﻿/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file SqlSaStfAttendProvider.cs instead.
*/

#region using directives

using System;
using System.Data;
using System.Data.Common;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using System.Collections;
using System.Collections.Specialized;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SaStfAttend"/> entity.
	///</summary>
	public abstract partial class SqlSaStfAttendProviderBase : SaStfAttendProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlSaStfAttendProviderBase"/> instance.
		/// </summary>
		public SqlSaStfAttendProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlSaStfAttendProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlSaStfAttendProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
	{
		this._connectionString = connectionString;
		this._useStoredProcedure = useStoredProcedure;
		this._providerInvariantName = providerInvariantName;
	}
		
	#endregion "Constructors"
	
		#region Public properties
	/// <summary>
    /// Gets or sets the connection string.
    /// </summary>
    /// <value>The connection string.</value>
    public string ConnectionString
	{
		get {return this._connectionString;}
		set {this._connectionString = value;}
	}
	
	/// <summary>
    /// Gets or sets a value indicating whether to use stored procedures.
    /// </summary>
    /// <value><c>true</c> if we choose to use use stored procedures; otherwise, <c>false</c>.</value>
	public bool UseStoredProcedure
	{
		get {return this._useStoredProcedure;}
		set {this._useStoredProcedure = value;}
	}
	
	/// <summary>
    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
    /// </summary>
    /// <value>The name of the provider invariant.</value>
    public string ProviderInvariantName
    {
        get { return this._providerInvariantName; }
        set { this._providerInvariantName = value; }
    }
	#endregion
	
		#region Get Many To Many Relationship Functions
		#endregion
	
		#region Delete Functions
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saStfAttendId">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Decimal _saStfAttendId)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@SaStfAttendId", DbType.Decimal, _saStfAttendId);
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete")); 

			int results = 0;
			
			if (transactionManager != null)
			{	
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
			{
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(SaStfAttend)
					,_saStfAttendId);
				EntityManager.StopTracking(entityKey);
			}
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Delete")); 

			commandWrapper = null;
			
			return Convert.ToBoolean(results);
		}//end Delete
		#endregion

		#region Find Functions

		#region Parsed Find Methods
		/// <summary>
		/// 	Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks>Operators must be capitalized (OR, AND).</remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfAttend objects.</returns>
		public override TList<SaStfAttend> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<SaStfAttend>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@SaStfAttendId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@AttDate", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@AbsenceFlg", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@ExecuseFlg", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, DBNull.Value);
	
			// replace all instances of 'AND' and 'OR' because we already set searchUsingOR
			whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|") ; 
			string[] clauses = whereClause.ToLower().Split('|');
		
			// Here's what's going on below: Find a field, then to get the value we
			// drop the field name from the front, trim spaces, drop the '=' sign,
			// trim more spaces, and drop any outer single quotes.
			// Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"
				
			char[] equalSign = {'='};
			char[] singleQuote = {'\''};
	   		foreach (string clause in clauses)
			{
				if (clause.Trim().StartsWith("sa_stf_attend_id ") || clause.Trim().StartsWith("sa_stf_attend_id="))
				{
					database.SetParameterValue(commandWrapper, "@SaStfAttendId", 
						clause.Trim().Remove(0,16).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sa_stf_member_id ") || clause.Trim().StartsWith("sa_stf_member_id="))
				{
					database.SetParameterValue(commandWrapper, "@SaStfMemberId", 
						clause.Trim().Remove(0,16).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("att_date ") || clause.Trim().StartsWith("att_date="))
				{
					database.SetParameterValue(commandWrapper, "@AttDate", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("absence_flg ") || clause.Trim().StartsWith("absence_flg="))
				{
					database.SetParameterValue(commandWrapper, "@AbsenceFlg", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("execuse_flg ") || clause.Trim().StartsWith("execuse_flg="))
				{
					database.SetParameterValue(commandWrapper, "@ExecuseFlg", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("from_time ") || clause.Trim().StartsWith("from_time="))
				{
					database.SetParameterValue(commandWrapper, "@FromTime", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("to_time ") || clause.Trim().StartsWith("to_time="))
				{
					database.SetParameterValue(commandWrapper, "@ToTime", 
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<SaStfAttend> rows = new TList<SaStfAttend>();
	
				
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
				
				Fill(reader, rows, start, pageLength);
				
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if (reader != null) 
					reader.Close();	
					
				commandWrapper = null;
			}
			return rows;
		}

		#endregion Parsed Find Methods
		
		#region Parameterized Find Methods
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfAttend objects.</returns>
		public override TList<SaStfAttend> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_Find_Dynamic", typeof(SaStfAttendColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<SaStfAttend> rows = new TList<SaStfAttend>();
			IDataReader reader = null;
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

				if ( transactionManager != null )
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}
				
				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;
				
				if ( reader.NextResult() )
				{
					if ( reader.Read() )
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if ( reader != null )
					reader.Close();
					
				commandWrapper = null;
			}
			
			return rows;
		}
		
		#endregion Parameterized Find Methods
		
		#endregion Find Functions
	
		#region GetAll Methods
				
		/// <summary>
		/// 	Gets All rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfAttend objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SaStfAttend> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<SaStfAttend> rows = new TList<SaStfAttend>();
			
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
				if(reader.NextResult())
				{
					if(reader.Read())
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
		}//end getall
		
		#endregion
				
		#region GetPaged Methods
				
		/// <summary>
		/// Gets a page of rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfAttend objects.</returns>
		public override TList<SaStfAttend> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_GetPaged", _useStoredProcedure);
		
			
            if (commandWrapper.CommandType == CommandType.Text
                && commandWrapper.CommandText != null)
            {
                commandWrapper.CommandText = commandWrapper.CommandText.Replace(SqlUtil.PAGE_INDEX, string.Concat(SqlUtil.PAGE_INDEX, Guid.NewGuid().ToString("N").Substring(0, 8)));
            }
			
			database.AddInParameter(commandWrapper, "@WhereClause", DbType.String, whereClause);
			database.AddInParameter(commandWrapper, "@OrderBy", DbType.String, orderBy);
			database.AddInParameter(commandWrapper, "@PageIndex", DbType.Int32, start);
			database.AddInParameter(commandWrapper, "@PageSize", DbType.Int32, pageLength);
		
			IDataReader reader = null;
			//Create Collection
			TList<SaStfAttend> rows = new TList<SaStfAttend>();
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}
				
				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;

				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

			}
			catch(Exception)
			{			
				throw;
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
		
		#region Get By Foreign Key Functions

		#region GetBySaStfMemberId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_STF_ATTEND_SA_STF_MEMBER key.
		///		FK_SA_STF_ATTEND_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaStfAttend objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SaStfAttend> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_GetBySaStfMemberId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _saStfMemberId);
			
			IDataReader reader = null;
			TList<SaStfAttend> rows = new TList<SaStfAttend>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySaStfMemberId", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}
			
				//Create Collection
				Fill(reader, rows, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySaStfMemberId", rows)); 
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
	
	#endregion
	
		#region Get By Index Functions

		#region GetBySaStfAttendId
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_STF_ATTEND index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfAttendId"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaStfAttend"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override UMIS_VER2.BusinessLyer.SaStfAttend GetBySaStfAttendId(TransactionManager transactionManager, System.Decimal _saStfAttendId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_GetBySaStfAttendId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@SaStfAttendId", DbType.Decimal, _saStfAttendId);
			
			IDataReader reader = null;
			TList<SaStfAttend> tmp = new TList<SaStfAttend>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySaStfAttendId", tmp)); 

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
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySaStfAttendId", tmp));
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
		
		#endregion

	#endregion Get By Index Functions

		#region Insert Methods
		/// <summary>
		/// Lets you efficiently bulk insert many entities to the database.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entities">The entities.</param>
		/// <remarks>
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.SaStfAttend object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<UMIS_VER2.BusinessLyer.SaStfAttend> entities)
		{
			//System.Data.SqlClient.SqlBulkCopy bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			
			System.Data.SqlClient.SqlBulkCopy bulkCopy = null;
	
			if (transactionManager != null && transactionManager.IsOpen)
			{			
				System.Data.SqlClient.SqlConnection cnx = transactionManager.TransactionObject.Connection as System.Data.SqlClient.SqlConnection;
				System.Data.SqlClient.SqlTransaction transaction = transactionManager.TransactionObject as System.Data.SqlClient.SqlTransaction;
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(cnx, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints, transaction); //, null);
			}
			else
			{
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			}
			
			bulkCopy.BulkCopyTimeout = 360;
			bulkCopy.DestinationTableName = "SA_STF_ATTEND";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("SA_STF_ATTEND_ID", typeof(System.Decimal));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("SA_STF_MEMBER_ID", typeof(System.Decimal));
			col1.AllowDBNull = false;		
			DataColumn col2 = dataTable.Columns.Add("ATT_DATE", typeof(System.DateTime));
			col2.AllowDBNull = false;		
			DataColumn col3 = dataTable.Columns.Add("ABSENCE_FLG", typeof(System.Decimal));
			col3.AllowDBNull = false;		
			DataColumn col4 = dataTable.Columns.Add("EXECUSE_FLG", typeof(System.Decimal));
			col4.AllowDBNull = false;		
			DataColumn col5 = dataTable.Columns.Add("FROM_TIME", typeof(System.DateTime));
			col5.AllowDBNull = true;		
			DataColumn col6 = dataTable.Columns.Add("TO_TIME", typeof(System.DateTime));
			col6.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("SA_STF_ATTEND_ID", "SA_STF_ATTEND_ID");
			bulkCopy.ColumnMappings.Add("SA_STF_MEMBER_ID", "SA_STF_MEMBER_ID");
			bulkCopy.ColumnMappings.Add("ATT_DATE", "ATT_DATE");
			bulkCopy.ColumnMappings.Add("ABSENCE_FLG", "ABSENCE_FLG");
			bulkCopy.ColumnMappings.Add("EXECUSE_FLG", "EXECUSE_FLG");
			bulkCopy.ColumnMappings.Add("FROM_TIME", "FROM_TIME");
			bulkCopy.ColumnMappings.Add("TO_TIME", "TO_TIME");
			
			foreach(UMIS_VER2.BusinessLyer.SaStfAttend entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["SA_STF_ATTEND_ID"] = entity.SaStfAttendId;
							
				
					row["SA_STF_MEMBER_ID"] = entity.SaStfMemberId;
							
				
					row["ATT_DATE"] = entity.AttDate;
							
				
					row["ABSENCE_FLG"] = entity.AbsenceFlg;
							
				
					row["EXECUSE_FLG"] = entity.ExecuseFlg;
							
				
					row["FROM_TIME"] = entity.FromTime.HasValue ? (object) entity.FromTime  : System.DBNull.Value;
							
				
					row["TO_TIME"] = entity.ToTime.HasValue ? (object) entity.ToTime  : System.DBNull.Value;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(UMIS_VER2.BusinessLyer.SaStfAttend entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a UMIS_VER2.BusinessLyer.SaStfAttend object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaStfAttend object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.SaStfAttend object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfAttend entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@SaStfAttendId", DbType.Decimal, 5);
			database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, entity.SaStfMemberId );
			database.AddInParameter(commandWrapper, "@AttDate", DbType.DateTime, entity.AttDate );
			database.AddInParameter(commandWrapper, "@AbsenceFlg", DbType.Decimal, entity.AbsenceFlg );
			database.AddInParameter(commandWrapper, "@ExecuseFlg", DbType.Decimal, entity.ExecuseFlg );
			database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, (entity.FromTime.HasValue ? (object) entity.FromTime  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, (entity.ToTime.HasValue ? (object) entity.ToTime  : System.DBNull.Value));
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));
				
			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
					
			object _saStfAttendId = database.GetParameterValue(commandWrapper, "@SaStfAttendId");
			entity.SaStfAttendId = (System.Decimal)_saStfAttendId;
			
			entity.OriginalSaStfAttendId = entity.SaStfAttendId;
			
			entity.AcceptChanges();
	
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

			return Convert.ToBoolean(results);
		}	
		#endregion

		#region Update Methods
				
		/// <summary>
		/// 	Update an existing row in the datasource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaStfAttend object to update.</param>
		/// <remarks>
		///		After updating the datasource, the UMIS_VER2.BusinessLyer.SaStfAttend object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfAttend entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_ATTEND_Update", _useStoredProcedure);
			
			database.AddInParameter(commandWrapper, "@SaStfAttendId", DbType.Decimal, entity.SaStfAttendId );
			database.AddInParameter(commandWrapper, "@OriginalSaStfAttendId", DbType.Decimal, entity.OriginalSaStfAttendId);
			database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, entity.SaStfMemberId );
			database.AddInParameter(commandWrapper, "@AttDate", DbType.DateTime, entity.AttDate );
			database.AddInParameter(commandWrapper, "@AbsenceFlg", DbType.Decimal, entity.AbsenceFlg );
			database.AddInParameter(commandWrapper, "@ExecuseFlg", DbType.Decimal, entity.ExecuseFlg );
			database.AddInParameter(commandWrapper, "@FromTime", DbType.DateTime, (entity.FromTime.HasValue ? (object) entity.FromTime : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@ToTime", DbType.DateTime, (entity.ToTime.HasValue ? (object) entity.ToTime : System.DBNull.Value) );
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
				EntityManager.StopTracking(entity.EntityTrackingKey);
			
			entity.OriginalSaStfAttendId = entity.SaStfAttendId;
			
			entity.AcceptChanges();
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

			return Convert.ToBoolean(results);
		}
			
		#endregion
		
		#region Custom Methods
	
		#endregion
	}//end class
} // end namespace
