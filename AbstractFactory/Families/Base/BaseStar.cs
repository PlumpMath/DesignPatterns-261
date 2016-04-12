using System;
using System.Drawing;
using DP.Common;
using DP.Common.Attributes;

namespace DP.AbstractFactory.Families.Base
{
    [PatternSourceCode]
    public abstract class BaseStar : BaseElement
    {
        public override string Text
        {
            get { return "Star"; }
        }        
    }
}
