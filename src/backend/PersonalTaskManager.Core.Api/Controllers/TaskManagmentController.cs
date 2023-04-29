using Microsoft.AspNetCore.Mvc;

namespace PersonalTaskManager.Core.Api.Controllers;

[ApiController]
[Route("api/v0/tasks")]
public class TaskManagmentController : ControllerBase
{
    private IRepository<Task> tasks;

    public TaskManagmentController(IRepository<Task> tasks)
    {
        this.tasks = tasks;
    }

    [HttpGet()]
    public ActionResult<List<Task>> GetAll()
    {
        return Ok(this.tasks.GetAll());
    }

    [HttpPost()]
    [Route("add")]
    public IActionResult AddTask([FromBody]Task task)
    {
        this.tasks.Add(task);
        return Created("tasks",task);
    }
}
