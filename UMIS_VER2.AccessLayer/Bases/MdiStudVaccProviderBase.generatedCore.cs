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
	/// This class is the base class for any <see cref="MdiStudVaccProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudVaccProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.MdiStudVacc, UMIS_VER2.BusinessLyer.MdiStudVaccKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudVaccKey key)
		{
			return Delete(transactionManager, key.MdiStudVaccId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _mdiStudVaccId)
		{
			return Delete(null, _mdiStudVaccId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _mdiStudVaccId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_ED_STUD key.
		///		FK_MDI_STUD_VACC_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_ED_STUD key.
		///		FK_MDI_STUD_VACC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudVacc> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_ED_STUD key.
		///		FK_MDI_STUD_VACC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_ED_STUD key.
		///		fkMdiStudVaccEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_ED_STUD key.
		///		fkMdiStudVaccEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_ED_STUD key.
		///		FK_MDI_STUD_VACC_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public abstract TList<MdiStudVacc> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_MDI_CDE_VACC key.
		///		FK_MDI_STUD_VACC_MDI_CDE_VACC Description: 
		/// </summary>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByMdiCdeVaccId(System.Decimal _mdiCdeVaccId)
		{
			int count = -1;
			return GetByMdiCdeVaccId(_mdiCdeVaccId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_MDI_CDE_VACC key.
		///		FK_MDI_STUD_VACC_MDI_CDE_VACC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		/// <remarks></remarks>
		public TList<MdiStudVacc> GetByMdiCdeVaccId(TransactionManager transactionManager, System.Decimal _mdiCdeVaccId)
		{
			int count = -1;
			return GetByMdiCdeVaccId(transactionManager, _mdiCdeVaccId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_MDI_CDE_VACC key.
		///		FK_MDI_STUD_VACC_MDI_CDE_VACC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByMdiCdeVaccId(TransactionManager transactionManager, System.Decimal _mdiCdeVaccId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiCdeVaccId(transactionManager, _mdiCdeVaccId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_MDI_CDE_VACC key.
		///		fkMdiStudVaccMdiCdeVacc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByMdiCdeVaccId(System.Decimal _mdiCdeVaccId, int start, int pageLength)
		{
			int count =  -1;
			return GetByMdiCdeVaccId(null, _mdiCdeVaccId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_MDI_CDE_VACC key.
		///		fkMdiStudVaccMdiCdeVacc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public TList<MdiStudVacc> GetByMdiCdeVaccId(System.Decimal _mdiCdeVaccId, int start, int pageLength,out int count)
		{
			return GetByMdiCdeVaccId(null, _mdiCdeVaccId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_MDI_STUD_VACC_MDI_CDE_VACC key.
		///		FK_MDI_STUD_VACC_MDI_CDE_VACC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.MdiStudVacc objects.</returns>
		public abstract TList<MdiStudVacc> GetByMdiCdeVaccId(TransactionManager transactionManager, System.Decimal _mdiCdeVaccId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.MdiStudVacc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudVaccKey key, int start, int pageLength)
		{
			return GetByMdiStudVaccId(transactionManager, key.MdiStudVaccId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByMdiStudVaccId(System.Decimal _mdiStudVaccId)
		{
			int count = -1;
			return GetByMdiStudVaccId(null,_mdiStudVaccId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByMdiStudVaccId(System.Decimal _mdiStudVaccId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudVaccId(null, _mdiStudVaccId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByMdiStudVaccId(TransactionManager transactionManager, System.Decimal _mdiStudVaccId)
		{
			int count = -1;
			return GetByMdiStudVaccId(transactionManager, _mdiStudVaccId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByMdiStudVaccId(TransactionManager transactionManager, System.Decimal _mdiStudVaccId, int start, int pageLength)
		{
			int count = -1;
			return GetByMdiStudVaccId(transactionManager, _mdiStudVaccId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByMdiStudVaccId(System.Decimal _mdiStudVaccId, int start, int pageLength, out int count)
		{
			return GetByMdiStudVaccId(null, _mdiStudVaccId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mdiStudVaccId">مسلسل تطعيم الطالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudVacc GetByMdiStudVaccId(TransactionManager transactionManager, System.Decimal _mdiStudVaccId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="_vaccSerial">رقم الجرعة</param>
		/// <param name="_rptSerial"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(System.Decimal _edStudId, System.Decimal _mdiCdeVaccId, System.Decimal _vaccSerial, System.Decimal? _rptSerial)
		{
			int count = -1;
			return GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(null,_edStudId, _mdiCdeVaccId, _vaccSerial, _rptSerial, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="_vaccSerial">رقم الجرعة</param>
		/// <param name="_rptSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(System.Decimal _edStudId, System.Decimal _mdiCdeVaccId, System.Decimal _vaccSerial, System.Decimal? _rptSerial, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(null, _edStudId, _mdiCdeVaccId, _vaccSerial, _rptSerial, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="_vaccSerial">رقم الجرعة</param>
		/// <param name="_rptSerial"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _mdiCdeVaccId, System.Decimal _vaccSerial, System.Decimal? _rptSerial)
		{
			int count = -1;
			return GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(transactionManager, _edStudId, _mdiCdeVaccId, _vaccSerial, _rptSerial, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="_vaccSerial">رقم الجرعة</param>
		/// <param name="_rptSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _mdiCdeVaccId, System.Decimal _vaccSerial, System.Decimal? _rptSerial, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(transactionManager, _edStudId, _mdiCdeVaccId, _vaccSerial, _rptSerial, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="_vaccSerial">رقم الجرعة</param>
		/// <param name="_rptSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.MdiStudVacc GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(System.Decimal _edStudId, System.Decimal _mdiCdeVaccId, System.Decimal _vaccSerial, System.Decimal? _rptSerial, int start, int pageLength, out int count)
		{
			return GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(null, _edStudId, _mdiCdeVaccId, _vaccSerial, _rptSerial, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_MDI_STUD_VACC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">رقم الطالب</param>
		/// <param name="_mdiCdeVaccId">نوع التطعيم</param>
		/// <param name="_vaccSerial">رقم الجرعة</param>
		/// <param name="_rptSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.MdiStudVacc GetByEdStudIdMdiCdeVaccIdVaccSerialRptSerial(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _mdiCdeVaccId, System.Decimal _vaccSerial, System.Decimal? _rptSerial, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MdiStudVacc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MdiStudVacc&gt;"/></returns>
		public static TList<MdiStudVacc> Fill(IDataReader reader, TList<MdiStudVacc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.MdiStudVacc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MdiStudVacc")
					.Append("|").Append((System.Decimal)reader["MDI_STUD_VACC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<MdiStudVacc>(
					key.ToString(), // EntityTrackingKey
					"MdiStudVacc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.MdiStudVacc();
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
					c.MdiStudVaccId = (System.Decimal)reader["MDI_STUD_VACC_ID"];
					c.OriginalMdiStudVaccId = c.MdiStudVaccId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.RptSerial = Convert.IsDBNull(reader["RPT_SERIAL"]) ? null : (System.Decimal?)reader["RPT_SERIAL"];
					c.MdiCdeVaccId = (System.Decimal)reader["MDI_CDE_VACC_ID"];
					c.VaccDate = (System.DateTime)reader["VACC_DATE"];
					c.RevaccDate = Convert.IsDBNull(reader["REVACC_DATE"]) ? null : (System.DateTime?)reader["REVACC_DATE"];
					c.VaccSerial = (System.Decimal)reader["VACC_SERIAL"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.MdiStudVacc entity)
		{
			if (!reader.Read()) return;
			
			entity.MdiStudVaccId = (System.Decimal)reader[((int)MdiStudVaccColumn.MdiStudVaccId - 1)];
			entity.OriginalMdiStudVaccId = (System.Decimal)reader["MDI_STUD_VACC_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)MdiStudVaccColumn.EdStudId - 1)];
			entity.RptSerial = (reader.IsDBNull(((int)MdiStudVaccColumn.RptSerial - 1)))?null:(System.Decimal?)reader[((int)MdiStudVaccColumn.RptSerial - 1)];
			entity.MdiCdeVaccId = (System.Decimal)reader[((int)MdiStudVaccColumn.MdiCdeVaccId - 1)];
			entity.VaccDate = (System.DateTime)reader[((int)MdiStudVaccColumn.VaccDate - 1)];
			entity.RevaccDate = (reader.IsDBNull(((int)MdiStudVaccColumn.RevaccDate - 1)))?null:(System.DateTime?)reader[((int)MdiStudVaccColumn.RevaccDate - 1)];
			entity.VaccSerial = (System.Decimal)reader[((int)MdiStudVaccColumn.VaccSerial - 1)];
			entity.Notes = (reader.IsDBNull(((int)MdiStudVaccColumn.Notes - 1)))?null:(System.String)reader[((int)MdiStudVaccColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.MdiStudVacc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MdiStudVaccId = (System.Decimal)dataRow["MDI_STUD_VACC_ID"];
			entity.OriginalMdiStudVaccId = (System.Decimal)dataRow["MDI_STUD_VACC_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.RptSerial = Convert.IsDBNull(dataRow["RPT_SERIAL"]) ? null : (System.Decimal?)dataRow["RPT_SERIAL"];
			entity.MdiCdeVaccId = (System.Decimal)dataRow["MDI_CDE_VACC_ID"];
			entity.VaccDate = (System.DateTime)dataRow["VACC_DATE"];
			entity.RevaccDate = Convert.IsDBNull(dataRow["REVACC_DATE"]) ? null : (System.DateTime?)dataRow["REVACC_DATE"];
			entity.VaccSerial = (System.Decimal)dataRow["VACC_SERIAL"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.MdiStudVacc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudVacc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudVacc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
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

			#region MdiCdeVaccIdSource	
			if (CanDeepLoad(entity, "MdiCdeVacc|MdiCdeVaccIdSource", deepLoadType, innerList) 
				&& entity.MdiCdeVaccIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.MdiCdeVaccId;
				MdiCdeVacc tmpEntity = EntityManager.LocateEntity<MdiCdeVacc>(EntityLocator.ConstructKeyFromPkItems(typeof(MdiCdeVacc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.MdiCdeVaccIdSource = tmpEntity;
				else
					entity.MdiCdeVaccIdSource = DataRepository.MdiCdeVaccProvider.GetByMdiCdeVaccId(transactionManager, entity.MdiCdeVaccId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiCdeVaccIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.MdiCdeVaccIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MdiCdeVaccProvider.DeepLoad(transactionManager, entity.MdiCdeVaccIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion MdiCdeVaccIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.MdiStudVacc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.MdiStudVacc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.MdiStudVacc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.MdiStudVacc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region MdiCdeVaccIdSource
			if (CanDeepSave(entity, "MdiCdeVacc|MdiCdeVaccIdSource", deepSaveType, innerList) 
				&& entity.MdiCdeVaccIdSource != null)
			{
				DataRepository.MdiCdeVaccProvider.Save(transactionManager, entity.MdiCdeVaccIdSource);
				entity.MdiCdeVaccId = entity.MdiCdeVaccIdSource.MdiCdeVaccId;
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
	
	#region MdiStudVaccChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.MdiStudVacc</c>
	///</summary>
	public enum MdiStudVaccChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>MdiCdeVacc</c> at MdiCdeVaccIdSource
		///</summary>
		[ChildEntityType(typeof(MdiCdeVacc))]
		MdiCdeVacc,
	}
	
	#endregion MdiStudVaccChildEntityTypes
	
	#region MdiStudVaccFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MdiStudVaccColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudVacc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudVaccFilterBuilder : SqlFilterBuilder<MdiStudVaccColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudVaccFilterBuilder class.
		/// </summary>
		public MdiStudVaccFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudVaccFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudVaccFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudVaccFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudVaccFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudVaccFilterBuilder
	
	#region MdiStudVaccParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MdiStudVaccColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudVacc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MdiStudVaccParameterBuilder : ParameterizedSqlFilterBuilder<MdiStudVaccColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudVaccParameterBuilder class.
		/// </summary>
		public MdiStudVaccParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MdiStudVaccParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MdiStudVaccParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MdiStudVaccParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MdiStudVaccParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MdiStudVaccParameterBuilder
	
	#region MdiStudVaccSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MdiStudVaccColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MdiStudVacc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MdiStudVaccSortBuilder : SqlSortBuilder<MdiStudVaccColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MdiStudVaccSqlSortBuilder class.
		/// </summary>
		public MdiStudVaccSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MdiStudVaccSortBuilder
	
} // end namespace
