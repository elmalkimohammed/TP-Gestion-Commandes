using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using TP_Gestion_Commandes.ViewModel;

namespace TP_Gestion_Commandes.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Home( CategorieVM obj )
        {

            if ( !ModelState.IsValid  )
            {
                return View();
            }

            MySqlConnection conn = new MySqlConnection("Host=localhost; Port=3309; Database=gestcommandes; Uid=root;");
            conn.Open();
            MySqlCommand commd = new MySqlCommand("INSERT INTO category ( Libelle ) VALUES ('" + obj.Libelle + "')", conn);
            commd.ExecuteNonQuery();
            conn.Close();

            return View();

        }
    }
}
