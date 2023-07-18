using System.Text.Json;
using System.Xml.Serialization;

namespace JSON_XML;

public class JsonProcessor
{
    private string Path { get; set; }

    public JsonProcessor(string path)
    {
        Path = path;
    }
    

    public string Parce()
    {
        try
        {
            Squad? squad;
            using (var file = new StreamReader(Path))
            {
                squad = JsonSerializer.Deserialize<Squad>(file.ReadToEnd());
            }
            
            using (var xmlFile = new FileStream(System.IO.Path.ChangeExtension(Path, ".xml"), FileMode.CreateNew))
            {
                new XmlSerializer(typeof(Squad)).Serialize(xmlFile, squad);
            }
            
            return "Done";
        }
        catch (Exception e)
        {
            return e.ToString();
        }
    }
}