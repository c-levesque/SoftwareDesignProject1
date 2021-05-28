using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Elements
{
    public class HtmlList : IElement
    {
        public string ListType { get; set; }
        public bool IsOrdered { get; set; }
        public List<string> Data = new List<string>();

        public HtmlList(string listType, string [] data)
        {
            if (listType == "Ordered")
            {
                this.ListType = "ol";
            }
            else
            {
                this.ListType = "ul";
            }

            foreach (string d in data)
            {
                this.Data.Add(d);
            }
        }
        public override string ToString()
        {
            string returnString = $"<{ListType}>";
            foreach (string listItem in Data)
            {
                returnString += $"<li>{listItem}</li>";
            }
            returnString += $"</{ListType}>";

            return returnString;
        }
    }
}
