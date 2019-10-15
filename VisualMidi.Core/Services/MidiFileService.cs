using System;
using System.Collections.Generic;
using VisualMidi.Core.Entities;

namespace VisualMidi.Core.Services
{
    public class MidiFileService : IMidiFileService
    {
        public MidiFileService()
        {
        }

        public IEnumerable<MidiFile> GetAllFiles()
        {
            var midiFiles = new List<MidiFile> {
                    new MidiFile { Id = 1, Name = "file1" },
                    new MidiFile { Id = 2, Name = "file2" }};

            return midiFiles;
        }
    }
}
