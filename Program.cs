namespace SimpleTokenizer {
    public sealed class Program {
        static void Main() {
            while (true) {
                Console.Write("> ");

                var line = Console.ReadLine();

                if (!string.IsNullOrEmpty(line)) {
                    var token = Tokenizer(line);

                    if (line == token.Name) {
                        Console.WriteLine($"found token : {token.Kind}");
                    }
                }

                Console.WriteLine();
            }
        }

        static Token Tokenizer(string tokenName) {

            switch (tokenName) {
                case "foo":
                    return new Token(TokensKind.FooToken, tokenName);
                case "bar":
                    return new Token(TokensKind.BarToken, tokenName);
                default:
                    Console.WriteLine($"Token {tokenName} is not recognized");
                    return new Token(TokensKind.BadToken, tokenName);
            }

        }
    }
}