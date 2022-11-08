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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCodeGrading"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCodeGradingProvider: SqlEdCodeGradingProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCodeGradingProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCodeGradingProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override TList<EdCodeGrading> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_CODE_GRADING_Get_List", UseStoredProcedure);

            IDataReader reader = null;

            //Create Collection
            TList<EdCodeGrading> rows = new TList<EdCodeGrading>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAll", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGrading entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_CODE_GRADING_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, entity.EdCodeGradingId);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@SymbolAr", DbType.String, entity.SymbolAr);
            database.AddInParameter(commandWrapper, "@SymbolEn", DbType.String, entity.SymbolEn);
            database.AddInParameter(commandWrapper, "@GradOrder", DbType.String, entity.GradOrder);
            database.AddInParameter(commandWrapper, "@GradCode", DbType.String, entity.GradCode);

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


            entity.OriginalEdCodeGradingId = entity.EdCodeGradingId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGrading entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_CODE_GRADING_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, entity.EdCodeGradingId);
            database.AddInParameter(commandWrapper, "@OriginalEdCodeGradingId", DbType.Decimal, entity.OriginalEdCodeGradingId);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@SymbolAr", DbType.String, entity.SymbolAr);
            database.AddInParameter(commandWrapper, "@SymbolEn", DbType.String, entity.SymbolEn);
            database.AddInParameter(commandWrapper, "@GradOrder", DbType.String, entity.GradOrder);
            database.AddInParameter(commandWrapper, "@GradCode", DbType.String, entity.GradCode);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Stop Tracking Now that it has been updated and persisted.
            if (DataRepository.Provider.EnableEntityTracking)
                EntityManager.StopTracking(entity.EntityTrackingKey);

            entity.OriginalEdCodeGradingId = entity.EdCodeGradingId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }

        #endregion

        #region Custom Methods
        public override string GetMaxGradeOrder(TransactionManager transactionManager)
        {
            string Order = "";
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetMaxGradeOrder", this.UseStoredProcedure);

            IDataReader reader = null;
            TList<EdStud> rows = new TList<EdStud>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetMaxGradeOrder", rows));

                if (transactionManager != null)
                {
                    Order = Utility.ExecuteScalar(transactionManager, commandWrapper).ToString();
                }
                else
                {
                    Order = Utility.ExecuteScalar(database, commandWrapper).ToString();
                }


                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetMaxGradeOrder", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return Order;
        }

        public override DataTable GetAllForHonorDegree(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edCodeGradingTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAllForHonorDegree", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeGradingTypeId", DbType.Decimal, _edCodeGradingTypeId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdCodeGradingId");
            table.Columns.Add("EntPolicyGradingHdrId");
            table.Columns.Add("DescrAr");
            table.Columns.Add("DescrEn");

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
        #endregion
	}
}