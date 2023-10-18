using ScoreSystem.Domin;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddAppService();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.MapDefaultControllerRoute();
app.Run();