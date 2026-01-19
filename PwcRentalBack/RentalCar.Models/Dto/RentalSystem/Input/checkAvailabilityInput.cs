namespace RentalCar.Domain.Dto.RentalSystem.Input;

public sealed record CheckAvailabilityInput(string FullName, DateTime StartDate, DateTime EndDate, int CarId);