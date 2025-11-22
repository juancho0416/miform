using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace form.Pages
{

    public class ThirdTwoModel : PageModel
    {

        public string? Area { get; set; }
        public string? Empresa { get; set; }
        public string? ISO { get; set; }
        public string? NOM { get; set; }
        public string? Contrato { get; set; }
        public string? Solicitud { get; set; }
        public string? Requerimiento { get; set; }
        public string? Permiso { get; set; }
        public string? Peticion { get; set; }




        ///datos

        public string? Cliente { get; set; }
        public string? Estado { get; set; }
        public string? Municipio { get; set; }
        public string? Calle { get; set; }
        public string? Numero { get; set; }




        public void OnGet()
        {
            Area = TempData["Area"]?.ToString();
            Empresa = TempData["Empresa"]?.ToString();
            ISO = TempData["ISO"]?.ToString();
            NOM = TempData["NOM"]?.ToString();
            Contrato = TempData["Contrato"]?.ToString();
            Solicitud = TempData["Solicitud"]?.ToString();
            Requerimiento = TempData["Requerimiento"]?.ToString();
            Permiso = TempData["Permiso"]?.ToString();
            Peticion = TempData["Permiso"]?.ToString();


            ///datos
            Cliente = TempData["Cliente"]?.ToString();
            Estado = TempData["Estado"]?.ToString();
            Municipio = TempData["Municipio"]?.ToString();
            Calle = TempData["Calle"]?.ToString();
            Numero = TempData["Numero"]?.ToString();


            //guarda el tempp
            TempData.Keep();
        }


        public IActionResult OnPost()
        {
            Area = TempData["Area"]?.ToString();
            Empresa = TempData["Empresa"]?.ToString();
            ISO = TempData["ISO"]?.ToString();
            NOM = TempData["NOM"]?.ToString();
            Contrato = TempData["Contrato"]?.ToString();
            Solicitud = TempData["Solicitud"]?.ToString();
            Requerimiento = TempData["Requerimiento"]?.ToString();
            Permiso = TempData["Permiso"]?.ToString();
            Peticion = TempData["Peticion"]?.ToString();

            //datos//
            Cliente = TempData["Cliente"]?.ToString();
            Estado = TempData["Estado"]?.ToString();
            Municipio = TempData["Municipio"]?.ToString();
            Calle = TempData["Calle"]?.ToString();
            Numero = TempData["Numero"]?.ToString();


            //redirige a la ultima pagina 
            return RedirectToPage("Fourth");

        }




    }

}