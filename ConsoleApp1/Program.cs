using ConsoleApp1.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
.ConfigureServices((context, services) =>
{
    services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer("Data Source=(local); Initial Catalog=TechNova-ECommerce-A;Integrated Security=True;Encrypt=False")
    );
})
.Build();


//Data Source=(local); Initial Catalog=TechNova-ECommerce-A;Integrated Security=True;Encrypt=False