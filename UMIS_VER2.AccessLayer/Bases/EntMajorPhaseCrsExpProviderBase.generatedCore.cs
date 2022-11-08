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
	/// This class is the base class for any <see cref="EntMajorPhaseCrsExpProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntMajorPhaseCrsExpProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp, UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExpKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExpKey key)
		{
			return Delete(transactionManager, key.EntMajorPhaseCrsExpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entMajorPhaseCrsExpId)
		{
			return Delete(null, _entMajorPhaseCrsExpId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entMajorPhaseCrsExpId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		/// <remarks></remarks>
		public TList<EntMajorPhaseCrsExp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE key.
		///		fkEntMajorPhaseCrsExpEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE key.
		///		fkEntMajorPhaseCrsExpEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public abstract TList<EntMajorPhaseCrsExp> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEntMajorPhaseId(System.Decimal _entMajorPhaseId)
		{
			int count = -1;
			return GetByEntMajorPhaseId(_entMajorPhaseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		/// <remarks></remarks>
		public TList<EntMajorPhaseCrsExp> GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId)
		{
			int count = -1;
			return GetByEntMajorPhaseId(transactionManager, _entMajorPhaseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseId(transactionManager, _entMajorPhaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE key.
		///		fkEntMajorPhaseCrsExpEntMajorPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEntMajorPhaseId(System.Decimal _entMajorPhaseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMajorPhaseId(null, _entMajorPhaseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE key.
		///		fkEntMajorPhaseCrsExpEntMajorPhase Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public TList<EntMajorPhaseCrsExp> GetByEntMajorPhaseId(System.Decimal _entMajorPhaseId, int start, int pageLength,out int count)
		{
			return GetByEntMajorPhaseId(null, _entMajorPhaseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE key.
		///		FK_ENT_MAJOR_PHASE_CRS_EXP_ENT_MAJOR_PHASE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp objects.</returns>
		public abstract TList<EntMajorPhaseCrsExp> GetByEntMajorPhaseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExpKey key, int start, int pageLength)
		{
			return GetByEntMajorPhaseCrsExpId(transactionManager, key.EntMajorPhaseCrsExpId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseCrsExpId(System.Decimal _entMajorPhaseCrsExpId)
		{
			int count = -1;
			return GetByEntMajorPhaseCrsExpId(null,_entMajorPhaseCrsExpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseCrsExpId(System.Decimal _entMajorPhaseCrsExpId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseCrsExpId(null, _entMajorPhaseCrsExpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseCrsExpId(TransactionManager transactionManager, System.Decimal _entMajorPhaseCrsExpId)
		{
			int count = -1;
			return GetByEntMajorPhaseCrsExpId(transactionManager, _entMajorPhaseCrsExpId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseCrsExpId(TransactionManager transactionManager, System.Decimal _entMajorPhaseCrsExpId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseCrsExpId(transactionManager, _entMajorPhaseCrsExpId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseCrsExpId(System.Decimal _entMajorPhaseCrsExpId, int start, int pageLength, out int count)
		{
			return GetByEntMajorPhaseCrsExpId(null, _entMajorPhaseCrsExpId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseCrsExpId">استثناء مقررات للانتقال من المرحلة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseCrsExpId(TransactionManager transactionManager, System.Decimal _entMajorPhaseCrsExpId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseIdEdCourseId(System.Decimal _entMajorPhaseId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEntMajorPhaseIdEdCourseId(null,_entMajorPhaseId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseIdEdCourseId(System.Decimal _entMajorPhaseId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseIdEdCourseId(null, _entMajorPhaseId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseIdEdCourseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEntMajorPhaseIdEdCourseId(transactionManager, _entMajorPhaseId, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseIdEdCourseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMajorPhaseIdEdCourseId(transactionManager, _entMajorPhaseId, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseIdEdCourseId(System.Decimal _entMajorPhaseId, System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEntMajorPhaseIdEdCourseId(null, _entMajorPhaseId, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ENT_MAJOR_PHASE_CRS_EXP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMajorPhaseId">المراحل الدارسية</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp GetByEntMajorPhaseIdEdCourseId(TransactionManager transactionManager, System.Decimal _entMajorPhaseId, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntMajorPhaseCrsExp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntMajorPhaseCrsExp&gt;"/></returns>
		public static TList<EntMajorPhaseCrsExp> Fill(IDataReader reader, TList<EntMajorPhaseCrsExp> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntMajorPhaseCrsExp")
					.Append("|").Append((System.Decimal)reader["ENT_MAJOR_PHASE_CRS_EXP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntMajorPhaseCrsExp>(
					key.ToString(), // EntityTrackingKey
					"EntMajorPhaseCrsExp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp();
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
					c.EntMajorPhaseCrsExpId = (System.Decimal)reader["ENT_MAJOR_PHASE_CRS_EXP_ID"];
					c.OriginalEntMajorPhaseCrsExpId = c.EntMajorPhaseCrsExpId;
					c.EntMajorPhaseId = (System.Decimal)reader["ENT_MAJOR_PHASE_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp entity)
		{
			if (!reader.Read()) return;
			
			entity.EntMajorPhaseCrsExpId = (System.Decimal)reader[((int)EntMajorPhaseCrsExpColumn.EntMajorPhaseCrsExpId - 1)];
			entity.OriginalEntMajorPhaseCrsExpId = (System.Decimal)reader["ENT_MAJOR_PHASE_CRS_EXP_ID"];
			entity.EntMajorPhaseId = (System.Decimal)reader[((int)EntMajorPhaseCrsExpColumn.EntMajorPhaseId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)EntMajorPhaseCrsExpColumn.EdCourseId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EntMajorPhaseCrsExpColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EntMajorPhaseCrsExpColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EntMajorPhaseCrsExpColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EntMajorPhaseCrsExpColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntMajorPhaseCrsExpId = (System.Decimal)dataRow["ENT_MAJOR_PHASE_CRS_EXP_ID"];
			entity.OriginalEntMajorPhaseCrsExpId = (System.Decimal)dataRow["ENT_MAJOR_PHASE_CRS_EXP_ID"];
			entity.EntMajorPhaseId = (System.Decimal)dataRow["ENT_MAJOR_PHASE_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
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

			#region EntMajorPhaseIdSource	
			if (CanDeepLoad(entity, "EntMajorPhase|EntMajorPhaseIdSource", deepLoadType, innerList) 
				&& entity.EntMajorPhaseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMajorPhaseId;
				EntMajorPhase tmpEntity = EntityManager.LocateEntity<EntMajorPhase>(EntityLocator.ConstructKeyFromPkItems(typeof(EntMajorPhase), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMajorPhaseIdSource = tmpEntity;
				else
					entity.EntMajorPhaseIdSource = DataRepository.EntMajorPhaseProvider.GetByEntMajorPhaseId(transactionManager, entity.EntMajorPhaseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMajorPhaseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntMajorPhaseProvider.DeepLoad(transactionManager, entity.EntMajorPhaseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMajorPhaseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
			}
			#endregion 
			
			#region EntMajorPhaseIdSource
			if (CanDeepSave(entity, "EntMajorPhase|EntMajorPhaseIdSource", deepSaveType, innerList) 
				&& entity.EntMajorPhaseIdSource != null)
			{
				DataRepository.EntMajorPhaseProvider.Save(transactionManager, entity.EntMajorPhaseIdSource);
				entity.EntMajorPhaseId = entity.EntMajorPhaseIdSource.EntMajorPhaseId;
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
	
	#region EntMajorPhaseCrsExpChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntMajorPhaseCrsExp</c>
	///</summary>
	public enum EntMajorPhaseCrsExpChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>EntMajorPhase</c> at EntMajorPhaseIdSource
		///</summary>
		[ChildEntityType(typeof(EntMajorPhase))]
		EntMajorPhase,
	}
	
	#endregion EntMajorPhaseCrsExpChildEntityTypes
	
	#region EntMajorPhaseCrsExpFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntMajorPhaseCrsExpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMajorPhaseCrsExp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntMajorPhaseCrsExpFilterBuilder : SqlFilterBuilder<EntMajorPhaseCrsExpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseCrsExpFilterBuilder class.
		/// </summary>
		public EntMajorPhaseCrsExpFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseCrsExpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntMajorPhaseCrsExpFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseCrsExpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntMajorPhaseCrsExpFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntMajorPhaseCrsExpFilterBuilder
	
	#region EntMajorPhaseCrsExpParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntMajorPhaseCrsExpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMajorPhaseCrsExp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntMajorPhaseCrsExpParameterBuilder : ParameterizedSqlFilterBuilder<EntMajorPhaseCrsExpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseCrsExpParameterBuilder class.
		/// </summary>
		public EntMajorPhaseCrsExpParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseCrsExpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntMajorPhaseCrsExpParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseCrsExpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntMajorPhaseCrsExpParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntMajorPhaseCrsExpParameterBuilder
	
	#region EntMajorPhaseCrsExpSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntMajorPhaseCrsExpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntMajorPhaseCrsExp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntMajorPhaseCrsExpSortBuilder : SqlSortBuilder<EntMajorPhaseCrsExpColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntMajorPhaseCrsExpSqlSortBuilder class.
		/// </summary>
		public EntMajorPhaseCrsExpSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntMajorPhaseCrsExpSortBuilder
	
} // end namespace
