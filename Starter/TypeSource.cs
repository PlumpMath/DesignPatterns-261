using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.ILSpy;
using Mono.Cecil;
using System.Reflection;
using System.IO;
using ICSharpCode.Decompiler;
using ICSharpCode.ILSpy.VB;

namespace Starter
{
    public class TypeSource
    {
        public TypeSource(TypeDefinition typeDefenition)
        {
            TypeDef = typeDefenition;
            SourceCode = GetCodeForAllLanguages();
        }
        public TypeDefinition TypeDef { get; private set; }
        public IDictionary<Language,string> SourceCode { get; private set; }

        public static IEnumerable<TypeSource> GetTypesSourceCode(Type type)
        {
            var assembly = Assembly.GetAssembly(type);
            var assemblyDefenition = Mono.Cecil.AssemblyDefinition.ReadAssembly(assembly.Location);
            CSharpLanguage lang = new CSharpLanguage();
            foreach (var module in assemblyDefenition.Modules)
            {
                foreach (var typeDef in module.GetTypes().Where(ft => ft.CustomAttributes.Count(ca => ca.AttributeType.Name == "PatternSourceCodeAttribute") > 0))
                {
                    yield return new TypeSource(typeDef);
                }
            }
        }

        private string GetCode(Language language)
        {
            StringBuilder sb = new StringBuilder();
            using (var sw = new StringWriter(sb))
            {
                var output = new PlainTextOutput(sw);
                DecompilationOptions dcOptions = new DecompilationOptions() { FullDecompilation = true };
                language.DecompileType(TypeDef, output, dcOptions);
            }
            return sb.ToString();
        }

        private IDictionary<Language, string> GetCodeForAllLanguages()
        {
            var sources = new Dictionary<Language, string>();
            IList<Language> languages = new List<Language>()
            {
                new CSharpLanguage(),
                new VBLanguage(),
                new ILLanguage(true)
            };
            foreach (var language in languages)
            {
                sources.Add(language, GetCode(language));
            }
            return sources;
        }

        public override string ToString()
        {
            return TypeDef.Name;
        }

    }
}
