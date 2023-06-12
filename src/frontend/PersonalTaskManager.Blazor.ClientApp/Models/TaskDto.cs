public class TaskDto
{
	public string Id { get; init; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string? Description { get; set; }
	public bool IsDone { get; set; }
}