using System.Data;
using SystemWrapper.Data.SqlClient;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Samples.Data.SqlClient
{
    public class SqlConnectionSample
    {
        public ConnectionState OpenSqlConnection(ISqlConnectionWrap connection)
        {
            connection.Open();
            ConnectionState connectionState = connection.State;
            connection.Close();
            return connectionState;
        }
    }

    public class SqlConnectionSampleTests
    {
        [Test]
        public void OpenSqlConnection_test()
        {
            ISqlConnectionWrap connectionStub = MockRepository.GenerateStub<ISqlConnectionWrap>();
            connectionStub.Stub(x => x.State).Return(ConnectionState.Open);
            Assert.AreEqual(ConnectionState.Open, new SqlConnectionSample().OpenSqlConnection(connectionStub));
            connectionStub.AssertWasCalled(x => x.Open());
            connectionStub.AssertWasCalled(x => x.Close());
        }
    }
}