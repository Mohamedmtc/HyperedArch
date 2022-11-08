﻿/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file SqlSeAccntProvider.cs instead.
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SeAccnt"/> entity.
	///</summary>
	public abstract partial class SqlSeAccntProviderBase : SeAccntProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlSeAccntProviderBase"/> instance.
		/// </summary>
		public SqlSeAccntProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlSeAccntProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlSeAccntProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
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
		/// <param name="_seAccntId">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Decimal _seAccntId)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@SeAccntId", DbType.Decimal, _seAccntId);
			
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
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(SeAccnt)
					,_seAccntId);
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public override TList<SeAccnt> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<SeAccnt>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@SeAccntId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@DescAr", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@DescEn", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TemplateFlg", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@AdAccntGuid", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@AdAccntName", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SeUserLstId", DbType.Decimal, DBNull.Value);
	
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
				if (clause.Trim().StartsWith("se_accnt_id ") || clause.Trim().StartsWith("se_accnt_id="))
				{
					database.SetParameterValue(commandWrapper, "@SeAccntId", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("desc_ar ") || clause.Trim().StartsWith("desc_ar="))
				{
					database.SetParameterValue(commandWrapper, "@DescAr", 
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("desc_en ") || clause.Trim().StartsWith("desc_en="))
				{
					database.SetParameterValue(commandWrapper, "@DescEn", 
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("template_flg ") || clause.Trim().StartsWith("template_flg="))
				{
					database.SetParameterValue(commandWrapper, "@TemplateFlg", 
						clause.Trim().Remove(0,12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ad_accnt_guid ") || clause.Trim().StartsWith("ad_accnt_guid="))
				{
					database.SetParameterValue(commandWrapper, "@AdAccntGuid", 
						clause.Trim().Remove(0,13).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ad_accnt_name ") || clause.Trim().StartsWith("ad_accnt_name="))
				{
					database.SetParameterValue(commandWrapper, "@AdAccntName", 
						clause.Trim().Remove(0,13).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("se_code_user_type_id ") || clause.Trim().StartsWith("se_code_user_type_id="))
				{
					database.SetParameterValue(commandWrapper, "@SeCodeUserTypeId", 
						clause.Trim().Remove(0,20).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("last_date ") || clause.Trim().StartsWith("last_date="))
				{
					database.SetParameterValue(commandWrapper, "@LastDate", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("se_user_lst_id ") || clause.Trim().StartsWith("se_user_lst_id="))
				{
					database.SetParameterValue(commandWrapper, "@SeUserLstId", 
						clause.Trim().Remove(0,14).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<SeAccnt> rows = new TList<SeAccnt>();
	
				
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public override TList<SeAccnt> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_Find_Dynamic", typeof(SeAccntColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<SeAccnt> rows = new TList<SeAccnt>();
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SeAccnt> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<SeAccnt> rows = new TList<SeAccnt>();
			
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
		public override TList<SeAccnt> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_GetPaged", _useStoredProcedure);
		
			
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
			TList<SeAccnt> rows = new TList<SeAccnt>();
			
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

		#region GetBySeCodeUserTypeId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_SE_CODE_USER_TYPE key.
		///		FK_SE_ACCNT_SE_CODE_USER_TYPE Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccnt objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<SeAccnt> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal _seCodeUserTypeId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_GetBySeCodeUserTypeId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, _seCodeUserTypeId);
			
			IDataReader reader = null;
			TList<SeAccnt> rows = new TList<SeAccnt>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySeCodeUserTypeId", rows)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySeCodeUserTypeId", rows)); 
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

		#region GetByDescAr
					
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_ACCNT_DESC_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descAr"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override UMIS_VER2.BusinessLyer.SeAccnt GetByDescAr(TransactionManager transactionManager, System.String _descAr, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_GetByDescAr", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@DescAr", DbType.String, _descAr);
			
			IDataReader reader = null;
			TList<SeAccnt> tmp = new TList<SeAccnt>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByDescAr", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByDescAr", tmp));
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


		#region GetBySeAccntId
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccnt"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override UMIS_VER2.BusinessLyer.SeAccnt GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_GetBySeAccntId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@SeAccntId", DbType.Decimal, _seAccntId);
			
			IDataReader reader = null;
			TList<SeAccnt> tmp = new TList<SeAccnt>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySeAccntId", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySeAccntId", tmp));
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
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.SeAccnt object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<UMIS_VER2.BusinessLyer.SeAccnt> entities)
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
			bulkCopy.DestinationTableName = "SE_ACCNT";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("SE_ACCNT_ID", typeof(System.Decimal));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("DESC_AR", typeof(System.String));
			col1.AllowDBNull = false;		
			DataColumn col2 = dataTable.Columns.Add("DESC_EN", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("TEMPLATE_FLG", typeof(System.Decimal));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("AD_ACCNT_GUID", typeof(System.String));
			col4.AllowDBNull = false;		
			DataColumn col5 = dataTable.Columns.Add("AD_ACCNT_NAME", typeof(System.String));
			col5.AllowDBNull = false;		
			DataColumn col6 = dataTable.Columns.Add("SE_CODE_USER_TYPE_ID", typeof(System.Decimal));
			col6.AllowDBNull = false;		
			DataColumn col7 = dataTable.Columns.Add("LAST_DATE", typeof(System.DateTime));
			col7.AllowDBNull = true;		
			DataColumn col8 = dataTable.Columns.Add("SE_USER_LST_ID", typeof(System.Decimal));
			col8.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("SE_ACCNT_ID", "SE_ACCNT_ID");
			bulkCopy.ColumnMappings.Add("DESC_AR", "DESC_AR");
			bulkCopy.ColumnMappings.Add("DESC_EN", "DESC_EN");
			bulkCopy.ColumnMappings.Add("TEMPLATE_FLG", "TEMPLATE_FLG");
			bulkCopy.ColumnMappings.Add("AD_ACCNT_GUID", "AD_ACCNT_GUID");
			bulkCopy.ColumnMappings.Add("AD_ACCNT_NAME", "AD_ACCNT_NAME");
			bulkCopy.ColumnMappings.Add("SE_CODE_USER_TYPE_ID", "SE_CODE_USER_TYPE_ID");
			bulkCopy.ColumnMappings.Add("LAST_DATE", "LAST_DATE");
			bulkCopy.ColumnMappings.Add("SE_USER_LST_ID", "SE_USER_LST_ID");
			
			foreach(UMIS_VER2.BusinessLyer.SeAccnt entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["SE_ACCNT_ID"] = entity.SeAccntId;
							
				
					row["DESC_AR"] = entity.DescAr;
							
				
					row["DESC_EN"] = entity.DescEn;
							
				
					row["TEMPLATE_FLG"] = entity.TemplateFlg.HasValue ? (object) entity.TemplateFlg  : System.DBNull.Value;
							
				
					row["AD_ACCNT_GUID"] = entity.AdAccntGuid;
							
				
					row["AD_ACCNT_NAME"] = entity.AdAccntName;
							
				
					row["SE_CODE_USER_TYPE_ID"] = entity.SeCodeUserTypeId;
							
				
					row["LAST_DATE"] = entity.LastDate.HasValue ? (object) entity.LastDate  : System.DBNull.Value;
							
				
					row["SE_USER_LST_ID"] = entity.SeUserLstId.HasValue ? (object) entity.SeUserLstId  : System.DBNull.Value;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(UMIS_VER2.BusinessLyer.SeAccnt entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a UMIS_VER2.BusinessLyer.SeAccnt object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeAccnt object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.SeAccnt object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccnt entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@SeAccntId", DbType.Decimal, 5);
			database.AddInParameter(commandWrapper, "@DescAr", DbType.String, entity.DescAr );
			database.AddInParameter(commandWrapper, "@DescEn", DbType.String, entity.DescEn );
			database.AddInParameter(commandWrapper, "@TemplateFlg", DbType.Decimal, (entity.TemplateFlg.HasValue ? (object) entity.TemplateFlg  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@AdAccntGuid", DbType.String, entity.AdAccntGuid );
			database.AddInParameter(commandWrapper, "@AdAccntName", DbType.String, entity.AdAccntName );
			database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, entity.SeCodeUserTypeId );
			database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object) entity.LastDate  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@SeUserLstId", DbType.Decimal, (entity.SeUserLstId.HasValue ? (object) entity.SeUserLstId  : System.DBNull.Value));
			
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
					
			object _seAccntId = database.GetParameterValue(commandWrapper, "@SeAccntId");
			entity.SeAccntId = (System.Decimal)_seAccntId;
			
			entity.OriginalSeAccntId = entity.SeAccntId;
			
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
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeAccnt object to update.</param>
		/// <remarks>
		///		After updating the datasource, the UMIS_VER2.BusinessLyer.SeAccnt object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccnt entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SE_ACCNT_Update", _useStoredProcedure);
			
			database.AddInParameter(commandWrapper, "@SeAccntId", DbType.Decimal, entity.SeAccntId );
			database.AddInParameter(commandWrapper, "@OriginalSeAccntId", DbType.Decimal, entity.OriginalSeAccntId);
			database.AddInParameter(commandWrapper, "@DescAr", DbType.String, entity.DescAr );
			database.AddInParameter(commandWrapper, "@DescEn", DbType.String, entity.DescEn );
			database.AddInParameter(commandWrapper, "@TemplateFlg", DbType.Decimal, (entity.TemplateFlg.HasValue ? (object) entity.TemplateFlg : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@AdAccntGuid", DbType.String, entity.AdAccntGuid );
			database.AddInParameter(commandWrapper, "@AdAccntName", DbType.String, entity.AdAccntName );
			database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, entity.SeCodeUserTypeId );
			database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object) entity.LastDate : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@SeUserLstId", DbType.Decimal, (entity.SeUserLstId.HasValue ? (object) entity.SeUserLstId : System.DBNull.Value) );
			
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
			
			entity.OriginalSeAccntId = entity.SeAccntId;
			
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
