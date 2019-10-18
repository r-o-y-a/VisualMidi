using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VisualMidi.Core.Models;
using VisualMidi.Core.Services;

namespace MidiVisualizer.Controllers
{
    [Route("api/midifiles")]
    [ApiController]
    public class MidiFileController : ControllerBase
    {
        private IMidiFileService _midiFileServce;

        private readonly ILogger<MidiFileController> _logger;

        public MidiFileController(IMidiFileService midiFileService, ILogger<MidiFileController> logger)
        {
            _midiFileServce = midiFileService;
            _logger = logger;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<MidiFile>> GetAllFiles()
        {
            var midiFiles = _midiFileServce.GetAllFiles();
            return midiFiles.ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm(Name = "midiFile")]IFormFile midiFile)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "midiFiles");

            using (var fileContentStream = new MemoryStream())
            {
                await midiFile.CopyToAsync(fileContentStream);
                await System.IO.File.WriteAllBytesAsync(Path.Combine(folderPath, midiFile.FileName), fileContentStream.ToArray());
            }
            return CreatedAtRoute(routeName: "midiFile", routeValues: new { filename = midiFile.FileName }, value: null);
        }
    }
}
