using System.Collections.Generic;

namespace DocumentFactory
{
    public interface IDocument
    {
        List<IElement> Elements { get; set; }
        string ToString();
        void AddElement(IElement element);
        void RunDocument();
    }
}