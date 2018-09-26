using System.Collections.Generic;

namespace CachedRepository.Data.Models
{
	public class VehicleManufacturer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<VehicleModel> Models { get; set; }
	}
}
