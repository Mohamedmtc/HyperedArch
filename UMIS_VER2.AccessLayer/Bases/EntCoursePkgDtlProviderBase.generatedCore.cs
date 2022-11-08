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
	/// This class is the base class for any <see cref="EntCoursePkgDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCoursePkgDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCoursePkgDtl, UMIS_VER2.BusinessLyer.EntCoursePkgDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgDtlKey key)
		{
			return Delete(transactionManager, key.EntCoursePkgDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCoursePkgDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCoursePkgDtlId)
		{
			return Delete(null, _entCoursePkgDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgDtlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCoursePkgDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(_edCourseExpHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR key.
		///		fkEntCoursePkgDtlEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR key.
		///		fkEntCoursePkgDtlEdCourseExpHdr Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpHdrId(System.Decimal? _edCourseExpHdrId, int start, int pageLength,out int count)
		{
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public abstract TList<EntCoursePkgDtl> GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpHdrId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 Description: 
		/// </summary>
		/// <param name="_edCourseExpPrereqHdrId">XX not used </param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpPrereqHdrId(System.Decimal? _edCourseExpPrereqHdrId)
		{
			int count = -1;
			return GetByEdCourseExpPrereqHdrId(_edCourseExpPrereqHdrId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpPrereqHdrId">XX not used </param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EntCoursePkgDtl> GetByEdCourseExpPrereqHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpPrereqHdrId)
		{
			int count = -1;
			return GetByEdCourseExpPrereqHdrId(transactionManager, _edCourseExpPrereqHdrId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpPrereqHdrId">XX not used </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpPrereqHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpPrereqHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpPrereqHdrId(transactionManager, _edCourseExpPrereqHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 key.
		///		fkEntCoursePkgDtlEdCourseExpHdr1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpPrereqHdrId">XX not used </param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpPrereqHdrId(System.Decimal? _edCourseExpPrereqHdrId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseExpPrereqHdrId(null, _edCourseExpPrereqHdrId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 key.
		///		fkEntCoursePkgDtlEdCourseExpHdr1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseExpPrereqHdrId">XX not used </param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseExpPrereqHdrId(System.Decimal? _edCourseExpPrereqHdrId, int start, int pageLength,out int count)
		{
			return GetByEdCourseExpPrereqHdrId(null, _edCourseExpPrereqHdrId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 key.
		///		FK_ENT_COURSE_PKG_DTL_ED_COURSE_EXP_HDR1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpPrereqHdrId">XX not used </param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntCoursePkgDtl objects.</returns>
		public abstract TList<EntCoursePkgDtl> GetByEdCourseExpPrereqHdrId(TransactionManager transactionManager, System.Decimal? _edCourseExpPrereqHdrId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntCoursePkgDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgDtlKey key, int start, int pageLength)
		{
			return GetByEntCoursePkgDtlId(transactionManager, key.EntCoursePkgDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public abstract TList<EntCoursePkgDtl> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null,_entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrId(transactionManager, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public TList<EntCoursePkgDtl> GetByEntCoursePkgHdrId(System.Decimal? _entCoursePkgHdrId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgHdrId(null, _entCoursePkgHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_COURSE_PKG_HDR_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntCoursePkgDtl&gt;"/> class.</returns>
		public abstract TList<EntCoursePkgDtl> GetByEntCoursePkgHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_COURSE_PKG index.
		/// </summary>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgDtlId(System.Decimal _entCoursePkgDtlId)
		{
			int count = -1;
			return GetByEntCoursePkgDtlId(null,_entCoursePkgDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG index.
		/// </summary>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgDtlId(System.Decimal _entCoursePkgDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgDtlId(null, _entCoursePkgDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgDtlId(TransactionManager transactionManager, System.Decimal _entCoursePkgDtlId)
		{
			int count = -1;
			return GetByEntCoursePkgDtlId(transactionManager, _entCoursePkgDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgDtlId(TransactionManager transactionManager, System.Decimal _entCoursePkgDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgDtlId(transactionManager, _entCoursePkgDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG index.
		/// </summary>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgDtlId(System.Decimal _entCoursePkgDtlId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgDtlId(null, _entCoursePkgDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_COURSE_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgDtlId(TransactionManager transactionManager, System.Decimal _entCoursePkgDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_COURSE_PKG_DTL index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(System.Decimal? _entCoursePkgHdrId, System.Decimal? _edCourseId, System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(null,_entCoursePkgHdrId, _edCourseId, _edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_DTL index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(System.Decimal? _entCoursePkgHdrId, System.Decimal? _edCourseId, System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(null, _entCoursePkgHdrId, _edCourseId, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, System.Decimal? _edCourseId, System.Decimal? _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(transactionManager, _entCoursePkgHdrId, _edCourseId, _edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, System.Decimal? _edCourseId, System.Decimal? _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(transactionManager, _entCoursePkgHdrId, _edCourseId, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_DTL index.
		/// </summary>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(System.Decimal? _entCoursePkgHdrId, System.Decimal? _edCourseId, System.Decimal? _edCourseExpHdrId, int start, int pageLength, out int count)
		{
			return GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(null, _entCoursePkgHdrId, _edCourseId, _edCourseExpHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_COURSE_PKG_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCoursePkgHdrId"></param>
		/// <param name="_edCourseId"></param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCoursePkgDtl GetByEntCoursePkgHdrIdEdCourseIdEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal? _entCoursePkgHdrId, System.Decimal? _edCourseId, System.Decimal? _edCourseExpHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCoursePkgDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCoursePkgDtl&gt;"/></returns>
		public static TList<EntCoursePkgDtl> Fill(IDataReader reader, TList<EntCoursePkgDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCoursePkgDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCoursePkgDtl")
					.Append("|").Append((System.Decimal)reader["ENT_COURSE_PKG_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCoursePkgDtl>(
					key.ToString(), // EntityTrackingKey
					"EntCoursePkgDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCoursePkgDtl();
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
					c.EntCoursePkgDtlId = (System.Decimal)reader["ENT_COURSE_PKG_DTL_ID"];
					c.OriginalEntCoursePkgDtlId = c.EntCoursePkgDtlId;
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EntCoursePkgHdrId = Convert.IsDBNull(reader["ENT_COURSE_PKG_HDR_ID"]) ? null : (System.Decimal?)reader["ENT_COURSE_PKG_HDR_ID"];
					c.AddGpaFlg = (System.Decimal)reader["ADD_GPA_FLG"];
					c.AddMjrgpaFlg = Convert.IsDBNull(reader["ADD_MJRGPA_FLG"]) ? null : (System.Decimal?)reader["ADD_MJRGPA_FLG"];
					c.CrsExpFlg = Convert.IsDBNull(reader["CRS_EXP_FLG"]) ? null : (System.Decimal?)reader["CRS_EXP_FLG"];
					c.CrsExp = Convert.IsDBNull(reader["CRS_EXP"]) ? null : (System.String)reader["CRS_EXP"];
					c.CrsExpNameAr = Convert.IsDBNull(reader["CRS_EXP_NAME_AR"]) ? null : (System.String)reader["CRS_EXP_NAME_AR"];
					c.CrsExpNameEn = Convert.IsDBNull(reader["CRS_EXP_NAME_EN"]) ? null : (System.String)reader["CRS_EXP_NAME_EN"];
					c.EdCourseExpHdrId = Convert.IsDBNull(reader["ED_COURSE_EXP_HDR_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_EXP_HDR_ID"];
					c.EdCourseExpPrereqHdrId = Convert.IsDBNull(reader["ED_COURSE_EXP_PREREQ_HDR_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_EXP_PREREQ_HDR_ID"];
					c.CreditHours = Convert.IsDBNull(reader["CREDIT_HOURS"]) ? null : (System.Decimal?)reader["CREDIT_HOURS"];
					c.LoadWithTrain = Convert.IsDBNull(reader["LOAD_WITH_TRAIN"]) ? null : (System.Decimal?)reader["LOAD_WITH_TRAIN"];
					c.PrereqFlg = Convert.IsDBNull(reader["PREREQ_FLG"]) ? null : (System.Decimal?)reader["PREREQ_FLG"];
					c.PrereqCodeExp = Convert.IsDBNull(reader["PREREQ_CODE_EXP"]) ? null : (System.String)reader["PREREQ_CODE_EXP"];
					c.PrereqIdExp = Convert.IsDBNull(reader["PREREQ_ID_EXP"]) ? null : (System.String)reader["PREREQ_ID_EXP"];
					c.FailFlg = (System.Decimal)reader["FAIL_FLG"];
					c.PrereqStatusFlg = Convert.IsDBNull(reader["PREREQ_STATUS_FLG"]) ? null : (System.Decimal?)reader["PREREQ_STATUS_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCoursePkgDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCoursePkgDtlId = (System.Decimal)reader[((int)EntCoursePkgDtlColumn.EntCoursePkgDtlId - 1)];
			entity.OriginalEntCoursePkgDtlId = (System.Decimal)reader["ENT_COURSE_PKG_DTL_ID"];
			entity.EdCourseId = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.EdCourseId - 1)];
			entity.EntCoursePkgHdrId = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.EntCoursePkgHdrId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.EntCoursePkgHdrId - 1)];
			entity.AddGpaFlg = (System.Decimal)reader[((int)EntCoursePkgDtlColumn.AddGpaFlg - 1)];
			entity.AddMjrgpaFlg = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.AddMjrgpaFlg - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.AddMjrgpaFlg - 1)];
			entity.CrsExpFlg = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.CrsExpFlg - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.CrsExpFlg - 1)];
			entity.CrsExp = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.CrsExp - 1)))?null:(System.String)reader[((int)EntCoursePkgDtlColumn.CrsExp - 1)];
			entity.CrsExpNameAr = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.CrsExpNameAr - 1)))?null:(System.String)reader[((int)EntCoursePkgDtlColumn.CrsExpNameAr - 1)];
			entity.CrsExpNameEn = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.CrsExpNameEn - 1)))?null:(System.String)reader[((int)EntCoursePkgDtlColumn.CrsExpNameEn - 1)];
			entity.EdCourseExpHdrId = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.EdCourseExpHdrId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.EdCourseExpHdrId - 1)];
			entity.EdCourseExpPrereqHdrId = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.EdCourseExpPrereqHdrId - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.EdCourseExpPrereqHdrId - 1)];
			entity.CreditHours = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.CreditHours - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.CreditHours - 1)];
			entity.LoadWithTrain = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.LoadWithTrain - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.LoadWithTrain - 1)];
			entity.PrereqFlg = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.PrereqFlg - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.PrereqFlg - 1)];
			entity.PrereqCodeExp = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.PrereqCodeExp - 1)))?null:(System.String)reader[((int)EntCoursePkgDtlColumn.PrereqCodeExp - 1)];
			entity.PrereqIdExp = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.PrereqIdExp - 1)))?null:(System.String)reader[((int)EntCoursePkgDtlColumn.PrereqIdExp - 1)];
			entity.FailFlg = (System.Decimal)reader[((int)EntCoursePkgDtlColumn.FailFlg - 1)];
			entity.PrereqStatusFlg = (reader.IsDBNull(((int)EntCoursePkgDtlColumn.PrereqStatusFlg - 1)))?null:(System.Decimal?)reader[((int)EntCoursePkgDtlColumn.PrereqStatusFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCoursePkgDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCoursePkgDtlId = (System.Decimal)dataRow["ENT_COURSE_PKG_DTL_ID"];
			entity.OriginalEntCoursePkgDtlId = (System.Decimal)dataRow["ENT_COURSE_PKG_DTL_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EntCoursePkgHdrId = Convert.IsDBNull(dataRow["ENT_COURSE_PKG_HDR_ID"]) ? null : (System.Decimal?)dataRow["ENT_COURSE_PKG_HDR_ID"];
			entity.AddGpaFlg = (System.Decimal)dataRow["ADD_GPA_FLG"];
			entity.AddMjrgpaFlg = Convert.IsDBNull(dataRow["ADD_MJRGPA_FLG"]) ? null : (System.Decimal?)dataRow["ADD_MJRGPA_FLG"];
			entity.CrsExpFlg = Convert.IsDBNull(dataRow["CRS_EXP_FLG"]) ? null : (System.Decimal?)dataRow["CRS_EXP_FLG"];
			entity.CrsExp = Convert.IsDBNull(dataRow["CRS_EXP"]) ? null : (System.String)dataRow["CRS_EXP"];
			entity.CrsExpNameAr = Convert.IsDBNull(dataRow["CRS_EXP_NAME_AR"]) ? null : (System.String)dataRow["CRS_EXP_NAME_AR"];
			entity.CrsExpNameEn = Convert.IsDBNull(dataRow["CRS_EXP_NAME_EN"]) ? null : (System.String)dataRow["CRS_EXP_NAME_EN"];
			entity.EdCourseExpHdrId = Convert.IsDBNull(dataRow["ED_COURSE_EXP_HDR_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_EXP_HDR_ID"];
			entity.EdCourseExpPrereqHdrId = Convert.IsDBNull(dataRow["ED_COURSE_EXP_PREREQ_HDR_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_EXP_PREREQ_HDR_ID"];
			entity.CreditHours = Convert.IsDBNull(dataRow["CREDIT_HOURS"]) ? null : (System.Decimal?)dataRow["CREDIT_HOURS"];
			entity.LoadWithTrain = Convert.IsDBNull(dataRow["LOAD_WITH_TRAIN"]) ? null : (System.Decimal?)dataRow["LOAD_WITH_TRAIN"];
			entity.PrereqFlg = Convert.IsDBNull(dataRow["PREREQ_FLG"]) ? null : (System.Decimal?)dataRow["PREREQ_FLG"];
			entity.PrereqCodeExp = Convert.IsDBNull(dataRow["PREREQ_CODE_EXP"]) ? null : (System.String)dataRow["PREREQ_CODE_EXP"];
			entity.PrereqIdExp = Convert.IsDBNull(dataRow["PREREQ_ID_EXP"]) ? null : (System.String)dataRow["PREREQ_ID_EXP"];
			entity.FailFlg = (System.Decimal)dataRow["FAIL_FLG"];
			entity.PrereqStatusFlg = Convert.IsDBNull(dataRow["PREREQ_STATUS_FLG"]) ? null : (System.Decimal?)dataRow["PREREQ_STATUS_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCoursePkgDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCoursePkgDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseExpHdrIdSource	
			if (CanDeepLoad(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepLoadType, innerList) 
				&& entity.EdCourseExpHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseExpHdrId ?? 0.0m);
				EdCourseExpHdr tmpEntity = EntityManager.LocateEntity<EdCourseExpHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseExpHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseExpHdrIdSource = tmpEntity;
				else
					entity.EdCourseExpHdrIdSource = DataRepository.EdCourseExpHdrProvider.GetByEdCourseExpHdrId(transactionManager, (entity.EdCourseExpHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseExpHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseExpHdrProvider.DeepLoad(transactionManager, entity.EdCourseExpHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseExpHdrIdSource

			#region EdCourseExpPrereqHdrIdSource	
			if (CanDeepLoad(entity, "EdCourseExpHdr|EdCourseExpPrereqHdrIdSource", deepLoadType, innerList) 
				&& entity.EdCourseExpPrereqHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseExpPrereqHdrId ?? 0.0m);
				EdCourseExpHdr tmpEntity = EntityManager.LocateEntity<EdCourseExpHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourseExpHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseExpPrereqHdrIdSource = tmpEntity;
				else
					entity.EdCourseExpPrereqHdrIdSource = DataRepository.EdCourseExpHdrProvider.GetByEdCourseExpHdrId(transactionManager, (entity.EdCourseExpPrereqHdrId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpPrereqHdrIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseExpPrereqHdrIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseExpHdrProvider.DeepLoad(transactionManager, entity.EdCourseExpPrereqHdrIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseExpPrereqHdrIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

			#region EntCoursePkgHdrIdSource	
			if (CanDeepLoad(entity, "EntCoursePkgHdr|EntCoursePkgHdrIdSource", deepLoadType, innerList) 
				&& entity.EntCoursePkgHdrIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntCoursePkgHdrId ?? 0.0m);
				EntCoursePkgHdr tmpEntity = EntityManager.LocateEntity<EntCoursePkgHdr>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCoursePkgHdr), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCoursePkgHdrIdSource = tmpEntity;
				else
					entity.EntCoursePkgHdrIdSource = DataRepository.EntCoursePkgHdrProvider.GetByEntCoursePkgHdrId(transactionManager, (entity.EntCoursePkgHdrId ?? 0.0m));		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCoursePkgDtlId methods when available
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEntCoursePkgDtlId(transactionManager, entity.EntCoursePkgDtlId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCoursePkgDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCoursePkgDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCoursePkgDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCoursePkgDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseExpHdrIdSource
			if (CanDeepSave(entity, "EdCourseExpHdr|EdCourseExpHdrIdSource", deepSaveType, innerList) 
				&& entity.EdCourseExpHdrIdSource != null)
			{
				DataRepository.EdCourseExpHdrProvider.Save(transactionManager, entity.EdCourseExpHdrIdSource);
				entity.EdCourseExpHdrId = entity.EdCourseExpHdrIdSource.EdCourseExpHdrId;
			}
			#endregion 
			
			#region EdCourseExpPrereqHdrIdSource
			if (CanDeepSave(entity, "EdCourseExpHdr|EdCourseExpPrereqHdrIdSource", deepSaveType, innerList) 
				&& entity.EdCourseExpPrereqHdrIdSource != null)
			{
				DataRepository.EdCourseExpHdrProvider.Save(transactionManager, entity.EdCourseExpPrereqHdrIdSource);
				entity.EdCourseExpPrereqHdrId = entity.EdCourseExpPrereqHdrIdSource.EdCourseExpHdrId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EntCoursePkgDtlIdSource != null)
						{
							child.EntCoursePkgDtlId = child.EntCoursePkgDtlIdSource.EntCoursePkgDtlId;
						}
						else
						{
							child.EntCoursePkgDtlId = entity.EntCoursePkgDtlId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCoursePkgDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCoursePkgDtl</c>
	///</summary>
	public enum EntCoursePkgDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourseExpHdr</c> at EdCourseExpHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourseExpHdr))]
		EdCourseExpHdr,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntCoursePkgHdr</c> at EntCoursePkgHdrIdSource
		///</summary>
		[ChildEntityType(typeof(EntCoursePkgHdr))]
		EntCoursePkgHdr,
		///<summary>
		/// Collection of <c>EntCoursePkgDtl</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
	}
	
	#endregion EntCoursePkgDtlChildEntityTypes
	
	#region EntCoursePkgDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCoursePkgDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCoursePkgDtlFilterBuilder : SqlFilterBuilder<EntCoursePkgDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlFilterBuilder class.
		/// </summary>
		public EntCoursePkgDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCoursePkgDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCoursePkgDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCoursePkgDtlFilterBuilder
	
	#region EntCoursePkgDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCoursePkgDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCoursePkgDtlParameterBuilder : ParameterizedSqlFilterBuilder<EntCoursePkgDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlParameterBuilder class.
		/// </summary>
		public EntCoursePkgDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCoursePkgDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCoursePkgDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCoursePkgDtlParameterBuilder
	
	#region EntCoursePkgDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCoursePkgDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCoursePkgDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCoursePkgDtlSortBuilder : SqlSortBuilder<EntCoursePkgDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCoursePkgDtlSqlSortBuilder class.
		/// </summary>
		public EntCoursePkgDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCoursePkgDtlSortBuilder
	
} // end namespace
