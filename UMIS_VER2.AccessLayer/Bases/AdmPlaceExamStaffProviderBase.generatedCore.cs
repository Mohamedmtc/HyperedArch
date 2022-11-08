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
	/// This class is the base class for any <see cref="AdmPlaceExamStaffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmPlaceExamStaffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmPlaceExamStaff, UMIS_VER2.BusinessLyer.AdmPlaceExamStaffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamStaffKey key)
		{
			return Delete(transactionManager, key.AdmPlaceExamStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admPlaceExamStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admPlaceExamStaffId)
		{
			return Delete(null, _admPlaceExamStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admPlaceExamStaffId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(_admPlaceExamDatetimeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamStaff> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME key.
		///		fkAdmPlaceExamStaffAdmPlaceExamDatetime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME key.
		///		fkAdmPlaceExamStaffAdmPlaceExamDatetime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId, int start, int pageLength,out int count)
		{
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_STAFF_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public abstract TList<AdmPlaceExamStaff> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER key.
		///		FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER key.
		///		FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER key.
		///		FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER key.
		///		fkAdmPlaceExamStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER key.
		///		fkAdmPlaceExamStaffSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public TList<AdmPlaceExamStaff> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER key.
		///		FK_ADM_PLACE_EXAM_STAFF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamStaff objects.</returns>
		public abstract TList<AdmPlaceExamStaff> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmPlaceExamStaff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamStaffKey key, int start, int pageLength)
		{
			return GetByAdmPlaceExamStaffId(transactionManager, key.AdmPlaceExamStaffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_PLACE_EXAM_STAFF index.
		/// </summary>
		/// <param name="_admPlaceExamStaffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamStaff GetByAdmPlaceExamStaffId(System.Decimal _admPlaceExamStaffId)
		{
			int count = -1;
			return GetByAdmPlaceExamStaffId(null,_admPlaceExamStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_STAFF index.
		/// </summary>
		/// <param name="_admPlaceExamStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamStaff GetByAdmPlaceExamStaffId(System.Decimal _admPlaceExamStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamStaffId(null, _admPlaceExamStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamStaffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamStaff GetByAdmPlaceExamStaffId(TransactionManager transactionManager, System.Decimal _admPlaceExamStaffId)
		{
			int count = -1;
			return GetByAdmPlaceExamStaffId(transactionManager, _admPlaceExamStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamStaff GetByAdmPlaceExamStaffId(TransactionManager transactionManager, System.Decimal _admPlaceExamStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamStaffId(transactionManager, _admPlaceExamStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_STAFF index.
		/// </summary>
		/// <param name="_admPlaceExamStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamStaff GetByAdmPlaceExamStaffId(System.Decimal _admPlaceExamStaffId, int start, int pageLength, out int count)
		{
			return GetByAdmPlaceExamStaffId(null, _admPlaceExamStaffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_STAFF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPlaceExamStaff GetByAdmPlaceExamStaffId(TransactionManager transactionManager, System.Decimal _admPlaceExamStaffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmPlaceExamStaff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmPlaceExamStaff&gt;"/></returns>
		public static TList<AdmPlaceExamStaff> Fill(IDataReader reader, TList<AdmPlaceExamStaff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmPlaceExamStaff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmPlaceExamStaff")
					.Append("|").Append((System.Decimal)reader["ADM_PLACE_EXAM_STAFF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmPlaceExamStaff>(
					key.ToString(), // EntityTrackingKey
					"AdmPlaceExamStaff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmPlaceExamStaff();
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
					c.AdmPlaceExamStaffId = (System.Decimal)reader["ADM_PLACE_EXAM_STAFF_ID"];
					c.OriginalAdmPlaceExamStaffId = c.AdmPlaceExamStaffId;
					c.AdmPlaceExamDatetimeId = (System.Decimal)reader["ADM_PLACE_EXAM_DATETIME_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmPlaceExamStaff entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmPlaceExamStaffId = (System.Decimal)reader[((int)AdmPlaceExamStaffColumn.AdmPlaceExamStaffId - 1)];
			entity.OriginalAdmPlaceExamStaffId = (System.Decimal)reader["ADM_PLACE_EXAM_STAFF_ID"];
			entity.AdmPlaceExamDatetimeId = (System.Decimal)reader[((int)AdmPlaceExamStaffColumn.AdmPlaceExamDatetimeId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)AdmPlaceExamStaffColumn.SaStfMemberId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmPlaceExamStaffColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmPlaceExamStaffColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmPlaceExamStaffColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamStaffColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmPlaceExamStaff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmPlaceExamStaffId = (System.Decimal)dataRow["ADM_PLACE_EXAM_STAFF_ID"];
			entity.OriginalAdmPlaceExamStaffId = (System.Decimal)dataRow["ADM_PLACE_EXAM_STAFF_ID"];
			entity.AdmPlaceExamDatetimeId = (System.Decimal)dataRow["ADM_PLACE_EXAM_DATETIME_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamStaff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamStaff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamStaff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmPlaceExamDatetimeIdSource	
			if (CanDeepLoad(entity, "AdmPlaceExamDatetime|AdmPlaceExamDatetimeIdSource", deepLoadType, innerList) 
				&& entity.AdmPlaceExamDatetimeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmPlaceExamDatetimeId;
				AdmPlaceExamDatetime tmpEntity = EntityManager.LocateEntity<AdmPlaceExamDatetime>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmPlaceExamDatetime), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmPlaceExamDatetimeIdSource = tmpEntity;
				else
					entity.AdmPlaceExamDatetimeIdSource = DataRepository.AdmPlaceExamDatetimeProvider.GetByAdmPlaceExamDatetimeId(transactionManager, entity.AdmPlaceExamDatetimeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmPlaceExamDatetimeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad(transactionManager, entity.AdmPlaceExamDatetimeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmPlaceExamDatetimeIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmPlaceExamStaff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmPlaceExamStaff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamStaff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamStaff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmPlaceExamDatetimeIdSource
			if (CanDeepSave(entity, "AdmPlaceExamDatetime|AdmPlaceExamDatetimeIdSource", deepSaveType, innerList) 
				&& entity.AdmPlaceExamDatetimeIdSource != null)
			{
				DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeIdSource);
				entity.AdmPlaceExamDatetimeId = entity.AdmPlaceExamDatetimeIdSource.AdmPlaceExamDatetimeId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region AdmPlaceExamStaffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmPlaceExamStaff</c>
	///</summary>
	public enum AdmPlaceExamStaffChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmPlaceExamDatetime</c> at AdmPlaceExamDatetimeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmPlaceExamDatetime))]
		AdmPlaceExamDatetime,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion AdmPlaceExamStaffChildEntityTypes
	
	#region AdmPlaceExamStaffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmPlaceExamStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamStaffFilterBuilder : SqlFilterBuilder<AdmPlaceExamStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamStaffFilterBuilder class.
		/// </summary>
		public AdmPlaceExamStaffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamStaffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamStaffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamStaffFilterBuilder
	
	#region AdmPlaceExamStaffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmPlaceExamStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamStaffParameterBuilder : ParameterizedSqlFilterBuilder<AdmPlaceExamStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamStaffParameterBuilder class.
		/// </summary>
		public AdmPlaceExamStaffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamStaffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamStaffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamStaffParameterBuilder
	
	#region AdmPlaceExamStaffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmPlaceExamStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamStaff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmPlaceExamStaffSortBuilder : SqlSortBuilder<AdmPlaceExamStaffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamStaffSqlSortBuilder class.
		/// </summary>
		public AdmPlaceExamStaffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmPlaceExamStaffSortBuilder
	
} // end namespace
