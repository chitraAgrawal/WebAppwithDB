using WebAppwithDB.Services;

var builder = WebApplication.CreateBuilder(args);
// Register services
builder.Services.AddControllersWithViews(); // Equivalent to AddMvc()
builder.Services.AddTransient<CourseService>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Course}/{action=Index}/{id?}");
});

app.Run();
