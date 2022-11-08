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
	/// This class is the base class for any <see cref="EntPlcyAcadWarnDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPlcyAcadWarnDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtlKey key)
		{
			return Delete(transactionManager, key.EntPlcyAcadWarnDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPlcyAcadWarnDtlId)
		{
			return Delete(null, _entPlcyAcadWarnDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId">XXXالدرجة العلمية من اللائحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XXXالدرجة العلمية من اللائحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EntPlcyAcadWarnDtl> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XXXالدرجة العلمية من اللائحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE key.
		///		fkEntPlcyAcadWarnDtlAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">XXXالدرجة العلمية من اللائحة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE key.
		///		fkEntPlcyAcadWarnDtlAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId">XXXالدرجة العلمية من اللائحة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">XXXالدرجة العلمية من اللائحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public abstract TList<EntPlcyAcadWarnDtl> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="_edCdeAcadWarnTypeId">يوجة الانذار الاكاديمى الاول (1) الى الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEdCdeAcadWarnTypeId(System.Decimal _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(_edCdeAcadWarnTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId">يوجة الانذار الاكاديمى الاول (1) الى الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EntPlcyAcadWarnDtl> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal _edCdeAcadWarnTypeId)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId">يوجة الانذار الاكاديمى الاول (1) الى الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeAcadWarnTypeId(transactionManager, _edCdeAcadWarnTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE key.
		///		fkEntPlcyAcadWarnDtlEdCdeAcadWarnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeAcadWarnTypeId">يوجة الانذار الاكاديمى الاول (1) الى الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEdCdeAcadWarnTypeId(System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE key.
		///		fkEntPlcyAcadWarnDtlEdCdeAcadWarnType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeAcadWarnTypeId">يوجة الانذار الاكاديمى الاول (1) الى الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEdCdeAcadWarnTypeId(System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength,out int count)
		{
			return GetByEdCdeAcadWarnTypeId(null, _edCdeAcadWarnTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ED_CDE_ACAD_WARN_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeAcadWarnTypeId">يوجة الانذار الاكاديمى الاول (1) الى الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public abstract TList<EntPlcyAcadWarnDtl> GetByEdCdeAcadWarnTypeId(TransactionManager transactionManager, System.Decimal _edCdeAcadWarnTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN Description: 
		/// </summary>
		/// <param name="_entPlcyAcadWarnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEntPlcyAcadWarnId(System.Decimal _entPlcyAcadWarnId)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnId(_entPlcyAcadWarnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		/// <remarks></remarks>
		public TList<EntPlcyAcadWarnDtl> GetByEntPlcyAcadWarnId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnId)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnId(transactionManager, _entPlcyAcadWarnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEntPlcyAcadWarnId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnId(transactionManager, _entPlcyAcadWarnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN key.
		///		fkEntPlcyAcadWarnDtlEntPolicyAcadWarn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPlcyAcadWarnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEntPlcyAcadWarnId(System.Decimal _entPlcyAcadWarnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntPlcyAcadWarnId(null, _entPlcyAcadWarnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN key.
		///		fkEntPlcyAcadWarnDtlEntPolicyAcadWarn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entPlcyAcadWarnId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public TList<EntPlcyAcadWarnDtl> GetByEntPlcyAcadWarnId(System.Decimal _entPlcyAcadWarnId, int start, int pageLength,out int count)
		{
			return GetByEntPlcyAcadWarnId(null, _entPlcyAcadWarnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN key.
		///		FK_ENT_PLCY_ACAD_WARN_DTL_ENT_POLICY_ACAD_WARN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl objects.</returns>
		public abstract TList<EntPlcyAcadWarnDtl> GetByEntPlcyAcadWarnId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtlKey key, int start, int pageLength)
		{
			return GetByEntPlcyAcadWarnDtlId(transactionManager, key.EntPlcyAcadWarnDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_PLCY_ACAD_WARN_DTL index.
		/// </summary>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl GetByEntPlcyAcadWarnDtlId(System.Decimal _entPlcyAcadWarnDtlId)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnDtlId(null,_entPlcyAcadWarnDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PLCY_ACAD_WARN_DTL index.
		/// </summary>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl GetByEntPlcyAcadWarnDtlId(System.Decimal _entPlcyAcadWarnDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnDtlId(null, _entPlcyAcadWarnDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PLCY_ACAD_WARN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl GetByEntPlcyAcadWarnDtlId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnDtlId)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnDtlId(transactionManager, _entPlcyAcadWarnDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PLCY_ACAD_WARN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl GetByEntPlcyAcadWarnDtlId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPlcyAcadWarnDtlId(transactionManager, _entPlcyAcadWarnDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PLCY_ACAD_WARN_DTL index.
		/// </summary>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl GetByEntPlcyAcadWarnDtlId(System.Decimal _entPlcyAcadWarnDtlId, int start, int pageLength, out int count)
		{
			return GetByEntPlcyAcadWarnDtlId(null, _entPlcyAcadWarnDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PLCY_ACAD_WARN_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPlcyAcadWarnDtlId">محددات كل  نوع انذار</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl GetByEntPlcyAcadWarnDtlId(TransactionManager transactionManager, System.Decimal _entPlcyAcadWarnDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPlcyAcadWarnDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPlcyAcadWarnDtl&gt;"/></returns>
		public static TList<EntPlcyAcadWarnDtl> Fill(IDataReader reader, TList<EntPlcyAcadWarnDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPlcyAcadWarnDtl")
					.Append("|").Append((System.Decimal)reader["ENT_PLCY_ACAD_WARN_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPlcyAcadWarnDtl>(
					key.ToString(), // EntityTrackingKey
					"EntPlcyAcadWarnDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl();
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
					c.EntPlcyAcadWarnDtlId = (System.Decimal)reader["ENT_PLCY_ACAD_WARN_DTL_ID"];
					c.OriginalEntPlcyAcadWarnDtlId = c.EntPlcyAcadWarnDtlId;
					c.EntPlcyAcadWarnId = (System.Decimal)reader["ENT_PLCY_ACAD_WARN_ID"];
					c.EdCdeAcadWarnTypeId = (System.Decimal)reader["ED_CDE_ACAD_WARN_TYPE_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.MinGpa = Convert.IsDBNull(reader["MIN_GPA"]) ? null : (System.Decimal?)reader["MIN_GPA"];
					c.MinCgpa = Convert.IsDBNull(reader["MIN_CGPA"]) ? null : (System.Decimal?)reader["MIN_CGPA"];
					c.AccumChFrom = Convert.IsDBNull(reader["ACCUM_CH_FROM"]) ? null : (System.Decimal?)reader["ACCUM_CH_FROM"];
					c.AccumChTo = Convert.IsDBNull(reader["ACCUM_CH_TO"]) ? null : (System.Decimal?)reader["ACCUM_CH_TO"];
					c.DiscontSemCount = Convert.IsDBNull(reader["DISCONT_SEM_COUNT"]) ? null : (System.Decimal?)reader["DISCONT_SEM_COUNT"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPlcyAcadWarnDtlId = (System.Decimal)reader[((int)EntPlcyAcadWarnDtlColumn.EntPlcyAcadWarnDtlId - 1)];
			entity.OriginalEntPlcyAcadWarnDtlId = (System.Decimal)reader["ENT_PLCY_ACAD_WARN_DTL_ID"];
			entity.EntPlcyAcadWarnId = (System.Decimal)reader[((int)EntPlcyAcadWarnDtlColumn.EntPlcyAcadWarnId - 1)];
			entity.EdCdeAcadWarnTypeId = (System.Decimal)reader[((int)EntPlcyAcadWarnDtlColumn.EdCdeAcadWarnTypeId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnDtlColumn.AsCodeDegreeId - 1)];
			entity.MinGpa = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.MinGpa - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnDtlColumn.MinGpa - 1)];
			entity.MinCgpa = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.MinCgpa - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnDtlColumn.MinCgpa - 1)];
			entity.AccumChFrom = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.AccumChFrom - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnDtlColumn.AccumChFrom - 1)];
			entity.AccumChTo = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.AccumChTo - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnDtlColumn.AccumChTo - 1)];
			entity.DiscontSemCount = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.DiscontSemCount - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnDtlColumn.DiscontSemCount - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EntPlcyAcadWarnDtlColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EntPlcyAcadWarnDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EntPlcyAcadWarnDtlColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPlcyAcadWarnDtlId = (System.Decimal)dataRow["ENT_PLCY_ACAD_WARN_DTL_ID"];
			entity.OriginalEntPlcyAcadWarnDtlId = (System.Decimal)dataRow["ENT_PLCY_ACAD_WARN_DTL_ID"];
			entity.EntPlcyAcadWarnId = (System.Decimal)dataRow["ENT_PLCY_ACAD_WARN_ID"];
			entity.EdCdeAcadWarnTypeId = (System.Decimal)dataRow["ED_CDE_ACAD_WARN_TYPE_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.MinGpa = Convert.IsDBNull(dataRow["MIN_GPA"]) ? null : (System.Decimal?)dataRow["MIN_GPA"];
			entity.MinCgpa = Convert.IsDBNull(dataRow["MIN_CGPA"]) ? null : (System.Decimal?)dataRow["MIN_CGPA"];
			entity.AccumChFrom = Convert.IsDBNull(dataRow["ACCUM_CH_FROM"]) ? null : (System.Decimal?)dataRow["ACCUM_CH_FROM"];
			entity.AccumChTo = Convert.IsDBNull(dataRow["ACCUM_CH_TO"]) ? null : (System.Decimal?)dataRow["ACCUM_CH_TO"];
			entity.DiscontSemCount = Convert.IsDBNull(dataRow["DISCONT_SEM_COUNT"]) ? null : (System.Decimal?)dataRow["DISCONT_SEM_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EdCdeAcadWarnTypeIdSource	
			if (CanDeepLoad(entity, "EdCdeAcadWarnType|EdCdeAcadWarnTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCdeAcadWarnTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeAcadWarnTypeId;
				EdCdeAcadWarnType tmpEntity = EntityManager.LocateEntity<EdCdeAcadWarnType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeAcadWarnType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeAcadWarnTypeIdSource = tmpEntity;
				else
					entity.EdCdeAcadWarnTypeIdSource = DataRepository.EdCdeAcadWarnTypeProvider.GetByEdCdeAcadWarnTypeId(transactionManager, entity.EdCdeAcadWarnTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeAcadWarnTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeAcadWarnTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeAcadWarnTypeProvider.DeepLoad(transactionManager, entity.EdCdeAcadWarnTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeAcadWarnTypeIdSource

			#region EntPlcyAcadWarnIdSource	
			if (CanDeepLoad(entity, "EntPlcyAcadWarn|EntPlcyAcadWarnIdSource", deepLoadType, innerList) 
				&& entity.EntPlcyAcadWarnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPlcyAcadWarnId;
				EntPlcyAcadWarn tmpEntity = EntityManager.LocateEntity<EntPlcyAcadWarn>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPlcyAcadWarn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPlcyAcadWarnIdSource = tmpEntity;
				else
					entity.EntPlcyAcadWarnIdSource = DataRepository.EntPlcyAcadWarnProvider.GetByEntPlcyAcadWarnId(transactionManager, entity.EntPlcyAcadWarnId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPlcyAcadWarnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPlcyAcadWarnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPlcyAcadWarnProvider.DeepLoad(transactionManager, entity.EntPlcyAcadWarnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPlcyAcadWarnIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCdeAcadWarnTypeIdSource
			if (CanDeepSave(entity, "EdCdeAcadWarnType|EdCdeAcadWarnTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCdeAcadWarnTypeIdSource != null)
			{
				DataRepository.EdCdeAcadWarnTypeProvider.Save(transactionManager, entity.EdCdeAcadWarnTypeIdSource);
				entity.EdCdeAcadWarnTypeId = entity.EdCdeAcadWarnTypeIdSource.EdCdeAcadWarnTypeId;
			}
			#endregion 
			
			#region EntPlcyAcadWarnIdSource
			if (CanDeepSave(entity, "EntPlcyAcadWarn|EntPlcyAcadWarnIdSource", deepSaveType, innerList) 
				&& entity.EntPlcyAcadWarnIdSource != null)
			{
				DataRepository.EntPlcyAcadWarnProvider.Save(transactionManager, entity.EntPlcyAcadWarnIdSource);
				entity.EntPlcyAcadWarnId = entity.EntPlcyAcadWarnIdSource.EntPlcyAcadWarnId;
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
	
	#region EntPlcyAcadWarnDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPlcyAcadWarnDtl</c>
	///</summary>
	public enum EntPlcyAcadWarnDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>EdCdeAcadWarnType</c> at EdCdeAcadWarnTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeAcadWarnType))]
		EdCdeAcadWarnType,
		
		///<summary>
		/// Composite Property for <c>EntPlcyAcadWarn</c> at EntPlcyAcadWarnIdSource
		///</summary>
		[ChildEntityType(typeof(EntPlcyAcadWarn))]
		EntPlcyAcadWarn,
	}
	
	#endregion EntPlcyAcadWarnDtlChildEntityTypes
	
	#region EntPlcyAcadWarnDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPlcyAcadWarnDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPlcyAcadWarnDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPlcyAcadWarnDtlFilterBuilder : SqlFilterBuilder<EntPlcyAcadWarnDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnDtlFilterBuilder class.
		/// </summary>
		public EntPlcyAcadWarnDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPlcyAcadWarnDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPlcyAcadWarnDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPlcyAcadWarnDtlFilterBuilder
	
	#region EntPlcyAcadWarnDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPlcyAcadWarnDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPlcyAcadWarnDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPlcyAcadWarnDtlParameterBuilder : ParameterizedSqlFilterBuilder<EntPlcyAcadWarnDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnDtlParameterBuilder class.
		/// </summary>
		public EntPlcyAcadWarnDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPlcyAcadWarnDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPlcyAcadWarnDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPlcyAcadWarnDtlParameterBuilder
	
	#region EntPlcyAcadWarnDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPlcyAcadWarnDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPlcyAcadWarnDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPlcyAcadWarnDtlSortBuilder : SqlSortBuilder<EntPlcyAcadWarnDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPlcyAcadWarnDtlSqlSortBuilder class.
		/// </summary>
		public EntPlcyAcadWarnDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPlcyAcadWarnDtlSortBuilder
	
} // end namespace
