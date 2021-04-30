using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAppProject.Tokenizer
{

    
    public class TokenizerManager
    {
        public List<Token> Load(string sourceCode)
        {
            string input = sourceCode;
            Tokenizer t = new Tokenizer(new Input(input), new Tokenizable[] {
                new NumberTokenizer(),
            });

            List<Token> tokens = t.all();
            return tokens;
            
        }
    }
}
