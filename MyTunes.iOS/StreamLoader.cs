using MyTunes.Shared;
using System.IO;

namespace MyTunes
{
    class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return System.IO.File.OpenRead(filename);
        }
    }
}