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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudState"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudStateProvider: SqlEdStudStateProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudStateProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudStateProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        //updated by dalia at 13-12-2012 to add the new field that added in ed_stud_Faculty and entering from homestate screen
        //updated by dalia farouk 11-10-2012 to add flag of create user or not for student 
        public override void UpdateStudState(TransactionManager transactionManager, System.Decimal _EdStudId, System.String _StudFacCode, System.Decimal _EdAcadYearId

     , System.Decimal _EntMainId, System.Decimal _AsFacultyId, System.String _StudName, System.Decimal _SeUserId, System.Decimal? _EdCodeSemester, System.Decimal _Flage, System.Decimal _Lang, System.Decimal? _AS_CODE_DEGREE_ID, System.Decimal? _ED_CDE_QUAL_PHASE
          , DateTime _ENROLL_DATE, System.Decimal? _ADM_CDE_APP_TYPE_ID, System.Decimal? _ED_STUD_QUAL_ID)

        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UpdateStudState", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyId);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);
            database.AddInParameter(commandWrapper, "@UserId", DbType.Decimal, _SeUserId);
            database.AddInParameter(commandWrapper, "@StudFacCode", DbType.String, _StudFacCode);
            database.AddInParameter(commandWrapper, "@EdCodeSemester", DbType.Decimal, _EdCodeSemester);
            database.AddInParameter(commandWrapper, "@Flage", DbType.Decimal, _Flage);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_ID", DbType.Decimal,((_AS_CODE_DEGREE_ID == -1) ? null :  _AS_CODE_DEGREE_ID));
            database.AddInParameter(commandWrapper, "@ED_CDE_QUAL_PHASE", DbType.Decimal, ((_ED_CDE_QUAL_PHASE == -1) ? null : _ED_CDE_QUAL_PHASE));
            database.AddInParameter(commandWrapper, "@ENROLL_DATE", DbType.DateTime, _ENROLL_DATE);
            database.AddInParameter(commandWrapper, "@ADM_CDE_APP_TYPE_ID", DbType.Decimal, ((_ADM_CDE_APP_TYPE_ID == -1) ? null : _ADM_CDE_APP_TYPE_ID));
            database.AddInParameter(commandWrapper, "@ED_STUD_QUAL_ID", DbType.Decimal, ((_ED_STUD_QUAL_ID == -1) ? null : _ED_STUD_QUAL_ID));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }
        }

        public override void UpdateFullFillStatusAndAcadWarning(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EntMainId, System.Decimal _AsFacultyId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_State_UpdateFullFillStatusAndAcadWarning", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyId);

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }
        }



        public override void InsertStudSemStateUser(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId
            , System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _AsFacultyId, System.Decimal _Lang, System.Decimal _CreatorUserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.InsertStudSemStateUser", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@CreatorUserId", DbType.Decimal, _CreatorUserId);

            int results = 0;


            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }
        }


        public override DataTable GetStateRegisteredCourses(TransactionManager transactionManager, System.Decimal _EdStudSemesterId, System.Decimal _EntMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_STATE_GetRegisteredCourses", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override void BatchCourseDeclaration(TransactionManager transactionManager, string StudCode, string StateCode, string YearCalendar, string SemesterDescrEn, string TOT_CH, string FULLFILLED_CH, string ED_CODE_STATE_STATUS_Symbol)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.BatchCourseDeclaration", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@StateCode", DbType.String, StateCode);
            database.AddInParameter(commandWrapper, "@YearCalendar", DbType.String, YearCalendar);
            database.AddInParameter(commandWrapper, "@SemesterDescrEn", DbType.String, SemesterDescrEn);
            database.AddInParameter(commandWrapper, "@TOT_CH", DbType.Decimal, TOT_CH);
            database.AddInParameter(commandWrapper, "@FULLFILLED_CH", DbType.Decimal, FULLFILLED_CH);
            database.AddInParameter(commandWrapper, "@ED_CODE_STATE_STATUS_Descer", DbType.String, ED_CODE_STATE_STATUS_Symbol);


            int results = 0;


            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }
        }

        public override TList<EdStudState> GetStudStates(TransactionManager transactionManager, decimal edStudId, decimal isDeclared, decimal isHomeFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_STATE_GetStudStates", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, edStudId);
            database.AddInParameter(commandWrapper, "@IsDeclared", DbType.Decimal, isDeclared);
            database.AddInParameter(commandWrapper, "@IsHomeFlg", DbType.Decimal, isHomeFlg);

            IDataReader reader = null;
            TList<EdStudState> tmp = new TList<EdStudState>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudStates", tmp));

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
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudStates", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;

            //return rows;
        }

        #endregion
	}
}