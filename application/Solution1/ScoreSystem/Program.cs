using Microsoft.Extensions.FileProviders;
using RazorLight;
using RazorLight.Extensions;
using ScoreSystem.Application;

namespace ScoreSystem;

class Program { 
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddAppService();
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddMvc();
        
        var engine = new RazorLightEngineBuilder()
            .UseEmbeddedResourcesProject(typeof(Program))
            .UseMemoryCachingProvider()
            .Build();
        
        builder.Services.AddSingleton(engine.Handler);
        builder.Services.AddRazorLight(() => engine);

        var app = builder.Build();

        app.MapDefaultControllerRoute();
        app.UseStaticFiles(new StaticFileOptions()
        {
            FileProvider = new PhysicalFileProvider(
                Path.Combine(builder.Environment.ContentRootPath, "Static")),
            RequestPath = "/StaticFiles"
        });
        app.Run();
    }
}