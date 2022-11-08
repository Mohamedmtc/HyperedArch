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
	/// This class is the base class for any <see cref="EntPolicyAbsenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyAbsenceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyAbsence, UMIS_VER2.BusinessLyer.EntPolicyAbsenceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAbsenceKey key)
		{
			return Delete(transactionManager, key.EntPolicyAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyAbsenceId)
		{
			return Delete(null, _entPolicyAbsenceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAbsenceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyAbsenceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_BYLAW key.
		///		FK_ENT_POLICY_ABSENCE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdBylawId(System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(_edBylawId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_BYLAW key.
		///		FK_ENT_POLICY_ABSENCE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAbsence> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_BYLAW key.
		///		FK_ENT_POLICY_ABSENCE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawId(transactionManager, _edBylawId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_BYLAW key.
		///		fkEntPolicyAbsenceEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdBylawId(null, _edBylawId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_BYLAW key.
		///		fkEntPolicyAbsenceEdBylaw Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edBylawId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdBylawId(System.Decimal _edBylawId, int start, int pageLength,out int count)
		{
			return GetByEdBylawId(null, _edBylawId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_BYLAW key.
		///		FK_ENT_POLICY_ABSENCE_ED_BYLAW Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public abstract TList<EntPolicyAbsence> GetByEdBylawId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="_edCodeCourseTeachingId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(_edCodeCourseTeachingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAbsence> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING key.
		///		fkEntPolicyAbsenceEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING key.
		///		fkEntPolicyAbsenceEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public abstract TList<EntPolicyAbsence> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		/// <remarks></remarks>
		public TList<EntPolicyAbsence> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL key.
		///		fkEntPolicyAbsenceEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL key.
		///		fkEntPolicyAbsenceEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public TList<EntPolicyAbsence> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL key.
		///		FK_ENT_POLICY_ABSENCE_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPolicyAbsence objects.</returns>
		public abstract TList<EntPolicyAbsence> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyAbsence Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAbsenceKey key, int start, int pageLength)
		{
			return GetByEntPolicyAbsenceId(transactionManager, key.EntPolicyAbsenceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_BYLAW_CR_ABSENCE index.
		/// </summary>
		/// <param name="_entPolicyAbsenceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEntPolicyAbsenceId(System.Decimal _entPolicyAbsenceId)
		{
			int count = -1;
			return GetByEntPolicyAbsenceId(null,_entPolicyAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_ABSENCE index.
		/// </summary>
		/// <param name="_entPolicyAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEntPolicyAbsenceId(System.Decimal _entPolicyAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAbsenceId(null, _entPolicyAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAbsenceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEntPolicyAbsenceId(TransactionManager transactionManager, System.Decimal _entPolicyAbsenceId)
		{
			int count = -1;
			return GetByEntPolicyAbsenceId(transactionManager, _entPolicyAbsenceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEntPolicyAbsenceId(TransactionManager transactionManager, System.Decimal _entPolicyAbsenceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyAbsenceId(transactionManager, _entPolicyAbsenceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_ABSENCE index.
		/// </summary>
		/// <param name="_entPolicyAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEntPolicyAbsenceId(System.Decimal _entPolicyAbsenceId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyAbsenceId(null, _entPolicyAbsenceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_BYLAW_CR_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyAbsenceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEntPolicyAbsenceId(TransactionManager transactionManager, System.Decimal _entPolicyAbsenceId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_POLICY_ABSENCE index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEdBylawIdEdCodeLevelId(System.Decimal _edBylawId, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLevelId(null,_edBylawId, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ABSENCE index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEdBylawIdEdCodeLevelId(System.Decimal _edBylawId, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLevelId(null, _edBylawId, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEdBylawIdEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edBylawId, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLevelId(transactionManager, _edBylawId, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEdBylawIdEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edBylawId, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdBylawIdEdCodeLevelId(transactionManager, _edBylawId, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ABSENCE index.
		/// </summary>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEdBylawIdEdCodeLevelId(System.Decimal _edBylawId, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count)
		{
			return GetByEdBylawIdEdCodeLevelId(null, _edBylawId, _edCodeLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_POLICY_ABSENCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edBylawId"></param>
		/// <param name="_edCodeLevelId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyAbsence GetByEdBylawIdEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edBylawId, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyAbsence&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyAbsence&gt;"/></returns>
		public static TList<EntPolicyAbsence> Fill(IDataReader reader, TList<EntPolicyAbsence> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyAbsence c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyAbsence")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_ABSENCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyAbsence>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyAbsence",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyAbsence();
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
					c.EntPolicyAbsenceId = (System.Decimal)reader["ENT_POLICY_ABSENCE_ID"];
					c.OriginalEntPolicyAbsenceId = c.EntPolicyAbsenceId;
					c.AbsContactHours = Convert.IsDBNull(reader["ABS_CONTACT_HOURS"]) ? null : (System.Int32?)reader["ABS_CONTACT_HOURS"];
					c.EdCodeCourseTeachingId = Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.MinRateCourseAttend = Convert.IsDBNull(reader["MIN_RATE_COURSE_ATTEND"]) ? null : (System.Decimal?)reader["MIN_RATE_COURSE_ATTEND"];
					c.AbsRateWarninig1 = Convert.IsDBNull(reader["ABS_RATE_WARNINIG_1"]) ? null : (System.Decimal?)reader["ABS_RATE_WARNINIG_1"];
					c.AbsRateWarninig2 = Convert.IsDBNull(reader["ABS_RATE_WARNINIG_2"]) ? null : (System.Decimal?)reader["ABS_RATE_WARNINIG_2"];
					c.AbsRateCourseFail = (System.Decimal)reader["ABS_RATE_COURSE_FAIL"];
					c.EdBylawId = (System.Decimal)reader["ED_BYLAW_ID"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyAbsence entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyAbsenceId = (System.Decimal)reader[((int)EntPolicyAbsenceColumn.EntPolicyAbsenceId - 1)];
			entity.OriginalEntPolicyAbsenceId = (System.Decimal)reader["ENT_POLICY_ABSENCE_ID"];
			entity.AbsContactHours = (reader.IsDBNull(((int)EntPolicyAbsenceColumn.AbsContactHours - 1)))?null:(System.Int32?)reader[((int)EntPolicyAbsenceColumn.AbsContactHours - 1)];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)EntPolicyAbsenceColumn.EdCodeCourseTeachingId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAbsenceColumn.EdCodeCourseTeachingId - 1)];
			entity.MinRateCourseAttend = (reader.IsDBNull(((int)EntPolicyAbsenceColumn.MinRateCourseAttend - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAbsenceColumn.MinRateCourseAttend - 1)];
			entity.AbsRateWarninig1 = (reader.IsDBNull(((int)EntPolicyAbsenceColumn.AbsRateWarninig1 - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAbsenceColumn.AbsRateWarninig1 - 1)];
			entity.AbsRateWarninig2 = (reader.IsDBNull(((int)EntPolicyAbsenceColumn.AbsRateWarninig2 - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAbsenceColumn.AbsRateWarninig2 - 1)];
			entity.AbsRateCourseFail = (System.Decimal)reader[((int)EntPolicyAbsenceColumn.AbsRateCourseFail - 1)];
			entity.EdBylawId = (System.Decimal)reader[((int)EntPolicyAbsenceColumn.EdBylawId - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)EntPolicyAbsenceColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)EntPolicyAbsenceColumn.EdCodeLevelId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyAbsence entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyAbsenceId = (System.Decimal)dataRow["ENT_POLICY_ABSENCE_ID"];
			entity.OriginalEntPolicyAbsenceId = (System.Decimal)dataRow["ENT_POLICY_ABSENCE_ID"];
			entity.AbsContactHours = Convert.IsDBNull(dataRow["ABS_CONTACT_HOURS"]) ? null : (System.Int32?)dataRow["ABS_CONTACT_HOURS"];
			entity.EdCodeCourseTeachingId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.MinRateCourseAttend = Convert.IsDBNull(dataRow["MIN_RATE_COURSE_ATTEND"]) ? null : (System.Decimal?)dataRow["MIN_RATE_COURSE_ATTEND"];
			entity.AbsRateWarninig1 = Convert.IsDBNull(dataRow["ABS_RATE_WARNINIG_1"]) ? null : (System.Decimal?)dataRow["ABS_RATE_WARNINIG_1"];
			entity.AbsRateWarninig2 = Convert.IsDBNull(dataRow["ABS_RATE_WARNINIG_2"]) ? null : (System.Decimal?)dataRow["ABS_RATE_WARNINIG_2"];
			entity.AbsRateCourseFail = (System.Decimal)dataRow["ABS_RATE_COURSE_FAIL"];
			entity.EdBylawId = (System.Decimal)dataRow["ED_BYLAW_ID"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyAbsence"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAbsence Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAbsence entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdBylawIdSource	
			if (CanDeepLoad(entity, "EdBylaw|EdBylawIdSource", deepLoadType, innerList) 
				&& entity.EdBylawIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdBylawId;
				EdBylaw tmpEntity = EntityManager.LocateEntity<EdBylaw>(EntityLocator.ConstructKeyFromPkItems(typeof(EdBylaw), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdBylawIdSource = tmpEntity;
				else
					entity.EdBylawIdSource = DataRepository.EdBylawProvider.GetByEdBylawId(transactionManager, entity.EdBylawId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdBylawIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdBylawProvider.DeepLoad(transactionManager, entity.EdBylawIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdBylawIdSource

			#region EdCodeCourseTeachingIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseTeachingId ?? 0.0m);
				EdCodeCourseTeaching tmpEntity = EntityManager.LocateEntity<EdCodeCourseTeaching>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseTeaching), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseTeachingIdSource = tmpEntity;
				else
					entity.EdCodeCourseTeachingIdSource = DataRepository.EdCodeCourseTeachingProvider.GetByEdCodeCourseTeachingId(transactionManager, (entity.EdCodeCourseTeachingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseTeachingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseTeachingProvider.DeepLoad(transactionManager, entity.EdCodeCourseTeachingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseTeachingIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyAbsence object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyAbsence instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyAbsence Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyAbsence entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdBylawIdSource
			if (CanDeepSave(entity, "EdBylaw|EdBylawIdSource", deepSaveType, innerList) 
				&& entity.EdBylawIdSource != null)
			{
				DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawIdSource);
				entity.EdBylawId = entity.EdBylawIdSource.EdBylawId;
			}
			#endregion 
			
			#region EdCodeCourseTeachingIdSource
			if (CanDeepSave(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource != null)
			{
				DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingIdSource);
				entity.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
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
	
	#region EntPolicyAbsenceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyAbsence</c>
	///</summary>
	public enum EntPolicyAbsenceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdBylaw</c> at EdBylawIdSource
		///</summary>
		[ChildEntityType(typeof(EdBylaw))]
		EdBylaw,
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseTeaching</c> at EdCodeCourseTeachingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseTeaching))]
		EdCodeCourseTeaching,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
	}
	
	#endregion EntPolicyAbsenceChildEntityTypes
	
	#region EntPolicyAbsenceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAbsenceFilterBuilder : SqlFilterBuilder<EntPolicyAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAbsenceFilterBuilder class.
		/// </summary>
		public EntPolicyAbsenceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAbsenceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAbsenceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAbsenceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAbsenceFilterBuilder
	
	#region EntPolicyAbsenceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAbsence"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyAbsenceParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyAbsenceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAbsenceParameterBuilder class.
		/// </summary>
		public EntPolicyAbsenceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyAbsenceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyAbsenceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyAbsenceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyAbsenceParameterBuilder
	
	#region EntPolicyAbsenceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyAbsenceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyAbsence"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyAbsenceSortBuilder : SqlSortBuilder<EntPolicyAbsenceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyAbsenceSqlSortBuilder class.
		/// </summary>
		public EntPolicyAbsenceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyAbsenceSortBuilder
	
} // end namespace
