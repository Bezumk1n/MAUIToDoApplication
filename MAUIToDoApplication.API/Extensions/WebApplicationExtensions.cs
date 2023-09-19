using MAUIToDoApplication.API.Data;
using MAUIToDoApplication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MAUIToDoApplication.API.Extensions
{
    public static class WebApplicationExtensions
    {
        public static WebApplication RegisterEndPoints(this WebApplication application)
        {
            application.MapGet("api/todo", async (AppDbContext context) =>
            {
                var items = await context.ToDos.ToListAsync();
                return Results.Ok(items);
            });
            application.MapPost("api/todo", async (AppDbContext context, ToDo todo) =>
            {
                await context.ToDos.AddAsync(todo);
                await context.SaveChangesAsync();
                return Results.Created($"api/todo/{todo.Id}", todo);
            });
            application.MapPut("api/todo/{id}", async (AppDbContext context, Guid id, ToDo toDo) =>
            {
                var toDoModel = await context.ToDos.FirstOrDefaultAsync(q => q.Id == id);
                if (toDoModel == null)
                    return Results.NotFound();
                toDoModel.ToDoName = toDo.ToDoName;
                await context.SaveChangesAsync();
                return Results.NoContent();
            });
            application.MapDelete("api/todo/{id}", async (AppDbContext context, Guid id) =>
            {
                var toDoModel = await context.ToDos.FirstOrDefaultAsync(q => q.Id == id);
                if (toDoModel == null)
                    return Results.NotFound(id);
                context.ToDos.Remove(toDoModel);
                await context.SaveChangesAsync();
                return Results.NoContent();
            });
            return application;
        }
    }
}
