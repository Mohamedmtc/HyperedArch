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
	/// This class is the base class for any <see cref="GsAddressDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsAddressDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsAddressDtl, UMIS_VER2.BusinessLyer.GsAddressDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAddressDtlKey key)
		{
			return Delete(transactionManager, key.GsAddressDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsAddressDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsAddressDtlId)
		{
			return Delete(null, _gsAddressDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAddressDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsAddressDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ADDRESS_ED_STUD key.
		///		FK_ED_STUD_ADDRESS_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ADDRESS_ED_STUD key.
		///		FK_ED_STUD_ADDRESS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		/// <remarks></remarks>
		public TList<GsAddressDtl> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ADDRESS_ED_STUD key.
		///		FK_ED_STUD_ADDRESS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ADDRESS_ED_STUD key.
		///		fkEdStudAddressEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ADDRESS_ED_STUD key.
		///		fkEdStudAddressEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ADDRESS_ED_STUD key.
		///		FK_ED_STUD_ADDRESS_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public abstract TList<GsAddressDtl> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_ADM_APPLICANTS key.
		///		FK_GS_ADDRESS_DTL_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_ADM_APPLICANTS key.
		///		FK_GS_ADDRESS_DTL_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		/// <remarks></remarks>
		public TList<GsAddressDtl> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_ADM_APPLICANTS key.
		///		FK_GS_ADDRESS_DTL_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_ADM_APPLICANTS key.
		///		fkGsAddressDtlAdmApplicants Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_ADM_APPLICANTS key.
		///		fkGsAddressDtlAdmApplicants Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_ADM_APPLICANTS key.
		///		FK_GS_ADDRESS_DTL_ADM_APPLICANTS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public abstract TList<GsAddressDtl> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE key.
		///		FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE key.
		///		FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		/// <remarks></remarks>
		public TList<GsAddressDtl> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE key.
		///		FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE key.
		///		fkGsAddressDtlGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE key.
		///		fkGsAddressDtlGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public TList<GsAddressDtl> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE key.
		///		FK_GS_ADDRESS_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsAddressDtl objects.</returns>
		public abstract TList<GsAddressDtl> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsAddressDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAddressDtlKey key, int start, int pageLength)
		{
			return GetByGsAddressDtlId(transactionManager, key.GsAddressDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_ADDRESS index.
		/// </summary>
		/// <param name="_gsAddressDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAddressDtl GetByGsAddressDtlId(System.Decimal _gsAddressDtlId)
		{
			int count = -1;
			return GetByGsAddressDtlId(null,_gsAddressDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ADDRESS index.
		/// </summary>
		/// <param name="_gsAddressDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAddressDtl GetByGsAddressDtlId(System.Decimal _gsAddressDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsAddressDtlId(null, _gsAddressDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ADDRESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAddressDtl GetByGsAddressDtlId(TransactionManager transactionManager, System.Decimal _gsAddressDtlId)
		{
			int count = -1;
			return GetByGsAddressDtlId(transactionManager, _gsAddressDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ADDRESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAddressDtl GetByGsAddressDtlId(TransactionManager transactionManager, System.Decimal _gsAddressDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsAddressDtlId(transactionManager, _gsAddressDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ADDRESS index.
		/// </summary>
		/// <param name="_gsAddressDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsAddressDtl GetByGsAddressDtlId(System.Decimal _gsAddressDtlId, int start, int pageLength, out int count)
		{
			return GetByGsAddressDtlId(null, _gsAddressDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ADDRESS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsAddressDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsAddressDtl GetByGsAddressDtlId(TransactionManager transactionManager, System.Decimal _gsAddressDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsAddressDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsAddressDtl&gt;"/></returns>
		public static TList<GsAddressDtl> Fill(IDataReader reader, TList<GsAddressDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsAddressDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsAddressDtl")
					.Append("|").Append((System.Decimal)reader["GS_ADDRESS_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsAddressDtl>(
					key.ToString(), // EntityTrackingKey
					"GsAddressDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsAddressDtl();
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
					c.GsAddressDtlId = (System.Decimal)reader["GS_ADDRESS_DTL_ID"];
					c.OriginalGsAddressDtlId = c.GsAddressDtlId;
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.Child1Id = Convert.IsDBNull(reader["CHILD1_ID"]) ? null : (System.String)reader["CHILD1_ID"];
					c.Child2Id = Convert.IsDBNull(reader["CHILD2_ID"]) ? null : (System.String)reader["CHILD2_ID"];
					c.Child3Id = Convert.IsDBNull(reader["CHILD3_ID"]) ? null : (System.String)reader["CHILD3_ID"];
					c.DtlAddAr = Convert.IsDBNull(reader["DTL_ADD_AR"]) ? null : (System.String)reader["DTL_ADD_AR"];
					c.DtlAddEn = Convert.IsDBNull(reader["DTL_ADD_EN"]) ? null : (System.String)reader["DTL_ADD_EN"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.Child4Id = Convert.IsDBNull(reader["CHILD4_ID"]) ? null : (System.String)reader["CHILD4_ID"];
					c.Child5Id = Convert.IsDBNull(reader["CHILD5_ID"]) ? null : (System.String)reader["CHILD5_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsAddressDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.GsAddressDtlId = (System.Decimal)reader[((int)GsAddressDtlColumn.GsAddressDtlId - 1)];
			entity.OriginalGsAddressDtlId = (System.Decimal)reader["GS_ADDRESS_DTL_ID"];
			entity.EdStudId = (reader.IsDBNull(((int)GsAddressDtlColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)GsAddressDtlColumn.EdStudId - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)GsAddressDtlColumn.GsCountryNodeId - 1)];
			entity.Child1Id = (reader.IsDBNull(((int)GsAddressDtlColumn.Child1Id - 1)))?null:(System.String)reader[((int)GsAddressDtlColumn.Child1Id - 1)];
			entity.Child2Id = (reader.IsDBNull(((int)GsAddressDtlColumn.Child2Id - 1)))?null:(System.String)reader[((int)GsAddressDtlColumn.Child2Id - 1)];
			entity.Child3Id = (reader.IsDBNull(((int)GsAddressDtlColumn.Child3Id - 1)))?null:(System.String)reader[((int)GsAddressDtlColumn.Child3Id - 1)];
			entity.DtlAddAr = (reader.IsDBNull(((int)GsAddressDtlColumn.DtlAddAr - 1)))?null:(System.String)reader[((int)GsAddressDtlColumn.DtlAddAr - 1)];
			entity.DtlAddEn = (reader.IsDBNull(((int)GsAddressDtlColumn.DtlAddEn - 1)))?null:(System.String)reader[((int)GsAddressDtlColumn.DtlAddEn - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)GsAddressDtlColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)GsAddressDtlColumn.AdmApplicantId - 1)];
			entity.Child4Id = (reader.IsDBNull(((int)GsAddressDtlColumn.Child4Id - 1)))?null:(System.String)reader[((int)GsAddressDtlColumn.Child4Id - 1)];
			entity.Child5Id = (reader.IsDBNull(((int)GsAddressDtlColumn.Child5Id - 1)))?null:(System.String)reader[((int)GsAddressDtlColumn.Child5Id - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsAddressDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsAddressDtlId = (System.Decimal)dataRow["GS_ADDRESS_DTL_ID"];
			entity.OriginalGsAddressDtlId = (System.Decimal)dataRow["GS_ADDRESS_DTL_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.Child1Id = Convert.IsDBNull(dataRow["CHILD1_ID"]) ? null : (System.String)dataRow["CHILD1_ID"];
			entity.Child2Id = Convert.IsDBNull(dataRow["CHILD2_ID"]) ? null : (System.String)dataRow["CHILD2_ID"];
			entity.Child3Id = Convert.IsDBNull(dataRow["CHILD3_ID"]) ? null : (System.String)dataRow["CHILD3_ID"];
			entity.DtlAddAr = Convert.IsDBNull(dataRow["DTL_ADD_AR"]) ? null : (System.String)dataRow["DTL_ADD_AR"];
			entity.DtlAddEn = Convert.IsDBNull(dataRow["DTL_ADD_EN"]) ? null : (System.String)dataRow["DTL_ADD_EN"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.Child4Id = Convert.IsDBNull(dataRow["CHILD4_ID"]) ? null : (System.String)dataRow["CHILD4_ID"];
			entity.Child5Id = Convert.IsDBNull(dataRow["CHILD5_ID"]) ? null : (System.String)dataRow["CHILD5_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsAddressDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsAddressDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAddressDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCountryNodeId;
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsAddressDtlId methods when available
			
			#region GsCdeTrainSiteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeTrainSite>|GsCdeTrainSiteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeTrainSiteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeTrainSiteCollection = DataRepository.GsCdeTrainSiteProvider.GetByGsAddressDtlId(transactionManager, entity.GsAddressDtlId);

				if (deep && entity.GsCdeTrainSiteCollection.Count > 0)
				{
					deepHandles.Add("GsCdeTrainSiteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeTrainSite>) DataRepository.GsCdeTrainSiteProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeTrainSiteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsAddressDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsAddressDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsAddressDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsAddressDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsCdeTrainSite>
				if (CanDeepSave(entity.GsCdeTrainSiteCollection, "List<GsCdeTrainSite>|GsCdeTrainSiteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeTrainSite child in entity.GsCdeTrainSiteCollection)
					{
						if(child.GsAddressDtlIdSource != null)
						{
							child.GsAddressDtlId = child.GsAddressDtlIdSource.GsAddressDtlId;
						}
						else
						{
							child.GsAddressDtlId = entity.GsAddressDtlId;
						}

					}

					if (entity.GsCdeTrainSiteCollection.Count > 0 || entity.GsCdeTrainSiteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeTrainSiteProvider.Save(transactionManager, entity.GsCdeTrainSiteCollection);
						
						deepHandles.Add("GsCdeTrainSiteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeTrainSite >) DataRepository.GsCdeTrainSiteProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeTrainSiteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region GsAddressDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsAddressDtl</c>
	///</summary>
	public enum GsAddressDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>GsAddressDtl</c> as OneToMany for GsCdeTrainSiteCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeTrainSite>))]
		GsCdeTrainSiteCollection,
	}
	
	#endregion GsAddressDtlChildEntityTypes
	
	#region GsAddressDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsAddressDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsAddressDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsAddressDtlFilterBuilder : SqlFilterBuilder<GsAddressDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsAddressDtlFilterBuilder class.
		/// </summary>
		public GsAddressDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsAddressDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsAddressDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsAddressDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsAddressDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsAddressDtlFilterBuilder
	
	#region GsAddressDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsAddressDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsAddressDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsAddressDtlParameterBuilder : ParameterizedSqlFilterBuilder<GsAddressDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsAddressDtlParameterBuilder class.
		/// </summary>
		public GsAddressDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsAddressDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsAddressDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsAddressDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsAddressDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsAddressDtlParameterBuilder
	
	#region GsAddressDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsAddressDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsAddressDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsAddressDtlSortBuilder : SqlSortBuilder<GsAddressDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsAddressDtlSqlSortBuilder class.
		/// </summary>
		public GsAddressDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsAddressDtlSortBuilder
	
} // end namespace
