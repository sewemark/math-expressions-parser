namespace ParserForms
{
    public class ExpresionPrim : NonTerminal
    {
        private Term term;
        private ExpresionPrim expresionPrime;

        public ExpresionPrim()
        {

        }

        public override bool TryDoForRule(TokenAnalyzer tokenAnalyzer, ref float value)
        {
            term = new Term();
            expresionPrime = new ExpresionPrim();
            for (;;)
            {
                TokenType token = tokenAnalyzer.GetNextToken();

                if (token == TokenType.Addition)
                {
                    float rightPart = 0.0f;
                    if (!term.TryDoForRule(tokenAnalyzer, ref rightPart))
                    {
                        return false;
                    }
                    value += rightPart;

                    if (!expresionPrime.TryDoForRule(tokenAnalyzer, ref value))
                    {
                        return false;
                    }

                    return true;
                }

                else if (token == TokenType.Subtraction)
                {
                    float rightPart = 0.0f;
                    if (!term.TryDoForRule(tokenAnalyzer, ref rightPart))
                    {
                        return false;
                    }
                    value -= rightPart;
                    if (!expresionPrime.TryDoForRule(tokenAnalyzer, ref value))
                    {
                        return false;
                    }
                    return true;
                }

                else
                {
                    tokenAnalyzer.BackTrack();
                    return true;
                }
            }
        }
    }
}
