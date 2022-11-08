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
	/// This class is the base class for any <see cref="AccomStudGuestReqDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudGuestReqDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl, UMIS_VER2.BusinessLyer.AccomStudGuestReqDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReqDtlKey key)
		{
			return Delete(transactionManager, key.AccomStudGuestReqDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudGuestReqDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudGuestReqDtlId)
		{
			return Delete(null, _accomStudGuestReqDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudGuestReqDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED Description: 
		/// </summary>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomBedId(System.Decimal? _accomBedId)
		{
			int count = -1;
			return GetByAccomBedId(_accomBedId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudGuestReqDtl> GetByAccomBedId(TransactionManager transactionManager, System.Decimal? _accomBedId)
		{
			int count = -1;
			return GetByAccomBedId(transactionManager, _accomBedId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomBedId(TransactionManager transactionManager, System.Decimal? _accomBedId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomBedId(transactionManager, _accomBedId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED key.
		///		fkAccomStudGuestReqDtlAccomBed Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomBedId(System.Decimal? _accomBedId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomBedId(null, _accomBedId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED key.
		///		fkAccomStudGuestReqDtlAccomBed Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomBedId(System.Decimal? _accomBedId, int start, int pageLength,out int count)
		{
			return GetByAccomBedId(null, _accomBedId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_BED Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomBedId">سراير الغرفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public abstract TList<AccomStudGuestReqDtl> GetByAccomBedId(TransactionManager transactionManager, System.Decimal? _accomBedId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="_accomRoomId">الغرف  -من نوع ضيافة فقط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomRoomId(System.Decimal? _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(_accomRoomId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف  -من نوع ضيافة فقط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudGuestReqDtl> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal? _accomRoomId)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف  -من نوع ضيافة فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal? _accomRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomRoomId(transactionManager, _accomRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM key.
		///		fkAccomStudGuestReqDtlAccomRoom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomRoomId">الغرف  -من نوع ضيافة فقط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomRoomId(System.Decimal? _accomRoomId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM key.
		///		fkAccomStudGuestReqDtlAccomRoom Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomRoomId">الغرف  -من نوع ضيافة فقط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomRoomId(System.Decimal? _accomRoomId, int start, int pageLength,out int count)
		{
			return GetByAccomRoomId(null, _accomRoomId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_ROOM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomRoomId">الغرف  -من نوع ضيافة فقط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public abstract TList<AccomStudGuestReqDtl> GetByAccomRoomId(TransactionManager transactionManager, System.Decimal? _accomRoomId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ Description: 
		/// </summary>
		/// <param name="_accomStudGuestReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomStudGuestReqId(System.Decimal _accomStudGuestReqId)
		{
			int count = -1;
			return GetByAccomStudGuestReqId(_accomStudGuestReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudGuestReqDtl> GetByAccomStudGuestReqId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqId)
		{
			int count = -1;
			return GetByAccomStudGuestReqId(transactionManager, _accomStudGuestReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomStudGuestReqId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudGuestReqId(transactionManager, _accomStudGuestReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ key.
		///		fkAccomStudGuestReqDtlAccomStudGuestReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudGuestReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomStudGuestReqId(System.Decimal _accomStudGuestReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudGuestReqId(null, _accomStudGuestReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ key.
		///		fkAccomStudGuestReqDtlAccomStudGuestReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudGuestReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByAccomStudGuestReqId(System.Decimal _accomStudGuestReqId, int start, int pageLength,out int count)
		{
			return GetByAccomStudGuestReqId(null, _accomStudGuestReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_ACCOM_STUD_GUEST_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public abstract TList<AccomStudGuestReqDtl> GetByAccomStudGuestReqId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudGuestReqDtl> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE key.
		///		fkAccomStudGuestReqDtlGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE key.
		///		fkAccomStudGuestReqDtlGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public TList<AccomStudGuestReqDtl> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE key.
		///		FK_ACCOM_STUD_GUEST_REQ_DTL_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl objects.</returns>
		public abstract TList<AccomStudGuestReqDtl> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReqDtlKey key, int start, int pageLength)
		{
			return GetByAccomStudGuestReqDtlId(transactionManager, key.AccomStudGuestReqDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_GUEST_REQ_DTL index.
		/// </summary>
		/// <param name="_accomStudGuestReqDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl GetByAccomStudGuestReqDtlId(System.Decimal _accomStudGuestReqDtlId)
		{
			int count = -1;
			return GetByAccomStudGuestReqDtlId(null,_accomStudGuestReqDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ_DTL index.
		/// </summary>
		/// <param name="_accomStudGuestReqDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl GetByAccomStudGuestReqDtlId(System.Decimal _accomStudGuestReqDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudGuestReqDtlId(null, _accomStudGuestReqDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl GetByAccomStudGuestReqDtlId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqDtlId)
		{
			int count = -1;
			return GetByAccomStudGuestReqDtlId(transactionManager, _accomStudGuestReqDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl GetByAccomStudGuestReqDtlId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudGuestReqDtlId(transactionManager, _accomStudGuestReqDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ_DTL index.
		/// </summary>
		/// <param name="_accomStudGuestReqDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl GetByAccomStudGuestReqDtlId(System.Decimal _accomStudGuestReqDtlId, int start, int pageLength, out int count)
		{
			return GetByAccomStudGuestReqDtlId(null, _accomStudGuestReqDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_GUEST_REQ_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudGuestReqDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl GetByAccomStudGuestReqDtlId(TransactionManager transactionManager, System.Decimal _accomStudGuestReqDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudGuestReqDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudGuestReqDtl&gt;"/></returns>
		public static TList<AccomStudGuestReqDtl> Fill(IDataReader reader, TList<AccomStudGuestReqDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudGuestReqDtl")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_GUEST_REQ_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudGuestReqDtl>(
					key.ToString(), // EntityTrackingKey
					"AccomStudGuestReqDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl();
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
					c.AccomStudGuestReqDtlId = (System.Decimal)reader["ACCOM_STUD_GUEST_REQ_DTL_ID"];
					c.OriginalAccomStudGuestReqDtlId = c.AccomStudGuestReqDtlId;
					c.AccomStudGuestReqId = (System.Decimal)reader["ACCOM_STUD_GUEST_REQ_ID"];
					c.GuestNameAr = (System.String)reader["GUEST_NAME_AR"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.Address = Convert.IsDBNull(reader["ADDRESS"]) ? null : (System.String)reader["ADDRESS"];
					c.MobileNum = Convert.IsDBNull(reader["MOBILE_NUM"]) ? null : (System.String)reader["MOBILE_NUM"];
					c.WorkType = Convert.IsDBNull(reader["WORK_TYPE"]) ? null : (System.String)reader["WORK_TYPE"];
					c.WorkAddress = Convert.IsDBNull(reader["WORK_ADDRESS"]) ? null : (System.String)reader["WORK_ADDRESS"];
					c.AccomRoomId = Convert.IsDBNull(reader["ACCOM_ROOM_ID"]) ? null : (System.Decimal?)reader["ACCOM_ROOM_ID"];
					c.AccomBedId = Convert.IsDBNull(reader["ACCOM_BED_ID"]) ? null : (System.Decimal?)reader["ACCOM_BED_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudGuestReqDtlId = (System.Decimal)reader[((int)AccomStudGuestReqDtlColumn.AccomStudGuestReqDtlId - 1)];
			entity.OriginalAccomStudGuestReqDtlId = (System.Decimal)reader["ACCOM_STUD_GUEST_REQ_DTL_ID"];
			entity.AccomStudGuestReqId = (System.Decimal)reader[((int)AccomStudGuestReqDtlColumn.AccomStudGuestReqId - 1)];
			entity.GuestNameAr = (System.String)reader[((int)AccomStudGuestReqDtlColumn.GuestNameAr - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AccomStudGuestReqDtlColumn.GsCountryNodeId - 1)];
			entity.Address = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.Address - 1)))?null:(System.String)reader[((int)AccomStudGuestReqDtlColumn.Address - 1)];
			entity.MobileNum = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.MobileNum - 1)))?null:(System.String)reader[((int)AccomStudGuestReqDtlColumn.MobileNum - 1)];
			entity.WorkType = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.WorkType - 1)))?null:(System.String)reader[((int)AccomStudGuestReqDtlColumn.WorkType - 1)];
			entity.WorkAddress = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.WorkAddress - 1)))?null:(System.String)reader[((int)AccomStudGuestReqDtlColumn.WorkAddress - 1)];
			entity.AccomRoomId = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.AccomRoomId - 1)))?null:(System.Decimal?)reader[((int)AccomStudGuestReqDtlColumn.AccomRoomId - 1)];
			entity.AccomBedId = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.AccomBedId - 1)))?null:(System.Decimal?)reader[((int)AccomStudGuestReqDtlColumn.AccomBedId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudGuestReqDtlColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudGuestReqDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudGuestReqDtlColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudGuestReqDtlId = (System.Decimal)dataRow["ACCOM_STUD_GUEST_REQ_DTL_ID"];
			entity.OriginalAccomStudGuestReqDtlId = (System.Decimal)dataRow["ACCOM_STUD_GUEST_REQ_DTL_ID"];
			entity.AccomStudGuestReqId = (System.Decimal)dataRow["ACCOM_STUD_GUEST_REQ_ID"];
			entity.GuestNameAr = (System.String)dataRow["GUEST_NAME_AR"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.Address = Convert.IsDBNull(dataRow["ADDRESS"]) ? null : (System.String)dataRow["ADDRESS"];
			entity.MobileNum = Convert.IsDBNull(dataRow["MOBILE_NUM"]) ? null : (System.String)dataRow["MOBILE_NUM"];
			entity.WorkType = Convert.IsDBNull(dataRow["WORK_TYPE"]) ? null : (System.String)dataRow["WORK_TYPE"];
			entity.WorkAddress = Convert.IsDBNull(dataRow["WORK_ADDRESS"]) ? null : (System.String)dataRow["WORK_ADDRESS"];
			entity.AccomRoomId = Convert.IsDBNull(dataRow["ACCOM_ROOM_ID"]) ? null : (System.Decimal?)dataRow["ACCOM_ROOM_ID"];
			entity.AccomBedId = Convert.IsDBNull(dataRow["ACCOM_BED_ID"]) ? null : (System.Decimal?)dataRow["ACCOM_BED_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomBedIdSource	
			if (CanDeepLoad(entity, "AccomBed|AccomBedIdSource", deepLoadType, innerList) 
				&& entity.AccomBedIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomBedId ?? 0.0m);
				AccomBed tmpEntity = EntityManager.LocateEntity<AccomBed>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomBed), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomBedIdSource = tmpEntity;
				else
					entity.AccomBedIdSource = DataRepository.AccomBedProvider.GetByAccomBedId(transactionManager, (entity.AccomBedId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomBedIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomBedIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomBedProvider.DeepLoad(transactionManager, entity.AccomBedIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomBedIdSource

			#region AccomRoomIdSource	
			if (CanDeepLoad(entity, "AccomRoom|AccomRoomIdSource", deepLoadType, innerList) 
				&& entity.AccomRoomIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AccomRoomId ?? 0.0m);
				AccomRoom tmpEntity = EntityManager.LocateEntity<AccomRoom>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomRoom), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomRoomIdSource = tmpEntity;
				else
					entity.AccomRoomIdSource = DataRepository.AccomRoomProvider.GetByAccomRoomId(transactionManager, (entity.AccomRoomId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomRoomIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomRoomIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomRoomProvider.DeepLoad(transactionManager, entity.AccomRoomIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomRoomIdSource

			#region AccomStudGuestReqIdSource	
			if (CanDeepLoad(entity, "AccomStudGuestReq|AccomStudGuestReqIdSource", deepLoadType, innerList) 
				&& entity.AccomStudGuestReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomStudGuestReqId;
				AccomStudGuestReq tmpEntity = EntityManager.LocateEntity<AccomStudGuestReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudGuestReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudGuestReqIdSource = tmpEntity;
				else
					entity.AccomStudGuestReqIdSource = DataRepository.AccomStudGuestReqProvider.GetByAccomStudGuestReqId(transactionManager, entity.AccomStudGuestReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudGuestReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudGuestReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudGuestReqProvider.DeepLoad(transactionManager, entity.AccomStudGuestReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudGuestReqIdSource

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomBedIdSource
			if (CanDeepSave(entity, "AccomBed|AccomBedIdSource", deepSaveType, innerList) 
				&& entity.AccomBedIdSource != null)
			{
				DataRepository.AccomBedProvider.Save(transactionManager, entity.AccomBedIdSource);
				entity.AccomBedId = entity.AccomBedIdSource.AccomBedId;
			}
			#endregion 
			
			#region AccomRoomIdSource
			if (CanDeepSave(entity, "AccomRoom|AccomRoomIdSource", deepSaveType, innerList) 
				&& entity.AccomRoomIdSource != null)
			{
				DataRepository.AccomRoomProvider.Save(transactionManager, entity.AccomRoomIdSource);
				entity.AccomRoomId = entity.AccomRoomIdSource.AccomRoomId;
			}
			#endregion 
			
			#region AccomStudGuestReqIdSource
			if (CanDeepSave(entity, "AccomStudGuestReq|AccomStudGuestReqIdSource", deepSaveType, innerList) 
				&& entity.AccomStudGuestReqIdSource != null)
			{
				DataRepository.AccomStudGuestReqProvider.Save(transactionManager, entity.AccomStudGuestReqIdSource);
				entity.AccomStudGuestReqId = entity.AccomStudGuestReqIdSource.AccomStudGuestReqId;
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
	
	#region AccomStudGuestReqDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudGuestReqDtl</c>
	///</summary>
	public enum AccomStudGuestReqDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomBed</c> at AccomBedIdSource
		///</summary>
		[ChildEntityType(typeof(AccomBed))]
		AccomBed,
		
		///<summary>
		/// Composite Property for <c>AccomRoom</c> at AccomRoomIdSource
		///</summary>
		[ChildEntityType(typeof(AccomRoom))]
		AccomRoom,
		
		///<summary>
		/// Composite Property for <c>AccomStudGuestReq</c> at AccomStudGuestReqIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudGuestReq))]
		AccomStudGuestReq,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
	}
	
	#endregion AccomStudGuestReqDtlChildEntityTypes
	
	#region AccomStudGuestReqDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudGuestReqDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudGuestReqDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudGuestReqDtlFilterBuilder : SqlFilterBuilder<AccomStudGuestReqDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqDtlFilterBuilder class.
		/// </summary>
		public AccomStudGuestReqDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudGuestReqDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudGuestReqDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudGuestReqDtlFilterBuilder
	
	#region AccomStudGuestReqDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudGuestReqDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudGuestReqDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudGuestReqDtlParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudGuestReqDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqDtlParameterBuilder class.
		/// </summary>
		public AccomStudGuestReqDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudGuestReqDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudGuestReqDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudGuestReqDtlParameterBuilder
	
	#region AccomStudGuestReqDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudGuestReqDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudGuestReqDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudGuestReqDtlSortBuilder : SqlSortBuilder<AccomStudGuestReqDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudGuestReqDtlSqlSortBuilder class.
		/// </summary>
		public AccomStudGuestReqDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudGuestReqDtlSortBuilder
	
} // end namespace
