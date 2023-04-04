using Microsoft.AspNetCore.Mvc;

namespace PersonalTaskManager.Core.Api.Controllers;

[ApiController]
[Route("api/v0")]
public class TaskManagmentController : ControllerBase
{
    private IRepository<Task> tasks;

    public TaskManagmentController(IRepository<Task> tasks)
    {
        this.tasks = tasks;
    }

    [HttpGet(Name = "tasks")]
    public ActionResult<List<Task>> GetAll()
    {
        return Ok(tasks);
    }
}
