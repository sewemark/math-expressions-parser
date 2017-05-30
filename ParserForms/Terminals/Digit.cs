namespace ParserForms
{
    public class Digit : Terminal
    {
        public bool TryDoForTerminal(TokenAnalyzer tokenAnalyzer, ref float value, bool isFloat, bool isMinus)
        {
            if (isFloat)
            {
                value = float.Parse(value.ToString() + "," + tokenAnalyzer.GetNumber());
            }

            else
            {
                value = float.Parse(value.ToString() + tokenAnalyzer.GetNumber().ToString());
            }

            if (isMinus)
            {
                value *= -1;
            }

            return true;
        }
    }

    public abstract class Terminal
    {
        public bool TryDoForNonTerminal(TokenAnalyzer tokenAnalyzer, ref float value, bool isFloat)
        {
            return true;
        }
    }
}
