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
	/// This class is the base class for any <see cref="SeUserAccntProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserAccntProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeUserAccnt, UMIS_VER2.BusinessLyer.SeUserAccntKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntKey key)
		{
			return Delete(transactionManager, key.SeUserAccntId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seUserAccntId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seUserAccntId)
		{
			return Delete(null, _seUserAccntId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seUserAccntId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserAccnt> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS key.
		///		fkSeUserAccntAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS key.
		///		fkSeUserAccntAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS key.
		///		FK_SE_USER_ACCNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public abstract TList<SeUserAccnt> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_ENTITY_MAIN key.
		///		FK_SE_USER_ACCNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId">جامعة -كلية -قسم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_ENTITY_MAIN key.
		///		FK_SE_USER_ACCNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">جامعة -كلية -قسم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserAccnt> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_ENTITY_MAIN key.
		///		FK_SE_USER_ACCNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">جامعة -كلية -قسم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_ENTITY_MAIN key.
		///		fkSeUserAccntEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">جامعة -كلية -قسم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_ENTITY_MAIN key.
		///		fkSeUserAccntEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId">جامعة -كلية -قسم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_ENTITY_MAIN key.
		///		FK_SE_USER_ACCNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId">جامعة -كلية -قسم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public abstract TList<SeUserAccnt> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_GS_CODE_GENDER key.
		///		FK_SE_USER_ACCNT_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_GS_CODE_GENDER key.
		///		FK_SE_USER_ACCNT_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		/// <remarks></remarks>
		public TList<SeUserAccnt> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_GS_CODE_GENDER key.
		///		FK_SE_USER_ACCNT_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_GS_CODE_GENDER key.
		///		fkSeUserAccntGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_GS_CODE_GENDER key.
		///		fkSeUserAccntGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public TList<SeUserAccnt> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_USER_ACCNT_GS_CODE_GENDER key.
		///		FK_SE_USER_ACCNT_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeUserAccnt objects.</returns>
		public abstract TList<SeUserAccnt> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeUserAccnt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccntKey key, int start, int pageLength)
		{
			return GetBySeUserAccntId(transactionManager, key.SeUserAccntId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="_seAccountId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserIdSeAccountId(System.Decimal _seUserId, System.Decimal _seAccountId)
		{
			int count = -1;
			return GetBySeUserIdSeAccountId(null,_seUserId, _seAccountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserIdSeAccountId(System.Decimal _seUserId, System.Decimal _seAccountId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserIdSeAccountId(null, _seUserId, _seAccountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="_seAccountId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserIdSeAccountId(TransactionManager transactionManager, System.Decimal _seUserId, System.Decimal _seAccountId)
		{
			int count = -1;
			return GetBySeUserIdSeAccountId(transactionManager, _seUserId, _seAccountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserIdSeAccountId(TransactionManager transactionManager, System.Decimal _seUserId, System.Decimal _seAccountId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserIdSeAccountId(transactionManager, _seUserId, _seAccountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserIdSeAccountId(System.Decimal _seUserId, System.Decimal _seAccountId, int start, int pageLength, out int count)
		{
			return GetBySeUserIdSeAccountId(null, _seUserId, _seAccountId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserIdSeAccountId(TransactionManager transactionManager, System.Decimal _seUserId, System.Decimal _seAccountId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="_seAccountId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeAccountId(System.Decimal _seAccountId)
		{
			int count = -1;
			return GetBySeAccountId(null,_seAccountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeAccountId(System.Decimal _seAccountId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccountId(null, _seAccountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccountId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeAccountId(TransactionManager transactionManager, System.Decimal _seAccountId)
		{
			int count = -1;
			return GetBySeAccountId(transactionManager, _seAccountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeAccountId(TransactionManager transactionManager, System.Decimal _seAccountId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeAccountId(transactionManager, _seAccountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeAccountId(System.Decimal _seAccountId, int start, int pageLength, out int count)
		{
			return GetBySeAccountId(null, _seAccountId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_ACCOUNT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seAccountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public abstract TList<SeUserAccnt> GetBySeAccountId(TransactionManager transactionManager, System.Decimal _seAccountId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeUserId(System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(null,_seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public TList<SeUserAccnt> GetBySeUserId(System.Decimal _seUserId, int start, int pageLength, out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_USER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeUserAccnt&gt;"/> class.</returns>
		public abstract TList<SeUserAccnt> GetBySeUserId(TransactionManager transactionManager, System.Decimal _seUserId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="_seUserAccntId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserAccntId(System.Decimal _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(null,_seUserAccntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserAccntId(System.Decimal _seUserAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal _seUserAccntId)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal _seUserAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserAccntId(transactionManager, _seUserAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserAccntId(System.Decimal _seUserAccntId, int start, int pageLength, out int count)
		{
			return GetBySeUserAccntId(null, _seUserAccntId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_USER_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeUserAccnt GetBySeUserAccntId(TransactionManager transactionManager, System.Decimal _seUserAccntId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeUserAccnt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeUserAccnt&gt;"/></returns>
		public static TList<SeUserAccnt> Fill(IDataReader reader, TList<SeUserAccnt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeUserAccnt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeUserAccnt")
					.Append("|").Append((System.Decimal)reader["SE_USER_ACCNT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeUserAccnt>(
					key.ToString(), // EntityTrackingKey
					"SeUserAccnt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeUserAccnt();
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
					c.SeUserAccntId = (System.Decimal)reader["SE_USER_ACCNT_ID"];
					c.OriginalSeUserAccntId = c.SeUserAccntId;
					c.SeUserId = (System.Decimal)reader["SE_USER_ID"];
					c.SeAccountId = (System.Decimal)reader["SE_ACCOUNT_ID"];
					c.ContCreateFlg = Convert.IsDBNull(reader["CONT_CREATE_FLG"]) ? null : (System.Decimal?)reader["CONT_CREATE_FLG"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.RcvMailFlg = Convert.IsDBNull(reader["RCV_MAIL_FLG"]) ? null : (System.Decimal?)reader["RCV_MAIL_FLG"];
					c.HeadFlg = Convert.IsDBNull(reader["HEAD_FLG"]) ? null : (System.Decimal?)reader["HEAD_FLG"];
					c.AvailPeriodFromDate = Convert.IsDBNull(reader["AVAIL_PERIOD_FROM_DATE"]) ? null : (System.DateTime?)reader["AVAIL_PERIOD_FROM_DATE"];
					c.AvailPeriodFromTime = Convert.IsDBNull(reader["AVAIL_PERIOD_FROM_TIME"]) ? null : (System.DateTime?)reader["AVAIL_PERIOD_FROM_TIME"];
					c.AvailPeriodToDate = Convert.IsDBNull(reader["AVAIL_PERIOD_TO_DATE"]) ? null : (System.DateTime?)reader["AVAIL_PERIOD_TO_DATE"];
					c.AvailPeriodToTime = Convert.IsDBNull(reader["AVAIL_PERIOD_TO_TIME"]) ? null : (System.DateTime?)reader["AVAIL_PERIOD_TO_TIME"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.HasAvailPeriod = Convert.IsDBNull(reader["HAS_AVAIL_PERIOD"]) ? null : (System.Decimal?)reader["HAS_AVAIL_PERIOD"];
					c.UserTableId = Convert.IsDBNull(reader["USER_TABLE_ID"]) ? null : (System.Decimal?)reader["USER_TABLE_ID"];
					c.ByforceFlg = Convert.IsDBNull(reader["BYFORCE_FLG"]) ? null : (System.Decimal?)reader["BYFORCE_FLG"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserLstId = Convert.IsDBNull(reader["SE_USER_LST_ID"]) ? null : (System.Decimal?)reader["SE_USER_LST_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeUserAccnt entity)
		{
			if (!reader.Read()) return;
			
			entity.SeUserAccntId = (System.Decimal)reader[((int)SeUserAccntColumn.SeUserAccntId - 1)];
			entity.OriginalSeUserAccntId = (System.Decimal)reader["SE_USER_ACCNT_ID"];
			entity.SeUserId = (System.Decimal)reader[((int)SeUserAccntColumn.SeUserId - 1)];
			entity.SeAccountId = (System.Decimal)reader[((int)SeUserAccntColumn.SeAccountId - 1)];
			entity.ContCreateFlg = (reader.IsDBNull(((int)SeUserAccntColumn.ContCreateFlg - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.ContCreateFlg - 1)];
			entity.IsActive = (System.Decimal)reader[((int)SeUserAccntColumn.IsActive - 1)];
			entity.RcvMailFlg = (reader.IsDBNull(((int)SeUserAccntColumn.RcvMailFlg - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.RcvMailFlg - 1)];
			entity.HeadFlg = (reader.IsDBNull(((int)SeUserAccntColumn.HeadFlg - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.HeadFlg - 1)];
			entity.AvailPeriodFromDate = (reader.IsDBNull(((int)SeUserAccntColumn.AvailPeriodFromDate - 1)))?null:(System.DateTime?)reader[((int)SeUserAccntColumn.AvailPeriodFromDate - 1)];
			entity.AvailPeriodFromTime = (reader.IsDBNull(((int)SeUserAccntColumn.AvailPeriodFromTime - 1)))?null:(System.DateTime?)reader[((int)SeUserAccntColumn.AvailPeriodFromTime - 1)];
			entity.AvailPeriodToDate = (reader.IsDBNull(((int)SeUserAccntColumn.AvailPeriodToDate - 1)))?null:(System.DateTime?)reader[((int)SeUserAccntColumn.AvailPeriodToDate - 1)];
			entity.AvailPeriodToTime = (reader.IsDBNull(((int)SeUserAccntColumn.AvailPeriodToTime - 1)))?null:(System.DateTime?)reader[((int)SeUserAccntColumn.AvailPeriodToTime - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)SeUserAccntColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.EntMainId - 1)];
			entity.HasAvailPeriod = (reader.IsDBNull(((int)SeUserAccntColumn.HasAvailPeriod - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.HasAvailPeriod - 1)];
			entity.UserTableId = (reader.IsDBNull(((int)SeUserAccntColumn.UserTableId - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.UserTableId - 1)];
			entity.ByforceFlg = (reader.IsDBNull(((int)SeUserAccntColumn.ByforceFlg - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.ByforceFlg - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SeUserAccntColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SeUserAccntColumn.LastDate - 1)];
			entity.SeUserLstId = (reader.IsDBNull(((int)SeUserAccntColumn.SeUserLstId - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.SeUserLstId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)SeUserAccntColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.AsCodeDegreeClassId - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)SeUserAccntColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)SeUserAccntColumn.GsCodeGenderId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeUserAccnt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeUserAccntId = (System.Decimal)dataRow["SE_USER_ACCNT_ID"];
			entity.OriginalSeUserAccntId = (System.Decimal)dataRow["SE_USER_ACCNT_ID"];
			entity.SeUserId = (System.Decimal)dataRow["SE_USER_ID"];
			entity.SeAccountId = (System.Decimal)dataRow["SE_ACCOUNT_ID"];
			entity.ContCreateFlg = Convert.IsDBNull(dataRow["CONT_CREATE_FLG"]) ? null : (System.Decimal?)dataRow["CONT_CREATE_FLG"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.RcvMailFlg = Convert.IsDBNull(dataRow["RCV_MAIL_FLG"]) ? null : (System.Decimal?)dataRow["RCV_MAIL_FLG"];
			entity.HeadFlg = Convert.IsDBNull(dataRow["HEAD_FLG"]) ? null : (System.Decimal?)dataRow["HEAD_FLG"];
			entity.AvailPeriodFromDate = Convert.IsDBNull(dataRow["AVAIL_PERIOD_FROM_DATE"]) ? null : (System.DateTime?)dataRow["AVAIL_PERIOD_FROM_DATE"];
			entity.AvailPeriodFromTime = Convert.IsDBNull(dataRow["AVAIL_PERIOD_FROM_TIME"]) ? null : (System.DateTime?)dataRow["AVAIL_PERIOD_FROM_TIME"];
			entity.AvailPeriodToDate = Convert.IsDBNull(dataRow["AVAIL_PERIOD_TO_DATE"]) ? null : (System.DateTime?)dataRow["AVAIL_PERIOD_TO_DATE"];
			entity.AvailPeriodToTime = Convert.IsDBNull(dataRow["AVAIL_PERIOD_TO_TIME"]) ? null : (System.DateTime?)dataRow["AVAIL_PERIOD_TO_TIME"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.HasAvailPeriod = Convert.IsDBNull(dataRow["HAS_AVAIL_PERIOD"]) ? null : (System.Decimal?)dataRow["HAS_AVAIL_PERIOD"];
			entity.UserTableId = Convert.IsDBNull(dataRow["USER_TABLE_ID"]) ? null : (System.Decimal?)dataRow["USER_TABLE_ID"];
			entity.ByforceFlg = Convert.IsDBNull(dataRow["BYFORCE_FLG"]) ? null : (System.Decimal?)dataRow["BYFORCE_FLG"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserLstId = Convert.IsDBNull(dataRow["SE_USER_LST_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_LST_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeUserAccnt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccnt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccnt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeAccountIdSource	
			if (CanDeepLoad(entity, "SeAccnt|SeAccountIdSource", deepLoadType, innerList) 
				&& entity.SeAccountIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeAccountId;
				SeAccnt tmpEntity = EntityManager.LocateEntity<SeAccnt>(EntityLocator.ConstructKeyFromPkItems(typeof(SeAccnt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeAccountIdSource = tmpEntity;
				else
					entity.SeAccountIdSource = DataRepository.SeAccntProvider.GetBySeAccntId(transactionManager, entity.SeAccountId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccountIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeAccountIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeAccntProvider.DeepLoad(transactionManager, entity.SeAccountIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeAccountIdSource

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

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
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

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeUserId;
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, entity.SeUserId);		
				
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
			// Deep load child collections  - Call GetBySeUserAccntId methods when available
			
			#region SeUserAccntFormDiffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccntFormDiff>|SeUserAccntFormDiffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntFormDiffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntFormDiffCollection = DataRepository.SeUserAccntFormDiffProvider.GetBySeUserAccountId(transactionManager, entity.SeUserAccntId);

				if (deep && entity.SeUserAccntFormDiffCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccntFormDiff>) DataRepository.SeUserAccntFormDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntFormDiffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserAccntControlDiffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccntControlDiff>|SeUserAccntControlDiffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntControlDiffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntControlDiffCollection = DataRepository.SeUserAccntControlDiffProvider.GetBySeUserAccountId(transactionManager, entity.SeUserAccntId);

				if (deep && entity.SeUserAccntControlDiffCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntControlDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccntControlDiff>) DataRepository.SeUserAccntControlDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntControlDiffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserAccntDegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccntDeg>|SeUserAccntDegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntDegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntDegCollection = DataRepository.SeUserAccntDegProvider.GetBySeUserAccntId(transactionManager, entity.SeUserAccntId);

				if (deep && entity.SeUserAccntDegCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntDegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccntDeg>) DataRepository.SeUserAccntDegProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntDegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMessage>|SvMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMessageCollection = DataRepository.SvMessageProvider.GetBySeUserAccntId(transactionManager, entity.SeUserAccntId);

				if (deep && entity.SvMessageCollection.Count > 0)
				{
					deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMessage>) DataRepository.SvMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMessageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserMessage>|SvUserMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserMessageCollection = DataRepository.SvUserMessageProvider.GetBySeUserAccntId(transactionManager, entity.SeUserAccntId);

				if (deep && entity.SvUserMessageCollection.Count > 0)
				{
					deepHandles.Add("SvUserMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserMessage>) DataRepository.SvUserMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserMessageCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeUserAccnt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeUserAccnt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeUserAccnt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccnt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeAccountIdSource
			if (CanDeepSave(entity, "SeAccnt|SeAccountIdSource", deepSaveType, innerList) 
				&& entity.SeAccountIdSource != null)
			{
				DataRepository.SeAccntProvider.Save(transactionManager, entity.SeAccountIdSource);
				entity.SeAccountId = entity.SeAccountIdSource.SeAccntId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
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
	
			#region List<SeUserAccntFormDiff>
				if (CanDeepSave(entity.SeUserAccntFormDiffCollection, "List<SeUserAccntFormDiff>|SeUserAccntFormDiffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccntFormDiff child in entity.SeUserAccntFormDiffCollection)
					{
						if(child.SeUserAccountIdSource != null)
						{
							child.SeUserAccountId = child.SeUserAccountIdSource.SeUserAccntId;
						}
						else
						{
							child.SeUserAccountId = entity.SeUserAccntId;
						}

					}

					if (entity.SeUserAccntFormDiffCollection.Count > 0 || entity.SeUserAccntFormDiffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntFormDiffProvider.Save(transactionManager, entity.SeUserAccntFormDiffCollection);
						
						deepHandles.Add("SeUserAccntFormDiffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccntFormDiff >) DataRepository.SeUserAccntFormDiffProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntFormDiffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserAccntControlDiff>
				if (CanDeepSave(entity.SeUserAccntControlDiffCollection, "List<SeUserAccntControlDiff>|SeUserAccntControlDiffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccntControlDiff child in entity.SeUserAccntControlDiffCollection)
					{
						if(child.SeUserAccountIdSource != null)
						{
							child.SeUserAccountId = child.SeUserAccountIdSource.SeUserAccntId;
						}
						else
						{
							child.SeUserAccountId = entity.SeUserAccntId;
						}

					}

					if (entity.SeUserAccntControlDiffCollection.Count > 0 || entity.SeUserAccntControlDiffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntControlDiffProvider.Save(transactionManager, entity.SeUserAccntControlDiffCollection);
						
						deepHandles.Add("SeUserAccntControlDiffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccntControlDiff >) DataRepository.SeUserAccntControlDiffProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntControlDiffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserAccntDeg>
				if (CanDeepSave(entity.SeUserAccntDegCollection, "List<SeUserAccntDeg>|SeUserAccntDegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccntDeg child in entity.SeUserAccntDegCollection)
					{
						if(child.SeUserAccntIdSource != null)
						{
							child.SeUserAccntId = child.SeUserAccntIdSource.SeUserAccntId;
						}
						else
						{
							child.SeUserAccntId = entity.SeUserAccntId;
						}

					}

					if (entity.SeUserAccntDegCollection.Count > 0 || entity.SeUserAccntDegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntDegProvider.Save(transactionManager, entity.SeUserAccntDegCollection);
						
						deepHandles.Add("SeUserAccntDegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccntDeg >) DataRepository.SeUserAccntDegProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntDegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvMessage>
				if (CanDeepSave(entity.SvMessageCollection, "List<SvMessage>|SvMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMessage child in entity.SvMessageCollection)
					{
						if(child.SeUserAccntIdSource != null)
						{
							child.SeUserAccntId = child.SeUserAccntIdSource.SeUserAccntId;
						}
						else
						{
							child.SeUserAccntId = entity.SeUserAccntId;
						}

					}

					if (entity.SvMessageCollection.Count > 0 || entity.SvMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvMessageProvider.Save(transactionManager, entity.SvMessageCollection);
						
						deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMessage >) DataRepository.SvMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvMessageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserMessage>
				if (CanDeepSave(entity.SvUserMessageCollection, "List<SvUserMessage>|SvUserMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserMessage child in entity.SvUserMessageCollection)
					{
						if(child.SeUserAccntIdSource != null)
						{
							child.SeUserAccntId = child.SeUserAccntIdSource.SeUserAccntId;
						}
						else
						{
							child.SeUserAccntId = entity.SeUserAccntId;
						}

					}

					if (entity.SvUserMessageCollection.Count > 0 || entity.SvUserMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserMessageProvider.Save(transactionManager, entity.SvUserMessageCollection);
						
						deepHandles.Add("SvUserMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserMessage >) DataRepository.SvUserMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserMessageCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeUserAccntChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeUserAccnt</c>
	///</summary>
	public enum SeUserAccntChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeAccnt</c> at SeAccountIdSource
		///</summary>
		[ChildEntityType(typeof(SeAccnt))]
		SeAccnt,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>SeUserAccnt</c> as OneToMany for SeUserAccntFormDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccntFormDiff>))]
		SeUserAccntFormDiffCollection,
		///<summary>
		/// Collection of <c>SeUserAccnt</c> as OneToMany for SeUserAccntControlDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccntControlDiff>))]
		SeUserAccntControlDiffCollection,
		///<summary>
		/// Collection of <c>SeUserAccnt</c> as OneToMany for SeUserAccntDegCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccntDeg>))]
		SeUserAccntDegCollection,
		///<summary>
		/// Collection of <c>SeUserAccnt</c> as OneToMany for SvMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMessage>))]
		SvMessageCollection,
		///<summary>
		/// Collection of <c>SeUserAccnt</c> as OneToMany for SvUserMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserMessage>))]
		SvUserMessageCollection,
	}
	
	#endregion SeUserAccntChildEntityTypes
	
	#region SeUserAccntFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeUserAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccnt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntFilterBuilder : SqlFilterBuilder<SeUserAccntColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFilterBuilder class.
		/// </summary>
		public SeUserAccntFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntFilterBuilder
	
	#region SeUserAccntParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeUserAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccnt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeUserAccntParameterBuilder : ParameterizedSqlFilterBuilder<SeUserAccntColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntParameterBuilder class.
		/// </summary>
		public SeUserAccntParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeUserAccntParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeUserAccntParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeUserAccntParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeUserAccntParameterBuilder
	
	#region SeUserAccntSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeUserAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeUserAccnt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeUserAccntSortBuilder : SqlSortBuilder<SeUserAccntColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeUserAccntSqlSortBuilder class.
		/// </summary>
		public SeUserAccntSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeUserAccntSortBuilder
	
} // end namespace
