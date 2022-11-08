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
	/// This class is the base class for any <see cref="EdStudCourseRegPolcyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegPolcyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy, UMIS_VER2.BusinessLyer.EdStudCourseRegPolcyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegPolcyKey key)
		{
			return Delete(transactionManager, key.EdStudCourseRegPolcyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseRegPolcyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseRegPolcyId)
		{
			return Delete(null, _edStudCourseRegPolcyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegPolcyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseRegPolcyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegPolcy> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG key.
		///		fkEdStudCourseRegPolcyEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG key.
		///		fkEdStudCourseRegPolcyEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public abstract TList<EdStudCourseRegPolcy> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR Description: 
		/// </summary>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEntPolcyGrdngHdrId(System.Decimal _entPolcyGrdngHdrId)
		{
			int count = -1;
			return GetByEntPolcyGrdngHdrId(_entPolcyGrdngHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegPolcy> GetByEntPolcyGrdngHdrId(TransactionManager transactionManager, System.Decimal _entPolcyGrdngHdrId)
		{
			int count = -1;
			return GetByEntPolcyGrdngHdrId(transactionManager, _entPolcyGrdngHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEntPolcyGrdngHdrId(TransactionManager transactionManager, System.Decimal _entPolcyGrdngHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolcyGrdngHdrId(transactionManager, _entPolcyGrdngHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR key.
		///		fkEdStudCourseRegPolcyEntPolcyGrdngHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEntPolcyGrdngHdrId(System.Decimal _entPolcyGrdngHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPolcyGrdngHdrId(null, _entPolcyGrdngHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR key.
		///		fkEdStudCourseRegPolcyEntPolcyGrdngHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public TList<EdStudCourseRegPolcy> GetByEntPolcyGrdngHdrId(System.Decimal _entPolcyGrdngHdrId, int start, int pageLength,out int count)
		{
			return GetByEntPolcyGrdngHdrId(null, _entPolcyGrdngHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR key.
		///		FK_ED_STUD_COURSE_REG_POLCY_ENT_POLCY_GRDNG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolcyGrdngHdrId">قواعد الرصد المؤقتة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy objects.</returns>
		public abstract TList<EdStudCourseRegPolcy> GetByEntPolcyGrdngHdrId(TransactionManager transactionManager, System.Decimal _entPolcyGrdngHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegPolcyKey key, int start, int pageLength)
		{
			return GetByEdStudCourseRegPolcyId(transactionManager, key.EdStudCourseRegPolcyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_COURSE_REG_POLCY index.
		/// </summary>
		/// <param name="_edStudCourseRegPolcyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy GetByEdStudCourseRegPolcyId(System.Decimal _edStudCourseRegPolcyId)
		{
			int count = -1;
			return GetByEdStudCourseRegPolcyId(null,_edStudCourseRegPolcyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_POLCY index.
		/// </summary>
		/// <param name="_edStudCourseRegPolcyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy GetByEdStudCourseRegPolcyId(System.Decimal _edStudCourseRegPolcyId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegPolcyId(null, _edStudCourseRegPolcyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_POLCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegPolcyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy GetByEdStudCourseRegPolcyId(TransactionManager transactionManager, System.Decimal _edStudCourseRegPolcyId)
		{
			int count = -1;
			return GetByEdStudCourseRegPolcyId(transactionManager, _edStudCourseRegPolcyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_POLCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegPolcyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy GetByEdStudCourseRegPolcyId(TransactionManager transactionManager, System.Decimal _edStudCourseRegPolcyId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegPolcyId(transactionManager, _edStudCourseRegPolcyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_POLCY index.
		/// </summary>
		/// <param name="_edStudCourseRegPolcyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy GetByEdStudCourseRegPolcyId(System.Decimal _edStudCourseRegPolcyId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegPolcyId(null, _edStudCourseRegPolcyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_POLCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegPolcyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy GetByEdStudCourseRegPolcyId(TransactionManager transactionManager, System.Decimal _edStudCourseRegPolcyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseRegPolcy&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseRegPolcy&gt;"/></returns>
		public static TList<EdStudCourseRegPolcy> Fill(IDataReader reader, TList<EdStudCourseRegPolcy> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseRegPolcy")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_REG_POLCY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseRegPolcy>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseRegPolcy",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy();
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
					c.EdStudCourseRegPolcyId = (System.Decimal)reader["ED_STUD_COURSE_REG_POLCY_ID"];
					c.OriginalEdStudCourseRegPolcyId = c.EdStudCourseRegPolcyId;
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.EntPolcyGrdngHdrId = (System.Decimal)reader["ENT_POLCY_GRDNG_HDR_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseRegPolcyId = (System.Decimal)reader[((int)EdStudCourseRegPolcyColumn.EdStudCourseRegPolcyId - 1)];
			entity.OriginalEdStudCourseRegPolcyId = (System.Decimal)reader["ED_STUD_COURSE_REG_POLCY_ID"];
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStudCourseRegPolcyColumn.EdStudCourseRegId - 1)];
			entity.EntPolcyGrdngHdrId = (System.Decimal)reader[((int)EdStudCourseRegPolcyColumn.EntPolcyGrdngHdrId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseRegPolcyId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_POLCY_ID"];
			entity.OriginalEdStudCourseRegPolcyId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_POLCY_ID"];
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.EntPolcyGrdngHdrId = (System.Decimal)dataRow["ENT_POLCY_GRDNG_HDR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudCourseRegId;
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegProvider.DeepLoad(transactionManager, entity.EdStudCourseRegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegIdSource

			#region EntPolcyGrdngHdrIdSource	
			if (CanDeepLoad(entity, "EntPolcyGrdngHdr|EntPolcyGrdngHdrIdSource", deepLoadType, innerList) 
				&& entity.EntPolcyGrdngHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPolcyGrdngHdrId;
				EntPolcyGrdngHdr tmpEntity = EntityManager.LocateEntity<EntPolcyGrdngHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolcyGrdngHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolcyGrdngHdrIdSource = tmpEntity;
				else
					entity.EntPolcyGrdngHdrIdSource = DataRepository.EntPolcyGrdngHdrProvider.GetByEntPolcyGrdngHdrId(transactionManager, entity.EntPolcyGrdngHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolcyGrdngHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolcyGrdngHdrProvider.DeepLoad(transactionManager, entity.EntPolcyGrdngHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolcyGrdngHdrIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
			}
			#endregion 
			
			#region EntPolcyGrdngHdrIdSource
			if (CanDeepSave(entity, "EntPolcyGrdngHdr|EntPolcyGrdngHdrIdSource", deepSaveType, innerList) 
				&& entity.EntPolcyGrdngHdrIdSource != null)
			{
				DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrIdSource);
				entity.EntPolcyGrdngHdrId = entity.EntPolcyGrdngHdrIdSource.EntPolcyGrdngHdrId;
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
	
	#region EdStudCourseRegPolcyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseRegPolcy</c>
	///</summary>
	public enum EdStudCourseRegPolcyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		
		///<summary>
		/// Composite Property for <c>EntPolcyGrdngHdr</c> at EntPolcyGrdngHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolcyGrdngHdr))]
		EntPolcyGrdngHdr,
	}
	
	#endregion EdStudCourseRegPolcyChildEntityTypes
	
	#region EdStudCourseRegPolcyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseRegPolcyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegPolcy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegPolcyFilterBuilder : SqlFilterBuilder<EdStudCourseRegPolcyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPolcyFilterBuilder class.
		/// </summary>
		public EdStudCourseRegPolcyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPolcyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegPolcyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPolcyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegPolcyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegPolcyFilterBuilder
	
	#region EdStudCourseRegPolcyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseRegPolcyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegPolcy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegPolcyParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseRegPolcyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPolcyParameterBuilder class.
		/// </summary>
		public EdStudCourseRegPolcyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPolcyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegPolcyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPolcyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegPolcyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegPolcyParameterBuilder
	
	#region EdStudCourseRegPolcySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseRegPolcyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegPolcy"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseRegPolcySortBuilder : SqlSortBuilder<EdStudCourseRegPolcyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegPolcySqlSortBuilder class.
		/// </summary>
		public EdStudCourseRegPolcySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseRegPolcySortBuilder
	
} // end namespace
