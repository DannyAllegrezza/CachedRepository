namespace CachedRepository.Data.Models
{
	public class VehicleModel
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int VehicleManufacturerId { get; set; }
		public VehicleManufacturer VehicleManufacturer { get; set; }
	}
}
