using System;
using System.Collections.Generic;

namespace DocumentFactory.Documents
{
    public class MarkdownDocument : IDocument
    {
        private static MarkdownDocument _instance;
        public string Name { get; set; }
        public List<IElement> Elements { get; set; }

        private MarkdownDocument()
        {
            Console.WriteLine("Markdown document created");
        }

        public static MarkdownDocument GetInstance()
        {
            if(_instance == null)
            {
                _instance = new MarkdownDocument();
            }
            return _instance;
        }
        public override string ToString()
        {
            return "I am the MARKDOWN object";
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