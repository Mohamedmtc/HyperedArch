#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="SeAccntFormDiffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeAccntFormDiffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeAccntFormDiff, UMIS_VER2.BusinessLyer.SeAccntFormDiffKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntFormDiffKey key)
		{
			return Delete(transactionManager, key.SeAccntFormDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seAccntFormDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seAccntFormDiffId)
		{
			return Delete(null, _seAccntFormDiffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntFormDiffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seAccntFormDiffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeAccntId(System.Decimal _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(_seAccntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		/// <remarks></remarks>
		public TList<SeAccntFormDiff> GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntId(transactionManager, _seAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_ACCNT key.
		///		fkSeAccntFormDiffSeAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeAccntId(System.Decimal _seAccntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeAccntId(null, _seAccntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_ACCNT key.
		///		fkSeAccntFormDiffSeAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seAccntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeAccntId(System.Decimal _seAccntId, int start, int pageLength,out int count)
		{
			return GetBySeAccntId(null, _seAccntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_ACCNT key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public abstract TList<SeAccntFormDiff> GetBySeAccntId(TransactionManager transactionManager, System.Decimal _seAccntId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_FORM key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_FORM Description: 
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeFormId(System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(_seFormId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_FORM key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		/// <remarks></remarks>
		public TList<SeAccntFormDiff> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_FORM key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_FORM key.
		///		fkSeAccntFormDiffSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeFormId(null, _seFormId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_FORM key.
		///		fkSeAccntFormDiffSeForm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seFormId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public TList<SeAccntFormDiff> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength,out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_ACCNT_FORM_DIFF_SE_FORM key.
		///		FK_SE_ACCNT_FORM_DIFF_SE_FORM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeAccntFormDiff objects.</returns>
		public abstract TList<SeAccntFormDiff> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength, out int count);
		
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override UMIS_VER2.BusinessLyer.SeAccntFormDiff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntFormDiffKey key, int start, int pageLength)
		{
			return GetBySeAccntFormDiffId(transactionManager, key.SeAccntFormDiffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seAccntFormDiffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntFormDiffId(System.Decimal _seAccntFormDiffId)
		{
			int count = -1;
			return GetBySeAccntFormDiffId(null,_seAccntFormDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntFormDiffId(System.Decimal _seAccntFormDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntFormDiffId(null, _seAccntFormDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntFormDiffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntFormDiffId(TransactionManager transactionManager, System.Decimal _seAccntFormDiffId)
		{
			int count = -1;
			return GetBySeAccntFormDiffId(transactionManager, _seAccntFormDiffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntFormDiffId(TransactionManager transactionManager, System.Decimal _seAccntFormDiffId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntFormDiffId(transactionManager, _seAccntFormDiffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntFormDiffId(System.Decimal _seAccntFormDiffId, int start, int pageLength, out int count)
		{
			return GetBySeAccntFormDiffId(null, _seAccntFormDiffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntFormDiffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntFormDiffId(TransactionManager transactionManager, System.Decimal _seAccntFormDiffId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntIdSeFormId(System.Decimal _seAccntId, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeAccntIdSeFormId(null,_seAccntId, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntIdSeFormId(System.Decimal _seAccntId, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntIdSeFormId(null, _seAccntId, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntIdSeFormId(TransactionManager transactionManager, System.Decimal _seAccntId, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeAccntIdSeFormId(transactionManager, _seAccntId, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntIdSeFormId(TransactionManager transactionManager, System.Decimal _seAccntId, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccntIdSeFormId(transactionManager, _seAccntId, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="_seAccntId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntIdSeFormId(System.Decimal _seAccntId, System.Decimal _seFormId, int start, int pageLength, out int count)
		{
			return GetBySeAccntIdSeFormId(null, _seAccntId, _seFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_ACCNT_FORM_DIFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccntId"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeAccntFormDiff GetBySeAccntIdSeFormId(TransactionManager transactionManager, System.Decimal _seAccntId, System.Decimal _seFormId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeAccntFormDiff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeAccntFormDiff&gt;"/></returns>
		public static TList<SeAccntFormDiff> Fill(IDataReader reader, TList<SeAccntFormDiff> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				UMIS_VER2.BusinessLyer.SeAccntFormDiff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeAccntFormDiff")
					.Append("|").Append((System.Decimal)reader["SE_ACCNT_FORM_DIFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeAccntFormDiff>(
					key.ToString(), // EntityTrackingKey
					"SeAccntFormDiff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeAccntFormDiff();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.SeAccntFormDiffId = (System.Decimal)reader["SE_ACCNT_FORM_DIFF_ID"];
					c.OriginalSeAccntFormDiffId = c.SeAccntFormDiffId;
					c.SeAccntId = (System.Decimal)reader["SE_ACCNT_ID"];
					c.SeFormId = (System.Decimal)reader["SE_FORM_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserLstId = Convert.IsDBNull(reader["SE_USER_LST_ID"]) ? null : (System.Decimal?)reader["SE_USER_LST_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeAccntFormDiff entity)
		{
			if (!reader.Read()) return;
			
			entity.SeAccntFormDiffId = (System.Decimal)reader[((int)SeAccntFormDiffColumn.SeAccntFormDiffId - 1)];
			entity.OriginalSeAccntFormDiffId = (System.Decimal)reader["SE_ACCNT_FORM_DIFF_ID"];
			entity.SeAccntId = (System.Decimal)reader[((int)SeAccntFormDiffColumn.SeAccntId - 1)];
			entity.SeFormId = (System.Decimal)reader[((int)SeAccntFormDiffColumn.SeFormId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SeAccntFormDiffColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SeAccntFormDiffColumn.LastDate - 1)];
			entity.SeUserLstId = (reader.IsDBNull(((int)SeAccntFormDiffColumn.SeUserLstId - 1)))?null:(System.Decimal?)reader[((int)SeAccntFormDiffColumn.SeUserLstId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeAccntFormDiff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeAccntFormDiffId = (System.Decimal)dataRow["SE_ACCNT_FORM_DIFF_ID"];
			entity.OriginalSeAccntFormDiffId = (System.Decimal)dataRow["SE_ACCNT_FORM_DIFF_ID"];
			entity.SeAccntId = (System.Decimal)dataRow["SE_ACCNT_ID"];
			entity.SeFormId = (System.Decimal)dataRow["SE_FORM_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserLstId = Convert.IsDBNull(dataRow["SE_USER_LST_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_LST_ID"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeAccntFormDiff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeAccntFormDiff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntFormDiff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeAccntIdSource	
			if (CanDeepLoad(entity, "SeAccnt|SeAccntIdSource", deepLoadType, innerList) 
				&& entity.SeAccntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeAccntId;
				SeAccnt tmpEntity = EntityManager.LocateEntity<SeAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeAccntIdSource = tmpEntity;
				else
					entity.SeAccntIdSource = DataRepository.SeAccntProvider.GetBySeAccntId(transactionManager, entity.SeAccntId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeAccntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeAccntProvider.DeepLoad(transactionManager, entity.SeAccntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeAccntIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeFormId;
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, entity.SeFormId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeAccntFormDiff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeAccntFormDiff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeAccntFormDiff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeAccntFormDiff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeAccntIdSource
			if (CanDeepSave(entity, "SeAccnt|SeAccntIdSource", deepSaveType, innerList) 
				&& entity.SeAccntIdSource != null)
			{
				DataRepository.SeAccntProvider.Save(transactionManager, entity.SeAccntIdSource);
				entity.SeAccntId = entity.SeAccntIdSource.SeAccntId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region SeAccntFormDiffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeAccntFormDiff</c>
	///</summary>
	public enum SeAccntFormDiffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeAccnt</c> at SeAccntIdSource
		///</summary>
		[ChildEntityType(typeof(SeAccnt))]
		SeAccnt,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
	}
	
	#endregion SeAccntFormDiffChildEntityTypes
	
	#region SeAccntFormDiffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeAccntFormDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccntFormDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeAccntFormDiffFilterBuilder : SqlFilterBuilder<SeAccntFormDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntFormDiffFilterBuilder class.
		/// </summary>
		public SeAccntFormDiffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeAccntFormDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeAccntFormDiffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeAccntFormDiffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeAccntFormDiffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeAccntFormDiffFilterBuilder
	
	#region SeAccntFormDiffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeAccntFormDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccntFormDiff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeAccntFormDiffParameterBuilder : ParameterizedSqlFilterBuilder<SeAccntFormDiffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntFormDiffParameterBuilder class.
		/// </summary>
		public SeAccntFormDiffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeAccntFormDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeAccntFormDiffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeAccntFormDiffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeAccntFormDiffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeAccntFormDiffParameterBuilder
	
	#region SeAccntFormDiffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeAccntFormDiffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeAccntFormDiff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeAccntFormDiffSortBuilder : SqlSortBuilder<SeAccntFormDiffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeAccntFormDiffSqlSortBuilder class.
		/// </summary>
		public SeAccntFormDiffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeAccntFormDiffSortBuilder
	
} // end namespace
