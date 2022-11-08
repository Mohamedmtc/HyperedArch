#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudCodeChng"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudCodeChngProvider: SqlEdStudCodeChngProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudCodeChngProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudCodeChngProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
        #region custom Methods
        //added by dalia 28-6-2012

        public override DataTable GetSTUDCODECHNGByStuDId(TransactionManager transactionManager, decimal ED_STUD_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SP_STUD_CODE_CHNG", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, ED_STUD_ID);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_CODE_CHNG_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("OLD_STUD_CODE");
            table.Columns.Add("NEW_STUD_CODE");
            table.Columns.Add("CHNG_DATE");
            table.Columns.Add("IS_LAST");
            table.Columns.Add("REASON");
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

                //FillView(reader, table, start, pageLength);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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
        }//end GetAllForView
        
        public override DataTable GetAcadymicYearGrThanCurrentYear(TransactionManager transactionManager, decimal ED_STUD_ID,decimal asFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetAcadymicYearGrThanCurrentYear", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, ED_STUD_ID);
            database.AddInParameter(commandWrapper, "@as_faculty_info_id", DbType.Decimal, asFacultyInfoId);
            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("ED_ACAD_YEAR_ID");


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

                //FillView(reader, table, start, pageLength);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetMaxChgCode(TransactionManager transactionManager, decimal ED_STUD_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SP_GetMaxChgCode", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, ED_STUD_ID);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_CODE_CHNG_ID");


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

                //FillView(reader, table, start, pageLength);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString()};
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

        public override bool InsertNewCode(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChng entity, decimal as_faculty_info_id)
     {
         SqlDatabase database = new SqlDatabase(this.ConnectionString);
         DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "ED_STUD_CODE_CHNG_InsertNewCode", UseStoredProcedure);

         database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
         database.AddInParameter(commandWrapper, "@NewStudCode", DbType.String, entity.NewStudCode);
         database.AddInParameter(commandWrapper, "@ChangDate", DbType.DateTime, entity.ChngDate);
         database.AddInParameter(commandWrapper, "@NOTES", DbType.String, entity.Notes);
         database.AddInParameter(commandWrapper, "@OldStudCode", DbType.String, entity.OldStudCode);
         database.AddInParameter(commandWrapper, "@as_faculty_info_id", DbType.String, as_faculty_info_id);
         int results = 0;

         //Provider Data Requesting Command Event
         OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertNewCode", entity));

         if (transactionManager != null)
         {
             results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
         }
         else
         {
             results = Utility.ExecuteNonQuery(database, commandWrapper);
         }


         entity.AcceptChanges();

         //Provider Data Requested Command Event
         OnDataRequested(new CommandEventArgs(commandWrapper, "InsertNewCode", entity));

         return Convert.ToBoolean(results);
     }	
   
        public override bool UpdateNewCode(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCodeChng entity)
     {
         SqlDatabase database = new SqlDatabase(this.ConnectionString);
         DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "ED_STUD_CODE_CHNG_UpdateNewCode", UseStoredProcedure);

         database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, entity.EdStudId);
         database.AddInParameter(commandWrapper, "@NewStudCode", DbType.String, entity.NewStudCode);
         database.AddInParameter(commandWrapper, "@ChangDate", DbType.DateTime, entity.ChngDate);
         database.AddInParameter(commandWrapper, "@NOTES", DbType.String, entity.Notes);
         database.AddInParameter(commandWrapper, "@OldStudCode", DbType.String, entity.OldStudCode);
         database.AddInParameter(commandWrapper, "@ED_STUD_CODE_CHNG_ID", DbType.String, entity.EdStudCodeChngId);
         int results = 0;

         //Provider Data Requesting Command Event
         OnDataRequesting(new CommandEventArgs(commandWrapper, "UpdateNewCode", entity));

         if (transactionManager != null)
         {
             results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
         }
         else
         {
             results = Utility.ExecuteNonQuery(database, commandWrapper);
         }


         entity.AcceptChanges();

         //Provider Data Requested Command Event
         OnDataRequested(new CommandEventArgs(commandWrapper, "UpdateNewCode", entity));

         return Convert.ToBoolean(results);
     }	
  
        #endregion
    }
}