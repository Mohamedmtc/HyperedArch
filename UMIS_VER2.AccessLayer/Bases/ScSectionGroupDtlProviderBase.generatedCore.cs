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
	/// This class is the base class for any <see cref="ScSectionGroupDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSectionGroupDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScSectionGroupDtl, UMIS_VER2.BusinessLyer.ScSectionGroupDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupDtlKey key)
		{
			return Delete(transactionManager, key.ScSectionGroupDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scSectionGroupDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scSectionGroupDtlId)
		{
			return Delete(null, _scSectionGroupDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scSectionGroupDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR key.
		///		FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR Description: 
		/// </summary>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(_scSectionGroupHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR key.
		///		FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupDtl> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR key.
		///		FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSectionGroupHdrId(transactionManager, _scSectionGroupHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR key.
		///		fkEdSectionGroupEdSecGrpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR key.
		///		fkEdSectionGroupEdSecGrpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScSectionGroupHdrId(System.Decimal _scSectionGroupHdrId, int start, int pageLength,out int count)
		{
			return GetByScSectionGroupHdrId(null, _scSectionGroupHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR key.
		///		FK_ED_SECTION_GROUP_ED_SEC_GRP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public abstract TList<ScSectionGroupDtl> GetByScSectionGroupHdrId(TransactionManager transactionManager, System.Decimal _scSectionGroupHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_ED_COURSE key.
		///		fkScSectionGroupDtlEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_ED_COURSE key.
		///		fkScSectionGroupDtlEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_ED_COURSE key.
		///		FK_SC_SECTION_GROUP_DTL_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public abstract TList<ScSectionGroupDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		/// <remarks></remarks>
		public TList<ScSectionGroupDtl> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 key.
		///		fkScSectionGroupDtlScScheduleDtl1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 key.
		///		fkScSectionGroupDtlScScheduleDtl1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public TList<ScSectionGroupDtl> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SECTION_GROUP_DTL_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScSectionGroupDtl objects.</returns>
		public abstract TList<ScSectionGroupDtl> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScSectionGroupDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupDtlKey key, int start, int pageLength)
		{
			return GetByScSectionGroupDtlId(transactionManager, key.ScSectionGroupDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_SECTION_GROUP index.
		/// </summary>
		/// <param name="_scSectionGroupDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupDtl GetByScSectionGroupDtlId(System.Decimal _scSectionGroupDtlId)
		{
			int count = -1;
			return GetByScSectionGroupDtlId(null,_scSectionGroupDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SECTION_GROUP index.
		/// </summary>
		/// <param name="_scSectionGroupDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupDtl GetByScSectionGroupDtlId(System.Decimal _scSectionGroupDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSectionGroupDtlId(null, _scSectionGroupDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SECTION_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupDtl GetByScSectionGroupDtlId(TransactionManager transactionManager, System.Decimal _scSectionGroupDtlId)
		{
			int count = -1;
			return GetByScSectionGroupDtlId(transactionManager, _scSectionGroupDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SECTION_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupDtl GetByScSectionGroupDtlId(TransactionManager transactionManager, System.Decimal _scSectionGroupDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSectionGroupDtlId(transactionManager, _scSectionGroupDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SECTION_GROUP index.
		/// </summary>
		/// <param name="_scSectionGroupDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScSectionGroupDtl GetByScSectionGroupDtlId(System.Decimal _scSectionGroupDtlId, int start, int pageLength, out int count)
		{
			return GetByScSectionGroupDtlId(null, _scSectionGroupDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_SECTION_GROUP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSectionGroupDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScSectionGroupDtl GetByScSectionGroupDtlId(TransactionManager transactionManager, System.Decimal _scSectionGroupDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScSectionGroupDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScSectionGroupDtl&gt;"/></returns>
		public static TList<ScSectionGroupDtl> Fill(IDataReader reader, TList<ScSectionGroupDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScSectionGroupDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScSectionGroupDtl")
					.Append("|").Append((System.Decimal)reader["SC_SECTION_GROUP_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScSectionGroupDtl>(
					key.ToString(), // EntityTrackingKey
					"ScSectionGroupDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScSectionGroupDtl();
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
					c.ScSectionGroupDtlId = (System.Decimal)reader["SC_SECTION_GROUP_DTL_ID"];
					c.OriginalScSectionGroupDtlId = c.ScSectionGroupDtlId;
					c.ScSectionGroupHdrId = (System.Decimal)reader["SC_SECTION_GROUP_HDR_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScSectionGroupDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.ScSectionGroupDtlId = (System.Decimal)reader[((int)ScSectionGroupDtlColumn.ScSectionGroupDtlId - 1)];
			entity.OriginalScSectionGroupDtlId = (System.Decimal)reader["SC_SECTION_GROUP_DTL_ID"];
			entity.ScSectionGroupHdrId = (System.Decimal)reader[((int)ScSectionGroupDtlColumn.ScSectionGroupHdrId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)ScSectionGroupDtlColumn.EdCourseId - 1)];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)ScSectionGroupDtlColumn.ScScheduleDtlId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScSectionGroupDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScSectionGroupDtlId = (System.Decimal)dataRow["SC_SECTION_GROUP_DTL_ID"];
			entity.OriginalScSectionGroupDtlId = (System.Decimal)dataRow["SC_SECTION_GROUP_DTL_ID"];
			entity.ScSectionGroupHdrId = (System.Decimal)dataRow["SC_SECTION_GROUP_HDR_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScSectionGroupDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSectionGroupDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScSectionGroupHdrIdSource	
			if (CanDeepLoad(entity, "ScSectionGroupHdr|ScSectionGroupHdrIdSource", deepLoadType, innerList) 
				&& entity.ScSectionGroupHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScSectionGroupHdrId;
				ScSectionGroupHdr tmpEntity = EntityManager.LocateEntity<ScSectionGroupHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(ScSectionGroupHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScSectionGroupHdrIdSource = tmpEntity;
				else
					entity.ScSectionGroupHdrIdSource = DataRepository.ScSectionGroupHdrProvider.GetByScSectionGroupHdrId(transactionManager, entity.ScSectionGroupHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScSectionGroupHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScSectionGroupHdrProvider.DeepLoad(transactionManager, entity.ScSectionGroupHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScSectionGroupHdrIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
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

			#region ScScheduleDtlIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScScheduleDtlId;
				ScScheduleDtl tmpEntity = EntityManager.LocateEntity<ScScheduleDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlIdSource = tmpEntity;
				else
					entity.ScScheduleDtlIdSource = DataRepository.ScScheduleDtlProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlProvider.DeepLoad(transactionManager, entity.ScScheduleDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScSectionGroupDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScSectionGroupDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScSectionGroupDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScSectionGroupDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ScSectionGroupHdrIdSource
			if (CanDeepSave(entity, "ScSectionGroupHdr|ScSectionGroupHdrIdSource", deepSaveType, innerList) 
				&& entity.ScSectionGroupHdrIdSource != null)
			{
				DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrIdSource);
				entity.ScSectionGroupHdrId = entity.ScSectionGroupHdrIdSource.ScSectionGroupHdrId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region ScScheduleDtlIdSource
			if (CanDeepSave(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlIdSource != null)
			{
				DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlIdSource);
				entity.ScScheduleDtlId = entity.ScScheduleDtlIdSource.ScScheduleDtlId;
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
	
	#region ScSectionGroupDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScSectionGroupDtl</c>
	///</summary>
	public enum ScSectionGroupDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScSectionGroupHdr</c> at ScSectionGroupHdrIdSource
		///</summary>
		[ChildEntityType(typeof(ScSectionGroupHdr))]
		ScSectionGroupHdr,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
	}
	
	#endregion ScSectionGroupDtlChildEntityTypes
	
	#region ScSectionGroupDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScSectionGroupDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSectionGroupDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSectionGroupDtlFilterBuilder : SqlFilterBuilder<ScSectionGroupDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlFilterBuilder class.
		/// </summary>
		public ScSectionGroupDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSectionGroupDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSectionGroupDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSectionGroupDtlFilterBuilder
	
	#region ScSectionGroupDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScSectionGroupDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSectionGroupDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScSectionGroupDtlParameterBuilder : ParameterizedSqlFilterBuilder<ScSectionGroupDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlParameterBuilder class.
		/// </summary>
		public ScSectionGroupDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScSectionGroupDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScSectionGroupDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScSectionGroupDtlParameterBuilder
	
	#region ScSectionGroupDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScSectionGroupDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScSectionGroupDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScSectionGroupDtlSortBuilder : SqlSortBuilder<ScSectionGroupDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScSectionGroupDtlSqlSortBuilder class.
		/// </summary>
		public ScSectionGroupDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScSectionGroupDtlSortBuilder
	
} // end namespace
