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
	/// This class is the base class for any <see cref="AdmScholorshipProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmScholorshipProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmScholorship, UMIS_VER2.BusinessLyer.AdmScholorshipKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmScholorshipKey key)
		{
			return Delete(transactionManager, key.AdmScholorshipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admScholorshipId">XX  not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admScholorshipId)
		{
			return Delete(null, _admScholorshipId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admScholorshipId">XX  not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admScholorshipId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ADM_APPLICANT key.
		///		FK_ADM_SCHOLORSHIP_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ADM_APPLICANT key.
		///		FK_ADM_SCHOLORSHIP_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		/// <remarks></remarks>
		public TList<AdmScholorship> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ADM_APPLICANT key.
		///		FK_ADM_SCHOLORSHIP_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ADM_APPLICANT key.
		///		fkAdmScholorshipAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ADM_APPLICANT key.
		///		fkAdmScholorshipAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ADM_APPLICANT key.
		///		FK_ADM_SCHOLORSHIP_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public abstract TList<AdmScholorship> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ED_STUD key.
		///		FK_ADM_SCHOLORSHIP_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ED_STUD key.
		///		FK_ADM_SCHOLORSHIP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		/// <remarks></remarks>
		public TList<AdmScholorship> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ED_STUD key.
		///		FK_ADM_SCHOLORSHIP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ED_STUD key.
		///		fkAdmScholorshipEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ED_STUD key.
		///		fkAdmScholorshipEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_ED_STUD key.
		///		FK_ADM_SCHOLORSHIP_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public abstract TList<AdmScholorship> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_SPO_SPONSOR key.
		///		FK_ADM_SCHOLORSHIP_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetBySpoSponsorId(System.Decimal _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_SPO_SPONSOR key.
		///		FK_ADM_SCHOLORSHIP_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		/// <remarks></remarks>
		public TList<AdmScholorship> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_SPO_SPONSOR key.
		///		FK_ADM_SCHOLORSHIP_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_SPO_SPONSOR key.
		///		fkAdmScholorshipSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetBySpoSponsorId(System.Decimal _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_SPO_SPONSOR key.
		///		fkAdmScholorshipSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public TList<AdmScholorship> GetBySpoSponsorId(System.Decimal _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_SCHOLORSHIP_SPO_SPONSOR key.
		///		FK_ADM_SCHOLORSHIP_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmScholorship objects.</returns>
		public abstract TList<AdmScholorship> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmScholorship Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmScholorshipKey key, int start, int pageLength)
		{
			return GetByAdmScholorshipId(transactionManager, key.AdmScholorshipId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_SCHOLORSHIP index.
		/// </summary>
		/// <param name="_admScholorshipId">XX  not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmScholorship GetByAdmScholorshipId(System.Decimal _admScholorshipId)
		{
			int count = -1;
			return GetByAdmScholorshipId(null,_admScholorshipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SCHOLORSHIP index.
		/// </summary>
		/// <param name="_admScholorshipId">XX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmScholorship GetByAdmScholorshipId(System.Decimal _admScholorshipId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmScholorshipId(null, _admScholorshipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SCHOLORSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admScholorshipId">XX  not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmScholorship GetByAdmScholorshipId(TransactionManager transactionManager, System.Decimal _admScholorshipId)
		{
			int count = -1;
			return GetByAdmScholorshipId(transactionManager, _admScholorshipId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SCHOLORSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admScholorshipId">XX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmScholorship GetByAdmScholorshipId(TransactionManager transactionManager, System.Decimal _admScholorshipId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmScholorshipId(transactionManager, _admScholorshipId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SCHOLORSHIP index.
		/// </summary>
		/// <param name="_admScholorshipId">XX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmScholorship GetByAdmScholorshipId(System.Decimal _admScholorshipId, int start, int pageLength, out int count)
		{
			return GetByAdmScholorshipId(null, _admScholorshipId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_SCHOLORSHIP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admScholorshipId">XX  not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmScholorship GetByAdmScholorshipId(TransactionManager transactionManager, System.Decimal _admScholorshipId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmScholorship&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmScholorship&gt;"/></returns>
		public static TList<AdmScholorship> Fill(IDataReader reader, TList<AdmScholorship> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmScholorship c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmScholorship")
					.Append("|").Append((System.Decimal)reader["ADM_SCHOLORSHIP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmScholorship>(
					key.ToString(), // EntityTrackingKey
					"AdmScholorship",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmScholorship();
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
					c.AdmScholorshipId = (System.Decimal)reader["ADM_SCHOLORSHIP_ID"];
					c.OriginalAdmScholorshipId = c.AdmScholorshipId;
					c.SpoSponsorId = (System.Decimal)reader["SPO_SPONSOR_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmScholorship entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmScholorshipId = (System.Decimal)reader[((int)AdmScholorshipColumn.AdmScholorshipId - 1)];
			entity.OriginalAdmScholorshipId = (System.Decimal)reader["ADM_SCHOLORSHIP_ID"];
			entity.SpoSponsorId = (System.Decimal)reader[((int)AdmScholorshipColumn.SpoSponsorId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmScholorshipColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmScholorshipColumn.AdmApplicantId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)AdmScholorshipColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)AdmScholorshipColumn.EdStudId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmScholorship entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmScholorshipId = (System.Decimal)dataRow["ADM_SCHOLORSHIP_ID"];
			entity.OriginalAdmScholorshipId = (System.Decimal)dataRow["ADM_SCHOLORSHIP_ID"];
			entity.SpoSponsorId = (System.Decimal)dataRow["SPO_SPONSOR_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmScholorship"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmScholorship Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmScholorship entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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

			#region SpoSponsorIdSource	
			if (CanDeepLoad(entity, "SpoSponsor|SpoSponsorIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorId;
				SpoSponsor tmpEntity = EntityManager.LocateEntity<SpoSponsor>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorIdSource = tmpEntity;
				else
					entity.SpoSponsorIdSource = DataRepository.SpoSponsorProvider.GetBySpoSponsorId(transactionManager, entity.SpoSponsorId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorProvider.DeepLoad(transactionManager, entity.SpoSponsorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmScholorship object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmScholorship instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmScholorship Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmScholorship entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region SpoSponsorIdSource
			if (CanDeepSave(entity, "SpoSponsor|SpoSponsorIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorIdSource != null)
			{
				DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorIdSource);
				entity.SpoSponsorId = entity.SpoSponsorIdSource.SpoSponsorId;
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
	
	#region AdmScholorshipChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmScholorship</c>
	///</summary>
	public enum AdmScholorshipChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
	}
	
	#endregion AdmScholorshipChildEntityTypes
	
	#region AdmScholorshipFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmScholorshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmScholorship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmScholorshipFilterBuilder : SqlFilterBuilder<AdmScholorshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmScholorshipFilterBuilder class.
		/// </summary>
		public AdmScholorshipFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmScholorshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmScholorshipFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmScholorshipFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmScholorshipFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmScholorshipFilterBuilder
	
	#region AdmScholorshipParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmScholorshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmScholorship"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmScholorshipParameterBuilder : ParameterizedSqlFilterBuilder<AdmScholorshipColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmScholorshipParameterBuilder class.
		/// </summary>
		public AdmScholorshipParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmScholorshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmScholorshipParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmScholorshipParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmScholorshipParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmScholorshipParameterBuilder
	
	#region AdmScholorshipSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmScholorshipColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmScholorship"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmScholorshipSortBuilder : SqlSortBuilder<AdmScholorshipColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmScholorshipSqlSortBuilder class.
		/// </summary>
		public AdmScholorshipSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmScholorshipSortBuilder
	
} // end namespace
