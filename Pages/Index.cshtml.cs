using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace form.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public LoginInput Input { get; set; } = new LoginInput();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Redirige a la pagina 3 y se le agregan estos campos de ke han sido completados 
        return RedirectToPage("ZeroSecond");
    }

    public class LoginInput
    {
        //regx para validar el correo y contraseña
        [Required(ErrorMessage = "Correo electronico requerido")]
        [RegularExpression(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$",
        ErrorMessage = "El correo electronico no tiene el formato válido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contraseña requerida")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.{8,})(?=.*\d)(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "La contraseña debe tener mínimo 8 caracteres, incluir mayúscula, minúscula y número")]
        public string Password { get; set; } = string.Empty;
    }
}