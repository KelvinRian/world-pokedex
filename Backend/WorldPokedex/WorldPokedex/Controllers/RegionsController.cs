using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace WorldPokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : Controller
    {
        private static IWebHostEnvironment _enviroment;

        public RegionsController(IWebHostEnvironment enviroment)
        {
            _enviroment = enviroment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task Create([FromForm] IFormFile coverImage)
        {
            try
            {
                // Se não existe um diretório para as imagens, cria um.
                if (!Directory.Exists(_enviroment.WebRootPath + "\\images\\"))
                {
                    Directory.CreateDirectory(_enviroment.WebRootPath + "\\images\\");
                }

                // Criamos um arquivo no diretório e guardamos ele na variável fileStream.
                using (FileStream fileStream = System.IO.File.Create(_enviroment.WebRootPath + "\\images\\" +  coverImage.FileName))
                {
                    //CopyToAsync copia o conteúdo de coverImage para o arquivo na variável fileStream
                    await coverImage.CopyToAsync(fileStream);
                    fileStream.Flush();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
