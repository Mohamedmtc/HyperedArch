﻿/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file SqlEntPolicyAssessGrpHdrProvider.cs instead.
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntPolicyAssessGrpHdr"/> entity.
	///</summary>
	public abstract partial class SqlEntPolicyAssessGrpHdrProviderBase : EntPolicyAssessGrpHdrProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlEntPolicyAssessGrpHdrProviderBase"/> instance.
		/// </summary>
		public SqlEntPolicyAssessGrpHdrProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlEntPolicyAssessGrpHdrProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlEntPolicyAssessGrpHdrProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
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
		/// <param name="_entPolicyAssessGrpHdrId">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@EntPolicyAssessGrpHdrId", DbType.Int32, _entPolicyAssessGrpHdrId);
			
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
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyAssessGrpHdr)
					,_entPolicyAssessGrpHdrId);
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public override TList<EntPolicyAssessGrpHdr> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<EntPolicyAssessGrpHdr>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@EntPolicyAssessGrpHdrId", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GrpDescrAr", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GrpDescrEn", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MinMark", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@MaxMark", DbType.Decimal, DBNull.Value);
	
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
				if (clause.Trim().StartsWith("ent_policy_assess_grp_hdr_id ") || clause.Trim().StartsWith("ent_policy_assess_grp_hdr_id="))
				{
					database.SetParameterValue(commandWrapper, "@EntPolicyAssessGrpHdrId", 
						clause.Trim().Remove(0,28).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ent_policy_assess_hdr_id ") || clause.Trim().StartsWith("ent_policy_assess_hdr_id="))
				{
					database.SetParameterValue(commandWrapper, "@EntPolicyAssessHdrId", 
						clause.Trim().Remove(0,24).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("grp_descr_ar ") || clause.Trim().StartsWith("grp_descr_ar="))
				{
					database.SetParameterValue(commandWrapper, "@GrpDescrAr", 
						clause.Trim().Remove(0,12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("grp_descr_en ") || clause.Trim().StartsWith("grp_descr_en="))
				{
					database.SetParameterValue(commandWrapper, "@GrpDescrEn", 
						clause.Trim().Remove(0,12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("min_mark ") || clause.Trim().StartsWith("min_mark="))
				{
					database.SetParameterValue(commandWrapper, "@MinMark", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("max_mark ") || clause.Trim().StartsWith("max_mark="))
				{
					database.SetParameterValue(commandWrapper, "@MaxMark", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<EntPolicyAssessGrpHdr> rows = new TList<EntPolicyAssessGrpHdr>();
	
				
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public override TList<EntPolicyAssessGrpHdr> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_Find_Dynamic", typeof(EntPolicyAssessGrpHdrColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<EntPolicyAssessGrpHdr> rows = new TList<EntPolicyAssessGrpHdr>();
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<EntPolicyAssessGrpHdr> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<EntPolicyAssessGrpHdr> rows = new TList<EntPolicyAssessGrpHdr>();
			
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
		public override TList<EntPolicyAssessGrpHdr> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_GetPaged", _useStoredProcedure);
		
			
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
			TList<EntPolicyAssessGrpHdr> rows = new TList<EntPolicyAssessGrpHdr>();
			
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

		#region GetByEntPolicyAssessHdrId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR key.
		///		FK_ENT_POLICY_ASSESS_GRP_HDR_ENT_POLICY_ASSESS_HDR Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<EntPolicyAssessGrpHdr> GetByEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _entPolicyAssessHdrId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_GetByEntPolicyAssessHdrId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, _entPolicyAssessHdrId);
			
			IDataReader reader = null;
			TList<EntPolicyAssessGrpHdr> rows = new TList<EntPolicyAssessGrpHdr>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntPolicyAssessHdrId", rows)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEntPolicyAssessHdrId", rows)); 
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

		#region GetByEntPolicyAssessGrpHdrId
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_ASSESS_GRP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAssessGrpHdrId"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr GetByEntPolicyAssessGrpHdrId(TransactionManager transactionManager, System.Int32 _entPolicyAssessGrpHdrId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_GetByEntPolicyAssessGrpHdrId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@EntPolicyAssessGrpHdrId", DbType.Int32, _entPolicyAssessGrpHdrId);
			
			IDataReader reader = null;
			TList<EntPolicyAssessGrpHdr> tmp = new TList<EntPolicyAssessGrpHdr>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntPolicyAssessGrpHdrId", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEntPolicyAssessGrpHdrId", tmp));
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
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr> entities)
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
			bulkCopy.DestinationTableName = "ENT_POLICY_ASSESS_GRP_HDR";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("ENT_POLICY_ASSESS_GRP_HDR_ID", typeof(System.Int32));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("ENT_POLICY_ASSESS_HDR_ID", typeof(System.Decimal));
			col1.AllowDBNull = false;		
			DataColumn col2 = dataTable.Columns.Add("GRP_DESCR_AR", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("GRP_DESCR_EN", typeof(System.String));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("MIN_MARK", typeof(System.Decimal));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("MAX_MARK", typeof(System.Decimal));
			col5.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("ENT_POLICY_ASSESS_GRP_HDR_ID", "ENT_POLICY_ASSESS_GRP_HDR_ID");
			bulkCopy.ColumnMappings.Add("ENT_POLICY_ASSESS_HDR_ID", "ENT_POLICY_ASSESS_HDR_ID");
			bulkCopy.ColumnMappings.Add("GRP_DESCR_AR", "GRP_DESCR_AR");
			bulkCopy.ColumnMappings.Add("GRP_DESCR_EN", "GRP_DESCR_EN");
			bulkCopy.ColumnMappings.Add("MIN_MARK", "MIN_MARK");
			bulkCopy.ColumnMappings.Add("MAX_MARK", "MAX_MARK");
			
			foreach(UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["ENT_POLICY_ASSESS_GRP_HDR_ID"] = entity.EntPolicyAssessGrpHdrId;
							
				
					row["ENT_POLICY_ASSESS_HDR_ID"] = entity.EntPolicyAssessHdrId;
							
				
					row["GRP_DESCR_AR"] = entity.GrpDescrAr;
							
				
					row["GRP_DESCR_EN"] = entity.GrpDescrEn;
							
				
					row["MIN_MARK"] = entity.MinMark.HasValue ? (object) entity.MinMark  : System.DBNull.Value;
							
				
					row["MAX_MARK"] = entity.MaxMark.HasValue ? (object) entity.MaxMark  : System.DBNull.Value;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@EntPolicyAssessGrpHdrId", DbType.Int32, 4);
			database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, entity.EntPolicyAssessHdrId );
			database.AddInParameter(commandWrapper, "@GrpDescrAr", DbType.String, entity.GrpDescrAr );
			database.AddInParameter(commandWrapper, "@GrpDescrEn", DbType.String, entity.GrpDescrEn );
			database.AddInParameter(commandWrapper, "@MinMark", DbType.Decimal, (entity.MinMark.HasValue ? (object) entity.MinMark  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@MaxMark", DbType.Decimal, (entity.MaxMark.HasValue ? (object) entity.MaxMark  : System.DBNull.Value));
			
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
					
			object _entPolicyAssessGrpHdrId = database.GetParameterValue(commandWrapper, "@EntPolicyAssessGrpHdrId");
			entity.EntPolicyAssessGrpHdrId = (System.Int32)_entPolicyAssessGrpHdrId;
			
			entity.OriginalEntPolicyAssessGrpHdrId = entity.EntPolicyAssessGrpHdrId;
			
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
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr object to update.</param>
		/// <remarks>
		///		After updating the datasource, the UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAssessGrpHdr entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_GRP_HDR_Update", _useStoredProcedure);
			
			database.AddInParameter(commandWrapper, "@EntPolicyAssessGrpHdrId", DbType.Int32, entity.EntPolicyAssessGrpHdrId );
			database.AddInParameter(commandWrapper, "@OriginalEntPolicyAssessGrpHdrId", DbType.Int32, entity.OriginalEntPolicyAssessGrpHdrId);
			database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, entity.EntPolicyAssessHdrId );
			database.AddInParameter(commandWrapper, "@GrpDescrAr", DbType.String, entity.GrpDescrAr );
			database.AddInParameter(commandWrapper, "@GrpDescrEn", DbType.String, entity.GrpDescrEn );
			database.AddInParameter(commandWrapper, "@MinMark", DbType.Decimal, (entity.MinMark.HasValue ? (object) entity.MinMark : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@MaxMark", DbType.Decimal, (entity.MaxMark.HasValue ? (object) entity.MaxMark : System.DBNull.Value) );
			
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
			
			entity.OriginalEntPolicyAssessGrpHdrId = entity.EntPolicyAssessGrpHdrId;
			
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
