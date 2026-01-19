using MediatR;

namespace RentalCar.Application.Features.CustomerFeatures.Get;

public sealed record CheckAvailabilityRequest(int CarId, DateTime StartDate, DateTime EndDate) : IRequest<bool>;