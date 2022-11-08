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
	/// This class is the base class for any <see cref="GsApprovalDProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsApprovalDProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsApprovalD, UMIS_VER2.BusinessLyer.GsApprovalDKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalDKey key)
		{
			return Delete(transactionManager, key.GsApprovalDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsApprovalDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsApprovalDId)
		{
			return Delete(null, _gsApprovalDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsApprovalDId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000d key.
		///		FK_AUTO_000d Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000d key.
		///		FK_AUTO_000d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		/// <remarks></remarks>
		public TList<GsApprovalD> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000d key.
		///		FK_AUTO_000d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000d key.
		///		fkAuto000d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000d key.
		///		fkAuto000d Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000d key.
		///		FK_AUTO_000d Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public abstract TList<GsApprovalD> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000e key.
		///		FK_AUTO_000e Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByGsCodeApprovalListDId(System.Decimal _gsCodeApprovalListDId)
		{
			int count = -1;
			return GetByGsCodeApprovalListDId(_gsCodeApprovalListDId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000e key.
		///		FK_AUTO_000e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		/// <remarks></remarks>
		public TList<GsApprovalD> GetByGsCodeApprovalListDId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListDId)
		{
			int count = -1;
			return GetByGsCodeApprovalListDId(transactionManager, _gsCodeApprovalListDId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000e key.
		///		FK_AUTO_000e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByGsCodeApprovalListDId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListDId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListDId(transactionManager, _gsCodeApprovalListDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000e key.
		///		fkAuto000e Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByGsCodeApprovalListDId(System.Decimal _gsCodeApprovalListDId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalListDId(null, _gsCodeApprovalListDId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000e key.
		///		fkAuto000e Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public TList<GsApprovalD> GetByGsCodeApprovalListDId(System.Decimal _gsCodeApprovalListDId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalListDId(null, _gsCodeApprovalListDId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000e key.
		///		FK_AUTO_000e Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsApprovalD objects.</returns>
		public abstract TList<GsApprovalD> GetByGsCodeApprovalListDId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListDId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsApprovalD Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalDKey key, int start, int pageLength)
		{
			return GetByGsApprovalDId(transactionManager, key.GsApprovalDId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsApprovalD&gt;"/> class.</returns>
		public TList<GsApprovalD> GetByGsApprovalHId(System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(null,_gsApprovalHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsApprovalD&gt;"/> class.</returns>
		public TList<GsApprovalD> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsApprovalD&gt;"/> class.</returns>
		public TList<GsApprovalD> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsApprovalD&gt;"/> class.</returns>
		public TList<GsApprovalD> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalHId(transactionManager, _gsApprovalHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsApprovalD&gt;"/> class.</returns>
		public TList<GsApprovalD> GetByGsApprovalHId(System.Decimal _gsApprovalHId, int start, int pageLength, out int count)
		{
			return GetByGsApprovalHId(null, _gsApprovalHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_APPROVAL_H_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsApprovalD&gt;"/> class.</returns>
		public abstract TList<GsApprovalD> GetByGsApprovalHId(TransactionManager transactionManager, System.Decimal _gsApprovalHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_APPROVAL_D index.
		/// </summary>
		/// <param name="_gsApprovalDId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalD GetByGsApprovalDId(System.Decimal _gsApprovalDId)
		{
			int count = -1;
			return GetByGsApprovalDId(null,_gsApprovalDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_D index.
		/// </summary>
		/// <param name="_gsApprovalDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalD GetByGsApprovalDId(System.Decimal _gsApprovalDId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalDId(null, _gsApprovalDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalDId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalD GetByGsApprovalDId(TransactionManager transactionManager, System.Decimal _gsApprovalDId)
		{
			int count = -1;
			return GetByGsApprovalDId(transactionManager, _gsApprovalDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalD GetByGsApprovalDId(TransactionManager transactionManager, System.Decimal _gsApprovalDId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsApprovalDId(transactionManager, _gsApprovalDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_D index.
		/// </summary>
		/// <param name="_gsApprovalDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsApprovalD GetByGsApprovalDId(System.Decimal _gsApprovalDId, int start, int pageLength, out int count)
		{
			return GetByGsApprovalDId(null, _gsApprovalDId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_APPROVAL_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsApprovalDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsApprovalD GetByGsApprovalDId(TransactionManager transactionManager, System.Decimal _gsApprovalDId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsApprovalD&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsApprovalD&gt;"/></returns>
		public static TList<GsApprovalD> Fill(IDataReader reader, TList<GsApprovalD> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsApprovalD c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsApprovalD")
					.Append("|").Append((System.Decimal)reader["GS_APPROVAL_D_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsApprovalD>(
					key.ToString(), // EntityTrackingKey
					"GsApprovalD",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsApprovalD();
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
					c.GsApprovalDId = (System.Decimal)reader["GS_APPROVAL_D_ID"];
					c.OriginalGsApprovalDId = c.GsApprovalDId;
					c.GsApprovalHId = (System.Decimal)reader["GS_APPROVAL_H_ID"];
					c.GsCodeApprovalListDId = (System.Decimal)reader["GS_CODE_APPROVAL_LIST_D_ID"];
					c.IssueDate = Convert.IsDBNull(reader["ISSUE_DATE"]) ? null : (System.DateTime?)reader["ISSUE_DATE"];
					c.IssueNumber = Convert.IsDBNull(reader["ISSUE_NUMBER"]) ? null : (System.String)reader["ISSUE_NUMBER"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.IssueText = Convert.IsDBNull(reader["ISSUE_TEXT"]) ? null : (System.String)reader["ISSUE_TEXT"];
					c.IssueNotes = Convert.IsDBNull(reader["ISSUE_NOTES"]) ? null : (System.String)reader["ISSUE_NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsApprovalD entity)
		{
			if (!reader.Read()) return;
			
			entity.GsApprovalDId = (System.Decimal)reader[((int)GsApprovalDColumn.GsApprovalDId - 1)];
			entity.OriginalGsApprovalDId = (System.Decimal)reader["GS_APPROVAL_D_ID"];
			entity.GsApprovalHId = (System.Decimal)reader[((int)GsApprovalDColumn.GsApprovalHId - 1)];
			entity.GsCodeApprovalListDId = (System.Decimal)reader[((int)GsApprovalDColumn.GsCodeApprovalListDId - 1)];
			entity.IssueDate = (reader.IsDBNull(((int)GsApprovalDColumn.IssueDate - 1)))?null:(System.DateTime?)reader[((int)GsApprovalDColumn.IssueDate - 1)];
			entity.IssueNumber = (reader.IsDBNull(((int)GsApprovalDColumn.IssueNumber - 1)))?null:(System.String)reader[((int)GsApprovalDColumn.IssueNumber - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)GsApprovalDColumn.AsFacultyInfoId - 1)];
			entity.IssueText = (reader.IsDBNull(((int)GsApprovalDColumn.IssueText - 1)))?null:(System.String)reader[((int)GsApprovalDColumn.IssueText - 1)];
			entity.IssueNotes = (reader.IsDBNull(((int)GsApprovalDColumn.IssueNotes - 1)))?null:(System.String)reader[((int)GsApprovalDColumn.IssueNotes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsApprovalD entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsApprovalDId = (System.Decimal)dataRow["GS_APPROVAL_D_ID"];
			entity.OriginalGsApprovalDId = (System.Decimal)dataRow["GS_APPROVAL_D_ID"];
			entity.GsApprovalHId = (System.Decimal)dataRow["GS_APPROVAL_H_ID"];
			entity.GsCodeApprovalListDId = (System.Decimal)dataRow["GS_CODE_APPROVAL_LIST_D_ID"];
			entity.IssueDate = Convert.IsDBNull(dataRow["ISSUE_DATE"]) ? null : (System.DateTime?)dataRow["ISSUE_DATE"];
			entity.IssueNumber = Convert.IsDBNull(dataRow["ISSUE_NUMBER"]) ? null : (System.String)dataRow["ISSUE_NUMBER"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.IssueText = Convert.IsDBNull(dataRow["ISSUE_TEXT"]) ? null : (System.String)dataRow["ISSUE_TEXT"];
			entity.IssueNotes = Convert.IsDBNull(dataRow["ISSUE_NOTES"]) ? null : (System.String)dataRow["ISSUE_NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsApprovalD"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsApprovalD Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalD entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region GsCodeApprovalListDIdSource	
			if (CanDeepLoad(entity, "GsCodeApprovalListD|GsCodeApprovalListDIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalListDIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalListDId;
				GsCodeApprovalListD tmpEntity = EntityManager.LocateEntity<GsCodeApprovalListD>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApprovalListD), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalListDIdSource = tmpEntity;
				else
					entity.GsCodeApprovalListDIdSource = DataRepository.GsCodeApprovalListDProvider.GetByGsCodeApprovalListDId(transactionManager, entity.GsCodeApprovalListDId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalListDIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalListDIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalListDProvider.DeepLoad(transactionManager, entity.GsCodeApprovalListDIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalListDIdSource

			#region GsApprovalHIdSource	
			if (CanDeepLoad(entity, "GsApprovalH|GsApprovalHIdSource", deepLoadType, innerList) 
				&& entity.GsApprovalHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsApprovalHId;
				GsApprovalH tmpEntity = EntityManager.LocateEntity<GsApprovalH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsApprovalH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsApprovalHIdSource = tmpEntity;
				else
					entity.GsApprovalHIdSource = DataRepository.GsApprovalHProvider.GetByGsApprovalHId(transactionManager, entity.GsApprovalHId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsApprovalHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsApprovalHProvider.DeepLoad(transactionManager, entity.GsApprovalHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsApprovalHIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsApprovalD object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsApprovalD instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsApprovalD Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsApprovalD entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region GsCodeApprovalListDIdSource
			if (CanDeepSave(entity, "GsCodeApprovalListD|GsCodeApprovalListDIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalListDIdSource != null)
			{
				DataRepository.GsCodeApprovalListDProvider.Save(transactionManager, entity.GsCodeApprovalListDIdSource);
				entity.GsCodeApprovalListDId = entity.GsCodeApprovalListDIdSource.GsCodeApprovalListDId;
			}
			#endregion 
			
			#region GsApprovalHIdSource
			if (CanDeepSave(entity, "GsApprovalH|GsApprovalHIdSource", deepSaveType, innerList) 
				&& entity.GsApprovalHIdSource != null)
			{
				DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHIdSource);
				entity.GsApprovalHId = entity.GsApprovalHIdSource.GsApprovalHId;
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
	
	#region GsApprovalDChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsApprovalD</c>
	///</summary>
	public enum GsApprovalDChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsCodeApprovalListD</c> at GsCodeApprovalListDIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApprovalListD))]
		GsCodeApprovalListD,
		
		///<summary>
		/// Composite Property for <c>GsApprovalH</c> at GsApprovalHIdSource
		///</summary>
		[ChildEntityType(typeof(GsApprovalH))]
		GsApprovalH,
	}
	
	#endregion GsApprovalDChildEntityTypes
	
	#region GsApprovalDFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsApprovalDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsApprovalD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsApprovalDFilterBuilder : SqlFilterBuilder<GsApprovalDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsApprovalDFilterBuilder class.
		/// </summary>
		public GsApprovalDFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsApprovalDFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsApprovalDFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsApprovalDFilterBuilder
	
	#region GsApprovalDParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsApprovalDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsApprovalD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsApprovalDParameterBuilder : ParameterizedSqlFilterBuilder<GsApprovalDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsApprovalDParameterBuilder class.
		/// </summary>
		public GsApprovalDParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsApprovalDParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsApprovalDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsApprovalDParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsApprovalDParameterBuilder
	
	#region GsApprovalDSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsApprovalDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsApprovalD"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsApprovalDSortBuilder : SqlSortBuilder<GsApprovalDColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsApprovalDSqlSortBuilder class.
		/// </summary>
		public GsApprovalDSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsApprovalDSortBuilder
	
} // end namespace
