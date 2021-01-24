using System.Collections.Generic;

namespace SalesWebMvcUpdate.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; } //não sei porque não instanciou ela... min 5 aula 257
    }
}
