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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeCdeDiscType"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeCdeDiscTypeProvider: SqlFeeCdeDiscTypeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeCdeDiscTypeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeCdeDiscTypeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override TList<FeeCdeDiscType> GetStudValidCodes(TransactionManager transactionManager, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudValidDiscCodes", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            IDataReader reader = null;

            //Create Collection
            TList<FeeCdeDiscType> rows = new TList<FeeCdeDiscType>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudValidCodes", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudValidCodes", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall


        public override TList<FeeCdeDiscType> GetByFeeCdeDiscCatIdAsfacultyInfoId(TransactionManager transactionManager, System.Decimal _FeeCdeDiscCatId, System.Decimal _AsfacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_CDE_DISC_TYPE_GetByFeeCdeDiscCatIdAsfacultyInfoId", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@FeeCdeDiscCatId", DbType.Decimal, _FeeCdeDiscCatId);
            database.AddInParameter(commandWrapper, "@AsfacultyInfoId", DbType.Decimal, _AsfacultyInfoId);
            IDataReader reader = null;

            //Create Collection
            TList<FeeCdeDiscType> rows = new TList<FeeCdeDiscType>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "FEE_CDE_DISC_TYPE_GetByFeeCdeDiscCatIdAsfacultyInfoId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudValidCodes", rows));
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