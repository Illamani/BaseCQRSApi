using Microsoft.EntityFrameworkCore;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository.ModelRepository;

public class CustomerRepository(RentalContext context) : BaseRepository<Customer>(context), ICustomerRepository
{
	public async Task<bool> CheckCustomerAdded(string firstName, string lastName, string Address)
	{
		return await context.Customers.AnyAsync(x => x.FirstName.ToLower().Trim() == firstName && x.LastName.ToLower().Trim() == lastName && x.Address.ToLower().Trim() == Address);
	}
}
