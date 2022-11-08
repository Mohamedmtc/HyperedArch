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
	/// This class is the base class for any <see cref="EntPolicyCourseChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyCourseChngProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyCourseChng, UMIS_VER2.BusinessLyer.EntPolicyCourseChngKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseChngKey key)
		{
			return Delete(transactionManager, key.EntPolicyCourseChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyCourseChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyCourseChngId)
		{
			return Delete(null, _entPolicyCourseChngId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseChngId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyCourseChngId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseChng objects.</returns>
		public TList<EntPolicyCourseChng> GetByEdBylawId(System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseChng objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyCourseChng> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseChng objects.</returns>
		public TList<EntPolicyCourseChng> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW key.
		///		fkEntPolicyCourseChngEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseChng objects.</returns>
		public TList<EntPolicyCourseChng> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW key.
		///		fkEntPolicyCourseChngEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseChng objects.</returns>
		public TList<EntPolicyCourseChng> GetByEdBylawId(System.Decimal? _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW key.
		///		FK_ENT_POLICY_COURSE_CHNG_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyCourseChng objects.</returns>
		public abstract TList<EntPolicyCourseChng> GetByEdBylawId(TransactionManager transactionManager, System.Decimal? _edBylawId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyCourseChng Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseChngKey key, int start, int pageLength)
		{
			return GetByEntPolicyCourseChngId(transactionManager, key.EntPolicyCourseChngId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseChng&gt;"/> class.</returns>
		public TList<EntPolicyCourseChng> GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(null,_edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseChng&gt;"/> class.</returns>
		public TList<EntPolicyCourseChng> GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(null, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseChng&gt;"/> class.</returns>
		public TList<EntPolicyCourseChng> GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(transactionManager, _edCodeCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseChng&gt;"/> class.</returns>
		public TList<EntPolicyCourseChng> GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseChngId(transactionManager, _edCodeCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseChng&gt;"/> class.</returns>
		public TList<EntPolicyCourseChng> GetByEdCodeCourseChngId(System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseChngId(null, _edCodeCourseChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_COURSE_CHNG__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyCourseChng&gt;"/> class.</returns>
		public abstract TList<EntPolicyCourseChng> GetByEdCodeCourseChngId(TransactionManager transactionManager, System.Decimal _edCodeCourseChngId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_BYLAW_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="_entPolicyCourseChngId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseChng GetByEntPolicyCourseChngId(System.Decimal _entPolicyCourseChngId)
		{
			int count = -1;
			return GetByEntPolicyCourseChngId(null,_entPolicyCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="_entPolicyCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseChng GetByEntPolicyCourseChngId(System.Decimal _entPolicyCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyCourseChngId(null, _entPolicyCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseChngId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseChng GetByEntPolicyCourseChngId(TransactionManager transactionManager, System.Decimal _entPolicyCourseChngId)
		{
			int count = -1;
			return GetByEntPolicyCourseChngId(transactionManager, _entPolicyCourseChngId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseChng GetByEntPolicyCourseChngId(TransactionManager transactionManager, System.Decimal _entPolicyCourseChngId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyCourseChngId(transactionManager, _entPolicyCourseChngId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="_entPolicyCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyCourseChng GetByEntPolicyCourseChngId(System.Decimal _entPolicyCourseChngId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyCourseChngId(null, _entPolicyCourseChngId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_SUBJ_EDIT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyCourseChngId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyCourseChng GetByEntPolicyCourseChngId(TransactionManager transactionManager, System.Decimal _entPolicyCourseChngId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyCourseChng&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyCourseChng&gt;"/></returns>
		public static TList<EntPolicyCourseChng> Fill(IDataReader reader, TList<EntPolicyCourseChng> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyCourseChng c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyCourseChng")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_COURSE_CHNG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyCourseChng>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyCourseChng",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyCourseChng();
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
					c.EntPolicyCourseChngId = (System.Decimal)reader["ENT_POLICY_COURSE_CHNG_ID"];
					c.OriginalEntPolicyCourseChngId = c.EntPolicyCourseChngId;
					c.EdBylawId = Convert.IsDBNull(reader["ED_BYLAW_ID"]) ? null : (System.Decimal?)reader["ED_BYLAW_ID"];
					c.EdCodeCourseChngId = (System.Decimal)reader["ED_CODE_COURSE_CHNG_ID"];
					c.CourseNo = (System.Decimal)reader["COURSE_NO"];
					c.MaxWeeks = (System.Decimal)reader["MAX_WEEKS"];
					c.Absence = Convert.IsDBNull(reader["ABSENCE"]) ? null : (System.Decimal?)reader["ABSENCE"];
					c.ExcuseRequired = Convert.IsDBNull(reader["EXCUSE_REQUIRED"]) ? null : (System.Decimal?)reader["EXCUSE_REQUIRED"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyCourseChng entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyCourseChngId = (System.Decimal)reader[((int)EntPolicyCourseChngColumn.EntPolicyCourseChngId - 1)];
			entity.OriginalEntPolicyCourseChngId = (System.Decimal)reader["ENT_POLICY_COURSE_CHNG_ID"];
			entity.EdBylawId = (reader.IsDBNull(((int)EntPolicyCourseChngColumn.EdBylawId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseChngColumn.EdBylawId - 1)];
			entity.EdCodeCourseChngId = (System.Decimal)reader[((int)EntPolicyCourseChngColumn.EdCodeCourseChngId - 1)];
			entity.CourseNo = (System.Decimal)reader[((int)EntPolicyCourseChngColumn.CourseNo - 1)];
			entity.MaxWeeks = (System.Decimal)reader[((int)EntPolicyCourseChngColumn.MaxWeeks - 1)];
			entity.Absence = (reader.IsDBNull(((int)EntPolicyCourseChngColumn.Absence - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseChngColumn.Absence - 1)];
			entity.ExcuseRequired = (reader.IsDBNull(((int)EntPolicyCourseChngColumn.ExcuseRequired - 1)))?null:(System.Decimal?)reader[((int)EntPolicyCourseChngColumn.ExcuseRequired - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyCourseChng entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyCourseChngId = (System.Decimal)dataRow["ENT_POLICY_COURSE_CHNG_ID"];
			entity.OriginalEntPolicyCourseChngId = (System.Decimal)dataRow["ENT_POLICY_COURSE_CHNG_ID"];
			entity.EdBylawId = Convert.IsDBNull(dataRow["ED_BYLAW_ID"]) ? null : (System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.EdCodeCourseChngId = (System.Decimal)dataRow["ED_CODE_COURSE_CHNG_ID"];
			entity.CourseNo = (System.Decimal)dataRow["COURSE_NO"];
			entity.MaxWeeks = (System.Decimal)dataRow["MAX_WEEKS"];
			entity.Absence = Convert.IsDBNull(dataRow["ABSENCE"]) ? null : (System.Decimal?)dataRow["ABSENCE"];
			entity.ExcuseRequired = Convert.IsDBNull(dataRow["EXCUSE_REQUIRED"]) ? null : (System.Decimal?)dataRow["EXCUSE_REQUIRED"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyCourseChng"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyCourseChng Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseChng entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdBylawId ?? 0.0m);
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, (entity.EdBylawId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource

			#region EdCodeCourseChngIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseChng|EdCodeCourseChngIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseChngIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeCourseChngId;
				EdCodeCourseChng tmpEntity = EntityManager.LocateEntity<EdCodeCourseChng>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseChng), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseChngIdSource = tmpEntity;
				else
					entity.EdCodeCourseChngIdSource = DataRepository.EdCodeCourseChngProvider.GetByEdCodeCourseChngId(transactionManager, entity.EdCodeCourseChngId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseChngIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseChngIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseChngProvider.DeepLoad(transactionManager, entity.EdCodeCourseChngIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseChngIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyCourseChng object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyCourseChng instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyCourseChng Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyCourseChng entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			
			#region EdCodeCourseChngIdSource
			if (CanDeepSave(entity, "EdCodeCourseChng|EdCodeCourseChngIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseChngIdSource != null)
			{
				DataRepository.EdCodeCourseChngProvider.Save(transactionManager, entity.EdCodeCourseChngIdSource);
				entity.EdCodeCourseChngId = entity.EdCodeCourseChngIdSource.EdCodeCourseChngId;
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
	
	#region EntPolicyCourseChngChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyCourseChng</c>
	///</summary>
	public enum EntPolicyCourseChngChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseChng</c> at EdCodeCourseChngIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseChng))]
		EdCodeCourseChng,
	}
	
	#endregion EntPolicyCourseChngChildEntityTypes
	
	#region EntPolicyCourseChngFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyCourseChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyCourseChngFilterBuilder : SqlFilterBuilder<EntPolicyCourseChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseChngFilterBuilder class.
		/// </summary>
		public EntPolicyCourseChngFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyCourseChngFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseChngFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyCourseChngFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyCourseChngFilterBuilder
	
	#region EntPolicyCourseChngParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyCourseChng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyCourseChngParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyCourseChngColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseChngParameterBuilder class.
		/// </summary>
		public EntPolicyCourseChngParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyCourseChngParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseChngParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyCourseChngParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyCourseChngParameterBuilder
	
	#region EntPolicyCourseChngSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyCourseChngColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyCourseChng"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyCourseChngSortBuilder : SqlSortBuilder<EntPolicyCourseChngColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyCourseChngSqlSortBuilder class.
		/// </summary>
		public EntPolicyCourseChngSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyCourseChngSortBuilder
	
} // end namespace
