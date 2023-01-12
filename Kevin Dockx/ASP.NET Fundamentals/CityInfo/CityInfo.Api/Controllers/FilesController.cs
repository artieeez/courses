using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.Api.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider
                ?? throw new ArgumentNullException(nameof(fileExtensionContentTypeProvider));
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            var path = "cv_artur_webber_de_oliveira.pdf";

            if (!System.IO.File.Exists(path))
            {
                return NotFound();
            }

            if (!_fileExtensionContentTypeProvider.TryGetContentType(path, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, contentType, Path.GetFileName(path));
        }
    }
}
