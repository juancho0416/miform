using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace form.Pages;

public class SecondModel : PageModel
{


    [BindProperty]
    public FormInput Input { get; set; } = new FormInput();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        TempData["Nombre"] = Input.Nombre;
        TempData["RFC"] = Input.RFC;
        TempData["CURP"] = Input.CURP;
        TempData["Folio"] = Input.Folio;
        TempData["Phone"] = Input.Phone;
        // Redirige a la pagina 2 y el tempdata guarda lo que seleccionamos para la pagina 3 mostrarlos
        return RedirectToPage("TwoFive");
    }

    public class FormInput
    {

        /// vvalidaciones con regx de estos datos de la primer parte del formulario
        [Required(ErrorMessage = "Nombre completo requerido")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚÜÑáéíóúüñ'´`-]{2,}(?:\s+[A-Za-zÁÉÍÓÚÜÑáéíóúüñ'´`-]+)*$",
        ErrorMessage = "El nombre contiene caracteres no permitidos o es demasiado corto")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} requerido")]
        [RegularExpression(@"^(?=.*\d{7,15})[0-9+\-\s()]+$",
        ErrorMessage = "El numero de telefono contiene caracteres no permitidos o es demasiado corto")]
        [Display(Name = "Telefono celular")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "RFC requerido ")]
        [RegularExpression(@"^[A-Z]{3,4}\d{6}[A-Z0-9]{3}$",
        ErrorMessage = "El RFC No tiene el formato valido")]
        [Display(Name = "RFC")]
        public string RFC { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} requerido")]
        [RegularExpression(@"^[A-Z]{4}\d{6}[HM][A-Z]{5}[A-Z0-9]\d$",
        ErrorMessage = "El formato del CURP no es valido")]
        [Display(Name = "CURP")]
        public string CURP { get; set; } = string.Empty;

        [Required(ErrorMessage = "Folio requerido")]
        [RegularExpression(@"^[1-9]{8}",
        ErrorMessage = "El folio no tiene el formato valido")]
        [Display(Name = "Folio")]
        public string Folio { get; set; } = string.Empty;

    }
}



