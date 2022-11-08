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
	/// This class is the base class for any <see cref="EdStudCheatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCheatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudCheat, UMIS_VER2.BusinessLyer.EdStudCheatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCheatKey key)
		{
			return Delete(transactionManager, key.EdStudCheatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudCheatId)
		{
			return Delete(null, _edStudCheatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudCheatId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(_edCdeExamTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCheat> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeExamTypeId(transactionManager, _edCdeExamTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE key.
		///		fkEdStudCheatEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE key.
		///		fkEdStudCheatEdCdeExamType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdCdeExamTypeId(System.Decimal _edCdeExamTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeExamTypeId(null, _edCdeExamTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE key.
		///		FK_ED_STUD_CHEAT_ED_CDE_EXAM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeExamTypeId">نوع الامتحان: تكميلى- اعادة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public abstract TList<EdStudCheat> GetByEdCdeExamTypeId(TransactionManager transactionManager, System.Decimal _edCdeExamTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_EXAM_SCHDL key.
		///		FK_ED_STUD_CHEAT_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdExamSchdlId(System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(_edExamSchdlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_EXAM_SCHDL key.
		///		FK_ED_STUD_CHEAT_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCheat> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_EXAM_SCHDL key.
		///		FK_ED_STUD_CHEAT_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_EXAM_SCHDL key.
		///		fkEdStudCheatEdExamSchdl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edExamSchdlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_EXAM_SCHDL key.
		///		fkEdStudCheatEdExamSchdl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength,out int count)
		{
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_EXAM_SCHDL key.
		///		FK_ED_STUD_CHEAT_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public abstract TList<EdStudCheat> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCheat> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		fkEdStudCheatEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		fkEdStudCheatEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public abstract TList<EdStudCheat> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_BUILDING key.
		///		FK_ED_STUD_CHEAT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_BUILDING key.
		///		FK_ED_STUD_CHEAT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCheat> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_BUILDING key.
		///		FK_ED_STUD_CHEAT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_BUILDING key.
		///		fkEdStudCheatScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_BUILDING key.
		///		fkEdStudCheatScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_BUILDING key.
		///		FK_ED_STUD_CHEAT_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public abstract TList<EdStudCheat> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_HALL key.
		///		FK_ED_STUD_CHEAT_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_HALL key.
		///		FK_ED_STUD_CHEAT_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudCheat> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_HALL key.
		///		FK_ED_STUD_CHEAT_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_HALL key.
		///		fkEdStudCheatScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_HALL key.
		///		fkEdStudCheatScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public TList<EdStudCheat> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_CHEAT_SC_HALL key.
		///		FK_ED_STUD_CHEAT_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudCheat objects.</returns>
		public abstract TList<EdStudCheat> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudCheat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCheatKey key, int start, int pageLength)
		{
			return GetByEdStudCheatId(transactionManager, key.EdStudCheatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudCheatId(System.Decimal _edStudCheatId)
		{
			int count = -1;
			return GetByEdStudCheatId(null,_edStudCheatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudCheatId(System.Decimal _edStudCheatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCheatId(null, _edStudCheatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal _edStudCheatId)
		{
			int count = -1;
			return GetByEdStudCheatId(transactionManager, _edStudCheatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal _edStudCheatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudCheatId(transactionManager, _edStudCheatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudCheatId(System.Decimal _edStudCheatId, int start, int pageLength, out int count)
		{
			return GetByEdStudCheatId(null, _edStudCheatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudCheatId">تسجيل وقائع الغش</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudCheatId(TransactionManager transactionManager, System.Decimal _edStudCheatId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudSemesterIdEdExamSchdlId(System.Decimal _edStudSemesterId, System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdExamSchdlId(null,_edStudSemesterId, _edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudSemesterIdEdExamSchdlId(System.Decimal _edStudSemesterId, System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdExamSchdlId(null, _edStudSemesterId, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edExamSchdlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudSemesterIdEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdExamSchdlId(transactionManager, _edStudSemesterId, _edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudSemesterIdEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterIdEdExamSchdlId(transactionManager, _edStudSemesterId, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudSemesterIdEdExamSchdlId(System.Decimal _edStudSemesterId, System.Decimal _edExamSchdlId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterIdEdExamSchdlId(null, _edStudSemesterId, _edExamSchdlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudCheat GetByEdStudSemesterIdEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, System.Decimal _edExamSchdlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudCheat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudCheat&gt;"/></returns>
		public static TList<EdStudCheat> Fill(IDataReader reader, TList<EdStudCheat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudCheat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudCheat")
					.Append("|").Append((System.Decimal)reader["ED_STUD_CHEAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudCheat>(
					key.ToString(), // EntityTrackingKey
					"EdStudCheat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudCheat();
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
					c.EdStudCheatId = (System.Decimal)reader["ED_STUD_CHEAT_ID"];
					c.OriginalEdStudCheatId = c.EdStudCheatId;
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.CheatTime = Convert.IsDBNull(reader["CHEAT_TIME"]) ? null : (System.DateTime?)reader["CHEAT_TIME"];
					c.CheatDtl = Convert.IsDBNull(reader["CHEAT_DTL"]) ? null : (System.String)reader["CHEAT_DTL"];
					c.SupervisorName = Convert.IsDBNull(reader["SUPERVISOR_NAME"]) ? null : (System.String)reader["SUPERVISOR_NAME"];
					c.EdExamSchdlId = (System.Decimal)reader["ED_EXAM_SCHDL_ID"];
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EdCdeExamTypeId = (System.Decimal)reader["ED_CDE_EXAM_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudCheat entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudCheatId = (System.Decimal)reader[((int)EdStudCheatColumn.EdStudCheatId - 1)];
			entity.OriginalEdStudCheatId = (System.Decimal)reader["ED_STUD_CHEAT_ID"];
			entity.ScHallId = (reader.IsDBNull(((int)EdStudCheatColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)EdStudCheatColumn.ScHallId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)EdStudCheatColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)EdStudCheatColumn.ScBuildingId - 1)];
			entity.CheatTime = (reader.IsDBNull(((int)EdStudCheatColumn.CheatTime - 1)))?null:(System.DateTime?)reader[((int)EdStudCheatColumn.CheatTime - 1)];
			entity.CheatDtl = (reader.IsDBNull(((int)EdStudCheatColumn.CheatDtl - 1)))?null:(System.String)reader[((int)EdStudCheatColumn.CheatDtl - 1)];
			entity.SupervisorName = (reader.IsDBNull(((int)EdStudCheatColumn.SupervisorName - 1)))?null:(System.String)reader[((int)EdStudCheatColumn.SupervisorName - 1)];
			entity.EdExamSchdlId = (System.Decimal)reader[((int)EdStudCheatColumn.EdExamSchdlId - 1)];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudCheatColumn.EdStudSemesterId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudCheatColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudCheatColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudCheatColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudCheatColumn.LastDate - 1)];
			entity.EdCdeExamTypeId = (System.Decimal)reader[((int)EdStudCheatColumn.EdCdeExamTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudCheat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudCheatId = (System.Decimal)dataRow["ED_STUD_CHEAT_ID"];
			entity.OriginalEdStudCheatId = (System.Decimal)dataRow["ED_STUD_CHEAT_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.CheatTime = Convert.IsDBNull(dataRow["CHEAT_TIME"]) ? null : (System.DateTime?)dataRow["CHEAT_TIME"];
			entity.CheatDtl = Convert.IsDBNull(dataRow["CHEAT_DTL"]) ? null : (System.String)dataRow["CHEAT_DTL"];
			entity.SupervisorName = Convert.IsDBNull(dataRow["SUPERVISOR_NAME"]) ? null : (System.String)dataRow["SUPERVISOR_NAME"];
			entity.EdExamSchdlId = (System.Decimal)dataRow["ED_EXAM_SCHDL_ID"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.EdCdeExamTypeId = (System.Decimal)dataRow["ED_CDE_EXAM_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudCheat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCheat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCheat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeExamTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeExamTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeExamTypeId;
				EdCdeExamType tmpEntity = EntityManager.LocateEntity<EdCdeExamType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeExamType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeExamTypeIdSource = tmpEntity;
				else
					entity.EdCdeExamTypeIdSource = DataRepository.EdCdeExamTypeProvider.GetByEdCdeExamTypeId(transactionManager, entity.EdCdeExamTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeExamTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeExamTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeExamTypeProvider.DeepLoad(transactionManager, entity.EdCdeExamTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeExamTypeIdSource

			#region EdExamSchdlIdSource	
			if (CanDeepLoad(entity, "EdExamSchdl|EdExamSchdlIdSource", deepLoadType, innerList) 
				&& entity.EdExamSchdlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdExamSchdlId;
				EdExamSchdl tmpEntity = EntityManager.LocateEntity<EdExamSchdl>(EntityLocator.ConstructKeyFromPkItems(typeof(EdExamSchdl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdExamSchdlIdSource = tmpEntity;
				else
					entity.EdExamSchdlIdSource = DataRepository.EdExamSchdlProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdExamSchdlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdExamSchdlProvider.DeepLoad(transactionManager, entity.EdExamSchdlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdExamSchdlIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudSemesterId;
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, entity.EdStudSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScBuildingId ?? 0.0m);
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, (entity.ScBuildingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScHallId ?? 0.0m);
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, (entity.ScHallId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScHallIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScHallProvider.DeepLoad(transactionManager, entity.ScHallIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScHallIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdStudCheatId methods when available
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByEdStudCheatId(transactionManager, entity.EdStudCheatId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdStudCheatId(transactionManager, entity.EdStudCheatId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCheatExecCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCheatExec>|EdStudCheatExecCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCheatExecCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCheatExecCollection = DataRepository.EdStudCheatExecProvider.GetByEdStudCheatId(transactionManager, entity.EdStudCheatId);

				if (deep && entity.EdStudCheatExecCollection.Count > 0)
				{
					deepHandles.Add("EdStudCheatExecCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCheatExec>) DataRepository.EdStudCheatExecProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCheatExecCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudCheat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudCheat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudCheat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCheat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeExamTypeIdSource
			if (CanDeepSave(entity, "EdCdeExamType|EdCdeExamTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeExamTypeIdSource != null)
			{
				DataRepository.EdCdeExamTypeProvider.Save(transactionManager, entity.EdCdeExamTypeIdSource);
				entity.EdCdeExamTypeId = entity.EdCdeExamTypeIdSource.EdCdeExamTypeId;
			}
			#endregion 
			
			#region EdExamSchdlIdSource
			if (CanDeepSave(entity, "EdExamSchdl|EdExamSchdlIdSource", deepSaveType, innerList) 
				&& entity.EdExamSchdlIdSource != null)
			{
				DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlIdSource);
				entity.EdExamSchdlId = entity.EdExamSchdlIdSource.EdExamSchdlId;
			}
			#endregion 
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
			}
			#endregion 
			
			#region ScHallIdSource
			if (CanDeepSave(entity, "ScHall|ScHallIdSource", deepSaveType, innerList) 
				&& entity.ScHallIdSource != null)
			{
				DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallIdSource);
				entity.ScHallId = entity.ScHallIdSource.ScHallId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollection, "List<EdStudViol>|EdStudViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollection)
					{
						if(child.EdStudCheatIdSource != null)
						{
							child.EdStudCheatId = child.EdStudCheatIdSource.EdStudCheatId;
						}
						else
						{
							child.EdStudCheatId = entity.EdStudCheatId;
						}

					}

					if (entity.EdStudViolCollection.Count > 0 || entity.EdStudViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollection);
						
						deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdStudCheatIdSource != null)
						{
							child.EdStudCheatId = child.EdStudCheatIdSource.EdStudCheatId;
						}
						else
						{
							child.EdStudCheatId = entity.EdStudCheatId;
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
				
	
			#region List<EdStudCheatExec>
				if (CanDeepSave(entity.EdStudCheatExecCollection, "List<EdStudCheatExec>|EdStudCheatExecCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCheatExec child in entity.EdStudCheatExecCollection)
					{
						if(child.EdStudCheatIdSource != null)
						{
							child.EdStudCheatId = child.EdStudCheatIdSource.EdStudCheatId;
						}
						else
						{
							child.EdStudCheatId = entity.EdStudCheatId;
						}

					}

					if (entity.EdStudCheatExecCollection.Count > 0 || entity.EdStudCheatExecCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCheatExecProvider.Save(transactionManager, entity.EdStudCheatExecCollection);
						
						deepHandles.Add("EdStudCheatExecCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCheatExec >) DataRepository.EdStudCheatExecProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCheatExecCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudCheatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudCheat</c>
	///</summary>
	public enum EdStudCheatChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeExamType</c> at EdCdeExamTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeExamType))]
		EdCdeExamType,
		
		///<summary>
		/// Composite Property for <c>EdExamSchdl</c> at EdExamSchdlIdSource
		///</summary>
		[ChildEntityType(typeof(EdExamSchdl))]
		EdExamSchdl,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		///<summary>
		/// Collection of <c>EdStudCheat</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
		///<summary>
		/// Collection of <c>EdStudCheat</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>EdStudCheat</c> as OneToMany for EdStudCheatExecCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCheatExec>))]
		EdStudCheatExecCollection,
	}
	
	#endregion EdStudCheatChildEntityTypes
	
	#region EdStudCheatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudCheatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCheat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCheatFilterBuilder : SqlFilterBuilder<EdStudCheatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCheatFilterBuilder class.
		/// </summary>
		public EdStudCheatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCheatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCheatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCheatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCheatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCheatFilterBuilder
	
	#region EdStudCheatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudCheatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCheat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudCheatParameterBuilder : ParameterizedSqlFilterBuilder<EdStudCheatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCheatParameterBuilder class.
		/// </summary>
		public EdStudCheatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudCheatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudCheatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudCheatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudCheatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudCheatParameterBuilder
	
	#region EdStudCheatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudCheatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudCheat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudCheatSortBuilder : SqlSortBuilder<EdStudCheatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudCheatSqlSortBuilder class.
		/// </summary>
		public EdStudCheatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudCheatSortBuilder
	
} // end namespace
