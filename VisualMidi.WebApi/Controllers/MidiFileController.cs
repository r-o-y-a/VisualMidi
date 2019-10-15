using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VisualMidi.Core.Entities;
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
    }
}
