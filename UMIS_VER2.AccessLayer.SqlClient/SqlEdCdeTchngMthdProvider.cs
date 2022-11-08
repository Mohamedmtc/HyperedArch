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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCdeTchngMthd"/> entity.
	///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlEdCdeTchngMthdProvider : SqlEdCdeTchngMthdProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlEdCdeTchngMthdProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlEdCdeTchngMthdProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeTchngMthd entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_CDE_TCHNG_MTHD_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdCdeTchngMthdId", DbType.Decimal, 4);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);

            database.AddInParameter(commandWrapper, "@AbsChWeight", DbType.Decimal, (entity.AbsChWeight.HasValue ? (object)entity.AbsChWeight : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FingerPrintDelayTime", DbType.Decimal, (entity.FingerPrintDelayTime.HasValue ? (object)entity.FingerPrintDelayTime : System.DBNull.Value));

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

            entity.EdCdeTchngMthdId = (decimal)commandWrapper.Parameters["@EdCdeTchngMthdId"].Value;
            entity.OriginalEdCdeTchngMthdId = entity.EdCdeTchngMthdId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override TList<EdCdeTchngMthd> GetAllCourseTchngMthd(TransactionManager transactionManager, System.Decimal _edCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseTchngMthd", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);

            IDataReader reader = null;

            //Create Collection
            TList<EdCdeTchngMthd> rows = new TList<EdCdeTchngMthd>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAllCourseTchngMthd", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAllCourseTchngMthd", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall

        public override TList<EdCdeTchngMthd> GetTeachingMethod_SchdlSlot(TransactionManager transactionManager, System.Decimal _SchdleSlotID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetTeachingMethodbySchdleSlot", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SchdleSlotID", SqlDbType.Decimal, _SchdleSlotID);
            IDataReader reader = null;

            //Create Collection
            TList<EdCdeTchngMthd> rows = new TList<EdCdeTchngMthd>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetTeachingMethod_SchdlSlot", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetTeachingMethod_SchdlSlot", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall
       
    }
}