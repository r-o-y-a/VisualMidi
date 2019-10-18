using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using VisualMidi.Core.Models;
using VisualMidi.Core.Services;

namespace VisualMidi.Tests
{
    [TestFixture]
    public class MidiFileServiceTests
    {
        Mock<IMidiFileService> _midiFileService;

        [SetUp]
        public void Setup()
        {
            _midiFileService = new Mock<IMidiFileService>();
        }

        [Test]
        public void Test1()
        {
            _midiFileService.Setup(m => m.GetAllFiles()).Returns(new List<MidiFile>());
            var result = _midiFileService.Object.GetAllFiles();
            Assert.IsNotNull(result);
        }
    }
}