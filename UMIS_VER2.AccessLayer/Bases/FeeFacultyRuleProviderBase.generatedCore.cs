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
	/// This class is the base class for any <see cref="FeeFacultyRuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeFacultyRuleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeFacultyRule, UMIS_VER2.BusinessLyer.FeeFacultyRuleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyRuleKey key)
		{
			return Delete(transactionManager, key.FeeFacultyRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeFacultyRuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeFacultyRuleId)
		{
			return Delete(null, _feeFacultyRuleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFacultyRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE key.
		///		fkFeeFacultyRuleAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE key.
		///		fkFeeFacultyRuleAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public abstract TList<FeeFacultyRule> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFacultyRule> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeFacultyRuleAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS key.
		///		fkFeeFacultyRuleAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS key.
		///		FK_FEE_FACULTY_RULE_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public abstract TList<FeeFacultyRule> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_ACAD_YEAR key.
		///		FK_FEE_FACULTY_RULE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">XX not used</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_ACAD_YEAR key.
		///		FK_FEE_FACULTY_RULE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">XX not used</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFacultyRule> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_ACAD_YEAR key.
		///		FK_FEE_FACULTY_RULE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_ACAD_YEAR key.
		///		fkFeeFacultyRuleEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_ACAD_YEAR key.
		///		fkFeeFacultyRuleEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">XX not used</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_ACAD_YEAR key.
		///		FK_FEE_FACULTY_RULE_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public abstract TList<FeeFacultyRule> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE key.
		///		FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(_edCdeStudTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE key.
		///		FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFacultyRule> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE key.
		///		FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeStudTypeId(transactionManager, _edCdeStudTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE key.
		///		fkFeeFacultyRuleEdCdeStudType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE key.
		///		fkFeeFacultyRuleEdCdeStudType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCdeStudTypeId(System.Int32? _edCdeStudTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeStudTypeId(null, _edCdeStudTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE key.
		///		FK_FEE_FACULTY_RULE_ED_CDE_STUD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public abstract TList<FeeFacultyRule> GetByEdCdeStudTypeId(TransactionManager transactionManager, System.Int32? _edCdeStudTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER key.
		///		FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER key.
		///		FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFacultyRule> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER key.
		///		FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER key.
		///		fkFeeFacultyRuleEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER key.
		///		fkFeeFacultyRuleEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER key.
		///		FK_FEE_FACULTY_RULE_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public abstract TList<FeeFacultyRule> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_SPO_SPONSOR key.
		///		FK_FEE_FACULTY_RULE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_SPO_SPONSOR key.
		///		FK_FEE_FACULTY_RULE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		/// <remarks></remarks>
		public TList<FeeFacultyRule> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_SPO_SPONSOR key.
		///		FK_FEE_FACULTY_RULE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_SPO_SPONSOR key.
		///		fkFeeFacultyRuleSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_SPO_SPONSOR key.
		///		fkFeeFacultyRuleSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public TList<FeeFacultyRule> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_FACULTY_RULE_SPO_SPONSOR key.
		///		FK_FEE_FACULTY_RULE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeFacultyRule objects.</returns>
		public abstract TList<FeeFacultyRule> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeFacultyRule Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyRuleKey key, int start, int pageLength)
		{
			return GetByFeeFacultyRuleId(transactionManager, key.FeeFacultyRuleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public abstract TList<FeeFacultyRule> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(null,_edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_LEVEL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public abstract TList<FeeFacultyRule> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null,_edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public abstract TList<FeeFacultyRule> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEntMainId(System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public abstract TList<FeeFacultyRule> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null,_feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByFeeCodeTypeId(System.Decimal _feeCodeTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_TYPE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public abstract TList<FeeFacultyRule> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal _feeCodeTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null,_gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public TList<FeeFacultyRule> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeFacultyRule&gt;"/> class.</returns>
		public abstract TList<FeeFacultyRule> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(null,_feeFacultyRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeFacultyRuleId(transactionManager, _feeFacultyRuleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByFeeFacultyRuleId(System.Decimal _feeFacultyRuleId, int start, int pageLength, out int count)
		{
			return GetByFeeFacultyRuleId(null, _feeFacultyRuleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeFacultyRuleId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeFacultyRule GetByFeeFacultyRuleId(TransactionManager transactionManager, System.Decimal _feeFacultyRuleId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="_foreignFlg"></param>
		/// <param name="_isActive"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_isSponsor"></param>
		/// <param name="_orientFlg"></param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(System.Decimal? _asFacultyInfoId, System.Decimal? _asCodeDegreeId, System.Decimal? _edCodeLevelId, System.Decimal _entMainId, System.Decimal _feeCodeTypeId, System.Decimal _foreignFlg, System.Decimal? _isActive, System.Decimal? _edCodeSemesterTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal _isSponsor, System.Boolean? _orientFlg, System.Decimal? _edCodeSemesterId, System.Decimal? _spoSponsorId, System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(null,_asFacultyInfoId, _asCodeDegreeId, _edCodeLevelId, _entMainId, _feeCodeTypeId, _foreignFlg, _isActive, _edCodeSemesterTypeId, _asCodeDegreeClassId, _isSponsor, _orientFlg, _edCodeSemesterId, _spoSponsorId, _edCdeStudTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="_foreignFlg"></param>
		/// <param name="_isActive"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_isSponsor"></param>
		/// <param name="_orientFlg"></param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(System.Decimal? _asFacultyInfoId, System.Decimal? _asCodeDegreeId, System.Decimal? _edCodeLevelId, System.Decimal _entMainId, System.Decimal _feeCodeTypeId, System.Decimal _foreignFlg, System.Decimal? _isActive, System.Decimal? _edCodeSemesterTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal _isSponsor, System.Boolean? _orientFlg, System.Decimal? _edCodeSemesterId, System.Decimal? _spoSponsorId, System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(null, _asFacultyInfoId, _asCodeDegreeId, _edCodeLevelId, _entMainId, _feeCodeTypeId, _foreignFlg, _isActive, _edCodeSemesterTypeId, _asCodeDegreeClassId, _isSponsor, _orientFlg, _edCodeSemesterId, _spoSponsorId, _edCdeStudTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="_foreignFlg"></param>
		/// <param name="_isActive"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_isSponsor"></param>
		/// <param name="_orientFlg"></param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _asCodeDegreeId, System.Decimal? _edCodeLevelId, System.Decimal _entMainId, System.Decimal _feeCodeTypeId, System.Decimal _foreignFlg, System.Decimal? _isActive, System.Decimal? _edCodeSemesterTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal _isSponsor, System.Boolean? _orientFlg, System.Decimal? _edCodeSemesterId, System.Decimal? _spoSponsorId, System.Int32? _edCdeStudTypeId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(transactionManager, _asFacultyInfoId, _asCodeDegreeId, _edCodeLevelId, _entMainId, _feeCodeTypeId, _foreignFlg, _isActive, _edCodeSemesterTypeId, _asCodeDegreeClassId, _isSponsor, _orientFlg, _edCodeSemesterId, _spoSponsorId, _edCdeStudTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="_foreignFlg"></param>
		/// <param name="_isActive"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_isSponsor"></param>
		/// <param name="_orientFlg"></param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _asCodeDegreeId, System.Decimal? _edCodeLevelId, System.Decimal _entMainId, System.Decimal _feeCodeTypeId, System.Decimal _foreignFlg, System.Decimal? _isActive, System.Decimal? _edCodeSemesterTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal _isSponsor, System.Boolean? _orientFlg, System.Decimal? _edCodeSemesterId, System.Decimal? _spoSponsorId, System.Int32? _edCdeStudTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(transactionManager, _asFacultyInfoId, _asCodeDegreeId, _edCodeLevelId, _entMainId, _feeCodeTypeId, _foreignFlg, _isActive, _edCodeSemesterTypeId, _asCodeDegreeClassId, _isSponsor, _orientFlg, _edCodeSemesterId, _spoSponsorId, _edCdeStudTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="_foreignFlg"></param>
		/// <param name="_isActive"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_isSponsor"></param>
		/// <param name="_orientFlg"></param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeFacultyRule GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(System.Decimal? _asFacultyInfoId, System.Decimal? _asCodeDegreeId, System.Decimal? _edCodeLevelId, System.Decimal _entMainId, System.Decimal _feeCodeTypeId, System.Decimal _foreignFlg, System.Decimal? _isActive, System.Decimal? _edCodeSemesterTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal _isSponsor, System.Boolean? _orientFlg, System.Decimal? _edCodeSemesterId, System.Decimal? _spoSponsorId, System.Int32? _edCdeStudTypeId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(null, _asFacultyInfoId, _asCodeDegreeId, _edCodeLevelId, _entMainId, _feeCodeTypeId, _foreignFlg, _isActive, _edCodeSemesterTypeId, _asCodeDegreeClassId, _isSponsor, _orientFlg, _edCodeSemesterId, _spoSponsorId, _edCdeStudTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_FACULTY_RULE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="_entMainId"></param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="_foreignFlg"></param>
		/// <param name="_isActive"></param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_isSponsor"></param>
		/// <param name="_orientFlg"></param>
		/// <param name="_edCodeSemesterId">KU</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="_edCdeStudTypeId">burimi</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeFacultyRule GetByAsFacultyInfoIdAsCodeDegreeIdEdCodeLevelIdEntMainIdFeeCodeTypeIdForeignFlgIsActiveEdCodeSemesterTypeIdAsCodeDegreeClassIdIsSponsorOrientFlgEdCodeSemesterIdSpoSponsorIdEdCdeStudTypeId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, System.Decimal? _asCodeDegreeId, System.Decimal? _edCodeLevelId, System.Decimal _entMainId, System.Decimal _feeCodeTypeId, System.Decimal _foreignFlg, System.Decimal? _isActive, System.Decimal? _edCodeSemesterTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal _isSponsor, System.Boolean? _orientFlg, System.Decimal? _edCodeSemesterId, System.Decimal? _spoSponsorId, System.Int32? _edCdeStudTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeFacultyRule&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeFacultyRule&gt;"/></returns>
		public static TList<FeeFacultyRule> Fill(IDataReader reader, TList<FeeFacultyRule> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeFacultyRule c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeFacultyRule")
					.Append("|").Append((System.Decimal)reader["FEE_FACULTY_RULE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeFacultyRule>(
					key.ToString(), // EntityTrackingKey
					"FeeFacultyRule",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeFacultyRule();
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
					c.FeeFacultyRuleId = (System.Decimal)reader["FEE_FACULTY_RULE_ID"];
					c.OriginalFeeFacultyRuleId = c.FeeFacultyRuleId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.ForeignFlg = (System.Decimal)reader["FOREIGN_FLG"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.EdCodeSemesterTypeId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TYPE_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.FeeCodeTypeId = (System.Decimal)reader["FEE_CODE_TYPE_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.IsSponsor = (System.Decimal)reader["IS_SPONSOR"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Decimal?)reader["IS_ACTIVE"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.OrientFlg = Convert.IsDBNull(reader["ORIENT_FLG"]) ? null : (System.Boolean?)reader["ORIENT_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.FeeFacultyRuleAr = Convert.IsDBNull(reader["FEE_FACULTY_RULE_AR"]) ? null : (System.String)reader["FEE_FACULTY_RULE_AR"];
					c.FeeFacultyRuleEn = Convert.IsDBNull(reader["FEE_FACULTY_RULE_EN"]) ? null : (System.String)reader["FEE_FACULTY_RULE_EN"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.EdCdeStudTypeId = Convert.IsDBNull(reader["ED_CDE_STUD_TYPE_ID"]) ? null : (System.Int32?)reader["ED_CDE_STUD_TYPE_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeFacultyRule entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeFacultyRuleId = (System.Decimal)reader[((int)FeeFacultyRuleColumn.FeeFacultyRuleId - 1)];
			entity.OriginalFeeFacultyRuleId = (System.Decimal)reader["FEE_FACULTY_RULE_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)FeeFacultyRuleColumn.EntMainId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.AsFacultyInfoId - 1)];
			entity.ForeignFlg = (System.Decimal)reader[((int)FeeFacultyRuleColumn.ForeignFlg - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeFacultyRuleColumn.GsCodeCurrencyId - 1)];
			entity.EdCodeSemesterTypeId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.EdCodeSemesterTypeId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.EdCodeSemesterTypeId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.EdCodeLevelId - 1)];
			entity.FeeCodeTypeId = (System.Decimal)reader[((int)FeeFacultyRuleColumn.FeeCodeTypeId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.AsCodeDegreeClassId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.AsCodeDegreeId - 1)];
			entity.IsSponsor = (System.Decimal)reader[((int)FeeFacultyRuleColumn.IsSponsor - 1)];
			entity.IsActive = (reader.IsDBNull(((int)FeeFacultyRuleColumn.IsActive - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.IsActive - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.EdAcadYearId - 1)];
			entity.OrientFlg = (reader.IsDBNull(((int)FeeFacultyRuleColumn.OrientFlg - 1)))?null:(System.Boolean?)reader[((int)FeeFacultyRuleColumn.OrientFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeFacultyRuleColumn.Notes - 1)))?null:(System.String)reader[((int)FeeFacultyRuleColumn.Notes - 1)];
			entity.FeeFacultyRuleAr = (reader.IsDBNull(((int)FeeFacultyRuleColumn.FeeFacultyRuleAr - 1)))?null:(System.String)reader[((int)FeeFacultyRuleColumn.FeeFacultyRuleAr - 1)];
			entity.FeeFacultyRuleEn = (reader.IsDBNull(((int)FeeFacultyRuleColumn.FeeFacultyRuleEn - 1)))?null:(System.String)reader[((int)FeeFacultyRuleColumn.FeeFacultyRuleEn - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.EdCodeSemesterId - 1)];
			entity.SpoSponsorId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.SpoSponsorId - 1)];
			entity.EdCdeStudTypeId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.EdCdeStudTypeId - 1)))?null:(System.Int32?)reader[((int)FeeFacultyRuleColumn.EdCdeStudTypeId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeFacultyRuleColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeFacultyRuleColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeFacultyRuleColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeFacultyRuleColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeFacultyRule entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeFacultyRuleId = (System.Decimal)dataRow["FEE_FACULTY_RULE_ID"];
			entity.OriginalFeeFacultyRuleId = (System.Decimal)dataRow["FEE_FACULTY_RULE_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.ForeignFlg = (System.Decimal)dataRow["FOREIGN_FLG"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.EdCodeSemesterTypeId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.FeeCodeTypeId = (System.Decimal)dataRow["FEE_CODE_TYPE_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.IsSponsor = (System.Decimal)dataRow["IS_SPONSOR"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Decimal?)dataRow["IS_ACTIVE"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.OrientFlg = Convert.IsDBNull(dataRow["ORIENT_FLG"]) ? null : (System.Boolean?)dataRow["ORIENT_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.FeeFacultyRuleAr = Convert.IsDBNull(dataRow["FEE_FACULTY_RULE_AR"]) ? null : (System.String)dataRow["FEE_FACULTY_RULE_AR"];
			entity.FeeFacultyRuleEn = Convert.IsDBNull(dataRow["FEE_FACULTY_RULE_EN"]) ? null : (System.String)dataRow["FEE_FACULTY_RULE_EN"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.EdCdeStudTypeId = Convert.IsDBNull(dataRow["ED_CDE_STUD_TYPE_ID"]) ? null : (System.Int32?)dataRow["ED_CDE_STUD_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeFacultyRule"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFacultyRule Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyRule entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

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

			#region EdCdeStudTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeStudType|EdCdeStudTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeStudTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeStudTypeId ?? (int)0);
				EdCdeStudType tmpEntity = EntityManager.LocateEntity<EdCdeStudType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeStudType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeStudTypeIdSource = tmpEntity;
				else
					entity.EdCdeStudTypeIdSource = DataRepository.EdCdeStudTypeProvider.GetByEdCdeStudTypeId(transactionManager, (entity.EdCdeStudTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeStudTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeStudTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeStudTypeProvider.DeepLoad(transactionManager, entity.EdCdeStudTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeStudTypeIdSource

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelId ?? 0.0m));		
				
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

			#region EdCodeSemesterTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterTypeId ?? 0.0m);
				EdCodeSemesterType tmpEntity = EntityManager.LocateEntity<EdCodeSemesterType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemesterType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterTypeIdSource = tmpEntity;
				else
					entity.EdCodeSemesterTypeIdSource = DataRepository.EdCodeSemesterTypeProvider.GetByEdCodeSemesterTypeId(transactionManager, (entity.EdCodeSemesterTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterTypeProvider.DeepLoad(transactionManager, entity.EdCodeSemesterTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterTypeIdSource

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

			#region FeeCodeTypeIdSource	
			if (CanDeepLoad(entity, "FeeCodeType|FeeCodeTypeIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeTypeId;
				FeeCodeType tmpEntity = EntityManager.LocateEntity<FeeCodeType>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeTypeIdSource = tmpEntity;
				else
					entity.FeeCodeTypeIdSource = DataRepository.FeeCodeTypeProvider.GetByFeeCodeTypeId(transactionManager, entity.FeeCodeTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeTypeProvider.DeepLoad(transactionManager, entity.FeeCodeTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeTypeIdSource

			#region FeeFacultyRuleIdSource	
			if (CanDeepLoad(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepLoadType, innerList) 
				&& entity.FeeFacultyRuleIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeFacultyRuleId;
				FeeFacultyRule tmpEntity = EntityManager.LocateEntity<FeeFacultyRule>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeFacultyRule), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeFacultyRuleIdSource = tmpEntity;
				else
					entity.FeeFacultyRuleIdSource = DataRepository.FeeFacultyRuleProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeFacultyRuleIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeFacultyRuleProvider.DeepLoad(transactionManager, entity.FeeFacultyRuleIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeFacultyRuleIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeCurrencyId;
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

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
			// Deep load child collections  - Call GetByFeeFacultyRuleId methods when available
			
			#region FeeFacultyRule
			// RelationshipType.OneToOne
			if (CanDeepLoad(entity, "FeeFacultyRule|FeeFacultyRule", deepLoadType, innerList))
			{
				entity.FeeFacultyRule = DataRepository.FeeFacultyRuleProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRule' loaded. key " + entity.EntityTrackingKey);
				#endif 

				if (deep && entity.FeeFacultyRule != null)
				{
					deepHandles.Add("FeeFacultyRule",
						new KeyValuePair<Delegate, object>((DeepLoadSingleHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRule, deep, deepLoadType, childTypes, innerList }
					));
				}
			}
			#endregion 
			
			
			
			#region FeeItemSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemSemester>|FeeItemSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemSemesterCollection = DataRepository.FeeItemSemesterProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);

				if (deep && entity.FeeItemSemesterCollection.Count > 0)
				{
					deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemSemester>) DataRepository.FeeItemSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyItem>|FeeFacultyItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyItemCollection = DataRepository.FeeFacultyItemProvider.GetByFeeFacultyRuleId(transactionManager, entity.FeeFacultyRuleId);

				if (deep && entity.FeeFacultyItemCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyItem>) DataRepository.FeeFacultyItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeFacultyRule object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeFacultyRule instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeFacultyRule Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeFacultyRule entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
			
			#region EdCdeStudTypeIdSource
			if (CanDeepSave(entity, "EdCdeStudType|EdCdeStudTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeStudTypeIdSource != null)
			{
				DataRepository.EdCdeStudTypeProvider.Save(transactionManager, entity.EdCdeStudTypeIdSource);
				entity.EdCdeStudTypeId = entity.EdCdeStudTypeIdSource.EdCdeStudTypeId;
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
			
			#region EdCodeSemesterTypeIdSource
			if (CanDeepSave(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource != null)
			{
				DataRepository.EdCodeSemesterTypeProvider.Save(transactionManager, entity.EdCodeSemesterTypeIdSource);
				entity.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
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
			
			#region FeeCodeTypeIdSource
			if (CanDeepSave(entity, "FeeCodeType|FeeCodeTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeTypeIdSource != null)
			{
				DataRepository.FeeCodeTypeProvider.Save(transactionManager, entity.FeeCodeTypeIdSource);
				entity.FeeCodeTypeId = entity.FeeCodeTypeIdSource.FeeCodeTypeId;
			}
			#endregion 
			
			#region FeeFacultyRuleIdSource
			if (CanDeepSave(entity, "FeeFacultyRule|FeeFacultyRuleIdSource", deepSaveType, innerList) 
				&& entity.FeeFacultyRuleIdSource != null)
			{
				DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleIdSource);
				entity.FeeFacultyRuleId = entity.FeeFacultyRuleIdSource.FeeFacultyRuleId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
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

			#region FeeFacultyRule
			if (CanDeepSave(entity.FeeFacultyRule, "FeeFacultyRule|FeeFacultyRule", deepSaveType, innerList))
			{

				if (entity.FeeFacultyRule != null)
				{
					// update each child parent id with the real parent id (mostly used on insert)

					entity.FeeFacultyRule.FeeFacultyRuleId = entity.FeeFacultyRuleId;
					//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRule);
					deepHandles.Add("FeeFacultyRule",
						new KeyValuePair<Delegate, object>((DeepSaveSingleHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
						new object[] { transactionManager, entity.FeeFacultyRule, deepSaveType, childTypes, innerList }
					));
				}
			} 
			#endregion 
	
			#region List<FeeItemSemester>
				if (CanDeepSave(entity.FeeItemSemesterCollection, "List<FeeItemSemester>|FeeItemSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemSemester child in entity.FeeItemSemesterCollection)
					{
						if(child.FeeFacultyRuleIdSource != null)
						{
							child.FeeFacultyRuleId = child.FeeFacultyRuleIdSource.FeeFacultyRuleId;
						}
						else
						{
							child.FeeFacultyRuleId = entity.FeeFacultyRuleId;
						}

					}

					if (entity.FeeItemSemesterCollection.Count > 0 || entity.FeeItemSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemSemesterProvider.Save(transactionManager, entity.FeeItemSemesterCollection);
						
						deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemSemester >) DataRepository.FeeItemSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.FeeFacultyRuleIdSource != null)
						{
							child.FeeFacultyRuleId = child.FeeFacultyRuleIdSource.FeeFacultyRuleId;
						}
						else
						{
							child.FeeFacultyRuleId = entity.FeeFacultyRuleId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.FeeFacultyRuleIdSource != null)
						{
							child.FeeFacultyRuleId = child.FeeFacultyRuleIdSource.FeeFacultyRuleId;
						}
						else
						{
							child.FeeFacultyRuleId = entity.FeeFacultyRuleId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyItem>
				if (CanDeepSave(entity.FeeFacultyItemCollection, "List<FeeFacultyItem>|FeeFacultyItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyItem child in entity.FeeFacultyItemCollection)
					{
						if(child.FeeFacultyRuleIdSource != null)
						{
							child.FeeFacultyRuleId = child.FeeFacultyRuleIdSource.FeeFacultyRuleId;
						}
						else
						{
							child.FeeFacultyRuleId = entity.FeeFacultyRuleId;
						}

					}

					if (entity.FeeFacultyItemCollection.Count > 0 || entity.FeeFacultyItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyItemProvider.Save(transactionManager, entity.FeeFacultyItemCollection);
						
						deepHandles.Add("FeeFacultyItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyItem >) DataRepository.FeeFacultyItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeFacultyRuleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeFacultyRule</c>
	///</summary>
	public enum FeeFacultyRuleChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCdeStudType</c> at EdCdeStudTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeStudType))]
		EdCdeStudType,
		
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
		/// Composite Property for <c>EdCodeSemesterType</c> at EdCodeSemesterTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemesterType))]
		EdCodeSemesterType,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>FeeCodeType</c> at FeeCodeTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeType))]
		FeeCodeType,
		
		///<summary>
		/// Composite Property for <c>FeeFacultyRule</c> at FeeFacultyRuleIdSource
		///</summary>
		[ChildEntityType(typeof(FeeFacultyRule))]
		FeeFacultyRule,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
		///<summary>
		/// Collection of <c>FeeFacultyRule</c> as OneToMany for FeeItemSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemSemester>))]
		FeeItemSemesterCollection,
		///<summary>
		/// Collection of <c>FeeFacultyRule</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>FeeFacultyRule</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>FeeFacultyRule</c> as OneToMany for FeeFacultyItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyItem>))]
		FeeFacultyItemCollection,
	}
	
	#endregion FeeFacultyRuleChildEntityTypes
	
	#region FeeFacultyRuleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeFacultyRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacultyRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFacultyRuleFilterBuilder : SqlFilterBuilder<FeeFacultyRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleFilterBuilder class.
		/// </summary>
		public FeeFacultyRuleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFacultyRuleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFacultyRuleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFacultyRuleFilterBuilder
	
	#region FeeFacultyRuleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeFacultyRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacultyRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeFacultyRuleParameterBuilder : ParameterizedSqlFilterBuilder<FeeFacultyRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleParameterBuilder class.
		/// </summary>
		public FeeFacultyRuleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeFacultyRuleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeFacultyRuleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeFacultyRuleParameterBuilder
	
	#region FeeFacultyRuleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeFacultyRuleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeFacultyRule"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeFacultyRuleSortBuilder : SqlSortBuilder<FeeFacultyRuleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeFacultyRuleSqlSortBuilder class.
		/// </summary>
		public FeeFacultyRuleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeFacultyRuleSortBuilder
	
} // end namespace
