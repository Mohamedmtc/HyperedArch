﻿#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmCdeFee"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmCdeFeeProvider: SqlAdmCdeFeeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmCdeFeeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmCdeFeeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override int LoadFeeOnApplicant(TransactionManager transactionManager, decimal admCdeFeeId, decimal admOpenAcadSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadFeeOnApplicant", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmCdeFeeId", DbType.Decimal, admCdeFeeId);
            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, admOpenAcadSemesterId);

            IDataReader reader = null;

            int count = 0;

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

                while (reader.Read())
                {
                    count = int.Parse(reader[0].ToString());
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return count;
        }
	}
}