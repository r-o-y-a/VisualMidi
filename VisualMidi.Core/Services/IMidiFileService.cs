using System;
using System.Collections.Generic;
using VisualMidi.Core.Entities;

namespace VisualMidi.Core.Services
{
    public interface IMidiFileService
    {
        IEnumerable<MidiFile> GetAllFiles();
    }
}
