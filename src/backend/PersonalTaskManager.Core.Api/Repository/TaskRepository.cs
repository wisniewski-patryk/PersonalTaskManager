class TaskRepository : IRepository<Task>
{
    private readonly List<Task> tasks;
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
        this.tasks.Append(entity);
    }

    public Task? Get(string id)
    {
        return this.tasks.FirstOrDefault( t => t.Id.ToString() == id);
    }

    public IReadOnlyCollection<Task> GetAll()
    {
        return this.tasks;
    }
}