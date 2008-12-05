using System.Data.SqlClient;

namespace SystemWrapper.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlCommand"/> class.
    /// </summary>
    public class SqlCommandWrap : ISqlCommandWrap
    {
        /// <summary>
        /// Initializes a new instance of the SqlCommandWrap class. 
        /// </summary>
        public SqlCommandWrap()
        {
            SqlCommandInstance = new SqlCommand();
        }

        /// <summary>
        /// Initializes a new instance of the SqlCommandWrap class. 
        /// </summary>
        /// <param name="command">SqlCommand object.</param>
        public SqlCommandWrap(SqlCommand command)
        {
            SqlCommandInstance = command;
        }

        /// <summary>
        /// Initializes a new instance of the SqlCommandWrap class with the text of the query.
        /// </summary>
        /// <param name="cmdText">The text of the query.</param>
        public SqlCommandWrap(string cmdText)
        {
            SqlCommandInstance = new SqlCommand(cmdText);
        }

        /// <summary>
        /// Initializes a new instance of the SqlCommandWrap class with the text of the query and a ISqlConnectionWrap. 
        /// </summary>
        /// <param name="cmdText">The text of the query.</param>
        /// <param name="connection">A ISqlConnectionWrap that represents the connection to an instance of SQL Server.</param>
        public SqlCommandWrap(string cmdText, ISqlConnectionWrap connection)
        {
            SqlCommandInstance = new SqlCommand(cmdText, connection.SqlConnectionInstance);
        }

        public SqlCommand SqlCommandInstance { get; private set; }

        public ISqlDataReaderWrap ExecuteReader()
        {
            return new SqlDataReaderWrap(SqlCommandInstance.ExecuteReader());
        }
    }
}