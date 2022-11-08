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
	/// This class is the base class for any <see cref="EdCourseRltdProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseRltdProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseRltd, UMIS_VER2.BusinessLyer.EdCourseRltdKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseRltdKey key)
		{
			return Delete(transactionManager, key.EdCourseRltdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseRltdId)
		{
			return Delete(null, _edCourseRltdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseRltdId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE key.
		///		FK_ED_COURSE_RLTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourse1Id">مقرر الفصل الاول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse1Id(System.Decimal _edCourse1Id)
		{
			int count = -1;
			return GetByEdCourse1Id(_edCourse1Id, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE key.
		///		FK_ED_COURSE_RLTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourse1Id">مقرر الفصل الاول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseRltd> GetByEdCourse1Id(TransactionManager transactionManager, System.Decimal _edCourse1Id)
		{
			int count = -1;
			return GetByEdCourse1Id(transactionManager, _edCourse1Id, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE key.
		///		FK_ED_COURSE_RLTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourse1Id">مقرر الفصل الاول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse1Id(TransactionManager transactionManager, System.Decimal _edCourse1Id, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourse1Id(transactionManager, _edCourse1Id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE key.
		///		fkEdCourseRltdEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourse1Id">مقرر الفصل الاول</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse1Id(System.Decimal _edCourse1Id, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourse1Id(null, _edCourse1Id, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE key.
		///		fkEdCourseRltdEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourse1Id">مقرر الفصل الاول</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse1Id(System.Decimal _edCourse1Id, int start, int pageLength,out int count)
		{
			return GetByEdCourse1Id(null, _edCourse1Id, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE key.
		///		FK_ED_COURSE_RLTD_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourse1Id">مقرر الفصل الاول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public abstract TList<EdCourseRltd> GetByEdCourse1Id(TransactionManager transactionManager, System.Decimal _edCourse1Id, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE1 key.
		///		FK_ED_COURSE_RLTD_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="_edCourse2Id">مقرر الفصل التانى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse2Id(System.Decimal _edCourse2Id)
		{
			int count = -1;
			return GetByEdCourse2Id(_edCourse2Id, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE1 key.
		///		FK_ED_COURSE_RLTD_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourse2Id">مقرر الفصل التانى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		/// <remarks></remarks>
		public TList<EdCourseRltd> GetByEdCourse2Id(TransactionManager transactionManager, System.Decimal _edCourse2Id)
		{
			int count = -1;
			return GetByEdCourse2Id(transactionManager, _edCourse2Id, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE1 key.
		///		FK_ED_COURSE_RLTD_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourse2Id">مقرر الفصل التانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse2Id(TransactionManager transactionManager, System.Decimal _edCourse2Id, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourse2Id(transactionManager, _edCourse2Id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE1 key.
		///		fkEdCourseRltdEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourse2Id">مقرر الفصل التانى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse2Id(System.Decimal _edCourse2Id, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourse2Id(null, _edCourse2Id, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE1 key.
		///		fkEdCourseRltdEdCourse1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourse2Id">مقرر الفصل التانى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public TList<EdCourseRltd> GetByEdCourse2Id(System.Decimal _edCourse2Id, int start, int pageLength,out int count)
		{
			return GetByEdCourse2Id(null, _edCourse2Id, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_COURSE_RLTD_ED_COURSE1 key.
		///		FK_ED_COURSE_RLTD_ED_COURSE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourse2Id">مقرر الفصل التانى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourseRltd objects.</returns>
		public abstract TList<EdCourseRltd> GetByEdCourse2Id(TransactionManager transactionManager, System.Decimal _edCourse2Id, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseRltd Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseRltdKey key, int start, int pageLength)
		{
			return GetByEdCourseRltdId(transactionManager, key.EdCourseRltdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_RLTD index.
		/// </summary>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseRltd GetByEdCourseRltdId(System.Decimal _edCourseRltdId)
		{
			int count = -1;
			return GetByEdCourseRltdId(null,_edCourseRltdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_RLTD index.
		/// </summary>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseRltd GetByEdCourseRltdId(System.Decimal _edCourseRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseRltdId(null, _edCourseRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_RLTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseRltd GetByEdCourseRltdId(TransactionManager transactionManager, System.Decimal _edCourseRltdId)
		{
			int count = -1;
			return GetByEdCourseRltdId(transactionManager, _edCourseRltdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_RLTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseRltd GetByEdCourseRltdId(TransactionManager transactionManager, System.Decimal _edCourseRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseRltdId(transactionManager, _edCourseRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_RLTD index.
		/// </summary>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseRltd GetByEdCourseRltdId(System.Decimal _edCourseRltdId, int start, int pageLength, out int count)
		{
			return GetByEdCourseRltdId(null, _edCourseRltdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_RLTD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseRltdId">المقررات المنقسمة - المتصلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseRltd GetByEdCourseRltdId(TransactionManager transactionManager, System.Decimal _edCourseRltdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseRltd&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseRltd&gt;"/></returns>
		public static TList<EdCourseRltd> Fill(IDataReader reader, TList<EdCourseRltd> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseRltd c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseRltd")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_RLTD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseRltd>(
					key.ToString(), // EntityTrackingKey
					"EdCourseRltd",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseRltd();
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
					c.EdCourseRltdId = (System.Decimal)reader["ED_COURSE_RLTD_ID"];
					c.OriginalEdCourseRltdId = c.EdCourseRltdId;
					c.EdCourse1Id = (System.Decimal)reader["ED_COURSE_1_ID"];
					c.EdCourse2Id = (System.Decimal)reader["ED_COURSE_2_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseRltd entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseRltdId = (System.Decimal)reader[((int)EdCourseRltdColumn.EdCourseRltdId - 1)];
			entity.OriginalEdCourseRltdId = (System.Decimal)reader["ED_COURSE_RLTD_ID"];
			entity.EdCourse1Id = (System.Decimal)reader[((int)EdCourseRltdColumn.EdCourse1Id - 1)];
			entity.EdCourse2Id = (System.Decimal)reader[((int)EdCourseRltdColumn.EdCourse2Id - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdCourseRltdColumn.Notes - 1)))?null:(System.String)reader[((int)EdCourseRltdColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseRltd entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseRltdId = (System.Decimal)dataRow["ED_COURSE_RLTD_ID"];
			entity.OriginalEdCourseRltdId = (System.Decimal)dataRow["ED_COURSE_RLTD_ID"];
			entity.EdCourse1Id = (System.Decimal)dataRow["ED_COURSE_1_ID"];
			entity.EdCourse2Id = (System.Decimal)dataRow["ED_COURSE_2_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseRltd"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseRltd Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseRltd entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourse1IdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourse1IdSource", deepLoadType, innerList) 
				&& entity.EdCourse1IdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourse1Id;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourse1IdSource = tmpEntity;
				else
					entity.EdCourse1IdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourse1Id);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourse1IdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourse1IdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourse1IdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourse1IdSource

			#region EdCourse2IdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourse2IdSource", deepLoadType, innerList) 
				&& entity.EdCourse2IdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourse2Id;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourse2IdSource = tmpEntity;
				else
					entity.EdCourse2IdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourse2Id);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourse2IdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourse2IdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourse2IdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourse2IdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseRltd object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseRltd instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseRltd Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseRltd entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourse1IdSource
			if (CanDeepSave(entity, "EdCourse|EdCourse1IdSource", deepSaveType, innerList) 
				&& entity.EdCourse1IdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourse1IdSource);
				entity.EdCourse1Id = entity.EdCourse1IdSource.EdCourseId;
			}
			#endregion 
			
			#region EdCourse2IdSource
			if (CanDeepSave(entity, "EdCourse|EdCourse2IdSource", deepSaveType, innerList) 
				&& entity.EdCourse2IdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourse2IdSource);
				entity.EdCourse2Id = entity.EdCourse2IdSource.EdCourseId;
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
	
	#region EdCourseRltdChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseRltd</c>
	///</summary>
	public enum EdCourseRltdChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourse1IdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion EdCourseRltdChildEntityTypes
	
	#region EdCourseRltdFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseRltdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseRltd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseRltdFilterBuilder : SqlFilterBuilder<EdCourseRltdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseRltdFilterBuilder class.
		/// </summary>
		public EdCourseRltdFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseRltdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseRltdFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseRltdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseRltdFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseRltdFilterBuilder
	
	#region EdCourseRltdParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseRltdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseRltd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseRltdParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseRltdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseRltdParameterBuilder class.
		/// </summary>
		public EdCourseRltdParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseRltdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseRltdParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseRltdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseRltdParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseRltdParameterBuilder
	
	#region EdCourseRltdSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseRltdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseRltd"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseRltdSortBuilder : SqlSortBuilder<EdCourseRltdColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseRltdSqlSortBuilder class.
		/// </summary>
		public EdCourseRltdSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseRltdSortBuilder
	
} // end namespace
