#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudEnrollChange"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudEnrollChangeProvider: SqlEdStudEnrollChangeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudEnrollChangeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudEnrollChangeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods

        public override DataTable SearchStudEnrollChange(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId
            , System.DateTime? _FromDate, System.DateTime? _ToDate, System.Decimal _EdCodeEnrollTypeId, System.Decimal? _TypeID, System.Decimal? _ApproveFlg, System.String _StudCode, System.Decimal _EdAcadYearIdchange, System.Decimal _EdCodeSemesterIdchange, string _NationalNumber)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchStudEnrollChange", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearIdchange", DbType.Decimal, _EdAcadYearIdchange);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterIdchange", DbType.Decimal, _EdCodeSemesterIdchange);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, _ToDate);
            database.AddInParameter(commandWrapper, "@TypeID", DbType.Decimal, _TypeID);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollTypeId", DbType.Decimal, _EdCodeEnrollTypeId);
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, _ApproveFlg);
            database.AddInParameter(commandWrapper, "@STUD_CODE", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@National_Number", DbType.String, _NationalNumber);
            


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudEnrollChangeId");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("LevelDescAr");
            table.Columns.Add("LevelDescrEn");
            table.Columns.Add("OldEnrollDescAr");
            table.Columns.Add("OldEnrollDescEn");
            table.Columns.Add("NewEnrollDescAr");
            table.Columns.Add("NewEnrollDescEn");
            table.Columns.Add("CHANGE_DATE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("MajorAr");
            table.Columns.Add("MajorEn");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                         reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                         reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString()};
                        table.Rows.Add(items);
                    }
                }

                ////Create Collection
                //Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }


        public override DataTable SearchStudForUnOfficilWithdraw(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId,
            System.Decimal _AsFacultyInfoId, System.Decimal _ENT_MAIN_ID, System.Decimal _AS_CODE_DEGREE_ID, System.Decimal _AS_CODE_DEGREE_CLASS_ID, System.Decimal? _PAY_FLG, System.Decimal? _MinAcadLoad, System.Decimal _AdmYear)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudForUnOfficilWithdraw", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ENT_MAIN_ID", DbType.Decimal, _ENT_MAIN_ID);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_ID", DbType.Decimal, _AS_CODE_DEGREE_ID);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_CLASS_ID", DbType.Decimal, _AS_CODE_DEGREE_CLASS_ID);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_JOIN_ID", DbType.Decimal, _AdmYear);


            if (_PAY_FLG.HasValue)
                database.AddInParameter(commandWrapper, "@PAY_FLG", DbType.Decimal, _PAY_FLG.Value);
            if (_MinAcadLoad.HasValue)
                database.AddInParameter(commandWrapper, "@MinAcadLoad", DbType.Decimal, _MinAcadLoad);

         //   database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, _ApproveFlg);

       



            IDataReader reader = null;
            DataTable table = new DataTable();
            //table.Columns.Add("EdStudEnrollChangeId");
            //table.Columns.Add("STUD_FACULTY_CODE");
            //table.Columns.Add("FULL_NAME_AR");
            //table.Columns.Add("FULL_NAME_EN");
            //table.Columns.Add("LevelDescAr");
            //table.Columns.Add("LevelDescrEn");
            //table.Columns.Add("OldEnrollDescAr");
            //table.Columns.Add("OldEnrollDescEn");
            //table.Columns.Add("NewEnrollDescAr");
            //table.Columns.Add("NewEnrollDescEn");
            //table.Columns.Add("CHANGE_DATE");

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    table.Load(reader);
                    //read data
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                    //                     reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                    //    table.Rows.Add(items);
                    //}
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    table.Load(reader);
                    //read data
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                    //                     reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                    //    table.Rows.Add(items);
                    //}
                }

                ////Create Collection
                //Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }


        public override DataTable GetByStudFacultyId(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEnrollChngByStudFacultyId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AcadDescrAr");
            table.Columns.Add("AcadDescrEn");
            table.Columns.Add("SemDescrAr");
            table.Columns.Add("SemDescrEn");
            table.Columns.Add("OldEnrollDescrAr");
            table.Columns.Add("OldEnrollDescrEn");
            table.Columns.Add("NewEnrollDescrAr");
            table.Columns.Add("NewEnrollDescrEn");
            table.Columns.Add("CHANGE_DATE");

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                         reader[7].ToString(),reader[8].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                                         reader[7].ToString(),reader[8].ToString()};
                        table.Rows.Add(items);
                    }
                }

                ////Create Collection
                //Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }



        public override string ChangeStudsEnrollUnofficial(TransactionManager transactionManager, decimal ED_STUD_SEMESTER_ID, DateTime REQ_DATE, decimal ED_CDE_ENROLL_CHNG_RSN_ID
            , string Notes, string DECISION_NO, DateTime DECISION_DATE, decimal SA_STF_MEM_APPROVED_BY_ID, decimal SE_USER_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ChangeStudsEnrollUnofficial", this.UseStoredProcedure);



            database.AddInParameter(commandWrapper, "@ED_STUD_SEMESTER_ID ", DbType.Decimal, ED_STUD_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@REQ_DATE ", DbType.Date, REQ_DATE);
            database.AddInParameter(commandWrapper, "@ED_CDE_ENROLL_CHNG_RSN_ID", DbType.Decimal, ED_CDE_ENROLL_CHNG_RSN_ID);
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, Notes);
            database.AddInParameter(commandWrapper, "@DECISION_NO", DbType.String, DECISION_NO);
            database.AddInParameter(commandWrapper, "@DECISION_DATE", DbType.Date, DECISION_DATE);
            database.AddInParameter(commandWrapper, "@SA_STF_MEM_APPROVED_BY_ID", DbType.Decimal, SA_STF_MEM_APPROVED_BY_ID);
            database.AddInParameter(commandWrapper, "@SE_USER_ID", DbType.Decimal, SE_USER_ID);          
            database.AddOutParameter(commandWrapper,"@Error", DbType.String, 1000);



            int results = 0;

            //Provider Data Requesting Command Event
            //OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_STUD_InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return commandWrapper.Parameters["@Error"].Value.ToString();
        }


        public override string CheckStudEnrollChange(TransactionManager transactionManager, int EdStudSemesterLastId,  int EdCodeEnrollFromId
          , int EdCodeEnrollToId, int ReqSemCount,DateTime ReqDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "CHK_STUD_ENROLL_CHANGE", this.UseStoredProcedure);
           
            database.AddInParameter(commandWrapper, "@EdStudSemesterLastId ", DbType.Int32, EdStudSemesterLastId);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollFromId ", DbType.Int32, EdCodeEnrollFromId);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollToId", DbType.Int32, EdCodeEnrollToId);
            database.AddInParameter(commandWrapper, "@ReqSemCount", DbType.Int32, ReqSemCount);
            database.AddInParameter(commandWrapper, "@ReqDate", DbType.DateTime, ReqDate);
            database.AddOutParameter(commandWrapper, "@RetMsg", DbType.String, 200);



            string results = "0";

            //Provider Data Requesting Command Event
            //OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_STUD_InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper).ToString();
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper).ToString();
            }

            return commandWrapper.Parameters["@RetMsg"].Value.ToString();
        }

        public override string ExecuteStudEnrollChange(TransactionManager transactionManager,decimal EdStudEnrollChangeID, int EdStudSemesterLastId, int EdCodeEnrollFromId
        , int EdCodeEnrollToId, DateTime ReqDate, decimal? UserID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "EXEC_STUD_ENROLL_CHANGE", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudEnrollChangeID", DbType.Int32, EdStudEnrollChangeID);
            database.AddInParameter(commandWrapper, "@EdStudSemesterLastId ", DbType.Int32, EdStudSemesterLastId);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollFromId ", DbType.Int32, EdCodeEnrollFromId);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollToId", DbType.Int32, EdCodeEnrollToId);            
            database.AddInParameter(commandWrapper, "@ReqDate", DbType.DateTime, ReqDate);
            database.AddOutParameter(commandWrapper, "@RetMsg", DbType.String, 200);
            if(UserID != null)
                database.AddInParameter(commandWrapper, "@UserID", DbType.Decimal, UserID);

            int results = 0;

            //Provider Data Requesting Command Event
            //OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_STUD_InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return commandWrapper.Parameters["@RetMsg"].Value.ToString();
        }
        #endregion
	}
}