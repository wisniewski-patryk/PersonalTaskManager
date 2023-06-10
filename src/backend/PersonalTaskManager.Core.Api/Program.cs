var builder = WebApplication.CreateBuilder(args);

// Add CORS
var MyAllowSpecificOrgins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options => 
    {
        options.AddPolicy(name: MyAllowSpecificOrgins,
            policy => 
                {
                    policy.WithOrigins("http://localhost:5200");
                }
            );
    });

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add repository
builder.Services.AddSingleton<IRepository<Task>, TaskRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // NOTE: https://localhost:5250/swagger/index.html
    app.UseCors(MyAllowSpecificOrgins);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
