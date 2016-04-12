using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DP.Common.Attributes
{
    public class PatternIconAttribute:Attribute
    {
        public PatternIconAttribute(Icon icon)
        {
            PatternIcon = icon;
        }
        public Icon PatternIcon { get; private set; }

    }
}
