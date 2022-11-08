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
	/// This class is the base class for any <see cref="AdmAppCourseCompProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppCourseCompProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppCourseComp, UMIS_VER2.BusinessLyer.AdmAppCourseCompKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCourseCompKey key)
		{
			return Delete(transactionManager, key.AdmAppCourseCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppCourseCompId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppCourseCompId)
		{
			return Delete(null, _admAppCourseCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCourseCompId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppCourseCompId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppCourseComp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCourseCompKey key, int start, int pageLength)
		{
			return GetByAdmAppCourseCompId(transactionManager, key.AdmAppCourseCompId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_APP_COURSE_COMP_APPLICANT_COURSE_UK index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmApplicantIdAdmCdeCourseCompId(System.Decimal _admApplicantId, System.Decimal _admCdeCourseCompId)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeCourseCompId(null,_admApplicantId, _admCdeCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_COURSE_COMP_APPLICANT_COURSE_UK index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmApplicantIdAdmCdeCourseCompId(System.Decimal _admApplicantId, System.Decimal _admCdeCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeCourseCompId(null, _admApplicantId, _admCdeCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_COURSE_COMP_APPLICANT_COURSE_UK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmApplicantIdAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admApplicantId, System.Decimal _admCdeCourseCompId)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeCourseCompId(transactionManager, _admApplicantId, _admCdeCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_COURSE_COMP_APPLICANT_COURSE_UK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmApplicantIdAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admApplicantId, System.Decimal _admCdeCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeCourseCompId(transactionManager, _admApplicantId, _admCdeCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_COURSE_COMP_APPLICANT_COURSE_UK index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmApplicantIdAdmCdeCourseCompId(System.Decimal _admApplicantId, System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantIdAdmCdeCourseCompId(null, _admApplicantId, _admCdeCourseCompId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_COURSE_COMP_APPLICANT_COURSE_UK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeCourseCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmApplicantIdAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admApplicantId, System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(null,_admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public abstract TList<AdmAppCourseComp> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_CDE_COURSE_COMP__1 index.
		/// </summary>
		/// <param name="_admCdeCourseCompId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public TList<AdmAppCourseComp> GetByAdmCdeCourseCompId(System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppCourseComp&gt;"/> class.</returns>
		public abstract TList<AdmAppCourseComp> GetByAdmCdeCourseCompId(TransactionManager transactionManager, System.Decimal _admCdeCourseCompId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_COURSE_COMP index.
		/// </summary>
		/// <param name="_admAppCourseCompId">XX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmAppCourseCompId(System.Decimal _admAppCourseCompId)
		{
			int count = -1;
			return GetByAdmAppCourseCompId(null,_admAppCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COURSE_COMP index.
		/// </summary>
		/// <param name="_admAppCourseCompId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmAppCourseCompId(System.Decimal _admAppCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppCourseCompId(null, _admAppCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCourseCompId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmAppCourseCompId(TransactionManager transactionManager, System.Decimal _admAppCourseCompId)
		{
			int count = -1;
			return GetByAdmAppCourseCompId(transactionManager, _admAppCourseCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCourseCompId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmAppCourseCompId(TransactionManager transactionManager, System.Decimal _admAppCourseCompId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppCourseCompId(transactionManager, _admAppCourseCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COURSE_COMP index.
		/// </summary>
		/// <param name="_admAppCourseCompId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmAppCourseCompId(System.Decimal _admAppCourseCompId, int start, int pageLength, out int count)
		{
			return GetByAdmAppCourseCompId(null, _admAppCourseCompId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COURSE_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCourseCompId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppCourseComp GetByAdmAppCourseCompId(TransactionManager transactionManager, System.Decimal _admAppCourseCompId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppCourseComp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppCourseComp&gt;"/></returns>
		public static TList<AdmAppCourseComp> Fill(IDataReader reader, TList<AdmAppCourseComp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppCourseComp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppCourseComp")
					.Append("|").Append((System.Decimal)reader["ADM_APP_COURSE_COMP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppCourseComp>(
					key.ToString(), // EntityTrackingKey
					"AdmAppCourseComp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppCourseComp();
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
					c.AdmAppCourseCompId = (System.Decimal)reader["ADM_APP_COURSE_COMP_ID"];
					c.OriginalAdmAppCourseCompId = c.AdmAppCourseCompId;
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppCourseComp entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppCourseCompId = (System.Decimal)reader[((int)AdmAppCourseCompColumn.AdmAppCourseCompId - 1)];
			entity.OriginalAdmAppCourseCompId = (System.Decimal)reader["ADM_APP_COURSE_COMP_ID"];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppCourseCompColumn.AdmApplicantId - 1)];
			entity.AdmCdeCourseCompId = (System.Decimal)reader[((int)AdmAppCourseCompColumn.AdmCdeCourseCompId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppCourseComp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppCourseCompId = (System.Decimal)dataRow["ADM_APP_COURSE_COMP_ID"];
			entity.OriginalAdmAppCourseCompId = (System.Decimal)dataRow["ADM_APP_COURSE_COMP_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppCourseComp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppCourseComp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCourseComp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmApplicantId;
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmApplicantIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.AdmApplicantIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmApplicantIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppCourseComp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppCourseComp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppCourseComp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCourseComp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			
			#region AdmCdeCourseCompIdSource
			if (CanDeepSave(entity, "AdmCdeCourseComp|AdmCdeCourseCompIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeCourseCompIdSource != null)
			{
				DataRepository.AdmCdeCourseCompProvider.Save(transactionManager, entity.AdmCdeCourseCompIdSource);
				entity.AdmCdeCourseCompId = entity.AdmCdeCourseCompIdSource.AdmCdeCourseCompId;
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
	
	#region AdmAppCourseCompChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppCourseComp</c>
	///</summary>
	public enum AdmAppCourseCompChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AdmCdeCourseComp</c> at AdmCdeCourseCompIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeCourseComp))]
		AdmCdeCourseComp,
	}
	
	#endregion AdmAppCourseCompChildEntityTypes
	
	#region AdmAppCourseCompFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppCourseComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppCourseCompFilterBuilder : SqlFilterBuilder<AdmAppCourseCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompFilterBuilder class.
		/// </summary>
		public AdmAppCourseCompFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppCourseCompFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppCourseCompFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppCourseCompFilterBuilder
	
	#region AdmAppCourseCompParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppCourseComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppCourseCompParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppCourseCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompParameterBuilder class.
		/// </summary>
		public AdmAppCourseCompParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppCourseCompParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppCourseCompParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppCourseCompParameterBuilder
	
	#region AdmAppCourseCompSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppCourseCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppCourseComp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppCourseCompSortBuilder : SqlSortBuilder<AdmAppCourseCompColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompSqlSortBuilder class.
		/// </summary>
		public AdmAppCourseCompSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppCourseCompSortBuilder
	
} // end namespace
