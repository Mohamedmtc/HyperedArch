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
	/// This class is the base class for any <see cref="EdStudQualGroupProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudQualGroupProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudQualGroup, UMIS_VER2.BusinessLyer.EdStudQualGroupKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualGroupKey key)
		{
			return Delete(transactionManager, key.EdStudQualGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudQualGroupId)
		{
			return Delete(null, _edStudQualGroupId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudQualGroupId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdCodeQualGroupId(System.Decimal _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(_edCodeQualGroupId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQualGroup> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal _edCodeQualGroupId)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal _edCodeQualGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualGroupId(transactionManager, _edCodeQualGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP key.
		///		fkEdStudQualGroupEdCodeQualGroup Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdCodeQualGroupId(System.Decimal _edCodeQualGroupId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP key.
		///		fkEdStudQualGroupEdCodeQualGroup Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdCodeQualGroupId(System.Decimal _edCodeQualGroupId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualGroupId(null, _edCodeQualGroupId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP key.
		///		FK_ED_STUD_QUAL_GROUP_ED_CODE_QUAL_GROUP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualGroupId">SAT1-Sat2-OL-AS-AL</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public abstract TList<EdStudQualGroup> GetByEdCodeQualGroupId(TransactionManager transactionManager, System.Decimal _edCodeQualGroupId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="_edStudQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdStudQualId(System.Decimal _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(_edStudQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudQualGroup> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal _edStudQualId)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal _edStudQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualId(transactionManager, _edStudQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL key.
		///		fkEdStudQualGroupEdStudQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdStudQualId(System.Decimal _edStudQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL key.
		///		fkEdStudQualGroupEdStudQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public TList<EdStudQualGroup> GetByEdStudQualId(System.Decimal _edStudQualId, int start, int pageLength,out int count)
		{
			return GetByEdStudQualId(null, _edStudQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL key.
		///		FK_ED_STUD_QUAL_GROUP_ED_STUD_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudQualGroup objects.</returns>
		public abstract TList<EdStudQualGroup> GetByEdStudQualId(TransactionManager transactionManager, System.Decimal _edStudQualId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudQualGroup Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualGroupKey key, int start, int pageLength)
		{
			return GetByEdStudQualGroupId(transactionManager, key.EdStudQualGroupId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_QUAL_GROUP index.
		/// </summary>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualGroup GetByEdStudQualGroupId(System.Decimal _edStudQualGroupId)
		{
			int count = -1;
			return GetByEdStudQualGroupId(null,_edStudQualGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_GROUP index.
		/// </summary>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualGroup GetByEdStudQualGroupId(System.Decimal _edStudQualGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualGroupId(null, _edStudQualGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualGroup GetByEdStudQualGroupId(TransactionManager transactionManager, System.Decimal _edStudQualGroupId)
		{
			int count = -1;
			return GetByEdStudQualGroupId(transactionManager, _edStudQualGroupId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualGroup GetByEdStudQualGroupId(TransactionManager transactionManager, System.Decimal _edStudQualGroupId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudQualGroupId(transactionManager, _edStudQualGroupId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_GROUP index.
		/// </summary>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudQualGroup GetByEdStudQualGroupId(System.Decimal _edStudQualGroupId, int start, int pageLength, out int count)
		{
			return GetByEdStudQualGroupId(null, _edStudQualGroupId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_QUAL_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudQualGroupId">مجموعات مؤهل الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudQualGroup GetByEdStudQualGroupId(TransactionManager transactionManager, System.Decimal _edStudQualGroupId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudQualGroup&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudQualGroup&gt;"/></returns>
		public static TList<EdStudQualGroup> Fill(IDataReader reader, TList<EdStudQualGroup> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudQualGroup c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudQualGroup")
					.Append("|").Append((System.Decimal)reader["ED_STUD_QUAL_GROUP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudQualGroup>(
					key.ToString(), // EntityTrackingKey
					"EdStudQualGroup",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudQualGroup();
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
					c.EdStudQualGroupId = (System.Decimal)reader["ED_STUD_QUAL_GROUP_ID"];
					c.OriginalEdStudQualGroupId = c.EdStudQualGroupId;
					c.EdStudQualId = (System.Decimal)reader["ED_STUD_QUAL_ID"];
					c.EdCodeQualGroupId = (System.Decimal)reader["ED_CODE_QUAL_GROUP_ID"];
					c.AdmCdeExamGrdngId = Convert.IsDBNull(reader["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_EXAM_GRDNG_ID"];
					c.StudGrpMark = Convert.IsDBNull(reader["STUD_GRP_MARK"]) ? null : (System.Decimal?)reader["STUD_GRP_MARK"];
					c.GrpPrcnt = Convert.IsDBNull(reader["GRP_PRCNT"]) ? null : (System.Decimal?)reader["GRP_PRCNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudQualGroup entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudQualGroupId = (System.Decimal)reader[((int)EdStudQualGroupColumn.EdStudQualGroupId - 1)];
			entity.OriginalEdStudQualGroupId = (System.Decimal)reader["ED_STUD_QUAL_GROUP_ID"];
			entity.EdStudQualId = (System.Decimal)reader[((int)EdStudQualGroupColumn.EdStudQualId - 1)];
			entity.EdCodeQualGroupId = (System.Decimal)reader[((int)EdStudQualGroupColumn.EdCodeQualGroupId - 1)];
			entity.AdmCdeExamGrdngId = (reader.IsDBNull(((int)EdStudQualGroupColumn.AdmCdeExamGrdngId - 1)))?null:(System.Decimal?)reader[((int)EdStudQualGroupColumn.AdmCdeExamGrdngId - 1)];
			entity.StudGrpMark = (reader.IsDBNull(((int)EdStudQualGroupColumn.StudGrpMark - 1)))?null:(System.Decimal?)reader[((int)EdStudQualGroupColumn.StudGrpMark - 1)];
			entity.GrpPrcnt = (reader.IsDBNull(((int)EdStudQualGroupColumn.GrpPrcnt - 1)))?null:(System.Decimal?)reader[((int)EdStudQualGroupColumn.GrpPrcnt - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudQualGroup entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudQualGroupId = (System.Decimal)dataRow["ED_STUD_QUAL_GROUP_ID"];
			entity.OriginalEdStudQualGroupId = (System.Decimal)dataRow["ED_STUD_QUAL_GROUP_ID"];
			entity.EdStudQualId = (System.Decimal)dataRow["ED_STUD_QUAL_ID"];
			entity.EdCodeQualGroupId = (System.Decimal)dataRow["ED_CODE_QUAL_GROUP_ID"];
			entity.AdmCdeExamGrdngId = Convert.IsDBNull(dataRow["ADM_CDE_EXAM_GRDNG_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_EXAM_GRDNG_ID"];
			entity.StudGrpMark = Convert.IsDBNull(dataRow["STUD_GRP_MARK"]) ? null : (System.Decimal?)dataRow["STUD_GRP_MARK"];
			entity.GrpPrcnt = Convert.IsDBNull(dataRow["GRP_PRCNT"]) ? null : (System.Decimal?)dataRow["GRP_PRCNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudQualGroup"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudQualGroup Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualGroup entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeQualGroupIdSource	
			if (CanDeepLoad(entity, "EdCodeQualGroup|EdCodeQualGroupIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualGroupIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeQualGroupId;
				EdCodeQualGroup tmpEntity = EntityManager.LocateEntity<EdCodeQualGroup>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQualGroup), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualGroupIdSource = tmpEntity;
				else
					entity.EdCodeQualGroupIdSource = DataRepository.EdCodeQualGroupProvider.GetByEdCodeQualGroupId(transactionManager, entity.EdCodeQualGroupId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualGroupIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualGroupIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualGroupProvider.DeepLoad(transactionManager, entity.EdCodeQualGroupIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualGroupIdSource

			#region EdStudQualIdSource	
			if (CanDeepLoad(entity, "EdStudQual|EdStudQualIdSource", deepLoadType, innerList) 
				&& entity.EdStudQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudQualId;
				EdStudQual tmpEntity = EntityManager.LocateEntity<EdStudQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudQualIdSource = tmpEntity;
				else
					entity.EdStudQualIdSource = DataRepository.EdStudQualProvider.GetByEdStudQualId(transactionManager, entity.EdStudQualId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudQualProvider.DeepLoad(transactionManager, entity.EdStudQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudQualIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudQualGroup object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudQualGroup instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudQualGroup Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQualGroup entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeQualGroupIdSource
			if (CanDeepSave(entity, "EdCodeQualGroup|EdCodeQualGroupIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualGroupIdSource != null)
			{
				DataRepository.EdCodeQualGroupProvider.Save(transactionManager, entity.EdCodeQualGroupIdSource);
				entity.EdCodeQualGroupId = entity.EdCodeQualGroupIdSource.EdCodeQualGroupId;
			}
			#endregion 
			
			#region EdStudQualIdSource
			if (CanDeepSave(entity, "EdStudQual|EdStudQualIdSource", deepSaveType, innerList) 
				&& entity.EdStudQualIdSource != null)
			{
				DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualIdSource);
				entity.EdStudQualId = entity.EdStudQualIdSource.EdStudQualId;
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
	
	#region EdStudQualGroupChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudQualGroup</c>
	///</summary>
	public enum EdStudQualGroupChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeQualGroup</c> at EdCodeQualGroupIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQualGroup))]
		EdCodeQualGroup,
		
		///<summary>
		/// Composite Property for <c>EdStudQual</c> at EdStudQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudQual))]
		EdStudQual,
	}
	
	#endregion EdStudQualGroupChildEntityTypes
	
	#region EdStudQualGroupFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudQualGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQualGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudQualGroupFilterBuilder : SqlFilterBuilder<EdStudQualGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualGroupFilterBuilder class.
		/// </summary>
		public EdStudQualGroupFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudQualGroupFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualGroupFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudQualGroupFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudQualGroupFilterBuilder
	
	#region EdStudQualGroupParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudQualGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQualGroup"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudQualGroupParameterBuilder : ParameterizedSqlFilterBuilder<EdStudQualGroupColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualGroupParameterBuilder class.
		/// </summary>
		public EdStudQualGroupParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudQualGroupParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudQualGroupParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudQualGroupParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudQualGroupParameterBuilder
	
	#region EdStudQualGroupSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudQualGroupColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudQualGroup"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudQualGroupSortBuilder : SqlSortBuilder<EdStudQualGroupColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudQualGroupSqlSortBuilder class.
		/// </summary>
		public EdStudQualGroupSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudQualGroupSortBuilder
	
} // end namespace
