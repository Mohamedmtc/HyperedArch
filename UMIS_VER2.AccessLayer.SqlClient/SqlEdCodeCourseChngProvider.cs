#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCodeCourseChng"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCodeCourseChngProvider: SqlEdCodeCourseChngProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCodeCourseChngProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCodeCourseChngProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods
        #region GetAllForView Methods

        /// <summary>
        /// 	Gets All For View rows from the DataSource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">out. The number of rows that match this query.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCodeCourseChng objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        /*
        public override DataTable GetAllForView(TransactionManager transactionManager, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this._connectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetForAdviseCourseChngView", _useStoredProcedure);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdCodeCourseChngID");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");
            table.Columns.Add("EdStudCount");

            DataRow[] rows = table.Rows;

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAllForView", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                FillView(reader, table, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAllForView"));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }//end GetAllForView
        */

        public override DataTable GetAllForView(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetForAdviseCourseChngView", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("EdCodeCourseChngID");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");
            table.Columns.Add("EdStudCount");
            table.Columns.Add("EdChangeCount");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //FillView(reader, table, start, pageLength);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }//end GetAllForView
     
        #endregion
        #endregion
	}
}