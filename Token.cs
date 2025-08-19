namespace Shitty502
{
    namespace Tokens
    {
        internal class Token
        {
            public Token(string _text = "", uint _lineNumber = 0, TokenType _type = TokenType.Invalid)
            {
                text = _text;
                lineNumber = _lineNumber;
                type = _type;
            }

            public uint lineNumber = 0;
            public uint charNumber = 0;
            public string text = "";
            public TokenType type = TokenType.Unknown;
        }
        enum TokenType
        {
            Operator,
            Address,
            Number,
            Comment,
            Label,
            Unknown,
            Invalid, // Has not been initialized yet
        }
    }
}
