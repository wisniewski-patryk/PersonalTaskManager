internal interface ITasksCrudService
{
	Task Add(TaskDto task);
	Task<IReadOnlyCollection<TaskDto>> GetAll();
	Task Update(string id, TaskDto task);
	Task Delete(string id);
}

class TasksCrudService : ITasksCrudService
{
	private readonly HttpClient httpClient;

	public TasksCrudService(HttpClient httpClient)
	{
		this.httpClient = httpClient;
	}

	public async Task Add(TaskDto task)
	{
		
	}

	public async Task Delete(string id)
	{
		throw new NotImplementedException();
	}

	public async Task<IReadOnlyCollection<TaskDto>?> GetAll()
	{
		var response = await this.httpClient.GetAsync("/api/v0/tasks");
		var taskList = await System.Text.Json.JsonSerializer.DeserializeAsync<IReadOnlyCollection<TaskDto>>(response.Content.ReadAsStream());
		return taskList;
	}

	public async Task Update(string id, TaskDto task)
	{
		throw new NotImplementedException();
	}
}
