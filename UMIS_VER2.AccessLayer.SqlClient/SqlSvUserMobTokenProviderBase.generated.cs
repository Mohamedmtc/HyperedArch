﻿/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file SqlSvUserMobTokenProvider.cs instead.
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SvUserMobToken"/> entity.
	///</summary>
	public abstract partial class SqlSvUserMobTokenProviderBase : SvUserMobTokenProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlSvUserMobTokenProviderBase"/> instance.
		/// </summary>
		public SqlSvUserMobTokenProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlSvUserMobTokenProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlSvUserMobTokenProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
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
		/// <param name="_svUserMobTokenId">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Decimal _svUserMobTokenId)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@SvUserMobTokenId", DbType.Decimal, _svUserMobTokenId);
			
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
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(SvUserMobToken)
					,_svUserMobTokenId);
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public override TList<SvUserMobToken> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<SvUserMobToken>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@SvUserMobTokenId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Token", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@UserIp", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SvCdeDeviceTypeId", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Notes", DbType.String, DBNull.Value);
	
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
				if (clause.Trim().StartsWith("sv_user_mob_token_id ") || clause.Trim().StartsWith("sv_user_mob_token_id="))
				{
					database.SetParameterValue(commandWrapper, "@SvUserMobTokenId", 
						clause.Trim().Remove(0,20).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("se_user_id ") || clause.Trim().StartsWith("se_user_id="))
				{
					database.SetParameterValue(commandWrapper, "@SeUserId", 
						clause.Trim().Remove(0,10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("token ") || clause.Trim().StartsWith("token="))
				{
					database.SetParameterValue(commandWrapper, "@Token", 
						clause.Trim().Remove(0,5).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("user_ip ") || clause.Trim().StartsWith("user_ip="))
				{
					database.SetParameterValue(commandWrapper, "@UserIp", 
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sv_cde_device_type_id ") || clause.Trim().StartsWith("sv_cde_device_type_id="))
				{
					database.SetParameterValue(commandWrapper, "@SvCdeDeviceTypeId", 
						clause.Trim().Remove(0,21).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("last_date ") || clause.Trim().StartsWith("last_date="))
				{
					database.SetParameterValue(commandWrapper, "@LastDate", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("gs_code_language_id ") || clause.Trim().StartsWith("gs_code_language_id="))
				{
					database.SetParameterValue(commandWrapper, "@GsCodeLanguageId", 
						clause.Trim().Remove(0,19).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("notes ") || clause.Trim().StartsWith("notes="))
				{
					database.SetParameterValue(commandWrapper, "@Notes", 
						clause.Trim().Remove(0,5).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<SvUserMobToken> rows = new TList<SvUserMobToken>();
	
				
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public override TList<SvUserMobToken> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_Find_Dynamic", typeof(SvUserMobTokenColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<SvUserMobToken> rows = new TList<SvUserMobToken>();
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SvUserMobToken> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<SvUserMobToken> rows = new TList<SvUserMobToken>();
			
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
		public override TList<SvUserMobToken> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_GetPaged", _useStoredProcedure);
		
			
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
			TList<SvUserMobToken> rows = new TList<SvUserMobToken>();
			
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

		#region GetByGsCodeLanguageId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE key.
		///		FK_SV_USER_MOB_TOKEN_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SvUserMobToken> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_GetByGsCodeLanguageId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, _gsCodeLanguageId);
			
			IDataReader reader = null;
			TList<SvUserMobToken> rows = new TList<SvUserMobToken>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByGsCodeLanguageId", rows)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByGsCodeLanguageId", rows)); 
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
	

		#region GetBySeUserId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SE_USER key.
		///		FK_SV_USER_MOB_TOKEN_SE_USER Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SvUserMobToken> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_GetBySeUserId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _seUserId);
			
			IDataReader reader = null;
			TList<SvUserMobToken> rows = new TList<SvUserMobToken>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySeUserId", rows)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySeUserId", rows)); 
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
	

		#region GetBySvCdeDeviceTypeId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE key.
		///		FK_SV_USER_MOB_TOKEN_SV_CDE_DEVICE_TYPE Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeDeviceTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvUserMobToken objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SvUserMobToken> GetBySvCdeDeviceTypeId(TransactionManager transactionManager, System.Int32? _svCdeDeviceTypeId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_GetBySvCdeDeviceTypeId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@SvCdeDeviceTypeId", DbType.Int32, _svCdeDeviceTypeId);
			
			IDataReader reader = null;
			TList<SvUserMobToken> rows = new TList<SvUserMobToken>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySvCdeDeviceTypeId", rows)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySvCdeDeviceTypeId", rows)); 
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

		#region GetBySvUserMobTokenId
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_USER_MOB_TOKEN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svUserMobTokenId"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvUserMobToken"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override UMIS_VER2.BusinessLyer.SvUserMobToken GetBySvUserMobTokenId(TransactionManager transactionManager, System.Decimal _svUserMobTokenId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_GetBySvUserMobTokenId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@SvUserMobTokenId", DbType.Decimal, _svUserMobTokenId);
			
			IDataReader reader = null;
			TList<SvUserMobToken> tmp = new TList<SvUserMobToken>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySvUserMobTokenId", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySvUserMobTokenId", tmp));
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
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.SvUserMobToken object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<UMIS_VER2.BusinessLyer.SvUserMobToken> entities)
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
			bulkCopy.DestinationTableName = "SV_USER_MOB_TOKEN";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("SV_USER_MOB_TOKEN_ID", typeof(System.Decimal));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("SE_USER_ID", typeof(System.Decimal));
			col1.AllowDBNull = false;		
			DataColumn col2 = dataTable.Columns.Add("TOKEN", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("USER_IP", typeof(System.String));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("SV_CDE_DEVICE_TYPE_ID", typeof(System.Int32));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("LAST_DATE", typeof(System.DateTime));
			col5.AllowDBNull = true;		
			DataColumn col6 = dataTable.Columns.Add("GS_CODE_LANGUAGE_ID", typeof(System.Decimal));
			col6.AllowDBNull = true;		
			DataColumn col7 = dataTable.Columns.Add("NOTES", typeof(System.String));
			col7.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("SV_USER_MOB_TOKEN_ID", "SV_USER_MOB_TOKEN_ID");
			bulkCopy.ColumnMappings.Add("SE_USER_ID", "SE_USER_ID");
			bulkCopy.ColumnMappings.Add("TOKEN", "TOKEN");
			bulkCopy.ColumnMappings.Add("USER_IP", "USER_IP");
			bulkCopy.ColumnMappings.Add("SV_CDE_DEVICE_TYPE_ID", "SV_CDE_DEVICE_TYPE_ID");
			bulkCopy.ColumnMappings.Add("LAST_DATE", "LAST_DATE");
			bulkCopy.ColumnMappings.Add("GS_CODE_LANGUAGE_ID", "GS_CODE_LANGUAGE_ID");
			bulkCopy.ColumnMappings.Add("NOTES", "NOTES");
			
			foreach(UMIS_VER2.BusinessLyer.SvUserMobToken entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["SV_USER_MOB_TOKEN_ID"] = entity.SvUserMobTokenId;
							
				
					row["SE_USER_ID"] = entity.SeUserId;
							
				
					row["TOKEN"] = entity.Token;
							
				
					row["USER_IP"] = entity.UserIp;
							
				
					row["SV_CDE_DEVICE_TYPE_ID"] = entity.SvCdeDeviceTypeId.HasValue ? (object) entity.SvCdeDeviceTypeId  : System.DBNull.Value;
							
				
					row["LAST_DATE"] = entity.LastDate.HasValue ? (object) entity.LastDate  : System.DBNull.Value;
							
				
					row["GS_CODE_LANGUAGE_ID"] = entity.GsCodeLanguageId.HasValue ? (object) entity.GsCodeLanguageId  : System.DBNull.Value;
							
				
					row["NOTES"] = entity.Notes;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(UMIS_VER2.BusinessLyer.SvUserMobToken entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a UMIS_VER2.BusinessLyer.SvUserMobToken object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvUserMobToken object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.SvUserMobToken object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMobToken entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@SvUserMobTokenId", DbType.Decimal, 5);
			database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, entity.SeUserId );
			database.AddInParameter(commandWrapper, "@Token", DbType.String, entity.Token );
			database.AddInParameter(commandWrapper, "@UserIp", DbType.String, entity.UserIp );
			database.AddInParameter(commandWrapper, "@SvCdeDeviceTypeId", DbType.Int32, (entity.SvCdeDeviceTypeId.HasValue ? (object) entity.SvCdeDeviceTypeId  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object) entity.LastDate  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, (entity.GsCodeLanguageId.HasValue ? (object) entity.GsCodeLanguageId  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes );
			
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
					
			object _svUserMobTokenId = database.GetParameterValue(commandWrapper, "@SvUserMobTokenId");
			entity.SvUserMobTokenId = (System.Decimal)_svUserMobTokenId;
			
			
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
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvUserMobToken object to update.</param>
		/// <remarks>
		///		After updating the datasource, the UMIS_VER2.BusinessLyer.SvUserMobToken object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvUserMobToken entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_USER_MOB_TOKEN_Update", _useStoredProcedure);
			
			database.AddInParameter(commandWrapper, "@SvUserMobTokenId", DbType.Decimal, entity.SvUserMobTokenId );
			database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, entity.SeUserId );
			database.AddInParameter(commandWrapper, "@Token", DbType.String, entity.Token );
			database.AddInParameter(commandWrapper, "@UserIp", DbType.String, entity.UserIp );
			database.AddInParameter(commandWrapper, "@SvCdeDeviceTypeId", DbType.Int32, (entity.SvCdeDeviceTypeId.HasValue ? (object) entity.SvCdeDeviceTypeId : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object) entity.LastDate : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, (entity.GsCodeLanguageId.HasValue ? (object) entity.GsCodeLanguageId : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes );
			
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
