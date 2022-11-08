#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCdeAcadWarnType"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCdeAcadWarnTypeProvider: SqlEdCdeAcadWarnTypeProviderBase
	{
        string _connectionString;

        /// <summary>
        /// Creates a new <see cref="SqlEdCdeAcadWarnTypeProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlEdCdeAcadWarnTypeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        // MElshazly 2/7/2019 [9734]
        public override TList<EdCdeAcadWarnType> GetAcadWarnType(TransactionManager transactionManager, decimal _edByLawId)
        {
            SqlDatabase database = new SqlDatabase(ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAcadWarnType", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@edByLawId", DbType.Decimal, _edByLawId);

            IDataReader reader = null;
            TList<EdCdeAcadWarnType> tmp = new TList<EdCdeAcadWarnType>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAcadWarnType", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAcadWarnType", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWrapper = null;
            }

            if (tmp.Count >0)
            {
                return tmp;
            }
            else if (tmp.Count == 0)
            {
                return null;
            }
            else
            {
                throw new DataException("Cannot find the unique instance of the class.");
            }
        }

    }
}