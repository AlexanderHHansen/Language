using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content.Exceptions
{
    internal class UndeclaredVariableException : Exception
    {
        public UndeclaredVariableException(string message) : base(message) { }
    }
}
