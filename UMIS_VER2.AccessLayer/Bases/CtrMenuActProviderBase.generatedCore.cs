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
	/// This class is the base class for any <see cref="CtrMenuActProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrMenuActProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrMenuAct, UMIS_VER2.BusinessLyer.CtrMenuActKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuActKey key)
		{
			return Delete(transactionManager, key.CtrMenuActId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrMenuActId)
		{
			return Delete(null, _ctrMenuActId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrMenuActId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_ACT_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(_ctrCdeMealId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_ACT_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenuAct> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_ACT_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_CDE_MEAL key.
		///		fkCtrMenuActCtrCdeMeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_CDE_MEAL key.
		///		fkCtrMenuActCtrCdeMeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_ACT_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public abstract TList<CtrMenuAct> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_MENU key.
		///		FK_CTR_MENU_ACT_CTR_MENU Description: 
		/// </summary>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrMenuId(System.Decimal? _ctrMenuId)
		{
			int count = -1;
			return GetByCtrMenuId(_ctrMenuId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_MENU key.
		///		FK_CTR_MENU_ACT_CTR_MENU Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenuAct> GetByCtrMenuId(TransactionManager transactionManager, System.Decimal? _ctrMenuId)
		{
			int count = -1;
			return GetByCtrMenuId(transactionManager, _ctrMenuId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_MENU key.
		///		FK_CTR_MENU_ACT_CTR_MENU Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrMenuId(TransactionManager transactionManager, System.Decimal? _ctrMenuId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuId(transactionManager, _ctrMenuId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_MENU key.
		///		fkCtrMenuActCtrMenu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrMenuId(System.Decimal? _ctrMenuId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrMenuId(null, _ctrMenuId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_MENU key.
		///		fkCtrMenuActCtrMenu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByCtrMenuId(System.Decimal? _ctrMenuId, int start, int pageLength,out int count)
		{
			return GetByCtrMenuId(null, _ctrMenuId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_CTR_MENU key.
		///		FK_CTR_MENU_ACT_CTR_MENU Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public abstract TList<CtrMenuAct> GetByCtrMenuId(TransactionManager transactionManager, System.Decimal? _ctrMenuId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_SC_TCHNG_DAY key.
		///		FK_CTR_MENU_ACT_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="_scTchngDayId">يوم التدريس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByScTchngDayId(System.Decimal? _scTchngDayId)
		{
			int count = -1;
			return GetByScTchngDayId(_scTchngDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_SC_TCHNG_DAY key.
		///		FK_CTR_MENU_ACT_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId">يوم التدريس</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenuAct> GetByScTchngDayId(TransactionManager transactionManager, System.Decimal? _scTchngDayId)
		{
			int count = -1;
			return GetByScTchngDayId(transactionManager, _scTchngDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_SC_TCHNG_DAY key.
		///		FK_CTR_MENU_ACT_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId">يوم التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByScTchngDayId(TransactionManager transactionManager, System.Decimal? _scTchngDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngDayId(transactionManager, _scTchngDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_SC_TCHNG_DAY key.
		///		fkCtrMenuActScTchngDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngDayId">يوم التدريس</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByScTchngDayId(System.Decimal? _scTchngDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScTchngDayId(null, _scTchngDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_SC_TCHNG_DAY key.
		///		fkCtrMenuActScTchngDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngDayId">يوم التدريس</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public TList<CtrMenuAct> GetByScTchngDayId(System.Decimal? _scTchngDayId, int start, int pageLength,out int count)
		{
			return GetByScTchngDayId(null, _scTchngDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_SC_TCHNG_DAY key.
		///		FK_CTR_MENU_ACT_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId">يوم التدريس</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuAct objects.</returns>
		public abstract TList<CtrMenuAct> GetByScTchngDayId(TransactionManager transactionManager, System.Decimal? _scTchngDayId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrMenuAct Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuActKey key, int start, int pageLength)
		{
			return GetByCtrMenuActId(transactionManager, key.CtrMenuActId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuAct GetByCtrMenuActId(System.Decimal _ctrMenuActId)
		{
			int count = -1;
			return GetByCtrMenuActId(null,_ctrMenuActId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuAct GetByCtrMenuActId(System.Decimal _ctrMenuActId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuActId(null, _ctrMenuActId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuAct GetByCtrMenuActId(TransactionManager transactionManager, System.Decimal _ctrMenuActId)
		{
			int count = -1;
			return GetByCtrMenuActId(transactionManager, _ctrMenuActId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuAct GetByCtrMenuActId(TransactionManager transactionManager, System.Decimal _ctrMenuActId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuActId(transactionManager, _ctrMenuActId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuAct GetByCtrMenuActId(System.Decimal _ctrMenuActId, int start, int pageLength, out int count)
		{
			return GetByCtrMenuActId(null, _ctrMenuActId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrMenuAct GetByCtrMenuActId(TransactionManager transactionManager, System.Decimal _ctrMenuActId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrMenuAct&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrMenuAct&gt;"/></returns>
		public static TList<CtrMenuAct> Fill(IDataReader reader, TList<CtrMenuAct> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrMenuAct c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrMenuAct")
					.Append("|").Append((System.Decimal)reader["CTR_MENU_ACT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrMenuAct>(
					key.ToString(), // EntityTrackingKey
					"CtrMenuAct",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrMenuAct();
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
					c.CtrMenuActId = (System.Decimal)reader["CTR_MENU_ACT_ID"];
					c.OriginalCtrMenuActId = c.CtrMenuActId;
					c.PlanDt = (System.DateTime)reader["PLAN_DT"];
					c.CtrCdeMealId = (System.Decimal)reader["CTR_CDE_MEAL_ID"];
					c.CtrMenuId = Convert.IsDBNull(reader["CTR_MENU_ID"]) ? null : (System.Decimal?)reader["CTR_MENU_ID"];
					c.StudCount = (System.Decimal)reader["STUD_COUNT"];
					c.StudOutCount = (System.Decimal)reader["STUD_OUT_COUNT"];
					c.StudExpCount = (System.Decimal)reader["STUD_EXP_COUNT"];
					c.ExtMealCount = (System.Decimal)reader["EXT_MEAL_COUNT"];
					c.ScTchngDayId = Convert.IsDBNull(reader["SC_TCHNG_DAY_ID"]) ? null : (System.Decimal?)reader["SC_TCHNG_DAY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrMenuAct entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrMenuActId = (System.Decimal)reader[((int)CtrMenuActColumn.CtrMenuActId - 1)];
			entity.OriginalCtrMenuActId = (System.Decimal)reader["CTR_MENU_ACT_ID"];
			entity.PlanDt = (System.DateTime)reader[((int)CtrMenuActColumn.PlanDt - 1)];
			entity.CtrCdeMealId = (System.Decimal)reader[((int)CtrMenuActColumn.CtrCdeMealId - 1)];
			entity.CtrMenuId = (reader.IsDBNull(((int)CtrMenuActColumn.CtrMenuId - 1)))?null:(System.Decimal?)reader[((int)CtrMenuActColumn.CtrMenuId - 1)];
			entity.StudCount = (System.Decimal)reader[((int)CtrMenuActColumn.StudCount - 1)];
			entity.StudOutCount = (System.Decimal)reader[((int)CtrMenuActColumn.StudOutCount - 1)];
			entity.StudExpCount = (System.Decimal)reader[((int)CtrMenuActColumn.StudExpCount - 1)];
			entity.ExtMealCount = (System.Decimal)reader[((int)CtrMenuActColumn.ExtMealCount - 1)];
			entity.ScTchngDayId = (reader.IsDBNull(((int)CtrMenuActColumn.ScTchngDayId - 1)))?null:(System.Decimal?)reader[((int)CtrMenuActColumn.ScTchngDayId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrMenuAct entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrMenuActId = (System.Decimal)dataRow["CTR_MENU_ACT_ID"];
			entity.OriginalCtrMenuActId = (System.Decimal)dataRow["CTR_MENU_ACT_ID"];
			entity.PlanDt = (System.DateTime)dataRow["PLAN_DT"];
			entity.CtrCdeMealId = (System.Decimal)dataRow["CTR_CDE_MEAL_ID"];
			entity.CtrMenuId = Convert.IsDBNull(dataRow["CTR_MENU_ID"]) ? null : (System.Decimal?)dataRow["CTR_MENU_ID"];
			entity.StudCount = (System.Decimal)dataRow["STUD_COUNT"];
			entity.StudOutCount = (System.Decimal)dataRow["STUD_OUT_COUNT"];
			entity.StudExpCount = (System.Decimal)dataRow["STUD_EXP_COUNT"];
			entity.ExtMealCount = (System.Decimal)dataRow["EXT_MEAL_COUNT"];
			entity.ScTchngDayId = Convert.IsDBNull(dataRow["SC_TCHNG_DAY_ID"]) ? null : (System.Decimal?)dataRow["SC_TCHNG_DAY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuAct"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuAct Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuAct entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CtrCdeMealIdSource	
			if (CanDeepLoad(entity, "CtrCdeMeal|CtrCdeMealIdSource", deepLoadType, innerList) 
				&& entity.CtrCdeMealIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CtrCdeMealId;
				CtrCdeMeal tmpEntity = EntityManager.LocateEntity<CtrCdeMeal>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrCdeMeal), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrCdeMealIdSource = tmpEntity;
				else
					entity.CtrCdeMealIdSource = DataRepository.CtrCdeMealProvider.GetByCtrCdeMealId(transactionManager, entity.CtrCdeMealId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeMealIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrCdeMealIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrCdeMealProvider.DeepLoad(transactionManager, entity.CtrCdeMealIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrCdeMealIdSource

			#region CtrMenuIdSource	
			if (CanDeepLoad(entity, "CtrMenu|CtrMenuIdSource", deepLoadType, innerList) 
				&& entity.CtrMenuIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CtrMenuId ?? 0.0m);
				CtrMenu tmpEntity = EntityManager.LocateEntity<CtrMenu>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrMenu), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrMenuIdSource = tmpEntity;
				else
					entity.CtrMenuIdSource = DataRepository.CtrMenuProvider.GetByCtrMenuId(transactionManager, (entity.CtrMenuId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrMenuIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrMenuProvider.DeepLoad(transactionManager, entity.CtrMenuIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrMenuIdSource

			#region ScTchngDayIdSource	
			if (CanDeepLoad(entity, "ScTchngDay|ScTchngDayIdSource", deepLoadType, innerList) 
				&& entity.ScTchngDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScTchngDayId ?? 0.0m);
				ScTchngDay tmpEntity = EntityManager.LocateEntity<ScTchngDay>(EntityLocator.ConstructKeyFromPkItems(typeof(ScTchngDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScTchngDayIdSource = tmpEntity;
				else
					entity.ScTchngDayIdSource = DataRepository.ScTchngDayProvider.GetByScTchngDayId(transactionManager, (entity.ScTchngDayId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScTchngDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScTchngDayProvider.DeepLoad(transactionManager, entity.ScTchngDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScTchngDayIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrMenuActId methods when available
			
			#region CtrMenuActItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenuActItem>|CtrMenuActItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuActItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuActItemCollection = DataRepository.CtrMenuActItemProvider.GetByCtrMenuActId(transactionManager, entity.CtrMenuActId);

				if (deep && entity.CtrMenuActItemCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuActItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenuActItem>) DataRepository.CtrMenuActItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuActItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrMenuAct object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrMenuAct instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuAct Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuAct entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CtrCdeMealIdSource
			if (CanDeepSave(entity, "CtrCdeMeal|CtrCdeMealIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeMealIdSource != null)
			{
				DataRepository.CtrCdeMealProvider.Save(transactionManager, entity.CtrCdeMealIdSource);
				entity.CtrCdeMealId = entity.CtrCdeMealIdSource.CtrCdeMealId;
			}
			#endregion 
			
			#region CtrMenuIdSource
			if (CanDeepSave(entity, "CtrMenu|CtrMenuIdSource", deepSaveType, innerList) 
				&& entity.CtrMenuIdSource != null)
			{
				DataRepository.CtrMenuProvider.Save(transactionManager, entity.CtrMenuIdSource);
				entity.CtrMenuId = entity.CtrMenuIdSource.CtrMenuId;
			}
			#endregion 
			
			#region ScTchngDayIdSource
			if (CanDeepSave(entity, "ScTchngDay|ScTchngDayIdSource", deepSaveType, innerList) 
				&& entity.ScTchngDayIdSource != null)
			{
				DataRepository.ScTchngDayProvider.Save(transactionManager, entity.ScTchngDayIdSource);
				entity.ScTchngDayId = entity.ScTchngDayIdSource.ScTchngDayId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CtrMenuActItem>
				if (CanDeepSave(entity.CtrMenuActItemCollection, "List<CtrMenuActItem>|CtrMenuActItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenuActItem child in entity.CtrMenuActItemCollection)
					{
						if(child.CtrMenuActIdSource != null)
						{
							child.CtrMenuActId = child.CtrMenuActIdSource.CtrMenuActId;
						}
						else
						{
							child.CtrMenuActId = entity.CtrMenuActId;
						}

					}

					if (entity.CtrMenuActItemCollection.Count > 0 || entity.CtrMenuActItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuActItemProvider.Save(transactionManager, entity.CtrMenuActItemCollection);
						
						deepHandles.Add("CtrMenuActItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenuActItem >) DataRepository.CtrMenuActItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuActItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrMenuActChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrMenuAct</c>
	///</summary>
	public enum CtrMenuActChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CtrCdeMeal</c> at CtrCdeMealIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeMeal))]
		CtrCdeMeal,
		
		///<summary>
		/// Composite Property for <c>CtrMenu</c> at CtrMenuIdSource
		///</summary>
		[ChildEntityType(typeof(CtrMenu))]
		CtrMenu,
		
		///<summary>
		/// Composite Property for <c>ScTchngDay</c> at ScTchngDayIdSource
		///</summary>
		[ChildEntityType(typeof(ScTchngDay))]
		ScTchngDay,
		///<summary>
		/// Collection of <c>CtrMenuAct</c> as OneToMany for CtrMenuActItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenuActItem>))]
		CtrMenuActItemCollection,
	}
	
	#endregion CtrMenuActChildEntityTypes
	
	#region CtrMenuActFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrMenuActColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuActFilterBuilder : SqlFilterBuilder<CtrMenuActColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuActFilterBuilder class.
		/// </summary>
		public CtrMenuActFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuActFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuActFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuActFilterBuilder
	
	#region CtrMenuActParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrMenuActColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuActParameterBuilder : ParameterizedSqlFilterBuilder<CtrMenuActColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuActParameterBuilder class.
		/// </summary>
		public CtrMenuActParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuActParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuActParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuActParameterBuilder
	
	#region CtrMenuActSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrMenuActColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuAct"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrMenuActSortBuilder : SqlSortBuilder<CtrMenuActColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuActSqlSortBuilder class.
		/// </summary>
		public CtrMenuActSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrMenuActSortBuilder
	
} // end namespace
