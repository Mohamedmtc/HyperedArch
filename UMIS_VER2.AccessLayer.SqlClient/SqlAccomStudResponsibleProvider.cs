#region Using directives

using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AccomStudResponsible"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAccomStudResponsibleProvider: SqlAccomStudResponsibleProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAccomStudResponsibleProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAccomStudResponsibleProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
      
        #region Custom Methods
        public override DataTable GetACCOMSTUDRESPONSIBLE(TransactionManager transactionManager, decimal EdAcadYearJoinId, decimal EdCodeSemesterJoinId, decimal AsFacultyInfoId, decimal _NamePolicy,
            string _StudClFullName, decimal EdstudId, decimal LangNum, decimal AsDegreeId, decimal? EdCodeLEvelId = null, decimal? MajorId = null, decimal? MinorId = null)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GetACCOMSTUDRESPONSIBLE", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("EdAcadYearJoinId", SqlDbType.Decimal).Value = EdAcadYearJoinId;
            command.Parameters.Add("EdCodeSemesterJoinId", SqlDbType.Decimal).Value = EdCodeSemesterJoinId;
            command.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            command.Parameters.Add("AsCodeDegreeId", SqlDbType.Decimal).Value = AsDegreeId;

            if(EdCodeLEvelId.HasValue)
                command.Parameters.Add("EdCodeLevelId", SqlDbType.Decimal).Value = EdCodeLEvelId;
            if (!string.IsNullOrEmpty(_StudClFullName))
                command.Parameters.Add("StudFullName", SqlDbType.NVarChar).Value = _StudClFullName;

            command.Parameters.Add("LangNum", SqlDbType.Decimal).Value = LangNum;
            command.Parameters.Add("NamePolicy", SqlDbType.Decimal).Value = _NamePolicy;
            command.Parameters.Add("StudID", SqlDbType.Decimal).Value = EdstudId;

            if(MajorId.HasValue)
                command.Parameters.Add("MajorId", SqlDbType.Decimal).Value = MajorId;
            if(MinorId.HasValue)
                command.Parameters.Add("MinorID", SqlDbType.Decimal).Value = MinorId;

            conn.Open();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();

            return table;
        }

        #endregion
    }
}