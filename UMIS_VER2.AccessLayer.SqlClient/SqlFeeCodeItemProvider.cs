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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeCodeItem"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeCodeItemProvider: SqlFeeCodeItemProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeCodeItemProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeCodeItemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override TList<FeeCodeItem> GetByFeeCodeTypeId_DegreeType(TransactionManager transactionManager, decimal _FeeCodeTypeId, decimal _AsCodeDegreeID,decimal _AsDegreeClassID , int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetByFeeCodeTypeId_DegreeTypeID", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeID", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@CodeDegreeID", DbType.Decimal, _AsCodeDegreeID);
            database.AddInParameter(commandWrapper, "@DegreeClassID", DbType.Decimal, _AsDegreeClassID);
            IDataReader reader = null;

            //Create Collection
            TList<FeeCodeItem> rows = new TList<FeeCodeItem>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByFeeCodeTypeId_DegreeType", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByFeeCodeTypeId_DegreeType", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall

        #endregion
    }
}