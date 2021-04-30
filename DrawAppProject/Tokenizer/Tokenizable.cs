using System;
namespace DrawAppProject.Tokenizer
{
    public abstract class Tokenizable
    {
        public bool isOptional = false;
        public abstract bool tokenizable(Tokenizer tokenizer);
        public abstract Token tokenize(Tokenizer tokenizer);
    }
}