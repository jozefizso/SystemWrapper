using System;
using System.IO;
using System.Text;
using SystemInterface.IO;

namespace SystemWrapper.IO
{
    public sealed class TextWriterFactory : ITextWriterFactory
    {
        public ITextWriter CreateStringWriter()
        {
            return new StringWriterWrap(new StringWriter());
        }

        public ITextWriter CreateStringWriter(StringBuilder builder)
        {
            return new StringWriterWrap(new StringWriter(builder));
        }

        public ITextWriter CreateStringWriter(IFormatProvider provider)
        {
            return new StringWriterWrap(new StringWriter(provider));
        }

        public ITextWriter CreateStringWriter(StringBuilder builder, IFormatProvider provider)
        {
            return new StringWriterWrap(new StringWriter(builder, provider));
        }
    }
}
