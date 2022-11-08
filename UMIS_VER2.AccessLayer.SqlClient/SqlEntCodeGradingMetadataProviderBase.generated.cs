﻿/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file SqlEntCodeGradingMetadataProvider.cs instead.
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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntCodeGradingMetadata"/> entity.
	///</summary>
	public abstract partial class SqlEntCodeGradingMetadataProviderBase : EntCodeGradingMetadataProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlEntCodeGradingMetadataProviderBase"/> instance.
		/// </summary>
		public SqlEntCodeGradingMetadataProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlEntCodeGradingMetadataProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlEntCodeGradingMetadataProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
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
		/// <param name="_entCodeGradingMdId">XX. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@EntCodeGradingMdId", DbType.Decimal, _entCodeGradingMdId);
			
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
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeGradingMetadata)
					,_entCodeGradingMdId);
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public override TList<EntCodeGradingMetadata> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<EntCodeGradingMetadata>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@EntCodeGradingMdId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@EntCodeMdTypeId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@SpChkName", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TblRltdFlg", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TblName", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@EdCodeStudyMethodId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@DispOrder", DbType.Decimal, DBNull.Value);
	
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
				if (clause.Trim().StartsWith("ent_code_grading_md_id ") || clause.Trim().StartsWith("ent_code_grading_md_id="))
				{
					database.SetParameterValue(commandWrapper, "@EntCodeGradingMdId", 
						clause.Trim().Remove(0,22).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("descr_ar ") || clause.Trim().StartsWith("descr_ar="))
				{
					database.SetParameterValue(commandWrapper, "@DescrAr", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("descr_en ") || clause.Trim().StartsWith("descr_en="))
				{
					database.SetParameterValue(commandWrapper, "@DescrEn", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ent_code_md_type_id ") || clause.Trim().StartsWith("ent_code_md_type_id="))
				{
					database.SetParameterValue(commandWrapper, "@EntCodeMdTypeId", 
						clause.Trim().Remove(0,19).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("sp_chk_name ") || clause.Trim().StartsWith("sp_chk_name="))
				{
					database.SetParameterValue(commandWrapper, "@SpChkName", 
						clause.Trim().Remove(0,11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("tbl_rltd_flg ") || clause.Trim().StartsWith("tbl_rltd_flg="))
				{
					database.SetParameterValue(commandWrapper, "@TblRltdFlg", 
						clause.Trim().Remove(0,12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("tbl_name ") || clause.Trim().StartsWith("tbl_name="))
				{
					database.SetParameterValue(commandWrapper, "@TblName", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("ed_code_study_method_id ") || clause.Trim().StartsWith("ed_code_study_method_id="))
				{
					database.SetParameterValue(commandWrapper, "@EdCodeStudyMethodId", 
						clause.Trim().Remove(0,23).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("disp_order ") || clause.Trim().StartsWith("disp_order="))
				{
					database.SetParameterValue(commandWrapper, "@DispOrder", 
						clause.Trim().Remove(0,10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<EntCodeGradingMetadata> rows = new TList<EntCodeGradingMetadata>();
	
				
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public override TList<EntCodeGradingMetadata> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_Find_Dynamic", typeof(EntCodeGradingMetadataColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<EntCodeGradingMetadata> rows = new TList<EntCodeGradingMetadata>();
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<EntCodeGradingMetadata> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<EntCodeGradingMetadata> rows = new TList<EntCodeGradingMetadata>();
			
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
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
		public override TList<EntCodeGradingMetadata> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_GetPaged", _useStoredProcedure);
		
			
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
			TList<EntCodeGradingMetadata> rows = new TList<EntCodeGradingMetadata>();
			
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

		#region GetByEntCodeMdTypeId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_MD_TYPE Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<EntCodeGradingMetadata> GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_GetByEntCodeMdTypeId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@EntCodeMdTypeId", DbType.Decimal, _entCodeMdTypeId);
			
			IDataReader reader = null;
			TList<EntCodeGradingMetadata> rows = new TList<EntCodeGradingMetadata>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntCodeMdTypeId", rows)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEntCodeMdTypeId", rows)); 
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
	

		#region GetByEdCodeStudyMethodId
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD key.
		///		FK_ENT_CODE_GRADING_METADATA_ED_CODE_STUDY_METHOD Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCodeGradingMetadata objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<EntCodeGradingMetadata> GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal? _edCodeStudyMethodId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_GetByEdCodeStudyMethodId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@EdCodeStudyMethodId", DbType.Decimal, _edCodeStudyMethodId);
			
			IDataReader reader = null;
			TList<EntCodeGradingMetadata> rows = new TList<EntCodeGradingMetadata>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCodeStudyMethodId", rows)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCodeStudyMethodId", rows)); 
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

		#region GetByEntCodeGradingMdId
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GRAD_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId">XX</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeGradingMetadata"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override UMIS_VER2.BusinessLyer.EntCodeGradingMetadata GetByEntCodeGradingMdId(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_GetByEntCodeGradingMdId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@EntCodeGradingMdId", DbType.Decimal, _entCodeGradingMdId);
			
			IDataReader reader = null;
			TList<EntCodeGradingMetadata> tmp = new TList<EntCodeGradingMetadata>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEntCodeGradingMdId", tmp)); 

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
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEntCodeGradingMdId", tmp));
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
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EntCodeGradingMetadata object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<UMIS_VER2.BusinessLyer.EntCodeGradingMetadata> entities)
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
			bulkCopy.DestinationTableName = "ENT_CODE_GRADING_METADATA";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("ENT_CODE_GRADING_MD_ID", typeof(System.Decimal));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("DESCR_AR", typeof(System.String));
			col1.AllowDBNull = true;		
			DataColumn col2 = dataTable.Columns.Add("DESCR_EN", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("ENT_CODE_MD_TYPE_ID", typeof(System.Decimal));
			col3.AllowDBNull = false;		
			DataColumn col4 = dataTable.Columns.Add("SP_CHK_NAME", typeof(System.String));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("TBL_RLTD_FLG", typeof(System.Decimal));
			col5.AllowDBNull = false;		
			DataColumn col6 = dataTable.Columns.Add("TBL_NAME", typeof(System.String));
			col6.AllowDBNull = true;		
			DataColumn col7 = dataTable.Columns.Add("ED_CODE_STUDY_METHOD_ID", typeof(System.Decimal));
			col7.AllowDBNull = true;		
			DataColumn col8 = dataTable.Columns.Add("DISP_ORDER", typeof(System.Decimal));
			col8.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("ENT_CODE_GRADING_MD_ID", "ENT_CODE_GRADING_MD_ID");
			bulkCopy.ColumnMappings.Add("DESCR_AR", "DESCR_AR");
			bulkCopy.ColumnMappings.Add("DESCR_EN", "DESCR_EN");
			bulkCopy.ColumnMappings.Add("ENT_CODE_MD_TYPE_ID", "ENT_CODE_MD_TYPE_ID");
			bulkCopy.ColumnMappings.Add("SP_CHK_NAME", "SP_CHK_NAME");
			bulkCopy.ColumnMappings.Add("TBL_RLTD_FLG", "TBL_RLTD_FLG");
			bulkCopy.ColumnMappings.Add("TBL_NAME", "TBL_NAME");
			bulkCopy.ColumnMappings.Add("ED_CODE_STUDY_METHOD_ID", "ED_CODE_STUDY_METHOD_ID");
			bulkCopy.ColumnMappings.Add("DISP_ORDER", "DISP_ORDER");
			
			foreach(UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["ENT_CODE_GRADING_MD_ID"] = entity.EntCodeGradingMdId;
							
				
					row["DESCR_AR"] = entity.DescrAr;
							
				
					row["DESCR_EN"] = entity.DescrEn;
							
				
					row["ENT_CODE_MD_TYPE_ID"] = entity.EntCodeMdTypeId;
							
				
					row["SP_CHK_NAME"] = entity.SpChkName;
							
				
					row["TBL_RLTD_FLG"] = entity.TblRltdFlg;
							
				
					row["TBL_NAME"] = entity.TblName;
							
				
					row["ED_CODE_STUDY_METHOD_ID"] = entity.EdCodeStudyMethodId.HasValue ? (object) entity.EdCodeStudyMethodId  : System.DBNull.Value;
							
				
					row["DISP_ORDER"] = entity.DispOrder.HasValue ? (object) entity.DispOrder  : System.DBNull.Value;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a UMIS_VER2.BusinessLyer.EntCodeGradingMetadata object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeGradingMetadata object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the UMIS_VER2.BusinessLyer.EntCodeGradingMetadata object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_Insert", _useStoredProcedure);
			
			database.AddOutParameter(commandWrapper, "@EntCodeGradingMdId", DbType.Decimal, 5);
			database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr );
			database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn );
			database.AddInParameter(commandWrapper, "@EntCodeMdTypeId", DbType.Decimal, entity.EntCodeMdTypeId );
			database.AddInParameter(commandWrapper, "@SpChkName", DbType.String, entity.SpChkName );
			database.AddInParameter(commandWrapper, "@TblRltdFlg", DbType.Decimal, entity.TblRltdFlg );
			database.AddInParameter(commandWrapper, "@TblName", DbType.String, entity.TblName );
			database.AddInParameter(commandWrapper, "@EdCodeStudyMethodId", DbType.Decimal, (entity.EdCodeStudyMethodId.HasValue ? (object) entity.EdCodeStudyMethodId  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@DispOrder", DbType.Decimal, (entity.DispOrder.HasValue ? (object) entity.DispOrder  : System.DBNull.Value));
			
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
					
			object _entCodeGradingMdId = database.GetParameterValue(commandWrapper, "@EntCodeGradingMdId");
			entity.EntCodeGradingMdId = (System.Decimal)_entCodeGradingMdId;
			
			entity.OriginalEntCodeGradingMdId = entity.EntCodeGradingMdId;
			
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
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeGradingMetadata object to update.</param>
		/// <remarks>
		///		After updating the datasource, the UMIS_VER2.BusinessLyer.EntCodeGradingMetadata object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeGradingMetadata entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_CODE_GRADING_METADATA_Update", _useStoredProcedure);
			
			database.AddInParameter(commandWrapper, "@EntCodeGradingMdId", DbType.Decimal, entity.EntCodeGradingMdId );
			database.AddInParameter(commandWrapper, "@OriginalEntCodeGradingMdId", DbType.Decimal, entity.OriginalEntCodeGradingMdId);
			database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr );
			database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn );
			database.AddInParameter(commandWrapper, "@EntCodeMdTypeId", DbType.Decimal, entity.EntCodeMdTypeId );
			database.AddInParameter(commandWrapper, "@SpChkName", DbType.String, entity.SpChkName );
			database.AddInParameter(commandWrapper, "@TblRltdFlg", DbType.Decimal, entity.TblRltdFlg );
			database.AddInParameter(commandWrapper, "@TblName", DbType.String, entity.TblName );
			database.AddInParameter(commandWrapper, "@EdCodeStudyMethodId", DbType.Decimal, (entity.EdCodeStudyMethodId.HasValue ? (object) entity.EdCodeStudyMethodId : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@DispOrder", DbType.Decimal, (entity.DispOrder.HasValue ? (object) entity.DispOrder : System.DBNull.Value) );
			
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
			
			entity.OriginalEntCodeGradingMdId = entity.EntCodeGradingMdId;
			
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
