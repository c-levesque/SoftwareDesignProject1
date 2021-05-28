using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Factories
{
    public class MarkdownFactory : IDocumentFactory
    {
        public IDocument CreateDocument(string fileName)
        {
            throw new NotImplementedException();
        }

        public IElement CreateElement(string elementType, string props)
        {
            throw new NotImplementedException();
        }
    }
}
