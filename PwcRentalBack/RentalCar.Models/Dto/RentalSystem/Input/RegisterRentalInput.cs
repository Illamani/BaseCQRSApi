namespace RentalCar.Domain.Dto.RentalSystem.Input;

public sealed record RegisterRentalInput(DateTime StartDate, DateTime EndDate, int CarId, int CustomerId);
