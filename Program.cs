using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure HTTP request pipeline
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.MapGet("/", async context =>
            {
                context.Response.Redirect("/index.html");
            });


            app.UseAuthorization();

          

            app.MapControllers();

            app.Run();
        }
    }
}
