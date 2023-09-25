

using BPark.Api.Controllers;
using BPark.Core.Interface;
using BPark.infrastructure.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Agregar aquí la línea de registro de servicios.
        builder.Services.AddTransient<IPostRepository, PostRepository>();
      //  builder.Services.AddTransient<IPostRepository, PostRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
