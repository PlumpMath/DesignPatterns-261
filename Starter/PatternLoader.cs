using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Common;
using ICSharpCode.ILSpy;
using ICSharpCode.Decompiler;
using ICSharpCode.ILSpy.TextView;
using ICSharpCode.ILSpy.VB;
using Mono.Cecil;

namespace Starter
{
    public class PatternLoader
    {
        public static IEnumerable<Type> GetPatternTypes()
        {
            List<Type> patternTypes = new List<Type>();
            var patternsDomain = AppDomain.CreateDomain("PatternsDomain");
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            foreach (var file in di.GetFiles().Where(f=>f.Name.EndsWith(".dll") || f.Name.EndsWith(".exe")))
            {
                try
                {
                    Assembly assembly =  patternsDomain.Load(AssemblyName.GetAssemblyName(file.Name));
                    patternTypes.AddRange(assembly.GetTypes().Where(t => t.GetInterface("IPattern")!=null));
                }
                catch (Exception)
                {
                    //logging
                }
            }
            AppDomain.Unload(patternsDomain);
            return patternTypes;
        }

        public IEnumerable<TypeSource> GetSourceCode(Type type)
        {
            var assembly = Assembly.GetAssembly(type);
            var assemblyDefenition = Mono.Cecil.AssemblyDefinition.ReadAssembly(assembly.Location);
            CSharpLanguage lang = new CSharpLanguage();
            foreach (var m in assemblyDefenition.Modules)
            {
                foreach(var t in m.GetTypes().Where(ft=>ft.CustomAttributes.Count(ca=>ca.AttributeType.Name=="PatternSourceCodeAttribute")>0))
                {
                    yield return new TypeSource() { Type = t, SourceCode = GetCodeForAllLanguages(t) };
                }
            }

        }

        private string GetCode(Language language,TypeDefinition typeDef)
        {
            StringBuilder sb = new StringBuilder();
            using (var sw = new StringWriter(sb))
            {
                var output = new PlainTextOutput(sw);
                DecompilationOptions dcOptions = new DecompilationOptions() { FullDecompilation = true };
                language.DecompileType(typeDef, output, dcOptions);
            }
            return sb.ToString();
        }

        private IDictionary<Language, string> GetCodeForAllLanguages(TypeDefinition typeDef)
        {
            var sources = new Dictionary<Language,string>();
            IList<Language> languages = new List<Language>()
            {
                new CSharpLanguage(),
                new VBLanguage(),
                new ILLanguage(true)
            };
            foreach (var language in languages)
            {
                sources.Add(language,GetCode(language,typeDef));
            }
            return sources;
        }
    }
}
