using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInterface.IO
{
    public interface IStreamWriterFactory
    {
        IStreamWriter Create(TextWriter textWriter);
        IStreamWriter Create(StreamWriter streamWriter);
        IStreamWriter Create(Stream stream);
        IStreamWriter Create(IStream stream);
        IStreamWriter Create(string path);
        IStreamWriter Create(Stream stream, Encoding encoding);
    }
}
