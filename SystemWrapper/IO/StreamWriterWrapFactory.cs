using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInterface.IO;

namespace SystemWrapper.IO
{
    public class StreamWriterWrapFactory : IStreamWriterFactory
    {
        public IStreamWriter Create(Stream stream)
        {
            return new StreamWriterWrap(stream);
        }

        public IStreamWriter Create(string path)
        {
            return new StreamWriterWrap(path);
        }

        public IStreamWriter Create(IStream stream)
        {
            return new StreamWriterWrap(stream);
        }

        public IStreamWriter Create(StreamWriter streamWriter)
        {
            return new StreamWriterWrap(streamWriter);
        }

        public IStreamWriter Create(TextWriter textWriter)
        {
            return new StreamWriterWrap(textWriter);
        }

        public IStreamWriter Create(Stream stream, Encoding encoding)
        {
            return new StreamWriterWrap(stream, encoding);
        }
    }
}
