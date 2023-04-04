class TaskRepository : IRepository<Task>
{
    private readonly IEnumerable<Task> tasks;
    public TaskRepository(IEnumerable<Task> tasks)
    {
        this.tasks = tasks;
    }
    public void Add(Task entity)
    {
        this.tasks.Append(entity);
    }

    public Task Get(string id)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyCollection<Task> GetAll()
    {
        throw new NotImplementedException();
    }
}