using System;
using System.Collections.Generic;

namespace DocumentFactory.Documents
{
    public class HtmlDocument : IDocument
    {
        private static HtmlDocument _instance;

        public List<IElement> Elements { get; set; }

        public string FileName { get; set; }

        private HtmlDocument()
        {
            Console.WriteLine("Html document created");
        }

        public static HtmlDocument GetInstance(string fileName)
        {
            if (_instance == null)
            {
                _instance = new HtmlDocument();
                _instance.Elements = new List<IElement>();
                _instance.FileName = fileName;
            }
            return _instance;
        }
        public override string ToString()
        {
            return "I am the HTML object";
        }

        public void RunDocument()
        {
            // save document to file

            // run inside a browser

        }

        public void AddElement(IElement element)
        {
            if (element == null)
            {
                return;
            }
            Elements.Add(element);
        }
    }
}
