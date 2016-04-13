using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DP.Common;
using ICSharpCode.ILSpy;
using ICSharpCode.Decompiler;
using ICSharpCode.ILSpy.TextView;
using ICSharpCode.ILSpy.VB;
using Mono.Cecil;
using System.ComponentModel;
using System.Drawing;
using DP.Common.Attributes;

namespace Starter
{
    public class PatternDescription
    {
        public PatternDescription(Type type)
        {
            PatternType = type;
            var dnAttr = type.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;
            DisplayName = dnAttr != null ? dnAttr.DisplayName : type.Name;
            var descrAttr = type.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
            Description = descrAttr != null ? descrAttr.Description : string.Empty;

            var iconAttr = type.GetCustomAttribute(typeof(PatternIconAttribute)) as PatternIconAttribute;
            Icon = iconAttr?.Icon;
        }
        public Type PatternType { get; private set; }
        public string DisplayName { get; private set; }
        public string Description { get; private set; }
        public Icon Icon { get; private set; }

        public static IEnumerable<PatternDescription> GetPatternDescription()
        {
            List<PatternDescription> patternTypes = new List<PatternDescription>();
            var patternsDomain = AppDomain.CreateDomain("PatternsDomain");
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            foreach (var file in di.GetFiles().Where(f=>f.Name.EndsWith(".dll") || f.Name.EndsWith(".exe")))
            {
                try
                {
                    Assembly assembly =  patternsDomain.Load(AssemblyName.GetAssemblyName(file.Name));
                    patternTypes
                        .AddRange(assembly.GetTypes().Where(t => t.GetInterface("IPattern") != null)
                        .Select(t => new PatternDescription(t)));
                }
                catch (Exception)
                {
                    //logging
                }
            }
            AppDomain.Unload(patternsDomain);
            return patternTypes.OrderBy(p => p.DisplayName);
        }

    }
}
