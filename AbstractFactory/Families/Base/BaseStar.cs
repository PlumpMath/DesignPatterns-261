using System;
using System.Drawing;
using DP.Common;

namespace AbstractFactory.Families.Base
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
