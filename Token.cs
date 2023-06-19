namespace SimpleTokenizer {
    public struct Token {

        public TokensKind Kind { get; }
        public string Name { get; }

        public Token(TokensKind kind, string name) {
            Kind = kind;
            Name = name;
        }
    }
}