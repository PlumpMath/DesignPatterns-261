using System;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace DP.Common.Attributes
{
    public class PatternIconAttribute:Attribute
    {
        public PatternIconAttribute(Type resourceType, string propertyName)
        {
            var iconProperty = resourceType.GetProperty(propertyName, BindingFlags.Static | BindingFlags.NonPublic);
            Icon = iconProperty.GetValue(null,null) as Icon;
        }

        public Icon Icon { get; private set; }
    }
}
