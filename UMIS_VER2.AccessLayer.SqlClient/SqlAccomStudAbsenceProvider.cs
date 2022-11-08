#region Using directives

using System;
using System.Configuration;
using System.Collections.Generic;
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AccomStudAbsence"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAccomStudAbsenceProvider: SqlAccomStudAbsenceProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAccomStudAbsenceProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAccomStudAbsenceProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override DataTable GetAccomAbsenceStuds(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyInfoId,
           decimal _NamePolicy, decimal? EdCodeLevelId, string _StudClFullName, decimal EdstudId, decimal LangNum, DateTime? AbsenceDate, decimal? GenderId = null, decimal FajrFlg = 0,decimal?AsCodeDegreeClass=null)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GetAccomAbsenceStuds", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("EdAcadYearId", SqlDbType.Decimal).Value = EdAcadYearId;
            command.Parameters.Add("EdCodeSemesterId", SqlDbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("AsFacultyInfoId", SqlDbType.Decimal).Value = AsFacultyInfoId;
            command.Parameters.Add("EdCodeLevelId", SqlDbType.Decimal).Value = EdCodeLevelId;
            command.Parameters.Add("StudFullName", SqlDbType.NVarChar).Value = _StudClFullName;
            command.Parameters.Add("LangNum", SqlDbType.Decimal).Value = LangNum;
            command.Parameters.Add("NamePolicy", SqlDbType.Decimal).Value = _NamePolicy;
            command.Parameters.Add("StudID", SqlDbType.Decimal).Value = EdstudId;

            if(AbsenceDate.HasValue)
                command.Parameters.Add("AbsenceDate", SqlDbType.DateTime).Value = AbsenceDate;

            if(GenderId.HasValue)
                command.Parameters.Add("GenderId", SqlDbType.Decimal).Value = GenderId;

            command.Parameters.Add("FajrFlg", SqlDbType.Decimal).Value = FajrFlg;

            if(AsCodeDegreeClass!=null)
                command.Parameters.Add("AsCodeDegreeClass", SqlDbType.Decimal).Value = AsCodeDegreeClass;
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