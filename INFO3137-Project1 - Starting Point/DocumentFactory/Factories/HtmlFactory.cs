using DocumentFactory.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Factories
{
    public class HtmlFactory : IDocumentFactory
    {
        public IDocument CreateDocument(string fileName)
        {
            IDocument document = HtmlDocument.GetInstance(fileName);
            return document;
        }

        public IElement CreateElement(string elementType, string props)
        {
            throw new NotImplementedException();
        }
    }
}
