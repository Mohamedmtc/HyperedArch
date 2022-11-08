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
	/// This class is the base class for any <see cref="PgThesisCommProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisCommProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisComm, UMIS_VER2.BusinessLyer.PgThesisCommKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommKey key)
		{
			return Delete(transactionManager, key.PgThesisCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisCommId)
		{
			return Delete(null, _pgThesisCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisCommId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisComm objects.</returns>
		public TList<PgThesisComm> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisComm objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisComm> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisComm objects.</returns>
		public TList<PgThesisComm> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_PG_THESIS_STUD key.
		///		fkPgThesisCommPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisComm objects.</returns>
		public TList<PgThesisComm> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_PG_THESIS_STUD key.
		///		fkPgThesisCommPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisComm objects.</returns>
		public TList<PgThesisComm> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">بيانات الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisComm objects.</returns>
		public abstract TList<PgThesisComm> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisComm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisCommKey key, int start, int pageLength)
		{
			return GetByPgThesisCommId(transactionManager, key.PgThesisCommId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_COMM index.
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisComm GetByPgThesisCommId(System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(null,_pgThesisCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM index.
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisComm GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisComm GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisComm GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisCommId(transactionManager, _pgThesisCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM index.
		/// </summary>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisComm GetByPgThesisCommId(System.Decimal _pgThesisCommId, int start, int pageLength, out int count)
		{
			return GetByPgThesisCommId(null, _pgThesisCommId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisCommId">تشكيل لجنة المناقشة والتحكيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisComm GetByPgThesisCommId(TransactionManager transactionManager, System.Decimal _pgThesisCommId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisComm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisComm&gt;"/></returns>
		public static TList<PgThesisComm> Fill(IDataReader reader, TList<PgThesisComm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisComm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisComm")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_COMM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisComm>(
					key.ToString(), // EntityTrackingKey
					"PgThesisComm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisComm();
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
					c.PgThesisCommId = (System.Decimal)reader["PG_THESIS_COMM_ID"];
					c.OriginalPgThesisCommId = c.PgThesisCommId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.CommStartDate = Convert.IsDBNull(reader["COMM_START_DATE"]) ? null : (System.DateTime?)reader["COMM_START_DATE"];
					c.CommEndDate = Convert.IsDBNull(reader["COMM_END_DATE"]) ? null : (System.DateTime?)reader["COMM_END_DATE"];
					c.CommNum = Convert.IsDBNull(reader["COMM_NUM"]) ? null : (System.Int32?)reader["COMM_NUM"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.IsLast = (System.Boolean)reader["IS_LAST"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisComm entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisCommId = (System.Decimal)reader[((int)PgThesisCommColumn.PgThesisCommId - 1)];
			entity.OriginalPgThesisCommId = (System.Decimal)reader["PG_THESIS_COMM_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisCommColumn.PgThesisStudId - 1)];
			entity.CommStartDate = (reader.IsDBNull(((int)PgThesisCommColumn.CommStartDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommColumn.CommStartDate - 1)];
			entity.CommEndDate = (reader.IsDBNull(((int)PgThesisCommColumn.CommEndDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommColumn.CommEndDate - 1)];
			entity.CommNum = (reader.IsDBNull(((int)PgThesisCommColumn.CommNum - 1)))?null:(System.Int32?)reader[((int)PgThesisCommColumn.CommNum - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisCommColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisCommColumn.Notes - 1)];
			entity.IsLast = (System.Boolean)reader[((int)PgThesisCommColumn.IsLast - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisCommColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisCommColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisCommColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisCommColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisComm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisCommId = (System.Decimal)dataRow["PG_THESIS_COMM_ID"];
			entity.OriginalPgThesisCommId = (System.Decimal)dataRow["PG_THESIS_COMM_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.CommStartDate = Convert.IsDBNull(dataRow["COMM_START_DATE"]) ? null : (System.DateTime?)dataRow["COMM_START_DATE"];
			entity.CommEndDate = Convert.IsDBNull(dataRow["COMM_END_DATE"]) ? null : (System.DateTime?)dataRow["COMM_END_DATE"];
			entity.CommNum = Convert.IsDBNull(dataRow["COMM_NUM"]) ? null : (System.Int32?)dataRow["COMM_NUM"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.IsLast = (System.Boolean)dataRow["IS_LAST"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisComm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisComm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisComm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region PgThesisStudIdSource	
			if (CanDeepLoad(entity, "PgThesisStud|PgThesisStudIdSource", deepLoadType, innerList) 
				&& entity.PgThesisStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.PgThesisStudId;
				PgThesisStud tmpEntity = EntityManager.LocateEntity<PgThesisStud>(EntityLocator.ConstructKeyFromPkItems(typeof(PgThesisStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.PgThesisStudIdSource = tmpEntity;
				else
					entity.PgThesisStudIdSource = DataRepository.PgThesisStudProvider.GetByPgThesisStudId(transactionManager, entity.PgThesisStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.PgThesisStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.PgThesisStudProvider.DeepLoad(transactionManager, entity.PgThesisStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion PgThesisStudIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisCommId methods when available
			
			#region PgThesisCommRecommendCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommRecommend>|PgThesisCommRecommendCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRecommendCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommRecommendCollection = DataRepository.PgThesisCommRecommendProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);

				if (deep && entity.PgThesisCommRecommendCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommRecommendCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommRecommend>) DataRepository.PgThesisCommRecommendProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommRecommendCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisDiscussionDateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisDiscussionDate>|PgThesisDiscussionDateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisDiscussionDateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisDiscussionDateCollection = DataRepository.PgThesisDiscussionDateProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);

				if (deep && entity.PgThesisDiscussionDateCollection.Count > 0)
				{
					deepHandles.Add("PgThesisDiscussionDateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisDiscussionDate>) DataRepository.PgThesisDiscussionDateProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisDiscussionDateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommMemberCollection = DataRepository.PgThesisCommMemberProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);

				if (deep && entity.PgThesisCommMemberCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommMember>) DataRepository.PgThesisCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommRptCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommRpt>|PgThesisCommRptCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommRptCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommRptCollection = DataRepository.PgThesisCommRptProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);

				if (deep && entity.PgThesisCommRptCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommRptCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommRpt>) DataRepository.PgThesisCommRptProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommRptCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommApprove>|PgThesisCommApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommApproveCollection = DataRepository.PgThesisCommApproveProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);

				if (deep && entity.PgThesisCommApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommApprove>) DataRepository.PgThesisCommApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgAttchdDoc>|PgAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisCommId(transactionManager, entity.PgThesisCommId);

				if (deep && entity.PgAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgAttchdDoc>) DataRepository.PgAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.PgAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisComm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisComm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisComm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisComm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region PgThesisStudIdSource
			if (CanDeepSave(entity, "PgThesisStud|PgThesisStudIdSource", deepSaveType, innerList) 
				&& entity.PgThesisStudIdSource != null)
			{
				DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudIdSource);
				entity.PgThesisStudId = entity.PgThesisStudIdSource.PgThesisStudId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<PgThesisCommRecommend>
				if (CanDeepSave(entity.PgThesisCommRecommendCollection, "List<PgThesisCommRecommend>|PgThesisCommRecommendCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommRecommend child in entity.PgThesisCommRecommendCollection)
					{
						if(child.PgThesisCommIdSource != null)
						{
							child.PgThesisCommId = child.PgThesisCommIdSource.PgThesisCommId;
						}
						else
						{
							child.PgThesisCommId = entity.PgThesisCommId;
						}

					}

					if (entity.PgThesisCommRecommendCollection.Count > 0 || entity.PgThesisCommRecommendCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommRecommendProvider.Save(transactionManager, entity.PgThesisCommRecommendCollection);
						
						deepHandles.Add("PgThesisCommRecommendCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommRecommend >) DataRepository.PgThesisCommRecommendProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommRecommendCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisDiscussionDate>
				if (CanDeepSave(entity.PgThesisDiscussionDateCollection, "List<PgThesisDiscussionDate>|PgThesisDiscussionDateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisDiscussionDate child in entity.PgThesisDiscussionDateCollection)
					{
						if(child.PgThesisCommIdSource != null)
						{
							child.PgThesisCommId = child.PgThesisCommIdSource.PgThesisCommId;
						}
						else
						{
							child.PgThesisCommId = entity.PgThesisCommId;
						}

					}

					if (entity.PgThesisDiscussionDateCollection.Count > 0 || entity.PgThesisDiscussionDateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisDiscussionDateProvider.Save(transactionManager, entity.PgThesisDiscussionDateCollection);
						
						deepHandles.Add("PgThesisDiscussionDateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisDiscussionDate >) DataRepository.PgThesisDiscussionDateProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisDiscussionDateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisCommMember>
				if (CanDeepSave(entity.PgThesisCommMemberCollection, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommMember child in entity.PgThesisCommMemberCollection)
					{
						if(child.PgThesisCommIdSource != null)
						{
							child.PgThesisCommId = child.PgThesisCommIdSource.PgThesisCommId;
						}
						else
						{
							child.PgThesisCommId = entity.PgThesisCommId;
						}

					}

					if (entity.PgThesisCommMemberCollection.Count > 0 || entity.PgThesisCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommMemberProvider.Save(transactionManager, entity.PgThesisCommMemberCollection);
						
						deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommMember >) DataRepository.PgThesisCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisCommRpt>
				if (CanDeepSave(entity.PgThesisCommRptCollection, "List<PgThesisCommRpt>|PgThesisCommRptCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommRpt child in entity.PgThesisCommRptCollection)
					{
						if(child.PgThesisCommIdSource != null)
						{
							child.PgThesisCommId = child.PgThesisCommIdSource.PgThesisCommId;
						}
						else
						{
							child.PgThesisCommId = entity.PgThesisCommId;
						}

					}

					if (entity.PgThesisCommRptCollection.Count > 0 || entity.PgThesisCommRptCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommRptProvider.Save(transactionManager, entity.PgThesisCommRptCollection);
						
						deepHandles.Add("PgThesisCommRptCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommRpt >) DataRepository.PgThesisCommRptProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommRptCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisCommApprove>
				if (CanDeepSave(entity.PgThesisCommApproveCollection, "List<PgThesisCommApprove>|PgThesisCommApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommApprove child in entity.PgThesisCommApproveCollection)
					{
						if(child.PgThesisCommIdSource != null)
						{
							child.PgThesisCommId = child.PgThesisCommIdSource.PgThesisCommId;
						}
						else
						{
							child.PgThesisCommId = entity.PgThesisCommId;
						}

					}

					if (entity.PgThesisCommApproveCollection.Count > 0 || entity.PgThesisCommApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommApproveProvider.Save(transactionManager, entity.PgThesisCommApproveCollection);
						
						deepHandles.Add("PgThesisCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommApprove >) DataRepository.PgThesisCommApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgAttchdDoc>
				if (CanDeepSave(entity.PgAttchdDocCollection, "List<PgAttchdDoc>|PgAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgAttchdDoc child in entity.PgAttchdDocCollection)
					{
						if(child.PgThesisCommIdSource != null)
						{
							child.PgThesisCommId = child.PgThesisCommIdSource.PgThesisCommId;
						}
						else
						{
							child.PgThesisCommId = entity.PgThesisCommId;
						}

					}

					if (entity.PgAttchdDocCollection.Count > 0 || entity.PgAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgAttchdDocProvider.Save(transactionManager, entity.PgAttchdDocCollection);
						
						deepHandles.Add("PgAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgAttchdDoc >) DataRepository.PgAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.PgAttchdDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgThesisCommChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisComm</c>
	///</summary>
	public enum PgThesisCommChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		///<summary>
		/// Collection of <c>PgThesisComm</c> as OneToMany for PgThesisCommRecommendCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommRecommend>))]
		PgThesisCommRecommendCollection,
		///<summary>
		/// Collection of <c>PgThesisComm</c> as OneToMany for PgThesisDiscussionDateCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisDiscussionDate>))]
		PgThesisDiscussionDateCollection,
		///<summary>
		/// Collection of <c>PgThesisComm</c> as OneToMany for PgThesisCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommMember>))]
		PgThesisCommMemberCollection,
		///<summary>
		/// Collection of <c>PgThesisComm</c> as OneToMany for PgThesisCommRptCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommRpt>))]
		PgThesisCommRptCollection,
		///<summary>
		/// Collection of <c>PgThesisComm</c> as OneToMany for PgThesisCommApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommApprove>))]
		PgThesisCommApproveCollection,
		///<summary>
		/// Collection of <c>PgThesisComm</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgThesisCommChildEntityTypes
	
	#region PgThesisCommFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommFilterBuilder : SqlFilterBuilder<PgThesisCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommFilterBuilder class.
		/// </summary>
		public PgThesisCommFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommFilterBuilder
	
	#region PgThesisCommParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisCommParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommParameterBuilder class.
		/// </summary>
		public PgThesisCommParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisCommParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisCommParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisCommParameterBuilder
	
	#region PgThesisCommSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisComm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisCommSortBuilder : SqlSortBuilder<PgThesisCommColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisCommSqlSortBuilder class.
		/// </summary>
		public PgThesisCommSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisCommSortBuilder
	
} // end namespace
