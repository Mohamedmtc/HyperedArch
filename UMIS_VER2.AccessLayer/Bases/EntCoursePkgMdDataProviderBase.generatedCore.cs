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
	/// This class is the base class for any <see cref="EntCoursePkgMdDataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCoursePkgMdDataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCoursePkgMdData, UMIS_VER2.BusinessLyer.EntCoursePkgMdDataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgMdDataKey key)
		{
			return Delete(transactionManager, key.EntCoursePkgMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCoursePkgMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _entCoursePkgMdDataId)
		{
			return Delete(null, _entCoursePkgMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _entCoursePkgMdDataId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntCoursePkgMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR key.
		///		fkEntCoursePkgMdDataEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public abstract TList<EntCoursePkgMdData> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA Description: 
		/// </summary>
		/// <param name="_entCodePrecondMdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCodePrecondMdId(System.Decimal? _entCodePrecondMdId)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(_entCodePrecondMdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgMdData> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal? _entCodePrecondMdId)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(transactionManager, _entCodePrecondMdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal? _entCodePrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(transactionManager, _entCodePrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA key.
		///		fkEntCoursePkgMdDataEntCodePrecondMetadata Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCodePrecondMdId(System.Decimal? _entCodePrecondMdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCodePrecondMdId(null, _entCodePrecondMdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA key.
		///		fkEntCoursePkgMdDataEntCodePrecondMetadata Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCodePrecondMdId(System.Decimal? _entCodePrecondMdId, int start, int pageLength,out int count)
		{
			return GetByEntCodePrecondMdId(null, _entCodePrecondMdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_CODE_PRECOND_METADATA Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public abstract TList<EntCoursePkgMdData> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal? _entCodePrecondMdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(_entCoursePkgHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgMdData> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR key.
		///		fkEntCoursePkgMdDataEntCoursePkgHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR key.
		///		fkEntCoursePkgMdDataEntCoursePkgHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, int start, int pageLength,out int count)
		{
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENT_COURSE_PKG_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public abstract TList<EntCoursePkgMdData> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN key.
		///		fkEntCoursePkgMdDataEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN key.
		///		fkEntCoursePkgMdDataEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public TList<EntCoursePkgMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN key.
		///		FK_ENT_COURSE_PKG_MD_DATA_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgMdData objects.</returns>
		public abstract TList<EntCoursePkgMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntCoursePkgMdData Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgMdDataKey key, int start, int pageLength)
		{
			return GetByEntCoursePkgMdDataId(transactionManager, key.EntCoursePkgMdDataId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_COURSE_PKG_MD_DATA index.
		/// </summary>
		/// <param name="_entCoursePkgMdDataId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgMdData GetByEntCoursePkgMdDataId(System.Int32 _entCoursePkgMdDataId)
		{
			int count = -1;
			return GetByEntCoursePkgMdDataId(null,_entCoursePkgMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_MD_DATA index.
		/// </summary>
		/// <param name="_entCoursePkgMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgMdData GetByEntCoursePkgMdDataId(System.Int32 _entCoursePkgMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgMdDataId(null, _entCoursePkgMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgMdDataId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgMdData GetByEntCoursePkgMdDataId(TransactionManager transactionManager, System.Int32 _entCoursePkgMdDataId)
		{
			int count = -1;
			return GetByEntCoursePkgMdDataId(transactionManager, _entCoursePkgMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgMdData GetByEntCoursePkgMdDataId(TransactionManager transactionManager, System.Int32 _entCoursePkgMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgMdDataId(transactionManager, _entCoursePkgMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_MD_DATA index.
		/// </summary>
		/// <param name="_entCoursePkgMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgMdData GetByEntCoursePkgMdDataId(System.Int32 _entCoursePkgMdDataId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgMdDataId(null, _entCoursePkgMdDataId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCoursePkgMdData GetByEntCoursePkgMdDataId(TransactionManager transactionManager, System.Int32 _entCoursePkgMdDataId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCoursePkgMdData&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCoursePkgMdData&gt;"/></returns>
		public static TList<EntCoursePkgMdData> Fill(IDataReader reader, TList<EntCoursePkgMdData> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCoursePkgMdData c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCoursePkgMdData")
					.Append("|").Append((System.Int32)reader["ENT_COURSE_PKG_MD_DATA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCoursePkgMdData>(
					key.ToString(), // EntityTrackingKey
					"EntCoursePkgMdData",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCoursePkgMdData();
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
					c.EntCoursePkgMdDataId = (System.Int32)reader["ENT_COURSE_PKG_MD_DATA_ID"];
					c.OriginalEntCoursePkgMdDataId = c.EntCoursePkgMdDataId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EntCoursePkgHdrId = (System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"];
					c.EntCodePrecondMdId = Convert.IsDBNull(reader["ENT_CODE_PRECOND_MD_ID"]) ? null : (System.Decimal?)reader["ENT_CODE_PRECOND_MD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCoursePkgMdData entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCoursePkgMdDataId = (System.Int32)reader[((int)EntCoursePkgMdDataColumn.EntCoursePkgMdDataId - 1)];
			entity.OriginalEntCoursePkgMdDataId = (System.Int32)reader["ENT_COURSE_PKG_MD_DATA_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EntCoursePkgMdDataColumn.EntMainId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EntCoursePkgMdDataColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgMdDataColumn.EdAcadYearId - 1)];
			entity.EntCoursePkgHdrId = (System.Decimal)reader[((int)EntCoursePkgMdDataColumn.EntCoursePkgHdrId - 1)];
			entity.EntCodePrecondMdId = (reader.IsDBNull(((int)EntCoursePkgMdDataColumn.EntCodePrecondMdId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgMdDataColumn.EntCodePrecondMdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCoursePkgMdData entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCoursePkgMdDataId = (System.Int32)dataRow["ENT_COURSE_PKG_MD_DATA_ID"];
			entity.OriginalEntCoursePkgMdDataId = (System.Int32)dataRow["ENT_COURSE_PKG_MD_DATA_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EntCoursePkgHdrId = (System.Decimal)dataRow["ENT_COURSE_PKG_HDR_ID"];
			entity.EntCodePrecondMdId = Convert.IsDBNull(dataRow["ENT_CODE_PRECOND_MD_ID"]) ? null : (System.Decimal?)dataRow["ENT_CODE_PRECOND_MD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgMdData"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCoursePkgMdData Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgMdData entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EntCodePrecondMdIdSource	
			if (CanDeepLoad(entity, "EntCodePrecondMetadata|EntCodePrecondMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodePrecondMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCodePrecondMdId ?? 0.0m);
				EntCodePrecondMetadata tmpEntity = EntityManager.LocateEntity<EntCodePrecondMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodePrecondMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodePrecondMdIdSource = tmpEntity;
				else
					entity.EntCodePrecondMdIdSource = DataRepository.EntCodePrecondMetadataProvider.GetByEntCodePrecondMdId(transactionManager, (entity.EntCodePrecondMdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePrecondMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodePrecondMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodePrecondMetadataProvider.DeepLoad(transactionManager, entity.EntCodePrecondMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodePrecondMdIdSource

			#region EntCoursePkgHdrIdSource	
			if (CanDeepLoad(entity, "EntCoursePkgHdr|EntCoursePkgHdrIdSource", deepLoadType, innerList) 
				&& entity.EntCoursePkgHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCoursePkgHdrId;
				EntCoursePkgHdr tmpEntity = EntityManager.LocateEntity<EntCoursePkgHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCoursePkgHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCoursePkgHdrIdSource = tmpEntity;
				else
					entity.EntCoursePkgHdrIdSource = DataRepository.EntCoursePkgHdrProvider.GetByEntCoursePkgHdrId(transactionManager, entity.EntCoursePkgHdrId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCoursePkgHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCoursePkgHdrProvider.DeepLoad(transactionManager, entity.EntCoursePkgHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCoursePkgHdrIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCoursePkgMdData object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCoursePkgMdData instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCoursePkgMdData Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgMdData entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EntCodePrecondMdIdSource
			if (CanDeepSave(entity, "EntCodePrecondMetadata|EntCodePrecondMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodePrecondMdIdSource != null)
			{
				DataRepository.EntCodePrecondMetadataProvider.Save(transactionManager, entity.EntCodePrecondMdIdSource);
				entity.EntCodePrecondMdId = entity.EntCodePrecondMdIdSource.EntCodePrecondMdId;
			}
			#endregion 
			
			#region EntCoursePkgHdrIdSource
			if (CanDeepSave(entity, "EntCoursePkgHdr|EntCoursePkgHdrIdSource", deepSaveType, innerList) 
				&& entity.EntCoursePkgHdrIdSource != null)
			{
				DataRepository.EntCoursePkgHdrProvider.Save(transactionManager, entity.EntCoursePkgHdrIdSource);
				entity.EntCoursePkgHdrId = entity.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
			}
			#endregion 
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
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
	
	#region EntCoursePkgMdDataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCoursePkgMdData</c>
	///</summary>
	public enum EntCoursePkgMdDataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EntCodePrecondMetadata</c> at EntCodePrecondMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodePrecondMetadata))]
		EntCodePrecondMetadata,
		
		///<summary>
		/// Composite Property for <c>EntCoursePkgHdr</c> at EntCoursePkgHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntCoursePkgHdr))]
		EntCoursePkgHdr,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EntCoursePkgMdDataChildEntityTypes
	
	#region EntCoursePkgMdDataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCoursePkgMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCoursePkgMdDataFilterBuilder : SqlFilterBuilder<EntCoursePkgMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgMdDataFilterBuilder class.
		/// </summary>
		public EntCoursePkgMdDataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCoursePkgMdDataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCoursePkgMdDataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCoursePkgMdDataFilterBuilder
	
	#region EntCoursePkgMdDataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCoursePkgMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCoursePkgMdDataParameterBuilder : ParameterizedSqlFilterBuilder<EntCoursePkgMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgMdDataParameterBuilder class.
		/// </summary>
		public EntCoursePkgMdDataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCoursePkgMdDataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCoursePkgMdDataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCoursePkgMdDataParameterBuilder
	
	#region EntCoursePkgMdDataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCoursePkgMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgMdData"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCoursePkgMdDataSortBuilder : SqlSortBuilder<EntCoursePkgMdDataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgMdDataSqlSortBuilder class.
		/// </summary>
		public EntCoursePkgMdDataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCoursePkgMdDataSortBuilder
	
} // end namespace
