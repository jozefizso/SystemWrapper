using System.Data;
using System.Data.SqlClient;

namespace SystemWrapper.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlConnection"/> class.
    /// </summary>
    public class SqlConnectionWrap :ISqlConnectionWrap
		{

			#region Constructors

			/// <summary>
			/// Initializes a new instance of the SqlConnectionWrap class. 
			/// </summary>
			public SqlConnectionWrap()
			{
				Initialize();
			}

			/// <summary>
			/// Initializes a new instance of the SqlConnectionWrap class. 
			/// </summary>
			public void Initialize()
			{
				SqlConnectionInstance = new SqlConnection();
			}

			/// <summary>
			/// Initializes a new instance of the SqlConnectionWrap class. 
			/// </summary>
			/// <param name="connection">SqlConnection object.</param>
			public SqlConnectionWrap(SqlConnection connection)
			{
				Initialize(connection);
			}

			/// <summary>
			/// Initializes a new instance of the SqlConnectionWrap class. 
			/// </summary>
			/// <param name="connection">SqlConnection object.</param>
			public void Initialize(SqlConnection connection)
			{
				SqlConnectionInstance = connection;
			}

			/// <summary>
			/// Initializes a new instance of the SqlConnection class when given a string that contains the connection string. 
			/// </summary>
			/// <param name="connectionString">The connection used to open the SQL Server database.</param>
			public SqlConnectionWrap(string connectionString)
			{
				Initialize(connectionString);
			}

			/// <summary>
			/// Initializes a new instance of the SqlConnection class when given a string that contains the connection string. 
			/// </summary>
			/// <param name="connectionString">The connection used to open the SQL Server database.</param>
			public void Initialize(string connectionString)
			{
				SqlConnectionInstance = new SqlConnection(connectionString);
			}

			#endregion
				
				public string ConnectionString
        {
            get { return SqlConnectionInstance.ConnectionString; }
            set { SqlConnectionInstance.ConnectionString = value; }
        }

        public int ConnectionTimeout
        {
            get { return SqlConnectionInstance.ConnectionTimeout; }
        }

        public string Database
        {
            get { return SqlConnectionInstance.Database; }
        }

        public string DataSource
        {
            get { return SqlConnectionInstance.DataSource; }
        }

        public bool FireInfoMessageEventOnUserErrors
        {
            get { return SqlConnectionInstance.FireInfoMessageEventOnUserErrors; }
            set { SqlConnectionInstance.FireInfoMessageEventOnUserErrors = value; }
        }

        public int PacketSize
        {
            get { return SqlConnectionInstance.PacketSize; }
        }

        public string ServerVersion
        {
            get { return SqlConnectionInstance.ServerVersion; }
        }

        public SqlConnection SqlConnectionInstance { get; private set; }

        public ConnectionState State
        {
            get { return SqlConnectionInstance.State; }
        }

        public bool StatisticsEnabled
        {
            get { return SqlConnectionInstance.StatisticsEnabled; }
            set { SqlConnectionInstance.StatisticsEnabled = value; }
        }

        public string WorkstationId
        {
            get { return SqlConnectionInstance.WorkstationId; }
        }

        public void Close()
        {
            SqlConnectionInstance.Close();
        }

        public void Open()
        {
            SqlConnectionInstance.Open();
        }
    }
}