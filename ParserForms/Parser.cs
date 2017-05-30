namespace ParserForms
{
    public class Parser
    {
        public Parser()
        {
        }

        public bool Parse(TokenAnalyzer tokenAnalyzer, ref float result)
        {
            return new Expresion().TryDoForRule(tokenAnalyzer, ref result);
        }
    }
}
