using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawAppProject.Tokenizer;

namespace DrawAppProject.Engine
{
    public class DrawEngine
    {
        protected List<string> shapes = new List<string>();

        public DrawEngine()
        {

        }

        public DrawEngine ParseTokens(List<Token> tokens)
        {
            // parse
            // set shapes
            return this;
        }

        public string GetSourceCode()
        {
            // convert shapes to string 
            return "";

            //StringBuilder sb = new StringBuilder();

            //sb.AppendLine("#rect");
            //sb.Append("");
            //sb.Append(":");
            //sb.Append("Value");
            //sb.AppendLine("key:value");

            //sb.ToString()

        }
    }
}
