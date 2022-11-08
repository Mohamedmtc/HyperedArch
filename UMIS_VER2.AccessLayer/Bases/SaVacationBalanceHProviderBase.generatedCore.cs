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
	/// This class is the base class for any <see cref="SaVacationBalanceHProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaVacationBalanceHProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaVacationBalanceH, UMIS_VER2.BusinessLyer.SaVacationBalanceHKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalanceHKey key)
		{
			return Delete(transactionManager, key.SaVacationBalanceHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saVacationBalanceHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saVacationBalanceHId)
		{
			return Delete(null, _saVacationBalanceHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saVacationBalanceHId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0030 key.
		///		FK_AUTO_0030 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0030 key.
		///		FK_AUTO_0030 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationBalanceH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0030 key.
		///		FK_AUTO_0030 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0030 key.
		///		fkAuto0030 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0030 key.
		///		fkAuto0030 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0030 key.
		///		FK_AUTO_0030 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public abstract TList<SaVacationBalanceH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="_saVacationBylowId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetBySaVacationBylowId(System.Decimal _saVacationBylowId)
		{
			int count = -1;
			return GetBySaVacationBylowId(_saVacationBylowId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylowId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationBalanceH> GetBySaVacationBylowId(TransactionManager transactionManager, System.Decimal _saVacationBylowId)
		{
			int count = -1;
			return GetBySaVacationBylowId(transactionManager, _saVacationBylowId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylowId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetBySaVacationBylowId(TransactionManager transactionManager, System.Decimal _saVacationBylowId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBylowId(transactionManager, _saVacationBylowId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS key.
		///		fkSaVacationBalanceHSaVacationBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylowId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetBySaVacationBylowId(System.Decimal _saVacationBylowId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaVacationBylowId(null, _saVacationBylowId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS key.
		///		fkSaVacationBalanceHSaVacationBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saVacationBylowId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public TList<SaVacationBalanceH> GetBySaVacationBylowId(System.Decimal _saVacationBylowId, int start, int pageLength,out int count)
		{
			return GetBySaVacationBylowId(null, _saVacationBylowId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS key.
		///		FK_SA_VACATION_BALANCE_H_SA_VACATION_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylowId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBalanceH objects.</returns>
		public abstract TList<SaVacationBalanceH> GetBySaVacationBylowId(TransactionManager transactionManager, System.Decimal _saVacationBylowId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaVacationBalanceH Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalanceHKey key, int start, int pageLength)
		{
			return GetBySaVacationBalanceHId(transactionManager, key.SaVacationBalanceHId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_VACATION_BALANCE_H index.
		/// </summary>
		/// <param name="_saVacationBalanceHId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalanceH GetBySaVacationBalanceHId(System.Decimal _saVacationBalanceHId)
		{
			int count = -1;
			return GetBySaVacationBalanceHId(null,_saVacationBalanceHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE_H index.
		/// </summary>
		/// <param name="_saVacationBalanceHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalanceH GetBySaVacationBalanceHId(System.Decimal _saVacationBalanceHId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBalanceHId(null, _saVacationBalanceHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalanceH GetBySaVacationBalanceHId(TransactionManager transactionManager, System.Decimal _saVacationBalanceHId)
		{
			int count = -1;
			return GetBySaVacationBalanceHId(transactionManager, _saVacationBalanceHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalanceH GetBySaVacationBalanceHId(TransactionManager transactionManager, System.Decimal _saVacationBalanceHId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBalanceHId(transactionManager, _saVacationBalanceHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE_H index.
		/// </summary>
		/// <param name="_saVacationBalanceHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBalanceH GetBySaVacationBalanceHId(System.Decimal _saVacationBalanceHId, int start, int pageLength, out int count)
		{
			return GetBySaVacationBalanceHId(null, _saVacationBalanceHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BALANCE_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBalanceHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaVacationBalanceH GetBySaVacationBalanceHId(TransactionManager transactionManager, System.Decimal _saVacationBalanceHId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaVacationBalanceH&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaVacationBalanceH&gt;"/></returns>
		public static TList<SaVacationBalanceH> Fill(IDataReader reader, TList<SaVacationBalanceH> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaVacationBalanceH c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaVacationBalanceH")
					.Append("|").Append((System.Decimal)reader["SA_VACATION_BALANCE_H_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaVacationBalanceH>(
					key.ToString(), // EntityTrackingKey
					"SaVacationBalanceH",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaVacationBalanceH();
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
					c.SaVacationBalanceHId = (System.Decimal)reader["SA_VACATION_BALANCE_H_ID"];
					c.OriginalSaVacationBalanceHId = c.SaVacationBalanceHId;
					c.AsNodeId = (System.Decimal)reader["AS_NODE_ID"];
					c.PeriodFrom = (System.DateTime)reader["PERIOD_FROM"];
					c.PeriodTo = (System.DateTime)reader["PERIOD_TO"];
					c.DeductFromTransfer = (System.Decimal)reader["DEDUCT_FROM_TRANSFER"];
					c.DeductApprovedDate = Convert.IsDBNull(reader["DEDUCT_APPROVED_DATE"]) ? null : (System.DateTime?)reader["DEDUCT_APPROVED_DATE"];
					c.SaBalance = (System.Decimal)reader["SA_BALANCE"];
					c.SaVacationBylowId = (System.Decimal)reader["SA_VACATION_BYLOW_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaVacationBalanceH entity)
		{
			if (!reader.Read()) return;
			
			entity.SaVacationBalanceHId = (System.Decimal)reader[((int)SaVacationBalanceHColumn.SaVacationBalanceHId - 1)];
			entity.OriginalSaVacationBalanceHId = (System.Decimal)reader["SA_VACATION_BALANCE_H_ID"];
			entity.AsNodeId = (System.Decimal)reader[((int)SaVacationBalanceHColumn.AsNodeId - 1)];
			entity.PeriodFrom = (System.DateTime)reader[((int)SaVacationBalanceHColumn.PeriodFrom - 1)];
			entity.PeriodTo = (System.DateTime)reader[((int)SaVacationBalanceHColumn.PeriodTo - 1)];
			entity.DeductFromTransfer = (System.Decimal)reader[((int)SaVacationBalanceHColumn.DeductFromTransfer - 1)];
			entity.DeductApprovedDate = (reader.IsDBNull(((int)SaVacationBalanceHColumn.DeductApprovedDate - 1)))?null:(System.DateTime?)reader[((int)SaVacationBalanceHColumn.DeductApprovedDate - 1)];
			entity.SaBalance = (System.Decimal)reader[((int)SaVacationBalanceHColumn.SaBalance - 1)];
			entity.SaVacationBylowId = (System.Decimal)reader[((int)SaVacationBalanceHColumn.SaVacationBylowId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaVacationBalanceHColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaVacationBalanceH entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaVacationBalanceHId = (System.Decimal)dataRow["SA_VACATION_BALANCE_H_ID"];
			entity.OriginalSaVacationBalanceHId = (System.Decimal)dataRow["SA_VACATION_BALANCE_H_ID"];
			entity.AsNodeId = (System.Decimal)dataRow["AS_NODE_ID"];
			entity.PeriodFrom = (System.DateTime)dataRow["PERIOD_FROM"];
			entity.PeriodTo = (System.DateTime)dataRow["PERIOD_TO"];
			entity.DeductFromTransfer = (System.Decimal)dataRow["DEDUCT_FROM_TRANSFER"];
			entity.DeductApprovedDate = Convert.IsDBNull(dataRow["DEDUCT_APPROVED_DATE"]) ? null : (System.DateTime?)dataRow["DEDUCT_APPROVED_DATE"];
			entity.SaBalance = (System.Decimal)dataRow["SA_BALANCE"];
			entity.SaVacationBylowId = (System.Decimal)dataRow["SA_VACATION_BYLOW_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBalanceH"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationBalanceH Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalanceH entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SaVacationBylowIdSource	
			if (CanDeepLoad(entity, "SaVacationBylaws|SaVacationBylowIdSource", deepLoadType, innerList) 
				&& entity.SaVacationBylowIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaVacationBylowId;
				SaVacationBylaws tmpEntity = EntityManager.LocateEntity<SaVacationBylaws>(EntityLocator.ConstructKeyFromPkItems(typeof(SaVacationBylaws), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaVacationBylowIdSource = tmpEntity;
				else
					entity.SaVacationBylowIdSource = DataRepository.SaVacationBylawsProvider.GetBySaVacationBylawsId(transactionManager, entity.SaVacationBylowId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBylowIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaVacationBylowIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaVacationBylawsProvider.DeepLoad(transactionManager, entity.SaVacationBylowIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaVacationBylowIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaVacationBalanceHId methods when available
			
			#region SaVacationBalanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationBalance>|SaVacationBalanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBalanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationBalanceCollection = DataRepository.SaVacationBalanceProvider.GetBySaVacationBalanceHId(transactionManager, entity.SaVacationBalanceHId);

				if (deep && entity.SaVacationBalanceCollection.Count > 0)
				{
					deepHandles.Add("SaVacationBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationBalance>) DataRepository.SaVacationBalanceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationBalanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaVacationBalanceH object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaVacationBalanceH instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationBalanceH Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBalanceH entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaVacationBylowIdSource
			if (CanDeepSave(entity, "SaVacationBylaws|SaVacationBylowIdSource", deepSaveType, innerList) 
				&& entity.SaVacationBylowIdSource != null)
			{
				DataRepository.SaVacationBylawsProvider.Save(transactionManager, entity.SaVacationBylowIdSource);
				entity.SaVacationBylowId = entity.SaVacationBylowIdSource.SaVacationBylawsId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaVacationBalance>
				if (CanDeepSave(entity.SaVacationBalanceCollection, "List<SaVacationBalance>|SaVacationBalanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationBalance child in entity.SaVacationBalanceCollection)
					{
						if(child.SaVacationBalanceHIdSource != null)
						{
							child.SaVacationBalanceHId = child.SaVacationBalanceHIdSource.SaVacationBalanceHId;
						}
						else
						{
							child.SaVacationBalanceHId = entity.SaVacationBalanceHId;
						}

					}

					if (entity.SaVacationBalanceCollection.Count > 0 || entity.SaVacationBalanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationBalanceProvider.Save(transactionManager, entity.SaVacationBalanceCollection);
						
						deepHandles.Add("SaVacationBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationBalance >) DataRepository.SaVacationBalanceProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationBalanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region SaVacationBalanceHChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaVacationBalanceH</c>
	///</summary>
	public enum SaVacationBalanceHChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaVacationBylaws</c> at SaVacationBylowIdSource
		///</summary>
		[ChildEntityType(typeof(SaVacationBylaws))]
		SaVacationBylaws,
		///<summary>
		/// Collection of <c>SaVacationBalanceH</c> as OneToMany for SaVacationBalanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationBalance>))]
		SaVacationBalanceCollection,
	}
	
	#endregion SaVacationBalanceHChildEntityTypes
	
	#region SaVacationBalanceHFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaVacationBalanceHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBalanceH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationBalanceHFilterBuilder : SqlFilterBuilder<SaVacationBalanceHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceHFilterBuilder class.
		/// </summary>
		public SaVacationBalanceHFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationBalanceHFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationBalanceHFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationBalanceHFilterBuilder
	
	#region SaVacationBalanceHParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaVacationBalanceHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBalanceH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationBalanceHParameterBuilder : ParameterizedSqlFilterBuilder<SaVacationBalanceHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceHParameterBuilder class.
		/// </summary>
		public SaVacationBalanceHParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationBalanceHParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationBalanceHParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationBalanceHParameterBuilder
	
	#region SaVacationBalanceHSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaVacationBalanceHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBalanceH"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaVacationBalanceHSortBuilder : SqlSortBuilder<SaVacationBalanceHColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBalanceHSqlSortBuilder class.
		/// </summary>
		public SaVacationBalanceHSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaVacationBalanceHSortBuilder
	
} // end namespace
