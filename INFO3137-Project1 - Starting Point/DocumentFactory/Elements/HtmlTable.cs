using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Elements
{
    public class HtmlTable : IElement
    {
        public List<string> Head { get; set; }
        public List<string> Rows { get; set; }
       

        public HtmlTable(string tableData)
        {
            Parse(tableData);
        }

        private void Parse(string tableData)
        {
            string[] split = tableData.Split(';');

            foreach(string data in split)
            {
                string[] section = data.Split('$');
                if(section[0] == "Head")
                {
                    foreach(string parsed in section)
                    {
                        this.Head.Add(parsed);
                    }
                }
                else // else its a row
                {
                    foreach(string parsed in section)
                    {
                        this.Rows.Add(parsed);
                    }
                }
            }
        }

    }
}
