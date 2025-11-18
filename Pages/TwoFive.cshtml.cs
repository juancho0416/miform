using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace form.Pages;

public class TwoFive : PageModel
{


    [BindProperty]
    public FormInput Input { get; set; } = new FormInput();



    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        ///datos con tempdata

        TempData["Area"] = Input.Area;
        TempData["Empresa"] = Input.Empresa;
        TempData["ISO"] = Input.ISO;
        TempData["NOM"] = Input.NOM;
        TempData["Contrato"] = Input.Contrato;
        TempData["Requerimiento"] = Input.Requerimiento;
        // TempData["Archivo"] = Input.Archivo;


        // Redirige a la pagina 3 y se le agregan estos campos de ke han sido completados 
        return RedirectToPage("TwoNine");


    }

    public class FormInput
    {
        ///Desplegables que no ocupan expresiones regular
        [Required(ErrorMessage = "Es necesario seleccionar un area ")]
        [Display(Name = "Area")]
        public string Area { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar una NOM")]
        [Display(Name = "NOM")]
        public string NOM { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar una ISO")]
        [Display(Name = "ISO")]
        public string ISO { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar un contrato")]
        [Display(Name = "Contrato")]
        public string Contrato { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar una empresa")]
        [Display(Name = "Empresa")]
        public string Empresa { get; set; } = string.Empty;

        // [Required(ErrorMessage = "Es necesario seleccionar un archivo")]
        // [Display(Name = "Archivo")]
        // public string Archivo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar un requerimiento")]
        [Display(Name = "Requerimiento")]
        public string Requerimiento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario selecciona un permiso")]
        [Display(Name = "Permiso")]
        public string Permiso { get; set; } = string.Empty;

        [Required(ErrorMessage = "Es necesario seleccionar una peticion")]
        [Display(Name = "Peticion")]
        public string Peticion { get; set; } = string.Empty;
        ///para guardar en db
        // [ActionName("Enviar")]
        // public IActionResult OnPostEnviar()
        // { }   
    }

}






