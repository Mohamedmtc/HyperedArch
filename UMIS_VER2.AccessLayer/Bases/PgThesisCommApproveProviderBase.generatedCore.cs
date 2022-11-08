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
	/// This class is the base class for any <see cref="PgThesisCommApproveProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisCommApproveProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisCommApprove, UMIS_VER2.BusinessLyer.PgThesisCommApproveKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommApproveKey key)
		{
			return Delete(transactionManager, key.PgThesisCommApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisCommApproveId)
		{
			return Delete(null, _pgThesisCommApproveId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisCommApproveId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(_gsCodeApprovalId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommApprove> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL key.
		///		fkPgThesisCommApproveGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL key.
		///		fkPgThesisCommApproveGsCodeApproval Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength,out int count)
		{
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL key.
		///		FK_PG_THESIS_COMM_APPROVE_GS_CODE_APPROVAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public abstract TList<PgThesisCommApprove> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByPgThesisCommId(System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(_pgThesisCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisCommApprove> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM key.
		///		fkPgThesisCommApprovePgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM key.
		///		fkPgThesisCommApprovePgThesisComm Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public TList<PgThesisCommApprove> GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength,out int count)
		{
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM key.
		///		FK_PG_THESIS_COMM_APPROVE_PG_THESIS_COMM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisCommApprove objects.</returns>
		public abstract TList<PgThesisCommApprove> GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisCommApprove Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommApproveKey key, int start, int pageLength)
		{
			return GetByPgThesisCommApproveId(transactionManager, key.PgThesisCommApproveId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_COMM_APPROVE index.
		/// </summary>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommApprove GetByPgThesisCommApproveId(System.Decimal _pgThesisCommApproveId)
		{
			int count = -1;
			return GetByPgThesisCommApproveId(null,_pgThesisCommApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_APPROVE index.
		/// </summary>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommApprove GetByPgThesisCommApproveId(System.Decimal _pgThesisCommApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommApproveId(null, _pgThesisCommApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommApprove GetByPgThesisCommApproveId(TransactionManager transactionManager, System.Decimal _pgThesisCommApproveId)
		{
			int count = -1;
			return GetByPgThesisCommApproveId(transactionManager, _pgThesisCommApproveId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommApprove GetByPgThesisCommApproveId(TransactionManager transactionManager, System.Decimal _pgThesisCommApproveId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommApproveId(transactionManager, _pgThesisCommApproveId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_APPROVE index.
		/// </summary>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisCommApprove GetByPgThesisCommApproveId(System.Decimal _pgThesisCommApproveId, int start, int pageLength, out int count)
		{
			return GetByPgThesisCommApproveId(null, _pgThesisCommApproveId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM_APPROVE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommApproveId">اعتماد تشكيل لجنة التحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisCommApprove GetByPgThesisCommApproveId(TransactionManager transactionManager, System.Decimal _pgThesisCommApproveId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisCommApprove&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisCommApprove&gt;"/></returns>
		public static TList<PgThesisCommApprove> Fill(IDataReader reader, TList<PgThesisCommApprove> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisCommApprove c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisCommApprove")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_COMM_APPROVE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisCommApprove>(
					key.ToString(), // EntityTrackingKey
					"PgThesisCommApprove",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisCommApprove();
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
					c.PgThesisCommApproveId = (System.Decimal)reader["PG_THESIS_COMM_APPROVE_ID"];
					c.OriginalPgThesisCommApproveId = c.PgThesisCommApproveId;
					c.PgThesisCommId = (System.Decimal)reader["PG_THESIS_COMM_ID"];
					c.GsCodeApprovalId = (System.Decimal)reader["GS_CODE_APPROVAL_ID"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisCommApprove entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisCommApproveId = (System.Decimal)reader[((int)PgThesisCommApproveColumn.PgThesisCommApproveId - 1)];
			entity.OriginalPgThesisCommApproveId = (System.Decimal)reader["PG_THESIS_COMM_APPROVE_ID"];
			entity.PgThesisCommId = (System.Decimal)reader[((int)PgThesisCommApproveColumn.PgThesisCommId - 1)];
			entity.GsCodeApprovalId = (System.Decimal)reader[((int)PgThesisCommApproveColumn.GsCodeApprovalId - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)PgThesisCommApproveColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommApproveColumn.ApproveDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisCommApproveColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisCommApproveColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisCommApproveColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommApproveColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisCommApprove entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisCommApproveId = (System.Decimal)dataRow["PG_THESIS_COMM_APPROVE_ID"];
			entity.OriginalPgThesisCommApproveId = (System.Decimal)dataRow["PG_THESIS_COMM_APPROVE_ID"];
			entity.PgThesisCommId = (System.Decimal)dataRow["PG_THESIS_COMM_ID"];
			entity.GsCodeApprovalId = (System.Decimal)dataRow["GS_CODE_APPROVAL_ID"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisCommApprove"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommApprove Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommApprove entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeApprovalIdSource	
			if (CanDeepLoad(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalId;
				GsCodeApproval tmpEntity = EntityManager.LocateEntity<GsCodeApproval>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApproval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalIdSource = tmpEntity;
				else
					entity.GsCodeApprovalIdSource = DataRepository.GsCodeApprovalProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalProvider.DeepLoad(transactionManager, entity.GsCodeApprovalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalIdSource

			#region PgThesisCommIdSource	
			if (CanDeepLoad(entity, "PgThesisComm|PgThesisCommIdSource", deepLoadType, innerList) 
				&& entity.PgThesisCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisCommId;
				PgThesisComm tmpEntity = EntityManager.LocateEntity<PgThesisComm>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisCommIdSource = tmpEntity;
				else
					entity.PgThesisCommIdSource = DataRepository.PgThesisCommProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisCommProvider.DeepLoad(transactionManager, entity.PgThesisCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisCommIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisCommApprove object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisCommApprove instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisCommApprove Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommApprove entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeApprovalIdSource
			if (CanDeepSave(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalIdSource != null)
			{
				DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalIdSource);
				entity.GsCodeApprovalId = entity.GsCodeApprovalIdSource.GsCodeApprovalId;
			}
			#endregion 
			
			#region PgThesisCommIdSource
			if (CanDeepSave(entity, "PgThesisComm|PgThesisCommIdSource", deepSaveType, innerList) 
				&& entity.PgThesisCommIdSource != null)
			{
				DataRepository.PgThesisCommProvider.Save(transactionManager, entity.PgThesisCommIdSource);
				entity.PgThesisCommId = entity.PgThesisCommIdSource.PgThesisCommId;
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
	
	#region PgThesisCommApproveChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisCommApprove</c>
	///</summary>
	public enum PgThesisCommApproveChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeApproval</c> at GsCodeApprovalIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApproval))]
		GsCodeApproval,
		
		///<summary>
		/// Composite Property for <c>PgThesisComm</c> at PgThesisCommIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisComm))]
		PgThesisComm,
	}
	
	#endregion PgThesisCommApproveChildEntityTypes
	
	#region PgThesisCommApproveFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisCommApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommApproveFilterBuilder : SqlFilterBuilder<PgThesisCommApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommApproveFilterBuilder class.
		/// </summary>
		public PgThesisCommApproveFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommApproveFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommApproveFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommApproveFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommApproveFilterBuilder
	
	#region PgThesisCommApproveParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisCommApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommApprove"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommApproveParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisCommApproveColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommApproveParameterBuilder class.
		/// </summary>
		public PgThesisCommApproveParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommApproveParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommApproveParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommApproveParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommApproveParameterBuilder
	
	#region PgThesisCommApproveSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisCommApproveColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisCommApprove"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisCommApproveSortBuilder : SqlSortBuilder<PgThesisCommApproveColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommApproveSqlSortBuilder class.
		/// </summary>
		public PgThesisCommApproveSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisCommApproveSortBuilder
	
} // end namespace
