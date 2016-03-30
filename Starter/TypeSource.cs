using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.ILSpy;
using Mono.Cecil;

namespace Starter
{
    public class TypeSource
    {
        public TypeDefinition Type { get; set; }
        public IDictionary<Language,string> SourceCode { get; set; }
    }
}
