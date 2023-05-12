class TaskRepository : IRepository<Task>
{
    private List<Task> tasks;

    public TaskRepository(List<Task> tasks)
    {
        this.tasks = tasks;
    }

    public TaskRepository()
    {
        this.tasks = new();
    }
    public void Add(Task entity)
    {
        this.tasks.Add(entity);
    }

    public Task? Get(string id)
    {
        return this.tasks.FirstOrDefault( t => t.Id.ToString() == id);
    }

    public IReadOnlyCollection<Task> GetAll()
    {
        return this.tasks;
    }

    public void Delete(string id)
    {
        var taskToDelete = this.tasks.FirstOrDefault(t => t.Id.ToString() == id) ?? throw new ArgumentNullException();
        this.tasks.Remove(taskToDelete);
    }

	public void Patch(Task entity, string id)
	{
		var taskToPatch = this.tasks.FirstOrDefault(t => t.Id.ToString() == id) ?? throw new ArgumentException();
        if (taskToPatch.Name != entity.Name)
        {
            taskToPatch.Name = entity.Name;
        }
        if (taskToPatch.Description != entity.Description)
        {
            taskToPatch.Description = entity.Description;
        }
	}
}