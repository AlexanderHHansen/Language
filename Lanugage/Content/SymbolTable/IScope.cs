using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content.SymbolTable
{
    public interface IScope
    {
        IScope EnclosingScope { get; set; }

        void DefineSymbol(Symbol symbol);

        void UpdateSymbolType(string name, int type);

        Symbol? GetSymbol(string name);
    }
}
