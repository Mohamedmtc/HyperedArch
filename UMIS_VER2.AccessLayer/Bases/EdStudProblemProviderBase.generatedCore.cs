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
	/// This class is the base class for any <see cref="EdStudProblemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudProblemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudProblem, UMIS_VER2.BusinessLyer.EdStudProblemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudProblemKey key)
		{
			return Delete(transactionManager, key.EdStudProblemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudProblemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudProblemId)
		{
			return Delete(null, _edStudProblemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudProblemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudProblemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_ACAD_YEAR key.
		///		FK_ED_STUD_PROBLEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_ACAD_YEAR key.
		///		FK_ED_STUD_PROBLEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudProblem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_ACAD_YEAR key.
		///		FK_ED_STUD_PROBLEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_ACAD_YEAR key.
		///		fkEdStudProblemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_ACAD_YEAR key.
		///		fkEdStudProblemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_ACAD_YEAR key.
		///		FK_ED_STUD_PROBLEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public abstract TList<EdStudProblem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudProblem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER key.
		///		fkEdStudProblemEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER key.
		///		fkEdStudProblemEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER key.
		///		FK_ED_STUD_PROBLEM_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public abstract TList<EdStudProblem> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_STUD key.
		///		FK_ED_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_STUD key.
		///		FK_ED_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudProblem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_STUD key.
		///		FK_ED_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_STUD key.
		///		fkEdStudProblemEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_STUD key.
		///		fkEdStudProblemEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ED_STUD key.
		///		FK_ED_STUD_PROBLEM_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public abstract TList<EdStudProblem> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="_erpOrgTreeIdFrm"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdFrm(System.Decimal? _erpOrgTreeIdFrm)
		{
			int count = -1;
			return GetByErpOrgTreeIdFrm(_erpOrgTreeIdFrm, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeIdFrm"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudProblem> GetByErpOrgTreeIdFrm(TransactionManager transactionManager, System.Decimal? _erpOrgTreeIdFrm)
		{
			int count = -1;
			return GetByErpOrgTreeIdFrm(transactionManager, _erpOrgTreeIdFrm, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeIdFrm"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdFrm(TransactionManager transactionManager, System.Decimal? _erpOrgTreeIdFrm, int start, int pageLength)
		{
			int count = -1;
			return GetByErpOrgTreeIdFrm(transactionManager, _erpOrgTreeIdFrm, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE key.
		///		fkEdStudProblemErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeIdFrm"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdFrm(System.Decimal? _erpOrgTreeIdFrm, int start, int pageLength)
		{
			int count =  -1;
			return GetByErpOrgTreeIdFrm(null, _erpOrgTreeIdFrm, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE key.
		///		fkEdStudProblemErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeIdFrm"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdFrm(System.Decimal? _erpOrgTreeIdFrm, int start, int pageLength,out int count)
		{
			return GetByErpOrgTreeIdFrm(null, _erpOrgTreeIdFrm, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeIdFrm"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public abstract TList<EdStudProblem> GetByErpOrgTreeIdFrm(TransactionManager transactionManager, System.Decimal? _erpOrgTreeIdFrm, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="_erpOrgTreeIdTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdTo(System.Decimal? _erpOrgTreeIdTo)
		{
			int count = -1;
			return GetByErpOrgTreeIdTo(_erpOrgTreeIdTo, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeIdTo"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudProblem> GetByErpOrgTreeIdTo(TransactionManager transactionManager, System.Decimal? _erpOrgTreeIdTo)
		{
			int count = -1;
			return GetByErpOrgTreeIdTo(transactionManager, _erpOrgTreeIdTo, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeIdTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdTo(TransactionManager transactionManager, System.Decimal? _erpOrgTreeIdTo, int start, int pageLength)
		{
			int count = -1;
			return GetByErpOrgTreeIdTo(transactionManager, _erpOrgTreeIdTo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 key.
		///		fkEdStudProblemErpOrgTree1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeIdTo"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdTo(System.Decimal? _erpOrgTreeIdTo, int start, int pageLength)
		{
			int count =  -1;
			return GetByErpOrgTreeIdTo(null, _erpOrgTreeIdTo, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 key.
		///		fkEdStudProblemErpOrgTree1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_erpOrgTreeIdTo"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByErpOrgTreeIdTo(System.Decimal? _erpOrgTreeIdTo, int start, int pageLength,out int count)
		{
			return GetByErpOrgTreeIdTo(null, _erpOrgTreeIdTo, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 key.
		///		FK_ED_STUD_PROBLEM_ERP_ORG_TREE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeIdTo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public abstract TList<EdStudProblem> GetByErpOrgTreeIdTo(TransactionManager transactionManager, System.Decimal? _erpOrgTreeIdTo, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_GS_CDE_VIOL key.
		///		FK_ED_STUD_PROBLEM_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="_gsCdeViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByGsCdeViolId(System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByGsCdeViolId(_gsCdeViolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_GS_CDE_VIOL key.
		///		FK_ED_STUD_PROBLEM_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudProblem> GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByGsCdeViolId(transactionManager, _gsCdeViolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_GS_CDE_VIOL key.
		///		FK_ED_STUD_PROBLEM_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolId(transactionManager, _gsCdeViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_GS_CDE_VIOL key.
		///		fkEdStudProblemGsCdeViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByGsCdeViolId(System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeViolId(null, _gsCdeViolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_GS_CDE_VIOL key.
		///		fkEdStudProblemGsCdeViol Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public TList<EdStudProblem> GetByGsCdeViolId(System.Decimal _gsCdeViolId, int start, int pageLength,out int count)
		{
			return GetByGsCdeViolId(null, _gsCdeViolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_PROBLEM_GS_CDE_VIOL key.
		///		FK_ED_STUD_PROBLEM_GS_CDE_VIOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudProblem objects.</returns>
		public abstract TList<EdStudProblem> GetByGsCdeViolId(TransactionManager transactionManager, System.Decimal _gsCdeViolId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudProblem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudProblemKey key, int start, int pageLength)
		{
			return GetByEdStudProblemId(transactionManager, key.EdStudProblemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_PROBLEM index.
		/// </summary>
		/// <param name="_edStudProblemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByEdStudProblemId(System.Decimal _edStudProblemId)
		{
			int count = -1;
			return GetByEdStudProblemId(null,_edStudProblemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PROBLEM index.
		/// </summary>
		/// <param name="_edStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByEdStudProblemId(System.Decimal _edStudProblemId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudProblemId(null, _edStudProblemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PROBLEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudProblemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByEdStudProblemId(TransactionManager transactionManager, System.Decimal _edStudProblemId)
		{
			int count = -1;
			return GetByEdStudProblemId(transactionManager, _edStudProblemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PROBLEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByEdStudProblemId(TransactionManager transactionManager, System.Decimal _edStudProblemId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudProblemId(transactionManager, _edStudProblemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PROBLEM index.
		/// </summary>
		/// <param name="_edStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByEdStudProblemId(System.Decimal _edStudProblemId, int start, int pageLength, out int count)
		{
			return GetByEdStudProblemId(null, _edStudProblemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_PROBLEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudProblemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudProblem GetByEdStudProblemId(TransactionManager transactionManager, System.Decimal _edStudProblemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key STUD_PROBLEM_CHECK index.
		/// </summary>
		/// <param name="_probDate"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByProbDateEdStudIdGsCdeViolId(System.DateTime _probDate, System.Decimal _edStudId, System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByProbDateEdStudIdGsCdeViolId(null,_probDate, _edStudId, _gsCdeViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_PROBLEM_CHECK index.
		/// </summary>
		/// <param name="_probDate"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByProbDateEdStudIdGsCdeViolId(System.DateTime _probDate, System.Decimal _edStudId, System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByProbDateEdStudIdGsCdeViolId(null, _probDate, _edStudId, _gsCdeViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_PROBLEM_CHECK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_probDate"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByProbDateEdStudIdGsCdeViolId(TransactionManager transactionManager, System.DateTime _probDate, System.Decimal _edStudId, System.Decimal _gsCdeViolId)
		{
			int count = -1;
			return GetByProbDateEdStudIdGsCdeViolId(transactionManager, _probDate, _edStudId, _gsCdeViolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_PROBLEM_CHECK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_probDate"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByProbDateEdStudIdGsCdeViolId(TransactionManager transactionManager, System.DateTime _probDate, System.Decimal _edStudId, System.Decimal _gsCdeViolId, int start, int pageLength)
		{
			int count = -1;
			return GetByProbDateEdStudIdGsCdeViolId(transactionManager, _probDate, _edStudId, _gsCdeViolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_PROBLEM_CHECK index.
		/// </summary>
		/// <param name="_probDate"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudProblem GetByProbDateEdStudIdGsCdeViolId(System.DateTime _probDate, System.Decimal _edStudId, System.Decimal _gsCdeViolId, int start, int pageLength, out int count)
		{
			return GetByProbDateEdStudIdGsCdeViolId(null, _probDate, _edStudId, _gsCdeViolId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the STUD_PROBLEM_CHECK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_probDate"></param>
		/// <param name="_edStudId"></param>
		/// <param name="_gsCdeViolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudProblem GetByProbDateEdStudIdGsCdeViolId(TransactionManager transactionManager, System.DateTime _probDate, System.Decimal _edStudId, System.Decimal _gsCdeViolId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudProblem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudProblem&gt;"/></returns>
		public static TList<EdStudProblem> Fill(IDataReader reader, TList<EdStudProblem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudProblem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudProblem")
					.Append("|").Append((System.Decimal)reader["ED_STUD_PROBLEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudProblem>(
					key.ToString(), // EntityTrackingKey
					"EdStudProblem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudProblem();
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
					c.EdStudProblemId = (System.Decimal)reader["ED_STUD_PROBLEM_ID"];
					c.OriginalEdStudProblemId = c.EdStudProblemId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.ProbDate = (System.DateTime)reader["PROB_DATE"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.Decision = Convert.IsDBNull(reader["DECISION"]) ? null : (System.String)reader["DECISION"];
					c.ErpOrgTreeIdFrm = Convert.IsDBNull(reader["ERP_ORG_TREE_ID_FRM"]) ? null : (System.Decimal?)reader["ERP_ORG_TREE_ID_FRM"];
					c.ErpOrgTreeIdTo = Convert.IsDBNull(reader["ERP_ORG_TREE_ID_TO"]) ? null : (System.Decimal?)reader["ERP_ORG_TREE_ID_TO"];
					c.GsCdeViolId = (System.Decimal)reader["GS_CDE_VIOL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudProblem entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudProblemId = (System.Decimal)reader[((int)EdStudProblemColumn.EdStudProblemId - 1)];
			entity.OriginalEdStudProblemId = (System.Decimal)reader["ED_STUD_PROBLEM_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)EdStudProblemColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)EdStudProblemColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudProblemColumn.EdCodeSemesterId - 1)];
			entity.ProbDate = (System.DateTime)reader[((int)EdStudProblemColumn.ProbDate - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)EdStudProblemColumn.EdStudId - 1)];
			entity.Decision = (reader.IsDBNull(((int)EdStudProblemColumn.Decision - 1)))?null:(System.String)reader[((int)EdStudProblemColumn.Decision - 1)];
			entity.ErpOrgTreeIdFrm = (reader.IsDBNull(((int)EdStudProblemColumn.ErpOrgTreeIdFrm - 1)))?null:(System.Decimal?)reader[((int)EdStudProblemColumn.ErpOrgTreeIdFrm - 1)];
			entity.ErpOrgTreeIdTo = (reader.IsDBNull(((int)EdStudProblemColumn.ErpOrgTreeIdTo - 1)))?null:(System.Decimal?)reader[((int)EdStudProblemColumn.ErpOrgTreeIdTo - 1)];
			entity.GsCdeViolId = (System.Decimal)reader[((int)EdStudProblemColumn.GsCdeViolId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudProblem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudProblemId = (System.Decimal)dataRow["ED_STUD_PROBLEM_ID"];
			entity.OriginalEdStudProblemId = (System.Decimal)dataRow["ED_STUD_PROBLEM_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.ProbDate = (System.DateTime)dataRow["PROB_DATE"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.Decision = Convert.IsDBNull(dataRow["DECISION"]) ? null : (System.String)dataRow["DECISION"];
			entity.ErpOrgTreeIdFrm = Convert.IsDBNull(dataRow["ERP_ORG_TREE_ID_FRM"]) ? null : (System.Decimal?)dataRow["ERP_ORG_TREE_ID_FRM"];
			entity.ErpOrgTreeIdTo = Convert.IsDBNull(dataRow["ERP_ORG_TREE_ID_TO"]) ? null : (System.Decimal?)dataRow["ERP_ORG_TREE_ID_TO"];
			entity.GsCdeViolId = (System.Decimal)dataRow["GS_CDE_VIOL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudProblem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudProblem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudProblem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
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

			#region ErpOrgTreeIdFrmSource	
			if (CanDeepLoad(entity, "ErpOrgTree|ErpOrgTreeIdFrmSource", deepLoadType, innerList) 
				&& entity.ErpOrgTreeIdFrmSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ErpOrgTreeIdFrm ?? 0.0m);
				ErpOrgTree tmpEntity = EntityManager.LocateEntity<ErpOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ErpOrgTreeIdFrmSource = tmpEntity;
				else
					entity.ErpOrgTreeIdFrmSource = DataRepository.ErpOrgTreeProvider.GetByErpOrgTreeId(transactionManager, (entity.ErpOrgTreeIdFrm ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpOrgTreeIdFrmSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ErpOrgTreeIdFrmSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpOrgTreeProvider.DeepLoad(transactionManager, entity.ErpOrgTreeIdFrmSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ErpOrgTreeIdFrmSource

			#region ErpOrgTreeIdToSource	
			if (CanDeepLoad(entity, "ErpOrgTree|ErpOrgTreeIdToSource", deepLoadType, innerList) 
				&& entity.ErpOrgTreeIdToSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ErpOrgTreeIdTo ?? 0.0m);
				ErpOrgTree tmpEntity = EntityManager.LocateEntity<ErpOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ErpOrgTreeIdToSource = tmpEntity;
				else
					entity.ErpOrgTreeIdToSource = DataRepository.ErpOrgTreeProvider.GetByErpOrgTreeId(transactionManager, (entity.ErpOrgTreeIdTo ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpOrgTreeIdToSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ErpOrgTreeIdToSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpOrgTreeProvider.DeepLoad(transactionManager, entity.ErpOrgTreeIdToSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ErpOrgTreeIdToSource

			#region GsCdeViolIdSource	
			if (CanDeepLoad(entity, "GsCdeViol|GsCdeViolIdSource", deepLoadType, innerList) 
				&& entity.GsCdeViolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeViolId;
				GsCdeViol tmpEntity = EntityManager.LocateEntity<GsCdeViol>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeViol), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeViolIdSource = tmpEntity;
				else
					entity.GsCdeViolIdSource = DataRepository.GsCdeViolProvider.GetByGsCdeViolId(transactionManager, entity.GsCdeViolId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeViolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeViolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeViolProvider.DeepLoad(transactionManager, entity.GsCdeViolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeViolIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudProblem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudProblem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudProblem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudProblem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region ErpOrgTreeIdFrmSource
			if (CanDeepSave(entity, "ErpOrgTree|ErpOrgTreeIdFrmSource", deepSaveType, innerList) 
				&& entity.ErpOrgTreeIdFrmSource != null)
			{
				DataRepository.ErpOrgTreeProvider.Save(transactionManager, entity.ErpOrgTreeIdFrmSource);
				entity.ErpOrgTreeIdFrm = entity.ErpOrgTreeIdFrmSource.ErpOrgTreeId;
			}
			#endregion 
			
			#region ErpOrgTreeIdToSource
			if (CanDeepSave(entity, "ErpOrgTree|ErpOrgTreeIdToSource", deepSaveType, innerList) 
				&& entity.ErpOrgTreeIdToSource != null)
			{
				DataRepository.ErpOrgTreeProvider.Save(transactionManager, entity.ErpOrgTreeIdToSource);
				entity.ErpOrgTreeIdTo = entity.ErpOrgTreeIdToSource.ErpOrgTreeId;
			}
			#endregion 
			
			#region GsCdeViolIdSource
			if (CanDeepSave(entity, "GsCdeViol|GsCdeViolIdSource", deepSaveType, innerList) 
				&& entity.GsCdeViolIdSource != null)
			{
				DataRepository.GsCdeViolProvider.Save(transactionManager, entity.GsCdeViolIdSource);
				entity.GsCdeViolId = entity.GsCdeViolIdSource.GsCdeViolId;
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
	
	#region EdStudProblemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudProblem</c>
	///</summary>
	public enum EdStudProblemChildEntityTypes
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>ErpOrgTree</c> at ErpOrgTreeIdFrmSource
		///</summary>
		[ChildEntityType(typeof(ErpOrgTree))]
		ErpOrgTree,
		
		///<summary>
		/// Composite Property for <c>GsCdeViol</c> at GsCdeViolIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeViol))]
		GsCdeViol,
	}
	
	#endregion EdStudProblemChildEntityTypes
	
	#region EdStudProblemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudProblemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudProblem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudProblemFilterBuilder : SqlFilterBuilder<EdStudProblemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudProblemFilterBuilder class.
		/// </summary>
		public EdStudProblemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudProblemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudProblemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudProblemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudProblemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudProblemFilterBuilder
	
	#region EdStudProblemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudProblemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudProblem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudProblemParameterBuilder : ParameterizedSqlFilterBuilder<EdStudProblemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudProblemParameterBuilder class.
		/// </summary>
		public EdStudProblemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudProblemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudProblemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudProblemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudProblemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudProblemParameterBuilder
	
	#region EdStudProblemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudProblemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudProblem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudProblemSortBuilder : SqlSortBuilder<EdStudProblemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudProblemSqlSortBuilder class.
		/// </summary>
		public EdStudProblemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudProblemSortBuilder
	
} // end namespace
