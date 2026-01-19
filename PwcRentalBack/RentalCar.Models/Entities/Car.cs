using RentalCar.Domain.Common;

namespace RentalCar.Domain.Entities;

public class Car : BaseEntity
{
	public int? ServiceId { get; set; }
	public virtual ICollection<ServiceModel> Services { get; set; }

	public string Type { get; set; }

	public string Brand { get; set; }

	public string Model { get; set; }
}
