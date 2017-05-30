using System;

namespace ParserForms
{
      public class TermPrime :NonTerminal
    {
        private Prime prime;
        private TermPrime termPrime;

        public override bool TryDoForRule(TokenAnalyzer tokenAnalyzer, ref float value)
        {
            termPrime = new TermPrime();
            prime = new Prime();
            for (;;)
            {
                TokenType token = tokenAnalyzer.GetNextToken();

                if (token == TokenType.Multiplication)
                {
                    float rightPart = 0.0f;

                    if (!prime.TryDoForRule(tokenAnalyzer, ref rightPart))
                    {
                        return false;
                    }

                    value *= rightPart;

                    if (!termPrime.TryDoForRule(tokenAnalyzer, ref value))
                    {
                        return false;
                    }

                    return true;
                }

               else if (token == TokenType.Division)
                {
                    float rightPart = 0.0f;

                    if (!prime.TryDoForRule(tokenAnalyzer, ref rightPart))
                    {
                        return false;
                    }

                    if (rightPart == 0)
                    {
                        return false;
                    }

                    value /= rightPart;

                    if (!termPrime.TryDoForRule(tokenAnalyzer, ref value))
                    {
                        return false;
                    }

                    return true;
                }

                else if (token == TokenType.Power)
                {
                    float rightPart = 0.0f;
                    if (!prime.TryDoForRule(tokenAnalyzer, ref rightPart))
                    {
                        return false;
                    }

                    value = (float)Math.Pow(value, rightPart);

                    if (!termPrime.TryDoForRule(tokenAnalyzer, ref value))
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
