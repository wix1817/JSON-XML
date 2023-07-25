namespace JSON_XML;

public class DataProvider
{
    private string Path { get; set; }

    public DataProvider(string path)
    {
        Path = path;
    }

    public string[] OutputOfExistingFiles()
    {
        string[] files = Directory.GetFiles(@$"{Path}", "*.json");
        return files;
    }
        
    private string CheckPath(string path)
    {
        if (File.Exists(path))
        {
            try
            {
                Path = path;
                return Path;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        return "Error: FileNotExist";
    }
}