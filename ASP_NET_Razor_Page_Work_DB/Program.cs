using ASP_NET_Razor_Page_Work_DB.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
