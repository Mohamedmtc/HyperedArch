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
	/// This class is the base class for any <see cref="CoStudCheatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoStudCheatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoStudCheat, UMIS_VER2.BusinessLyer.CoStudCheatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoStudCheatKey key)
		{
			return Delete(transactionManager, key.CoStudCheatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coStudCheatId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coStudCheatId)
		{
			return Delete(null, _coStudCheatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coStudCheatId">XX not used. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coStudCheatId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="_coControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlId(System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(_coControlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<CoStudCheat> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlId(transactionManager, _coControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL key.
		///		fkCoStudCheatCoControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoControlId(null, _coControlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL key.
		///		fkCoStudCheatCoControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlId(System.Decimal _coControlId, int start, int pageLength,out int count)
		{
			return GetByCoControlId(null, _coControlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public abstract TList<CoStudCheat> GetByCoControlId(TransactionManager transactionManager, System.Decimal _coControlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="_coControlMembId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembId(System.Decimal _coControlMembId)
		{
			int count = -1;
			return GetByCoControlMembId(_coControlMembId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<CoStudCheat> GetByCoControlMembId(TransactionManager transactionManager, System.Decimal _coControlMembId)
		{
			int count = -1;
			return GetByCoControlMembId(transactionManager, _coControlMembId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembId(TransactionManager transactionManager, System.Decimal _coControlMembId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlMembId(transactionManager, _coControlMembId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER key.
		///		fkCoStudCheatCoControlMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlMembId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembId(System.Decimal _coControlMembId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoControlMembId(null, _coControlMembId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER key.
		///		fkCoStudCheatCoControlMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlMembId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembId(System.Decimal _coControlMembId, int start, int pageLength,out int count)
		{
			return GetByCoControlMembId(null, _coControlMembId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public abstract TList<CoStudCheat> GetByCoControlMembId(TransactionManager transactionManager, System.Decimal _coControlMembId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 Description: 
		/// </summary>
		/// <param name="_coControlMembHdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembHdId(System.Decimal _coControlMembHdId)
		{
			int count = -1;
			return GetByCoControlMembHdId(_coControlMembHdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembHdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<CoStudCheat> GetByCoControlMembHdId(TransactionManager transactionManager, System.Decimal _coControlMembHdId)
		{
			int count = -1;
			return GetByCoControlMembHdId(transactionManager, _coControlMembHdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembHdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembHdId(TransactionManager transactionManager, System.Decimal _coControlMembHdId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlMembHdId(transactionManager, _coControlMembHdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 key.
		///		fkCoStudCheatCoControlMember1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlMembHdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembHdId(System.Decimal _coControlMembHdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoControlMembHdId(null, _coControlMembHdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 key.
		///		fkCoStudCheatCoControlMember1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coControlMembHdId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoControlMembHdId(System.Decimal _coControlMembHdId, int start, int pageLength,out int count)
		{
			return GetByCoControlMembHdId(null, _coControlMembHdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 key.
		///		FK_CO_STUD_CHEAT_CO_CONTROL_MEMBER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlMembHdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public abstract TList<CoStudCheat> GetByCoControlMembHdId(TransactionManager transactionManager, System.Decimal _coControlMembHdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(_coExamSchdlPlaceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<CoStudCheat> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE key.
		///		fkCoStudCheatCoExamSchdlPlace Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE key.
		///		fkCoStudCheatCoExamSchdlPlace Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength,out int count)
		{
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE key.
		///		FK_CO_STUD_CHEAT_CO_EXAM_SCHDL_PLACE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public abstract TList<CoStudCheat> GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_CO_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_CO_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		/// <remarks></remarks>
		public TList<CoStudCheat> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_CO_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		fkCoStudCheatEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		fkCoStudCheatEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public TList<CoStudCheat> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_STUD_CHEAT_ED_STUD_SEMESTER key.
		///		FK_CO_STUD_CHEAT_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoStudCheat objects.</returns>
		public abstract TList<CoStudCheat> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoStudCheat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoStudCheatKey key, int start, int pageLength)
		{
			return GetByCoStudCheatId(transactionManager, key.CoStudCheatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_STUD_CHEAT index.
		/// </summary>
		/// <param name="_coStudCheatId">XX not used</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoStudCheat GetByCoStudCheatId(System.Decimal _coStudCheatId)
		{
			int count = -1;
			return GetByCoStudCheatId(null,_coStudCheatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_STUD_CHEAT index.
		/// </summary>
		/// <param name="_coStudCheatId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoStudCheat GetByCoStudCheatId(System.Decimal _coStudCheatId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoStudCheatId(null, _coStudCheatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coStudCheatId">XX not used</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoStudCheat GetByCoStudCheatId(TransactionManager transactionManager, System.Decimal _coStudCheatId)
		{
			int count = -1;
			return GetByCoStudCheatId(transactionManager, _coStudCheatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coStudCheatId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoStudCheat GetByCoStudCheatId(TransactionManager transactionManager, System.Decimal _coStudCheatId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoStudCheatId(transactionManager, _coStudCheatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_STUD_CHEAT index.
		/// </summary>
		/// <param name="_coStudCheatId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoStudCheat GetByCoStudCheatId(System.Decimal _coStudCheatId, int start, int pageLength, out int count)
		{
			return GetByCoStudCheatId(null, _coStudCheatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_STUD_CHEAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coStudCheatId">XX not used</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoStudCheat GetByCoStudCheatId(TransactionManager transactionManager, System.Decimal _coStudCheatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoStudCheat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoStudCheat&gt;"/></returns>
		public static TList<CoStudCheat> Fill(IDataReader reader, TList<CoStudCheat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoStudCheat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoStudCheat")
					.Append("|").Append((System.Decimal)reader["CO_STUD_CHEAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoStudCheat>(
					key.ToString(), // EntityTrackingKey
					"CoStudCheat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoStudCheat();
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
					c.CoStudCheatId = (System.Decimal)reader["CO_STUD_CHEAT_ID"];
					c.OriginalCoStudCheatId = c.CoStudCheatId;
					c.CoControlId = (System.Decimal)reader["CO_CONTROL_ID"];
					c.CoExamSchdlPlaceId = (System.Decimal)reader["CO_EXAM_SCHDL_PLACE_ID"];
					c.EdStudSemesterId = Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_STUD_SEMESTER_ID"];
					c.CheatDtl = (System.String)reader["CHEAT_DTL"];
					c.CoControlMembId = (System.Decimal)reader["CO_CONTROL_MEMB_ID"];
					c.CoControlMembHdId = (System.Decimal)reader["CO_CONTROL_MEMB_HD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoStudCheat entity)
		{
			if (!reader.Read()) return;
			
			entity.CoStudCheatId = (System.Decimal)reader[((int)CoStudCheatColumn.CoStudCheatId - 1)];
			entity.OriginalCoStudCheatId = (System.Decimal)reader["CO_STUD_CHEAT_ID"];
			entity.CoControlId = (System.Decimal)reader[((int)CoStudCheatColumn.CoControlId - 1)];
			entity.CoExamSchdlPlaceId = (System.Decimal)reader[((int)CoStudCheatColumn.CoExamSchdlPlaceId - 1)];
			entity.EdStudSemesterId = (reader.IsDBNull(((int)CoStudCheatColumn.EdStudSemesterId - 1)))?null:(System.Decimal?)reader[((int)CoStudCheatColumn.EdStudSemesterId - 1)];
			entity.CheatDtl = (System.String)reader[((int)CoStudCheatColumn.CheatDtl - 1)];
			entity.CoControlMembId = (System.Decimal)reader[((int)CoStudCheatColumn.CoControlMembId - 1)];
			entity.CoControlMembHdId = (System.Decimal)reader[((int)CoStudCheatColumn.CoControlMembHdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoStudCheat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoStudCheatId = (System.Decimal)dataRow["CO_STUD_CHEAT_ID"];
			entity.OriginalCoStudCheatId = (System.Decimal)dataRow["CO_STUD_CHEAT_ID"];
			entity.CoControlId = (System.Decimal)dataRow["CO_CONTROL_ID"];
			entity.CoExamSchdlPlaceId = (System.Decimal)dataRow["CO_EXAM_SCHDL_PLACE_ID"];
			entity.EdStudSemesterId = Convert.IsDBNull(dataRow["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_SEMESTER_ID"];
			entity.CheatDtl = (System.String)dataRow["CHEAT_DTL"];
			entity.CoControlMembId = (System.Decimal)dataRow["CO_CONTROL_MEMB_ID"];
			entity.CoControlMembHdId = (System.Decimal)dataRow["CO_CONTROL_MEMB_HD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoStudCheat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoStudCheat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoStudCheat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoControlIdSource	
			if (CanDeepLoad(entity, "CoControl|CoControlIdSource", deepLoadType, innerList) 
				&& entity.CoControlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlId;
				CoControl tmpEntity = EntityManager.LocateEntity<CoControl>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlIdSource = tmpEntity;
				else
					entity.CoControlIdSource = DataRepository.CoControlProvider.GetByCoControlId(transactionManager, entity.CoControlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlProvider.DeepLoad(transactionManager, entity.CoControlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlIdSource

			#region CoControlMembIdSource	
			if (CanDeepLoad(entity, "CoControlMember|CoControlMembIdSource", deepLoadType, innerList) 
				&& entity.CoControlMembIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlMembId;
				CoControlMember tmpEntity = EntityManager.LocateEntity<CoControlMember>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControlMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlMembIdSource = tmpEntity;
				else
					entity.CoControlMembIdSource = DataRepository.CoControlMemberProvider.GetByCoControlMembersId(transactionManager, entity.CoControlMembId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlMembIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlMembIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlMemberProvider.DeepLoad(transactionManager, entity.CoControlMembIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlMembIdSource

			#region CoControlMembHdIdSource	
			if (CanDeepLoad(entity, "CoControlMember|CoControlMembHdIdSource", deepLoadType, innerList) 
				&& entity.CoControlMembHdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlMembHdId;
				CoControlMember tmpEntity = EntityManager.LocateEntity<CoControlMember>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControlMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlMembHdIdSource = tmpEntity;
				else
					entity.CoControlMembHdIdSource = DataRepository.CoControlMemberProvider.GetByCoControlMembersId(transactionManager, entity.CoControlMembHdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlMembHdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlMembHdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlMemberProvider.DeepLoad(transactionManager, entity.CoControlMembHdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlMembHdIdSource

			#region CoExamSchdlPlaceIdSource	
			if (CanDeepLoad(entity, "CoExamSchdlPlace|CoExamSchdlPlaceIdSource", deepLoadType, innerList) 
				&& entity.CoExamSchdlPlaceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoExamSchdlPlaceId;
				CoExamSchdlPlace tmpEntity = EntityManager.LocateEntity<CoExamSchdlPlace>(EntityLocator.ConstructKeyFromPkItems(typeof(CoExamSchdlPlace), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoExamSchdlPlaceIdSource = tmpEntity;
				else
					entity.CoExamSchdlPlaceIdSource = DataRepository.CoExamSchdlPlaceProvider.GetByCoExamSchdlPlaceId(transactionManager, entity.CoExamSchdlPlaceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamSchdlPlaceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoExamSchdlPlaceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoExamSchdlPlaceProvider.DeepLoad(transactionManager, entity.CoExamSchdlPlaceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoExamSchdlPlaceIdSource

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudSemesterId ?? 0.0m);
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, (entity.EdStudSemesterId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoStudCheat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoStudCheat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoStudCheat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoStudCheat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoControlIdSource
			if (CanDeepSave(entity, "CoControl|CoControlIdSource", deepSaveType, innerList) 
				&& entity.CoControlIdSource != null)
			{
				DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlIdSource);
				entity.CoControlId = entity.CoControlIdSource.CoControlId;
			}
			#endregion 
			
			#region CoControlMembIdSource
			if (CanDeepSave(entity, "CoControlMember|CoControlMembIdSource", deepSaveType, innerList) 
				&& entity.CoControlMembIdSource != null)
			{
				DataRepository.CoControlMemberProvider.Save(transactionManager, entity.CoControlMembIdSource);
				entity.CoControlMembId = entity.CoControlMembIdSource.CoControlMembersId;
			}
			#endregion 
			
			#region CoControlMembHdIdSource
			if (CanDeepSave(entity, "CoControlMember|CoControlMembHdIdSource", deepSaveType, innerList) 
				&& entity.CoControlMembHdIdSource != null)
			{
				DataRepository.CoControlMemberProvider.Save(transactionManager, entity.CoControlMembHdIdSource);
				entity.CoControlMembHdId = entity.CoControlMembHdIdSource.CoControlMembersId;
			}
			#endregion 
			
			#region CoExamSchdlPlaceIdSource
			if (CanDeepSave(entity, "CoExamSchdlPlace|CoExamSchdlPlaceIdSource", deepSaveType, innerList) 
				&& entity.CoExamSchdlPlaceIdSource != null)
			{
				DataRepository.CoExamSchdlPlaceProvider.Save(transactionManager, entity.CoExamSchdlPlaceIdSource);
				entity.CoExamSchdlPlaceId = entity.CoExamSchdlPlaceIdSource.CoExamSchdlPlaceId;
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
	
	#region CoStudCheatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoStudCheat</c>
	///</summary>
	public enum CoStudCheatChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControl</c> at CoControlIdSource
		///</summary>
		[ChildEntityType(typeof(CoControl))]
		CoControl,
		
		///<summary>
		/// Composite Property for <c>CoControlMember</c> at CoControlMembIdSource
		///</summary>
		[ChildEntityType(typeof(CoControlMember))]
		CoControlMember,
		
		///<summary>
		/// Composite Property for <c>CoExamSchdlPlace</c> at CoExamSchdlPlaceIdSource
		///</summary>
		[ChildEntityType(typeof(CoExamSchdlPlace))]
		CoExamSchdlPlace,
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
	}
	
	#endregion CoStudCheatChildEntityTypes
	
	#region CoStudCheatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoStudCheatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoStudCheat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoStudCheatFilterBuilder : SqlFilterBuilder<CoStudCheatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoStudCheatFilterBuilder class.
		/// </summary>
		public CoStudCheatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoStudCheatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoStudCheatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoStudCheatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoStudCheatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoStudCheatFilterBuilder
	
	#region CoStudCheatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoStudCheatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoStudCheat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoStudCheatParameterBuilder : ParameterizedSqlFilterBuilder<CoStudCheatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoStudCheatParameterBuilder class.
		/// </summary>
		public CoStudCheatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoStudCheatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoStudCheatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoStudCheatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoStudCheatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoStudCheatParameterBuilder
	
	#region CoStudCheatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoStudCheatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoStudCheat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoStudCheatSortBuilder : SqlSortBuilder<CoStudCheatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoStudCheatSqlSortBuilder class.
		/// </summary>
		public CoStudCheatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoStudCheatSortBuilder
	
} // end namespace
