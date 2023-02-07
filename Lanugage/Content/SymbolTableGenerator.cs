using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Lanugage.Content
{
    public partial class SymbolTableGenerator : SimpleBaseVisitor<object>
    {
        // https://pages.cs.wisc.edu/~fischer/cs536.s08/course.hold/html/NOTES/6.SYMBOL-TABLES.html
        // https://github.com/humleflue/P4/blob/master/ANTLR/src/Compiler/SymbolTableGenerator/SymbolTableGeneratorListener.java

        private ParseTreeProperty<Scope> Scopes;
        private Scope CurrentScope;

        private List<Dictionary<string, Type>> Table;

        public SymbolTableGenerator()
        {
            Table = new List<Dictionary<string, Type>>();
            Scopes = new ParseTreeProperty<Scope>();
            CurrentScope = new Scope();
        }

        void EnterScope()
        {
            Table.Append(new Dictionary<string, Type>());
        }

        void ExitScope()
        {
            Table.RemoveAt(Table.Count - 1);
        }

        void Insert(ParserRuleContext token)
        {

        }

        void lookup(ParserRuleContext token)
        {

        }
    }
}
