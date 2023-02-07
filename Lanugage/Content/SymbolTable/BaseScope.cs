using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content.SymbolTable
{
    public class BaseScope : IScope
    {
        public Scope enclosingScope { get; private set; }

        protected Dictionary<string, Symbol> symbols = new Dictionary<string, Symbol>();

        //Only use this to create the global scope
        public BaseScope()
        {
        }

        public BaseScope(Scope enclosingScope)
        {
            setEnclosingScope(enclosingScope);
        }

        public Scope getEnclosingScope()
        {
            return this.enclosingScope;
        }

        
        public void setEnclosingScope(Scope scope)
        {
            this.enclosingScope = scope;
        }

        public void defineSymbol(Symbol symbol)
        {
            if (symbols.ContainsKey(symbol.Name)) {
                throw new ArgumentException("duplicate symbol " + symbol.Name);
            }
            symbols.Append(symbol.Name, symbol);
        }


        public Symbol getSymbol(String name)
        {
            Symbol s = symbols.get(name);
            if (s != null)
            {
                return s;
            }
            // if not here, check any enclosing scope
            if (this.enclosingScope != null) return this.enclosingScope.getSymbol(name);
            // Below return statement only happens when symbol is not found in globalscope
            return null;
        }
    }
}
