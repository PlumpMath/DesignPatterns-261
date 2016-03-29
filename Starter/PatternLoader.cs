using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Common;
using ICSharpCode.ILSpy;
using ICSharpCode.Decompiler;

namespace Starter
{
    public class PatternLoader
    {
        public IEnumerable<Type> GetPatternTypes()
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

        public void GetSourceCode(Type type)
        {
            var assembly = Assembly.GetAssembly(type);
            var assemblyDefenition = Mono.Cecil.AssemblyDefinition.ReadAssembly(assembly.Location);
            CSharpLanguage lang = new CSharpLanguage();
            foreach (var m in assemblyDefenition.Modules)
            {
                foreach(var t in m.GetTypes().Where(ft=>ft.CustomAttributes.Count(ca=>ca.AttributeType.Equals(typeof(PatternSourceCodeAttribute)))>0))
                {
                    ITextOutput
                    lang.DecompileType(t,)
                    //t.Methods[0].b
                }
            }
            
        }
    }
}
