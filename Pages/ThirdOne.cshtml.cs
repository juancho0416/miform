using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace form.Pages
{
    public class ThirdOneModel : PageModel
    {
        public string? Seccion { get; set; }
        public string? Regulacion { get; set; }
        public string? Ley { get; set; }
        public string? Articulo { get; set; }
        public string? Parrafo { get; set; }
        public void OnGet()
        {
            //primera parte del formuylario
            Seccion = TempData["Seccion"]?.ToString();
            Regulacion = TempData["Regulacion"]?.ToString();
            Ley = TempData["Ley"]?.ToString();
            Articulo = TempData["Articulo"]?.ToString();
            Parrafo = TempData["Parrafo"]?.ToString();
            TempData.Keep();
        }
        //redirige a la página de k ya ha sido completado la Fourth
        public IActionResult OnPost()
        {
            Seccion = TempData["Seccion"]?.ToString();
            Regulacion = TempData["Regulacion"]?.ToString();
            Ley = TempData["Ley"]?.ToString();
            Articulo = TempData["Articulo"]?.ToString();
            Parrafo = TempData["Parrafo"]?.ToString();

            return RedirectToPage("/Fourth");
        }
    }
}























