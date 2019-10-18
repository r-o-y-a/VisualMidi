using Microsoft.EntityFrameworkCore;

namespace VisualMidi.Core.Models
{ 
    public class MidiFileContext : DbContext
    {
    public MidiFileContext(DbContextOptions<MidiFileContext> options)
        : base(options)
    {
    }

    public DbSet<MidiFile> MidiFiles { get; set; }
    }
}
