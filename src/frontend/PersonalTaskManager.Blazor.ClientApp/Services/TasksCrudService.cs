using System.Text.Json;
using System.Net.Http.Json;

internal interface ITasksCrudService
{
	Task Add(TaskDto task);
	Task<IReadOnlyCollection<TaskDto>?> GetAll();
	Task<TaskDto?> Get(string id);
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
		var response = await httpClient.PostAsJsonAsync("api/v0/tasks/add", task);
		response.EnsureSuccessStatusCode();
	}

	public async Task Delete(string id)
	{
		var response = await this.httpClient.DeleteAsync($"api/v0/tasks/{id}/delete");
		response.EnsureSuccessStatusCode();
	}

	public async Task<TaskDto?> Get(string id)
	{
		var response = await this.httpClient.GetAsync($"api/v0/tasks/{id}");

		return await JsonSerializer.DeserializeAsync<TaskDto>(response.Content.ReadAsStream());
	}

	public async Task<IReadOnlyCollection<TaskDto>?> GetAll()
	{
		var response = await this.httpClient.GetAsync("api/v0/tasks");
		var taskList = await System.Text.Json.JsonSerializer.DeserializeAsync<IReadOnlyCollection<TaskDto>>(response.Content.ReadAsStream());
		return taskList;
	}

	public async Task Update(string id, TaskDto task)
	{
		var response = await this.httpClient.PatchAsJsonAsync($"api/v0/tasks/{id}/update", task);
		response.EnsureSuccessStatusCode();
	}
}
