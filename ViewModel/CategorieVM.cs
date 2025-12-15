using System.ComponentModel.DataAnnotations;

namespace TP_Gestion_Commandes.ViewModel
{
    public class CategorieVM
    {
        [Required(ErrorMessage = "Invalid Typed Informations")]
        public String Libelle { get; set; }
    }
}
