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
	/// This class is the base class for any <see cref="SvStudStaffEvalExtProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudStaffEvalExtProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudStaffEvalExt, UMIS_VER2.BusinessLyer.SvStudStaffEvalExtKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEvalExtKey key)
		{
			return Delete(transactionManager, key.SvStudStaffEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudStaffEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudStaffEvalExtId)
		{
			return Delete(null, _svStudStaffEvalExtId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalExtId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudStaffEvalExtId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudStaffEvalExt> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD key.
		///		fkSvStudStaffEvalExtEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD key.
		///		fkSvStudStaffEvalExtEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">فى حالة STUD_STAFF_FLG=2</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public abstract TList<SvStudStaffEvalExt> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudStaffEvalExt> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER key.
		///		fkSvStudStaffEvalExtSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER key.
		///		fkSvStudStaffEvalExtSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public abstract TList<SvStudStaffEvalExt> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT Description: 
		/// </summary>
		/// <param name="_svStaffEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySvStaffEvalExtId(System.Decimal _svStaffEvalExtId)
		{
			int count = -1;
			return GetBySvStaffEvalExtId(_svStaffEvalExtId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudStaffEvalExt> GetBySvStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStaffEvalExtId)
		{
			int count = -1;
			return GetBySvStaffEvalExtId(transactionManager, _svStaffEvalExtId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySvStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStaffEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffEvalExtId(transactionManager, _svStaffEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT key.
		///		fkSvStudStaffEvalExtSvStaffEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySvStaffEvalExtId(System.Decimal _svStaffEvalExtId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvStaffEvalExtId(null, _svStaffEvalExtId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT key.
		///		fkSvStudStaffEvalExtSvStaffEvalExt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public TList<SvStudStaffEvalExt> GetBySvStaffEvalExtId(System.Decimal _svStaffEvalExtId, int start, int pageLength,out int count)
		{
			return GetBySvStaffEvalExtId(null, _svStaffEvalExtId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT key.
		///		FK_SV_STUD_STAFF_EVAL_EXT_SV_STAFF_EVAL_EXT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudStaffEvalExt objects.</returns>
		public abstract TList<SvStudStaffEvalExt> GetBySvStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStaffEvalExtId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStudStaffEvalExt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEvalExtKey key, int start, int pageLength)
		{
			return GetBySvStudStaffEvalExtId(transactionManager, key.SvStudStaffEvalExtId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStudStaffEvalExtId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEvalExt GetBySvStudStaffEvalExtId(System.Decimal _svStudStaffEvalExtId)
		{
			int count = -1;
			return GetBySvStudStaffEvalExtId(null,_svStudStaffEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStudStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEvalExt GetBySvStudStaffEvalExtId(System.Decimal _svStudStaffEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudStaffEvalExtId(null, _svStudStaffEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalExtId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEvalExt GetBySvStudStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStudStaffEvalExtId)
		{
			int count = -1;
			return GetBySvStudStaffEvalExtId(transactionManager, _svStudStaffEvalExtId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEvalExt GetBySvStudStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStudStaffEvalExtId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudStaffEvalExtId(transactionManager, _svStudStaffEvalExtId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="_svStudStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudStaffEvalExt GetBySvStudStaffEvalExtId(System.Decimal _svStudStaffEvalExtId, int start, int pageLength, out int count)
		{
			return GetBySvStudStaffEvalExtId(null, _svStudStaffEvalExtId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_STAFF_EVAL_EXT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudStaffEvalExtId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudStaffEvalExt GetBySvStudStaffEvalExtId(TransactionManager transactionManager, System.Decimal _svStudStaffEvalExtId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudStaffEvalExt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudStaffEvalExt&gt;"/></returns>
		public static TList<SvStudStaffEvalExt> Fill(IDataReader reader, TList<SvStudStaffEvalExt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudStaffEvalExt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudStaffEvalExt")
					.Append("|").Append((System.Decimal)reader["SV_STUD_STAFF_EVAL_EXT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudStaffEvalExt>(
					key.ToString(), // EntityTrackingKey
					"SvStudStaffEvalExt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudStaffEvalExt();
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
					c.SvStudStaffEvalExtId = (System.Decimal)reader["SV_STUD_STAFF_EVAL_EXT_ID"];
					c.OriginalSvStudStaffEvalExtId = c.SvStudStaffEvalExtId;
					c.SvStaffEvalExtId = (System.Decimal)reader["SV_STAFF_EVAL_EXT_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.EvalExtRply = Convert.IsDBNull(reader["EVAL_EXT_RPLY"]) ? null : (System.String)reader["EVAL_EXT_RPLY"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudStaffEvalExt entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudStaffEvalExtId = (System.Decimal)reader[((int)SvStudStaffEvalExtColumn.SvStudStaffEvalExtId - 1)];
			entity.OriginalSvStudStaffEvalExtId = (System.Decimal)reader["SV_STUD_STAFF_EVAL_EXT_ID"];
			entity.SvStaffEvalExtId = (System.Decimal)reader[((int)SvStudStaffEvalExtColumn.SvStaffEvalExtId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)SvStudStaffEvalExtColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)SvStudStaffEvalExtColumn.SaStfMemberId - 1)];
			entity.EvalExtRply = (reader.IsDBNull(((int)SvStudStaffEvalExtColumn.EvalExtRply - 1)))?null:(System.String)reader[((int)SvStudStaffEvalExtColumn.EvalExtRply - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)SvStudStaffEvalExtColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)SvStudStaffEvalExtColumn.EdStudId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudStaffEvalExt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudStaffEvalExtId = (System.Decimal)dataRow["SV_STUD_STAFF_EVAL_EXT_ID"];
			entity.OriginalSvStudStaffEvalExtId = (System.Decimal)dataRow["SV_STUD_STAFF_EVAL_EXT_ID"];
			entity.SvStaffEvalExtId = (System.Decimal)dataRow["SV_STAFF_EVAL_EXT_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.EvalExtRply = Convert.IsDBNull(dataRow["EVAL_EXT_RPLY"]) ? null : (System.String)dataRow["EVAL_EXT_RPLY"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudStaffEvalExt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudStaffEvalExt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEvalExt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
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

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource

			#region SvStaffEvalExtIdSource	
			if (CanDeepLoad(entity, "SvStaffEvalExt|SvStaffEvalExtIdSource", deepLoadType, innerList) 
				&& entity.SvStaffEvalExtIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvStaffEvalExtId;
				SvStaffEvalExt tmpEntity = EntityManager.LocateEntity<SvStaffEvalExt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvStaffEvalExt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvStaffEvalExtIdSource = tmpEntity;
				else
					entity.SvStaffEvalExtIdSource = DataRepository.SvStaffEvalExtProvider.GetBySvStaffEvalExtId(transactionManager, entity.SvStaffEvalExtId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvalExtIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvStaffEvalExtIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvStaffEvalExtProvider.DeepLoad(transactionManager, entity.SvStaffEvalExtIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvStaffEvalExtIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudStaffEvalExt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudStaffEvalExt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudStaffEvalExt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudStaffEvalExt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
			}
			#endregion 
			
			#region SvStaffEvalExtIdSource
			if (CanDeepSave(entity, "SvStaffEvalExt|SvStaffEvalExtIdSource", deepSaveType, innerList) 
				&& entity.SvStaffEvalExtIdSource != null)
			{
				DataRepository.SvStaffEvalExtProvider.Save(transactionManager, entity.SvStaffEvalExtIdSource);
				entity.SvStaffEvalExtId = entity.SvStaffEvalExtIdSource.SvStaffEvalExtId;
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
	
	#region SvStudStaffEvalExtChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudStaffEvalExt</c>
	///</summary>
	public enum SvStudStaffEvalExtChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SvStaffEvalExt</c> at SvStaffEvalExtIdSource
		///</summary>
		[ChildEntityType(typeof(SvStaffEvalExt))]
		SvStaffEvalExt,
	}
	
	#endregion SvStudStaffEvalExtChildEntityTypes
	
	#region SvStudStaffEvalExtFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudStaffEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudStaffEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudStaffEvalExtFilterBuilder : SqlFilterBuilder<SvStudStaffEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalExtFilterBuilder class.
		/// </summary>
		public SvStudStaffEvalExtFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudStaffEvalExtFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalExtFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudStaffEvalExtFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudStaffEvalExtFilterBuilder
	
	#region SvStudStaffEvalExtParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudStaffEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudStaffEvalExt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudStaffEvalExtParameterBuilder : ParameterizedSqlFilterBuilder<SvStudStaffEvalExtColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalExtParameterBuilder class.
		/// </summary>
		public SvStudStaffEvalExtParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudStaffEvalExtParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalExtParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudStaffEvalExtParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudStaffEvalExtParameterBuilder
	
	#region SvStudStaffEvalExtSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudStaffEvalExtColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudStaffEvalExt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudStaffEvalExtSortBuilder : SqlSortBuilder<SvStudStaffEvalExtColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudStaffEvalExtSqlSortBuilder class.
		/// </summary>
		public SvStudStaffEvalExtSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudStaffEvalExtSortBuilder
	
} // end namespace
