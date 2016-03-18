using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Starter
{
    public class PatternLoader
    {
        public IEnumerable<Type> GetPatternNames()
        {
            IEnumerable<Type> patternTypes = null;
            var patternsDomain = AppDomain.CreateDomain("PatternsDomain");
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            foreach (var file in di.GetFiles().Where(f=>f.Name.EndsWith(".dll") || f.Name.EndsWith(".exe")))
            {
                try
                {
                    Assembly assembly =  patternsDomain.Load(AssemblyName.GetAssemblyName(file.Name));
                    patternTypes =  assembly.GetTypes().Where(t => t.GetInterface("IPattern")!=null);
                }
                catch (Exception)
                {
                    //logging
                }
            }
            AppDomain.Unload(patternsDomain);
            //var ttt = Activator.CreateInstance(patternTypes.ElementAtOrDefault(0));
            return patternTypes;
        }
    }
}
