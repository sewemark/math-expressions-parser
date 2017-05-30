namespace ParserForms
{
    public class Term : NonTerminal
    {
        private Prime primar;
        private TermPrime termPrime;

        public override bool TryDoForRule(TokenAnalyzer tokenAnalyzer, ref float value)
        {
            primar = new Prime();
            termPrime = new TermPrime();

            if (!primar.TryDoForRule(tokenAnalyzer, ref value))
            {
                return false;
            }

            if (!termPrime.TryDoForRule(tokenAnalyzer, ref value))
            {
                return false;
            }

            return true;
        }
    }
}
