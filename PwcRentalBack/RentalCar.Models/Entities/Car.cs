using RentalCar.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.Domain.Entities;

public class Car : BaseEntity
{
	public int? ServiceId { get; set; }

	[ForeignKey("ServiceId")]
	public virtual ICollection<ServiceModel> Services { get; set; }

	public string Type { get; set; }

	public string Brand { get; set; }

	public string Model { get; set; }
}
