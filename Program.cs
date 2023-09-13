var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<UserService>();
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(x => x
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
    );
});
var app = builder.Build();

app.MapGet("/users", (UserService userService) => userService.Users);
app.MapGet("/", () => "Hello, thanks for watching my course!");

app.UseCors();
app.Run();
