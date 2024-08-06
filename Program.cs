var builder = WebApplication.CreateBuilder(args);

List<Category> categories = new()
{
    new() { Id = 1, Label = "Business" },
    new() { Id = 2, Label = "Health" },
    new() { Id = 3, Label = "Travel" },
    new() { Id = 4, Label = "Politics" },
    new() { Id = 5, Label = "Sports" },
    new() { Id = 6, Label = "Culture" },
    new() { Id = 7, Label = "Food" }
};
List<Tag> tags = new()
{
    new() { Id = 1, Label = "America" },
    new() { Id = 2, Label = "Olympics" },
    new() { Id = 3, Label = "Election" },
    new() { Id = 4, Label = "Budget" },
    new() { Id = 5, Label = "Fusion" },
    new() { Id = 6, Label = "Moscow" },
    new() { Id = 7, Label = "Europe" }
};
List<User> users = new()
{
    new()
    {
        Id = 1,
        FirstName = "Virginia",
        LastName = "Woolf",
        Email = "whosafraid@me.com",
        Bio = "Now deceased but still at it.",
        Username = "LoneWoolf",
        Password = "5%mythoughts41!",
        CreatedOn = DateTime.Now,
        Active = false
    }
};
List<Post> posts = new()
{
    new() 
    {
        Id = 1,
        UserId = 1,
        CategoryId = 6,
        Title = "Mr.Bennett and Mrs. Brown",
        PublicationDate = new DateTime(1924, 05, 18),
        Content = "Mr. Bennett says that it is only if the characters are real that the novel has any chance of surviving. Otherwise, die it must. But, I ask myself, what is reality? And who are the judges of reality?"
    }
};

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Run();

