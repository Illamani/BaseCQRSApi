using RentalCar.Domain.Common;

namespace RentalCar.Domain.Entities
{
	public class Customer : BaseEntity
	{
		public string FirstName { get; set; }

		public string LastName{ get; set; }

		public string Address { get; set; }
	}
}
