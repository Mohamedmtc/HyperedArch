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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="RsrchStudPostponeReq"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlRsrchStudPostponeReqProvider: SqlRsrchStudPostponeReqProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlRsrchStudPostponeReqProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlRsrchStudPostponeReqProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        //eman moustafa ,Date:29-9-2020  Task:14029
        public override DataTable GetStudWithRsrch_postpon(TransactionManager transactionManager, System.Decimal? EntMainMajorId, System.Decimal? EntMainMinorId,
       System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.String studCode,
         System.Decimal? _asCodeDegree, System.Decimal _statuecodeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudWithRsrch_PostPon_Req", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeID", DbType.Decimal, _asCodeDegree);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainMajorId", DbType.Decimal, EntMainMajorId);
            database.AddInParameter(commandWrapper, "@EntMainMinorId", DbType.Decimal, EntMainMinorId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@StatueCodeId", DbType.Decimal, _statuecodeId);


            IDataReader reader = null;
            DataTable table = new DataTable();

            // table.Columns.Add("ED_CODE_COURSE_ID");

            table.Columns.Add("RSRCH_STUD_POSTPONE_REQ_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_EN");
            table.Columns.Add("StatusDesAR");
            table.Columns.Add("StatusDesEN");
            table.Columns.Add("REQ_DATE");
            table.Columns.Add("APPROVE_FLG");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString()
                                     , reader[8].ToString() , reader[9].ToString() ,reader[10].ToString() 
                                     };
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
        }
    
    }
}