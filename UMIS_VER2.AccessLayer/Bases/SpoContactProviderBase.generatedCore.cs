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
	/// This class is the base class for any <see cref="SpoContactProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoContactProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoContact, UMIS_VER2.BusinessLyer.SpoContactKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoContactKey key)
		{
			return Delete(transactionManager, key.SpoSponsorContactId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorContactId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorContactId)
		{
			return Delete(null, _spoSponsorContactId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContactId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorContactId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD key.
		///		FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD Description: 
		/// </summary>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetByGsCodeContactMethodId(System.Decimal? _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(_gsCodeContactMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD key.
		///		FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		/// <remarks></remarks>
		public TList<SpoContact> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal? _gsCodeContactMethodId)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD key.
		///		FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal? _gsCodeContactMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeContactMethodId(transactionManager, _gsCodeContactMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD key.
		///		fkSpoContactGsCodeContactMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetByGsCodeContactMethodId(System.Decimal? _gsCodeContactMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD key.
		///		fkSpoContactGsCodeContactMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetByGsCodeContactMethodId(System.Decimal? _gsCodeContactMethodId, int start, int pageLength,out int count)
		{
			return GetByGsCodeContactMethodId(null, _gsCodeContactMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD key.
		///		FK_SPO_CONTACT_GS_CODE_CONTACT_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeContactMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public abstract TList<SpoContact> GetByGsCodeContactMethodId(TransactionManager transactionManager, System.Decimal? _gsCodeContactMethodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_Department key.
		///		FK_SPO_CONTACT_SPO_Department Description: 
		/// </summary>
		/// <param name="_spoDepartmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoDepartmentId(System.Decimal? _spoDepartmentId)
		{
			int count = -1;
			return GetBySpoDepartmentId(_spoDepartmentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_Department key.
		///		FK_SPO_CONTACT_SPO_Department Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoDepartmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		/// <remarks></remarks>
		public TList<SpoContact> GetBySpoDepartmentId(TransactionManager transactionManager, System.Decimal? _spoDepartmentId)
		{
			int count = -1;
			return GetBySpoDepartmentId(transactionManager, _spoDepartmentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_Department key.
		///		FK_SPO_CONTACT_SPO_Department Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoDepartmentId(TransactionManager transactionManager, System.Decimal? _spoDepartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoDepartmentId(transactionManager, _spoDepartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_Department key.
		///		fkSpoContactSpoDepartment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoDepartmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoDepartmentId(System.Decimal? _spoDepartmentId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoDepartmentId(null, _spoDepartmentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_Department key.
		///		fkSpoContactSpoDepartment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoDepartmentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoDepartmentId(System.Decimal? _spoDepartmentId, int start, int pageLength,out int count)
		{
			return GetBySpoDepartmentId(null, _spoDepartmentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_Department key.
		///		FK_SPO_CONTACT_SPO_Department Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public abstract TList<SpoContact> GetBySpoDepartmentId(TransactionManager transactionManager, System.Decimal? _spoDepartmentId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON key.
		///		FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON Description: 
		/// </summary>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoResponsiblePersonId(System.Decimal? _spoResponsiblePersonId)
		{
			int count = -1;
			return GetBySpoResponsiblePersonId(_spoResponsiblePersonId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON key.
		///		FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		/// <remarks></remarks>
		public TList<SpoContact> GetBySpoResponsiblePersonId(TransactionManager transactionManager, System.Decimal? _spoResponsiblePersonId)
		{
			int count = -1;
			return GetBySpoResponsiblePersonId(transactionManager, _spoResponsiblePersonId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON key.
		///		FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoResponsiblePersonId(TransactionManager transactionManager, System.Decimal? _spoResponsiblePersonId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoResponsiblePersonId(transactionManager, _spoResponsiblePersonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON key.
		///		fkSpoContactSpoResponsiblePerson Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoResponsiblePersonId(System.Decimal? _spoResponsiblePersonId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoResponsiblePersonId(null, _spoResponsiblePersonId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON key.
		///		fkSpoContactSpoResponsiblePerson Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoResponsiblePersonId(System.Decimal? _spoResponsiblePersonId, int start, int pageLength,out int count)
		{
			return GetBySpoResponsiblePersonId(null, _spoResponsiblePersonId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON key.
		///		FK_SPO_CONTACT_SPO_RESPONSIBLE_PERSON Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoResponsiblePersonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public abstract TList<SpoContact> GetBySpoResponsiblePersonId(TransactionManager transactionManager, System.Decimal? _spoResponsiblePersonId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_SPONSOR key.
		///		FK_SPO_CONTACT_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_SPONSOR key.
		///		FK_SPO_CONTACT_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		/// <remarks></remarks>
		public TList<SpoContact> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_SPONSOR key.
		///		FK_SPO_CONTACT_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_SPONSOR key.
		///		fkSpoContactSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_SPONSOR key.
		///		fkSpoContactSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public TList<SpoContact> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_CONTACT_SPO_SPONSOR key.
		///		FK_SPO_CONTACT_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoContact objects.</returns>
		public abstract TList<SpoContact> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoContact Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoContactKey key, int start, int pageLength)
		{
			return GetBySpoSponsorContactId(transactionManager, key.SpoSponsorContactId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_SPONSOR_CONTACT index.
		/// </summary>
		/// <param name="_spoSponsorContactId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoContact GetBySpoSponsorContactId(System.Decimal _spoSponsorContactId)
		{
			int count = -1;
			return GetBySpoSponsorContactId(null,_spoSponsorContactId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_CONTACT index.
		/// </summary>
		/// <param name="_spoSponsorContactId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoContact GetBySpoSponsorContactId(System.Decimal _spoSponsorContactId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorContactId(null, _spoSponsorContactId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_CONTACT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContactId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoContact GetBySpoSponsorContactId(TransactionManager transactionManager, System.Decimal _spoSponsorContactId)
		{
			int count = -1;
			return GetBySpoSponsorContactId(transactionManager, _spoSponsorContactId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_CONTACT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContactId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoContact GetBySpoSponsorContactId(TransactionManager transactionManager, System.Decimal _spoSponsorContactId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorContactId(transactionManager, _spoSponsorContactId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_CONTACT index.
		/// </summary>
		/// <param name="_spoSponsorContactId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoContact GetBySpoSponsorContactId(System.Decimal _spoSponsorContactId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorContactId(null, _spoSponsorContactId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_CONTACT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorContactId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoContact GetBySpoSponsorContactId(TransactionManager transactionManager, System.Decimal _spoSponsorContactId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoContact&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoContact&gt;"/></returns>
		public static TList<SpoContact> Fill(IDataReader reader, TList<SpoContact> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoContact c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoContact")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_CONTACT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoContact>(
					key.ToString(), // EntityTrackingKey
					"SpoContact",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoContact();
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
					c.SpoSponsorContactId = (System.Decimal)reader["SPO_SPONSOR_CONTACT_ID"];
					c.OriginalSpoSponsorContactId = c.SpoSponsorContactId;
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.GsCodeContactMethodId = Convert.IsDBNull(reader["GS_CODE_CONTACT_METHOD_ID"]) ? null : (System.Decimal?)reader["GS_CODE_CONTACT_METHOD_ID"];
					c.ContactValue = Convert.IsDBNull(reader["CONTACT_VALUE"]) ? null : (System.String)reader["CONTACT_VALUE"];
					c.SpoDepartmentId = Convert.IsDBNull(reader["SPO_DEPARTMENT_ID"]) ? null : (System.Decimal?)reader["SPO_DEPARTMENT_ID"];
					c.SpoResponsiblePersonId = Convert.IsDBNull(reader["SPO_RESPONSIBLE_PERSON_ID"]) ? null : (System.Decimal?)reader["SPO_RESPONSIBLE_PERSON_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoContact entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorContactId = (System.Decimal)reader[((int)SpoContactColumn.SpoSponsorContactId - 1)];
			entity.OriginalSpoSponsorContactId = (System.Decimal)reader["SPO_SPONSOR_CONTACT_ID"];
			entity.SpoSponsorId = (reader.IsDBNull(((int)SpoContactColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)SpoContactColumn.SpoSponsorId - 1)];
			entity.GsCodeContactMethodId = (reader.IsDBNull(((int)SpoContactColumn.GsCodeContactMethodId - 1)))?null:(System.Decimal?)reader[((int)SpoContactColumn.GsCodeContactMethodId - 1)];
			entity.ContactValue = (reader.IsDBNull(((int)SpoContactColumn.ContactValue - 1)))?null:(System.String)reader[((int)SpoContactColumn.ContactValue - 1)];
			entity.SpoDepartmentId = (reader.IsDBNull(((int)SpoContactColumn.SpoDepartmentId - 1)))?null:(System.Decimal?)reader[((int)SpoContactColumn.SpoDepartmentId - 1)];
			entity.SpoResponsiblePersonId = (reader.IsDBNull(((int)SpoContactColumn.SpoResponsiblePersonId - 1)))?null:(System.Decimal?)reader[((int)SpoContactColumn.SpoResponsiblePersonId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoContact entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorContactId = (System.Decimal)dataRow["SPO_SPONSOR_CONTACT_ID"];
			entity.OriginalSpoSponsorContactId = (System.Decimal)dataRow["SPO_SPONSOR_CONTACT_ID"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.GsCodeContactMethodId = Convert.IsDBNull(dataRow["GS_CODE_CONTACT_METHOD_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_CONTACT_METHOD_ID"];
			entity.ContactValue = Convert.IsDBNull(dataRow["CONTACT_VALUE"]) ? null : (System.String)dataRow["CONTACT_VALUE"];
			entity.SpoDepartmentId = Convert.IsDBNull(dataRow["SPO_DEPARTMENT_ID"]) ? null : (System.Decimal?)dataRow["SPO_DEPARTMENT_ID"];
			entity.SpoResponsiblePersonId = Convert.IsDBNull(dataRow["SPO_RESPONSIBLE_PERSON_ID"]) ? null : (System.Decimal?)dataRow["SPO_RESPONSIBLE_PERSON_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoContact"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoContact Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoContact entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeContactMethodIdSource	
			if (CanDeepLoad(entity, "GsCodeContactMethod|GsCodeContactMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodeContactMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeContactMethodId ?? 0.0m);
				GsCodeContactMethod tmpEntity = EntityManager.LocateEntity<GsCodeContactMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeContactMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeContactMethodIdSource = tmpEntity;
				else
					entity.GsCodeContactMethodIdSource = DataRepository.GsCodeContactMethodProvider.GetByGsCodeContactMethodId(transactionManager, (entity.GsCodeContactMethodId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeContactMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeContactMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeContactMethodProvider.DeepLoad(transactionManager, entity.GsCodeContactMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeContactMethodIdSource

			#region SpoDepartmentIdSource	
			if (CanDeepLoad(entity, "SpoDepartment|SpoDepartmentIdSource", deepLoadType, innerList) 
				&& entity.SpoDepartmentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoDepartmentId ?? 0.0m);
				SpoDepartment tmpEntity = EntityManager.LocateEntity<SpoDepartment>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoDepartment), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoDepartmentIdSource = tmpEntity;
				else
					entity.SpoDepartmentIdSource = DataRepository.SpoDepartmentProvider.GetBySpoDepartmentId(transactionManager, (entity.SpoDepartmentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoDepartmentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoDepartmentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoDepartmentProvider.DeepLoad(transactionManager, entity.SpoDepartmentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoDepartmentIdSource

			#region SpoResponsiblePersonIdSource	
			if (CanDeepLoad(entity, "SpoResponsiblePerson|SpoResponsiblePersonIdSource", deepLoadType, innerList) 
				&& entity.SpoResponsiblePersonIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoResponsiblePersonId ?? 0.0m);
				SpoResponsiblePerson tmpEntity = EntityManager.LocateEntity<SpoResponsiblePerson>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoResponsiblePerson), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoResponsiblePersonIdSource = tmpEntity;
				else
					entity.SpoResponsiblePersonIdSource = DataRepository.SpoResponsiblePersonProvider.GetBySpoResponsiblePersonId(transactionManager, (entity.SpoResponsiblePersonId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoResponsiblePersonIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoResponsiblePersonIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoResponsiblePersonProvider.DeepLoad(transactionManager, entity.SpoResponsiblePersonIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoResponsiblePersonIdSource

			#region SpoSponsorIdSource	
			if (CanDeepLoad(entity, "SpoSponsor|SpoSponsorIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponsorId ?? 0.0m);
				SpoSponsor tmpEntity = EntityManager.LocateEntity<SpoSponsor>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorIdSource = tmpEntity;
				else
					entity.SpoSponsorIdSource = DataRepository.SpoSponsorProvider.GetBySpoSponsorId(transactionManager, (entity.SpoSponsorId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoContact object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoContact instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoContact Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoContact entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeContactMethodIdSource
			if (CanDeepSave(entity, "GsCodeContactMethod|GsCodeContactMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodeContactMethodIdSource != null)
			{
				DataRepository.GsCodeContactMethodProvider.Save(transactionManager, entity.GsCodeContactMethodIdSource);
				entity.GsCodeContactMethodId = entity.GsCodeContactMethodIdSource.GsCodeContactMethodId;
			}
			#endregion 
			
			#region SpoDepartmentIdSource
			if (CanDeepSave(entity, "SpoDepartment|SpoDepartmentIdSource", deepSaveType, innerList) 
				&& entity.SpoDepartmentIdSource != null)
			{
				DataRepository.SpoDepartmentProvider.Save(transactionManager, entity.SpoDepartmentIdSource);
				entity.SpoDepartmentId = entity.SpoDepartmentIdSource.SpoDepartmentId;
			}
			#endregion 
			
			#region SpoResponsiblePersonIdSource
			if (CanDeepSave(entity, "SpoResponsiblePerson|SpoResponsiblePersonIdSource", deepSaveType, innerList) 
				&& entity.SpoResponsiblePersonIdSource != null)
			{
				DataRepository.SpoResponsiblePersonProvider.Save(transactionManager, entity.SpoResponsiblePersonIdSource);
				entity.SpoResponsiblePersonId = entity.SpoResponsiblePersonIdSource.SpoResponsiblePersonId;
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
	
	#region SpoContactChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoContact</c>
	///</summary>
	public enum SpoContactChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeContactMethod</c> at GsCodeContactMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeContactMethod))]
		GsCodeContactMethod,
		
		///<summary>
		/// Composite Property for <c>SpoDepartment</c> at SpoDepartmentIdSource
		///</summary>
		[ChildEntityType(typeof(SpoDepartment))]
		SpoDepartment,
		
		///<summary>
		/// Composite Property for <c>SpoResponsiblePerson</c> at SpoResponsiblePersonIdSource
		///</summary>
		[ChildEntityType(typeof(SpoResponsiblePerson))]
		SpoResponsiblePerson,
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
	}
	
	#endregion SpoContactChildEntityTypes
	
	#region SpoContactFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoContactColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoContact"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoContactFilterBuilder : SqlFilterBuilder<SpoContactColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoContactFilterBuilder class.
		/// </summary>
		public SpoContactFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoContactFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoContactFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoContactFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoContactFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoContactFilterBuilder
	
	#region SpoContactParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoContactColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoContact"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoContactParameterBuilder : ParameterizedSqlFilterBuilder<SpoContactColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoContactParameterBuilder class.
		/// </summary>
		public SpoContactParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoContactParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoContactParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoContactParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoContactParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoContactParameterBuilder
	
	#region SpoContactSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoContactColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoContact"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoContactSortBuilder : SqlSortBuilder<SpoContactColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoContactSqlSortBuilder class.
		/// </summary>
		public SpoContactSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoContactSortBuilder
	
} // end namespace
