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
            List<string> Rows = new List<string>();

            foreach (string s in split)
            {
                string[] splitAgain = s.Split("$");
                if (splitAgain[0] == "Head")
                {
                    foreach (string parsed in splitAgain)
                    {
                        if (parsed != "Head")
                        {
                            Head.Add(parsed);
                        }
                    }
                }
                else // its the rows
                {

                    foreach (string parsed in splitAgain)
                    {
                        Rows.Add(parsed);
                    }
                }
            }


            IElement header = new HtmlHeader(1, "The Header");
            IElement image = new HtmlImage("img/csharp.png", "Alt Text", "Title Text");
            string[] data = {"item 1", "item 2", "item 3"};
            IElement list = new HtmlList("Unordered", data);
            Console.WriteLine(header.ToString());
            Console.WriteLine(image.ToString());
            Console.WriteLine(list.ToString());




            int x = 0;
       }
    }
}
