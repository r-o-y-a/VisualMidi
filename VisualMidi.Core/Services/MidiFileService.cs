using System.Collections.Generic;
using System.Linq;
using VisualMidi.Core.Models;

namespace VisualMidi.Core.Services
{
    public class MidiFileService : IMidiFileService
    {
        private MidiFileContext _context;

        public MidiFileService(MidiFileContext context)
        {
            _context = context;
        }

        public IEnumerable<MidiFile> GetAllFiles()
        {
            /*
             * var midiFiles = new List<MidiFile> {
                    new MidiFile { Id = 1, Name = "file1" },
                    new MidiFile { Id = 2, Name = "file2" }};
             */

            var midiFiles = _context.MidiFiles.ToList();

            return midiFiles;
        }

        public MidiFile AddFile(MidiFile midiFile)
        {
            _context.MidiFiles.Add(midiFile);
            _context.SaveChangesAsync();

            return midiFile;
        }
    }
}
