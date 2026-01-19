using Microsoft.EntityFrameworkCore;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Context;

public class RentalContext(DbContextOptions<RentalContext> options) : DbContext(options)
{
	public DbSet<Car> Cars { get; set; }

	public DbSet<Customer> Customers { get; set; }

	public DbSet<Rental> Rentals { get; set; }

	public DbSet<ServiceModel> Services { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Car>(c =>
		{
			c.ToTable("Car");
			c.Property(c => c.ServiceId).IsRequired(false);
		});

		modelBuilder.Entity<Customer>()
			.ToTable("Customer");

		modelBuilder.Entity<Rental>(e =>
		{
			e.ToTable("Rental");
			e.HasOne(x => x.Customer).WithOne().HasForeignKey<Rental>(x => x.CustomerId).IsRequired(false);
			e.HasOne(x => x.Car).WithOne().HasForeignKey<Rental>(x => x.CarId).IsRequired(false);
		});

		modelBuilder.Entity<ServiceModel>()
			.ToTable("Service");
	}
}
