using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;

namespace RentalCar.Application.Features.CustomerFeatures.Get;

public sealed class CheckAvailabilityHandler(IRentalRepository rentalRepository) : IRequestHandler<CheckAvailabilityRequest, bool>
{
    public async Task<bool> Handle(CheckAvailabilityRequest request, CancellationToken cancellationToken)
    {
        return await rentalRepository.CheckAvailabilityAsync(request, cancellationToken);
	}
}
