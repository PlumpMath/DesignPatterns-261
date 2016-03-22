using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Common;

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

        public IPattern GetPattern(Type type)
        {
            return Activator.CreateInstance(type) as IPattern;
        }
    }
}
