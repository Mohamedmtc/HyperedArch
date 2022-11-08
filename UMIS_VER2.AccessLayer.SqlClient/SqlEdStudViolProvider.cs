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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudViol"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudViolProvider: SqlEdStudViolProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudViolProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudViolProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override decimal GetMaxGroupID(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetMaxGroupID", this.UseStoredProcedure);

           

            //IDataReader reader = null;
            decimal reader;
          //  TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetMaxGroupID"));

                if (transactionManager != null)
                {
                    reader = decimal.Parse( Utility.ExecuteScalar(transactionManager, commandWrapper).ToString());
                }
                else
                {
                    reader = decimal.Parse(Utility.ExecuteScalar(database, commandWrapper).ToString());
                }

                //Create Collection
               // Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetMaxGroupID"));
            }
            finally
            {
                //if (reader != null)
                //    reader.Close();

                commandWrapper = null;
            }
            return reader;
        }

        public override DataTable GetByViolatDate_VioID(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_VIOL_GetByViolatDate_VioID", this.UseStoredProcedure);

            //database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);
            //database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            //database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            //database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();

                              
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("VIOL_DATE");
            table.Columns.Add("GS_CDE_VIOL_ID");
            table.Columns.Add("GROUP_ID");
            table.Columns.Add("VIOL_SERIAL");
            table.Columns.Add("GS_CDE_CAMPUS_ID");
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("ERP_ORG_TREE_FROM_ID");
            table.Columns.Add("ERP_ORG_TREE_TO_ID");
            table.Columns.Add("GS_CDE_PENALTY_ID");
            table.Columns.Add("PNLTY_DATE");
            table.Columns.Add("NOTES");
            table.Columns.Add("EXPEL_FLG");
            table.Columns.Add("ED_CODE_SEMESTER_STOP_ID");
            table.Columns.Add("ED_ACAD_YEAR_STOP_ID");
            table.Columns.Add("BAN_FEE");
            table.Columns.Add("EXEC_GLG");
            table.Columns.Add("DROP_FLG");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("GS_CDE_VIOL_CAT_ID");
           
            


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString() };
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


        public override DataTable GetByViolatStd(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId,System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId,
            System.Decimal? _GsCdeViolId, DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_VIOL_Students", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId.HasValue ? _AcadYearId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId.HasValue ? _EdCodeSemesterId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId.HasValue ? _AsFacultyInfoId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudFacultyCode", DbType.String, string.IsNullOrEmpty(_StudFacultyCode) ? (object)DBNull.Value : _StudFacultyCode);
            database.AddInParameter(commandWrapper, "@GsCdeViolCatId", DbType.Decimal, _GsCdeViolCatId.HasValue ? _GsCdeViolCatId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeViolId", DbType.Decimal, _GsCdeViolId.HasValue ? _GsCdeViolId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolFromDate", DbType.Date, _ViolFromDate.HasValue ? (object)_ViolFromDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolToDate", DbType.Date, _ViolToDate.HasValue ? (object)_ViolToDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudentName", DbType.Decimal, string.IsNullOrEmpty(_StudentName) ? (object)DBNull.Value : (object)_StudentName);
            database.AddInParameter(commandWrapper, "@IsEnglish", DbType.Boolean, _IsEnglish.HasValue ? (_IsEnglish.Value ? 1 : 0) : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy.HasValue ? _NamePolicy : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@Exec_Glg", DbType.Decimal, 0);
            database.AddInParameter(commandWrapper, "@GsCdePenaltyId", DbType.Decimal, 0);

            IDataReader reader = null;
            DataTable table = new DataTable();

          
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("VIOL_DATE");
            table.Columns.Add("GS_CDE_VIOL_ID");
            table.Columns.Add("GROUP_ID");
            table.Columns.Add("VIOL_SERIAL");
            table.Columns.Add("GS_CDE_CAMPUS_ID");
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("ERP_ORG_TREE_FROM_ID");
            table.Columns.Add("ERP_ORG_TREE_TO_ID");
            table.Columns.Add("GS_CDE_PENALTY_ID");
            table.Columns.Add("PNLTY_DATE");
            table.Columns.Add("NOTES");
            table.Columns.Add("EXPEL_FLG");

            table.Columns.Add("ED_CODE_SEMESTER_STOP_FROM_ID");
            table.Columns.Add("ED_CODE_SEMESTER_STOP_TO_ID");

            table.Columns.Add("ED_ACAD_YEAR_STOP_FROM_ID");
            table.Columns.Add("ED_ACAD_YEAR_STOP_TO_ID");

            table.Columns.Add("BAN_FEE");
            table.Columns.Add("EXEC_GLG");
            table.Columns.Add("DROP_FLG");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("FULLNAMEAR");
            table.Columns.Add("FULLNAMEEN");

            table.Columns.Add("PDESCR_AR");
            table.Columns.Add("PDESCR_EN");
            table.Columns.Add("ED_STUD_VIOL_ID");
            table.Columns.Add("EDSTUDID");

            table.Columns.Add("GS_CDE_VIOL_CAT_ID");

            table.Columns.Add("CDESCREN");
            table.Columns.Add("CDESCRAR");
            

            table.Columns.Add("BuildDescrEN");
            table.Columns.Add("BuildDescrAR");
            
            

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString()
                                         , reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() 
                                           , reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString()};
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

        public override DataTable GetByViolatStd(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId,
          System.Decimal? _GsCdeViolId, DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish, bool? _Exec_Glg, System.Decimal? _GsCdePenaltyId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_VIOL_Students", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId.HasValue ? _AcadYearId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId.HasValue ? _EdCodeSemesterId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId.HasValue ? _AsFacultyInfoId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudFacultyCode", DbType.String, string.IsNullOrEmpty(_StudFacultyCode) ? (object)DBNull.Value : _StudFacultyCode);
            database.AddInParameter(commandWrapper, "@GsCdeViolCatId", DbType.Decimal, _GsCdeViolCatId.HasValue ? _GsCdeViolCatId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeViolId", DbType.Decimal, _GsCdeViolId.HasValue ? _GsCdeViolId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolFromDate", DbType.Date, _ViolFromDate.HasValue ? (object)_ViolFromDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolToDate", DbType.Date, _ViolToDate.HasValue ? (object)_ViolToDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudentName", DbType.Decimal, string.IsNullOrEmpty(_StudentName) ? (object)DBNull.Value : (object)_StudentName);
            database.AddInParameter(commandWrapper, "@IsEnglish", DbType.Boolean, _IsEnglish.HasValue ? (_IsEnglish.Value ? 1 : 0) : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, _NamePolicy.HasValue ? _NamePolicy : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@Exec_Glg", DbType.Decimal, _Exec_Glg.HasValue ? _Exec_Glg : false);
            database.AddInParameter(commandWrapper, "@GsCdePenaltyId", DbType.Decimal, _GsCdePenaltyId.HasValue ? _GsCdePenaltyId : (object)DBNull.Value);
            IDataReader reader = null;
            DataTable table = new DataTable();


            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("VIOL_DATE");
            table.Columns.Add("GS_CDE_VIOL_ID");
            table.Columns.Add("GROUP_ID");
            table.Columns.Add("VIOL_SERIAL");
            table.Columns.Add("GS_CDE_CAMPUS_ID");
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("ERP_ORG_TREE_FROM_ID");
            table.Columns.Add("ERP_ORG_TREE_TO_ID");
            table.Columns.Add("GS_CDE_PENALTY_ID");
            table.Columns.Add("PNLTY_DATE");
            table.Columns.Add("NOTES");
            table.Columns.Add("EXPEL_FLG");
            table.Columns.Add("ED_CODE_SEMESTER_STOP_ID");
            table.Columns.Add("ED_ACAD_YEAR_STOP_ID");
            table.Columns.Add("BAN_FEE");
            table.Columns.Add("EXEC_GLG");
            table.Columns.Add("DROP_FLG");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("FULLNAMEAR");
            table.Columns.Add("FULLNAMEEN");
            table.Columns.Add("PDESCR_AR");
            table.Columns.Add("PDESCR_EN");
            table.Columns.Add("ED_STUD_VIOL_ID");
            table.Columns.Add("EDSTUDID");
            table.Columns.Add("GS_CDE_VIOL_CAT_ID");
            table.Columns.Add("CDESCREN");
            table.Columns.Add("CDESCRAR");
            table.Columns.Add("LocDESCRAR");
            table.Columns.Add("LocDESCREN");
            

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString()
                                         , reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString(), reader[30].ToString(), reader[31].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() 
                                           , reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString(), reader[30].ToString(), reader[31].ToString()};
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

        public override DataTable GetStudentViolations(TransactionManager transactionManager, string _StudFacultyCode, string NationalityCPR, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, DateTime? _ViolFromDate, DateTime? _ViolToDate, 
            System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId, decimal? _penalityRelatedFlg, System.Decimal? _GsCdePenaltyId, decimal? _Exec_Glg, decimal? AsCodeDegreeClass = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentViolations", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@studCode", DbType.String, string.IsNullOrEmpty(_StudFacultyCode) ? (object)DBNull.Value : _StudFacultyCode);
            database.AddInParameter(commandWrapper, "@NationalityCPR", DbType.String, NationalityCPR);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _AcadYearId.HasValue ? _AcadYearId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId.HasValue ? _EdCodeSemesterId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@FromDate", DbType.Date, _ViolFromDate.HasValue ? (object)_ViolFromDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ToDate", DbType.Date, _ViolToDate.HasValue ? (object)_ViolToDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeViolCatId", DbType.Decimal, _GsCdeViolCatId.HasValue ? _GsCdeViolCatId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeViolId", DbType.Decimal, _GsCdeViolId.HasValue ? _GsCdeViolId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@PenaltyRelatedFlg", DbType.Decimal, _penalityRelatedFlg.HasValue ? _penalityRelatedFlg : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdePenaltyId", DbType.Decimal, _GsCdePenaltyId.HasValue ? _GsCdePenaltyId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ExecFlg", DbType.Decimal, _Exec_Glg.HasValue ? _Exec_Glg : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClass", DbType.Decimal, AsCodeDegreeClass.HasValue ? AsCodeDegreeClass : (object)DBNull.Value);//walaa 25/7/2022
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_VIOL_ID");
            table.Columns.Add("VIOL_DATE");
            table.Columns.Add("GS_CDE_VIOL_ID");
            table.Columns.Add("GS_CDE_PENALTY_ID");
            table.Columns.Add("ED_STUD_VIOL_APPEAL_ID");
            table.Columns.Add("EXEC_FLG");
            table.Columns.Add("EXE_FLG_REG");
            table.Columns.Add("Drop_Flg");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ViolDescAr");
            table.Columns.Add("ViolDescrEn");
            table.Columns.Add("PenaltyDescAr");
            table.Columns.Add("PenaltyDescEn");
            table.Columns.Add("PNLTY_DATE");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("BuildingDescAr");
            table.Columns.Add("BuildingDescEn");
            table.Columns.Add("AttchdDocPath");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), 
                                           reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(),
                                           reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(),reader[22].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 
                                           reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), 
                                           reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(),
                                           reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(),reader[22].ToString()};
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


        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudViol entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_VIOL_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudViolId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@GsCdeCampusId", DbType.Decimal, (entity.GsCdeCampusId.HasValue ? (object)entity.GsCdeCampusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, (entity.ScBuildingId.HasValue ? (object)entity.ScBuildingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ViolDate", DbType.DateTime, entity.ViolDate);
            database.AddInParameter(commandWrapper, "@GsCdeViolId", DbType.Decimal, entity.GsCdeViolId);
            database.AddInParameter(commandWrapper, "@GroupId", DbType.Decimal, (entity.GroupId.HasValue ? (object)entity.GroupId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCdePenaltyId", DbType.Decimal, (entity.GsCdePenaltyId.HasValue ? (object)entity.GsCdePenaltyId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PnltyDate", DbType.DateTime, (entity.PnltyDate.HasValue ? (object)entity.PnltyDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ViolFrom", DbType.Date, (entity.ViolFrom.HasValue ? (object)entity.ViolFrom : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ViolTo", DbType.Date, (entity.ViolTo.HasValue ? (object)entity.ViolTo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PnltyFrom", DbType.Date, (entity.PnltyFrom.HasValue ? (object)entity.PnltyFrom : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PnltyTo", DbType.Date, (entity.PnltyTo.HasValue ? (object)entity.PnltyTo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@BhvrMark", DbType.Decimal, (entity.BhvrMark.HasValue ? (object)entity.BhvrMark : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AttndMark", DbType.Decimal, (entity.AttndMark.HasValue ? (object)entity.AttndMark : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DropDate", DbType.DateTime, (entity.DropDate.HasValue ? (object)entity.DropDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
            database.AddInParameter(commandWrapper, "@ErpOrgTreeFromId", DbType.Decimal, (entity.ErpOrgTreeFromId.HasValue ? (object)entity.ErpOrgTreeFromId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ErpOrgTreeToId", DbType.Decimal, (entity.ErpOrgTreeToId.HasValue ? (object)entity.ErpOrgTreeToId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, entity.EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ViolSerial", DbType.Decimal, (entity.ViolSerial.HasValue ? (object)entity.ViolSerial : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@BanFee", DbType.Decimal, (entity.BanFee.HasValue ? (object)entity.BanFee : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@BanFeePayFlag", DbType.Decimal, (entity.BanFeePayFlag.HasValue ? (object)entity.BanFeePayFlag : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DropFlg", DbType.Decimal, entity.DropFlg);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterStopFromId", DbType.Decimal, (entity.EdCodeSemesterStopFromId.HasValue ? (object)entity.EdCodeSemesterStopFromId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdAcadYearStopFromId", DbType.Decimal, (entity.EdAcadYearStopFromId.HasValue ? (object)entity.EdAcadYearStopFromId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeSemesterStopToId", DbType.Decimal, (entity.EdCodeSemesterStopToId.HasValue ? (object)entity.EdCodeSemesterStopToId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdAcadYearStopToId", DbType.Decimal, (entity.EdAcadYearStopToId.HasValue ? (object)entity.EdAcadYearStopToId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AppealFlg", DbType.Decimal, entity.AppealFlg);
            database.AddInParameter(commandWrapper, "@OtherFlag", DbType.Decimal, (entity.OtherFlag.HasValue ? (object)entity.OtherFlag : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@OtherSite", DbType.String, entity.OtherSite);
            database.AddInParameter(commandWrapper, "@GsCdeViolCatId", DbType.Decimal, entity.GsCdeViolCatId);
            database.AddInParameter(commandWrapper, "@InvestigationCommInOut", DbType.Decimal, (entity.InvestigationCommInOut.HasValue ? (object)entity.InvestigationCommInOut : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@InvestigationDate", DbType.DateTime, (entity.InvestigationDate.HasValue ? (object)entity.InvestigationDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@InvestigationEndDate", DbType.DateTime, (entity.InvestigationEndDate.HasValue ? (object)entity.InvestigationEndDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@InvestigationRecommendation", DbType.String, entity.InvestigationRecommendation);
            database.AddInParameter(commandWrapper, "@ApprovedBy", DbType.Decimal, (entity.ApprovedBy.HasValue ? (object)entity.ApprovedBy : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CancelFlg", DbType.Decimal, (entity.CancelFlg.HasValue ? (object)entity.CancelFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PunishCommFlg", DbType.Decimal, (entity.PunishCommFlg.HasValue ? (object)entity.PunishCommFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PunishCommDate", DbType.DateTime, (entity.PunishCommDate.HasValue ? (object)entity.PunishCommDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PunishCommEndDate", DbType.DateTime, (entity.PunishCommEndDate.HasValue ? (object)entity.PunishCommEndDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PenaltyRelatedFlg", DbType.Decimal, (entity.PenaltyRelatedFlg.HasValue ? (object)entity.PenaltyRelatedFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SemesterNo", DbType.Decimal, (entity.SemesterNo.HasValue ? (object)entity.SemesterNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AbsenceFlg", DbType.Decimal, (entity.AbsenceFlg.HasValue ? (object)entity.AbsenceFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ExecFlg", DbType.Decimal, (entity.ExecFlg.HasValue ? (object)entity.ExecFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ExeFlgReg", DbType.Decimal, (entity.ExeFlgReg.HasValue ? (object)entity.ExeFlgReg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@WarningNo", DbType.Decimal, entity.WarningNo);
            database.AddInParameter(commandWrapper, "@EdStudCheatId", DbType.Decimal, (entity.EdStudCheatId.HasValue ? (object)entity.EdStudCheatId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Witness", DbType.String, entity.Witness);
            database.AddInParameter(commandWrapper, "@GsCodeApprovalId", DbType.Decimal, (entity.GsCodeApprovalId.HasValue ? (object)entity.GsCodeApprovalId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ApprovedByName", DbType.String, entity.ApprovedByName);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.EdStudViolId = decimal.Parse(commandWrapper.Parameters["@EdStudViolId"].Value.ToString());
            entity.OriginalEdStudViolId = entity.EdStudViolId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }


        public override bool ExecuteStudViol(TransactionManager transactionManager, decimal edStudViolId, decimal? UserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ExecuteStudViol", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudViolId", DbType.Decimal, edStudViolId);
            if(UserID != null)
                database.AddInParameter(commandWrapper, "@UserID", DbType.Decimal, UserID);
            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }
        //eman moustafa  Date:10/3/2020
        public override DataTable Get_Students_VIOL(TransactionManager transactionManager, decimal? AcadYearId, decimal? EdCodeSemesterId, decimal? AsFacultyInfoId, string StudFacultyCode, decimal? GsCdeViolCatId, decimal? GsCdeViolId,
           decimal? GsCdePenaltyId, DateTime? ViolFromDate, DateTime? ViolToDate, string CPR, decimal? ExecFlg, decimal? STFmemberId,decimal? AsCodeDegreeClassId=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_Students_VIOL", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, AcadYearId.HasValue ? AcadYearId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId.HasValue ? EdCodeSemesterId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? AsFacultyInfoId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@StudFacultyCode", DbType.String, string.IsNullOrEmpty(StudFacultyCode) ? (object)DBNull.Value : StudFacultyCode);
            database.AddInParameter(commandWrapper, "@GsCdeViolCatId", DbType.Decimal, GsCdeViolCatId.HasValue ? GsCdeViolCatId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeViolId", DbType.Decimal, GsCdeViolId.HasValue ? GsCdeViolId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolFromDate", DbType.Date, ViolFromDate.HasValue ? (object)ViolFromDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@ViolToDate", DbType.Date, ViolToDate.HasValue ? (object)ViolToDate : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@txtCPR", DbType.String, string.IsNullOrEmpty(CPR) ? (object)DBNull.Value : (object)CPR);
            database.AddInParameter(commandWrapper, "@ExecFlg", DbType.Decimal, ExecFlg.HasValue ? ExecFlg : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, STFmemberId.HasValue ? STFmemberId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdePenaltyId", DbType.Decimal, GsCdePenaltyId.HasValue ? GsCdePenaltyId : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId.HasValue ? AsCodeDegreeClassId : (object)DBNull.Value);//walaa 25/7/2022
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("GSCDEVIOLID");
            table.Columns.Add("EdStudId");
            table.Columns.Add("EdStudViolId");
            table.Columns.Add("VIOLDATE");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("GS_CDE_VIOL_CAT_ID");
            table.Columns.Add("GS_CDE_PENALTY_ID");
            table.Columns.Add("EXEC_FLG");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("DropFlg");
          
           
         

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString() };
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

        public override bool CancelExecuteStudViol(TransactionManager transactionManager, decimal edStudViolId, decimal? UserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CancelExecuteStudViol", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudViolId", DbType.Decimal, edStudViolId);
            if (UserID != null)
                database.AddInParameter(commandWrapper, "@UserID", DbType.Decimal, UserID);
            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }
    }
}
