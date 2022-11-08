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
	/// This class is the base class for any <see cref="EdStudGroupPreProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudGroupPreProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudGroupPre, UMIS_VER2.BusinessLyer.EdStudGroupPreKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGroupPreKey key)
		{
			return Delete(transactionManager, key.EdStudGroupPreId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudGroupPreId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudGroupPreId)
		{
			return Delete(null, _edStudGroupPreId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGroupPreId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudGroupPreId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO key.
		///		FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO key.
		///		FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGroupPre> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO key.
		///		FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO key.
		///		fkRdStudGroupPreAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO key.
		///		fkRdStudGroupPreAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO key.
		///		FK_RD_STUD_GROUP_PRE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public abstract TList<EdStudGroupPre> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL key.
		///		FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL key.
		///		FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudGroupPre> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL key.
		///		FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL key.
		///		fkRdStudGroupPreScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL key.
		///		fkRdStudGroupPreScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public TList<EdStudGroupPre> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL key.
		///		FK_RD_STUD_GROUP_PRE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudGroupPre objects.</returns>
		public abstract TList<EdStudGroupPre> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudGroupPre Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGroupPreKey key, int start, int pageLength)
		{
			return GetByEdStudGroupPreId(transactionManager, key.EdStudGroupPreId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_RD_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="_edStudGroupPreId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudGroupPreId(System.Decimal _edStudGroupPreId)
		{
			int count = -1;
			return GetByEdStudGroupPreId(null,_edStudGroupPreId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RD_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="_edStudGroupPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudGroupPreId(System.Decimal _edStudGroupPreId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudGroupPreId(null, _edStudGroupPreId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RD_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGroupPreId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudGroupPreId(TransactionManager transactionManager, System.Decimal _edStudGroupPreId)
		{
			int count = -1;
			return GetByEdStudGroupPreId(transactionManager, _edStudGroupPreId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RD_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGroupPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudGroupPreId(TransactionManager transactionManager, System.Decimal _edStudGroupPreId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudGroupPreId(transactionManager, _edStudGroupPreId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RD_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="_edStudGroupPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudGroupPreId(System.Decimal _edStudGroupPreId, int start, int pageLength, out int count)
		{
			return GetByEdStudGroupPreId(null, _edStudGroupPreId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RD_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudGroupPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudGroupPreId(TransactionManager transactionManager, System.Decimal _edStudGroupPreId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="_edStudCourseRegPreId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudCourseRegPreId(System.Decimal _edStudCourseRegPreId)
		{
			int count = -1;
			return GetByEdStudCourseRegPreId(null,_edStudCourseRegPreId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="_edStudCourseRegPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudCourseRegPreId(System.Decimal _edStudCourseRegPreId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegPreId(null, _edStudCourseRegPreId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegPreId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudCourseRegPreId(TransactionManager transactionManager, System.Decimal _edStudCourseRegPreId)
		{
			int count = -1;
			return GetByEdStudCourseRegPreId(transactionManager, _edStudCourseRegPreId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudCourseRegPreId(TransactionManager transactionManager, System.Decimal _edStudCourseRegPreId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegPreId(transactionManager, _edStudCourseRegPreId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="_edStudCourseRegPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudCourseRegPreId(System.Decimal _edStudCourseRegPreId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegPreId(null, _edStudCourseRegPreId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_GROUP_PRE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegPreId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudGroupPre GetByEdStudCourseRegPreId(TransactionManager transactionManager, System.Decimal _edStudCourseRegPreId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudGroupPre&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudGroupPre&gt;"/></returns>
		public static TList<EdStudGroupPre> Fill(IDataReader reader, TList<EdStudGroupPre> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudGroupPre c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudGroupPre")
					.Append("|").Append((System.Decimal)reader["ED_STUD_GROUP_PRE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudGroupPre>(
					key.ToString(), // EntityTrackingKey
					"EdStudGroupPre",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudGroupPre();
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
					c.EdStudGroupPreId = (System.Decimal)reader["ED_STUD_GROUP_PRE_ID"];
					c.OriginalEdStudGroupPreId = c.EdStudGroupPreId;
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EdStudCourseRegPreId = (System.Decimal)reader["ED_STUD_COURSE_REG_PRE_ID"];
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.WaitNo = Convert.IsDBNull(reader["WAIT_NO"]) ? null : (System.Decimal?)reader["WAIT_NO"];
					c.WaitReqDate = Convert.IsDBNull(reader["WAIT_REQ_DATE"]) ? null : (System.DateTime?)reader["WAIT_REQ_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudGroupPre entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudGroupPreId = (System.Decimal)reader[((int)EdStudGroupPreColumn.EdStudGroupPreId - 1)];
			entity.OriginalEdStudGroupPreId = (System.Decimal)reader["ED_STUD_GROUP_PRE_ID"];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdStudGroupPreColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdStudGroupPreColumn.AsFacultyInfoId - 1)];
			entity.EdStudCourseRegPreId = (System.Decimal)reader[((int)EdStudGroupPreColumn.EdStudCourseRegPreId - 1)];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)EdStudGroupPreColumn.ScScheduleDtlId - 1)];
			entity.WaitNo = (reader.IsDBNull(((int)EdStudGroupPreColumn.WaitNo - 1)))?null:(System.Decimal?)reader[((int)EdStudGroupPreColumn.WaitNo - 1)];
			entity.WaitReqDate = (reader.IsDBNull(((int)EdStudGroupPreColumn.WaitReqDate - 1)))?null:(System.DateTime?)reader[((int)EdStudGroupPreColumn.WaitReqDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudGroupPre entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudGroupPreId = (System.Decimal)dataRow["ED_STUD_GROUP_PRE_ID"];
			entity.OriginalEdStudGroupPreId = (System.Decimal)dataRow["ED_STUD_GROUP_PRE_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudCourseRegPreId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_PRE_ID"];
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.WaitNo = Convert.IsDBNull(dataRow["WAIT_NO"]) ? null : (System.Decimal?)dataRow["WAIT_NO"];
			entity.WaitReqDate = Convert.IsDBNull(dataRow["WAIT_REQ_DATE"]) ? null : (System.DateTime?)dataRow["WAIT_REQ_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudGroupPre"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudGroupPre Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGroupPre entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region EdStudCourseRegPreIdSource	
			if (CanDeepLoad(entity, "EdStudCourseRegPre|EdStudCourseRegPreIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegPreIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudCourseRegPreId;
				EdStudCourseRegPre tmpEntity = EntityManager.LocateEntity<EdStudCourseRegPre>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseRegPre), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegPreIdSource = tmpEntity;
				else
					entity.EdStudCourseRegPreIdSource = DataRepository.EdStudCourseRegPreProvider.GetByEdStudCourseRegPreId(transactionManager, entity.EdStudCourseRegPreId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPreIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegPreIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegPreProvider.DeepLoad(transactionManager, entity.EdStudCourseRegPreIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegPreIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudGroupPre object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudGroupPre instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudGroupPre Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGroupPre entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdStudCourseRegPreIdSource
			if (CanDeepSave(entity, "EdStudCourseRegPre|EdStudCourseRegPreIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegPreIdSource != null)
			{
				DataRepository.EdStudCourseRegPreProvider.Save(transactionManager, entity.EdStudCourseRegPreIdSource);
				entity.EdStudCourseRegPreId = entity.EdStudCourseRegPreIdSource.EdStudCourseRegPreId;
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
	
	#region EdStudGroupPreChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudGroupPre</c>
	///</summary>
	public enum EdStudGroupPreChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseRegPre</c> at EdStudCourseRegPreIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseRegPre))]
		EdStudCourseRegPre,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
	}
	
	#endregion EdStudGroupPreChildEntityTypes
	
	#region EdStudGroupPreFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudGroupPreColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGroupPre"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudGroupPreFilterBuilder : SqlFilterBuilder<EdStudGroupPreColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGroupPreFilterBuilder class.
		/// </summary>
		public EdStudGroupPreFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudGroupPreFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudGroupPreFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudGroupPreFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudGroupPreFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudGroupPreFilterBuilder
	
	#region EdStudGroupPreParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudGroupPreColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGroupPre"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudGroupPreParameterBuilder : ParameterizedSqlFilterBuilder<EdStudGroupPreColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGroupPreParameterBuilder class.
		/// </summary>
		public EdStudGroupPreParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudGroupPreParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudGroupPreParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudGroupPreParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudGroupPreParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudGroupPreParameterBuilder
	
	#region EdStudGroupPreSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudGroupPreColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudGroupPre"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudGroupPreSortBuilder : SqlSortBuilder<EdStudGroupPreColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudGroupPreSqlSortBuilder class.
		/// </summary>
		public EdStudGroupPreSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudGroupPreSortBuilder
	
} // end namespace
