using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Lanugage.Content.SymbolTable;

namespace Lanugage.Content
{
    public partial class SymbolTableVisitor : SimpleBaseVisitor<object>
    {
        // https://pages.cs.wisc.edu/~fischer/cs536.s08/course.hold/html/NOTES/6.SYMBOL-TABLES.html
        // https://github.com/humleflue/P4/blob/master/ANTLR/src/Compiler/SymbolTableGenerator/SymbolTableGeneratorListener.java

        private ParseTreeProperty<Scope> Scopes;
        private Scope CurrentScope;

        private List<Dictionary<string, Types.Type>> Table;

        public SymbolTableVisitor()
        {
            Table = new List<Dictionary<string, Types.Type>>();
            Scopes = new ParseTreeProperty<Scope>();
            CurrentScope = new Scope();
        }

        void EnterScope()
        {
            Table.Append(new Dictionary<string, Types.Type>());
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
