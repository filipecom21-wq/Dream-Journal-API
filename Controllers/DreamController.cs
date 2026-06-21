using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DreamController : ControllerBase
{
    private readonly DreamService _dreamService;

    public DreamController(DreamService dreamService)
    {
        _dreamService = dreamService;
    }

    [HttpGet]
    public ActionResult<List<Dream>> GetDreams()
    {
        return Ok(_dreamService.GetAllDreams());
    }

    [HttpPost]
    public ActionResult<Dream> CreateDream(Dream dream)
    {
        try
        {
            _dreamService.AddDream(dream);
            return CreatedAtAction(nameof(GetDream), new { id = dream.Id }, dream);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public ActionResult<Dream> UpdateDream(int id, Dream updatedDream)
    {

        try
        {
            updatedDream.Id = id; // Garante que o ID do sonho atualizado seja o mesmo do caminho
            bool updated = _dreamService.UpdateDream(updatedDream);
            if (updated)
            {
                return Ok(updatedDream);
            }
            return NotFound();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> DeleteDream(int id)
    {
        bool deleted = _dreamService.DeleteDream(id);
        if (deleted)
        {
            return NoContent();
        }
        return NotFound();
    }

    [HttpGet("{id}")]
    public ActionResult<Dream> GetDream(int id)
    {
        var dream = _dreamService.GetDreamById(id);
        if (dream != null)
        {
            return Ok(dream);
        }
        return NotFound();
    }
}