using CachedRepository.Data.Models;
using CachedRepository.Data.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CachedRepository.Pages
{
	public class IndexModel : PageModel
    {
        private readonly IRepository<VehicleManufacturer> _repository;

        public IndexModel(IRepository<VehicleManufacturer> repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {

        }
    }
}
