using System;
using System.Collections.Generic;
using VisualMidi.Core.Models;

namespace VisualMidi.Core.Services
{
    public interface IMidiFileService
    {
        IEnumerable<MidiFile> GetAllFiles();
        MidiFile AddFile(MidiFile midiFile);
    }
}
