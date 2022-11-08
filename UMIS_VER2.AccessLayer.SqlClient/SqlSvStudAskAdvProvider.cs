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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvStudAskAdv"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSvStudAskAdvProvider: SqlSvStudAskAdvProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSvStudAskAdvProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSvStudAskAdvProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override DataTable GetAllForView(TransactionManager transactionManager, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_STUD_ASK_ADV_GetAllForView", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("QUEST_DATE");
            table.Columns.Add("QUEST_DTL");
            table.Columns.Add("NoOfReplies");
            table.Columns.Add("SV_STUD_ASK_ADV_ID");

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
        public override DataTable GetTopOneAnswer(TransactionManager transactionManager, System.Decimal _SvStudAskAdvId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_STUD_ASK_ADV_GetTopOneAnswer", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@SvStudAskAdvId", DbType.Decimal, _SvStudAskAdvId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_STUD_ASK_ADV_ID");
            table.Columns.Add("SV_STUD_ASK_ADV_RE_ID");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("RE_DATE");


            try
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
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;

        }
        public override DataTable GetAllQuestionsForStaff(TransactionManager transactionManager, System.Decimal _SaStfMemberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_STUD_ASK_ADV_GetAllQuestionsForStaff", this.UseStoredProcedure);
            //EntCoursePkgHdrId
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_STUD_ASK_ADV_ID");
            table.Columns.Add("QUEST_DATE");
            table.Columns.Add("QUEST_DTL");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("NoOfReplies");
            table.Columns.Add("ED_STUD_ID");


            try
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