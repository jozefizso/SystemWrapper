using System;
using System.Text;

namespace SystemInterface.IO
{
    public interface ITextWriterFactory
    {
        ITextWriter CreateStringWriter();
        ITextWriter CreateStringWriter(IFormatProvider provider);
        ITextWriter CreateStringWriter(StringBuilder builder);
        ITextWriter CreateStringWriter(StringBuilder builder, IFormatProvider provider);
    }
}
