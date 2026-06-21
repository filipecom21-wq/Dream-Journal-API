public class DreamService
{
    private readonly List<Dream> _dreams;

    private int nextId = 1;

    public DreamService()
    {
        _dreams = new List<Dream>();
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
            return true;
        }
        return false;
    }

        
    
}