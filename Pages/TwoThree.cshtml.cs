using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace form.Pages;

public class TwoThreeModel : PageModel
{
    private readonly IWebHostEnvironment _env;
    public TwoThreeModel(IWebHostEnvironment env) => _env = env;




    //parte de subir archivos validos
    public string? Archivo { get; set; }
    public bool FileExists { get; set; }
    public string? UploadMessage { get; set; }

    // único OnGet: acepta parámetros opcionales (vienen por query string) o usa TempData
    public void OnGet(string? uploadedFile, string? message)
    {
        Archivo = !string.IsNullOrWhiteSpace(uploadedFile) ? uploadedFile : TempData["UploadedFile"] as string;
        UploadMessage = !string.IsNullOrWhiteSpace(message) ? message : TempData["UploadMessage"] as string;

        if (!string.IsNullOrWhiteSpace(Archivo))
        {
            var safeName = Path.GetFileName(Archivo);
            var uploads = Path.Combine(_env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "uploads");
            var fullPath = Path.Combine(uploads, safeName);

            FileExists = System.IO.File.Exists(fullPath);
            Archivo = safeName;
            if (!FileExists)
            {
                UploadMessage = "No se encontró el archivo subido.";
            }
            else
            {
                UploadMessage ??= "Archivo encontrado y listo para validar.";
            }
        }
        else
        {
            FileExists = false;
            UploadMessage ??= "No se recibió nombre de archivo.";
        }

        // deja valores en TempData si otras vistas los necesitan
        TempData["UploadedFile"] = Archivo;
        TempData["UploadMessage"] = UploadMessage;
    }

    // opcional: manejar POST de confirmación
    public IActionResult OnPostConfirm()
    {
        // ...acción de confirmación...
        return RedirectToPage("/Index");
    }










    public IActionResult OnPost()
    {
        //fecha

        //primera parte del formulario

        Archivo = TempData["Archivo"]?.ToString();








        return RedirectToPage("Fourth");

    }
}







