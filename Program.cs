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
    },
    new()
    {
        Id = 2,
        FirstName = "James",
        LastName = "Joyce",
        Email = "modernist@literature.com",
        Bio = "Known for stream of consciousness.",
        Username = "JoyceFan",
        Password = "j0yceStream!",
        CreatedOn = DateTime.Now,
        Active = true
    },
    new()
    {
        Id = 3,
        FirstName = "Franz",
        LastName = "Kafka",
        Email = "metamorphosis@kafka.com",
        Bio = "Wrote about existential anxieties.",
        Username = "Kafkaesque",
        Password = "k4fka!@2024",
        CreatedOn = DateTime.Now,
        Active = true
    },
    new()
    {
        Id = 4,
        FirstName = "Gabriel",
        LastName = "García Márquez",
        Email = "magicrealism@macondo.com",
        Bio = "Master of magical realism.",
        Username = "MacondoMagic",
        Password = "g@m34rc!ez",
        CreatedOn = DateTime.Now,
        Active = false
    },
    new()
    {
        Id = 5,
        FirstName = "Haruki",
        LastName = "Murakami",
        Email = "surreal@murakami.com",
        Bio = "Writes surreal and fantastical fiction.",
        Username = "MurakamiFan",
        Password = "1Q2w3e4r!",
        CreatedOn = DateTime.Now,
        Active = true
    },
    new()
{
    Id = 6,
    FirstName = "Margaret",
    LastName = "Atwood",
    Email = "dystopian@atwood.com",
    Bio = "Known for her speculative fiction and dystopian novels.",
    Username = "AtwoodFan",
    Password = "M@rg@ret2024!",
    CreatedOn = DateTime.Now,
    Active = true
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

