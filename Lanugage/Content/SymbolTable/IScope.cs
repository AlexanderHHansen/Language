using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content.SymbolTable
{
    public interface IScope
    {
        Scope getEnclosingScope();

        void setEnclosingScope(Scope scope);

        void defineSymbol(Symbol symbol);

        Symbol getSymbol(String name);
    }
}
