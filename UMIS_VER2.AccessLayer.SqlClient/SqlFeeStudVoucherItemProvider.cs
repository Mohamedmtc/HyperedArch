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
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeStudVoucherItem"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlFeeStudVoucherItemProvider : SqlFeeStudVoucherItemProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlFeeStudVoucherItemProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlFeeStudVoucherItemProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods
        public override DataTable GetHistoricalFees(TransactionManager transactionManager,
    System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
    System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _FeeCodeTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetHistoricalFees", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _FacEntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@CurrEdCodeSemId", DbType.Decimal, _CurrEdCodeSemId);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            IDataReader reader = null;
            TList<FeeStudVoucherItem> rows = new TList<FeeStudVoucherItem>();
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CODE_ITEM_ID");
            table.Columns.Add("FEE_ITEM_VALUE");
            table.Columns.Add("FEE_FACULTY_ITEM_ID");
            table.Columns.Add("GS_CODE_CURRENCY_ID");
            table.Columns.Add("FEE_STUD_FEE_ITEM_ID");
            table.Columns.Add("DiscAmount");
            table.Columns.Add("CodeItemDescrAr");
            table.Columns.Add("CodeItemDescrEn");
            table.Columns.Add("CurrDescAr");
            table.Columns.Add("CurrDescrEn");

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetHistoricalFees", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString()};
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

        public override DataTable GetStudVoucherItem(TransactionManager transactionManager,
            System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudVoucherItems", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeesSelectFlag", DbType.Decimal, _SelectFeesFlag);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _FacEntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@CurrEdCodeSemId", DbType.Decimal, _CurrEdCodeSemId);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, _GsCodeCurrencyId);
            IDataReader reader = null;
            TList<FeeStudVoucherItem> rows = new TList<FeeStudVoucherItem>();
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CODE_ITEM_ID");
            table.Columns.Add("FEE_ITEM_VALUE");
            table.Columns.Add("FEE_FACULTY_ITEM_ID");
            table.Columns.Add("GS_CODE_CURRENCY_ID");
            table.Columns.Add("FEE_STUD_FEE_ITEM_ID");
            table.Columns.Add("DiscAmount");
            table.Columns.Add("RemainingAmount");
            table.Columns.Add("CodeItemDescrAr");
            table.Columns.Add("CodeItemDescrEn");
            table.Columns.Add("CurrDescAr");
            table.Columns.Add("CurrDescrEn");
            table.Columns.Add("FEE_CODE_TYPE_ID");
            table.Columns.Add("DISC_FLG");
            table.Columns.Add("YearDescAr");
            table.Columns.Add("YearDescEn");
            table.Columns.Add("FeeCodeItemId");
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("EdStudId");
            table.Columns.Add("Sem_DESCR_AR");
            table.Columns.Add("Sem_DESCR_EN");
            //Added By Mostafa hussien - 18/2/2018 - Bug Bug4191_1
            table.Columns.Add("EDIT_FLG");
            table.Columns.Add("LOAD_DATE");
            // 1-4-2020 esraa yousef 13248 -- task15849  maha 
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("ITEM_ORDR"); //Angham 25/08/2022 BU

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudVoucherItem", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),
                                         reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString()
                                         ,reader[22].ToString(),reader[23].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),
                                         reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString()
                                         ,reader[22].ToString(),reader[23].ToString()};
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


        public override DataTable GetStudVoucherItemBalance(TransactionManager transactionManager,
            System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudVoucherItemBalance", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeesSelectFlag", DbType.Decimal, _SelectFeesFlag);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _FacEntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@CurrEdCodeSemId", DbType.Decimal, _CurrEdCodeSemId);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, _GsCodeCurrencyId);
            IDataReader reader = null;
            TList<FeeStudVoucherItem> rows = new TList<FeeStudVoucherItem>();
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CODE_ITEM_ID");
            table.Columns.Add("FEE_ITEM_VALUE");
            table.Columns.Add("FEE_FACULTY_ITEM_ID");
            table.Columns.Add("GS_CODE_CURRENCY_ID");
            table.Columns.Add("FEE_STUD_FEE_ITEM_ID");
            table.Columns.Add("DiscAmount");
            table.Columns.Add("RemainingAmount");
            table.Columns.Add("CodeItemDescrAr");
            table.Columns.Add("CodeItemDescrEn");
            table.Columns.Add("CurrDescAr");
            table.Columns.Add("CurrDescrEn");
            table.Columns.Add("FEE_CODE_TYPE_ID");
            table.Columns.Add("DISC_FLG");
            table.Columns.Add("YearDescAr");
            table.Columns.Add("YearDescEn");
            table.Columns.Add("FeeCodeItemId");
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("EdStudId");
            table.Columns.Add("Sem_DESCR_AR");
            table.Columns.Add("Sem_DESCR_EN");

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudVoucherItem", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),
                                         reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),
                                         reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString()};
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
        public override DataTable LoadStudVoucherItem(TransactionManager transactionManager,
     System.Decimal _FeeStudVoucherID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadStudVoucherItem", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeStudVoucherID", DbType.Decimal, _FeeStudVoucherID);
            IDataReader reader = null;
            TList<FeeStudVoucherItem> rows = new TList<FeeStudVoucherItem>();
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CODE_ITEM_ID");
            table.Columns.Add("FEE_ITEM_VALUE");
            table.Columns.Add("FEE_FACULTY_ITEM_ID");
            table.Columns.Add("GS_CODE_CURRENCY_ID");
            table.Columns.Add("FEE_STUD_FEE_ITEM_ID");
            table.Columns.Add("DiscAmount");
            table.Columns.Add("RemainingAmount");
            table.Columns.Add("CodeItemDescrAr");
            table.Columns.Add("CodeItemDescrEn");
            table.Columns.Add("CurrDescAr");
            table.Columns.Add("CurrDescrEn");
            table.Columns.Add("FEE_CODE_TYPE_ID");
            table.Columns.Add("DISC_FLG");
            table.Columns.Add("FEE_STUD_VOUCHER_ITEM_ID");
            table.Columns.Add("PAY_AMOUNT");
            table.Columns.Add("TotalPayed");
            table.Columns.Add("YearDescAr");
            table.Columns.Add("YearDescEn");
            table.Columns.Add("FeeCodeItemId");
            table.Columns.Add("EdAcadYearId");
            table.Columns.Add("EdStudId");
            table.Columns.Add("Sem_DESCR_AR");
            table.Columns.Add("Sem_DESCR_EN");
            //Added By Mostafa hussien - 18/2/2018 - Bug Bug4191_2
            table.Columns.Add("EDIT_FLG");
            // 1-4-2020 esraa yousef 13248 ---task15849 maha
            table.Columns.Add("COURSE_CODE");
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "LoadStudVoucherItem", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString()
                                         ,reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString()
                                         ,reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString()};
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




        public override DataTable GetStuditemsDiscound(TransactionManager transactionManager,
      System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
      System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId,System.Decimal _FeeCdeDiscCatId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStuditemsDiscound", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeesSelectFlag", DbType.Decimal, _SelectFeesFlag);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _FacEntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@CurrEdCodeSemId", DbType.Decimal, _CurrEdCodeSemId);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, _GsCodeCurrencyId);
            database.AddInParameter(commandWrapper, "@FeeCdeDiscCatId", DbType.Decimal, _FeeCdeDiscCatId);
            
            IDataReader reader = null;
            TList<FeeStudVoucherItem> rows = new TList<FeeStudVoucherItem>();
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CODE_ITEM_ID");
            table.Columns.Add("FEE_ITEM_VALUE");
            table.Columns.Add("FEE_FACULTY_ITEM_ID");
            table.Columns.Add("GS_CODE_CURRENCY_ID");
            table.Columns.Add("FEE_STUD_FEE_ITEM_ID");
            table.Columns.Add("DiscAmount");
            table.Columns.Add("RemainingAmount");
            table.Columns.Add("CodeItemDescrAr");
            table.Columns.Add("CodeItemDescrEn");
            table.Columns.Add("CurrDescAr");
            table.Columns.Add("CurrDescrEn");
            table.Columns.Add("FEE_CODE_TYPE_ID");
            table.Columns.Add("DISC_FLG");
            table.Columns.Add("SPO_AMOUNT");
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStuditemsDiscound", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString()};
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



        public override DataTable GetStuditemsDiscoundAll(TransactionManager transactionManager,
 System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
 System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId, System.Decimal _FeeStudDisc, System.Decimal _FeeCdeDiscCatId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStuditemsDiscoundAll", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@FeesSelectFlag", DbType.Decimal, _SelectFeesFlag);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _FacEntityMainId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@CurrEdCodeSemId", DbType.Decimal, _CurrEdCodeSemId);
            database.AddInParameter(commandWrapper, "@FeeCodeTypeId", DbType.Decimal, _FeeCodeTypeId);
            database.AddInParameter(commandWrapper, "@GsCodeCurrencyId", DbType.Decimal, _GsCodeCurrencyId);
            database.AddInParameter(commandWrapper, "@FeeCdeDiscCatId", DbType.Decimal, _FeeCdeDiscCatId);
            database.AddInParameter(commandWrapper, "@FeeStudDisc", DbType.Decimal, _FeeStudDisc);
            
            IDataReader reader = null;
            TList<FeeStudVoucherItem> rows = new TList<FeeStudVoucherItem>();
            DataTable table = new DataTable();

            
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStuditemsDiscound", rows));

                if (transactionManager != null)
                {
                    table = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString()
                    //                     ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                    //                     reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString()};
                    //    table.Rows.Add(items);
                    //}
                }
                else
                {
                    table = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                
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



        public override DataTable LoadStuditemsDiscound(TransactionManager transactionManager,
   System.Decimal _FeeStudDiscId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadStuditemsDiscound", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeStudDiscId", DbType.Decimal, _FeeStudDiscId);
            IDataReader reader = null;
            TList<FeeStudVoucherItem> rows = new TList<FeeStudVoucherItem>();
            DataTable table = new DataTable();
            table.Columns.Add("FEE_CODE_ITEM_ID");
            table.Columns.Add("FEE_ITEM_VALUE");
            table.Columns.Add("FEE_FACULTY_ITEM_ID");
            table.Columns.Add("GS_CODE_CURRENCY_ID");
            table.Columns.Add("FEE_STUD_FEE_ITEM_ID");
            table.Columns.Add("DiscAmount");
            table.Columns.Add("RemainingAmount");
            table.Columns.Add("CodeItemDescrAr");
            table.Columns.Add("CodeItemDescrEn");
            table.Columns.Add("CurrDescAr");
            table.Columns.Add("CurrDescrEn");
            table.Columns.Add("FEE_CODE_TYPE_ID");
            table.Columns.Add("DISC_FLG");
            table.Columns.Add("SPO_AMOUNT");
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStuditemsDiscound", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()
                                         ,reader[5].ToString(),reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),
                                         reader[10].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString()};
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





        public override decimal GetStudentPayed(System.Decimal FeeStudFeeItemId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentPayed", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FeeStudFeeItemId", DbType.Decimal, FeeStudFeeItemId);
            IDataReader reader = null;
            
               
                    return decimal.Parse( Utility.ExecuteScalar(database, commandWrapper).ToString());
             
            }


        }

        #endregion
    }
