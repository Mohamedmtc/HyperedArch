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
	/// This class is the base class for any <see cref="MltRptDayOutStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltRptDayOutStudProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MltRptDayOutStud, UMIS_VER2.BusinessLyer.MltRptDayOutStudKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOutStudKey key)
		{
			return Delete(transactionManager, key.MltRptDayOutStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mltRptDayOutStudId)
		{
			return Delete(null, _mltRptDayOutStudId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mltRptDayOutStudId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_ED_STUD key.
		///		FK_MLT_RPT_DAY_OUT_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_ED_STUD key.
		///		FK_MLT_RPT_DAY_OUT_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayOutStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_ED_STUD key.
		///		FK_MLT_RPT_DAY_OUT_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_ED_STUD key.
		///		fkMltRptDayOutStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_ED_STUD key.
		///		fkMltRptDayOutStudEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_ED_STUD key.
		///		FK_MLT_RPT_DAY_OUT_STUD_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public abstract TList<MltRptDayOutStud> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT key.
		///		FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT Description: 
		/// </summary>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByMltRptDayOutId(System.Decimal _mltRptDayOutId)
		{
			int count = -1;
			return GetByMltRptDayOutId(_mltRptDayOutId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT key.
		///		FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		/// <remarks></remarks>
		public TList<MltRptDayOutStud> GetByMltRptDayOutId(TransactionManager transactionManager, System.Decimal _mltRptDayOutId)
		{
			int count = -1;
			return GetByMltRptDayOutId(transactionManager, _mltRptDayOutId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT key.
		///		FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByMltRptDayOutId(TransactionManager transactionManager, System.Decimal _mltRptDayOutId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayOutId(transactionManager, _mltRptDayOutId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT key.
		///		fkMltRptDayOutStudMltRptDayOut Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByMltRptDayOutId(System.Decimal _mltRptDayOutId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMltRptDayOutId(null, _mltRptDayOutId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT key.
		///		fkMltRptDayOutStudMltRptDayOut Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public TList<MltRptDayOutStud> GetByMltRptDayOutId(System.Decimal _mltRptDayOutId, int start, int pageLength,out int count)
		{
			return GetByMltRptDayOutId(null, _mltRptDayOutId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT key.
		///		FK_MLT_RPT_DAY_OUT_STUD_MLT_RPT_DAY_OUT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutId">بيان الخروج</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MltRptDayOutStud objects.</returns>
		public abstract TList<MltRptDayOutStud> GetByMltRptDayOutId(TransactionManager transactionManager, System.Decimal _mltRptDayOutId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MltRptDayOutStud Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOutStudKey key, int start, int pageLength)
		{
			return GetByMltRptDayOutStudId(transactionManager, key.MltRptDayOutStudId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MLT_RPT_DAY_OUT_STUD index.
		/// </summary>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOutStud GetByMltRptDayOutStudId(System.Decimal _mltRptDayOutStudId)
		{
			int count = -1;
			return GetByMltRptDayOutStudId(null,_mltRptDayOutStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT_STUD index.
		/// </summary>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOutStud GetByMltRptDayOutStudId(System.Decimal _mltRptDayOutStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayOutStudId(null, _mltRptDayOutStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOutStud GetByMltRptDayOutStudId(TransactionManager transactionManager, System.Decimal _mltRptDayOutStudId)
		{
			int count = -1;
			return GetByMltRptDayOutStudId(transactionManager, _mltRptDayOutStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOutStud GetByMltRptDayOutStudId(TransactionManager transactionManager, System.Decimal _mltRptDayOutStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByMltRptDayOutStudId(transactionManager, _mltRptDayOutStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT_STUD index.
		/// </summary>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MltRptDayOutStud GetByMltRptDayOutStudId(System.Decimal _mltRptDayOutStudId, int start, int pageLength, out int count)
		{
			return GetByMltRptDayOutStudId(null, _mltRptDayOutStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MLT_RPT_DAY_OUT_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mltRptDayOutStudId">تفاصيل خروج الطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MltRptDayOutStud GetByMltRptDayOutStudId(TransactionManager transactionManager, System.Decimal _mltRptDayOutStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MltRptDayOutStud&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MltRptDayOutStud&gt;"/></returns>
		public static TList<MltRptDayOutStud> Fill(IDataReader reader, TList<MltRptDayOutStud> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MltRptDayOutStud c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MltRptDayOutStud")
					.Append("|").Append((System.Decimal)reader["MLT_RPT_DAY_OUT_STUD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MltRptDayOutStud>(
					key.ToString(), // EntityTrackingKey
					"MltRptDayOutStud",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MltRptDayOutStud();
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
					c.MltRptDayOutStudId = (System.Decimal)reader["MLT_RPT_DAY_OUT_STUD_ID"];
					c.OriginalMltRptDayOutStudId = c.MltRptDayOutStudId;
					c.MltRptDayOutId = (System.Decimal)reader["MLT_RPT_DAY_OUT_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MltRptDayOutStud entity)
		{
			if (!reader.Read()) return;
			
			entity.MltRptDayOutStudId = (System.Decimal)reader[((int)MltRptDayOutStudColumn.MltRptDayOutStudId - 1)];
			entity.OriginalMltRptDayOutStudId = (System.Decimal)reader["MLT_RPT_DAY_OUT_STUD_ID"];
			entity.MltRptDayOutId = (System.Decimal)reader[((int)MltRptDayOutStudColumn.MltRptDayOutId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)MltRptDayOutStudColumn.EdStudId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MltRptDayOutStud entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MltRptDayOutStudId = (System.Decimal)dataRow["MLT_RPT_DAY_OUT_STUD_ID"];
			entity.OriginalMltRptDayOutStudId = (System.Decimal)dataRow["MLT_RPT_DAY_OUT_STUD_ID"];
			entity.MltRptDayOutId = (System.Decimal)dataRow["MLT_RPT_DAY_OUT_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MltRptDayOutStud"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayOutStud Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOutStud entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

			#region MltRptDayOutIdSource	
			if (CanDeepLoad(entity, "MltRptDayOut|MltRptDayOutIdSource", deepLoadType, innerList) 
				&& entity.MltRptDayOutIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MltRptDayOutId;
				MltRptDayOut tmpEntity = EntityManager.LocateEntity<MltRptDayOut>(EntityLocator.ConstructKeyFromPkItems(typeof(MltRptDayOut), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MltRptDayOutIdSource = tmpEntity;
				else
					entity.MltRptDayOutIdSource = DataRepository.MltRptDayOutProvider.GetByMltRptDayOutId(transactionManager, entity.MltRptDayOutId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayOutIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MltRptDayOutIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MltRptDayOutProvider.DeepLoad(transactionManager, entity.MltRptDayOutIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MltRptDayOutIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MltRptDayOutStud object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MltRptDayOutStud instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MltRptDayOutStud Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MltRptDayOutStud entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region MltRptDayOutIdSource
			if (CanDeepSave(entity, "MltRptDayOut|MltRptDayOutIdSource", deepSaveType, innerList) 
				&& entity.MltRptDayOutIdSource != null)
			{
				DataRepository.MltRptDayOutProvider.Save(transactionManager, entity.MltRptDayOutIdSource);
				entity.MltRptDayOutId = entity.MltRptDayOutIdSource.MltRptDayOutId;
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
	
	#region MltRptDayOutStudChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MltRptDayOutStud</c>
	///</summary>
	public enum MltRptDayOutStudChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>MltRptDayOut</c> at MltRptDayOutIdSource
		///</summary>
		[ChildEntityType(typeof(MltRptDayOut))]
		MltRptDayOut,
	}
	
	#endregion MltRptDayOutStudChildEntityTypes
	
	#region MltRptDayOutStudFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MltRptDayOutStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayOutStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayOutStudFilterBuilder : SqlFilterBuilder<MltRptDayOutStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutStudFilterBuilder class.
		/// </summary>
		public MltRptDayOutStudFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayOutStudFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutStudFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayOutStudFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayOutStudFilterBuilder
	
	#region MltRptDayOutStudParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MltRptDayOutStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayOutStud"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MltRptDayOutStudParameterBuilder : ParameterizedSqlFilterBuilder<MltRptDayOutStudColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutStudParameterBuilder class.
		/// </summary>
		public MltRptDayOutStudParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MltRptDayOutStudParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutStudParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MltRptDayOutStudParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MltRptDayOutStudParameterBuilder
	
	#region MltRptDayOutStudSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MltRptDayOutStudColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MltRptDayOutStud"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MltRptDayOutStudSortBuilder : SqlSortBuilder<MltRptDayOutStudColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MltRptDayOutStudSqlSortBuilder class.
		/// </summary>
		public MltRptDayOutStudSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MltRptDayOutStudSortBuilder
	
} // end namespace
