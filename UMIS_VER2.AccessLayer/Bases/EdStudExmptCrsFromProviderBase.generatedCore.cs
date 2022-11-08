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
	/// This class is the base class for any <see cref="EdStudExmptCrsFromProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExmptCrsFromProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom, UMIS_VER2.BusinessLyer.EdStudExmptCrsFromKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsFromKey key)
		{
			return Delete(transactionManager, key.EdStudExmptCrsFromId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudExmptCrsFromId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudExmptCrsFromId)
		{
			return Delete(null, _edStudExmptCrsFromId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsFromId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudExmptCrsFromId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptCrsFrom> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE key.
		///		fkEdStudExmptCrsFromEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE key.
		///		fkEdStudExmptCrsFromEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public abstract TList<EdStudExmptCrsFrom> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="_edStudExmptReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(_edStudExmptReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudExmptCrsFrom> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptReqId(transactionManager, _edStudExmptReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ key.
		///		fkEdStudExmptCrsFromEdStudExmptReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ key.
		///		fkEdStudExmptCrsFromEdStudExmptReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public TList<EdStudExmptCrsFrom> GetByEdStudExmptReqId(System.Decimal _edStudExmptReqId, int start, int pageLength,out int count)
		{
			return GetByEdStudExmptReqId(null, _edStudExmptReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ key.
		///		FK_ED_STUD_EXMPT_CRS_FROM_ED_STUD_EXMPT_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom objects.</returns>
		public abstract TList<EdStudExmptCrsFrom> GetByEdStudExmptReqId(TransactionManager transactionManager, System.Decimal _edStudExmptReqId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsFromKey key, int start, int pageLength)
		{
			return GetByEdStudExmptCrsFromId(transactionManager, key.EdStudExmptCrsFromId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_EXMPT_CRS_FROM index.
		/// </summary>
		/// <param name="_edStudExmptCrsFromId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom GetByEdStudExmptCrsFromId(System.Decimal _edStudExmptCrsFromId)
		{
			int count = -1;
			return GetByEdStudExmptCrsFromId(null,_edStudExmptCrsFromId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_FROM index.
		/// </summary>
		/// <param name="_edStudExmptCrsFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom GetByEdStudExmptCrsFromId(System.Decimal _edStudExmptCrsFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptCrsFromId(null, _edStudExmptCrsFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_FROM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsFromId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom GetByEdStudExmptCrsFromId(TransactionManager transactionManager, System.Decimal _edStudExmptCrsFromId)
		{
			int count = -1;
			return GetByEdStudExmptCrsFromId(transactionManager, _edStudExmptCrsFromId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_FROM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom GetByEdStudExmptCrsFromId(TransactionManager transactionManager, System.Decimal _edStudExmptCrsFromId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudExmptCrsFromId(transactionManager, _edStudExmptCrsFromId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_FROM index.
		/// </summary>
		/// <param name="_edStudExmptCrsFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom GetByEdStudExmptCrsFromId(System.Decimal _edStudExmptCrsFromId, int start, int pageLength, out int count)
		{
			return GetByEdStudExmptCrsFromId(null, _edStudExmptCrsFromId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_EXMPT_CRS_FROM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudExmptCrsFromId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom GetByEdStudExmptCrsFromId(TransactionManager transactionManager, System.Decimal _edStudExmptCrsFromId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudExmptCrsFrom&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudExmptCrsFrom&gt;"/></returns>
		public static TList<EdStudExmptCrsFrom> Fill(IDataReader reader, TList<EdStudExmptCrsFrom> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudExmptCrsFrom")
					.Append("|").Append((System.Decimal)reader["ED_STUD_EXMPT_CRS_FROM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudExmptCrsFrom>(
					key.ToString(), // EntityTrackingKey
					"EdStudExmptCrsFrom",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom();
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
					c.EdStudExmptCrsFromId = (System.Decimal)reader["ED_STUD_EXMPT_CRS_FROM_ID"];
					c.OriginalEdStudExmptCrsFromId = c.EdStudExmptCrsFromId;
					c.EdStudExmptReqId = (System.Decimal)reader["ED_STUD_EXMPT_REQ_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.CrsCode = Convert.IsDBNull(reader["CRS_CODE"]) ? null : (System.String)reader["CRS_CODE"];
					c.CrsNameAr = Convert.IsDBNull(reader["CRS_NAME_AR"]) ? null : (System.String)reader["CRS_NAME_AR"];
					c.CrsNameEn = Convert.IsDBNull(reader["CRS_NAME_EN"]) ? null : (System.String)reader["CRS_NAME_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudExmptCrsFromId = (System.Decimal)reader[((int)EdStudExmptCrsFromColumn.EdStudExmptCrsFromId - 1)];
			entity.OriginalEdStudExmptCrsFromId = (System.Decimal)reader["ED_STUD_EXMPT_CRS_FROM_ID"];
			entity.EdStudExmptReqId = (System.Decimal)reader[((int)EdStudExmptCrsFromColumn.EdStudExmptReqId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)EdStudExmptCrsFromColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)EdStudExmptCrsFromColumn.EdCourseId - 1)];
			entity.CrsCode = (reader.IsDBNull(((int)EdStudExmptCrsFromColumn.CrsCode - 1)))?null:(System.String)reader[((int)EdStudExmptCrsFromColumn.CrsCode - 1)];
			entity.CrsNameAr = (reader.IsDBNull(((int)EdStudExmptCrsFromColumn.CrsNameAr - 1)))?null:(System.String)reader[((int)EdStudExmptCrsFromColumn.CrsNameAr - 1)];
			entity.CrsNameEn = (reader.IsDBNull(((int)EdStudExmptCrsFromColumn.CrsNameEn - 1)))?null:(System.String)reader[((int)EdStudExmptCrsFromColumn.CrsNameEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudExmptCrsFromId = (System.Decimal)dataRow["ED_STUD_EXMPT_CRS_FROM_ID"];
			entity.OriginalEdStudExmptCrsFromId = (System.Decimal)dataRow["ED_STUD_EXMPT_CRS_FROM_ID"];
			entity.EdStudExmptReqId = (System.Decimal)dataRow["ED_STUD_EXMPT_REQ_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.CrsCode = Convert.IsDBNull(dataRow["CRS_CODE"]) ? null : (System.String)dataRow["CRS_CODE"];
			entity.CrsNameAr = Convert.IsDBNull(dataRow["CRS_NAME_AR"]) ? null : (System.String)dataRow["CRS_NAME_AR"];
			entity.CrsNameEn = Convert.IsDBNull(dataRow["CRS_NAME_EN"]) ? null : (System.String)dataRow["CRS_NAME_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EdStudExmptReqIdSource	
			if (CanDeepLoad(entity, "EdStudExmptReq|EdStudExmptReqIdSource", deepLoadType, innerList) 
				&& entity.EdStudExmptReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudExmptReqId;
				EdStudExmptReq tmpEntity = EntityManager.LocateEntity<EdStudExmptReq>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudExmptReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudExmptReqIdSource = tmpEntity;
				else
					entity.EdStudExmptReqIdSource = DataRepository.EdStudExmptReqProvider.GetByEdStudExmptReqId(transactionManager, entity.EdStudExmptReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudExmptReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudExmptReqProvider.DeepLoad(transactionManager, entity.EdStudExmptReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudExmptReqIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EdStudExmptReqIdSource
			if (CanDeepSave(entity, "EdStudExmptReq|EdStudExmptReqIdSource", deepSaveType, innerList) 
				&& entity.EdStudExmptReqIdSource != null)
			{
				DataRepository.EdStudExmptReqProvider.Save(transactionManager, entity.EdStudExmptReqIdSource);
				entity.EdStudExmptReqId = entity.EdStudExmptReqIdSource.EdStudExmptReqId;
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
	
	#region EdStudExmptCrsFromChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudExmptCrsFrom</c>
	///</summary>
	public enum EdStudExmptCrsFromChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStudExmptReq</c> at EdStudExmptReqIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudExmptReq))]
		EdStudExmptReq,
	}
	
	#endregion EdStudExmptCrsFromChildEntityTypes
	
	#region EdStudExmptCrsFromFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudExmptCrsFromColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptCrsFrom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptCrsFromFilterBuilder : SqlFilterBuilder<EdStudExmptCrsFromColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsFromFilterBuilder class.
		/// </summary>
		public EdStudExmptCrsFromFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsFromFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptCrsFromFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsFromFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptCrsFromFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptCrsFromFilterBuilder
	
	#region EdStudExmptCrsFromParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudExmptCrsFromColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptCrsFrom"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudExmptCrsFromParameterBuilder : ParameterizedSqlFilterBuilder<EdStudExmptCrsFromColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsFromParameterBuilder class.
		/// </summary>
		public EdStudExmptCrsFromParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsFromParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudExmptCrsFromParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsFromParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudExmptCrsFromParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudExmptCrsFromParameterBuilder
	
	#region EdStudExmptCrsFromSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudExmptCrsFromColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudExmptCrsFrom"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudExmptCrsFromSortBuilder : SqlSortBuilder<EdStudExmptCrsFromColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudExmptCrsFromSqlSortBuilder class.
		/// </summary>
		public EdStudExmptCrsFromSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudExmptCrsFromSortBuilder
	
} // end namespace
