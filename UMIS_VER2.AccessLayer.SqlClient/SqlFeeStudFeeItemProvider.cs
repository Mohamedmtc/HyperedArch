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
using System.Data.SqlClient;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
    ///<summary>
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudFeeItem"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlFeeStudFeeItemProvider : SqlFeeStudFeeItemProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlFeeStudFeeItemProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlFeeStudFeeItemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods
        public override decimal InsertWithIdOut(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudFeeItem entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_STUD_FEE_ITEM_InsertIdOut", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@FeeStudFeeItemId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, (entity.EdCodeSemesterId.HasValue ? (object)entity.EdCodeSemesterId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, entity.FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@FeeFacultyItemId", DbType.Decimal, entity.FeeFacultyItemId);
            database.AddInParameter(commandWrapper, "@FeeItemValue", DbType.Decimal, entity.FeeItemValue);
            database.AddInParameter(commandWrapper, "@RemainAmount", DbType.Decimal, entity.RemainAmount);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, entity.GsCodeCurrencyId);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalFeeStudFeeItemId = entity.FeeStudFeeItemId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "InsertWithIdOut", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@FeeStudFeeItemId"].Value);
        }

        public override TList<FeeStudFeeItem> GetByStudentFeeCodeTypeID(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID, decimal currentAcadYear, int codeTypeID, decimal EdCodeSemesterID, decimal GsCodeCurrencyId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_STUD_FEE_ITEM_GetByStudentFeeCodeTypeID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, edStudID);
            database.AddInParameter(commandWrapper, "@facultyID", DbType.Decimal, facultyID);
            database.AddInParameter(commandWrapper, "@currentYearID", DbType.Decimal, currentAcadYear);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeID", DbType.Int32, codeTypeID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Int32, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, GsCodeCurrencyId);
            
            IDataReader reader = null;
            TList<FeeStudFeeItem> tmp = new TList<FeeStudFeeItem>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "FEE_STUD_FEE_ITEM_GetByStudentFeeCodeTypeID", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, 0, 1000);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "FEE_STUD_FEE_ITEM_GetByStudentFeeCodeTypeID", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (tmp.Count > 0)
            {
                return tmp;
            }
            else if (tmp.Count == 0)
            {
                return null;
            }
            else
            {
                throw new DataException("Cannot find the unique instance of the class.");
            }

        }



        public override DataTable GetByStudent(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID, decimal currentAcadYear, int codeTypeID, decimal EdCodeSemesterID, decimal GsCodeCurrencyId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_STUD_FEE_ITEM_GetByStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, edStudID);
            database.AddInParameter(commandWrapper, "@facultyID", DbType.Decimal, facultyID);
            database.AddInParameter(commandWrapper, "@currentYearID", DbType.Decimal, currentAcadYear);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeID", DbType.Int32, codeTypeID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Int32, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, GsCodeCurrencyId);
            

            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByStudent"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetByStudent"));

            return dt;
        }
        public override DataTable GetStudentDelayedFeesItems(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID, decimal EdAcadYearId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentDelayedFeesItems", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, edStudID);
            database.AddInParameter(commandWrapper, "@facultyID", DbType.Decimal, facultyID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FeeCodeItemDescrAr");
            dt.Columns.Add("FeeCodeItemDescrEn");
            dt.Columns.Add("FEE_ITEM_VALUE");
            dt.Columns.Add("DISC_AMOUNT");
            dt.Columns.Add("PAY_AMOUNT");
            dt.Columns.Add("REMAIN_AMOUNT");

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentDelayedFeesItems"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentDelayedFeesItems"));

            return dt;
        }

        //added by mmq at 08-08-2016
        public override DataTable GetFEE_ITEM_STS(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, DateTime? _FromDate, DateTime? _ToDate, String _EnrollType, String _range, string FromJoinYear, string ToJoinYear)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_ITEM_STS", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.String, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.String, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.String, _EdCodeSemester);
            database.AddInParameter(commandWrapper, "@Fromdate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@Todate", DbType.DateTime, _ToDate);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollType", DbType.String, _EnrollType);
            database.AddInParameter(commandWrapper, "@ToEdAcadYearId", DbType.String, _EdAcadYearId_To);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterTo", DbType.String, _EdCodeSemesterTo);
            database.AddInParameter(commandWrapper, "@RangeDu", DbType.String, _range);
            database.AddInParameter(commandWrapper, "@FromJoinYear", DbType.String, FromJoinYear);
            database.AddInParameter(commandWrapper, "@ToJoinYear", DbType.String, ToJoinYear);
            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FEE_CODE_ITEM_ID");
            dt.Columns.Add("FEE_CODE_ITEM_DESCR");
            dt.Columns.Add("DISC_CAT_10");
            dt.Columns.Add("DISC_CAT_Other");
            dt.Columns.Add("FinancialAid");
            dt.Columns.Add("SpecialScholarship");
            dt.Columns.Add("Total_Amount");
            dt.Columns.Add("Total_payments");
            dt.Columns.Add("Total_Remain");
            dt.Columns.Add("TotalStudents");
            dt.Columns.Add("StudPaied");
            dt.Columns.Add("StudNotPaied");
            dt.Columns.Add("RelayAmount");
            dt.Columns.Add("NetAmount");
            dt.Columns.Add("TotalLoaded");
            dt.Columns.Add("TotalLoadedValue");
            dt.Columns.Add("TotalLoadedRemain");
            dt.Columns.Add("TotalRefndValue");

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "FEE_ITEM_STS"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentDelayedFeesItems"));

            return dt;
        }

        public override DataTable GetSTUD_FEE_ITEM_View(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, string _FeeCodeItemId, string _PayFlag, DateTime? _FromDate, DateTime? _ToDate, string _DiscFlag, string _TotalPaymentsFlag, string _RefundFlag, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.STUD_FEE_ITEM_View", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.String, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.String, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.String, _EdCodeSemester);
            database.AddInParameter(commandWrapper, "@FeeCodeItemId", DbType.String, _FeeCodeItemId);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollType", DbType.String, _EnrollType);
            database.AddInParameter(commandWrapper, "@ToEdAcadYearId", DbType.String, _EdAcadYearId_To);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterTo", DbType.String, _EdCodeSemesterTo);
            database.AddInParameter(commandWrapper, "@RangeDu", DbType.String, _range);
            database.AddInParameter(commandWrapper, "@FromJoinYear", DbType.String, FromJoinYear);
            database.AddInParameter(commandWrapper, "@ToJoinYear", DbType.String, ToJoinYear);
            if (_PayFlag != "")
            {
                database.AddInParameter(commandWrapper, "@PAY_FLG", DbType.String, _PayFlag);
            }
            database.AddInParameter(commandWrapper, "@Fromdate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@Todate", DbType.DateTime, _ToDate);
            if (_DiscFlag != "")
            {
                database.AddInParameter(commandWrapper, "@DiscFlag", DbType.String, _DiscFlag);
            }
            if (_TotalPaymentsFlag != "")
            {
                database.AddInParameter(commandWrapper, "@TotalPaymentsFlag", DbType.String, _TotalPaymentsFlag);
            }
            if (_RefundFlag != "")
            {
                database.AddInParameter(commandWrapper, "@refndFlag", DbType.String, _RefundFlag);
            }

            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FULL_NAME");
            dt.Columns.Add("STUD_FACULTY_CODE");
            dt.Columns.Add("FACULTY_DESCR");
            dt.Columns.Add("FEE_ITEM_VALUE");
            dt.Columns.Add("DISC_AMOUNT");
            dt.Columns.Add("REMAIN_AMOUNT");
            dt.Columns.Add("PayedAmount");
            dt.Columns.Add("RelayAmount");
            dt.Columns.Add("ED_STUD_ID");
            dt.Columns.Add("RFND_VALUE");
            dt.Columns.Add("DISC_PERCENT");

            dt.Columns.Add("aid_amount");
            dt.Columns.Add("aid_percent");
            dt.Columns.Add("Scolarship_amount");
            dt.Columns.Add("Scolarship_percent");
            dt.Columns.Add("Special_Disc_amount");
            dt.Columns.Add("Special_Disc_percent");
            dt.Columns.Add("NOTES");
            dt.Columns.Add("TotalSholarshipAndAid");
            dt.Columns.Add("TotalSholarshipAndAidPercent");
            dt.Columns.Add("EarlyPayment_amount");

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "STUD_FEE_ITEM_View"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentDelayedFeesItems"));

            return dt;
        }

        //added by mmq at 16-08-2016GetStudentFeeItemStatus
        public override DataTable GetStudentAllFees(TransactionManager transactionManager, System.Decimal _Lang, string _StudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentAllFees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@edStudId", DbType.Decimal, _StudId);


            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Year_DESCR");
            dt.Columns.Add("SEMESTER_DESCR");
            dt.Columns.Add("FEE_CODE_ITEM_DESCR");
            dt.Columns.Add("Total_Amount");
            dt.Columns.Add("FEE_CODE_ITEM_ID");
            dt.Columns.Add("DISC_CAT");
            dt.Columns.Add("FEE_CDE_DISC_TYPE_ID");
            dt.Columns.Add("DISC_AMNT");

            dt.Columns.Add("Total_payments");
            dt.Columns.Add("Total_Remain");

            dt.Columns.Add("RECEIPT_DATE");
            dt.Columns.Add("RECEIPT_NUM");


            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentAllFees"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentAllFees"));

            return dt;
        }

        ///
        //added by mmq at 22-11-2016 to get student Extra Ch Fees

        public override DataTable GetStudentExtraChFees(TransactionManager transactionManager, System.Decimal _Lang, decimal EdAcadYearId, decimal AsFacultyId, decimal EdCodeSem, string studentCode, decimal _Type, decimal FeeCodeItemId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentsExtraChFees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@FeeCodeItemId", DbType.Decimal, FeeCodeItemId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studentCode);
            database.AddInParameter(commandWrapper, "@Type", DbType.String, _Type);

            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName");
            dt.Columns.Add("STUD_FACULTY_CODE");
            dt.Columns.Add("LevelDescr");
            dt.Columns.Add("FACULTY_DESCR");
            dt.Columns.Add("FEE_ITEM_VALUE");
            dt.Columns.Add("FEE_STUD_FEE_ITEM_ID");

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentsExtraChFees"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentsExtraChFees"));

            return dt;
        }


        

              //added by yassmin gamal at 09-05-2017
        public override DataTable GetSummerFeesandcredithours(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSem, decimal EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSummerFeesandcredithours", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.String, EdStudId);

            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "vm_get_students_fees_stat_new"));

            if (transactionManager != null)
            {
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "vm_get_students_fees_stat_new"));

            return dt;
        }



        //added by mmq at 11-08-2016
        public override DataTable GetByStudentsFeesMatrix(TransactionManager transactionManager, string _Lang, string _AsFacultyInfoID, string _EdAcadYearId
            , string _EdCodeSemesterId, string _EdCodeLevel, DateTime? _Fromdate, DateTime? _Todate, string _PayMethodId, string _Bank,
            string FromJoinYear, string ToJoinYear,string _JoinSemester, string Range, string Credit, string PageIndex
            , string PageSize, string StudID, string EnrollType, string FeesIds, int RemainFlag, decimal Status_Stud)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.vm_get_students_fees_stat_new", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.String, _Lang);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.String, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.String, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@JoinSemester", DbType.String, _JoinSemester);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.String, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevel", DbType.String, _EdCodeLevel);
            database.AddInParameter(commandWrapper, "@Fromdate", DbType.DateTime, _Fromdate);
            database.AddInParameter(commandWrapper, "@Todate", DbType.DateTime, _Todate);
            database.AddInParameter(commandWrapper, "@PayMethodId", DbType.String, _PayMethodId);
            database.AddInParameter(commandWrapper, "@Bank", DbType.String, _Bank);
            //
            database.AddInParameter(commandWrapper, "@FromJoinYear", DbType.String, FromJoinYear);
            database.AddInParameter(commandWrapper, "@ToJoinYear", DbType.String, ToJoinYear);
            database.AddInParameter(commandWrapper, "@Range", DbType.String, Range);
            database.AddInParameter(commandWrapper, "@Credit", DbType.String, Credit);

            database.AddInParameter(commandWrapper, "@PageIndex", DbType.String, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.String, PageSize);
            database.AddInParameter(commandWrapper, "@StudId", DbType.String, StudID);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollType", DbType.String, EnrollType);

            database.AddInParameter(commandWrapper, "@FeesIds", DbType.String, FeesIds);
            database.AddInParameter(commandWrapper, "@RemainFlag", DbType.String, RemainFlag);
            database.AddInParameter(commandWrapper, "@Status_Stud", DbType.String, Status_Stud); //added by esraa yousef 18914 eue 31-7-2022
            DataTable dt = new DataTable();

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "vm_get_students_fees_stat_new"));

            if (transactionManager != null)
            {
                if (Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables.Count>0)
                dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
            }
            else
            {
                if (Utility.ExecuteDataSet(database, commandWrapper).Tables.Count>0)
                dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "vm_get_students_fees_stat_new"));

            return dt;
        }

        ///////////////////////////////////
        public override DataTable GetStudentDelayedFees(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentDelayedFees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, edStudID);
            database.AddInParameter(commandWrapper, "@facultyID", DbType.Decimal, facultyID);
            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("ED_ACAD_YEAR_ID");
            dt.Columns.Add("AcadYearDescrAr");
            dt.Columns.Add("AcadYearDescrEn");
            dt.Columns.Add("TotalFeeAmount");
            dt.Columns.Add("TotalDiscAmount");
            dt.Columns.Add("TotalPayAmount");
            dt.Columns.Add("TotalRemainAmount");

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentDelayedFees"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentDelayedFees"));

            return dt;
        }

        public override DataTable GetStudFeeStatus(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudFeeStatus", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FeeValue");
            table.Columns.Add("DiscAmount");
            table.Columns.Add("ActualValue");
            table.Columns.Add("PayAmount");
            table.Columns.Add("RemainingValue");

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
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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


        //added by mmq at 01-08-2016
        public override DataTable GetStudentFeeItemStatus(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.VM_StudentFeeItemStatus", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _lang);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_ACAD_YEAR");
            table.Columns.Add("ED_CODE_SEMESTER");
            table.Columns.Add("FEE_CODE_TYPE");
            table.Columns.Add("Fees_Amount");
            table.Columns.Add("Remain_Amount");
            table.Columns.Add("Payed_amount");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("FEE_CODE_TYPE_ID");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("DISC_AMOUNT");
            table.Columns.Add("accrued");
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
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
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

        public override DataTable GetStudentFeeItemStatusDetails(TransactionManager transactionManager, System.Decimal _ED_STUD_SEMESTER_ID, System.Decimal _FEE_CODE_TYPE_ID, System.Decimal _lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.VM_StudentFeeItemStatusDetails", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _lang);
            database.AddInParameter(commandWrapper, "@FEE_CODE_TYPE_ID", DbType.Decimal, _FEE_CODE_TYPE_ID);
            database.AddInParameter(commandWrapper, "@ED_STUD_SEMESTER_ID", DbType.Decimal, _ED_STUD_SEMESTER_ID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CODE_ITEM");
            table.Columns.Add("RECEIPT_DATE");
            table.Columns.Add("RECEIPT_NUM");
            table.Columns.Add("FEE_ITEM_VALUE");
            table.Columns.Add("REMAIN_AMOUNT");
            table.Columns.Add("Payed_amount");
            table.Columns.Add("discAmount");
            table.Columns.Add("ED_STUD_SEMESTER_ID");
            table.Columns.Add("FEE_CODE_ITEM_ID");
            table.Columns.Add("ItemValue");//ItemValue
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
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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
        //added by mmq at 04-102016
        public override DataTable GetStudentItemDiscountDetails(TransactionManager transactionManager, System.String _ED_STUD_SEMESTER_ID, System.String _Fee_Code_Item_id, System.Decimal _lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.VM_ItemDiscountDetails", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _lang);
            database.AddInParameter(commandWrapper, "@Fee_Code_Item_id", DbType.Decimal, _Fee_Code_Item_id);
            database.AddInParameter(commandWrapper, "@ED_STUD_SEMESTER_ID", DbType.Decimal, _ED_STUD_SEMESTER_ID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CDE_DISC_TYPE");
            table.Columns.Add("FEE_CDE_DISC_CAT");
            table.Columns.Add("DISC_AMOUNT");
            table.Columns.Add("NOTES");

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
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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

        //added by mmq at 14-12-2016
        public override DataTable GetFEE_ITEM_STS_New(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, DateTime? _FromDate, DateTime? _ToDate, String _EnrollType, String _range, string FromJoinYear, string ToJoinYear, string paymethod, Decimal ActiveStatues)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAllTransactionFees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.String, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@Fromdate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@Todate", DbType.DateTime, _ToDate);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollType", DbType.String, _EnrollType);
            database.AddInParameter(commandWrapper, "@RangeDu", DbType.String, _range);
            database.AddInParameter(commandWrapper, "@FromJoinYear", DbType.String, FromJoinYear);
            database.AddInParameter(commandWrapper, "@ToJoinYear", DbType.String, ToJoinYear);
            database.AddInParameter(commandWrapper, "@PayMethod", DbType.String, paymethod);
            database.AddInParameter(commandWrapper, "@ActiveStatues", DbType.String, ActiveStatues);//Marwa 14/12/2021 17560 
            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FEE_CODE_ITEM_ID");
            dt.Columns.Add("TotalLoadedValue");
            dt.Columns.Add("FEE_CODE_ITEM_DESCR");
            dt.Columns.Add("DISC_CAT_10");
            dt.Columns.Add("DISC_CAT_Other");
            dt.Columns.Add("FinancialAid");
            dt.Columns.Add("SpecialScholarship");
            dt.Columns.Add("FineDiscount");//added by mmq at 18-01-2017
            dt.Columns.Add("TotalStudents");
            dt.Columns.Add("StudPaied");
            dt.Columns.Add("StudNotPaied");
            dt.Columns.Add("Total_payments");
            dt.Columns.Add("Total_Remain");
            dt.Columns.Add("ITEM_ORDR");
            dt.Columns.Add("NetAmount");
            dt.Columns.Add("TotalRefndValue");
            dt.Columns.Add("relay");
            dt.Columns.Add("TotalDisc");
            dt.Columns.Add("TottalyNotPaidCount");
            dt.Columns.Add("NewRelay");
            dt.Columns.Add("NewRelayEnd");
            dt.Columns.Add("RelayPayments");
            dt.Columns.Add("RelayEnd");
            dt.Columns.Add("StudenthaveNoFees");
            //dt.Columns.Add("TotalLoadedRemain");


            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAllTransactionFees"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentDelayedFeesItems"));

            return dt;
        }

        public override DataTable GetSTUD_FEE_ITEM_View_New(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, string _FeeCodeItemId, string _PayFlag, DateTime? _FromDate, DateTime? _ToDate, string _DiscFlag, string _TotalPaymentsFlag, string _RefundFlag, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear, string paymethod, Decimal ActiveStatues)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.STUD_FEE_ITEM_View_New", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.String, _AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.String, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.String, _EdCodeSemester);
            database.AddInParameter(commandWrapper, "@FeeCodeItemId", DbType.String, _FeeCodeItemId);
            database.AddInParameter(commandWrapper, "@EdCodeEnrollType", DbType.String, _EnrollType);
            database.AddInParameter(commandWrapper, "@ToEdAcadYearId", DbType.String, _EdAcadYearId_To);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterTo", DbType.String, _EdCodeSemesterTo);
            database.AddInParameter(commandWrapper, "@RangeDu", DbType.String, _range);
            database.AddInParameter(commandWrapper, "@FromJoinYear", DbType.String, FromJoinYear);
            database.AddInParameter(commandWrapper, "@ToJoinYear", DbType.String, ToJoinYear);
            database.AddInParameter(commandWrapper, "@PayMethod", DbType.String, paymethod);
            database.AddInParameter(commandWrapper, "@ActiveStatues", DbType.String, ActiveStatues);//Marwa 14/12/2021 17560
            if (_PayFlag != "")
            {
                database.AddInParameter(commandWrapper, "@PAY_FLG", DbType.String, _PayFlag);
            }
            database.AddInParameter(commandWrapper, "@Fromdate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@Todate", DbType.DateTime, _ToDate);
            if (_DiscFlag != "")
            {
                database.AddInParameter(commandWrapper, "@DiscFlag", DbType.String, _DiscFlag);
            }
            if (_TotalPaymentsFlag != "")
            {
                database.AddInParameter(commandWrapper, "@TotalPaymentsFlag", DbType.String, _TotalPaymentsFlag);
            }
            if (_RefundFlag != "")
            {
                database.AddInParameter(commandWrapper, "@refndFlag", DbType.String, _RefundFlag);
            }

            IDataReader reader = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("FULL_NAME");
            dt.Columns.Add("STUD_FACULTY_CODE");
            dt.Columns.Add("FACULTY_DESCR");
            dt.Columns.Add("FEE_ITEM_VALUE");
            dt.Columns.Add("DISC_AMOUNT");
            dt.Columns.Add("REMAIN_AMOUNT");
            dt.Columns.Add("PayedAmount");
            dt.Columns.Add("RelayAmount");
            dt.Columns.Add("ED_STUD_ID");
            dt.Columns.Add("RFND_VALUE");
            dt.Columns.Add("DISC_PERCENT");

            dt.Columns.Add("aid_amount");
            dt.Columns.Add("aid_percent");
            dt.Columns.Add("Scolarship_amount");
            dt.Columns.Add("Scolarship_percent");
            dt.Columns.Add("Special_Disc_amount");
            dt.Columns.Add("Special_Disc_percent");
            dt.Columns.Add("NOTES");
            dt.Columns.Add("TotalSholarshipAndAid");
            dt.Columns.Add("TotalSholarshipAndAidPercent");
            dt.Columns.Add("EarlyPayment_amount");
            dt.Columns.Add("EarlyPayment_Percent");
            dt.Columns.Add("Balance");//NewRelay
            dt.Columns.Add("NewRelay");
            dt.Columns.Add("BalanceUpDate");
            dt.Columns.Add("NewRelayEnd");
            dt.Columns.Add("RelayPayments");
            dt.Columns.Add("RelayEnd");
            dt.Columns.Add("FineDiscount_amount");  //added by mmq at 18-01-2017
            dt.Columns.Add("FineDiscount_percent"); //added by mmq at 18-01-2017

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "STUD_FEE_ITEM_View_New"));

            if (transactionManager != null)
            {
                reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString() };
                    dt.Rows.Add(items);
                }
            }
            else
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString(), reader[22].ToString(), reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString(), reader[27].ToString(), reader[28].ToString(), reader[29].ToString() };
                    dt.Rows.Add(items);
                }
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentDelayedFeesItems"));

            return dt;
        }

        /*--solve issue added by maha  confirmed with eng.ALi Mohamed --*/
        public override DataTable CheckStudFeesPaidPerSemester(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdStudId, decimal FeesType)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("CheckStudFeesPay_PerSemester", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@EdStudID", SqlDbType.Decimal).Value = EdStudId;
            command.Parameters.Add("@AcadYearID", SqlDbType.Decimal).Value = EdAcadYearId;
            command.Parameters.Add("@CodeSemesterID", SqlDbType.Decimal).Value = EdCodeSemesterId;
            command.Parameters.Add("@FeesType", SqlDbType.Decimal).Value = FeesType;

            conn.Open();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            return table;

        }
        // Menna 02012022
        public override DataTable GetFeeStudentCourse(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId,
            decimal AsFacultyId, decimal EdCourseId, decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetFeeStudentCourse", this.UseStoredProcedure);




            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyId", DbType.Decimal, AsFacultyId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);


            DataTable dt = null;
            //Create Collection
            try
            {
                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
	
        #endregion
    }
}