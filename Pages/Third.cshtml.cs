using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;





namespace form.Pages;

public class ThirdModel : PageModel
{
    //Pagina 2 primera parte del formulario
    public string? Nombre { get; set; }

    public string? RFC { get; set; }
    public string? CURP { get; set; }
    public string? Folio { get; set; }
    public string? Phone { get; set; }

    //pagina 3 segunda parte formulario
    public string? Area { get; set; }
    public string? Empresa { get; set; }
    public string? ISO { get; set; }
    public string? NOM { get; set; }
    public string? Contrato { get; set; }
    public string? Requerimiento { get; set; }
    public string? Permiso { get; set; }
    public string? Peticion { get; set; }

    //parte 3 subir archivos
    public string? Archivo { get; set; }




    public void OnGet()
    {

        //primera parte del formuylario

        Nombre = TempData["Nombre"]?.ToString();
        RFC = TempData["RFC"]?.ToString();
        CURP = TempData["CURP"]?.ToString();
        Folio = TempData["Folio"]?.ToString();
        Phone = TempData["Phone"]?.ToString();

        //Segunda parte formulario
        Area = TempData["Area"]?.ToString();
        Empresa = TempData["Empresa"]?.ToString();
        ISO = TempData["ISO"]?.ToString();
        NOM = TempData["NOM"]?.ToString();
        Contrato = TempData["Contrato"]?.ToString();
        Requerimiento = TempData["Requerimiento"]?.ToString();
        Permiso = TempData["Permiso"]?.ToString();
        Peticion = TempData["Peticion"]?.ToString();

        //Parte 3 subir archivos
        Archivo = TempData["Archivo"]?.ToString();




        TempData.Keep();
    }

    //redirige a la página de k ya ha sido completado la Fourth
    public IActionResult OnPost()
    {
        Nombre = TempData["Nombre"]?.ToString();
        RFC = TempData["RFC"]?.ToString();
        CURP = TempData["CURP"]?.ToString();
        Folio = TempData["Folio"]?.ToString();
        Phone = TempData["Phone"]?.ToString();
        //segunda parte formulario
        Area = TempData["Area"]?.ToString();
        Empresa = TempData["Empresa"]?.ToString();
        ISO = TempData["ISO"]?.ToString();
        NOM = TempData["NOM"]?.ToString();
        Contrato = TempData["Contrato"]?.ToString();
        Requerimiento = TempData["Requerimiento"]?.ToString();
        Permiso = TempData["Permiso"]?.ToString();
        Peticion = TempData["Peticion"]?.ToString();

        ///Parte 3 subir Archivo
        Archivo = TempData["Archivo"]?.ToString();


        return RedirectToPage("/Fourth");
    }
}