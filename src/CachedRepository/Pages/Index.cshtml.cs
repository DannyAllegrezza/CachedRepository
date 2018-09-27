using CachedRepository.Data.Models;
using CachedRepository.Data.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace CachedRepository.Pages
{
	public class IndexModel : PageModel
    {
        private readonly IRepository<VehicleManufacturer> _repository;
		public List<VehicleManufacturer> Manufacturers { get; set; }

        public IndexModel(IRepository<VehicleManufacturer> repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
			Manufacturers = _repository.GetAll().ToList();
        }
    }
}
