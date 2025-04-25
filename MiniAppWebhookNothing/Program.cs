
namespace MiniAppWebhookNothing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapPost("/webhook/delete-user", () =>
            {
                return Results.Json(new
                {
                    status = "ok",
                    message = "No user data stored. Nothing to delete."
                });
            });

            app.Run();

        }
    }
}
