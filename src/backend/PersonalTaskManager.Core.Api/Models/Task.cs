public class Task : BaseEntity
{ 
    public Task() : base()
    {
    }
    public Task(string name) : base()
    {
        this.Name = name;
    }

    public Task(string name, string description) : base()
    {
        this.Name = name;
        this.Description = description;
    }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}