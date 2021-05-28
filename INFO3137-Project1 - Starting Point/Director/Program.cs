using DocumentFactory.Factories;
using System.IO;
using System.Text.RegularExpressions;


namespace Director
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] commands;
            var list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');

            foreach (var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
            var commandList = strippedCommand.Split(':');
                switch (commandList[0])
                {
                    case "Document":
                        // Your document creation code goes here
                        if(commandList[1] == "Html")
                        {
                            CreateDocument(new HtmlFactory());
                        }
                        break;
                    case "Element":
                        // Your element creation code goes here
                        break;
                    case "Run":
                        // Your document running code goes here
                        break;
                    default:
                        break;
                }
            }
        }

        static void CreateDocument(IDocumentFactory factory)
        {
            var document = factory.CreateDocument("whatever.html");
        }
    }
}
