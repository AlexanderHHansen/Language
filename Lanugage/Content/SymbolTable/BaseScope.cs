using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content.SymbolTable
{
    public class BaseScope : IScope
    {
        public IScope? EnclosingScope { get; set; }

        public Dictionary<string, Symbol> Symbols { get; set; }

        //Only use this to create the global scope
        public BaseScope()
        {
            Symbols = new Dictionary<string, Symbol>();
        }

        public BaseScope(IScope enclosingScope)
        {
            Symbols = new Dictionary<string, Symbol>();
            EnclosingScope = enclosingScope;
        }

        public void DefineSymbol(Symbol symbol)
        {
            if (Symbols.ContainsKey(symbol.Name)) {
                throw new ArgumentException("duplicate symbol " + symbol.Name);
            }
            Symbols.Add(symbol.Name, symbol);
        }

        public void UpdateSymbolType(string name, int type)
        {
            Symbol s = Symbols[name];
            s.Type = type;
            Symbols[name] = s;
        }

        public Symbol? GetSymbol(string name)
        {
            try
            {
                Symbol s = Symbols[name];
                return s;
            }
            catch (Exception)
            {
                // symbol not in scope
                // if not here, check any enclosing scope
                if (EnclosingScope != null) return EnclosingScope.GetSymbol(name);
                return null;
            }
            
            // Below return statement only happens when symbol is not found in globalscope
            return null;
        }
    }
}
