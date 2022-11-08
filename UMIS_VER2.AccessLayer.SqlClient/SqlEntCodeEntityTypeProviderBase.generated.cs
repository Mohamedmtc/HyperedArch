﻿/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file SqlEntCodeEntityTypeProvider.cs instead.
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntCodeEntityType"/> entity.
	///</summary>
	public abstract partial class SqlEntCodeEntityTypeProviderBase : EntCodeEntityTypeProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlEntCodeEntityTypeProviderBase"/> instance.
		/// </summary>
		public SqlEntCodeEntityTypeProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlEntCodeEntityTypeProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlEntCodeEntityTypeProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
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
		/// <param name="_entCodeEntityTypeId">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, _entCodeEntityTypeId);
			
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
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeEntityType)
					,_entCodeEntityTypeId);
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeEntityType objects.</returns>
		public override TList<EntCodeEntityType> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<EntCodeEntityType>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@EntTypeDscrAr", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@EntTypeDscrEn", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@StateAbbrvAr", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@StateAbbrvEn", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@BylawRltdFlg", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuIntroduction", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuPrecondition", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuFullfilment", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuPolicies", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuGrading", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuCoursePackage", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuAcadPlan", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SubMnuBylaw", DbType.Decimal, DBNull.Value);
	
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
				if (clause.Trim().StartsWith("ent_code_entity_type_id ") || clause.Trim().StartsWith("ent_code_entity_type_id="))
				{
					database.SetParameterValue(commandWrapper, "@EntCodeEntityTypeId", 
						clause.Trim().Remove(0,23).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ent_type_dscr_ar ") || clause.Trim().StartsWith("ent_type_dscr_ar="))
				{
					database.SetParameterValue(commandWrapper, "@EntTypeDscrAr", 
						clause.Trim().Remove(0,16).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ent_type_dscr_en ") || clause.Trim().StartsWith("ent_type_dscr_en="))
				{
					database.SetParameterValue(commandWrapper, "@EntTypeDscrEn", 
						clause.Trim().Remove(0,16).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("state_abbrv_ar ") || clause.Trim().StartsWith("state_abbrv_ar="))
				{
					database.SetParameterValue(commandWrapper, "@StateAbbrvAr", 
						clause.Trim().Remove(0,14).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("state_abbrv_en ") || clause.Trim().StartsWith("state_abbrv_en="))
				{
					database.SetParameterValue(commandWrapper, "@StateAbbrvEn", 
						clause.Trim().Remove(0,14).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("bylaw_rltd_flg ") || clause.Trim().StartsWith("bylaw_rltd_flg="))
				{
					database.SetParameterValue(commandWrapper, "@BylawRltdFlg", 
						clause.Trim().Remove(0,14).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_introduction ") || clause.Trim().StartsWith("sub_mnu_introduction="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuIntroduction", 
						clause.Trim().Remove(0,20).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_precondition ") || clause.Trim().StartsWith("sub_mnu_precondition="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuPrecondition", 
						clause.Trim().Remove(0,20).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_fullfilment ") || clause.Trim().StartsWith("sub_mnu_fullfilment="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuFullfilment", 
						clause.Trim().Remove(0,19).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_policies ") || clause.Trim().StartsWith("sub_mnu_policies="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuPolicies", 
						clause.Trim().Remove(0,16).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_grading ") || clause.Trim().StartsWith("sub_mnu_grading="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuGrading", 
						clause.Trim().Remove(0,15).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_course_package ") || clause.Trim().StartsWith("sub_mnu_course_package="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuCoursePackage", 
						clause.Trim().Remove(0,22).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_acad_plan ") || clause.Trim().StartsWith("sub_mnu_acad_plan="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuAcadPlan", 
						clause.Trim().Remove(0,17).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sub_mnu_bylaw ") || clause.Trim().StartsWith("sub_mnu_bylaw="))
				{
					database.SetParameterValue(commandWrapper, "@SubMnuBylaw", 
						clause.Trim().Remove(0,13).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<EntCodeEntityType> rows = new TList<EntCodeEntityType>();
	
				
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeEntityType objects.</returns>
		public override TList<EntCodeEntityType> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_Find_Dynamic", typeof(EntCodeEntityTypeColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<EntCodeEntityType> rows = new TList<EntCodeEntityType>();
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeEntityType objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<EntCodeEntityType> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<EntCodeEntityType> rows = new TList<EntCodeEntityType>();
			
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeEntityType objects.</returns>
		public override TList<EntCodeEntityType> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_GetPaged", _useStoredProcedure);
		
			
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
			TList<EntCodeEntityType> rows = new TList<EntCodeEntityType>();
			
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
	#endregion
	
		#region Get By Index Functions

		#region GetByEntCodeEntityTypeId
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override UMIS_VER2.BusinessLyer.EntCodeEntityType GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_GetByEntCodeEntityTypeId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, _entCodeEntityTypeId);
			
			IDataReader reader = null;
			TList<EntCodeEntityType> tmp = new TList<EntCodeEntityType>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntCodeEntityTypeId", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEntCodeEntityTypeId", tmp));
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
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EntCodeEntityType object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<UMIS_VER2.BusinessLyer.EntCodeEntityType> entities)
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
			bulkCopy.DestinationTableName = "ENT_CODE_ENTITY_TYPE";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("ENT_CODE_ENTITY_TYPE_ID", typeof(System.Decimal));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("ENT_TYPE_DSCR_AR", typeof(System.String));
			col1.AllowDBNull = false;		
			DataColumn col2 = dataTable.Columns.Add("ENT_TYPE_DSCR_EN", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("STATE_ABBRV_AR", typeof(System.String));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("STATE_ABBRV_EN", typeof(System.String));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("BYLAW_RLTD_FLG", typeof(System.Decimal));
			col5.AllowDBNull = false;		
			DataColumn col6 = dataTable.Columns.Add("SUB_MNU_INTRODUCTION", typeof(System.Decimal));
			col6.AllowDBNull = false;		
			DataColumn col7 = dataTable.Columns.Add("SUB_MNU_PRECONDITION", typeof(System.Decimal));
			col7.AllowDBNull = false;		
			DataColumn col8 = dataTable.Columns.Add("SUB_MNU_FULLFILMENT", typeof(System.Decimal));
			col8.AllowDBNull = false;		
			DataColumn col9 = dataTable.Columns.Add("SUB_MNU_POLICIES", typeof(System.Decimal));
			col9.AllowDBNull = false;		
			DataColumn col10 = dataTable.Columns.Add("SUB_MNU_GRADING", typeof(System.Decimal));
			col10.AllowDBNull = false;		
			DataColumn col11 = dataTable.Columns.Add("SUB_MNU_COURSE_PACKAGE", typeof(System.Decimal));
			col11.AllowDBNull = false;		
			DataColumn col12 = dataTable.Columns.Add("SUB_MNU_ACAD_PLAN", typeof(System.Decimal));
			col12.AllowDBNull = false;		
			DataColumn col13 = dataTable.Columns.Add("SUB_MNU_BYLAW", typeof(System.Decimal));
			col13.AllowDBNull = false;		
			
			bulkCopy.ColumnMappings.Add("ENT_CODE_ENTITY_TYPE_ID", "ENT_CODE_ENTITY_TYPE_ID");
			bulkCopy.ColumnMappings.Add("ENT_TYPE_DSCR_AR", "ENT_TYPE_DSCR_AR");
			bulkCopy.ColumnMappings.Add("ENT_TYPE_DSCR_EN", "ENT_TYPE_DSCR_EN");
			bulkCopy.ColumnMappings.Add("STATE_ABBRV_AR", "STATE_ABBRV_AR");
			bulkCopy.ColumnMappings.Add("STATE_ABBRV_EN", "STATE_ABBRV_EN");
			bulkCopy.ColumnMappings.Add("BYLAW_RLTD_FLG", "BYLAW_RLTD_FLG");
			bulkCopy.ColumnMappings.Add("SUB_MNU_INTRODUCTION", "SUB_MNU_INTRODUCTION");
			bulkCopy.ColumnMappings.Add("SUB_MNU_PRECONDITION", "SUB_MNU_PRECONDITION");
			bulkCopy.ColumnMappings.Add("SUB_MNU_FULLFILMENT", "SUB_MNU_FULLFILMENT");
			bulkCopy.ColumnMappings.Add("SUB_MNU_POLICIES", "SUB_MNU_POLICIES");
			bulkCopy.ColumnMappings.Add("SUB_MNU_GRADING", "SUB_MNU_GRADING");
			bulkCopy.ColumnMappings.Add("SUB_MNU_COURSE_PACKAGE", "SUB_MNU_COURSE_PACKAGE");
			bulkCopy.ColumnMappings.Add("SUB_MNU_ACAD_PLAN", "SUB_MNU_ACAD_PLAN");
			bulkCopy.ColumnMappings.Add("SUB_MNU_BYLAW", "SUB_MNU_BYLAW");
			
			foreach(UMIS_VER2.BusinessLyer.EntCodeEntityType entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["ENT_CODE_ENTITY_TYPE_ID"] = entity.EntCodeEntityTypeId;
							
				
					row["ENT_TYPE_DSCR_AR"] = entity.EntTypeDscrAr;
							
				
					row["ENT_TYPE_DSCR_EN"] = entity.EntTypeDscrEn;
							
				
					row["STATE_ABBRV_AR"] = entity.StateAbbrvAr;
							
				
					row["STATE_ABBRV_EN"] = entity.StateAbbrvEn;
							
				
					row["BYLAW_RLTD_FLG"] = entity.BylawRltdFlg;
							
				
					row["SUB_MNU_INTRODUCTION"] = entity.SubMnuIntroduction;
							
				
					row["SUB_MNU_PRECONDITION"] = entity.SubMnuPrecondition;
							
				
					row["SUB_MNU_FULLFILMENT"] = entity.SubMnuFullfilment;
							
				
					row["SUB_MNU_POLICIES"] = entity.SubMnuPolicies;
							
				
					row["SUB_MNU_GRADING"] = entity.SubMnuGrading;
							
				
					row["SUB_MNU_COURSE_PACKAGE"] = entity.SubMnuCoursePackage;
							
				
					row["SUB_MNU_ACAD_PLAN"] = entity.SubMnuAcadPlan;
							
				
					row["SUB_MNU_BYLAW"] = entity.SubMnuBylaw;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(UMIS_VER2.BusinessLyer.EntCodeEntityType entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a UMIS_VER2.BusinessLyer.EntCodeEntityType object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeEntityType object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EntCodeEntityType object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeEntityType entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, 5);
			database.AddInParameter(commandWrapper, "@EntTypeDscrAr", DbType.String, entity.EntTypeDscrAr );
			database.AddInParameter(commandWrapper, "@EntTypeDscrEn", DbType.String, entity.EntTypeDscrEn );
			database.AddInParameter(commandWrapper, "@StateAbbrvAr", DbType.String, entity.StateAbbrvAr );
			database.AddInParameter(commandWrapper, "@StateAbbrvEn", DbType.String, entity.StateAbbrvEn );
			database.AddInParameter(commandWrapper, "@BylawRltdFlg", DbType.Decimal, entity.BylawRltdFlg );
			database.AddInParameter(commandWrapper, "@SubMnuIntroduction", DbType.Decimal, entity.SubMnuIntroduction );
			database.AddInParameter(commandWrapper, "@SubMnuPrecondition", DbType.Decimal, entity.SubMnuPrecondition );
			database.AddInParameter(commandWrapper, "@SubMnuFullfilment", DbType.Decimal, entity.SubMnuFullfilment );
			database.AddInParameter(commandWrapper, "@SubMnuPolicies", DbType.Decimal, entity.SubMnuPolicies );
			database.AddInParameter(commandWrapper, "@SubMnuGrading", DbType.Decimal, entity.SubMnuGrading );
			database.AddInParameter(commandWrapper, "@SubMnuCoursePackage", DbType.Decimal, entity.SubMnuCoursePackage );
			database.AddInParameter(commandWrapper, "@SubMnuAcadPlan", DbType.Decimal, entity.SubMnuAcadPlan );
			database.AddInParameter(commandWrapper, "@SubMnuBylaw", DbType.Decimal, entity.SubMnuBylaw );
			
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
					
			object _entCodeEntityTypeId = database.GetParameterValue(commandWrapper, "@EntCodeEntityTypeId");
			entity.EntCodeEntityTypeId = (System.Decimal)_entCodeEntityTypeId;
			
			entity.OriginalEntCodeEntityTypeId = entity.EntCodeEntityTypeId;
			
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
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeEntityType object to update.</param>
		/// <remarks>
		///		After updating the datasource, the UMIS_VER2.BusinessLyer.EntCodeEntityType object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeEntityType entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_ENTITY_TYPE_Update", _useStoredProcedure);
			
			database.AddInParameter(commandWrapper, "@EntCodeEntityTypeId", DbType.Decimal, entity.EntCodeEntityTypeId );
			database.AddInParameter(commandWrapper, "@OriginalEntCodeEntityTypeId", DbType.Decimal, entity.OriginalEntCodeEntityTypeId);
			database.AddInParameter(commandWrapper, "@EntTypeDscrAr", DbType.String, entity.EntTypeDscrAr );
			database.AddInParameter(commandWrapper, "@EntTypeDscrEn", DbType.String, entity.EntTypeDscrEn );
			database.AddInParameter(commandWrapper, "@StateAbbrvAr", DbType.String, entity.StateAbbrvAr );
			database.AddInParameter(commandWrapper, "@StateAbbrvEn", DbType.String, entity.StateAbbrvEn );
			database.AddInParameter(commandWrapper, "@BylawRltdFlg", DbType.Decimal, entity.BylawRltdFlg );
			database.AddInParameter(commandWrapper, "@SubMnuIntroduction", DbType.Decimal, entity.SubMnuIntroduction );
			database.AddInParameter(commandWrapper, "@SubMnuPrecondition", DbType.Decimal, entity.SubMnuPrecondition );
			database.AddInParameter(commandWrapper, "@SubMnuFullfilment", DbType.Decimal, entity.SubMnuFullfilment );
			database.AddInParameter(commandWrapper, "@SubMnuPolicies", DbType.Decimal, entity.SubMnuPolicies );
			database.AddInParameter(commandWrapper, "@SubMnuGrading", DbType.Decimal, entity.SubMnuGrading );
			database.AddInParameter(commandWrapper, "@SubMnuCoursePackage", DbType.Decimal, entity.SubMnuCoursePackage );
			database.AddInParameter(commandWrapper, "@SubMnuAcadPlan", DbType.Decimal, entity.SubMnuAcadPlan );
			database.AddInParameter(commandWrapper, "@SubMnuBylaw", DbType.Decimal, entity.SubMnuBylaw );
			
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
			
			entity.OriginalEntCodeEntityTypeId = entity.EntCodeEntityTypeId;
			
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
