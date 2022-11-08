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
	/// This class is the base class for any <see cref="EdStudCourseRegAddProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseRegAddProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCourseRegAdd, UMIS_VER2.BusinessLyer.EdStudCourseRegAddKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAddKey key)
		{
			return Delete(transactionManager, key.EdStudCourseRegAddId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCourseRegAddId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCourseRegAddId)
		{
			return Delete(null, _edStudCourseRegAddId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAddId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCourseRegAddId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="_actualEdCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualEdCodeGradingId(System.Decimal? _actualEdCodeGradingId)
		{
			int count = -1;
			return GetByActualEdCodeGradingId(_actualEdCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actualEdCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAdd> GetByActualEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _actualEdCodeGradingId)
		{
			int count = -1;
			return GetByActualEdCodeGradingId(transactionManager, _actualEdCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actualEdCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _actualEdCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByActualEdCodeGradingId(transactionManager, _actualEdCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING key.
		///		fkEdStudCourseRegAddEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_actualEdCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualEdCodeGradingId(System.Decimal? _actualEdCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByActualEdCodeGradingId(null, _actualEdCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING key.
		///		fkEdStudCourseRegAddEdCodeGrading Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_actualEdCodeGradingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualEdCodeGradingId(System.Decimal? _actualEdCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByActualEdCodeGradingId(null, _actualEdCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actualEdCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public abstract TList<EdStudCourseRegAdd> GetByActualEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _actualEdCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="_finalEdCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalEdCodeGradingId(System.Decimal? _finalEdCodeGradingId)
		{
			int count = -1;
			return GetByFinalEdCodeGradingId(_finalEdCodeGradingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_finalEdCodeGradingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAdd> GetByFinalEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _finalEdCodeGradingId)
		{
			int count = -1;
			return GetByFinalEdCodeGradingId(transactionManager, _finalEdCodeGradingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_finalEdCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _finalEdCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByFinalEdCodeGradingId(transactionManager, _finalEdCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 key.
		///		fkEdStudCourseRegAddEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_finalEdCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalEdCodeGradingId(System.Decimal? _finalEdCodeGradingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFinalEdCodeGradingId(null, _finalEdCodeGradingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 key.
		///		fkEdStudCourseRegAddEdCodeGrading1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_finalEdCodeGradingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalEdCodeGradingId(System.Decimal? _finalEdCodeGradingId, int start, int pageLength,out int count)
		{
			return GetByFinalEdCodeGradingId(null, _finalEdCodeGradingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_CODE_GRADING1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_finalEdCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public abstract TList<EdStudCourseRegAdd> GetByFinalEdCodeGradingId(TransactionManager transactionManager, System.Decimal? _finalEdCodeGradingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(_edStudCourseRegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAdd> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegId(transactionManager, _edStudCourseRegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG key.
		///		fkEdStudCourseRegAddEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG key.
		///		fkEdStudCourseRegAddEdStudCourseReg Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByEdStudCourseRegId(System.Decimal _edStudCourseRegId, int start, int pageLength,out int count)
		{
			return GetByEdStudCourseRegId(null, _edStudCourseRegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG key.
		///		FK_ED_STUD_COURSE_REG_ADD_ED_STUD_COURSE_REG Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public abstract TList<EdStudCourseRegAdd> GetByEdStudCourseRegId(TransactionManager transactionManager, System.Decimal _edStudCourseRegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="_finalGsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalGsCodePassFailId(System.Decimal? _finalGsCodePassFailId)
		{
			int count = -1;
			return GetByFinalGsCodePassFailId(_finalGsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_finalGsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAdd> GetByFinalGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _finalGsCodePassFailId)
		{
			int count = -1;
			return GetByFinalGsCodePassFailId(transactionManager, _finalGsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_finalGsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _finalGsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByFinalGsCodePassFailId(transactionManager, _finalGsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL key.
		///		fkEdStudCourseRegAddGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_finalGsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalGsCodePassFailId(System.Decimal? _finalGsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFinalGsCodePassFailId(null, _finalGsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL key.
		///		fkEdStudCourseRegAddGsCodePassFail Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_finalGsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByFinalGsCodePassFailId(System.Decimal? _finalGsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByFinalGsCodePassFailId(null, _finalGsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_finalGsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public abstract TList<EdStudCourseRegAdd> GetByFinalGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _finalGsCodePassFailId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="_actualGsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualGsCodePassFailId(System.Decimal? _actualGsCodePassFailId)
		{
			int count = -1;
			return GetByActualGsCodePassFailId(_actualGsCodePassFailId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actualGsCodePassFailId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCourseRegAdd> GetByActualGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _actualGsCodePassFailId)
		{
			int count = -1;
			return GetByActualGsCodePassFailId(transactionManager, _actualGsCodePassFailId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actualGsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _actualGsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByActualGsCodePassFailId(transactionManager, _actualGsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 key.
		///		fkEdStudCourseRegAddGsCodePassFail1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_actualGsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualGsCodePassFailId(System.Decimal? _actualGsCodePassFailId, int start, int pageLength)
		{
			int count =  -1;
			return GetByActualGsCodePassFailId(null, _actualGsCodePassFailId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 key.
		///		fkEdStudCourseRegAddGsCodePassFail1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_actualGsCodePassFailId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public TList<EdStudCourseRegAdd> GetByActualGsCodePassFailId(System.Decimal? _actualGsCodePassFailId, int start, int pageLength,out int count)
		{
			return GetByActualGsCodePassFailId(null, _actualGsCodePassFailId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 key.
		///		FK_ED_STUD_COURSE_REG_ADD_GS_CODE_PASS_FAIL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_actualGsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCourseRegAdd objects.</returns>
		public abstract TList<EdStudCourseRegAdd> GetByActualGsCodePassFailId(TransactionManager transactionManager, System.Decimal? _actualGsCodePassFailId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCourseRegAdd Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAddKey key, int start, int pageLength)
		{
			return GetByEdStudCourseRegAddId(transactionManager, key.EdStudCourseRegAddId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_COURSE_REG_ADD index.
		/// </summary>
		/// <param name="_edStudCourseRegAddId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAdd GetByEdStudCourseRegAddId(System.Decimal _edStudCourseRegAddId)
		{
			int count = -1;
			return GetByEdStudCourseRegAddId(null,_edStudCourseRegAddId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ADD index.
		/// </summary>
		/// <param name="_edStudCourseRegAddId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAdd GetByEdStudCourseRegAddId(System.Decimal _edStudCourseRegAddId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegAddId(null, _edStudCourseRegAddId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ADD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAddId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAdd GetByEdStudCourseRegAddId(TransactionManager transactionManager, System.Decimal _edStudCourseRegAddId)
		{
			int count = -1;
			return GetByEdStudCourseRegAddId(transactionManager, _edStudCourseRegAddId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ADD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAddId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAdd GetByEdStudCourseRegAddId(TransactionManager transactionManager, System.Decimal _edStudCourseRegAddId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCourseRegAddId(transactionManager, _edStudCourseRegAddId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ADD index.
		/// </summary>
		/// <param name="_edStudCourseRegAddId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCourseRegAdd GetByEdStudCourseRegAddId(System.Decimal _edStudCourseRegAddId, int start, int pageLength, out int count)
		{
			return GetByEdStudCourseRegAddId(null, _edStudCourseRegAddId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_COURSE_REG_ADD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCourseRegAddId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCourseRegAdd GetByEdStudCourseRegAddId(TransactionManager transactionManager, System.Decimal _edStudCourseRegAddId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCourseRegAdd&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCourseRegAdd&gt;"/></returns>
		public static TList<EdStudCourseRegAdd> Fill(IDataReader reader, TList<EdStudCourseRegAdd> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCourseRegAdd c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCourseRegAdd")
					.Append("|").Append((System.Decimal)reader["ED_STUD_COURSE_REG_ADD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCourseRegAdd>(
					key.ToString(), // EntityTrackingKey
					"EdStudCourseRegAdd",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCourseRegAdd();
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
					c.EdStudCourseRegAddId = (System.Decimal)reader["ED_STUD_COURSE_REG_ADD_ID"];
					c.OriginalEdStudCourseRegAddId = c.EdStudCourseRegAddId;
					c.EdStudCourseRegId = (System.Decimal)reader["ED_STUD_COURSE_REG_ID"];
					c.ActualCourseDegree = Convert.IsDBNull(reader["ACTUAL_COURSE_DEGREE"]) ? null : (System.Decimal?)reader["ACTUAL_COURSE_DEGREE"];
					c.ActualEdCodeGradingId = Convert.IsDBNull(reader["ACTUAL_ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["ACTUAL_ED_CODE_GRADING_ID"];
					c.ActualGsCodePassFailId = Convert.IsDBNull(reader["ACTUAL_GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["ACTUAL_GS_CODE_PASS_FAIL_ID"];
					c.ActualCoursePoint = Convert.IsDBNull(reader["ACTUAL_COURSE_POINT"]) ? null : (System.Decimal?)reader["ACTUAL_COURSE_POINT"];
					c.ClemMark = Convert.IsDBNull(reader["CLEM_MARK"]) ? null : (System.Decimal?)reader["CLEM_MARK"];
					c.RaiseMark = Convert.IsDBNull(reader["RAISE_MARK"]) ? null : (System.Decimal?)reader["RAISE_MARK"];
					c.FinalCourseDegree = Convert.IsDBNull(reader["FINAL_COURSE_DEGREE"]) ? null : (System.Decimal?)reader["FINAL_COURSE_DEGREE"];
					c.FinalEdCodeGradingId = Convert.IsDBNull(reader["FINAL_ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)reader["FINAL_ED_CODE_GRADING_ID"];
					c.FinalGsCodePassFailId = Convert.IsDBNull(reader["FINAL_GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)reader["FINAL_GS_CODE_PASS_FAIL_ID"];
					c.FinalCoursePoint = Convert.IsDBNull(reader["FINAL_COURSE_POINT"]) ? null : (System.Decimal?)reader["FINAL_COURSE_POINT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCourseRegAdd entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCourseRegAddId = (System.Decimal)reader[((int)EdStudCourseRegAddColumn.EdStudCourseRegAddId - 1)];
			entity.OriginalEdStudCourseRegAddId = (System.Decimal)reader["ED_STUD_COURSE_REG_ADD_ID"];
			entity.EdStudCourseRegId = (System.Decimal)reader[((int)EdStudCourseRegAddColumn.EdStudCourseRegId - 1)];
			entity.ActualCourseDegree = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.ActualCourseDegree - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.ActualCourseDegree - 1)];
			entity.ActualEdCodeGradingId = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.ActualEdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.ActualEdCodeGradingId - 1)];
			entity.ActualGsCodePassFailId = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.ActualGsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.ActualGsCodePassFailId - 1)];
			entity.ActualCoursePoint = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.ActualCoursePoint - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.ActualCoursePoint - 1)];
			entity.ClemMark = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.ClemMark - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.ClemMark - 1)];
			entity.RaiseMark = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.RaiseMark - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.RaiseMark - 1)];
			entity.FinalCourseDegree = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.FinalCourseDegree - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.FinalCourseDegree - 1)];
			entity.FinalEdCodeGradingId = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.FinalEdCodeGradingId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.FinalEdCodeGradingId - 1)];
			entity.FinalGsCodePassFailId = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.FinalGsCodePassFailId - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.FinalGsCodePassFailId - 1)];
			entity.FinalCoursePoint = (reader.IsDBNull(((int)EdStudCourseRegAddColumn.FinalCoursePoint - 1)))?null:(System.Decimal?)reader[((int)EdStudCourseRegAddColumn.FinalCoursePoint - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCourseRegAdd entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCourseRegAddId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ADD_ID"];
			entity.OriginalEdStudCourseRegAddId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ADD_ID"];
			entity.EdStudCourseRegId = (System.Decimal)dataRow["ED_STUD_COURSE_REG_ID"];
			entity.ActualCourseDegree = Convert.IsDBNull(dataRow["ACTUAL_COURSE_DEGREE"]) ? null : (System.Decimal?)dataRow["ACTUAL_COURSE_DEGREE"];
			entity.ActualEdCodeGradingId = Convert.IsDBNull(dataRow["ACTUAL_ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["ACTUAL_ED_CODE_GRADING_ID"];
			entity.ActualGsCodePassFailId = Convert.IsDBNull(dataRow["ACTUAL_GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["ACTUAL_GS_CODE_PASS_FAIL_ID"];
			entity.ActualCoursePoint = Convert.IsDBNull(dataRow["ACTUAL_COURSE_POINT"]) ? null : (System.Decimal?)dataRow["ACTUAL_COURSE_POINT"];
			entity.ClemMark = Convert.IsDBNull(dataRow["CLEM_MARK"]) ? null : (System.Decimal?)dataRow["CLEM_MARK"];
			entity.RaiseMark = Convert.IsDBNull(dataRow["RAISE_MARK"]) ? null : (System.Decimal?)dataRow["RAISE_MARK"];
			entity.FinalCourseDegree = Convert.IsDBNull(dataRow["FINAL_COURSE_DEGREE"]) ? null : (System.Decimal?)dataRow["FINAL_COURSE_DEGREE"];
			entity.FinalEdCodeGradingId = Convert.IsDBNull(dataRow["FINAL_ED_CODE_GRADING_ID"]) ? null : (System.Decimal?)dataRow["FINAL_ED_CODE_GRADING_ID"];
			entity.FinalGsCodePassFailId = Convert.IsDBNull(dataRow["FINAL_GS_CODE_PASS_FAIL_ID"]) ? null : (System.Decimal?)dataRow["FINAL_GS_CODE_PASS_FAIL_ID"];
			entity.FinalCoursePoint = Convert.IsDBNull(dataRow["FINAL_COURSE_POINT"]) ? null : (System.Decimal?)dataRow["FINAL_COURSE_POINT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCourseRegAdd"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegAdd Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAdd entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ActualEdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|ActualEdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.ActualEdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ActualEdCodeGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ActualEdCodeGradingIdSource = tmpEntity;
				else
					entity.ActualEdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.ActualEdCodeGradingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ActualEdCodeGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ActualEdCodeGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.ActualEdCodeGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ActualEdCodeGradingIdSource

			#region FinalEdCodeGradingIdSource	
			if (CanDeepLoad(entity, "EdCodeGrading|FinalEdCodeGradingIdSource", deepLoadType, innerList) 
				&& entity.FinalEdCodeGradingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FinalEdCodeGradingId ?? 0.0m);
				EdCodeGrading tmpEntity = EntityManager.LocateEntity<EdCodeGrading>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeGrading), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FinalEdCodeGradingIdSource = tmpEntity;
				else
					entity.FinalEdCodeGradingIdSource = DataRepository.EdCodeGradingProvider.GetByEdCodeGradingId(transactionManager, (entity.FinalEdCodeGradingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FinalEdCodeGradingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FinalEdCodeGradingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeGradingProvider.DeepLoad(transactionManager, entity.FinalEdCodeGradingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FinalEdCodeGradingIdSource

			#region EdStudCourseRegIdSource	
			if (CanDeepLoad(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepLoadType, innerList) 
				&& entity.EdStudCourseRegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudCourseRegId;
				EdStudCourseReg tmpEntity = EntityManager.LocateEntity<EdStudCourseReg>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudCourseReg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudCourseRegIdSource = tmpEntity;
				else
					entity.EdStudCourseRegIdSource = DataRepository.EdStudCourseRegProvider.GetByEdStudCourseRegId(transactionManager, entity.EdStudCourseRegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudCourseRegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudCourseRegProvider.DeepLoad(transactionManager, entity.EdStudCourseRegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudCourseRegIdSource

			#region FinalGsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|FinalGsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.FinalGsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FinalGsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FinalGsCodePassFailIdSource = tmpEntity;
				else
					entity.FinalGsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.FinalGsCodePassFailId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FinalGsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FinalGsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.FinalGsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FinalGsCodePassFailIdSource

			#region ActualGsCodePassFailIdSource	
			if (CanDeepLoad(entity, "GsCodePassFail|ActualGsCodePassFailIdSource", deepLoadType, innerList) 
				&& entity.ActualGsCodePassFailIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ActualGsCodePassFailId ?? 0.0m);
				GsCodePassFail tmpEntity = EntityManager.LocateEntity<GsCodePassFail>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePassFail), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ActualGsCodePassFailIdSource = tmpEntity;
				else
					entity.ActualGsCodePassFailIdSource = DataRepository.GsCodePassFailProvider.GetByGsCodePassFailId(transactionManager, (entity.ActualGsCodePassFailId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ActualGsCodePassFailIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ActualGsCodePassFailIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePassFailProvider.DeepLoad(transactionManager, entity.ActualGsCodePassFailIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ActualGsCodePassFailIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCourseRegAdd object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCourseRegAdd instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCourseRegAdd Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseRegAdd entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ActualEdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|ActualEdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.ActualEdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.ActualEdCodeGradingIdSource);
				entity.ActualEdCodeGradingId = entity.ActualEdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region FinalEdCodeGradingIdSource
			if (CanDeepSave(entity, "EdCodeGrading|FinalEdCodeGradingIdSource", deepSaveType, innerList) 
				&& entity.FinalEdCodeGradingIdSource != null)
			{
				DataRepository.EdCodeGradingProvider.Save(transactionManager, entity.FinalEdCodeGradingIdSource);
				entity.FinalEdCodeGradingId = entity.FinalEdCodeGradingIdSource.EdCodeGradingId;
			}
			#endregion 
			
			#region EdStudCourseRegIdSource
			if (CanDeepSave(entity, "EdStudCourseReg|EdStudCourseRegIdSource", deepSaveType, innerList) 
				&& entity.EdStudCourseRegIdSource != null)
			{
				DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegIdSource);
				entity.EdStudCourseRegId = entity.EdStudCourseRegIdSource.EdStudCourseRegId;
			}
			#endregion 
			
			#region FinalGsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|FinalGsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.FinalGsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.FinalGsCodePassFailIdSource);
				entity.FinalGsCodePassFailId = entity.FinalGsCodePassFailIdSource.GsCodePassFailId;
			}
			#endregion 
			
			#region ActualGsCodePassFailIdSource
			if (CanDeepSave(entity, "GsCodePassFail|ActualGsCodePassFailIdSource", deepSaveType, innerList) 
				&& entity.ActualGsCodePassFailIdSource != null)
			{
				DataRepository.GsCodePassFailProvider.Save(transactionManager, entity.ActualGsCodePassFailIdSource);
				entity.ActualGsCodePassFailId = entity.ActualGsCodePassFailIdSource.GsCodePassFailId;
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
	
	#region EdStudCourseRegAddChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCourseRegAdd</c>
	///</summary>
	public enum EdStudCourseRegAddChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeGrading</c> at ActualEdCodeGradingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeGrading))]
		EdCodeGrading,
		
		///<summary>
		/// Composite Property for <c>EdStudCourseReg</c> at EdStudCourseRegIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudCourseReg))]
		EdStudCourseReg,
		
		///<summary>
		/// Composite Property for <c>GsCodePassFail</c> at FinalGsCodePassFailIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePassFail))]
		GsCodePassFail,
	}
	
	#endregion EdStudCourseRegAddChildEntityTypes
	
	#region EdStudCourseRegAddFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCourseRegAddColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAdd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegAddFilterBuilder : SqlFilterBuilder<EdStudCourseRegAddColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAddFilterBuilder class.
		/// </summary>
		public EdStudCourseRegAddFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAddFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegAddFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAddFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegAddFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegAddFilterBuilder
	
	#region EdStudCourseRegAddParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCourseRegAddColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAdd"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCourseRegAddParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCourseRegAddColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAddParameterBuilder class.
		/// </summary>
		public EdStudCourseRegAddParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAddParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCourseRegAddParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAddParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCourseRegAddParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCourseRegAddParameterBuilder
	
	#region EdStudCourseRegAddSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCourseRegAddColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCourseRegAdd"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCourseRegAddSortBuilder : SqlSortBuilder<EdStudCourseRegAddColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCourseRegAddSqlSortBuilder class.
		/// </summary>
		public EdStudCourseRegAddSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCourseRegAddSortBuilder
	
} // end namespace
