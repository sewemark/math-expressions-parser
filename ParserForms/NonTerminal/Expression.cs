namespace ParserForms
{
    public class Expresion : NonTerminal
    {
        Term term;
        ExpresionPrim expresionPrime;

        public Expresion()
        {

        }

        public override bool TryDoForRule(TokenAnalyzer tokenAnalyzer, ref float value)
        {
            term = new Term();
            expresionPrime = new ExpresionPrim();

            if (!term.TryDoForRule(tokenAnalyzer, ref value))
            {
                return false;
            }

            if (!expresionPrime.TryDoForRule(tokenAnalyzer, ref value))
            {
                return false;
            }

            return true;
        }
    }
}
