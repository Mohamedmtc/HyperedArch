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
	/// This class is the base class for any <see cref="EdStudCourseCompProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseCompProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseComp, UMIS_VER2.BusinessLyer.EdStudCourseCompKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseCompKey key)
		{
			return Delete(transactionManager, key.EdStudCourseCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseCompId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseCompId)
		{
			return Delete(null, _edStudCourseCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseCompId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseCompId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseComp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseCompKey key, int start, int pageLength)
		{
			return GetByEdStudCourseCompId(transactionManager, key.EdStudCourseCompId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_CDE_COURSE_COMP__1 index.
		/// </summary>
		/// <param name="_admCdeCourseCompId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(null,_admCdeCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_COURSE_COMP__1 index.
		/// </summary>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(null, _admCdeCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_COURSE_COMP__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(transactionManager, _admCdeCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_COURSE_COMP__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeCourseCompId(transactionManager, _admCdeCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_COURSE_COMP__1 index.
		/// </summary>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeCourseCompId(null, _admCdeCourseCompId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_CDE_COURSE_COMP__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public abstract TList<EdStudCourseComp> GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public abstract TList<EdStudCourseComp> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_COURSE_COMP index.
		/// </summary>
		/// <param name="_edStudCourseCompId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseComp GetByEdStudCourseCompId(System.Decimal _edStudCourseCompId)
		{
			int count = -1;
			return GetByEdStudCourseCompId(null,_edStudCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_COMP index.
		/// </summary>
		/// <param name="_edStudCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseComp GetByEdStudCourseCompId(System.Decimal _edStudCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseCompId(null, _edStudCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseCompId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseComp GetByEdStudCourseCompId(TransactionManager transactionManager, System.Decimal _edStudCourseCompId)
		{
			int count = -1;
			return GetByEdStudCourseCompId(transactionManager, _edStudCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseComp GetByEdStudCourseCompId(TransactionManager transactionManager, System.Decimal _edStudCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseCompId(transactionManager, _edStudCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_COMP index.
		/// </summary>
		/// <param name="_edStudCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseComp GetByEdStudCourseCompId(System.Decimal _edStudCourseCompId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseCompId(null, _edStudCourseCompId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseComp GetByEdStudCourseCompId(TransactionManager transactionManager, System.Decimal _edStudCourseCompId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public TList<EdStudCourseComp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudCourseComp&gt;"/> class.</returns>
		public abstract TList<EdStudCourseComp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseComp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseComp&gt;"/></returns>
		public static TList<EdStudCourseComp> Fill(IDataReader reader, TList<EdStudCourseComp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseComp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseComp")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_COMP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseComp>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseComp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseComp();
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
					c.EdStudCourseCompId = (System.Decimal)reader["ED_STUD_COURSE_COMP_ID"];
					c.OriginalEdStudCourseCompId = c.EdStudCourseCompId;
					c.IsCompleted = (System.Decimal)reader["IS_COMPLETED"];
					c.CompDate = Convert.IsDBNull(reader["COMP_DATE"]) ? null : (System.DateTime?)reader["COMP_DATE"];
					c.StudDegree = Convert.IsDBNull(reader["STUD_DEGREE"]) ? null : (System.Decimal?)reader["STUD_DEGREE"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.AdmCdeCourseCompId = (System.Decimal)reader["ADM_CDE_COURSE_COMP_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseComp entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseCompId = (System.Decimal)reader[((int)EdStudCourseCompColumn.EdStudCourseCompId - 1)];
			entity.OriginalEdStudCourseCompId = (System.Decimal)reader["ED_STUD_COURSE_COMP_ID"];
			entity.IsCompleted = (System.Decimal)reader[((int)EdStudCourseCompColumn.IsCompleted - 1)];
			entity.CompDate = (reader.IsDBNull(((int)EdStudCourseCompColumn.CompDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCourseCompColumn.CompDate - 1)];
			entity.StudDegree = (reader.IsDBNull(((int)EdStudCourseCompColumn.StudDegree - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseCompColumn.StudDegree - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudCourseCompColumn.EdStudId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdStudCourseCompColumn.AsFacultyInfoId - 1)];
			entity.AdmCdeCourseCompId = (System.Decimal)reader[((int)EdStudCourseCompColumn.AdmCdeCourseCompId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseComp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseCompId = (System.Decimal)dataRow["ED_STUD_COURSE_COMP_ID"];
			entity.OriginalEdStudCourseCompId = (System.Decimal)dataRow["ED_STUD_COURSE_COMP_ID"];
			entity.IsCompleted = (System.Decimal)dataRow["IS_COMPLETED"];
			entity.CompDate = Convert.IsDBNull(dataRow["COMP_DATE"]) ? null : (System.DateTime?)dataRow["COMP_DATE"];
			entity.StudDegree = Convert.IsDBNull(dataRow["STUD_DEGREE"]) ? null : (System.Decimal?)dataRow["STUD_DEGREE"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.AdmCdeCourseCompId = (System.Decimal)dataRow["ADM_CDE_COURSE_COMP_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseComp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseComp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseComp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeCourseCompIdSource	
			if (CanDeepLoad(entity, "AdmCdeCourseComp|AdmCdeCourseCompIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeCourseCompIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeCourseCompId;
				AdmCdeCourseComp tmpEntity = EntityManager.LocateEntity<AdmCdeCourseComp>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeCourseComp), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeCourseCompIdSource = tmpEntity;
				else
					entity.AdmCdeCourseCompIdSource = DataRepository.AdmCdeCourseCompProvider.GetByAdmCdeCourseCompId(transactionManager, entity.AdmCdeCourseCompId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeCourseCompIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeCourseCompIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeCourseCompProvider.DeepLoad(transactionManager, entity.AdmCdeCourseCompIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeCourseCompIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseComp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseComp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseComp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseComp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeCourseCompIdSource
			if (CanDeepSave(entity, "AdmCdeCourseComp|AdmCdeCourseCompIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeCourseCompIdSource != null)
			{
				DataRepository.AdmCdeCourseCompProvider.Save(transactionManager, entity.AdmCdeCourseCompIdSource);
				entity.AdmCdeCourseCompId = entity.AdmCdeCourseCompIdSource.AdmCdeCourseCompId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
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
	
	#region EdStudCourseCompChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseComp</c>
	///</summary>
	public enum EdStudCourseCompChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeCourseComp</c> at AdmCdeCourseCompIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeCourseComp))]
		AdmCdeCourseComp,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
	}
	
	#endregion EdStudCourseCompChildEntityTypes
	
	#region EdStudCourseCompFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseCompFilterBuilder : SqlFilterBuilder<EdStudCourseCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseCompFilterBuilder class.
		/// </summary>
		public EdStudCourseCompFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseCompFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseCompFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseCompFilterBuilder
	
	#region EdStudCourseCompParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseCompParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseCompParameterBuilder class.
		/// </summary>
		public EdStudCourseCompParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseCompParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseCompParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseCompParameterBuilder
	
	#region EdStudCourseCompSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseComp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseCompSortBuilder : SqlSortBuilder<EdStudCourseCompColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseCompSqlSortBuilder class.
		/// </summary>
		public EdStudCourseCompSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseCompSortBuilder
	
} // end namespace
