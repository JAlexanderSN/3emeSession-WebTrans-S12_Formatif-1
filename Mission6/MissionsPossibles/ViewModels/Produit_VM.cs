using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mission.Models;

namespace Mission.ViewModels
{
    public class Produit_VM
    {
        public Produit Produit { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> CategorieList { get; set; }


    }
}
