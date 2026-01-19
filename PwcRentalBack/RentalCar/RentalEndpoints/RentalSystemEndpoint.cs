using Carter;

namespace RentalCar.Api.RentalEndpoints
{
    public sealed class RentalSystemEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("registerCustomer", RegisterCustomer);
            app.MapGet("checkAvailability", CheckAvailability);
            app.MapPost("registerRental", RegisterRental);
            app.MapPut("modifyReservation", ModifyReservation);
            app.MapDelete("cancelRental", CancelRental);
        }

        public static async Task<IResult> RegisterCustomer()
        {
            return Results.Ok();
        }

        public static async Task<IResult> CheckAvailability()
        {
            return Results.Ok();
        }

        public static async Task<IResult> RegisterRental()
        {
            return Results.Ok();
        }

        public static async Task<IResult> ModifyReservation()
        {
            return Results.Ok();
        }

        public static async Task<IResult> CancelRental()
        {
            return Results.Ok();
        }
    }
}
