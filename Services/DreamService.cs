public class DreamService
{
    private readonly JsonDatabase _jsonDatabase;
    private readonly List<Dream> _dreams;

    private int nextId = 1;

    public DreamService(JsonDatabase jsonDatabase)
    {
        _jsonDatabase = jsonDatabase;
        _dreams = _jsonDatabase.Load<Dream>();
        if (_dreams.Count > 0)
        {
            nextId = _dreams.Max(d => d.Id) + 1;
        }
    }

    private void ValidateDream(Dream dream)
    {
        if (string.IsNullOrWhiteSpace(dream.Title) || string.IsNullOrWhiteSpace(dream.Description))
        {
            throw new ArgumentException("Title and Description cannot be null or empty.");
        }
        if (dream.LucidityLevel < 1 || dream.LucidityLevel > 10)
        {
            throw new ArgumentException("Lucidity Level must be between 1 and 10.");
        }
    }

    public void AddDream(Dream dream)
    {
        ValidateDream(dream);

        dream.Id = nextId++;
        _dreams.Add(dream);
        _jsonDatabase.Save(_dreams);
    }

    public List<Dream> GetAllDreams()
    {
        return _dreams;
    }

    public Dream? GetDreamById(int id)
    {
        return _dreams.FirstOrDefault(d => d.Id == id);
    }

    public bool UpdateDream(Dream updatedDream)
    {
        ValidateDream(updatedDream);

        var existingDream = GetDreamById(updatedDream.Id);
        if (existingDream != null)
        {
            existingDream.Title = updatedDream.Title;
            existingDream.Description = updatedDream.Description;
            existingDream.Date = updatedDream.Date;
            existingDream.LucidityLevel = updatedDream.LucidityLevel;
            _jsonDatabase.Save(_dreams);
            return true;
        }
        return false;
    }

    public bool DeleteDream(int id)
    {
        var dreamToRemove = GetDreamById(id);
        if (dreamToRemove != null)
        {
            _dreams.Remove(dreamToRemove);
            _jsonDatabase.Save(_dreams);
            return true;
            
        }
        return false;
    }

        
    
}