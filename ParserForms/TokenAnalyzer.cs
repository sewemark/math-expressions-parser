using System;

namespace ParserForms
{
    public class TokenAnalyzer
    {
        private string[] sentence;
        private int pointer;
        private int number;

        public TokenAnalyzer(string _sentence)
        {
            pointer = 0;
            sentence = _sentence.Split(' ');
        }

        public int GetNumber()
        {
            return number;
        }

        public void BackTrack()
        {
            if (pointer < 1)
            {
                throw new InvalidSyntaxException();
            }
            pointer--;
        }

        public TokenType GetNextToken()
        {

            TokenType token = TokenType.End;
            if (pointer >= sentence.Length)
            {
                token = TokenType.End;
                return token;
            }
            else if (sentence[pointer] == "+")
            {
                token = TokenType.Addition;
            }
            else if (sentence[pointer] == "-")
            {
                token = TokenType.Subtraction;
            }
            else if (sentence[pointer] == "*")
            {
                token = TokenType.Multiplication;
            }
           else  if (sentence[pointer] == "/")
            {
                token = TokenType.Division;
            }
           else if (sentence[pointer] == "^")
            {
                token = TokenType.Power;
            }
          else  if (sentence[pointer] == ".")
            {
                token = TokenType.Dot;
            }
            else if (Int32.TryParse(sentence[pointer], out number))
            {
                token = TokenType.Number;
            }
            else 
            {
                token = TokenType.Incorrect;
                throw new InvalidSyntaxException();
            }
            pointer++;
            return token;
        }
    }

    public enum TokenType
    {
        Number, Addition, Subtraction, Division, Power, Multiplication, Incorrect, Dot, End
    }
}
