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
	/// This class is the base class for any <see cref="EdStudActvtyRegProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudActvtyRegProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudActvtyReg, UMIS_VER2.BusinessLyer.EdStudActvtyRegKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActvtyRegKey key)
		{
			return Delete(transactionManager, key.EdStudActvtyReg);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudActvtyReg)
		{
			return Delete(null, _edStudActvtyReg);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudActvtyReg);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByEdStudSemesterId(System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(_edStudSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudActvtyReg> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER key.
		///		fkEdStudActvtyRegEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER key.
		///		fkEdStudActvtyRegEdStudSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByEdStudSemesterId(System.Decimal _edStudSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER key.
		///		FK_ED_STUD_ACTVTY_REG_ED_STUD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public abstract TList<EdStudActvtyReg> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal _edStudSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY key.
		///		FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByGsCdeActvtyId(System.Int32 _gsCdeActvtyId)
		{
			int count = -1;
			return GetByGsCdeActvtyId(_gsCdeActvtyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY key.
		///		FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudActvtyReg> GetByGsCdeActvtyId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyId)
		{
			int count = -1;
			return GetByGsCdeActvtyId(transactionManager, _gsCdeActvtyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY key.
		///		FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByGsCdeActvtyId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeActvtyId(transactionManager, _gsCdeActvtyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY key.
		///		fkEdStudActvtyRegGsCdeActvty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByGsCdeActvtyId(System.Int32 _gsCdeActvtyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeActvtyId(null, _gsCdeActvtyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY key.
		///		fkEdStudActvtyRegGsCdeActvty Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetByGsCdeActvtyId(System.Int32 _gsCdeActvtyId, int start, int pageLength,out int count)
		{
			return GetByGsCdeActvtyId(null, _gsCdeActvtyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY key.
		///		FK_ED_STUD_ACTVTY_REG_GS_CDE_ACTVTY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyId">اكواد الانشطة اللاصفية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public abstract TList<EdStudActvtyReg> GetByGsCdeActvtyId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER key.
		///		FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId">المرشد المشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER key.
		///		FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">المرشد المشرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		/// <remarks></remarks>
		public TList<EdStudActvtyReg> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER key.
		///		FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">المرشد المشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER key.
		///		fkEdStudActvtyRegSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">المرشد المشرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER key.
		///		fkEdStudActvtyRegSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId">المرشد المشرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public TList<EdStudActvtyReg> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER key.
		///		FK_ED_STUD_ACTVTY_REG_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId">المرشد المشرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdStudActvtyReg objects.</returns>
		public abstract TList<EdStudActvtyReg> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdStudActvtyReg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActvtyRegKey key, int start, int pageLength)
		{
			return GetByEdStudActvtyReg(transactionManager, key.EdStudActvtyReg, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_ACTVTY_REG index.
		/// </summary>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActvtyReg GetByEdStudActvtyReg(System.Decimal _edStudActvtyReg)
		{
			int count = -1;
			return GetByEdStudActvtyReg(null,_edStudActvtyReg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ACTVTY_REG index.
		/// </summary>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActvtyReg GetByEdStudActvtyReg(System.Decimal _edStudActvtyReg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudActvtyReg(null, _edStudActvtyReg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ACTVTY_REG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActvtyReg GetByEdStudActvtyReg(TransactionManager transactionManager, System.Decimal _edStudActvtyReg)
		{
			int count = -1;
			return GetByEdStudActvtyReg(transactionManager, _edStudActvtyReg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ACTVTY_REG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActvtyReg GetByEdStudActvtyReg(TransactionManager transactionManager, System.Decimal _edStudActvtyReg, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudActvtyReg(transactionManager, _edStudActvtyReg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ACTVTY_REG index.
		/// </summary>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudActvtyReg GetByEdStudActvtyReg(System.Decimal _edStudActvtyReg, int start, int pageLength, out int count)
		{
			return GetByEdStudActvtyReg(null, _edStudActvtyReg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_ACTVTY_REG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudActvtyReg">طلب تسجيل ساعات نشاط  لاصفى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudActvtyReg GetByEdStudActvtyReg(TransactionManager transactionManager, System.Decimal _edStudActvtyReg, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudActvtyReg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudActvtyReg&gt;"/></returns>
		public static TList<EdStudActvtyReg> Fill(IDataReader reader, TList<EdStudActvtyReg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudActvtyReg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudActvtyReg")
					.Append("|").Append((System.Decimal)reader["ED_STUD_ACTVTY_REG"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudActvtyReg>(
					key.ToString(), // EntityTrackingKey
					"EdStudActvtyReg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudActvtyReg();
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
					c.EdStudActvtyReg = (System.Decimal)reader["ED_STUD_ACTVTY_REG"];
					c.OriginalEdStudActvtyReg = c.EdStudActvtyReg;
					c.EdStudSemesterId = (System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					c.GsCdeActvtyId = (System.Int32)reader["GS_CDE_ACTVTY_ID"];
					c.ActvtyFrom = (System.DateTime)reader["ACTVTY_FROM"];
					c.ActvtyTo = (System.DateTime)reader["ACTVTY_TO"];
					c.ActvtyHours = Convert.IsDBNull(reader["ACTVTY_HOURS"]) ? null : (System.Decimal?)reader["ACTVTY_HOURS"];
					c.ActvtyLoc = Convert.IsDBNull(reader["ACTVTY_LOC"]) ? null : (System.String)reader["ACTVTY_LOC"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.ReqNum = Convert.IsDBNull(reader["REQ_NUM"]) ? null : (System.Decimal?)reader["REQ_NUM"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudActvtyReg entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudActvtyReg = (System.Decimal)reader[((int)EdStudActvtyRegColumn.EdStudActvtyReg - 1)];
			entity.OriginalEdStudActvtyReg = (System.Decimal)reader["ED_STUD_ACTVTY_REG"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)EdStudActvtyRegColumn.EdStudSemesterId - 1)];
			entity.GsCdeActvtyId = (System.Int32)reader[((int)EdStudActvtyRegColumn.GsCdeActvtyId - 1)];
			entity.ActvtyFrom = (System.DateTime)reader[((int)EdStudActvtyRegColumn.ActvtyFrom - 1)];
			entity.ActvtyTo = (System.DateTime)reader[((int)EdStudActvtyRegColumn.ActvtyTo - 1)];
			entity.ActvtyHours = (reader.IsDBNull(((int)EdStudActvtyRegColumn.ActvtyHours - 1)))?null:(System.Decimal?)reader[((int)EdStudActvtyRegColumn.ActvtyHours - 1)];
			entity.ActvtyLoc = (reader.IsDBNull(((int)EdStudActvtyRegColumn.ActvtyLoc - 1)))?null:(System.String)reader[((int)EdStudActvtyRegColumn.ActvtyLoc - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)EdStudActvtyRegColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)EdStudActvtyRegColumn.SaStfMemberId - 1)];
			entity.ReqNum = (reader.IsDBNull(((int)EdStudActvtyRegColumn.ReqNum - 1)))?null:(System.Decimal?)reader[((int)EdStudActvtyRegColumn.ReqNum - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudActvtyRegColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudActvtyRegColumn.Notes - 1)];
			entity.LastDate = (reader.IsDBNull(((int)EdStudActvtyRegColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)EdStudActvtyRegColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)EdStudActvtyRegColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)EdStudActvtyRegColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudActvtyReg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudActvtyReg = (System.Decimal)dataRow["ED_STUD_ACTVTY_REG"];
			entity.OriginalEdStudActvtyReg = (System.Decimal)dataRow["ED_STUD_ACTVTY_REG"];
			entity.EdStudSemesterId = (System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.GsCdeActvtyId = (System.Int32)dataRow["GS_CDE_ACTVTY_ID"];
			entity.ActvtyFrom = (System.DateTime)dataRow["ACTVTY_FROM"];
			entity.ActvtyTo = (System.DateTime)dataRow["ACTVTY_TO"];
			entity.ActvtyHours = Convert.IsDBNull(dataRow["ACTVTY_HOURS"]) ? null : (System.Decimal?)dataRow["ACTVTY_HOURS"];
			entity.ActvtyLoc = Convert.IsDBNull(dataRow["ACTVTY_LOC"]) ? null : (System.String)dataRow["ACTVTY_LOC"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.ReqNum = Convert.IsDBNull(dataRow["REQ_NUM"]) ? null : (System.Decimal?)dataRow["REQ_NUM"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudActvtyReg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudActvtyReg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActvtyReg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region GsCdeActvtyIdSource	
			if (CanDeepLoad(entity, "GsCdeActvty|GsCdeActvtyIdSource", deepLoadType, innerList) 
				&& entity.GsCdeActvtyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeActvtyId;
				GsCdeActvty tmpEntity = EntityManager.LocateEntity<GsCdeActvty>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeActvty), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeActvtyIdSource = tmpEntity;
				else
					entity.GsCdeActvtyIdSource = DataRepository.GsCdeActvtyProvider.GetByGsCdeActvtyId(transactionManager, entity.GsCdeActvtyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeActvtyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeActvtyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeActvtyProvider.DeepLoad(transactionManager, entity.GsCdeActvtyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeActvtyIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudActvtyReg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudActvtyReg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudActvtyReg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudActvtyReg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region GsCdeActvtyIdSource
			if (CanDeepSave(entity, "GsCdeActvty|GsCdeActvtyIdSource", deepSaveType, innerList) 
				&& entity.GsCdeActvtyIdSource != null)
			{
				DataRepository.GsCdeActvtyProvider.Save(transactionManager, entity.GsCdeActvtyIdSource);
				entity.GsCdeActvtyId = entity.GsCdeActvtyIdSource.GsCdeActvtyId;
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
	
	#region EdStudActvtyRegChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudActvtyReg</c>
	///</summary>
	public enum EdStudActvtyRegChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>GsCdeActvty</c> at GsCdeActvtyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeActvty))]
		GsCdeActvty,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion EdStudActvtyRegChildEntityTypes
	
	#region EdStudActvtyRegFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudActvtyRegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudActvtyReg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudActvtyRegFilterBuilder : SqlFilterBuilder<EdStudActvtyRegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudActvtyRegFilterBuilder class.
		/// </summary>
		public EdStudActvtyRegFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudActvtyRegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudActvtyRegFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudActvtyRegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudActvtyRegFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudActvtyRegFilterBuilder
	
	#region EdStudActvtyRegParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudActvtyRegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudActvtyReg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudActvtyRegParameterBuilder : ParameterizedSqlFilterBuilder<EdStudActvtyRegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudActvtyRegParameterBuilder class.
		/// </summary>
		public EdStudActvtyRegParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudActvtyRegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudActvtyRegParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudActvtyRegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudActvtyRegParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudActvtyRegParameterBuilder
	
	#region EdStudActvtyRegSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudActvtyRegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudActvtyReg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudActvtyRegSortBuilder : SqlSortBuilder<EdStudActvtyRegColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudActvtyRegSqlSortBuilder class.
		/// </summary>
		public EdStudActvtyRegSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudActvtyRegSortBuilder
	
} // end namespace
