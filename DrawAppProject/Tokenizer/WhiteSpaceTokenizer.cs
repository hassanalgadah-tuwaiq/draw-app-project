﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAppProject.Tokenizer
{
    public class WhiteSpaceTokenizer : Tokenizable
    {
        public WhiteSpaceTokenizer()
        {
            isOptional = true;
        }

        public override bool tokenizable(Tokenizer t)
        {
            return Char.IsWhiteSpace(t.input.peek());
        }
        static bool isWhiteSpace(Input input)
        {
            return Char.IsWhiteSpace(input.peek());
        }
        public override Token tokenize(Tokenizer t)
        {
            return new Token(t.input.Position, t.input.LineNumber,
                TokenType.WhiteSpace, t.input.loop(isWhiteSpace));
        }
    }
}
