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
	/// This class is the base class for any <see cref="ScTchngDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScTchngDayProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScTchngDay, UMIS_VER2.BusinessLyer.ScTchngDayKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngDayKey key)
		{
			return Delete(transactionManager, key.ScTchngDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scTchngDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scTchngDayId)
		{
			return Delete(null, _scTchngDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scTchngDayId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(_gsCodeWeekDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScTchngDay> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY key.
		///		fkScTchngDayGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY key.
		///		fkScTchngDayGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength,out int count)
		{
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_TCHNG_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public abstract TList<ScTchngDay> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="_scSchdlPeriodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(_scSchdlPeriodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScTchngDay> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchdlPeriodId(transactionManager, _scSchdlPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD key.
		///		fkScTchngDayScSchdlPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlPeriodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD key.
		///		fkScTchngDayScSchdlPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSchdlPeriodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public TList<ScTchngDay> GetByScSchdlPeriodId(System.Decimal? _scSchdlPeriodId, int start, int pageLength,out int count)
		{
			return GetByScSchdlPeriodId(null, _scSchdlPeriodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD key.
		///		FK_SC_TCHNG_DAY_SC_SCHDL_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchdlPeriodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScTchngDay objects.</returns>
		public abstract TList<ScTchngDay> GetByScSchdlPeriodId(TransactionManager transactionManager, System.Decimal? _scSchdlPeriodId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScTchngDay Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngDayKey key, int start, int pageLength)
		{
			return GetByScTchngDayId(transactionManager, key.ScTchngDayId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_TCHNG_DAY index.
		/// </summary>
		/// <param name="_scTchngDayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngDay GetByScTchngDayId(System.Decimal _scTchngDayId)
		{
			int count = -1;
			return GetByScTchngDayId(null,_scTchngDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_DAY index.
		/// </summary>
		/// <param name="_scTchngDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngDay GetByScTchngDayId(System.Decimal _scTchngDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngDayId(null, _scTchngDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngDay GetByScTchngDayId(TransactionManager transactionManager, System.Decimal _scTchngDayId)
		{
			int count = -1;
			return GetByScTchngDayId(transactionManager, _scTchngDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngDay GetByScTchngDayId(TransactionManager transactionManager, System.Decimal _scTchngDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngDayId(transactionManager, _scTchngDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_DAY index.
		/// </summary>
		/// <param name="_scTchngDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScTchngDay GetByScTchngDayId(System.Decimal _scTchngDayId, int start, int pageLength, out int count)
		{
			return GetByScTchngDayId(null, _scTchngDayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_TCHNG_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScTchngDay GetByScTchngDayId(TransactionManager transactionManager, System.Decimal _scTchngDayId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScTchngDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScTchngDay&gt;"/></returns>
		public static TList<ScTchngDay> Fill(IDataReader reader, TList<ScTchngDay> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScTchngDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScTchngDay")
					.Append("|").Append((System.Decimal)reader["SC_TCHNG_DAY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScTchngDay>(
					key.ToString(), // EntityTrackingKey
					"ScTchngDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScTchngDay();
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
					c.ScTchngDayId = (System.Decimal)reader["SC_TCHNG_DAY_ID"];
					c.OriginalScTchngDayId = c.ScTchngDayId;
					c.GsCodeWeekDayId = (System.Decimal)reader["GS_CODE_WEEK_DAY_ID"];
					c.DayAr = (System.String)reader["DAY_AR"];
					c.DayEn = (System.String)reader["DAY_EN"];
					c.DaySrl = Convert.IsDBNull(reader["DAY_SRL"]) ? null : (System.Decimal?)reader["DAY_SRL"];
					c.ScSchdlPeriodId = Convert.IsDBNull(reader["SC_SCHDL_PERIOD_ID"]) ? null : (System.Decimal?)reader["SC_SCHDL_PERIOD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScTchngDay entity)
		{
			if (!reader.Read()) return;
			
			entity.ScTchngDayId = (System.Decimal)reader[((int)ScTchngDayColumn.ScTchngDayId - 1)];
			entity.OriginalScTchngDayId = (System.Decimal)reader["SC_TCHNG_DAY_ID"];
			entity.GsCodeWeekDayId = (System.Decimal)reader[((int)ScTchngDayColumn.GsCodeWeekDayId - 1)];
			entity.DayAr = (System.String)reader[((int)ScTchngDayColumn.DayAr - 1)];
			entity.DayEn = (System.String)reader[((int)ScTchngDayColumn.DayEn - 1)];
			entity.DaySrl = (reader.IsDBNull(((int)ScTchngDayColumn.DaySrl - 1)))?null:(System.Decimal?)reader[((int)ScTchngDayColumn.DaySrl - 1)];
			entity.ScSchdlPeriodId = (reader.IsDBNull(((int)ScTchngDayColumn.ScSchdlPeriodId - 1)))?null:(System.Decimal?)reader[((int)ScTchngDayColumn.ScSchdlPeriodId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScTchngDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScTchngDayId = (System.Decimal)dataRow["SC_TCHNG_DAY_ID"];
			entity.OriginalScTchngDayId = (System.Decimal)dataRow["SC_TCHNG_DAY_ID"];
			entity.GsCodeWeekDayId = (System.Decimal)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.DayAr = (System.String)dataRow["DAY_AR"];
			entity.DayEn = (System.String)dataRow["DAY_EN"];
			entity.DaySrl = Convert.IsDBNull(dataRow["DAY_SRL"]) ? null : (System.Decimal?)dataRow["DAY_SRL"];
			entity.ScSchdlPeriodId = Convert.IsDBNull(dataRow["SC_SCHDL_PERIOD_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHDL_PERIOD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScTchngDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScTchngDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeWeekDayIdSource	
			if (CanDeepLoad(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepLoadType, innerList) 
				&& entity.GsCodeWeekDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeWeekDayId;
				GsCodeWeekDay tmpEntity = EntityManager.LocateEntity<GsCodeWeekDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeWeekDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeWeekDayIdSource = tmpEntity;
				else
					entity.GsCodeWeekDayIdSource = DataRepository.GsCodeWeekDayProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeWeekDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeWeekDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeWeekDayProvider.DeepLoad(transactionManager, entity.GsCodeWeekDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeWeekDayIdSource

			#region ScSchdlPeriodIdSource	
			if (CanDeepLoad(entity, "ScSchdlPeriod|ScSchdlPeriodIdSource", deepLoadType, innerList) 
				&& entity.ScSchdlPeriodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScSchdlPeriodId ?? 0.0m);
				ScSchdlPeriod tmpEntity = EntityManager.LocateEntity<ScSchdlPeriod>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSchdlPeriod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSchdlPeriodIdSource = tmpEntity;
				else
					entity.ScSchdlPeriodIdSource = DataRepository.ScSchdlPeriodProvider.GetByScSchdlPeriodId(transactionManager, (entity.ScSchdlPeriodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlPeriodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSchdlPeriodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSchdlPeriodProvider.DeepLoad(transactionManager, entity.ScSchdlPeriodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSchdlPeriodIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScTchngDayId methods when available
			
			#region ScGroupDayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupDay>|ScGroupDayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupDayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupDayCollection = DataRepository.ScGroupDayProvider.GetByScTchngDayId(transactionManager, entity.ScTchngDayId);

				if (deep && entity.ScGroupDayCollection.Count > 0)
				{
					deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupDay>) DataRepository.ScGroupDayProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupDayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrMenuActCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenuAct>|CtrMenuActCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuActCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuActCollection = DataRepository.CtrMenuActProvider.GetByScTchngDayId(transactionManager, entity.ScTchngDayId);

				if (deep && entity.CtrMenuActCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuActCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenuAct>) DataRepository.CtrMenuActProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuActCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScTchngDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScTchngDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScTchngDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScTchngDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeWeekDayIdSource
			if (CanDeepSave(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepSaveType, innerList) 
				&& entity.GsCodeWeekDayIdSource != null)
			{
				DataRepository.GsCodeWeekDayProvider.Save(transactionManager, entity.GsCodeWeekDayIdSource);
				entity.GsCodeWeekDayId = entity.GsCodeWeekDayIdSource.GsCodeWeekDayId;
			}
			#endregion 
			
			#region ScSchdlPeriodIdSource
			if (CanDeepSave(entity, "ScSchdlPeriod|ScSchdlPeriodIdSource", deepSaveType, innerList) 
				&& entity.ScSchdlPeriodIdSource != null)
			{
				DataRepository.ScSchdlPeriodProvider.Save(transactionManager, entity.ScSchdlPeriodIdSource);
				entity.ScSchdlPeriodId = entity.ScSchdlPeriodIdSource.ScSchdlPeriodId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScGroupDay>
				if (CanDeepSave(entity.ScGroupDayCollection, "List<ScGroupDay>|ScGroupDayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupDay child in entity.ScGroupDayCollection)
					{
						if(child.ScTchngDayIdSource != null)
						{
							child.ScTchngDayId = child.ScTchngDayIdSource.ScTchngDayId;
						}
						else
						{
							child.ScTchngDayId = entity.ScTchngDayId;
						}

					}

					if (entity.ScGroupDayCollection.Count > 0 || entity.ScGroupDayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupDayProvider.Save(transactionManager, entity.ScGroupDayCollection);
						
						deepHandles.Add("ScGroupDayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupDay >) DataRepository.ScGroupDayProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupDayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrMenuAct>
				if (CanDeepSave(entity.CtrMenuActCollection, "List<CtrMenuAct>|CtrMenuActCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenuAct child in entity.CtrMenuActCollection)
					{
						if(child.ScTchngDayIdSource != null)
						{
							child.ScTchngDayId = child.ScTchngDayIdSource.ScTchngDayId;
						}
						else
						{
							child.ScTchngDayId = entity.ScTchngDayId;
						}

					}

					if (entity.CtrMenuActCollection.Count > 0 || entity.CtrMenuActCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuActProvider.Save(transactionManager, entity.CtrMenuActCollection);
						
						deepHandles.Add("CtrMenuActCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenuAct >) DataRepository.CtrMenuActProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuActCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScTchngDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScTchngDay</c>
	///</summary>
	public enum ScTchngDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeWeekDay</c> at GsCodeWeekDayIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeWeekDay))]
		GsCodeWeekDay,
		
		///<summary>
		/// Composite Property for <c>ScSchdlPeriod</c> at ScSchdlPeriodIdSource
		///</summary>
		[ChildEntityType(typeof(ScSchdlPeriod))]
		ScSchdlPeriod,
		///<summary>
		/// Collection of <c>ScTchngDay</c> as OneToMany for ScGroupDayCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupDay>))]
		ScGroupDayCollection,
		///<summary>
		/// Collection of <c>ScTchngDay</c> as OneToMany for CtrMenuActCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenuAct>))]
		CtrMenuActCollection,
	}
	
	#endregion ScTchngDayChildEntityTypes
	
	#region ScTchngDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScTchngDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScTchngDayFilterBuilder : SqlFilterBuilder<ScTchngDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngDayFilterBuilder class.
		/// </summary>
		public ScTchngDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScTchngDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScTchngDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScTchngDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScTchngDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScTchngDayFilterBuilder
	
	#region ScTchngDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScTchngDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScTchngDayParameterBuilder : ParameterizedSqlFilterBuilder<ScTchngDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngDayParameterBuilder class.
		/// </summary>
		public ScTchngDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScTchngDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScTchngDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScTchngDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScTchngDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScTchngDayParameterBuilder
	
	#region ScTchngDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScTchngDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScTchngDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScTchngDaySortBuilder : SqlSortBuilder<ScTchngDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScTchngDaySqlSortBuilder class.
		/// </summary>
		public ScTchngDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScTchngDaySortBuilder
	
} // end namespace
