using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CategoriasModel : PageModel
    {
        public List<Categoria> Categorias { get; set; } = new();
        public void OnGet()
        {
            for (var i = 0; i <= 100; i++)
            {
                Categorias.Add(new Categoria(i, $"Categoria {i}", i * 18.95M));
            }
        }

    }

        public record Categoria(
        int Id,
        string Titulo,
        decimal Preco);

}
