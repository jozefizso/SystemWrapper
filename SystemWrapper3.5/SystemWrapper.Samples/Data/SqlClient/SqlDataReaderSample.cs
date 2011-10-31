using System;
using System.Collections.Generic;
using SystemWrapper.Data.SqlClient;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Samples.Data.SqlClient
{
    public class SqlDataReaderSample
    {
        public List<string> ReadData(ISqlDataReaderWrap reader)
        {
            List<string> result = new List<string>();
            try
            {
                while (reader.Read())
                    result.Add(string.Format("{0}", reader[0]));
            }
            finally
            {
                reader.Close();
            }
            return result;
        }
    }

    public class SqlDataReaderSampleTests
    {
        [Test]
        public void ReadData_test()
        {
            ISqlDataReaderWrap readerStub = MockRepository.GenerateStub<ISqlDataReaderWrap>();

            List<string> result = new SqlDataReaderSample().ReadData(readerStub);
            Assert.AreEqual(2, result.Count);
        }
    }
}