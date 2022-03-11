using BookRealm.Data;
using BookRealm.Data.Common;
using BookRealm.Data.Common.Repositories;
using BookRealm.Data.Models;
using BookRealm.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using BookRealm.Services;
using System.Reflection;
using BookRealm.Models;
using BookRealm.Services.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BookRealmDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<BookRealmDbContext>();
// Data repositories
builder.Services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IDbQueryRunner, DbQueryRunner>();

// Application services
//builder.Services.AddTransient<IEmailSender>(x => new SendGridEmailSender(this.configuration["SendGrid:ApiKey"]));
builder.Services.AddTransient<ICountService, CountService>();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
//builder.Services.AddTransient<ICategoriesService, CategoriesService>();
//builder.Services.AddTransient<IRecipesService, RecipesService>();
//builder.Services.AddTransient<IVotesService, VotesService>();
//builder.Services.AddTransient<IIngredientsService, IngredientsService>();
builder.Services.AddTransient<IDataGatherer, DataGatherer>();
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddControllersWithViews();

var app = builder.Build();
AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
