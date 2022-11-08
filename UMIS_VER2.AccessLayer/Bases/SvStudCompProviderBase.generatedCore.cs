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
	/// This class is the base class for any <see cref="SvStudCompProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudCompProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudComp, UMIS_VER2.BusinessLyer.SvStudCompKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCompKey key)
		{
			return Delete(transactionManager, key.SvStudCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudCompId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudCompId)
		{
			return Delete(null, _svStudCompId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCompId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudCompId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SE_USER key.
		///		FK_SV_STUD_COMP_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SE_USER key.
		///		FK_SV_STUD_COMP_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudComp> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SE_USER key.
		///		FK_SV_STUD_COMP_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SE_USER key.
		///		fkSvStudCompSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SE_USER key.
		///		fkSvStudCompSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SE_USER key.
		///		FK_SV_STUD_COMP_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public abstract TList<SvStudComp> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_D key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_D Description: 
		/// </summary>
		/// <param name="_svCdeCompDId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompDId(System.Decimal? _svCdeCompDId)
		{
			int count = -1;
			return GetBySvCdeCompDId(_svCdeCompDId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_D key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_D Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompDId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudComp> GetBySvCdeCompDId(TransactionManager transactionManager, System.Decimal? _svCdeCompDId)
		{
			int count = -1;
			return GetBySvCdeCompDId(transactionManager, _svCdeCompDId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_D key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_D Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompDId(TransactionManager transactionManager, System.Decimal? _svCdeCompDId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompDId(transactionManager, _svCdeCompDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_D key.
		///		fkSvStudCompSvCdeCompD Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompDId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompDId(System.Decimal? _svCdeCompDId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeCompDId(null, _svCdeCompDId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_D key.
		///		fkSvStudCompSvCdeCompD Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompDId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompDId(System.Decimal? _svCdeCompDId, int start, int pageLength,out int count)
		{
			return GetBySvCdeCompDId(null, _svCdeCompDId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_D key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_D Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public abstract TList<SvStudComp> GetBySvCdeCompDId(TransactionManager transactionManager, System.Decimal? _svCdeCompDId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_H key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="_svCdeCompHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompHId(System.Decimal? _svCdeCompHId)
		{
			int count = -1;
			return GetBySvCdeCompHId(_svCdeCompHId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_H key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudComp> GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal? _svCdeCompHId)
		{
			int count = -1;
			return GetBySvCdeCompHId(transactionManager, _svCdeCompHId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_H key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal? _svCdeCompHId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompHId(transactionManager, _svCdeCompHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_H key.
		///		fkSvStudCompSvCdeCompH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompHId(System.Decimal? _svCdeCompHId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeCompHId(null, _svCdeCompHId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_H key.
		///		fkSvStudCompSvCdeCompH Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompHId(System.Decimal? _svCdeCompHId, int start, int pageLength,out int count)
		{
			return GetBySvCdeCompHId(null, _svCdeCompHId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_H key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_H Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public abstract TList<SvStudComp> GetBySvCdeCompHId(TransactionManager transactionManager, System.Decimal? _svCdeCompHId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_REPLY key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_REPLY Description: 
		/// </summary>
		/// <param name="_svCdeCompReplyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompReplyId(System.Decimal? _svCdeCompReplyId)
		{
			int count = -1;
			return GetBySvCdeCompReplyId(_svCdeCompReplyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_REPLY key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_REPLY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudComp> GetBySvCdeCompReplyId(TransactionManager transactionManager, System.Decimal? _svCdeCompReplyId)
		{
			int count = -1;
			return GetBySvCdeCompReplyId(transactionManager, _svCdeCompReplyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_REPLY key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_REPLY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompReplyId(TransactionManager transactionManager, System.Decimal? _svCdeCompReplyId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompReplyId(transactionManager, _svCdeCompReplyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_REPLY key.
		///		fkSvStudCompSvCdeCompReply Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompReplyId(System.Decimal? _svCdeCompReplyId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeCompReplyId(null, _svCdeCompReplyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_REPLY key.
		///		fkSvStudCompSvCdeCompReply Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public TList<SvStudComp> GetBySvCdeCompReplyId(System.Decimal? _svCdeCompReplyId, int start, int pageLength,out int count)
		{
			return GetBySvCdeCompReplyId(null, _svCdeCompReplyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_COMP_SV_CDE_COMP_REPLY key.
		///		FK_SV_STUD_COMP_SV_CDE_COMP_REPLY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompReplyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudComp objects.</returns>
		public abstract TList<SvStudComp> GetBySvCdeCompReplyId(TransactionManager transactionManager, System.Decimal? _svCdeCompReplyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStudComp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudCompKey key, int start, int pageLength)
		{
			return GetBySvStudCompId(transactionManager, key.SvStudCompId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public abstract TList<SvStudComp> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public abstract TList<SvStudComp> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCourseId(System.Decimal? _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public abstract TList<SvStudComp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdStudId(System.Decimal _edStudId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public abstract TList<SvStudComp> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(null,_saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public abstract TList<SvStudComp> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_CDE_COMP_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_svCdeCompTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeCompTypeId(System.Decimal _svCdeCompTypeId)
		{
			int count = -1;
			return GetBySvCdeCompTypeId(null,_svCdeCompTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_COMP_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_svCdeCompTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeCompTypeId(System.Decimal _svCdeCompTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompTypeId(null, _svCdeCompTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_COMP_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeCompTypeId(TransactionManager transactionManager, System.Decimal _svCdeCompTypeId)
		{
			int count = -1;
			return GetBySvCdeCompTypeId(transactionManager, _svCdeCompTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_COMP_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeCompTypeId(TransactionManager transactionManager, System.Decimal _svCdeCompTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeCompTypeId(transactionManager, _svCdeCompTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_COMP_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_svCdeCompTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeCompTypeId(System.Decimal _svCdeCompTypeId, int start, int pageLength, out int count)
		{
			return GetBySvCdeCompTypeId(null, _svCdeCompTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_COMP_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeCompTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public abstract TList<SvStudComp> GetBySvCdeCompTypeId(TransactionManager transactionManager, System.Decimal _svCdeCompTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SV_CDE_REQ_STATUS_ID_1 index.
		/// </summary>
		/// <param name="_svCdeReqStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeReqStatusId(System.Decimal? _svCdeReqStatusId)
		{
			int count = -1;
			return GetBySvCdeReqStatusId(null,_svCdeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_REQ_STATUS_ID_1 index.
		/// </summary>
		/// <param name="_svCdeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeReqStatusId(System.Decimal? _svCdeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeReqStatusId(null, _svCdeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_REQ_STATUS_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeReqStatusId(TransactionManager transactionManager, System.Decimal? _svCdeReqStatusId)
		{
			int count = -1;
			return GetBySvCdeReqStatusId(transactionManager, _svCdeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_REQ_STATUS_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeReqStatusId(TransactionManager transactionManager, System.Decimal? _svCdeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeReqStatusId(transactionManager, _svCdeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_REQ_STATUS_ID_1 index.
		/// </summary>
		/// <param name="_svCdeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public TList<SvStudComp> GetBySvCdeReqStatusId(System.Decimal? _svCdeReqStatusId, int start, int pageLength, out int count)
		{
			return GetBySvCdeReqStatusId(null, _svCdeReqStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SV_CDE_REQ_STATUS_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvStudComp&gt;"/> class.</returns>
		public abstract TList<SvStudComp> GetBySvCdeReqStatusId(TransactionManager transactionManager, System.Decimal? _svCdeReqStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_COMP index.
		/// </summary>
		/// <param name="_svStudCompId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudComp GetBySvStudCompId(System.Decimal _svStudCompId)
		{
			int count = -1;
			return GetBySvStudCompId(null,_svStudCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COMP index.
		/// </summary>
		/// <param name="_svStudCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudComp GetBySvStudCompId(System.Decimal _svStudCompId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudCompId(null, _svStudCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCompId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudComp GetBySvStudCompId(TransactionManager transactionManager, System.Decimal _svStudCompId)
		{
			int count = -1;
			return GetBySvStudCompId(transactionManager, _svStudCompId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudComp GetBySvStudCompId(TransactionManager transactionManager, System.Decimal _svStudCompId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudCompId(transactionManager, _svStudCompId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COMP index.
		/// </summary>
		/// <param name="_svStudCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudComp GetBySvStudCompId(System.Decimal _svStudCompId, int start, int pageLength, out int count)
		{
			return GetBySvStudCompId(null, _svStudCompId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_COMP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudCompId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudComp GetBySvStudCompId(TransactionManager transactionManager, System.Decimal _svStudCompId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudComp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudComp&gt;"/></returns>
		public static TList<SvStudComp> Fill(IDataReader reader, TList<SvStudComp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudComp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudComp")
					.Append("|").Append((System.Decimal)reader["SV_STUD_COMP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudComp>(
					key.ToString(), // EntityTrackingKey
					"SvStudComp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudComp();
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
					c.SvStudCompId = (System.Decimal)reader["SV_STUD_COMP_ID"];
					c.OriginalSvStudCompId = c.SvStudCompId;
					c.SvCdeCompTypeId = (System.Decimal)reader["SV_CDE_COMP_TYPE_ID"];
					c.CompDate = (System.DateTime)reader["COMP_DATE"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.CompDtl = (System.String)reader["COMP_DTL"];
					c.SvCdeReqStatusId = Convert.IsDBNull(reader["SV_CDE_REQ_STATUS_ID"]) ? null : (System.Decimal?)reader["SV_CDE_REQ_STATUS_ID"];
					c.CompComments = Convert.IsDBNull(reader["COMP_COMMENTS"]) ? null : (System.String)reader["COMP_COMMENTS"];
					c.ReplyDate = Convert.IsDBNull(reader["REPLY_DATE"]) ? null : (System.DateTime?)reader["REPLY_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.SvCdeCompDId = Convert.IsDBNull(reader["SV_CDE_COMP_D_ID"]) ? null : (System.Decimal?)reader["SV_CDE_COMP_D_ID"];
					c.SvCdeCompHId = Convert.IsDBNull(reader["SV_CDE_COMP_H_ID"]) ? null : (System.Decimal?)reader["SV_CDE_COMP_H_ID"];
					c.CloseFlg = Convert.IsDBNull(reader["CLOSE_FLG"]) ? null : (System.Decimal?)reader["CLOSE_FLG"];
					c.CloseDate = Convert.IsDBNull(reader["CLOSE_DATE"]) ? null : (System.DateTime?)reader["CLOSE_DATE"];
					c.SvCdeCompReplyId = Convert.IsDBNull(reader["SV_CDE_COMP_REPLY_ID"]) ? null : (System.Decimal?)reader["SV_CDE_COMP_REPLY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudComp entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudCompId = (System.Decimal)reader[((int)SvStudCompColumn.SvStudCompId - 1)];
			entity.OriginalSvStudCompId = (System.Decimal)reader["SV_STUD_COMP_ID"];
			entity.SvCdeCompTypeId = (System.Decimal)reader[((int)SvStudCompColumn.SvCdeCompTypeId - 1)];
			entity.CompDate = (System.DateTime)reader[((int)SvStudCompColumn.CompDate - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)SvStudCompColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)SvStudCompColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)SvStudCompColumn.EdCodeSemesterId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)SvStudCompColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.SaStfMemberId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)SvStudCompColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.EdCourseId - 1)];
			entity.CompDtl = (System.String)reader[((int)SvStudCompColumn.CompDtl - 1)];
			entity.SvCdeReqStatusId = (reader.IsDBNull(((int)SvStudCompColumn.SvCdeReqStatusId - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.SvCdeReqStatusId - 1)];
			entity.CompComments = (reader.IsDBNull(((int)SvStudCompColumn.CompComments - 1)))?null:(System.String)reader[((int)SvStudCompColumn.CompComments - 1)];
			entity.ReplyDate = (reader.IsDBNull(((int)SvStudCompColumn.ReplyDate - 1)))?null:(System.DateTime?)reader[((int)SvStudCompColumn.ReplyDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SvStudCompColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.SeUserId - 1)];
			entity.SvCdeCompDId = (reader.IsDBNull(((int)SvStudCompColumn.SvCdeCompDId - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.SvCdeCompDId - 1)];
			entity.SvCdeCompHId = (reader.IsDBNull(((int)SvStudCompColumn.SvCdeCompHId - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.SvCdeCompHId - 1)];
			entity.CloseFlg = (reader.IsDBNull(((int)SvStudCompColumn.CloseFlg - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.CloseFlg - 1)];
			entity.CloseDate = (reader.IsDBNull(((int)SvStudCompColumn.CloseDate - 1)))?null:(System.DateTime?)reader[((int)SvStudCompColumn.CloseDate - 1)];
			entity.SvCdeCompReplyId = (reader.IsDBNull(((int)SvStudCompColumn.SvCdeCompReplyId - 1)))?null:(System.Decimal?)reader[((int)SvStudCompColumn.SvCdeCompReplyId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudComp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudCompId = (System.Decimal)dataRow["SV_STUD_COMP_ID"];
			entity.OriginalSvStudCompId = (System.Decimal)dataRow["SV_STUD_COMP_ID"];
			entity.SvCdeCompTypeId = (System.Decimal)dataRow["SV_CDE_COMP_TYPE_ID"];
			entity.CompDate = (System.DateTime)dataRow["COMP_DATE"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.CompDtl = (System.String)dataRow["COMP_DTL"];
			entity.SvCdeReqStatusId = Convert.IsDBNull(dataRow["SV_CDE_REQ_STATUS_ID"]) ? null : (System.Decimal?)dataRow["SV_CDE_REQ_STATUS_ID"];
			entity.CompComments = Convert.IsDBNull(dataRow["COMP_COMMENTS"]) ? null : (System.String)dataRow["COMP_COMMENTS"];
			entity.ReplyDate = Convert.IsDBNull(dataRow["REPLY_DATE"]) ? null : (System.DateTime?)dataRow["REPLY_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.SvCdeCompDId = Convert.IsDBNull(dataRow["SV_CDE_COMP_D_ID"]) ? null : (System.Decimal?)dataRow["SV_CDE_COMP_D_ID"];
			entity.SvCdeCompHId = Convert.IsDBNull(dataRow["SV_CDE_COMP_H_ID"]) ? null : (System.Decimal?)dataRow["SV_CDE_COMP_H_ID"];
			entity.CloseFlg = Convert.IsDBNull(dataRow["CLOSE_FLG"]) ? null : (System.Decimal?)dataRow["CLOSE_FLG"];
			entity.CloseDate = Convert.IsDBNull(dataRow["CLOSE_DATE"]) ? null : (System.DateTime?)dataRow["CLOSE_DATE"];
			entity.SvCdeCompReplyId = Convert.IsDBNull(dataRow["SV_CDE_COMP_REPLY_ID"]) ? null : (System.Decimal?)dataRow["SV_CDE_COMP_REPLY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudComp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudComp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudComp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
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

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource

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

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource

			#region SvCdeCompDIdSource	
			if (CanDeepLoad(entity, "SvCdeCompD|SvCdeCompDIdSource", deepLoadType, innerList) 
				&& entity.SvCdeCompDIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeCompDId ?? 0.0m);
				SvCdeCompD tmpEntity = EntityManager.LocateEntity<SvCdeCompD>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeCompD), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeCompDIdSource = tmpEntity;
				else
					entity.SvCdeCompDIdSource = DataRepository.SvCdeCompDProvider.GetBySvCdeCompDId(transactionManager, (entity.SvCdeCompDId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeCompDIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeCompDIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeCompDProvider.DeepLoad(transactionManager, entity.SvCdeCompDIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeCompDIdSource

			#region SvCdeCompHIdSource	
			if (CanDeepLoad(entity, "SvCdeCompH|SvCdeCompHIdSource", deepLoadType, innerList) 
				&& entity.SvCdeCompHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeCompHId ?? 0.0m);
				SvCdeCompH tmpEntity = EntityManager.LocateEntity<SvCdeCompH>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeCompH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeCompHIdSource = tmpEntity;
				else
					entity.SvCdeCompHIdSource = DataRepository.SvCdeCompHProvider.GetBySvCdeCompHId(transactionManager, (entity.SvCdeCompHId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeCompHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeCompHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeCompHProvider.DeepLoad(transactionManager, entity.SvCdeCompHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeCompHIdSource

			#region SvCdeCompReplyIdSource	
			if (CanDeepLoad(entity, "SvCdeCompReply|SvCdeCompReplyIdSource", deepLoadType, innerList) 
				&& entity.SvCdeCompReplyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeCompReplyId ?? 0.0m);
				SvCdeCompReply tmpEntity = EntityManager.LocateEntity<SvCdeCompReply>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeCompReply), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeCompReplyIdSource = tmpEntity;
				else
					entity.SvCdeCompReplyIdSource = DataRepository.SvCdeCompReplyProvider.GetBySvCdeCompReplyId(transactionManager, (entity.SvCdeCompReplyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeCompReplyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeCompReplyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeCompReplyProvider.DeepLoad(transactionManager, entity.SvCdeCompReplyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeCompReplyIdSource

			#region SvCdeCompTypeIdSource	
			if (CanDeepLoad(entity, "SvCdeCompType|SvCdeCompTypeIdSource", deepLoadType, innerList) 
				&& entity.SvCdeCompTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvCdeCompTypeId;
				SvCdeCompType tmpEntity = EntityManager.LocateEntity<SvCdeCompType>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeCompType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeCompTypeIdSource = tmpEntity;
				else
					entity.SvCdeCompTypeIdSource = DataRepository.SvCdeCompTypeProvider.GetBySvCdeCompTypeId(transactionManager, entity.SvCdeCompTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeCompTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeCompTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeCompTypeProvider.DeepLoad(transactionManager, entity.SvCdeCompTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeCompTypeIdSource

			#region SvCdeReqStatusIdSource	
			if (CanDeepLoad(entity, "SvCdeReqStatus|SvCdeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.SvCdeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeReqStatusId ?? 0.0m);
				SvCdeReqStatus tmpEntity = EntityManager.LocateEntity<SvCdeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeReqStatusIdSource = tmpEntity;
				else
					entity.SvCdeReqStatusIdSource = DataRepository.SvCdeReqStatusProvider.GetBySvCdeReqStatusId(transactionManager, (entity.SvCdeReqStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeReqStatusProvider.DeepLoad(transactionManager, entity.SvCdeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeReqStatusIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudComp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudComp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudComp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudComp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			
			#region SvCdeCompDIdSource
			if (CanDeepSave(entity, "SvCdeCompD|SvCdeCompDIdSource", deepSaveType, innerList) 
				&& entity.SvCdeCompDIdSource != null)
			{
				DataRepository.SvCdeCompDProvider.Save(transactionManager, entity.SvCdeCompDIdSource);
				entity.SvCdeCompDId = entity.SvCdeCompDIdSource.SvCdeCompDId;
			}
			#endregion 
			
			#region SvCdeCompHIdSource
			if (CanDeepSave(entity, "SvCdeCompH|SvCdeCompHIdSource", deepSaveType, innerList) 
				&& entity.SvCdeCompHIdSource != null)
			{
				DataRepository.SvCdeCompHProvider.Save(transactionManager, entity.SvCdeCompHIdSource);
				entity.SvCdeCompHId = entity.SvCdeCompHIdSource.SvCdeCompHId;
			}
			#endregion 
			
			#region SvCdeCompReplyIdSource
			if (CanDeepSave(entity, "SvCdeCompReply|SvCdeCompReplyIdSource", deepSaveType, innerList) 
				&& entity.SvCdeCompReplyIdSource != null)
			{
				DataRepository.SvCdeCompReplyProvider.Save(transactionManager, entity.SvCdeCompReplyIdSource);
				entity.SvCdeCompReplyId = entity.SvCdeCompReplyIdSource.SvCdeCompReplyId;
			}
			#endregion 
			
			#region SvCdeCompTypeIdSource
			if (CanDeepSave(entity, "SvCdeCompType|SvCdeCompTypeIdSource", deepSaveType, innerList) 
				&& entity.SvCdeCompTypeIdSource != null)
			{
				DataRepository.SvCdeCompTypeProvider.Save(transactionManager, entity.SvCdeCompTypeIdSource);
				entity.SvCdeCompTypeId = entity.SvCdeCompTypeIdSource.SvCdeCompTypeId;
			}
			#endregion 
			
			#region SvCdeReqStatusIdSource
			if (CanDeepSave(entity, "SvCdeReqStatus|SvCdeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.SvCdeReqStatusIdSource != null)
			{
				DataRepository.SvCdeReqStatusProvider.Save(transactionManager, entity.SvCdeReqStatusIdSource);
				entity.SvCdeReqStatusId = entity.SvCdeReqStatusIdSource.SvCdeReqStatusId;
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
	
	#region SvStudCompChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudComp</c>
	///</summary>
	public enum SvStudCompChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		
		///<summary>
		/// Composite Property for <c>SvCdeCompD</c> at SvCdeCompDIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeCompD))]
		SvCdeCompD,
		
		///<summary>
		/// Composite Property for <c>SvCdeCompH</c> at SvCdeCompHIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeCompH))]
		SvCdeCompH,
		
		///<summary>
		/// Composite Property for <c>SvCdeCompReply</c> at SvCdeCompReplyIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeCompReply))]
		SvCdeCompReply,
		
		///<summary>
		/// Composite Property for <c>SvCdeCompType</c> at SvCdeCompTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeCompType))]
		SvCdeCompType,
		
		///<summary>
		/// Composite Property for <c>SvCdeReqStatus</c> at SvCdeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeReqStatus))]
		SvCdeReqStatus,
	}
	
	#endregion SvStudCompChildEntityTypes
	
	#region SvStudCompFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudCompFilterBuilder : SqlFilterBuilder<SvStudCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCompFilterBuilder class.
		/// </summary>
		public SvStudCompFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudCompFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudCompFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudCompFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudCompFilterBuilder
	
	#region SvStudCompParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudComp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudCompParameterBuilder : ParameterizedSqlFilterBuilder<SvStudCompColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCompParameterBuilder class.
		/// </summary>
		public SvStudCompParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudCompParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudCompParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudCompParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudCompParameterBuilder
	
	#region SvStudCompSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudCompColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudComp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudCompSortBuilder : SqlSortBuilder<SvStudCompColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudCompSqlSortBuilder class.
		/// </summary>
		public SvStudCompSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudCompSortBuilder
	
} // end namespace
