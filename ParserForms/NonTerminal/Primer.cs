namespace ParserForms
{
    public class Prime : NonTerminal
    {

        private Digit digit;
        public override bool TryDoForRule(TokenAnalyzer tokenAnalyzer, ref float value)
        {
            bool minus = false;
            for (;;)
            {
                TokenType token;
                while ((token = tokenAnalyzer.GetNextToken()) == TokenType.Subtraction)
                {
                    if (digit == null)
                    {
                        minus = !minus;

                    }
                    else
                    {
                        tokenAnalyzer.BackTrack();
                        return true;
                    }
                }

                tokenAnalyzer.BackTrack();

                while ((token = tokenAnalyzer.GetNextToken()) == TokenType.Number)
                {
                    if (digit == null)
                    {
                        digit = new Digit();

                    }
                    digit.TryDoForTerminal(tokenAnalyzer, ref value, false, minus);
                }
               
                tokenAnalyzer.BackTrack();

                if (digit == null)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
        }
    }
}
