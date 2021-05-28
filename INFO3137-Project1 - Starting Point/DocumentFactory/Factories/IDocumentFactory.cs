
namespace DocumentFactory.Factories
{
    public interface IDocumentFactory
    {
        IDocument CreateDocument(string fileName);
        IElement CreateElement(string elementType, string props);
    }
}
