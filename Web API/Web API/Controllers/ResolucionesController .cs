using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResolucionesController : ControllerBase
    {
        private readonly string carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "resoluciones");

        [HttpPost("upload")]
        public async Task<IActionResult> SubirArchivo(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Archivo inválido");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            string nombre = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string ruta = Path.Combine(carpeta, nombre);

            using (var stream = new FileStream(ruta, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            string url = $"{Request.Scheme}://{Request.Host}/resoluciones/{nombre}";

            return Ok(url); 
        }
    }
}
