namespace Shitty502
{
    internal class Lexer
    {
        public Lexer()
        {

        }

        public List<Tokens.Token> LexCode(string code)
        {
            List<Tokens.Token> result = [];

            string[] lines = code.Split("\n");

            int linesLength = lines.Length;
            for (uint lineNumber = 0; lineNumber < linesLength; lineNumber++)
            {
                string line = lines[lineNumber].Trim();
                string[] tokenTexts = line.Split(" ");

                foreach (string tokenText in tokenTexts)
                {
                    result.Add(new(tokenText, lineNumber));
                }
            }

            return result;
        }
    }
}
