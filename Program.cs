using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

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
        CreatedOn = new DateTime(2024, 07, 10),
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
        CreatedOn = new DateTime(2024, 07, 26),
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
        CreatedOn = new DateTime(2024, 07, 14),
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
        CreatedOn = new DateTime(2024, 07, 19),
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
        CreatedOn = new DateTime(2024, 07, 22),
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
        CreatedOn = new DateTime(2024, 07, 16),
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
        Title = "Mr. Bennett and Mrs. Brown",
        PublicationDate = new DateTime(1924, 05, 18),
        Content = "Mr. Bennett says that it is only if the characters are real that the novel has any chance of surviving. Otherwise, die it must. But, I ask myself, what is reality? And who are the judges of reality?"
    },
    new() 
    {
        Id = 2,
        UserId = 6,
        CategoryId = 4,
        Title = "Pride and Prejudice",
        PublicationDate = new DateTime(1813, 04, 11),
        Content = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife."
    },
    new() 
    {
        Id = 3,
        UserId = 3,
        CategoryId = 4,
        Title = "Moby-Dick",
        PublicationDate = new DateTime(1851, 11, 21),
        Content = "Call me Ishmael. Some years ago, never mind how long precisely, having little or no money in my purse, and nothing particular to interest me on shore, I thought I would sail about a little and see the watery part of the world."
    },    
    new() 
    {
        Id = 4,
        UserId = 2,
        CategoryId = 3,
        Title = "Jane Eyre",
        PublicationDate = new DateTime(1813, 04, 11),
        Content = "There was no possibility of taking a walk that day. We had been wandering, indeed, in the leafless shrubbery an hour in the morning; but since dinner (Mrs. Reed, when there was no company, dined early) the cold winter wind had brought with it clouds so sombre, and a rain so penetrating, that further outdoor exercise was now out of the question."
    },    
    new() 
    {
        Id = 5,
        UserId = 3,
        CategoryId = 2,
        Title = "100 Years of Solitude ",
        PublicationDate = new DateTime(1943, 07, 15),
        Content = "Many years later, as he faced the firing squad, Colonel Aureliano Buendía was to remember that distant afternoon when his father took him to discover ice."
    },    
    new() 
    {
        Id = 6,
        UserId = 4,
        CategoryId = 1,
        Title = "Wuthering Heights",
        PublicationDate = new DateTime(1967, 03, 15),
        Content = "I have just returned from a visit to my landlord, the solitary neighbour that I shall be troubled with."
    },    
    new() 
    {
        Id = 7,
        UserId = 5,
        CategoryId = 6,
        Title = "The Adventures of Sherlock Holmes",
        PublicationDate = new DateTime(1847, 05, 19),
        Content = "To Sherlock Holmes she is always the woman. I have seldom heard him mention her under any other name."
    },    
    new() 
    {
        Id = 8,
        UserId = 4,
        CategoryId = 4,
        Title = "Dracula",
        PublicationDate = new DateTime(1897, 06, 06),
        Content = "Dracula was a man who was born in the year 1431 in the land of Transylvania."
    },    
    new() 
    {
        Id = 9,
        UserId = 2,
        CategoryId = 3,
        Title = "Frankenstein",
        PublicationDate = new DateTime(1818, 04, 23),
        Content = "You will rejoice to hear that no disaster has accompanied the commencement of an enterprise which you have regarded with such evil forebodings."
    },    
    new() 
    {
        Id = 10,
        UserId = 1,
        CategoryId = 2,
        Title = "The Picture of Dorian Gray",
        PublicationDate = new DateTime(1890, 05, 17),
        Content = "The studio was filled with the rich odor of roses, and the air was warm with the scent of the flowers."
    },    new() 
    {
        Id = 11,
        UserId = 5,
        CategoryId = 4,
        Title = "Alice's Adventures in Wonderland",
        PublicationDate = new DateTime(1865, 04, 14),
        Content = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do; once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice, 'without pictures or conversations?"
    },
};

List<PostTag> postTags = new()
{
    new() { Id = 1, PostId = 1, TagId = 3 },
    new() { Id = 2, PostId = 1, TagId = 6 },
    new() { Id = 3, PostId = 2, TagId = 5 },
    new() { Id = 4, PostId = 4, TagId = 6 },
    new() { Id = 5, PostId = 5, TagId = 1 },
    new() { Id = 6, PostId = 8, TagId = 4 }
};

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>
(
    options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.MapGet("/users", () =>
{
    return users.OrderBy(user => user.Username);
});

app.MapGet("users/{id}", (int id) =>
{
    User user = users.FirstOrDefault(u => u.Id == id);
    if (user == null)
    {
        return Results.NotFound("User Not Found");
    }
    return Results.Ok(user);
});

app.MapGet("/posts", () =>
{
    foreach (Post post in posts)
    {
        post.User = users.FirstOrDefault(u => u.Id == post.UserId);
        post.Category = categories.FirstOrDefault(c => c.Id == post.CategoryId);
        post.Tags = tags
            .Where(t => postTags.Any(pt => pt.TagId == t.Id && pt.PostId == post.Id))
            .ToList();
    }
    return posts.OrderByDescending(post => post.PublicationDate);
});

app.MapGet("/posts/{id}", (int id) =>
{
    Post post = posts.FirstOrDefault(post => post.Id == id);
    if (post == null)
    {
        return Results.NotFound("Post Not Found");
    }
    post.User = users.FirstOrDefault(u => u.Id == post.UserId);
    post.Category = categories.FirstOrDefault(c => c.Id == post.CategoryId);
    post.Tags = tags
        .Where(t => postTags.Any(pt => pt.TagId == t.Id && pt.PostId == id))
        .ToList();
    return Results.Ok(post);

});

app.MapGet("/posts/categories/{id}", (int id) =>
{
    if (!categories.Any(c => c.Id == id))
    {
        return Results.NotFound("Category Not Found");
    }
    
    List<Post> postsByCategory = posts
        .Where(post => post.CategoryId == id)
        .OrderByDescending(post => post.PublicationDate)
        .ToList();
    foreach (Post post in postsByCategory)
    {
        post.User = users.FirstOrDefault(u => u.Id == post.UserId);
        post.Category = categories.FirstOrDefault(c => c.Id == post.CategoryId);
        post.Tags = tags
            .Where(t => postTags.Any(pt => pt.TagId == t.Id && pt.PostId == post.Id))
            .ToList();
    }

    return Results.Ok(postsByCategory);
});

app.MapGet("/posts/tags/{id}", (int id) =>
{
    if (!tags.Any(t => t.Id == id))
    {
        return Results.NotFound("Tag Not Found");
    }

    List<Post> postsByTag = posts
        .Where(p => postTags.Any(pt => pt.PostId == p.Id && pt.TagId == id))
        .OrderByDescending(post => post.PublicationDate)
        .ToList();
    foreach (Post post in postsByTag)
    {
        post.User = users.FirstOrDefault(u => u.Id == post.UserId);
        post.Category = categories.FirstOrDefault(c => c.Id == post.CategoryId);
        post.Tags = tags
            .Where(t => postTags.Any(pt => pt.TagId == t.Id && pt.PostId == post.Id))
            .ToList();
    }

    return Results.Ok(postsByTag);
});

app.MapGet("/posts/users/{id}", (int id) =>
{
    if (!users.Any(u => u.Id == id))
    {
        return Results.NotFound("User Not Found");
    }

    List<Post> postsByUser = posts
        .Where(post => post.UserId == id)
        .OrderByDescending(post => post.PublicationDate)
        .ToList();
    foreach (Post post in postsByUser)
    {
        post.User = users.FirstOrDefault(u => u.Id == post.UserId);
        post.Category = categories.FirstOrDefault(c => c.Id == post.CategoryId);
        post.Tags = tags
            .Where(t => postTags.Any(pt => pt.TagId == t.Id && pt.PostId == post.Id))
            .ToList();
    }

    return Results.Ok(postsByUser);
});

app.MapPost("/posts", (Post post) => 
{
    post.Id = posts.Max(p => p.Id) + 1;
    posts.Add(post);
    return post;
});

app.MapPut("/posts/{id}", (int id, Post post) => 
{
    Post postToUpdate = posts.FirstOrDefault(p => p.Id == id);
    int postIndex = posts.IndexOf(postToUpdate);

    if (postToUpdate == null)
    {
        return Results.NotFound("Post Not Found");
    }
    if (id != post.Id)
    {
        return Results.BadRequest("Post Id does not match URI");
    }
    posts[postIndex] = post;
    return Results.Ok(post);
});

app.MapDelete("/posts/{id}", (int id) => 
{
    Post? postToDelete = posts.FirstOrDefault(p => p.Id == id);
    if (postToDelete == null)
    {
        return Results.BadRequest();
    }
    postTags.RemoveAll(pt => pt.PostId == id);
    posts.Remove(postToDelete);
    return Results.Ok();
});

app.MapGet("/categories", () =>
{
    return Results.Ok(categories.OrderBy(category=> category.Label));
});

app.MapGet("/categories/{id}", (int id) =>
{
    Category category = categories.FirstOrDefault(c => c.Id == id);
    if (category == null)
    {
        return Results.NotFound("Category Not Found");
    }
    return Results.Ok(category);
});

app.MapPost("/categories", (Category category) =>
{
    category.Id = categories.Max(c => c.Id) + 1;
    categories.Add(category);
    return Results.Ok(category);
});

app.MapPut("/categories/{id}", (int id, Category category) =>
{
    Category categoryToUpdate = categories.FirstOrDefault(c => c.Id == id);

    if (id != category.Id)
    {
        return Results.BadRequest("Category Id does not match URI");
    }
    else if (categoryToUpdate == null)
    {
        categories.Add(category);
    }
    else
    {
        int categoryIndex = categories.IndexOf(categoryToUpdate);
        categories[categoryIndex] = category;
    };

    return Results.Ok(category);
});

app.MapDelete("/categories/{id}", (int id) =>
{
    if (categories.FirstOrDefault(c => c.Id == id) == null)
    {
        return Results.BadRequest();
    }
    categories.RemoveAll(c => c.Id == id);
    return Results.Ok();
});

app.MapGet("/tags", () =>
{
    return Results.Ok(tags.OrderBy(tag => tag.Label));
});

app.MapGet("/tags/{id}", (int id) =>
{
    Tag tag = tags.FirstOrDefault(t => t.Id == id);
    if (tag == null)
    {
        return Results.NotFound("Tag Not Found");
    }
    tag.Posts = posts
        .Where(p => postTags.Any(pt => pt.PostId == p.Id && pt.TagId == id))
        .ToList();
    return Results.Ok(tag);
});

app.MapPost("/tags", (Tag tag) =>
{
    tag.Id = tags.Max(t => t.Id) + 1;
    tags.Add(tag);
    return Results.Ok(tag);
});

app.MapPut("/tags/{id}", (int id, Tag tag) =>
{
    Tag? tagToUpdate = tags.FirstOrDefault(t => t.Id == id);

    if (tagToUpdate == null)
    {
        return Results.NotFound("Tag Not Found");
    }
    else if (id != tag.Id)
    {
        return Results.BadRequest("Tag Id does not match URI");
    }

    int tagIndex = tags.IndexOf(tagToUpdate);
    tags[tagIndex] = tag;
    return Results.Ok(tag);
});

app.MapDelete("/tags/{id}", (int id) =>
{
    if (tags.FirstOrDefault(t => t.Id == id) == null)
    {
        return Results.BadRequest();
    }
    postTags.RemoveAll(t => t.TagId == id);
    tags.RemoveAll(t => t.Id == id);
    return Results.Ok();
});

app.MapPost("/postTags", (PostTag postTag) =>
{
    postTag.Id = postTags.Max(pt => pt.Id) + 1;
    postTags.Add(postTag);
    return Results.Ok(postTag);
});

app.MapDelete("/postTags/{postId}/{tagId}", (int postId, int tagId) =>
{
    PostTag? postTagToDelete = postTags.FirstOrDefault(pt => pt.PostId == postId && pt.TagId == tagId);
    if (postTagToDelete == null)
    {
        return Results.BadRequest();
    }
    postTags.Remove(postTagToDelete);
    return Results.Ok();
});

app.MapGet("/postTags", () =>
{
    return Results.Ok(postTags);
});

app.Run();
