using MediatR;
using RentalCar.Domain.Dto.Rental;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Add;
public sealed record RegisterRentalRequest(Rental Rental) : IRequest<Rental>;
