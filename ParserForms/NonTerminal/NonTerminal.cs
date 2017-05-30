using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserForms
{
    public abstract class NonTerminal
    {

        public virtual bool TryDoForRule(TokenAnalyzer tokenAnalyzer, ref float value)
        {
            return true;
        }
    }
}
