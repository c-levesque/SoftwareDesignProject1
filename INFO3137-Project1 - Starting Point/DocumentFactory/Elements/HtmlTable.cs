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
        public List<List<string>> Rows { get; set; }


        public HtmlTable(string tableData)
        {
            Head = new List<string>();
            Rows = new List<List<string>>();
            Parse(tableData);
        }

        private void Parse(string tableData)
        {
            string[] split = tableData.Split(';');

            foreach(string data in split)
            {
                string[] section = data.Split('$');

                if (section[0] == "Head")
                {
                    for (int index = 0; index < section.Length; index++)
                    {
                        Head.Add(section[index]);
                    }
                }
                else if (section[0] == "Row")
                {
                    List<string> Row = new List<string>();
                    for (int index = 0; index < section.Length; index++)
                    {
                        Row.Add(section[index]);
                    }
                    Rows.Add(Row);
                }
                else
                {
                    continue;
                }
            }
        }


        public override string ToString()
        {
            string returnString = $"<table>";

            // add header
            returnString += $"<thead><tr>";
            foreach(string s in Head)
            {
                if(s != "Head")
                {
                    returnString += $"<th>{s}</th>";
                }
            }
            returnString += $"</tr></thead>";
           
            // add table rows
            foreach(List<string> row in Rows)
            {
                returnString += $"<tr>";
                foreach(string s in row)
                {
                    if(s != "Row")
                    {
                        returnString += $"<td>{s}</td>";
                    }
                }
                returnString += $"</tr>";
            }

            return returnString += $"</table>";

        }
    }
}
