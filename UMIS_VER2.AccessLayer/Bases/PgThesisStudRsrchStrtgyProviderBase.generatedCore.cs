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
	/// This class is the base class for any <see cref="PgThesisStudRsrchStrtgyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisStudRsrchStrtgyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy, UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgyKey key)
		{
			return Delete(transactionManager, key.PgThesisStudRsrchStrtgyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisStudRsrchStrtgyId)
		{
			return Delete(null, _pgThesisStudRsrchStrtgyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisStudRsrchStrtgyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy objects.</returns>
		public TList<PgThesisStudRsrchStrtgy> GetByPgThesisStudId(System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(_pgThesisStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy objects.</returns>
		/// <remarks></remarks>
		public TList<PgThesisStudRsrchStrtgy> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy objects.</returns>
		public TList<PgThesisStudRsrchStrtgy> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudId(transactionManager, _pgThesisStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD key.
		///		fkPgThesisStudRsrchStrtgyPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy objects.</returns>
		public TList<PgThesisStudRsrchStrtgy> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD key.
		///		fkPgThesisStudRsrchStrtgyPgThesisStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy objects.</returns>
		public TList<PgThesisStudRsrchStrtgy> GetByPgThesisStudId(System.Decimal _pgThesisStudId, int start, int pageLength,out int count)
		{
			return GetByPgThesisStudId(null, _pgThesisStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD key.
		///		FK_PG_THESIS_STUD_RSRCH_STRTGY_PG_THESIS_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudId">تسجيل بيانات الرسالة-بيانات البحث العلمي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy objects.</returns>
		public abstract TList<PgThesisStudRsrchStrtgy> GetByPgThesisStudId(TransactionManager transactionManager, System.Decimal _pgThesisStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgyKey key, int start, int pageLength)
		{
			return GetByPgThesisStudRsrchStrtgyId(transactionManager, key.PgThesisStudRsrchStrtgyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_STUD_RSRCH_STRTGY index.
		/// </summary>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy GetByPgThesisStudRsrchStrtgyId(System.Decimal _pgThesisStudRsrchStrtgyId)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(null,_pgThesisStudRsrchStrtgyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_RSRCH_STRTGY index.
		/// </summary>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy GetByPgThesisStudRsrchStrtgyId(System.Decimal _pgThesisStudRsrchStrtgyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(null, _pgThesisStudRsrchStrtgyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_RSRCH_STRTGY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal _pgThesisStudRsrchStrtgyId)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(transactionManager, _pgThesisStudRsrchStrtgyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_RSRCH_STRTGY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal _pgThesisStudRsrchStrtgyId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisStudRsrchStrtgyId(transactionManager, _pgThesisStudRsrchStrtgyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_RSRCH_STRTGY index.
		/// </summary>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy GetByPgThesisStudRsrchStrtgyId(System.Decimal _pgThesisStudRsrchStrtgyId, int start, int pageLength, out int count)
		{
			return GetByPgThesisStudRsrchStrtgyId(null, _pgThesisStudRsrchStrtgyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_STUD_RSRCH_STRTGY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisStudRsrchStrtgyId">تسجيل الخطة البحثية للرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy GetByPgThesisStudRsrchStrtgyId(TransactionManager transactionManager, System.Decimal _pgThesisStudRsrchStrtgyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisStudRsrchStrtgy&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisStudRsrchStrtgy&gt;"/></returns>
		public static TList<PgThesisStudRsrchStrtgy> Fill(IDataReader reader, TList<PgThesisStudRsrchStrtgy> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisStudRsrchStrtgy")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_STUD_RSRCH_STRTGY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisStudRsrchStrtgy>(
					key.ToString(), // EntityTrackingKey
					"PgThesisStudRsrchStrtgy",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy();
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
					c.PgThesisStudRsrchStrtgyId = (System.Decimal)reader["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
					c.OriginalPgThesisStudRsrchStrtgyId = c.PgThesisStudRsrchStrtgyId;
					c.PgThesisStudId = (System.Decimal)reader["PG_THESIS_STUD_ID"];
					c.RsrchStrtgyDate = Convert.IsDBNull(reader["RSRCH_STRTGY_DATE"]) ? null : (System.DateTime?)reader["RSRCH_STRTGY_DATE"];
					c.RsrchStrtgyEn = Convert.IsDBNull(reader["RSRCH_STRTGY_EN"]) ? null : (System.String)reader["RSRCH_STRTGY_EN"];
					c.RsrchStrtgyAr = Convert.IsDBNull(reader["RSRCH_STRTGY_AR"]) ? null : (System.String)reader["RSRCH_STRTGY_AR"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisStudRsrchStrtgyId = (System.Decimal)reader[((int)PgThesisStudRsrchStrtgyColumn.PgThesisStudRsrchStrtgyId - 1)];
			entity.OriginalPgThesisStudRsrchStrtgyId = (System.Decimal)reader["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
			entity.PgThesisStudId = (System.Decimal)reader[((int)PgThesisStudRsrchStrtgyColumn.PgThesisStudId - 1)];
			entity.RsrchStrtgyDate = (reader.IsDBNull(((int)PgThesisStudRsrchStrtgyColumn.RsrchStrtgyDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudRsrchStrtgyColumn.RsrchStrtgyDate - 1)];
			entity.RsrchStrtgyEn = (reader.IsDBNull(((int)PgThesisStudRsrchStrtgyColumn.RsrchStrtgyEn - 1)))?null:(System.String)reader[((int)PgThesisStudRsrchStrtgyColumn.RsrchStrtgyEn - 1)];
			entity.RsrchStrtgyAr = (reader.IsDBNull(((int)PgThesisStudRsrchStrtgyColumn.RsrchStrtgyAr - 1)))?null:(System.String)reader[((int)PgThesisStudRsrchStrtgyColumn.RsrchStrtgyAr - 1)];
			entity.LastDate = (reader.IsDBNull(((int)PgThesisStudRsrchStrtgyColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)PgThesisStudRsrchStrtgyColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)PgThesisStudRsrchStrtgyColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)PgThesisStudRsrchStrtgyColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisStudRsrchStrtgyId = (System.Decimal)dataRow["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
			entity.OriginalPgThesisStudRsrchStrtgyId = (System.Decimal)dataRow["PG_THESIS_STUD_RSRCH_STRTGY_ID"];
			entity.PgThesisStudId = (System.Decimal)dataRow["PG_THESIS_STUD_ID"];
			entity.RsrchStrtgyDate = Convert.IsDBNull(dataRow["RSRCH_STRTGY_DATE"]) ? null : (System.DateTime?)dataRow["RSRCH_STRTGY_DATE"];
			entity.RsrchStrtgyEn = Convert.IsDBNull(dataRow["RSRCH_STRTGY_EN"]) ? null : (System.String)dataRow["RSRCH_STRTGY_EN"];
			entity.RsrchStrtgyAr = Convert.IsDBNull(dataRow["RSRCH_STRTGY_AR"]) ? null : (System.String)dataRow["RSRCH_STRTGY_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			// Deep load child collections  - Call GetByPgThesisStudRsrchStrtgyId methods when available
			
			#region PgThesisStudApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudApproveCollection = DataRepository.PgThesisStudApproveProvider.GetByPgThesisStudRsrchStrtgyId(transactionManager, entity.PgThesisStudRsrchStrtgyId);

				if (deep && entity.PgThesisStudApproveCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStudApprove>) DataRepository.PgThesisStudApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudApproveCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgAttchdDocCollection = DataRepository.PgAttchdDocProvider.GetByPgThesisStudRsrchStrtgyId(transactionManager, entity.PgThesisStudRsrchStrtgyId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisStudApprove>
				if (CanDeepSave(entity.PgThesisStudApproveCollection, "List<PgThesisStudApprove>|PgThesisStudApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStudApprove child in entity.PgThesisStudApproveCollection)
					{
						if(child.PgThesisStudRsrchStrtgyIdSource != null)
						{
							child.PgThesisStudRsrchStrtgyId = child.PgThesisStudRsrchStrtgyIdSource.PgThesisStudRsrchStrtgyId;
						}
						else
						{
							child.PgThesisStudRsrchStrtgyId = entity.PgThesisStudRsrchStrtgyId;
						}

					}

					if (entity.PgThesisStudApproveCollection.Count > 0 || entity.PgThesisStudApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudApproveProvider.Save(transactionManager, entity.PgThesisStudApproveCollection);
						
						deepHandles.Add("PgThesisStudApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStudApprove >) DataRepository.PgThesisStudApproveProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudApproveCollection, deepSaveType, childTypes, innerList }
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
						if(child.PgThesisStudRsrchStrtgyIdSource != null)
						{
							child.PgThesisStudRsrchStrtgyId = child.PgThesisStudRsrchStrtgyIdSource.PgThesisStudRsrchStrtgyId;
						}
						else
						{
							child.PgThesisStudRsrchStrtgyId = entity.PgThesisStudRsrchStrtgyId;
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
	
	#region PgThesisStudRsrchStrtgyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisStudRsrchStrtgy</c>
	///</summary>
	public enum PgThesisStudRsrchStrtgyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>PgThesisStud</c> at PgThesisStudIdSource
		///</summary>
		[ChildEntityType(typeof(PgThesisStud))]
		PgThesisStud,
		///<summary>
		/// Collection of <c>PgThesisStudRsrchStrtgy</c> as OneToMany for PgThesisStudApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStudApprove>))]
		PgThesisStudApproveCollection,
		///<summary>
		/// Collection of <c>PgThesisStudRsrchStrtgy</c> as OneToMany for PgAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgAttchdDoc>))]
		PgAttchdDocCollection,
	}
	
	#endregion PgThesisStudRsrchStrtgyChildEntityTypes
	
	#region PgThesisStudRsrchStrtgyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisStudRsrchStrtgyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudRsrchStrtgy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudRsrchStrtgyFilterBuilder : SqlFilterBuilder<PgThesisStudRsrchStrtgyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudRsrchStrtgyFilterBuilder class.
		/// </summary>
		public PgThesisStudRsrchStrtgyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudRsrchStrtgyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudRsrchStrtgyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudRsrchStrtgyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudRsrchStrtgyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudRsrchStrtgyFilterBuilder
	
	#region PgThesisStudRsrchStrtgyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisStudRsrchStrtgyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudRsrchStrtgy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisStudRsrchStrtgyParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisStudRsrchStrtgyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudRsrchStrtgyParameterBuilder class.
		/// </summary>
		public PgThesisStudRsrchStrtgyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudRsrchStrtgyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisStudRsrchStrtgyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisStudRsrchStrtgyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisStudRsrchStrtgyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisStudRsrchStrtgyParameterBuilder
	
	#region PgThesisStudRsrchStrtgySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisStudRsrchStrtgyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisStudRsrchStrtgy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisStudRsrchStrtgySortBuilder : SqlSortBuilder<PgThesisStudRsrchStrtgyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisStudRsrchStrtgySqlSortBuilder class.
		/// </summary>
		public PgThesisStudRsrchStrtgySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisStudRsrchStrtgySortBuilder
	
} // end namespace
