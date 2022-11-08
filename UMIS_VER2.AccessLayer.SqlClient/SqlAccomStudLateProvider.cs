#region Using directives

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AccomStudLate"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAccomStudLateProvider: SqlAccomStudLateProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAccomStudLateProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAccomStudLateProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable GetBookedMaleStudsforLateness(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyInfoId,
              decimal AsdegreeId, decimal _NamePolicy, string _StudClFullName, decimal EdstudId, decimal? EdCodeLevelId, decimal Lang , decimal CurrentDateFlg, DateTime? LatenessDate,
             decimal? MajorId = null , decimal? MinorId = null ,decimal? GenderId = null )
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GetBookedMaleStudsforLateness", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("EdAcadYearId", SqlDbType.Decimal).Value = EdAcadYearId;
            command.Parameters.Add("EdCodeSemesterId", SqlDbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            command.Parameters.Add("EdCodeLevelId", SqlDbType.Decimal).Value = EdCodeLevelId;
            command.Parameters.Add("Lang", SqlDbType.Decimal).Value = Lang;
            command.Parameters.Add("NamePolicy", SqlDbType.Decimal).Value = _NamePolicy;
            command.Parameters.Add("StudID", SqlDbType.Decimal).Value = EdstudId;
            command.Parameters.Add("AsCodeDegreeId", SqlDbType.Decimal).Value = AsdegreeId;
            command.Parameters.Add("CurrentDateFlg", SqlDbType.Decimal).Value = CurrentDateFlg;

            if (LatenessDate != null && LatenessDate.ToString() != "__/__/____")
            {
                command.Parameters.Add("LatenessDate", SqlDbType.DateTime).Value = LatenessDate;
            }

            if(_StudClFullName != null)
                command.Parameters.Add("StudFullName", SqlDbType.NVarChar).Value = _StudClFullName;

            if (GenderId.HasValue)
                command.Parameters.Add("GenderId", SqlDbType.Decimal).Value = GenderId;

            if (MajorId.HasValue)
                command.Parameters.Add("MajorId", SqlDbType.Decimal).Value = MajorId;

            if (MinorId.HasValue)
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