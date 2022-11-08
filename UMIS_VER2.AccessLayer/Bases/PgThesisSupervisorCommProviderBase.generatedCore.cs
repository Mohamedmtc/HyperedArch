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
	/// This class is the base class for any <see cref="PgThesisSupervisorCommProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisSupervisorCommProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisSupervisorComm, UMIS_VER2.BusinessLyer.PgThesisSupervisorCommKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorCommKey key)
		{
			return Delete(transactionManager, key.PgThesisSupervisorCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisSupervisorCommId)
		{
			return Delete(null, _pgThesisSupervisorCommId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorCommId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorComm objects.</returns>
		public TList<PgThesisSupervisorComm> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorComm objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisSupervisorComm> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorComm objects.</returns>
		public TList<PgThesisSupervisorComm> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD key.
		///		fkPgThesisSupervisorCommPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorComm objects.</returns>
		public TList<PgThesisSupervisorComm> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD key.
		///		fkPgThesisSupervisorCommPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorComm objects.</returns>
		public TList<PgThesisSupervisorComm> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD key.
		///		FK_PG_THESIS_SUPERVISOR_COMM_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisSupervisorComm objects.</returns>
		public abstract TList<PgThesisSupervisorComm> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisSupervisorComm Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorCommKey key, int start, int pageLength)
		{
			return GetByPgThesisSupervisorCommId(transactionManager, key.PgThesisSupervisorCommId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_SUPERVISOR_COMM index.
		/// </summary>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorComm GetByPgThesisSupervisorCommId(System.Decimal _pgThesisSupervisorCommId)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(null,_pgThesisSupervisorCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_COMM index.
		/// </summary>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorComm GetByPgThesisSupervisorCommId(System.Decimal _pgThesisSupervisorCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(null, _pgThesisSupervisorCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorComm GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorCommId)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(transactionManager, _pgThesisSupervisorCommId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorComm GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorCommId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisSupervisorCommId(transactionManager, _pgThesisSupervisorCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_COMM index.
		/// </summary>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisSupervisorComm GetByPgThesisSupervisorCommId(System.Decimal _pgThesisSupervisorCommId, int start, int pageLength, out int count)
		{
			return GetByPgThesisSupervisorCommId(null, _pgThesisSupervisorCommId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_SUPERVISOR_COMM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisSupervisorCommId">لجنة الاشراف والمتابعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisSupervisorComm GetByPgThesisSupervisorCommId(TransactionManager transactionManager, System.Decimal _pgThesisSupervisorCommId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisSupervisorComm&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisSupervisorComm&gt;"/></returns>
		public static TList<PgThesisSupervisorComm> Fill(IDataReader reader, TList<PgThesisSupervisorComm> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisSupervisorComm c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisSupervisorComm")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_SUPERVISOR_COMM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisSupervisorComm>(
					key.ToString(), // EntityTrackingKey
					"PgThesisSupervisorComm",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisSupervisorComm();
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
					c.PgThesisSupervisorCommId = (System.Decimal)reader["PG_THESIS_SUPERVISOR_COMM_ID"];
					c.OriginalPgThesisSupervisorCommId = c.PgThesisSupervisorCommId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.CommDate = Convert.IsDBNull(reader["COMM_DATE"]) ? null : (System.DateTime?)reader["COMM_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisSupervisorComm entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisSupervisorCommId = (System.Decimal)reader[((int)PgThesisSupervisorCommColumn.PgThesisSupervisorCommId - 1)];
			entity.OriginalPgThesisSupervisorCommId = (System.Decimal)reader["PG_THESIS_SUPERVISOR_COMM_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisSupervisorCommColumn.PgThesisStudId - 1)];
			entity.CommDate = (reader.IsDBNull(((int)PgThesisSupervisorCommColumn.CommDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisSupervisorCommColumn.CommDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)PgThesisSupervisorCommColumn.Notes - 1)))?null:(System.String)reader[((int)PgThesisSupervisorCommColumn.Notes - 1)];
			entity.IsLast = (System.Boolean)reader[((int)PgThesisSupervisorCommColumn.IsLast - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisSupervisorCommColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisSupervisorCommColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisSupervisorCommColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisSupervisorCommColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisSupervisorComm entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisSupervisorCommId = (System.Decimal)dataRow["PG_THESIS_SUPERVISOR_COMM_ID"];
			entity.OriginalPgThesisSupervisorCommId = (System.Decimal)dataRow["PG_THESIS_SUPERVISOR_COMM_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.CommDate = Convert.IsDBNull(dataRow["COMM_DATE"]) ? null : (System.DateTime?)dataRow["COMM_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisSupervisorComm"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisSupervisorComm Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorComm entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			// Deep load child collections  - Call GetByPgThesisSupervisorCommId methods when available
			
			#region PgThesisSupervisorRptCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSupervisorRpt>|PgThesisSupervisorRptCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorRptCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSupervisorRptCollection = DataRepository.PgThesisSupervisorRptProvider.GetByPgThesisSupervisorCommId(transactionManager, entity.PgThesisSupervisorCommId);

				if (deep && entity.PgThesisSupervisorRptCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSupervisorRptCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSupervisorRpt>) DataRepository.PgThesisSupervisorRptProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSupervisorRptCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisSupervisorCommApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisSupervisorCommApprove>|PgThesisSupervisorCommApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisSupervisorCommApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisSupervisorCommApproveCollection = DataRepository.PgThesisSupervisorCommApproveProvider.GetByPgThesisSupervisorCommId(transactionManager, entity.PgThesisSupervisorCommId);

				if (deep && entity.PgThesisSupervisorCommApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisSupervisorCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisSupervisorCommApprove>) DataRepository.PgThesisSupervisorCommApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisSupervisorCommApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStaff>|PgThesisStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStaffCollection = DataRepository.PgThesisStaffProvider.GetByPgThesisSupervisorCommId(transactionManager, entity.PgThesisSupervisorCommId);

				if (deep && entity.PgThesisStaffCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStaff>) DataRepository.PgThesisStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStaffCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisSupervisorComm object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisSupervisorComm instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisSupervisorComm Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisSupervisorComm entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisSupervisorRpt>
				if (CanDeepSave(entity.PgThesisSupervisorRptCollection, "List<PgThesisSupervisorRpt>|PgThesisSupervisorRptCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSupervisorRpt child in entity.PgThesisSupervisorRptCollection)
					{
						if(child.PgThesisSupervisorCommIdSource != null)
						{
							child.PgThesisSupervisorCommId = child.PgThesisSupervisorCommIdSource.PgThesisSupervisorCommId;
						}
						else
						{
							child.PgThesisSupervisorCommId = entity.PgThesisSupervisorCommId;
						}

					}

					if (entity.PgThesisSupervisorRptCollection.Count > 0 || entity.PgThesisSupervisorRptCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSupervisorRptProvider.Save(transactionManager, entity.PgThesisSupervisorRptCollection);
						
						deepHandles.Add("PgThesisSupervisorRptCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSupervisorRpt >) DataRepository.PgThesisSupervisorRptProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSupervisorRptCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisSupervisorCommApprove>
				if (CanDeepSave(entity.PgThesisSupervisorCommApproveCollection, "List<PgThesisSupervisorCommApprove>|PgThesisSupervisorCommApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisSupervisorCommApprove child in entity.PgThesisSupervisorCommApproveCollection)
					{
						if(child.PgThesisSupervisorCommIdSource != null)
						{
							child.PgThesisSupervisorCommId = child.PgThesisSupervisorCommIdSource.PgThesisSupervisorCommId;
						}
						else
						{
							child.PgThesisSupervisorCommId = entity.PgThesisSupervisorCommId;
						}

					}

					if (entity.PgThesisSupervisorCommApproveCollection.Count > 0 || entity.PgThesisSupervisorCommApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisSupervisorCommApproveProvider.Save(transactionManager, entity.PgThesisSupervisorCommApproveCollection);
						
						deepHandles.Add("PgThesisSupervisorCommApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisSupervisorCommApprove >) DataRepository.PgThesisSupervisorCommApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisSupervisorCommApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStaff>
				if (CanDeepSave(entity.PgThesisStaffCollection, "List<PgThesisStaff>|PgThesisStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStaff child in entity.PgThesisStaffCollection)
					{
						if(child.PgThesisSupervisorCommIdSource != null)
						{
							child.PgThesisSupervisorCommId = child.PgThesisSupervisorCommIdSource.PgThesisSupervisorCommId;
						}
						else
						{
							child.PgThesisSupervisorCommId = entity.PgThesisSupervisorCommId;
						}

					}

					if (entity.PgThesisStaffCollection.Count > 0 || entity.PgThesisStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStaffProvider.Save(transactionManager, entity.PgThesisStaffCollection);
						
						deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStaff >) DataRepository.PgThesisStaffProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStaffCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgThesisSupervisorCommChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisSupervisorComm</c>
	///</summary>
	public enum PgThesisSupervisorCommChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		///<summary>
		/// Collection of <c>PgThesisSupervisorComm</c> as OneToMany for PgThesisSupervisorRptCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSupervisorRpt>))]
		PgThesisSupervisorRptCollection,
		///<summary>
		/// Collection of <c>PgThesisSupervisorComm</c> as OneToMany for PgThesisSupervisorCommApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisSupervisorCommApprove>))]
		PgThesisSupervisorCommApproveCollection,
		///<summary>
		/// Collection of <c>PgThesisSupervisorComm</c> as OneToMany for PgThesisStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStaff>))]
		PgThesisStaffCollection,
	}
	
	#endregion PgThesisSupervisorCommChildEntityTypes
	
	#region PgThesisSupervisorCommFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisSupervisorCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSupervisorComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisSupervisorCommFilterBuilder : SqlFilterBuilder<PgThesisSupervisorCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorCommFilterBuilder class.
		/// </summary>
		public PgThesisSupervisorCommFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisSupervisorCommFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorCommFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisSupervisorCommFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisSupervisorCommFilterBuilder
	
	#region PgThesisSupervisorCommParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisSupervisorCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSupervisorComm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisSupervisorCommParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisSupervisorCommColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorCommParameterBuilder class.
		/// </summary>
		public PgThesisSupervisorCommParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisSupervisorCommParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorCommParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisSupervisorCommParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisSupervisorCommParameterBuilder
	
	#region PgThesisSupervisorCommSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisSupervisorCommColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisSupervisorComm"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisSupervisorCommSortBuilder : SqlSortBuilder<PgThesisSupervisorCommColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisSupervisorCommSqlSortBuilder class.
		/// </summary>
		public PgThesisSupervisorCommSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisSupervisorCommSortBuilder
	
} // end namespace
