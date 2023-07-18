using Spectre.Console;

namespace JSON_XML
{
    class ConsoleMenu
    {
        private static string? Path;
        public static void Run()
        {
            Path = AnsiConsole.Ask<string>("Input file path: ");
            
            DataProvider dataProvider = new DataProvider(Path);
            
            var filePath = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select [green]txt file[/]")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to select file)[/]")
                    .AddChoices(dataProvider.OutputOfExistingFiles()));
            
            JsonProcessor data = new JsonProcessor(filePath);
            Console.WriteLine(data.Parce());
        }
        
    }
    
    
}