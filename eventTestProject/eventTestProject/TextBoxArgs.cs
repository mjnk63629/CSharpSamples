using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventTestProject
{
    public class TextBoxArgs : EventArgs
    {
        public TextBoxArgs()
        {
            
        }

        public TextBoxArgs(TextContent content)
        {
            this.Content = content;
        }
        public TextContent Content { get; set; }

    }
}
