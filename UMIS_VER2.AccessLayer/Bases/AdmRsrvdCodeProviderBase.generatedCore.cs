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
	/// This class is the base class for any <see cref="AdmRsrvdCodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmRsrvdCodeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmRsrvdCode, UMIS_VER2.BusinessLyer.AdmRsrvdCodeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRsrvdCodeKey key)
		{
			return Delete(transactionManager, key.AdmRsrvdCodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admRsrvdCodeId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admRsrvdCodeId)
		{
			return Delete(null, _admRsrvdCodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRsrvdCodeId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admRsrvdCodeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRsrvdCode objects.</returns>
		public TList<AdmRsrvdCode> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRsrvdCode objects.</returns>
		/// <remarks></remarks>
		public TList<AdmRsrvdCode> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRsrvdCode objects.</returns>
		public TList<AdmRsrvdCode> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmRsrvdCodeAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRsrvdCode objects.</returns>
		public TList<AdmRsrvdCode> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmRsrvdCodeAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRsrvdCode objects.</returns>
		public TList<AdmRsrvdCode> GetByAdmOpenAcadSemesterId(System.Decimal _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_RSRVD_CODE_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmRsrvdCode objects.</returns>
		public abstract TList<AdmRsrvdCode> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmRsrvdCode Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRsrvdCodeKey key, int start, int pageLength)
		{
			return GetByAdmRsrvdCodeId(transactionManager, key.AdmRsrvdCodeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_APP_RESERVED_CODE_NonClusteredIndex-20131121-210855 index.
		/// </summary>
		/// <param name="_admAppReservedCode"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmAppReservedCode(System.String _admAppReservedCode)
		{
			int count = -1;
			return GetByAdmAppReservedCode(null,_admAppReservedCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_RESERVED_CODE_NonClusteredIndex-20131121-210855 index.
		/// </summary>
		/// <param name="_admAppReservedCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmAppReservedCode(System.String _admAppReservedCode, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppReservedCode(null, _admAppReservedCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_RESERVED_CODE_NonClusteredIndex-20131121-210855 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppReservedCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmAppReservedCode(TransactionManager transactionManager, System.String _admAppReservedCode)
		{
			int count = -1;
			return GetByAdmAppReservedCode(transactionManager, _admAppReservedCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_RESERVED_CODE_NonClusteredIndex-20131121-210855 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppReservedCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmAppReservedCode(TransactionManager transactionManager, System.String _admAppReservedCode, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppReservedCode(transactionManager, _admAppReservedCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_RESERVED_CODE_NonClusteredIndex-20131121-210855 index.
		/// </summary>
		/// <param name="_admAppReservedCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmAppReservedCode(System.String _admAppReservedCode, int start, int pageLength, out int count)
		{
			return GetByAdmAppReservedCode(null, _admAppReservedCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_RESERVED_CODE_NonClusteredIndex-20131121-210855 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppReservedCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmAppReservedCode(TransactionManager transactionManager, System.String _admAppReservedCode, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_APPLICANT_ID_NonClusteredIndex-20131121-210805 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmRsrvdCode&gt;"/> class.</returns>
		public TList<AdmRsrvdCode> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(null,_admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-210805 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmRsrvdCode&gt;"/> class.</returns>
		public TList<AdmRsrvdCode> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-210805 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmRsrvdCode&gt;"/> class.</returns>
		public TList<AdmRsrvdCode> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-210805 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmRsrvdCode&gt;"/> class.</returns>
		public TList<AdmRsrvdCode> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-210805 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmRsrvdCode&gt;"/> class.</returns>
		public TList<AdmRsrvdCode> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-210805 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmRsrvdCode&gt;"/> class.</returns>
		public abstract TList<AdmRsrvdCode> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_RSRVD_CODE index.
		/// </summary>
		/// <param name="_admRsrvdCodeId">XX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmRsrvdCodeId(System.Decimal _admRsrvdCodeId)
		{
			int count = -1;
			return GetByAdmRsrvdCodeId(null,_admRsrvdCodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RSRVD_CODE index.
		/// </summary>
		/// <param name="_admRsrvdCodeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmRsrvdCodeId(System.Decimal _admRsrvdCodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRsrvdCodeId(null, _admRsrvdCodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RSRVD_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRsrvdCodeId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmRsrvdCodeId(TransactionManager transactionManager, System.Decimal _admRsrvdCodeId)
		{
			int count = -1;
			return GetByAdmRsrvdCodeId(transactionManager, _admRsrvdCodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RSRVD_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRsrvdCodeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmRsrvdCodeId(TransactionManager transactionManager, System.Decimal _admRsrvdCodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmRsrvdCodeId(transactionManager, _admRsrvdCodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RSRVD_CODE index.
		/// </summary>
		/// <param name="_admRsrvdCodeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmRsrvdCodeId(System.Decimal _admRsrvdCodeId, int start, int pageLength, out int count)
		{
			return GetByAdmRsrvdCodeId(null, _admRsrvdCodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_RSRVD_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admRsrvdCodeId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmRsrvdCode GetByAdmRsrvdCodeId(TransactionManager transactionManager, System.Decimal _admRsrvdCodeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmRsrvdCode&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmRsrvdCode&gt;"/></returns>
		public static TList<AdmRsrvdCode> Fill(IDataReader reader, TList<AdmRsrvdCode> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmRsrvdCode c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmRsrvdCode")
					.Append("|").Append((System.Decimal)reader["ADM_RSRVD_CODE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmRsrvdCode>(
					key.ToString(), // EntityTrackingKey
					"AdmRsrvdCode",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmRsrvdCode();
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
					c.AdmRsrvdCodeId = (System.Decimal)reader["ADM_RSRVD_CODE_ID"];
					c.OriginalAdmRsrvdCodeId = c.AdmRsrvdCodeId;
					c.AssignedFlg = (System.Decimal)reader["ASSIGNED_FLG"];
					c.AdmOpenAcadSemesterId = (System.Decimal)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.AdmAppReservedCode = Convert.IsDBNull(reader["ADM_APP_RESERVED_CODE"]) ? null : (System.String)reader["ADM_APP_RESERVED_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmRsrvdCode entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmRsrvdCodeId = (System.Decimal)reader[((int)AdmRsrvdCodeColumn.AdmRsrvdCodeId - 1)];
			entity.OriginalAdmRsrvdCodeId = (System.Decimal)reader["ADM_RSRVD_CODE_ID"];
			entity.AssignedFlg = (System.Decimal)reader[((int)AdmRsrvdCodeColumn.AssignedFlg - 1)];
			entity.AdmOpenAcadSemesterId = (System.Decimal)reader[((int)AdmRsrvdCodeColumn.AdmOpenAcadSemesterId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmRsrvdCodeColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmRsrvdCodeColumn.AdmApplicantId - 1)];
			entity.AdmAppReservedCode = (reader.IsDBNull(((int)AdmRsrvdCodeColumn.AdmAppReservedCode - 1)))?null:(System.String)reader[((int)AdmRsrvdCodeColumn.AdmAppReservedCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmRsrvdCode entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmRsrvdCodeId = (System.Decimal)dataRow["ADM_RSRVD_CODE_ID"];
			entity.OriginalAdmRsrvdCodeId = (System.Decimal)dataRow["ADM_RSRVD_CODE_ID"];
			entity.AssignedFlg = (System.Decimal)dataRow["ASSIGNED_FLG"];
			entity.AdmOpenAcadSemesterId = (System.Decimal)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.AdmAppReservedCode = Convert.IsDBNull(dataRow["ADM_APP_RESERVED_CODE"]) ? null : (System.String)dataRow["ADM_APP_RESERVED_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmRsrvdCode"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRsrvdCode Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRsrvdCode entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmApplicantId ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.AdmApplicantId ?? 0.0m));		
				
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

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmOpenAcadSemesterId;
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, entity.AdmOpenAcadSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmOpenAcadSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmOpenAcadSemesterProvider.DeepLoad(transactionManager, entity.AdmOpenAcadSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmOpenAcadSemesterIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmRsrvdCode object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmRsrvdCode instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmRsrvdCode Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmRsrvdCode entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
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
	
	#region AdmRsrvdCodeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmRsrvdCode</c>
	///</summary>
	public enum AdmRsrvdCodeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
	}
	
	#endregion AdmRsrvdCodeChildEntityTypes
	
	#region AdmRsrvdCodeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmRsrvdCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRsrvdCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRsrvdCodeFilterBuilder : SqlFilterBuilder<AdmRsrvdCodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeFilterBuilder class.
		/// </summary>
		public AdmRsrvdCodeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRsrvdCodeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRsrvdCodeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRsrvdCodeFilterBuilder
	
	#region AdmRsrvdCodeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmRsrvdCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRsrvdCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmRsrvdCodeParameterBuilder : ParameterizedSqlFilterBuilder<AdmRsrvdCodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeParameterBuilder class.
		/// </summary>
		public AdmRsrvdCodeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmRsrvdCodeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmRsrvdCodeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmRsrvdCodeParameterBuilder
	
	#region AdmRsrvdCodeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmRsrvdCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmRsrvdCode"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmRsrvdCodeSortBuilder : SqlSortBuilder<AdmRsrvdCodeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeSqlSortBuilder class.
		/// </summary>
		public AdmRsrvdCodeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmRsrvdCodeSortBuilder
	
} // end namespace
