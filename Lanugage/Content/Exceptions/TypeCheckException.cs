using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content.Exceptions
{
    public class TypeCheckException : Exception
    {
        public TypeCheckException(string message) : base(message) { }
    }
}
