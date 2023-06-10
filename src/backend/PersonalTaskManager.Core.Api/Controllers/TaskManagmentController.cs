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

    [HttpGet]
    [Route("{id}")]
    public ActionResult<Task?> Get(string id)
    {
        return this.tasks.Get(id);
    }

    [HttpPost()]
    [Route("add")]
    public IActionResult Add([FromBody]Task task)
    {
        this.tasks.Add(task);
        return Created("tasks", task);
    }

    [HttpPatch]
    [Route("{id}/update")]
    public IActionResult Update([FromBody]Task task, string id)
    {
        this.tasks.Patch(task, id);
        return Ok();
    }

    [HttpDelete]
    [Route("{id}/delete")]
    public IActionResult Delete(string id)
    {
        this.tasks.Delete(id);
        return Ok();
    }
}
