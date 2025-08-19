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
                string fullLine = lines[lineNumber];
                string trimmedLine = fullLine.Trim();

                // Split text by spaces
                string[] tokenTexts = trimmedLine.Split(" ");

                foreach (string tokenText in tokenTexts)
                {
                    result.Add(new(tokenText, lineNumber));
                }
            }

            return result;
        }
    }
}
