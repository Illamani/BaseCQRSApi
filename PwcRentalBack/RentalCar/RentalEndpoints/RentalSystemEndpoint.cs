using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.CustomerFeatures.Add;
using RentalCar.Application.Features.CustomerFeatures.Get;
using RentalCar.Application.Features.RentalFeatures.Add;
using RentalCar.Domain.Dto.Customer;
using RentalCar.Domain.Dto.Rental;
using RentalCar.Domain.Dto.RentalSystem.Input;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Api.RentalEndpoints
{
    public sealed class RentalSystemEndpoint : ICarterModule
    {
        private static readonly CustomerMapper _customerMapper = new();

        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("registerCustomer", RegisterCustomerAsync);
            app.MapGet("checkAvailability", CheckAvailabilityAsync);
            app.MapPost("registerRental", RegisterRentalAsync);
            app.MapPut("modifyReservation", ModifyReservationAsync);
            app.MapDelete("cancelRental", CancelRentalAsync);
        }

        public  async Task<IResult> RegisterCustomerAsync([FromBody] CustomerInput customerInput, ISender sender, CancellationToken cancellationToken)
        {
            var customerAdded = await sender.Send(new CheckCustomerAddedRequest(customerInput), cancellationToken);
            if (customerAdded)
                return Results.BadRequest("This customer has already been register");

            var customer = _customerMapper.CustomerInputToCustomer(customerInput);
            var customers = await sender.Send(new AddCustomerRequest(customer), cancellationToken);
            return Results.Ok(customers);
        }

        public static async Task<IResult> CheckAvailabilityAsync([FromBody] CheckAvailabilityInput input, ISender sender, CancellationToken cancellationToken)
        {
            var availability = await sender.Send(new CheckAvailabilityRequest(input.CarId, input.StartDate, input.EndDate), cancellationToken);
            if (availability)
                return Results.Ok();

            return Results.BadRequest("This Car is not available for the period you want");
        }

        public static async Task<IResult> RegisterRentalAsync([FromBody] RegisterRentalInput rentalInput, ISender sender, CancellationToken cancellationToken)
        {
            //var register = await sender.Send(new RegisterRentalRequest(rentalInput), cancellationToken);

            return Results.Ok();
        }

        public static async Task<IResult> ModifyReservationAsync()
        {
            return Results.Ok();
        }

        public static async Task<IResult> CancelRentalAsync()
        {
            return Results.Ok();
        }
    }
}
