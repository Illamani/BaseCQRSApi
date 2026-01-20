using MediatR;
using RentalCar.Domain.Dto.RentalSystem.Input;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RegisterRentalFeatures.Add;

public sealed record NewRentalRequest(RegisterRentalInput RegisterRental) : IRequest<Rental>;