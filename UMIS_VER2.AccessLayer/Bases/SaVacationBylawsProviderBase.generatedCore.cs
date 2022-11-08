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
	/// This class is the base class for any <see cref="SaVacationBylawsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaVacationBylawsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaVacationBylaws, UMIS_VER2.BusinessLyer.SaVacationBylawsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBylawsKey key)
		{
			return Delete(transactionManager, key.SaVacationBylawsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saVacationBylawsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saVacationBylawsId)
		{
			return Delete(null, _saVacationBylawsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saVacationBylawsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0537 key.
		///		FK_AUTO_0537 Description: 
		/// </summary>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBylaws objects.</returns>
		public TList<SaVacationBylaws> GetBySaCodeVacationTypeId(System.Decimal _saCodeVacationTypeId)
		{
			int count = -1;
			return GetBySaCodeVacationTypeId(_saCodeVacationTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0537 key.
		///		FK_AUTO_0537 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBylaws objects.</returns>
		/// <remarks></remarks>
		public TList<SaVacationBylaws> GetBySaCodeVacationTypeId(TransactionManager transactionManager, System.Decimal _saCodeVacationTypeId)
		{
			int count = -1;
			return GetBySaCodeVacationTypeId(transactionManager, _saCodeVacationTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0537 key.
		///		FK_AUTO_0537 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBylaws objects.</returns>
		public TList<SaVacationBylaws> GetBySaCodeVacationTypeId(TransactionManager transactionManager, System.Decimal _saCodeVacationTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeVacationTypeId(transactionManager, _saCodeVacationTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0537 key.
		///		fkAuto0537 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBylaws objects.</returns>
		public TList<SaVacationBylaws> GetBySaCodeVacationTypeId(System.Decimal _saCodeVacationTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeVacationTypeId(null, _saCodeVacationTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0537 key.
		///		fkAuto0537 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBylaws objects.</returns>
		public TList<SaVacationBylaws> GetBySaCodeVacationTypeId(System.Decimal _saCodeVacationTypeId, int start, int pageLength,out int count)
		{
			return GetBySaCodeVacationTypeId(null, _saCodeVacationTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0537 key.
		///		FK_AUTO_0537 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeVacationTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaVacationBylaws objects.</returns>
		public abstract TList<SaVacationBylaws> GetBySaCodeVacationTypeId(TransactionManager transactionManager, System.Decimal _saCodeVacationTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaVacationBylaws Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBylawsKey key, int start, int pageLength)
		{
			return GetBySaVacationBylawsId(transactionManager, key.SaVacationBylawsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_VACATION_BYLAWS index.
		/// </summary>
		/// <param name="_saVacationBylawsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBylaws GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId)
		{
			int count = -1;
			return GetBySaVacationBylawsId(null,_saVacationBylawsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BYLAWS index.
		/// </summary>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBylaws GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBylawsId(null, _saVacationBylawsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BYLAWS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBylaws GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId)
		{
			int count = -1;
			return GetBySaVacationBylawsId(transactionManager, _saVacationBylawsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BYLAWS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBylaws GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaVacationBylawsId(transactionManager, _saVacationBylawsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BYLAWS index.
		/// </summary>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaVacationBylaws GetBySaVacationBylawsId(System.Decimal _saVacationBylawsId, int start, int pageLength, out int count)
		{
			return GetBySaVacationBylawsId(null, _saVacationBylawsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_VACATION_BYLAWS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saVacationBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaVacationBylaws GetBySaVacationBylawsId(TransactionManager transactionManager, System.Decimal _saVacationBylawsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaVacationBylaws&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaVacationBylaws&gt;"/></returns>
		public static TList<SaVacationBylaws> Fill(IDataReader reader, TList<SaVacationBylaws> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaVacationBylaws c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaVacationBylaws")
					.Append("|").Append((System.Decimal)reader["SA_VACATION_BYLAWS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaVacationBylaws>(
					key.ToString(), // EntityTrackingKey
					"SaVacationBylaws",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaVacationBylaws();
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
					c.SaVacationBylawsId = (System.Decimal)reader["SA_VACATION_BYLAWS_ID"];
					c.OriginalSaVacationBylawsId = c.SaVacationBylawsId;
					c.VacationName = (System.String)reader["VACATION_NAME"];
					c.MaxNum = Convert.IsDBNull(reader["MAX_NUM"]) ? null : (System.Decimal?)reader["MAX_NUM"];
					c.MaxDays = Convert.IsDBNull(reader["MAX_DAYS"]) ? null : (System.Decimal?)reader["MAX_DAYS"];
					c.MaxDuration = Convert.IsDBNull(reader["MAX_DURATION"]) ? null : (System.Decimal?)reader["MAX_DURATION"];
					c.CalcPeriod = Convert.IsDBNull(reader["CALC_PERIOD"]) ? null : (System.Decimal?)reader["CALC_PERIOD"];
					c.IsassistingStaff = (System.Decimal)reader["ISASSISTING_STAFF"];
					c.IsTeachingStaff = (System.Decimal)reader["IS_TEACHING_STAFF"];
					c.HasDecision = (System.Decimal)reader["HAS_DECISION"];
					c.IsForWomen = (System.Decimal)reader["IS_FOR_WOMEN"];
					c.IsDuringAcademicYear = (System.Decimal)reader["IS_DURING_ACADEMIC_YEAR"];
					c.HasBalace = (System.Decimal)reader["HAS_BALACE"];
					c.AccBalance = (System.Decimal)reader["ACC_BALANCE"];
					c.CalcOnPeriod = (System.Decimal)reader["CALC_ON_PERIOD"];
					c.HasJobStartDecision = (System.Decimal)reader["HAS_JOB_START_DECISION"];
					c.SaCodeVacationTypeId = (System.Decimal)reader["SA_CODE_VACATION_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaVacationBylaws entity)
		{
			if (!reader.Read()) return;
			
			entity.SaVacationBylawsId = (System.Decimal)reader[((int)SaVacationBylawsColumn.SaVacationBylawsId - 1)];
			entity.OriginalSaVacationBylawsId = (System.Decimal)reader["SA_VACATION_BYLAWS_ID"];
			entity.VacationName = (System.String)reader[((int)SaVacationBylawsColumn.VacationName - 1)];
			entity.MaxNum = (reader.IsDBNull(((int)SaVacationBylawsColumn.MaxNum - 1)))?null:(System.Decimal?)reader[((int)SaVacationBylawsColumn.MaxNum - 1)];
			entity.MaxDays = (reader.IsDBNull(((int)SaVacationBylawsColumn.MaxDays - 1)))?null:(System.Decimal?)reader[((int)SaVacationBylawsColumn.MaxDays - 1)];
			entity.MaxDuration = (reader.IsDBNull(((int)SaVacationBylawsColumn.MaxDuration - 1)))?null:(System.Decimal?)reader[((int)SaVacationBylawsColumn.MaxDuration - 1)];
			entity.CalcPeriod = (reader.IsDBNull(((int)SaVacationBylawsColumn.CalcPeriod - 1)))?null:(System.Decimal?)reader[((int)SaVacationBylawsColumn.CalcPeriod - 1)];
			entity.IsassistingStaff = (System.Decimal)reader[((int)SaVacationBylawsColumn.IsassistingStaff - 1)];
			entity.IsTeachingStaff = (System.Decimal)reader[((int)SaVacationBylawsColumn.IsTeachingStaff - 1)];
			entity.HasDecision = (System.Decimal)reader[((int)SaVacationBylawsColumn.HasDecision - 1)];
			entity.IsForWomen = (System.Decimal)reader[((int)SaVacationBylawsColumn.IsForWomen - 1)];
			entity.IsDuringAcademicYear = (System.Decimal)reader[((int)SaVacationBylawsColumn.IsDuringAcademicYear - 1)];
			entity.HasBalace = (System.Decimal)reader[((int)SaVacationBylawsColumn.HasBalace - 1)];
			entity.AccBalance = (System.Decimal)reader[((int)SaVacationBylawsColumn.AccBalance - 1)];
			entity.CalcOnPeriod = (System.Decimal)reader[((int)SaVacationBylawsColumn.CalcOnPeriod - 1)];
			entity.HasJobStartDecision = (System.Decimal)reader[((int)SaVacationBylawsColumn.HasJobStartDecision - 1)];
			entity.SaCodeVacationTypeId = (System.Decimal)reader[((int)SaVacationBylawsColumn.SaCodeVacationTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaVacationBylaws entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaVacationBylawsId = (System.Decimal)dataRow["SA_VACATION_BYLAWS_ID"];
			entity.OriginalSaVacationBylawsId = (System.Decimal)dataRow["SA_VACATION_BYLAWS_ID"];
			entity.VacationName = (System.String)dataRow["VACATION_NAME"];
			entity.MaxNum = Convert.IsDBNull(dataRow["MAX_NUM"]) ? null : (System.Decimal?)dataRow["MAX_NUM"];
			entity.MaxDays = Convert.IsDBNull(dataRow["MAX_DAYS"]) ? null : (System.Decimal?)dataRow["MAX_DAYS"];
			entity.MaxDuration = Convert.IsDBNull(dataRow["MAX_DURATION"]) ? null : (System.Decimal?)dataRow["MAX_DURATION"];
			entity.CalcPeriod = Convert.IsDBNull(dataRow["CALC_PERIOD"]) ? null : (System.Decimal?)dataRow["CALC_PERIOD"];
			entity.IsassistingStaff = (System.Decimal)dataRow["ISASSISTING_STAFF"];
			entity.IsTeachingStaff = (System.Decimal)dataRow["IS_TEACHING_STAFF"];
			entity.HasDecision = (System.Decimal)dataRow["HAS_DECISION"];
			entity.IsForWomen = (System.Decimal)dataRow["IS_FOR_WOMEN"];
			entity.IsDuringAcademicYear = (System.Decimal)dataRow["IS_DURING_ACADEMIC_YEAR"];
			entity.HasBalace = (System.Decimal)dataRow["HAS_BALACE"];
			entity.AccBalance = (System.Decimal)dataRow["ACC_BALANCE"];
			entity.CalcOnPeriod = (System.Decimal)dataRow["CALC_ON_PERIOD"];
			entity.HasJobStartDecision = (System.Decimal)dataRow["HAS_JOB_START_DECISION"];
			entity.SaCodeVacationTypeId = (System.Decimal)dataRow["SA_CODE_VACATION_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaVacationBylaws"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationBylaws Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBylaws entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeVacationTypeIdSource	
			if (CanDeepLoad(entity, "SaCodeVacationType|SaCodeVacationTypeIdSource", deepLoadType, innerList) 
				&& entity.SaCodeVacationTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeVacationTypeId;
				SaCodeVacationType tmpEntity = EntityManager.LocateEntity<SaCodeVacationType>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeVacationType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeVacationTypeIdSource = tmpEntity;
				else
					entity.SaCodeVacationTypeIdSource = DataRepository.SaCodeVacationTypeProvider.GetBySaCodeVacationTypeId(transactionManager, entity.SaCodeVacationTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeVacationTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeVacationTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeVacationTypeProvider.DeepLoad(transactionManager, entity.SaCodeVacationTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeVacationTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaVacationBylawsId methods when available
			
			#region SaVacationBalanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationBalance>|SaVacationBalanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBalanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationBalanceCollection = DataRepository.SaVacationBalanceProvider.GetBySaVacationBylowId(transactionManager, entity.SaVacationBylawsId);

				if (deep && entity.SaVacationBalanceCollection.Count > 0)
				{
					deepHandles.Add("SaVacationBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationBalance>) DataRepository.SaVacationBalanceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationBalanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationBalanceHCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationBalanceH>|SaVacationBalanceHCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBalanceHCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationBalanceHCollection = DataRepository.SaVacationBalanceHProvider.GetBySaVacationBylowId(transactionManager, entity.SaVacationBylawsId);

				if (deep && entity.SaVacationBalanceHCollection.Count > 0)
				{
					deepHandles.Add("SaVacationBalanceHCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationBalanceH>) DataRepository.SaVacationBalanceHProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationBalanceHCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacation>|SaVacationCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationCollection = DataRepository.SaVacationProvider.GetBySaVacationBylawsId(transactionManager, entity.SaVacationBylawsId);

				if (deep && entity.SaVacationCollection.Count > 0)
				{
					deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacation>) DataRepository.SaVacationProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationRule>|SaVacationRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationRuleCollection = DataRepository.SaVacationRuleProvider.GetBySaVacationBylawsId(transactionManager, entity.SaVacationBylawsId);

				if (deep && entity.SaVacationRuleCollection.Count > 0)
				{
					deepHandles.Add("SaVacationRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationRule>) DataRepository.SaVacationRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationRuleCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaVacationBylaws object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaVacationBylaws instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaVacationBylaws Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaVacationBylaws entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeVacationTypeIdSource
			if (CanDeepSave(entity, "SaCodeVacationType|SaCodeVacationTypeIdSource", deepSaveType, innerList) 
				&& entity.SaCodeVacationTypeIdSource != null)
			{
				DataRepository.SaCodeVacationTypeProvider.Save(transactionManager, entity.SaCodeVacationTypeIdSource);
				entity.SaCodeVacationTypeId = entity.SaCodeVacationTypeIdSource.SaCodeVacationTypeId;
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
						if(child.SaVacationBylowIdSource != null)
						{
							child.SaVacationBylowId = child.SaVacationBylowIdSource.SaVacationBylawsId;
						}
						else
						{
							child.SaVacationBylowId = entity.SaVacationBylawsId;
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
				
	
			#region List<SaVacationBalanceH>
				if (CanDeepSave(entity.SaVacationBalanceHCollection, "List<SaVacationBalanceH>|SaVacationBalanceHCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationBalanceH child in entity.SaVacationBalanceHCollection)
					{
						if(child.SaVacationBylowIdSource != null)
						{
							child.SaVacationBylowId = child.SaVacationBylowIdSource.SaVacationBylawsId;
						}
						else
						{
							child.SaVacationBylowId = entity.SaVacationBylawsId;
						}

					}

					if (entity.SaVacationBalanceHCollection.Count > 0 || entity.SaVacationBalanceHCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationBalanceHProvider.Save(transactionManager, entity.SaVacationBalanceHCollection);
						
						deepHandles.Add("SaVacationBalanceHCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationBalanceH >) DataRepository.SaVacationBalanceHProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationBalanceHCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacation>
				if (CanDeepSave(entity.SaVacationCollection, "List<SaVacation>|SaVacationCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacation child in entity.SaVacationCollection)
					{
						if(child.SaVacationBylawsIdSource != null)
						{
							child.SaVacationBylawsId = child.SaVacationBylawsIdSource.SaVacationBylawsId;
						}
						else
						{
							child.SaVacationBylawsId = entity.SaVacationBylawsId;
						}

					}

					if (entity.SaVacationCollection.Count > 0 || entity.SaVacationCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationProvider.Save(transactionManager, entity.SaVacationCollection);
						
						deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacation >) DataRepository.SaVacationProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacationRule>
				if (CanDeepSave(entity.SaVacationRuleCollection, "List<SaVacationRule>|SaVacationRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationRule child in entity.SaVacationRuleCollection)
					{
						if(child.SaVacationBylawsIdSource != null)
						{
							child.SaVacationBylawsId = child.SaVacationBylawsIdSource.SaVacationBylawsId;
						}
						else
						{
							child.SaVacationBylawsId = entity.SaVacationBylawsId;
						}

					}

					if (entity.SaVacationRuleCollection.Count > 0 || entity.SaVacationRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationRuleProvider.Save(transactionManager, entity.SaVacationRuleCollection);
						
						deepHandles.Add("SaVacationRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationRule >) DataRepository.SaVacationRuleProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationRuleCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaVacationBylawsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaVacationBylaws</c>
	///</summary>
	public enum SaVacationBylawsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeVacationType</c> at SaCodeVacationTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeVacationType))]
		SaCodeVacationType,
		///<summary>
		/// Collection of <c>SaVacationBylaws</c> as OneToMany for SaVacationBalanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationBalance>))]
		SaVacationBalanceCollection,
		///<summary>
		/// Collection of <c>SaVacationBylaws</c> as OneToMany for SaVacationBalanceHCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationBalanceH>))]
		SaVacationBalanceHCollection,
		///<summary>
		/// Collection of <c>SaVacationBylaws</c> as OneToMany for SaVacationCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacation>))]
		SaVacationCollection,
		///<summary>
		/// Collection of <c>SaVacationBylaws</c> as OneToMany for SaVacationRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationRule>))]
		SaVacationRuleCollection,
	}
	
	#endregion SaVacationBylawsChildEntityTypes
	
	#region SaVacationBylawsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaVacationBylawsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBylaws"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationBylawsFilterBuilder : SqlFilterBuilder<SaVacationBylawsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBylawsFilterBuilder class.
		/// </summary>
		public SaVacationBylawsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBylawsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationBylawsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBylawsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationBylawsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationBylawsFilterBuilder
	
	#region SaVacationBylawsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaVacationBylawsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBylaws"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaVacationBylawsParameterBuilder : ParameterizedSqlFilterBuilder<SaVacationBylawsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBylawsParameterBuilder class.
		/// </summary>
		public SaVacationBylawsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBylawsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaVacationBylawsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaVacationBylawsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaVacationBylawsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaVacationBylawsParameterBuilder
	
	#region SaVacationBylawsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaVacationBylawsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaVacationBylaws"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaVacationBylawsSortBuilder : SqlSortBuilder<SaVacationBylawsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaVacationBylawsSqlSortBuilder class.
		/// </summary>
		public SaVacationBylawsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaVacationBylawsSortBuilder
	
} // end namespace
