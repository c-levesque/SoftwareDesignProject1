using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Elements
{
    public class HtmlImage : IElement
    {
        public string Path { get; set; }
        public string AltText { get; set; }
        public string TitleText { get; set; }

        public HtmlImage(string path, string altText, string titleText)
        {
            this.Path = path;
            this.AltText = altText;
            this.TitleText = titleText;
        }
        public override string ToString()
        {
            return $"<img alt='{AltText}' title='{TitleText}' src='{Path}' /><br />";
        }
    }
}
