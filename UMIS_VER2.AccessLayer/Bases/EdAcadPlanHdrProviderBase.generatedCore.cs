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
	/// This class is the base class for any <see cref="EdAcadPlanHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAcadPlanHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdAcadPlanHdr, UMIS_VER2.BusinessLyer.EdAcadPlanHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanHdrKey key)
		{
			return Delete(transactionManager, key.EdAcadPlanHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edAcadPlanHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edAcadPlanHdrId)
		{
			return Delete(null, _edAcadPlanHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN key.
		///		FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN Description: 
		/// </summary>
		/// <param name="_edAcadPlanId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanId(System.Decimal _edAcadPlanId)
		{
			int count = -1;
			return GetByEdAcadPlanId(_edAcadPlanId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN key.
		///		FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanId(TransactionManager transactionManager, System.Decimal _edAcadPlanId)
		{
			int count = -1;
			return GetByEdAcadPlanId(transactionManager, _edAcadPlanId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN key.
		///		FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanId(TransactionManager transactionManager, System.Decimal _edAcadPlanId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanId(transactionManager, _edAcadPlanId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN key.
		///		fkEdAcadPlanHdrEdAcadPlan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadPlanId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanId(System.Decimal _edAcadPlanId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadPlanId(null, _edAcadPlanId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN key.
		///		fkEdAcadPlanHdrEdAcadPlan Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanId(System.Decimal _edAcadPlanId, int start, int pageLength,out int count)
		{
			return GetByEdAcadPlanId(null, _edAcadPlanId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN key.
		///		FK_ED_ACAD_PLAN_HDR_ED_ACAD_PLAN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public abstract TList<EdAcadPlanHdr> GetByEdAcadPlanId(TransactionManager transactionManager, System.Decimal _edAcadPlanId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeLevelId(System.Decimal _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL key.
		///		fkEdAcadPlanHdrEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeLevelId(System.Decimal _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL key.
		///		fkEdAcadPlanHdrEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeLevelId(System.Decimal _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public abstract TList<EdAcadPlanHdr> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER key.
		///		fkEdAcadPlanHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER key.
		///		fkEdAcadPlanHdrEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER key.
		///		FK_ED_ACAD_PLAN_HDR_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public abstract TList<EdAcadPlanHdr> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainRltdId(System.Decimal? _entMainRltdId)
		{
			int count = -1;
			return GetByEntMainRltdId(_entMainRltdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanHdr> GetByEntMainRltdId(TransactionManager transactionManager, System.Decimal? _entMainRltdId)
		{
			int count = -1;
			return GetByEntMainRltdId(transactionManager, _entMainRltdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainRltdId(TransactionManager transactionManager, System.Decimal? _entMainRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainRltdId(transactionManager, _entMainRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN key.
		///		fkEdAcadPlanHdrEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainRltdId(System.Decimal? _entMainRltdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainRltdId(null, _entMainRltdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN key.
		///		fkEdAcadPlanHdrEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainRltdId(System.Decimal? _entMainRltdId, int start, int pageLength,out int count)
		{
			return GetByEntMainRltdId(null, _entMainRltdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public abstract TList<EdAcadPlanHdr> GetByEntMainRltdId(TransactionManager transactionManager, System.Decimal? _entMainRltdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainSpcRltdId(System.Decimal? _entMainSpcRltdId)
		{
			int count = -1;
			return GetByEntMainSpcRltdId(_entMainSpcRltdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlanHdr> GetByEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal? _entMainSpcRltdId)
		{
			int count = -1;
			return GetByEntMainSpcRltdId(transactionManager, _entMainSpcRltdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal? _entMainSpcRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainSpcRltdId(transactionManager, _entMainSpcRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 key.
		///		fkEdAcadPlanHdrEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainSpcRltdId(System.Decimal? _entMainSpcRltdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainSpcRltdId(null, _entMainSpcRltdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 key.
		///		fkEdAcadPlanHdrEntityMain1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public TList<EdAcadPlanHdr> GetByEntMainSpcRltdId(System.Decimal? _entMainSpcRltdId, int start, int pageLength,out int count)
		{
			return GetByEntMainSpcRltdId(null, _entMainSpcRltdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 key.
		///		FK_ED_ACAD_PLAN_HDR_ENTITY_MAIN1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlanHdr objects.</returns>
		public abstract TList<EdAcadPlanHdr> GetByEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal? _entMainSpcRltdId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdAcadPlanHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanHdrKey key, int start, int pageLength)
		{
			return GetByEdAcadPlanHdrId(transactionManager, key.EdAcadPlanHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanHdr GetByEdAcadPlanHdrId(System.Decimal _edAcadPlanHdrId)
		{
			int count = -1;
			return GetByEdAcadPlanHdrId(null,_edAcadPlanHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanHdr GetByEdAcadPlanHdrId(System.Decimal _edAcadPlanHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanHdrId(null, _edAcadPlanHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanHdr GetByEdAcadPlanHdrId(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId)
		{
			int count = -1;
			return GetByEdAcadPlanHdrId(transactionManager, _edAcadPlanHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanHdr GetByEdAcadPlanHdrId(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanHdrId(transactionManager, _edAcadPlanHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlanHdr GetByEdAcadPlanHdrId(System.Decimal _edAcadPlanHdrId, int start, int pageLength, out int count)
		{
			return GetByEdAcadPlanHdrId(null, _edAcadPlanHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadPlanHdr GetByEdAcadPlanHdrId(TransactionManager transactionManager, System.Decimal _edAcadPlanHdrId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdAcadPlanHdr&gt;"/> class.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(System.Decimal _edAcadPlanId, System.Decimal _edCodeLevelId, System.Decimal _edCodeSemesterId, System.Decimal? _entMainRltdId, System.Decimal? _entMainSpcRltdId)
		{
			int count = -1;
			return GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(null,_edAcadPlanId, _edCodeLevelId, _edCodeSemesterId, _entMainRltdId, _entMainSpcRltdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdAcadPlanHdr&gt;"/> class.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(System.Decimal _edAcadPlanId, System.Decimal _edCodeLevelId, System.Decimal _edCodeSemesterId, System.Decimal? _entMainRltdId, System.Decimal? _entMainSpcRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(null, _edAcadPlanId, _edCodeLevelId, _edCodeSemesterId, _entMainRltdId, _entMainSpcRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdAcadPlanHdr&gt;"/> class.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal _edAcadPlanId, System.Decimal _edCodeLevelId, System.Decimal _edCodeSemesterId, System.Decimal? _entMainRltdId, System.Decimal? _entMainSpcRltdId)
		{
			int count = -1;
			return GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(transactionManager, _edAcadPlanId, _edCodeLevelId, _edCodeSemesterId, _entMainRltdId, _entMainSpcRltdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdAcadPlanHdr&gt;"/> class.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal _edAcadPlanId, System.Decimal _edCodeLevelId, System.Decimal _edCodeSemesterId, System.Decimal? _entMainRltdId, System.Decimal? _entMainSpcRltdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(transactionManager, _edAcadPlanId, _edCodeLevelId, _edCodeSemesterId, _entMainRltdId, _entMainSpcRltdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdAcadPlanHdr&gt;"/> class.</returns>
		public TList<EdAcadPlanHdr> GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(System.Decimal _edAcadPlanId, System.Decimal _edCodeLevelId, System.Decimal _edCodeSemesterId, System.Decimal? _entMainRltdId, System.Decimal? _entMainSpcRltdId, int start, int pageLength, out int count)
		{
			return GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(null, _edAcadPlanId, _edCodeLevelId, _edCodeSemesterId, _entMainRltdId, _entMainSpcRltdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="_entMainRltdId">التخصص الفرعى المرتبط</param>
		/// <param name="_entMainSpcRltdId">التخصص الدقيق المرتبط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdAcadPlanHdr&gt;"/> class.</returns>
		public abstract TList<EdAcadPlanHdr> GetByEdAcadPlanIdEdCodeLevelIdEdCodeSemesterIdEntMainRltdIdEntMainSpcRltdId(TransactionManager transactionManager, System.Decimal _edAcadPlanId, System.Decimal _edCodeLevelId, System.Decimal _edCodeSemesterId, System.Decimal? _entMainRltdId, System.Decimal? _entMainSpcRltdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdAcadPlanHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdAcadPlanHdr&gt;"/></returns>
		public static TList<EdAcadPlanHdr> Fill(IDataReader reader, TList<EdAcadPlanHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdAcadPlanHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdAcadPlanHdr")
					.Append("|").Append((System.Decimal)reader["ED_ACAD_PLAN_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdAcadPlanHdr>(
					key.ToString(), // EntityTrackingKey
					"EdAcadPlanHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdAcadPlanHdr();
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
					c.EdAcadPlanHdrId = (System.Decimal)reader["ED_ACAD_PLAN_HDR_ID"];
					c.OriginalEdAcadPlanHdrId = c.EdAcadPlanHdrId;
					c.EdAcadPlanId = (System.Decimal)reader["ED_ACAD_PLAN_ID"];
					c.EdCodeLevelId = (System.Decimal)reader["ED_CODE_LEVEL_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.EntMainRltdId = Convert.IsDBNull(reader["ENT_MAIN_RLTD_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_RLTD_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdAcadPlanHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.EdAcadPlanHdrId = (System.Decimal)reader[((int)EdAcadPlanHdrColumn.EdAcadPlanHdrId - 1)];
			entity.OriginalEdAcadPlanHdrId = (System.Decimal)reader["ED_ACAD_PLAN_HDR_ID"];
			entity.EdAcadPlanId = (System.Decimal)reader[((int)EdAcadPlanHdrColumn.EdAcadPlanId - 1)];
			entity.EdCodeLevelId = (System.Decimal)reader[((int)EdAcadPlanHdrColumn.EdCodeLevelId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdAcadPlanHdrColumn.EdCodeSemesterId - 1)];
			entity.EntMainRltdId = (reader.IsDBNull(((int)EdAcadPlanHdrColumn.EntMainRltdId - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanHdrColumn.EntMainRltdId - 1)];
			entity.EntMainSpcRltdId = (reader.IsDBNull(((int)EdAcadPlanHdrColumn.EntMainSpcRltdId - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanHdrColumn.EntMainSpcRltdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdAcadPlanHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdAcadPlanHdrId = (System.Decimal)dataRow["ED_ACAD_PLAN_HDR_ID"];
			entity.OriginalEdAcadPlanHdrId = (System.Decimal)dataRow["ED_ACAD_PLAN_HDR_ID"];
			entity.EdAcadPlanId = (System.Decimal)dataRow["ED_ACAD_PLAN_ID"];
			entity.EdCodeLevelId = (System.Decimal)dataRow["ED_CODE_LEVEL_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.EntMainRltdId = Convert.IsDBNull(dataRow["ENT_MAIN_RLTD_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_RLTD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlanHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadPlanHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadPlanIdSource	
			if (CanDeepLoad(entity, "EdAcadPlan|EdAcadPlanIdSource", deepLoadType, innerList) 
				&& entity.EdAcadPlanIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadPlanId;
				EdAcadPlan tmpEntity = EntityManager.LocateEntity<EdAcadPlan>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadPlan), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadPlanIdSource = tmpEntity;
				else
					entity.EdAcadPlanIdSource = DataRepository.EdAcadPlanProvider.GetByEdAcadPlanId(transactionManager, entity.EdAcadPlanId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadPlanIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadPlanProvider.DeepLoad(transactionManager, entity.EdAcadPlanIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadPlanIdSource

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeLevelId;
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdAcadPlanHdrId methods when available
			
			#region EdAcadPlanDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanDtl>|EdAcadPlanDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanDtlCollection = DataRepository.EdAcadPlanDtlProvider.GetByEdAcadPlanHdrId(transactionManager, entity.EdAcadPlanHdrId);

				if (deep && entity.EdAcadPlanDtlCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanDtl>) DataRepository.EdAcadPlanDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdAcadPlanHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdAcadPlanHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadPlanHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadPlanIdSource
			if (CanDeepSave(entity, "EdAcadPlan|EdAcadPlanIdSource", deepSaveType, innerList) 
				&& entity.EdAcadPlanIdSource != null)
			{
				DataRepository.EdAcadPlanProvider.Save(transactionManager, entity.EdAcadPlanIdSource);
				entity.EdAcadPlanId = entity.EdAcadPlanIdSource.EdAcadPlanId;
			}
			#endregion 
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
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
			
			#region EntMainRltdIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainRltdIdSource", deepSaveType, innerList) 
				&& entity.EntMainRltdIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainRltdIdSource);
				entity.EntMainRltdId = entity.EntMainRltdIdSource.EntMainId;
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
						if(child.EdAcadPlanHdrIdSource != null)
						{
							child.EdAcadPlanHdrId = child.EdAcadPlanHdrIdSource.EdAcadPlanHdrId;
						}
						else
						{
							child.EdAcadPlanHdrId = entity.EdAcadPlanHdrId;
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
	
	#region EdAcadPlanHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdAcadPlanHdr</c>
	///</summary>
	public enum EdAcadPlanHdrChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadPlan</c> at EdAcadPlanIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadPlan))]
		EdAcadPlan,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainRltdIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>EdAcadPlanHdr</c> as OneToMany for EdAcadPlanDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanDtl>))]
		EdAcadPlanDtlCollection,
	}
	
	#endregion EdAcadPlanHdrChildEntityTypes
	
	#region EdAcadPlanHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdAcadPlanHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlanHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadPlanHdrFilterBuilder : SqlFilterBuilder<EdAcadPlanHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanHdrFilterBuilder class.
		/// </summary>
		public EdAcadPlanHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadPlanHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadPlanHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadPlanHdrFilterBuilder
	
	#region EdAcadPlanHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdAcadPlanHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlanHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadPlanHdrParameterBuilder : ParameterizedSqlFilterBuilder<EdAcadPlanHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanHdrParameterBuilder class.
		/// </summary>
		public EdAcadPlanHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadPlanHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadPlanHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadPlanHdrParameterBuilder
	
	#region EdAcadPlanHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdAcadPlanHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlanHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdAcadPlanHdrSortBuilder : SqlSortBuilder<EdAcadPlanHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanHdrSqlSortBuilder class.
		/// </summary>
		public EdAcadPlanHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdAcadPlanHdrSortBuilder
	
} // end namespace
