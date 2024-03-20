using namespace form_MNJ;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MNJ_JobWebContext.cs>(p=>p.UseInMemoryDataBase("CandidatesDB"))


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Privacy",
    pattern: "{controller=Home}/{action=Privacy}/{id?}");
    
    app.MapControllerRoute(
    name: "Form",
    pattern: "{controller=Home}/{action=Form}/{id?}");
app.Run();
