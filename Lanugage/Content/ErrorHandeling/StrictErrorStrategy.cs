using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content.ErrorHandeling
{
    public class StrictErrorStrategy : DefaultErrorStrategy
    {
        public override void Recover(Parser recognizer, RecognitionException e)
        {
            IToken token = recognizer.CurrentToken;
            string message = string.Format("parse error at line {0}, position {1} right before {2} ", token.Line, token.Column, GetTokenErrorDisplay(token));
            throw new Exception(message, e);
        }

        public override IToken RecoverInline(Parser recognizer)
        {
            IToken token = recognizer.CurrentToken;
            string message = string.Format("parse error at line {0}, position {1} right before {2} ", token.Line, token.Column, GetTokenErrorDisplay(token));
            throw new Exception(message, new InputMismatchException(recognizer));
        }


        public override void Sync(Parser recognizer) { }
    }
}
