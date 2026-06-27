
using System.Text.Json;
using System.IO;
public class JsonDatabase
{

    private readonly string _filePath;


    public JsonDatabase(string filePath)
    {
        _filePath = filePath;
    }

    public void Save<T>(List<T> data)
    {
        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }

    public List<T> Load<T>()
    {
        if (!File.Exists(_filePath))
        {
            return new List<T>();
        }

        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
    }
}