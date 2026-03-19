using Person.Models;

namespace Person.Routes;

public static class PersonRoute
{
    public static void PersonRoutes( this WebApplication app)
    {
        app.MapGet("person", () => new PersonModel("Jon"));
        // post, put, delete, patch
    }
}