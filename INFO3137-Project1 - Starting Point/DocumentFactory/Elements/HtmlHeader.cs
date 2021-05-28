using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Elements
{
    public class HtmlHeader : IElement
    {
        
        public int Size { get; set; }
        public string Data { get; set; }

        public HtmlHeader(int size, string data)
        {
            this.Size = size;
            this.Data = data;
        }

        public override string ToString()
        { 
            return $"<h{Size}>{Data}</h{Size}>";
        }
    }
}
