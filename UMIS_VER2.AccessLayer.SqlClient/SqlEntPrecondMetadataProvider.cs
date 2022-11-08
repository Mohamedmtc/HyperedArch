#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Linq;
#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntPrecondMetadata"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntPrecondMetadataProvider: SqlEntPrecondMetadataProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntPrecondMetadataProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntPrecondMetadataProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMetadata entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ENT_PRECOND_METADATA_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCodePrecondMdId", DbType.Decimal, entity.EntCodePrecondMdId);
            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@EntPrecondMdId", DbType.Decimal, entity.EntPrecondMdId);
            database.AddInParameter(commandWrapper, "@ObligFlg", DbType.Decimal, (entity.ObligFlg.HasValue ? (object)entity.ObligFlg : System.DBNull.Value));

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


            entity.OriginalEntPrecondMdId = entity.EntPrecondMdId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion
        //----- task 17060--- added by maha---//
        public override TList<EntPrecondMetadata> GetByEntCodeEntityTypeId_StudyMethodID(TransactionManager transactionManager, decimal _entCodeEntityTypeId, decimal _EntityMainID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetPrecondMetadata_ByEntCodeEntityTypeId_StudyMethodID", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, _entCodeEntityTypeId);
            database.AddInParameter(commandWrapper, "@EntityMainID", DbType.Decimal, _EntityMainID);
            

            IDataReader reader = null;
            TList<EntPrecondMetadata> tmp = new TList<EntPrecondMetadata>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntCodeEntityTypeId_StudyMethodID", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                var reder_x = reader;
               //---- Create collection and fill ---//
                int count = 0;
                
                    if(reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                    if (reader.NextResult())
                    {
                        Fill(reader, tmp, 0, count);
                    }
                   
                
                

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEntCodeEntityTypeId_StudyMethodID", tmp));
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


    }
}