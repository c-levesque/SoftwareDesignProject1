using DocumentFactory;
using DocumentFactory.Documents;
using DocumentFactory.Elements;
using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocument myItem = MarkdownDocument.GetInstance();
            IDocument myItem2 = HtmlDocument.GetInstance();

            Console.WriteLine(myItem.ToString());
            Console.WriteLine(myItem2.ToString());

            string test = "Head$Table Heading 1$Table Heading 2$Table Heading 3;Row$Some$Table$Text;Row$More$Table$Text;Row$Final$Table$Text";
            string[] split = test.Split(";");

            List<string> Head = new List<string>();
            List<List<string>> Rows = new List<List<string>>();


            foreach (string s in split)
            {
                string[] section = s.Split('$');

                if (section[0] == "Head")
                {
                    for (int index = 0; index < section.Length; index++)
                    {
                        Head.Add(section[index]);
                    }
                }
                else
                {
                    List<string> Row = new List<string>();
                    for (int index = 0; index < section.Length; index++)
                    {
                        Row.Add(section[index]);
                    }
                    Rows.Add(Row);
                }
            }

            IElement table = new HtmlTable(test);

            IElement header = new HtmlHeader(1, "The Header");
            IElement image = new HtmlImage("img/csharp.png", "Alt Text", "Title Text");
            string[] data = { "item 1", "item 2", "item 3" };
            IElement list = new HtmlList("Unordered", data);
            Console.WriteLine(header.ToString());
            Console.WriteLine(image.ToString());
            Console.WriteLine(list.ToString());
            Console.WriteLine(table.ToString());




            int x = 0;
        }


    }


}

