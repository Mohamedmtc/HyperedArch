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
	/// This class is the base class for any <see cref="EntCoursePkgHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCoursePkgHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCoursePkgHdr, UMIS_VER2.BusinessLyer.EntCoursePkgHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdrKey key)
		{
			return Delete(transactionManager, key.EntCoursePkgHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCoursePkgHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCoursePkgHdrId)
		{
			return Delete(null, _entCoursePkgHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR key.
		///		fkEntCoursePkgHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR key.
		///		fkEntCoursePkgHdrEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR key.
		///		FK_ENT_COURSE_PKG_HDR_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public abstract TList<EntCoursePkgHdr> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE key.
		///		FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE Description: 
		/// </summary>
		/// <param name="_entCdePkgTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntCdePkgTypeId(System.Decimal? _entCdePkgTypeId)
		{
			int count = -1;
			return GetByEntCdePkgTypeId(_entCdePkgTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE key.
		///		FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgHdr> GetByEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal? _entCdePkgTypeId)
		{
			int count = -1;
			return GetByEntCdePkgTypeId(transactionManager, _entCdePkgTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE key.
		///		FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal? _entCdePkgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCdePkgTypeId(transactionManager, _entCdePkgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE key.
		///		fkEntCoursePkgHdrEntCdePkgType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntCdePkgTypeId(System.Decimal? _entCdePkgTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntCdePkgTypeId(null, _entCdePkgTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE key.
		///		fkEntCoursePkgHdrEntCdePkgType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntCdePkgTypeId(System.Decimal? _entCdePkgTypeId, int start, int pageLength,out int count)
		{
			return GetByEntCdePkgTypeId(null, _entCdePkgTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE key.
		///		FK_ENT_COURSE_PKG_HDR_ENT_CDE_PKG_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public abstract TList<EntCoursePkgHdr> GetByEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal? _entCdePkgTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC Description: 
		/// </summary>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainSpcRltdId(System.Decimal? _entMainSpcRltdId)
		{
			int count = -1;
			return GetByEntMainSpcRltdId(_entMainSpcRltdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgHdr> GetByEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal? _entMainSpcRltdId)
		{
			int count = -1;
			return GetByEntMainSpcRltdId(transactionManager, _entMainSpcRltdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal? _entMainSpcRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainSpcRltdId(transactionManager, _entMainSpcRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC key.
		///		fkEntCoursePkgHdrEntityMainSpc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainSpcRltdId(System.Decimal? _entMainSpcRltdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainSpcRltdId(null, _entMainSpcRltdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC key.
		///		fkEntCoursePkgHdrEntityMainSpc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainSpcRltdId(System.Decimal? _entMainSpcRltdId, int start, int pageLength,out int count)
		{
			return GetByEntMainSpcRltdId(null, _entMainSpcRltdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN_SPC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public abstract TList<EntCoursePkgHdr> GetByEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal? _entMainSpcRltdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="_entMainRltdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainRltdId(System.Decimal? _entMainRltdId)
		{
			int count = -1;
			return GetByEntMainRltdId(_entMainRltdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainRltdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgHdr> GetByEntMainRltdId(TransactionManager transactionManager, System.Decimal? _entMainRltdId)
		{
			int count = -1;
			return GetByEntMainRltdId(transactionManager, _entMainRltdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainRltdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainRltdId(TransactionManager transactionManager, System.Decimal? _entMainRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainRltdId(transactionManager, _entMainRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 key.
		///		fkEntCoursePkgHdrEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainRltdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainRltdId(System.Decimal? _entMainRltdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainRltdId(null, _entMainRltdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 key.
		///		fkEntCoursePkgHdrEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainRltdId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainRltdId(System.Decimal? _entMainRltdId, int start, int pageLength,out int count)
		{
			return GetByEntMainRltdId(null, _entMainRltdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 key.
		///		FK_ENT_COURSE_PKG_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainRltdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgHdr objects.</returns>
		public abstract TList<EntCoursePkgHdr> GetByEntMainRltdId(TransactionManager transactionManager, System.Decimal? _entMainRltdId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntCoursePkgHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdrKey key, int start, int pageLength)
		{
			return GetByEntCoursePkgHdrId(transactionManager, key.EntCoursePkgHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgHdr&gt;"/> class.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgHdr&gt;"/> class.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgHdr&gt;"/> class.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgHdr&gt;"/> class.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgHdr&gt;"/> class.</returns>
		public TList<EntCoursePkgHdr> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgHdr&gt;"/> class.</returns>
		public abstract TList<EntCoursePkgHdr> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_COURSE_PKG_HDR index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null,_entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_HDR index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_HDR index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntCoursePkgHdrId(System.Decimal _entCoursePkgHdrId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal _entCoursePkgHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_COURSE_PKG_HDR_AR index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrAr, System.Decimal? _entCdePkgTypeId)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(null,_entMainId, _edAcadYearId, _descrAr, _entCdePkgTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_AR index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrAr, System.Decimal? _entCdePkgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(null, _entMainId, _edAcadYearId, _descrAr, _entCdePkgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrAr, System.Decimal? _entCdePkgTypeId)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(transactionManager, _entMainId, _edAcadYearId, _descrAr, _entCdePkgTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrAr, System.Decimal? _entCdePkgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(transactionManager, _entMainId, _edAcadYearId, _descrAr, _entCdePkgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_AR index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrAr, System.Decimal? _entCdePkgTypeId, int start, int pageLength, out int count)
		{
			return GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(null, _entMainId, _edAcadYearId, _descrAr, _entCdePkgTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrAr"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrArEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrAr, System.Decimal? _entCdePkgTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_COURSE_PKG_HDR_EN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrEn, System.Decimal? _entCdePkgTypeId)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(null,_entMainId, _edAcadYearId, _descrEn, _entCdePkgTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_EN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrEn, System.Decimal? _entCdePkgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(null, _entMainId, _edAcadYearId, _descrEn, _entCdePkgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrEn, System.Decimal? _entCdePkgTypeId)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(transactionManager, _entMainId, _edAcadYearId, _descrEn, _entCdePkgTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrEn, System.Decimal? _entCdePkgTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(transactionManager, _entMainId, _edAcadYearId, _descrEn, _entCdePkgTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_EN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrEn, System.Decimal? _entCdePkgTypeId, int start, int pageLength, out int count)
		{
			return GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(null, _entMainId, _edAcadYearId, _descrEn, _entCdePkgTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_HDR_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="_descrEn"></param>
		/// <param name="_entCdePkgTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCoursePkgHdr GetByEntMainIdEdAcadYearIdDescrEnEntCdePkgTypeId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, System.String _descrEn, System.Decimal? _entCdePkgTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCoursePkgHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCoursePkgHdr&gt;"/></returns>
		public static TList<EntCoursePkgHdr> Fill(IDataReader reader, TList<EntCoursePkgHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCoursePkgHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCoursePkgHdr")
					.Append("|").Append((System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCoursePkgHdr>(
					key.ToString(), // EntityTrackingKey
					"EntCoursePkgHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCoursePkgHdr();
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
					c.EntCoursePkgHdrId = (System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"];
					c.OriginalEntCoursePkgHdrId = c.EntCoursePkgHdrId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.MinTotCh = (System.Decimal)reader["MIN_TOT_CH"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntCdePkgTypeId = Convert.IsDBNull(reader["ENT_CDE_PKG_TYPE_ID"]) ? null : (System.Decimal?)reader["ENT_CDE_PKG_TYPE_ID"];
					c.EntMainRltdId = Convert.IsDBNull(reader["ENT_MAIN_RLTD_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_RLTD_ID"];
					c.PkgOrdr = Convert.IsDBNull(reader["PKG_ORDR"]) ? null : (System.Decimal?)reader["PKG_ORDR"];
					c.EntMainSpcRltdId = Convert.IsDBNull(reader["ENT_MAIN_SPC_RLTD_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_SPC_RLTD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCoursePkgHdrId = (System.Decimal)reader[((int)EntCoursePkgHdrColumn.EntCoursePkgHdrId - 1)];
			entity.OriginalEntCoursePkgHdrId = (System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EntCoursePkgHdrColumn.EntMainId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EntCoursePkgHdrColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgHdrColumn.EdAcadYearId - 1)];
			entity.MinTotCh = (System.Decimal)reader[((int)EntCoursePkgHdrColumn.MinTotCh - 1)];
			entity.DescrAr = (System.String)reader[((int)EntCoursePkgHdrColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EntCoursePkgHdrColumn.DescrEn - 1)))?null:(System.String)reader[((int)EntCoursePkgHdrColumn.DescrEn - 1)];
			entity.EntCdePkgTypeId = (reader.IsDBNull(((int)EntCoursePkgHdrColumn.EntCdePkgTypeId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgHdrColumn.EntCdePkgTypeId - 1)];
			entity.EntMainRltdId = (reader.IsDBNull(((int)EntCoursePkgHdrColumn.EntMainRltdId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgHdrColumn.EntMainRltdId - 1)];
			entity.PkgOrdr = (reader.IsDBNull(((int)EntCoursePkgHdrColumn.PkgOrdr - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgHdrColumn.PkgOrdr - 1)];
			entity.EntMainSpcRltdId = (reader.IsDBNull(((int)EntCoursePkgHdrColumn.EntMainSpcRltdId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgHdrColumn.EntMainSpcRltdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCoursePkgHdrId = (System.Decimal)dataRow["ENT_COURSE_PKG_HDR_ID"];
			entity.OriginalEntCoursePkgHdrId = (System.Decimal)dataRow["ENT_COURSE_PKG_HDR_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.MinTotCh = (System.Decimal)dataRow["MIN_TOT_CH"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.EntCdePkgTypeId = Convert.IsDBNull(dataRow["ENT_CDE_PKG_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ENT_CDE_PKG_TYPE_ID"];
			entity.EntMainRltdId = Convert.IsDBNull(dataRow["ENT_MAIN_RLTD_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_RLTD_ID"];
			entity.PkgOrdr = Convert.IsDBNull(dataRow["PKG_ORDR"]) ? null : (System.Decimal?)dataRow["PKG_ORDR"];
			entity.EntMainSpcRltdId = Convert.IsDBNull(dataRow["ENT_MAIN_SPC_RLTD_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_SPC_RLTD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCoursePkgHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntCdePkgTypeIdSource	
			if (CanDeepLoad(entity, "EntCdePkgType|EntCdePkgTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCdePkgTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCdePkgTypeId ?? 0.0m);
				EntCdePkgType tmpEntity = EntityManager.LocateEntity<EntCdePkgType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCdePkgType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCdePkgTypeIdSource = tmpEntity;
				else
					entity.EntCdePkgTypeIdSource = DataRepository.EntCdePkgTypeProvider.GetByEntCdePkgTypeId(transactionManager, (entity.EntCdePkgTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCdePkgTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCdePkgTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCdePkgTypeProvider.DeepLoad(transactionManager, entity.EntCdePkgTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCdePkgTypeIdSource

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

			#region EntMainSpcRltdIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainSpcRltdIdSource", deepLoadType, innerList) 
				&& entity.EntMainSpcRltdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainSpcRltdId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainSpcRltdIdSource = tmpEntity;
				else
					entity.EntMainSpcRltdIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainSpcRltdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainSpcRltdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainSpcRltdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainSpcRltdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainSpcRltdIdSource

			#region EntMainRltdIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainRltdIdSource", deepLoadType, innerList) 
				&& entity.EntMainRltdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainRltdId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainRltdIdSource = tmpEntity;
				else
					entity.EntMainRltdIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainRltdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainRltdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainRltdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainRltdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainRltdIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCoursePkgHdrId methods when available
			
			#region EdAcadPlanDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanDtl>|EdAcadPlanDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanDtlCollection = DataRepository.EdAcadPlanDtlProvider.GetByEntCoursePkgHdrId(transactionManager, entity.EntCoursePkgHdrId);

				if (deep && entity.EdAcadPlanDtlCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanDtl>) DataRepository.EdAcadPlanDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingCourse>|EntPolicyGradingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingCourseCollection = DataRepository.EntPolicyGradingCourseProvider.GetByEntCoursePkgHdrId(transactionManager, entity.EntCoursePkgHdrId);

				if (deep && entity.EntPolicyGradingCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingCourse>) DataRepository.EntPolicyGradingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransToCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransToCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransToCourseCollection = DataRepository.AdmAppTransToCourseProvider.GetByEntCoursePkgHdrId(transactionManager, entity.EntCoursePkgHdrId);

				if (deep && entity.AdmAppTransToCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransToCourse>) DataRepository.AdmAppTransToCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgMdData>|EntCoursePkgMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgMdDataCollection = DataRepository.EntCoursePkgMdDataProvider.GetByEntCoursePkgHdrId(transactionManager, entity.EntCoursePkgHdrId);

				if (deep && entity.EntCoursePkgMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCoursePkgMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgMdData>) DataRepository.EntCoursePkgMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgDtlCollection = DataRepository.EntCoursePkgDtlProvider.GetByEntCoursePkgHdrId(transactionManager, entity.EntCoursePkgHdrId);

				if (deep && entity.EntCoursePkgDtlCollection.Count > 0)
				{
					deepHandles.Add("EntCoursePkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgDtl>) DataRepository.EntCoursePkgDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAssessCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAssessCourse>|EntPolicyAssessCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAssessCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAssessCourseCollection = DataRepository.EntPolicyAssessCourseProvider.GetByEntCoursePkgHdrId(transactionManager, entity.EntCoursePkgHdrId);

				if (deep && entity.EntPolicyAssessCourseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAssessCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAssessCourse>) DataRepository.EntPolicyAssessCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAssessCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCoursePkgHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCoursePkgHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCoursePkgHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntCdePkgTypeIdSource
			if (CanDeepSave(entity, "EntCdePkgType|EntCdePkgTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCdePkgTypeIdSource != null)
			{
				DataRepository.EntCdePkgTypeProvider.Save(transactionManager, entity.EntCdePkgTypeIdSource);
				entity.EntCdePkgTypeId = entity.EntCdePkgTypeIdSource.EntCdePkgTypeId;
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
			
			#region EntMainSpcRltdIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainSpcRltdIdSource", deepSaveType, innerList) 
				&& entity.EntMainSpcRltdIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainSpcRltdIdSource);
				entity.EntMainSpcRltdId = entity.EntMainSpcRltdIdSource.EntMainId;
			}
			#endregion 
			
			#region EntMainRltdIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainRltdIdSource", deepSaveType, innerList) 
				&& entity.EntMainRltdIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainRltdIdSource);
				entity.EntMainRltdId = entity.EntMainRltdIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdAcadPlanDtl>
				if (CanDeepSave(entity.EdAcadPlanDtlCollection, "List<EdAcadPlanDtl>|EdAcadPlanDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanDtl child in entity.EdAcadPlanDtlCollection)
					{
						if(child.EntCoursePkgHdrIdSource != null)
						{
							child.EntCoursePkgHdrId = child.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
						}
						else
						{
							child.EntCoursePkgHdrId = entity.EntCoursePkgHdrId;
						}

					}

					if (entity.EdAcadPlanDtlCollection.Count > 0 || entity.EdAcadPlanDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanDtlProvider.Save(transactionManager, entity.EdAcadPlanDtlCollection);
						
						deepHandles.Add("EdAcadPlanDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanDtl >) DataRepository.EdAcadPlanDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingCourse>
				if (CanDeepSave(entity.EntPolicyGradingCourseCollection, "List<EntPolicyGradingCourse>|EntPolicyGradingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingCourse child in entity.EntPolicyGradingCourseCollection)
					{
						if(child.EntCoursePkgHdrIdSource != null)
						{
							child.EntCoursePkgHdrId = child.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
						}
						else
						{
							child.EntCoursePkgHdrId = entity.EntCoursePkgHdrId;
						}

					}

					if (entity.EntPolicyGradingCourseCollection.Count > 0 || entity.EntPolicyGradingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingCourseProvider.Save(transactionManager, entity.EntPolicyGradingCourseCollection);
						
						deepHandles.Add("EntPolicyGradingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingCourse >) DataRepository.EntPolicyGradingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransToCourse>
				if (CanDeepSave(entity.AdmAppTransToCourseCollection, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransToCourse child in entity.AdmAppTransToCourseCollection)
					{
						if(child.EntCoursePkgHdrIdSource != null)
						{
							child.EntCoursePkgHdrId = child.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
						}
						else
						{
							child.EntCoursePkgHdrId = entity.EntCoursePkgHdrId;
						}

					}

					if (entity.AdmAppTransToCourseCollection.Count > 0 || entity.AdmAppTransToCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransToCourseProvider.Save(transactionManager, entity.AdmAppTransToCourseCollection);
						
						deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransToCourse >) DataRepository.AdmAppTransToCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgMdData>
				if (CanDeepSave(entity.EntCoursePkgMdDataCollection, "List<EntCoursePkgMdData>|EntCoursePkgMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgMdData child in entity.EntCoursePkgMdDataCollection)
					{
						if(child.EntCoursePkgHdrIdSource != null)
						{
							child.EntCoursePkgHdrId = child.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
						}
						else
						{
							child.EntCoursePkgHdrId = entity.EntCoursePkgHdrId;
						}

					}

					if (entity.EntCoursePkgMdDataCollection.Count > 0 || entity.EntCoursePkgMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgMdDataProvider.Save(transactionManager, entity.EntCoursePkgMdDataCollection);
						
						deepHandles.Add("EntCoursePkgMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgMdData >) DataRepository.EntCoursePkgMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgDtl>
				if (CanDeepSave(entity.EntCoursePkgDtlCollection, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgDtl child in entity.EntCoursePkgDtlCollection)
					{
						if(child.EntCoursePkgHdrIdSource != null)
						{
							child.EntCoursePkgHdrId = child.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
						}
						else
						{
							child.EntCoursePkgHdrId = entity.EntCoursePkgHdrId;
						}

					}

					if (entity.EntCoursePkgDtlCollection.Count > 0 || entity.EntCoursePkgDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgDtlProvider.Save(transactionManager, entity.EntCoursePkgDtlCollection);
						
						deepHandles.Add("EntCoursePkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgDtl >) DataRepository.EntCoursePkgDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAssessCourse>
				if (CanDeepSave(entity.EntPolicyAssessCourseCollection, "List<EntPolicyAssessCourse>|EntPolicyAssessCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAssessCourse child in entity.EntPolicyAssessCourseCollection)
					{
						if(child.EntCoursePkgHdrIdSource != null)
						{
							child.EntCoursePkgHdrId = child.EntCoursePkgHdrIdSource.EntCoursePkgHdrId;
						}
						else
						{
							child.EntCoursePkgHdrId = entity.EntCoursePkgHdrId;
						}

					}

					if (entity.EntPolicyAssessCourseCollection.Count > 0 || entity.EntPolicyAssessCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAssessCourseProvider.Save(transactionManager, entity.EntPolicyAssessCourseCollection);
						
						deepHandles.Add("EntPolicyAssessCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAssessCourse >) DataRepository.EntPolicyAssessCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAssessCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCoursePkgHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCoursePkgHdr</c>
	///</summary>
	public enum EntCoursePkgHdrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EntCdePkgType</c> at EntCdePkgTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCdePkgType))]
		EntCdePkgType,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EntCoursePkgHdr</c> as OneToMany for EdAcadPlanDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanDtl>))]
		EdAcadPlanDtlCollection,
		///<summary>
		/// Collection of <c>EntCoursePkgHdr</c> as OneToMany for EntPolicyGradingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingCourse>))]
		EntPolicyGradingCourseCollection,
		///<summary>
		/// Collection of <c>EntCoursePkgHdr</c> as OneToMany for AdmAppTransToCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransToCourse>))]
		AdmAppTransToCourseCollection,
		///<summary>
		/// Collection of <c>EntCoursePkgHdr</c> as OneToMany for EntCoursePkgMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgMdData>))]
		EntCoursePkgMdDataCollection,
		///<summary>
		/// Collection of <c>EntCoursePkgHdr</c> as OneToMany for EntCoursePkgDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgDtl>))]
		EntCoursePkgDtlCollection,
		///<summary>
		/// Collection of <c>EntCoursePkgHdr</c> as OneToMany for EntPolicyAssessCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAssessCourse>))]
		EntPolicyAssessCourseCollection,
	}
	
	#endregion EntCoursePkgHdrChildEntityTypes
	
	#region EntCoursePkgHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCoursePkgHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCoursePkgHdrFilterBuilder : SqlFilterBuilder<EntCoursePkgHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrFilterBuilder class.
		/// </summary>
		public EntCoursePkgHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCoursePkgHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCoursePkgHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCoursePkgHdrFilterBuilder
	
	#region EntCoursePkgHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCoursePkgHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCoursePkgHdrParameterBuilder : ParameterizedSqlFilterBuilder<EntCoursePkgHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrParameterBuilder class.
		/// </summary>
		public EntCoursePkgHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCoursePkgHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCoursePkgHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCoursePkgHdrParameterBuilder
	
	#region EntCoursePkgHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCoursePkgHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCoursePkgHdrSortBuilder : SqlSortBuilder<EntCoursePkgHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrSqlSortBuilder class.
		/// </summary>
		public EntCoursePkgHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCoursePkgHdrSortBuilder
	
} // end namespace
