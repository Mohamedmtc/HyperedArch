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
	/// This class is the base class for any <see cref="EdAcadPlanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAcadPlanProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdAcadPlan, UMIS_VER2.BusinessLyer.EdAcadPlanKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanKey key)
		{
			return Delete(transactionManager, key.EdAcadPlanId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edAcadPlanId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edAcadPlanId)
		{
			return Delete(null, _edAcadPlanId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edAcadPlanId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ED_ACAD_YEAR key.
		///		FK_ED_ACAD_PLAN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ED_ACAD_YEAR key.
		///		FK_ED_ACAD_PLAN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlan> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ED_ACAD_YEAR key.
		///		FK_ED_ACAD_PLAN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ED_ACAD_YEAR key.
		///		fkEdAcadPlanEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ED_ACAD_YEAR key.
		///		fkEdAcadPlanEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ED_ACAD_YEAR key.
		///		FK_ED_ACAD_PLAN_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public abstract TList<EdAcadPlan> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlan> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ENTITY_MAIN key.
		///		fkEdAcadPlanEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ENTITY_MAIN key.
		///		fkEdAcadPlanEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_ENTITY_MAIN key.
		///		FK_ED_ACAD_PLAN_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public abstract TList<EdAcadPlan> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_SE_USER key.
		///		FK_ED_ACAD_PLAN_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_SE_USER key.
		///		FK_ED_ACAD_PLAN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		/// <remarks></remarks>
		public TList<EdAcadPlan> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_SE_USER key.
		///		FK_ED_ACAD_PLAN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_SE_USER key.
		///		fkEdAcadPlanSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_SE_USER key.
		///		fkEdAcadPlanSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public TList<EdAcadPlan> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_ACAD_PLAN_SE_USER key.
		///		FK_ED_ACAD_PLAN_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdAcadPlan objects.</returns>
		public abstract TList<EdAcadPlan> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdAcadPlan Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlanKey key, int start, int pageLength)
		{
			return GetByEdAcadPlanId(transactionManager, key.EdAcadPlanId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="_edAcadPlanId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEdAcadPlanId(System.Decimal _edAcadPlanId)
		{
			int count = -1;
			return GetByEdAcadPlanId(null,_edAcadPlanId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEdAcadPlanId(System.Decimal _edAcadPlanId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanId(null, _edAcadPlanId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEdAcadPlanId(TransactionManager transactionManager, System.Decimal _edAcadPlanId)
		{
			int count = -1;
			return GetByEdAcadPlanId(transactionManager, _edAcadPlanId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEdAcadPlanId(TransactionManager transactionManager, System.Decimal _edAcadPlanId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadPlanId(transactionManager, _edAcadPlanId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEdAcadPlanId(System.Decimal _edAcadPlanId, int start, int pageLength, out int count)
		{
			return GetByEdAcadPlanId(null, _edAcadPlanId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadPlan GetByEdAcadPlanId(TransactionManager transactionManager, System.Decimal _edAcadPlanId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEntMainIdEdAcadYearId(System.Decimal _entMainId, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearId(null,_entMainId, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEntMainIdEdAcadYearId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearId(null, _entMainId, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEntMainIdEdAcadYearId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearId(transactionManager, _entMainId, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEntMainIdEdAcadYearId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainIdEdAcadYearId(transactionManager, _entMainId, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdAcadPlan GetByEntMainIdEdAcadYearId(System.Decimal _entMainId, System.Decimal? _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEntMainIdEdAcadYearId(null, _entMainId, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ED_ACAD_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdAcadPlan GetByEntMainIdEdAcadYearId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdAcadPlan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdAcadPlan&gt;"/></returns>
		public static TList<EdAcadPlan> Fill(IDataReader reader, TList<EdAcadPlan> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdAcadPlan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdAcadPlan")
					.Append("|").Append((System.Decimal)reader["ED_ACAD_PLAN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdAcadPlan>(
					key.ToString(), // EntityTrackingKey
					"EdAcadPlan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdAcadPlan();
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
					c.EdAcadPlanId = (System.Decimal)reader["ED_ACAD_PLAN_ID"];
					c.OriginalEdAcadPlanId = c.EdAcadPlanId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.AcdPlnFlg = (System.Decimal)reader["ACD_PLN_FLG"];
					c.CurrentFlg = (System.Decimal)reader["CURRENT_FLG"];
					c.ClosedFlg = Convert.IsDBNull(reader["CLOSED_FLG"]) ? null : (System.Decimal?)reader["CLOSED_FLG"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EdtonNum = Convert.IsDBNull(reader["EDTON_NUM"]) ? null : (System.String)reader["EDTON_NUM"];
					c.AudtNote = Convert.IsDBNull(reader["AUDT_NOTE"]) ? null : (System.String)reader["AUDT_NOTE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdAcadPlan entity)
		{
			if (!reader.Read()) return;
			
			entity.EdAcadPlanId = (System.Decimal)reader[((int)EdAcadPlanColumn.EdAcadPlanId - 1)];
			entity.OriginalEdAcadPlanId = (System.Decimal)reader["ED_ACAD_PLAN_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)EdAcadPlanColumn.EntMainId - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)EdAcadPlanColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanColumn.EdAcadYearId - 1)];
			entity.AcdPlnFlg = (System.Decimal)reader[((int)EdAcadPlanColumn.AcdPlnFlg - 1)];
			entity.CurrentFlg = (System.Decimal)reader[((int)EdAcadPlanColumn.CurrentFlg - 1)];
			entity.ClosedFlg = (reader.IsDBNull(((int)EdAcadPlanColumn.ClosedFlg - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanColumn.ClosedFlg - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdAcadPlanColumn.Notes - 1)))?null:(System.String)reader[((int)EdAcadPlanColumn.Notes - 1)];
			entity.EdtonNum = (reader.IsDBNull(((int)EdAcadPlanColumn.EdtonNum - 1)))?null:(System.String)reader[((int)EdAcadPlanColumn.EdtonNum - 1)];
			entity.AudtNote = (reader.IsDBNull(((int)EdAcadPlanColumn.AudtNote - 1)))?null:(System.String)reader[((int)EdAcadPlanColumn.AudtNote - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdAcadPlanColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdAcadPlanColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdAcadPlanColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdAcadPlanColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdAcadPlan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdAcadPlanId = (System.Decimal)dataRow["ED_ACAD_PLAN_ID"];
			entity.OriginalEdAcadPlanId = (System.Decimal)dataRow["ED_ACAD_PLAN_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.AcdPlnFlg = (System.Decimal)dataRow["ACD_PLN_FLG"];
			entity.CurrentFlg = (System.Decimal)dataRow["CURRENT_FLG"];
			entity.ClosedFlg = Convert.IsDBNull(dataRow["CLOSED_FLG"]) ? null : (System.Decimal?)dataRow["CLOSED_FLG"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.EdtonNum = Convert.IsDBNull(dataRow["EDTON_NUM"]) ? null : (System.String)dataRow["EDTON_NUM"];
			entity.AudtNote = Convert.IsDBNull(dataRow["AUDT_NOTE"]) ? null : (System.String)dataRow["AUDT_NOTE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdAcadPlan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadPlan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdAcadPlanId methods when available
			
			#region EdAcadPlanHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanHdrCollection = DataRepository.EdAcadPlanHdrProvider.GetByEdAcadPlanId(transactionManager, entity.EdAcadPlanId);

				if (deep && entity.EdAcadPlanHdrCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanHdr>) DataRepository.EdAcadPlanHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanHdrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdAcadPlan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdAcadPlan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdAcadPlan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadPlan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdAcadPlanHdr>
				if (CanDeepSave(entity.EdAcadPlanHdrCollection, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanHdr child in entity.EdAcadPlanHdrCollection)
					{
						if(child.EdAcadPlanIdSource != null)
						{
							child.EdAcadPlanId = child.EdAcadPlanIdSource.EdAcadPlanId;
						}
						else
						{
							child.EdAcadPlanId = entity.EdAcadPlanId;
						}

					}

					if (entity.EdAcadPlanHdrCollection.Count > 0 || entity.EdAcadPlanHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanHdrProvider.Save(transactionManager, entity.EdAcadPlanHdrCollection);
						
						deepHandles.Add("EdAcadPlanHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanHdr >) DataRepository.EdAcadPlanHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanHdrCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdAcadPlanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdAcadPlan</c>
	///</summary>
	public enum EdAcadPlanChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>EdAcadPlan</c> as OneToMany for EdAcadPlanHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanHdr>))]
		EdAcadPlanHdrCollection,
	}
	
	#endregion EdAcadPlanChildEntityTypes
	
	#region EdAcadPlanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdAcadPlanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadPlanFilterBuilder : SqlFilterBuilder<EdAcadPlanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanFilterBuilder class.
		/// </summary>
		public EdAcadPlanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadPlanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadPlanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadPlanFilterBuilder
	
	#region EdAcadPlanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdAcadPlanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdAcadPlanParameterBuilder : ParameterizedSqlFilterBuilder<EdAcadPlanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanParameterBuilder class.
		/// </summary>
		public EdAcadPlanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdAcadPlanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdAcadPlanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdAcadPlanParameterBuilder
	
	#region EdAcadPlanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdAcadPlanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdAcadPlan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdAcadPlanSortBuilder : SqlSortBuilder<EdAcadPlanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdAcadPlanSqlSortBuilder class.
		/// </summary>
		public EdAcadPlanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdAcadPlanSortBuilder
	
} // end namespace
