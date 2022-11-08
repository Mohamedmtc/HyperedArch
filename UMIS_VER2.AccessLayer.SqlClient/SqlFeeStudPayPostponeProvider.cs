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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudPayPostpone"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeStudPayPostponeProvider: SqlFeeStudPayPostponeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeStudPayPostponeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeStudPayPostponeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        //added by mmq at 06-02-2017
        public override DataTable GetFeeStudPayPostpone(TransactionManager transactionManager, System.Decimal _Lang, decimal EdAcadYearId ,decimal EdCodeSemesterId , decimal PayFlag , decimal EdstudId, decimal? AsFacultyInfoId = null, decimal? AsCodeDereeClassId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeStudPayPostpone", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@PayFlag", DbType.Decimal, PayFlag);
            database.AddInParameter(commandWrapper, "@EdstudId", DbType.Decimal, EdstudId);
            //walaa 18/7/2022-18870
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClass", DbType.Decimal, AsCodeDereeClassId);

            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName");
            dt.Columns.Add("STUD_FACULTY_CODE");
            dt.Columns.Add("FACULTY_DESCR");
            dt.Columns.Add("ED_ACAD_YEAR_ID");
            dt.Columns.Add("ED_CODE_SEMESTER_ID");
            dt.Columns.Add("REQ_DATE");
            dt.Columns.Add("NOTES");
            dt.Columns.Add("FEE_STUD_PAY_POSTPONE_ID");
            dt.Columns.Add("ED_STUD_ID");
            
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFeeStudPayPostpone"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentsExtraChFees"));

            return dt;
        }
        public override DataTable GetFeeStudExceptions(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsCodeDegreeId, decimal AsFacultyInfoId, decimal EntMainId, decimal EdCodeLevelId, decimal HasException, decimal IsSponsered, decimal SponserId, decimal Lang, decimal StudID, decimal DegreeClassID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeStudExceptions", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@HasException", DbType.Decimal, HasException);
            database.AddInParameter(commandWrapper, "@IsSponsered", DbType.Decimal, IsSponsered);
            database.AddInParameter(commandWrapper, "@SpoSponserId", DbType.Decimal, SponserId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            if (StudID!=0)
            database.AddInParameter(commandWrapper, "@StudID", DbType.Decimal, StudID);
            database.AddInParameter(commandWrapper, "@DegreeClassId", DbType.Decimal, DegreeClassID);
            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName");
            dt.Columns.Add("STUD_FACULTY_CODE");
            dt.Columns.Add("ENT_DESCR_AR");
            dt.Columns.Add("ENT_DESCR_EN");
            dt.Columns.Add("LEVEl_DESC_AR");
            dt.Columns.Add("LEVEl_DESC_EN");
            dt.Columns.Add("ED_STUD_ID");
            dt.Columns.Add("FEE_STUD_PAY_POSTPONE_ID");           

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFeeStudExceptions"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                     reader[7].ToString()};
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                      reader[7].ToString()};
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetFeeStudExceptions"));

            return dt;
        }
    }
}