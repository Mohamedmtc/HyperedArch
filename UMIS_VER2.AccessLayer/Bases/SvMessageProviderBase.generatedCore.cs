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
	/// This class is the base class for any <see cref="SvMessageProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvMessageProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvMessage, UMIS_VER2.BusinessLyer.SvMessageKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessageKey key)
		{
			return Delete(transactionManager, key.SvMessageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svMessageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svMessageId)
		{
			return Delete(null, _svMessageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svMessageId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		/// <remarks></remarks>
		public TList<SvMessage> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_ADM_APPLICANT key.
		///		fkSvMessageAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_ADM_APPLICANT key.
		///		fkSvMessageAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_ADM_APPLICANT key.
		///		FK_SV_MESSAGE_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public abstract TList<SvMessage> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="_seUserAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySeUserAccntId(System.Decimal? _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(_seUserAccntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		/// <remarks></remarks>
		public TList<SvMessage> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal? _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal? _seUserAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SE_USER_ACCNT key.
		///		fkSvMessageSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySeUserAccntId(System.Decimal? _seUserAccntId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SE_USER_ACCNT key.
		///		fkSvMessageSeUserAccnt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySeUserAccntId(System.Decimal? _seUserAccntId, int start, int pageLength,out int count)
		{
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SE_USER_ACCNT key.
		///		FK_SV_MESSAGE_SE_USER_ACCNT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public abstract TList<SvMessage> GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal? _seUserAccntId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(_svAutoMsgTmpltId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		/// <remarks></remarks>
		public TList<SvMessage> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT key.
		///		fkSvMessageSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT key.
		///		fkSvMessageSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public TList<SvMessage> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId, int start, int pageLength,out int count)
		{
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT key.
		///		FK_SV_MESSAGE_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvMessage objects.</returns>
		public abstract TList<SvMessage> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvMessage Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessageKey key, int start, int pageLength)
		{
			return GetBySvMessageId(transactionManager, key.SvMessageId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdAcadYearId(System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public abstract TList<SvMessage> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public TList<SvMessage> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SvMessage&gt;"/> class.</returns>
		public abstract TList<SvMessage> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_MESSAGE index.
		/// </summary>
		/// <param name="_svMessageId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessage GetBySvMessageId(System.Decimal _svMessageId)
		{
			int count = -1;
			return GetBySvMessageId(null,_svMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE index.
		/// </summary>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessage GetBySvMessageId(System.Decimal _svMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMessageId(null, _svMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessage GetBySvMessageId(TransactionManager transactionManager, System.Decimal _svMessageId)
		{
			int count = -1;
			return GetBySvMessageId(transactionManager, _svMessageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessage GetBySvMessageId(TransactionManager transactionManager, System.Decimal _svMessageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvMessageId(transactionManager, _svMessageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE index.
		/// </summary>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvMessage GetBySvMessageId(System.Decimal _svMessageId, int start, int pageLength, out int count)
		{
			return GetBySvMessageId(null, _svMessageId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_MESSAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svMessageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvMessage GetBySvMessageId(TransactionManager transactionManager, System.Decimal _svMessageId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvMessage&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvMessage&gt;"/></returns>
		public static TList<SvMessage> Fill(IDataReader reader, TList<SvMessage> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvMessage c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvMessage")
					.Append("|").Append((System.Decimal)reader["SV_MESSAGE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvMessage>(
					key.ToString(), // EntityTrackingKey
					"SvMessage",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvMessage();
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
					c.SvMessageId = (System.Decimal)reader["SV_MESSAGE_ID"];
					c.OriginalSvMessageId = c.SvMessageId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.MsgContent = (System.String)reader["MSG_CONTENT"];
					c.MsgDate = (System.DateTime)reader["MSG_DATE"];
					c.MsgSubject = Convert.IsDBNull(reader["MSG_SUBJECT"]) ? null : (System.String)reader["MSG_SUBJECT"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.DeleteFlg = Convert.IsDBNull(reader["DELETE_FLG"]) ? null : (System.Decimal?)reader["DELETE_FLG"];
					c.SeUserAccntId = Convert.IsDBNull(reader["SE_USER_ACCNT_ID"]) ? null : (System.Decimal?)reader["SE_USER_ACCNT_ID"];
					c.NotifyFlg = Convert.IsDBNull(reader["NOTIFY_FLG"]) ? null : (System.Boolean?)reader["NOTIFY_FLG"];
					c.InboxFlg = Convert.IsDBNull(reader["INBOX_FLG"]) ? null : (System.Boolean?)reader["INBOX_FLG"];
					c.AutoFlg = Convert.IsDBNull(reader["AUTO_FLG"]) ? null : (System.Boolean?)reader["AUTO_FLG"];
					c.SvAutoMsgTmpltId = Convert.IsDBNull(reader["SV_AUTO_MSG_TMPLT_ID"]) ? null : (System.Decimal?)reader["SV_AUTO_MSG_TMPLT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvMessage entity)
		{
			if (!reader.Read()) return;
			
			entity.SvMessageId = (System.Decimal)reader[((int)SvMessageColumn.SvMessageId - 1)];
			entity.OriginalSvMessageId = (System.Decimal)reader["SV_MESSAGE_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)SvMessageColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)SvMessageColumn.EdCodeSemesterId - 1)];
			entity.MsgContent = (System.String)reader[((int)SvMessageColumn.MsgContent - 1)];
			entity.MsgDate = (System.DateTime)reader[((int)SvMessageColumn.MsgDate - 1)];
			entity.MsgSubject = (reader.IsDBNull(((int)SvMessageColumn.MsgSubject - 1)))?null:(System.String)reader[((int)SvMessageColumn.MsgSubject - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)SvMessageColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)SvMessageColumn.AdmApplicantId - 1)];
			entity.DeleteFlg = (reader.IsDBNull(((int)SvMessageColumn.DeleteFlg - 1)))?null:(System.Decimal?)reader[((int)SvMessageColumn.DeleteFlg - 1)];
			entity.SeUserAccntId = (reader.IsDBNull(((int)SvMessageColumn.SeUserAccntId - 1)))?null:(System.Decimal?)reader[((int)SvMessageColumn.SeUserAccntId - 1)];
			entity.NotifyFlg = (reader.IsDBNull(((int)SvMessageColumn.NotifyFlg - 1)))?null:(System.Boolean?)reader[((int)SvMessageColumn.NotifyFlg - 1)];
			entity.InboxFlg = (reader.IsDBNull(((int)SvMessageColumn.InboxFlg - 1)))?null:(System.Boolean?)reader[((int)SvMessageColumn.InboxFlg - 1)];
			entity.AutoFlg = (reader.IsDBNull(((int)SvMessageColumn.AutoFlg - 1)))?null:(System.Boolean?)reader[((int)SvMessageColumn.AutoFlg - 1)];
			entity.SvAutoMsgTmpltId = (reader.IsDBNull(((int)SvMessageColumn.SvAutoMsgTmpltId - 1)))?null:(System.Decimal?)reader[((int)SvMessageColumn.SvAutoMsgTmpltId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvMessage entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvMessageId = (System.Decimal)dataRow["SV_MESSAGE_ID"];
			entity.OriginalSvMessageId = (System.Decimal)dataRow["SV_MESSAGE_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.MsgContent = (System.String)dataRow["MSG_CONTENT"];
			entity.MsgDate = (System.DateTime)dataRow["MSG_DATE"];
			entity.MsgSubject = Convert.IsDBNull(dataRow["MSG_SUBJECT"]) ? null : (System.String)dataRow["MSG_SUBJECT"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.DeleteFlg = Convert.IsDBNull(dataRow["DELETE_FLG"]) ? null : (System.Decimal?)dataRow["DELETE_FLG"];
			entity.SeUserAccntId = Convert.IsDBNull(dataRow["SE_USER_ACCNT_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ACCNT_ID"];
			entity.NotifyFlg = Convert.IsDBNull(dataRow["NOTIFY_FLG"]) ? null : (System.Boolean?)dataRow["NOTIFY_FLG"];
			entity.InboxFlg = Convert.IsDBNull(dataRow["INBOX_FLG"]) ? null : (System.Boolean?)dataRow["INBOX_FLG"];
			entity.AutoFlg = Convert.IsDBNull(dataRow["AUTO_FLG"]) ? null : (System.Boolean?)dataRow["AUTO_FLG"];
			entity.SvAutoMsgTmpltId = Convert.IsDBNull(dataRow["SV_AUTO_MSG_TMPLT_ID"]) ? null : (System.Decimal?)dataRow["SV_AUTO_MSG_TMPLT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvMessage"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvMessage Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessage entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SeUserAccntIdSource	
			if (CanDeepLoad(entity, "SeUserAccnt|SeUserAccntIdSource", deepLoadType, innerList) 
				&& entity.SeUserAccntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserAccntId ?? 0.0m);
				SeUserAccnt tmpEntity = EntityManager.LocateEntity<SeUserAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUserAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserAccntIdSource = tmpEntity;
				else
					entity.SeUserAccntIdSource = DataRepository.SeUserAccntProvider.GetBySeUserAccntId(transactionManager, (entity.SeUserAccntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserAccntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserAccntProvider.DeepLoad(transactionManager, entity.SeUserAccntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserAccntIdSource

			#region SvAutoMsgTmpltIdSource	
			if (CanDeepLoad(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepLoadType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvAutoMsgTmpltId ?? 0.0m);
				SvAutoMsgTmplt tmpEntity = EntityManager.LocateEntity<SvAutoMsgTmplt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvAutoMsgTmplt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvAutoMsgTmpltIdSource = tmpEntity;
				else
					entity.SvAutoMsgTmpltIdSource = DataRepository.SvAutoMsgTmpltProvider.GetBySvAutoMsgTmpltId(transactionManager, (entity.SvAutoMsgTmpltId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmpltIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvAutoMsgTmpltIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvAutoMsgTmpltProvider.DeepLoad(transactionManager, entity.SvAutoMsgTmpltIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvAutoMsgTmpltIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvMessageId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetBySvMessageId(transactionManager, entity.SvMessageId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserMessage>|SvUserMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserMessageCollection = DataRepository.SvUserMessageProvider.GetBySvMessageId(transactionManager, entity.SvMessageId);

				if (deep && entity.SvUserMessageCollection.Count > 0)
				{
					deepHandles.Add("SvUserMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserMessage>) DataRepository.SvUserMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserMessageCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvMessage object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvMessage instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvMessage Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvMessage entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SeUserAccntIdSource
			if (CanDeepSave(entity, "SeUserAccnt|SeUserAccntIdSource", deepSaveType, innerList) 
				&& entity.SeUserAccntIdSource != null)
			{
				DataRepository.SeUserAccntProvider.Save(transactionManager, entity.SeUserAccntIdSource);
				entity.SeUserAccntId = entity.SeUserAccntIdSource.SeUserAccntId;
			}
			#endregion 
			
			#region SvAutoMsgTmpltIdSource
			if (CanDeepSave(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepSaveType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource != null)
			{
				DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmpltIdSource);
				entity.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.SvMessageIdSource != null)
						{
							child.SvMessageId = child.SvMessageIdSource.SvMessageId;
						}
						else
						{
							child.SvMessageId = entity.SvMessageId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserMessage>
				if (CanDeepSave(entity.SvUserMessageCollection, "List<SvUserMessage>|SvUserMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserMessage child in entity.SvUserMessageCollection)
					{
						if(child.SvMessageIdSource != null)
						{
							child.SvMessageId = child.SvMessageIdSource.SvMessageId;
						}
						else
						{
							child.SvMessageId = entity.SvMessageId;
						}

					}

					if (entity.SvUserMessageCollection.Count > 0 || entity.SvUserMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserMessageProvider.Save(transactionManager, entity.SvUserMessageCollection);
						
						deepHandles.Add("SvUserMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserMessage >) DataRepository.SvUserMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserMessageCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvMessageChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvMessage</c>
	///</summary>
	public enum SvMessageChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
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
		/// Composite Property for <c>SeUserAccnt</c> at SeUserAccntIdSource
		///</summary>
		[ChildEntityType(typeof(SeUserAccnt))]
		SeUserAccnt,
		
		///<summary>
		/// Composite Property for <c>SvAutoMsgTmplt</c> at SvAutoMsgTmpltIdSource
		///</summary>
		[ChildEntityType(typeof(SvAutoMsgTmplt))]
		SvAutoMsgTmplt,
		///<summary>
		/// Collection of <c>SvMessage</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>SvMessage</c> as OneToMany for SvUserMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserMessage>))]
		SvUserMessageCollection,
	}
	
	#endregion SvMessageChildEntityTypes
	
	#region SvMessageFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMessage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvMessageFilterBuilder : SqlFilterBuilder<SvMessageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMessageFilterBuilder class.
		/// </summary>
		public SvMessageFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvMessageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvMessageFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvMessageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvMessageFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvMessageFilterBuilder
	
	#region SvMessageParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMessage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvMessageParameterBuilder : ParameterizedSqlFilterBuilder<SvMessageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMessageParameterBuilder class.
		/// </summary>
		public SvMessageParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvMessageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvMessageParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvMessageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvMessageParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvMessageParameterBuilder
	
	#region SvMessageSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvMessageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvMessage"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvMessageSortBuilder : SqlSortBuilder<SvMessageColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvMessageSqlSortBuilder class.
		/// </summary>
		public SvMessageSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvMessageSortBuilder
	
} // end namespace
