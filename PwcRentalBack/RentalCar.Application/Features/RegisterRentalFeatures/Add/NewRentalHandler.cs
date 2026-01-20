using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RegisterRentalFeatures.Add;

public sealed class NewRentalHandler(IRentalRepository rentalRepository) : IRequestHandler<NewRentalRequest, Rental>
{
	public async Task<Rental> Handle(NewRentalRequest request, CancellationToken cancellationToken)
    {
        var rental = new Rental
        {
            CarId = request.RegisterRental.CarId,
            CustomerId = request.RegisterRental.CustomerId,
            EndDate = request.RegisterRental.EndDate,
            StartDate = request.RegisterRental.StartDate,
        };
        await rentalRepository.CreateAsync(rental, cancellationToken);
        return rental;
    }
}