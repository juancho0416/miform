using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace form.Pages;

public class ZeroThirdModel : PageModel
{


    [BindProperty]
    public FormInput Input { get; set; } = new FormInput();

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        //TempData 
        TempData["Seccion"] = Input.Seccion;
        TempData["Regulacion"] = Input.Regulacion;
        TempData["Ley"] = Input.Ley;
        TempData["Articulo"] = Input.Articulo;
        TempData["Parrafo"] = Input.Parrafo;
        TempData["Legislacion"] = Input.Legislacion;


        //redirige a la pagina (Third)

        return RedirectToPage("ThirdOne");
    }

    public class FormInput
    {
        [Required(ErrorMessage = "Es necesario seleccionar el area del tramite a realizar")]
        [Display(Name = "Seccion")]
        public string Seccion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar una regulacion")]
        [Display(Name = "Regulacion")]
        public string Regulacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar una ley")]
        [Display(Name = "Ley")]
        public string Ley { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar un articulo")]
        [Display(Name = "Articulo")]
        public string Articulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Es necesario seleccionar un parrafo de el articulo")]
        [Display(Name = "Parrafo")]
        public string Parrafo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar una legislacion")]
        [Display(Name = "Legislacion")]
        public string Legislacion { get; set; } = string.Empty;
    }


}