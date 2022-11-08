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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="GsCountryNode"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlGsCountryNodeProvider: SqlGsCountryNodeProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlGsCountryNodeProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlGsCountryNodeProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        public override void SetIsLocalChilds(TransactionManager transactionManager, System.Decimal isLocal, System.Decimal parentID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GS_COUNTRY_NODE_LOCAL_CHILD", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@islocal", DbType.Decimal, isLocal);
            database.AddInParameter(commandWrapper, "@parentID", DbType.Decimal, parentID);

            IDataReader reader = null;
            string Path = "";
            TList<GsCountryNode> rows = new TList<GsCountryNode>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SetIsLocalChilds", rows));

                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "SetIsLocalChilds", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
        }
        public override void SetIsLocal(TransactionManager transactionManager, System.Decimal isLocal, System.Decimal NodeID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GS_COUNTRY_NODE_SET_IS_LOCAL", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@islocal", DbType.Decimal, isLocal);
            database.AddInParameter(commandWrapper, "@nodeID", DbType.Decimal, NodeID);

            IDataReader reader = null;
            string Path = "";
            TList<GsCountryNode> rows = new TList<GsCountryNode>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SetIsLocal", rows));

                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "SetIsLocal", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
        }
        public override string GetCountryNodePath(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, System.Decimal _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GsCountryNodePath", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, _gsCountryNodeId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);

            IDataReader reader = null;
            string Path = "";
            TList<GsCountryNode> rows = new TList<GsCountryNode>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GsCountryNodePath", rows));

                if (transactionManager != null)
                {
                    Path = Utility.ExecuteScalar(transactionManager, commandWrapper) != System.DBNull.Value ? (string)Utility.ExecuteScalar(transactionManager, commandWrapper) : "";
                }
                else
                {
                    Path = Utility.ExecuteScalar(database, commandWrapper) != System.DBNull.Value ? (string)Utility.ExecuteScalar(database, commandWrapper) : "";
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GsCountryNodePath", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return Path;
        }
        public override TList<GsCountryNode> SelectByGsCodeCNodeNatureforignkeys(TransactionManager transactionManager, System.Decimal gscodecnodenatureid)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GS_CODE_C_NODE_NATUREGS_COUNTR", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@GsCodeCNodeNatureId", DbType.Decimal, gscodecnodenatureid);

            IDataReader reader = null;
            string Path = "";
            TList<GsCountryNode> rows = new TList<GsCountryNode>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SelectByGsCodeCNodeNatureforignkeys", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "SelectByGsCodeCNodeNatureforignkeys", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override TList<GsCountryNode> SelectByGsCountryNodeforignkeys(TransactionManager transactionManager, System.Decimal nodeparentid)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GS_COUNTRY_NODEGS_COUNTRY_NODE", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@NodeParentId", DbType.Decimal, nodeparentid);

            IDataReader reader = null;
            string Path = "";
            TList<GsCountryNode> rows = new TList<GsCountryNode>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SelectByGsCountryNodeforignkeys", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "SelectByGsCountryNodeforignkeys", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override TList<GsCountryNode> getDistrictsonCurrentCountry(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_getDistrictsonCurrentCountru", this.UseStoredProcedure);

         

            IDataReader reader = null;
            string Path = "";
            TList<GsCountryNode> rows = new TList<GsCountryNode>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "getDistrictsonCurrentCountry", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "getDistrictsonCurrentCountry", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override TList<GsCountryNode> GetAllCountries(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetNationalities", this.UseStoredProcedure);

            //database.AddInParameter(commandWrapper, "@GsCodeCNodeNatureId", DbType.Decimal, gscodecnodenatureid);

            IDataReader reader = null;
            string Path = "";
            TList<GsCountryNode> rows = new TList<GsCountryNode>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetNationalities", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetNationalities", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        #endregion
    }
}