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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntPolicyGradingDtl"/> entity.
	///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlEntPolicyGradingDtlProvider : SqlEntPolicyGradingDtlProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlEntPolicyGradingDtlProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlEntPolicyGradingDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }
        #region Custom Methods
        //public override TList<EntPolicyGradingDtl> GetStudAccumGrading(TransactionManager transactionManager, System.Decimal EdacadYearId, System.Decimal _AsFacultyInfoId, System.Decimal _edCodeGradingTypeId, System.Decimal _AsCodeDegreeClassId)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudAccumGradingScheme", this.UseStoredProcedure);

        //    database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, EdacadYearId);
        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
        //    database.AddInParameter(commandWrapper, "@EdCodeGradingTypeId", DbType.Decimal, _edCodeGradingTypeId);
        //    database.AddInParameter(commandWrapper, "@ascodedegreeclassid", DbType.Decimal, _AsCodeDegreeClassId);


        //    IDataReader reader = null;
        //    TList<EntPolicyGradingDtl> rows = new TList<EntPolicyGradingDtl>();
        //    try
        //    {
        //        //Provider Data Requesting Command Event
        //        OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudAccumGrading", rows));

        //        if (transactionManager != null)
        //        {
        //            reader = Utility.ExecuteReader(transactionManager, commandWrapper);
        //        }
        //        else
        //        {
        //            reader = Utility.ExecuteReader(database, commandWrapper);
        //        }

        //        //Create Collection
        //        Fill(reader, rows, 0, int.MaxValue);
        //        int count = -1;
        //        if (reader.NextResult())
        //        {
        //            if (reader.Read())
        //            {
        //                count = reader.GetInt32(0);
        //            }
        //        }

        //        //Provider Data Requested Command Event
        //        OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudAccumGrading", rows));
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //            reader.Close();

        //        commandWrapper = null;
        //    }
        //    return rows;
        //}
        public override DataTable GetStudAccumGrading(TransactionManager transactionManager, System.Decimal EdacadYearId, System.Decimal _AsFacultyInfoId, System.Decimal _edCodeGradingTypeId, System.Decimal _AsCodeDegreeClassId, decimal flag, 
            decimal? Major_Id = null , string BylawYearMajorId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudAccumGradingScheme", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, EdacadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeGradingTypeId", DbType.Decimal, _edCodeGradingTypeId);
            database.AddInParameter(commandWrapper, "@ascodedegreeclassid", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@Flag", DbType.Decimal, flag);
            if (Major_Id.HasValue)
                database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, Major_Id);

            database.AddInParameter(commandWrapper, "@AcadPlanId", DbType.String, BylawYearMajorId); 


            IDataReader reader = null;
            DataTable table = new DataTable();
            if (flag == 0)
            {
                table.Columns.Add("ENT_POLICY_GRADING_DTL_ID");
                table.Columns.Add("DESCR_AR");
                table.Columns.Add("DESCR_EN");
                table.Columns.Add("GRAD_CODE");
                table.Columns.Add("SYMBOL_AR");
                table.Columns.Add("SYMBOL_EN");
                table.Columns.Add("GRAD_ORDER");
                table.Columns.Add("MIN_RATE");
                table.Columns.Add("MAX_RATE");
                table.Columns.Add("GS_CODE_PASS_FAIL_ID");
                table.Columns.Add("POINTS");
                table.Columns.Add("AcadDescEn");
                table.Columns.Add("acadDescAR");
                table.Columns.Add("FACULTY_DESCR_AR");
                table.Columns.Add("FACULTY_DESCR_EN");
                table.Columns.Add("AS_FACULTY_INFO_ID");
                table.Columns.Add("ED_ACAD_YEAR_ID");
                table.Columns.Add("AS_CODE_DEGREE_CLASS_ID");
                table.Columns.Add("ED_CODE_GRADING_ID");
                table.Columns.Add("Major_AR");
                table.Columns.Add("Major_EN");
            }
            else
            {
                table.Columns.Add("AcadDescEn");
                table.Columns.Add("acadDescAR");
                table.Columns.Add("FACULTY_DESCR_AR");
                table.Columns.Add("FACULTY_DESCR_EN");
                table.Columns.Add("AS_FACULTY_INFO_ID");
                table.Columns.Add("ED_ACAD_YEAR_ID");
                table.Columns.Add("AS_CODE_DEGREE_CLASS_ID");
            }

            try
            {
                if (flag != 0)
                {
                    if (transactionManager != null)
                    {
                        reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                        //read data
                        while (reader.Read())
                        {


                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };

                            table.Rows.Add(items);
                        }
                    }
                    else
                    {
                        reader = Utility.ExecuteReader(database, commandWrapper);
                        //read data
                        while (reader.Read())
                        {

                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };

                            table.Rows.Add(items);
                        }
                    }
                }


                else
                {
                    if (transactionManager != null)
                    {
                        reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                        //read data
                        while (reader.Read())
                        {


                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };

                            table.Rows.Add(items);
                        }
                    }
                    else
                    {
                        reader = Utility.ExecuteReader(database, commandWrapper);
                        //read data
                        while (reader.Read())
                        {

                            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString() };

                            table.Rows.Add(items);
                        }
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


        public override UMIS_VER2.BusinessLyer.EntPolicyGradingDtl GetStudAccumGrading(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _TotalGpa, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudAccumGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@edStudId", DbType.Decimal, _edStudId);
            database.AddInParameter(commandWrapper, "@TotalGpa", DbType.Decimal, _TotalGpa);

            IDataReader reader = null;
            TList<EntPolicyGradingDtl> tmp = new TList<EntPolicyGradingDtl>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudAccumGrading", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudAccumGrading", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (tmp.Count == 1)
            {
                return tmp[0];
            }
            else if (tmp.Count == 0)
            {
                return null;
            }
            else
            {
                throw new DataException("Cannot find the unique instance of the class.");
            }

            //return rows;
        }
        public override DataTable GetSuccessGrading(TransactionManager transactionManager, System.Decimal _entMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSuccessGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_BYLAW_ID", DbType.Decimal, _entMainId);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ED_CODE_GRADING_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ENT_POLICY_GRADING_HDR_ID");
            table.Columns.Add("ENT_POLICY_GRADING_Dtl_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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

        public override DataTable GetEntPolicyGrdDtlUsingEdCodeGrdType(TransactionManager transactionManager, System.Decimal _AsFaculityInfoId, decimal _AsCodeDegreeClassId, System.Decimal _EdCodeGradingTypeId, decimal _EdByLawId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEntPolicyGrdDtlUsingEdCodeGrdType", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFaculityInfoId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@ED_CODE_GRADING_TYPE_ID", DbType.Decimal, _EdCodeGradingTypeId);
            database.AddInParameter(commandWrapper, "@EdBylawID", DbType.Decimal, _EdByLawId);

            IDataReader reader = null;
            //    TList<EntPolicyGradingDtl> rows = new TList<EntPolicyGradingDtl>();
            //    try
            //    {
            //        //Provider Data Requesting Command Event
            //        OnDataRequesting(new CommandEventArgs(commandWrapper, "GetEntPolicyGrdDtlUsingEdCodeGrdType", rows));

            //        if (transactionManager != null)
            //        {
            //            reader = Utility.ExecuteReader(transactionManager, commandWrapper);
            //        }
            //        else
            //        {
            //            reader = Utility.ExecuteReader(database, commandWrapper);
            //        }

            //        //Create collection and fill
            //        Fill(reader, rows, 0, int.MaxValue);

            //        //Provider Data Requested Command Event
            //        OnDataRequested(new CommandEventArgs(commandWrapper, "GetEntPolicyGrdDtlUsingEdCodeGrdType", rows));
            //    }
            //    finally
            //    {
            //        if (reader != null)
            //            reader.Close();

            //        commandWrapper = null;
            //    }

            //    return rows;
            //}
            DataTable table = new DataTable();
            table.Columns.Add("ED_CODE_GRADING_ID");
            table.Columns.Add("DESCR_AR");

            table.Columns.Add("DESCR_EN");
            table.Columns.Add("SYMBOL_AR");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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

        public override DataTable GetCourseGradingGeneralby_EdByLawID(TransactionManager transactionManager, System.Decimal _EdByLawID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetCourseGradingGeneralbyEdByLawID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdByLawID", DbType.Decimal, _EdByLawID);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ED_CODE_GRADING_ID");
            table.Columns.Add("SymbolAr");
            table.Columns.Add("SymbolEn");
            table.Columns.Add("DescGradAr");
            table.Columns.Add("DescGradEn");
           

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };

                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };

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

        #endregion

    }
}