using System.IO;

namespace SystemInterface.IO
{
    public interface IStringWriter : ITextWriter
    {
        StringWriter Instance { get; }
    }
}
