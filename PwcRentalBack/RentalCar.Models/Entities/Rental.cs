using RentalCar.Domain.Common;

namespace RentalCar.Domain.Entities
{
	public class Rental : BaseEntity
	{
		public int? CustomerId { get; set; }

		public virtual Customer	Customer { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int? CarId { get; set; }

		public virtual Car Car { get; set; }
	}
}
