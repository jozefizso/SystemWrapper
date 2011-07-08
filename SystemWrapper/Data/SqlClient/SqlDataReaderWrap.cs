using System.Data.SqlClient;

namespace SystemWrapper.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlDataReader"/> class.
    /// </summary>
    public class SqlDataReaderWrap : ISqlDataReaderWrap
		{
			#region Constructors
			/// <summary>
			/// Initializes a new instance of the SqlDataReaderWrap class (requires a subsequent call to Initialize). 
			/// </summary>
			public SqlDataReaderWrap()
			{
				//this constructor assumes the caller will call the Initialize method before using
			}

			/// <summary>
			/// Initializes a new instance of the SqlDataReaderWrap class. 
			/// </summary>
			/// <param name="dataReader">SqlDataReader object.</param>
			public SqlDataReaderWrap(SqlDataReader dataReader)
			{
				Initialize(dataReader);
			}

			/// <summary>
			/// Initializes a new instance of the SqlDataReaderWrap class. 
			/// </summary>
			/// <param name="dataReader">SqlDataReader object.</param>
			public void Initialize(SqlDataReader dataReader)
			{
				SqlDataReaderInstance = dataReader;
			}

			#endregion
				
			object ISqlDataReaderWrap.this[int i]
        {
            get { return SqlDataReaderInstance[i]; }
        }

        object ISqlDataReaderWrap.this[string name]
        {
            get { return SqlDataReaderInstance[name]; }
        }

        public SqlDataReader SqlDataReaderInstance { get; private set; }

        public void Close()
        {
            SqlDataReaderInstance.Close();
        }

        public bool Read()
        {
            return SqlDataReaderInstance.Read();
        }
    }
}