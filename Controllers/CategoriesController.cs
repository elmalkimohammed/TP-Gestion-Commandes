using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using TP_Gestion_Commandes.Models;
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
        public IActionResult TargetPage()
        {
            MySqlConnection conn = new MySqlConnection("Host=localhost; Port=3309; Database=gestcommandes; Uid=root;") ;
            conn.Open();
            List<Category> list = new List<Category>();
            MySqlCommand commd = new MySqlCommand("SELECT * FROM Category" , conn ) ;
            MySqlDataReader tableReader = commd.ExecuteReader();
            while ( tableReader.Read() )
            {
                Category category = new Category() ;
                category.id = tableReader.GetInt32("id") ;
                category.libelle = tableReader.GetString("libelle") ;
                list.Add(category);
            }
            ViewBag.categsList = list ;
            conn.Close();
            return View();
        }
    }
}
