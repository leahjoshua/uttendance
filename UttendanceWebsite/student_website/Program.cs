using Microsoft.EntityFrameworkCore;
using student_website.Components;
using student_website.Services;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 11, 2025
 * parisa added some lines
    NetID: JXY200013 and PXN210032
*/
//Detect the Database Connection
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);

builder.Services.AddScoped<SubmissionService>();
builder.Services.AddScoped<StudentService>();

/* Written by Parisa Nawar for CS 4485.0w1, CS Project, starting April 22, 2025
 * NetID: PXN210032
*/
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<UserConnectionInfoService>();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<HttpClient>();

// End writing

//Forwarded Header Middleware
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownNetworks.Clear();
    options.KnownProxies.Clear(); 
});

var app = builder.Build();

app.UseForwardedHeaders();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

//Get IP Address of Client
app.MapGet("/api/ip", (HttpContext ctx) =>
{
    var ip = ctx.Connection.RemoteIpAddress?.ToString();
    return Results.Ok(ip);
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();