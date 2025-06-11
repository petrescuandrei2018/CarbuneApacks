var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ✅ AICI vine corect configurat endpoint-ul SEO + default
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "ReviewuriLemn",
        pattern: "reviewuri/carbuni-lemn",
        defaults: new { controller = "Website", action = "ReviewuriCarbuniLemn" }
    );

    endpoints.MapControllerRoute(
        name: "CarbuneLemn",
        pattern: "produse/carbuni-lemn",
        defaults: new { controller = "Website", action = "CarbuneLemn" }
    );

    endpoints.MapControllerRoute(
        name: "CarbuneCocos",
        pattern: "produse/carbuni-cocos",
        defaults: new { controller = "Website", action = "CarbuneCocos" }
    );

    // Default route
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Website}/{action=Index}/{id?}"
    );
});

app.Run();
