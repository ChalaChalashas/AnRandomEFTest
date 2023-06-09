using Microsoft.AspNetCore.Mvc;

namespace AnFolderApi;

[Route("api/[controller]")]
public class FolderController: Controller
{
    private readonly IFolderService _service;

    public FolderController(IFolderService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<FolderDto> AddFolder(FolderDto folder, int? parentId)
    {
        return Ok(_service.AddFolder(folder, parentId));
    }
    
    [HttpGet("{id:int}")]
    public ActionResult<IEnumerable<FolderDto>> GetFolderTree(int id)
    {
        return Ok(_service.GetFolder(id));
    }

    [HttpGet("tree")]
    public ActionResult<IEnumerable<FolderDto>> GetFolderTree()
    {
        return Ok(_service.GetTree());
    }
}