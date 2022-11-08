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
	/// This class is the base class for any <see cref="SeFormControlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeFormControlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeFormControl, UMIS_VER2.BusinessLyer.SeFormControlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeFormControlKey key)
		{
			return Delete(transactionManager, key.SeFormControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seFormControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seFormControlId)
		{
			return Delete(null, _seFormControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seFormControlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.SeFormControl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeFormControlKey key, int start, int pageLength)
		{
			return GetBySeFormControlId(transactionManager, key.SeFormControlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_CONTROL_BIZ_TYPE__1 index.
		/// </summary>
		/// <param name="_seControlBizTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlBizTypeId(System.Decimal _seControlBizTypeId)
		{
			int count = -1;
			return GetBySeControlBizTypeId(null,_seControlBizTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_BIZ_TYPE__1 index.
		/// </summary>
		/// <param name="_seControlBizTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlBizTypeId(System.Decimal _seControlBizTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlBizTypeId(null, _seControlBizTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_BIZ_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlBizTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlBizTypeId(TransactionManager transactionManager, System.Decimal _seControlBizTypeId)
		{
			int count = -1;
			return GetBySeControlBizTypeId(transactionManager, _seControlBizTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_BIZ_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlBizTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlBizTypeId(TransactionManager transactionManager, System.Decimal _seControlBizTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlBizTypeId(transactionManager, _seControlBizTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_BIZ_TYPE__1 index.
		/// </summary>
		/// <param name="_seControlBizTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlBizTypeId(System.Decimal _seControlBizTypeId, int start, int pageLength, out int count)
		{
			return GetBySeControlBizTypeId(null, _seControlBizTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_BIZ_TYPE__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlBizTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public abstract TList<SeFormControl> GetBySeControlBizTypeId(TransactionManager transactionManager, System.Decimal _seControlBizTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_CONTROL_DISABLE_W_1 index.
		/// </summary>
		/// <param name="_seControlDisableWayId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlDisableWayId(System.Decimal _seControlDisableWayId)
		{
			int count = -1;
			return GetBySeControlDisableWayId(null,_seControlDisableWayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_DISABLE_W_1 index.
		/// </summary>
		/// <param name="_seControlDisableWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlDisableWayId(System.Decimal _seControlDisableWayId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlDisableWayId(null, _seControlDisableWayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_DISABLE_W_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlDisableWayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlDisableWayId(TransactionManager transactionManager, System.Decimal _seControlDisableWayId)
		{
			int count = -1;
			return GetBySeControlDisableWayId(transactionManager, _seControlDisableWayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_DISABLE_W_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlDisableWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlDisableWayId(TransactionManager transactionManager, System.Decimal _seControlDisableWayId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlDisableWayId(transactionManager, _seControlDisableWayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_DISABLE_W_1 index.
		/// </summary>
		/// <param name="_seControlDisableWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlDisableWayId(System.Decimal _seControlDisableWayId, int start, int pageLength, out int count)
		{
			return GetBySeControlDisableWayId(null, _seControlDisableWayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_DISABLE_W_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlDisableWayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public abstract TList<SeFormControl> GetBySeControlDisableWayId(TransactionManager transactionManager, System.Decimal _seControlDisableWayId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_CONTROL_TECH_TYPE_1 index.
		/// </summary>
		/// <param name="_seControlTechTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId)
		{
			int count = -1;
			return GetBySeControlTechTypeId(null,_seControlTechTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_TECH_TYPE_1 index.
		/// </summary>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlTechTypeId(null, _seControlTechTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_TECH_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId)
		{
			int count = -1;
			return GetBySeControlTechTypeId(transactionManager, _seControlTechTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_TECH_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeControlTechTypeId(transactionManager, _seControlTechTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_TECH_TYPE_1 index.
		/// </summary>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeControlTechTypeId(System.Decimal _seControlTechTypeId, int start, int pageLength, out int count)
		{
			return GetBySeControlTechTypeId(null, _seControlTechTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_CONTROL_TECH_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seControlTechTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public abstract TList<SeFormControl> GetBySeControlTechTypeId(TransactionManager transactionManager, System.Decimal _seControlTechTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeFormId(System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(null,_seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormId(transactionManager, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public TList<SeFormControl> GetBySeFormId(System.Decimal _seFormId, int start, int pageLength, out int count)
		{
			return GetBySeFormId(null, _seFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SE_FORM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SeFormControl&gt;"/> class.</returns>
		public abstract TList<SeFormControl> GetBySeFormId(TransactionManager transactionManager, System.Decimal _seFormId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_FORM_CONTROL index.
		/// </summary>
		/// <param name="_seFormControlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetBySeFormControlId(System.Decimal _seFormControlId)
		{
			int count = -1;
			return GetBySeFormControlId(null,_seFormControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM_CONTROL index.
		/// </summary>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetBySeFormControlId(System.Decimal _seFormControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormControlId(null, _seFormControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId)
		{
			int count = -1;
			return GetBySeFormControlId(transactionManager, _seFormControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeFormControlId(transactionManager, _seFormControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM_CONTROL index.
		/// </summary>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetBySeFormControlId(System.Decimal _seFormControlId, int start, int pageLength, out int count)
		{
			return GetBySeFormControlId(null, _seFormControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_FORM_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seFormControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeFormControl GetBySeFormControlId(TransactionManager transactionManager, System.Decimal _seFormControlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SE_FORM_CONTROL_CODE index.
		/// </summary>
		/// <param name="_codeName"></param>
		/// <param name="_seFormId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetByCodeNameSeFormId(System.String _codeName, System.Decimal _seFormId)
		{
			int count = -1;
			return GetByCodeNameSeFormId(null,_codeName, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_FORM_CONTROL_CODE index.
		/// </summary>
		/// <param name="_codeName"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetByCodeNameSeFormId(System.String _codeName, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetByCodeNameSeFormId(null, _codeName, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_FORM_CONTROL_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_codeName"></param>
		/// <param name="_seFormId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetByCodeNameSeFormId(TransactionManager transactionManager, System.String _codeName, System.Decimal _seFormId)
		{
			int count = -1;
			return GetByCodeNameSeFormId(transactionManager, _codeName, _seFormId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_FORM_CONTROL_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_codeName"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetByCodeNameSeFormId(TransactionManager transactionManager, System.String _codeName, System.Decimal _seFormId, int start, int pageLength)
		{
			int count = -1;
			return GetByCodeNameSeFormId(transactionManager, _codeName, _seFormId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_FORM_CONTROL_CODE index.
		/// </summary>
		/// <param name="_codeName"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeFormControl GetByCodeNameSeFormId(System.String _codeName, System.Decimal _seFormId, int start, int pageLength, out int count)
		{
			return GetByCodeNameSeFormId(null, _codeName, _seFormId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SE_FORM_CONTROL_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_codeName"></param>
		/// <param name="_seFormId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeFormControl GetByCodeNameSeFormId(TransactionManager transactionManager, System.String _codeName, System.Decimal _seFormId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeFormControl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeFormControl&gt;"/></returns>
		public static TList<SeFormControl> Fill(IDataReader reader, TList<SeFormControl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeFormControl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeFormControl")
					.Append("|").Append((System.Decimal)reader["SE_FORM_CONTROL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeFormControl>(
					key.ToString(), // EntityTrackingKey
					"SeFormControl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeFormControl();
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
					c.SeFormControlId = (System.Decimal)reader["SE_FORM_CONTROL_ID"];
					c.OriginalSeFormControlId = c.SeFormControlId;
					c.CodeName = (System.String)reader["CODE_NAME"];
					c.DescAr = (System.String)reader["DESC_AR"];
					c.SeFormId = (System.Decimal)reader["SE_FORM_ID"];
					c.SeControlTechTypeId = (System.Decimal)reader["SE_CONTROL_TECH_TYPE_ID"];
					c.SeControlBizTypeId = (System.Decimal)reader["SE_CONTROL_BIZ_TYPE_ID"];
					c.SeControlDisableWayId = (System.Decimal)reader["SE_CONTROL_DISABLE_WAY_ID"];
					c.DescEn = Convert.IsDBNull(reader["DESC_EN"]) ? null : (System.String)reader["DESC_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeFormControl entity)
		{
			if (!reader.Read()) return;
			
			entity.SeFormControlId = (System.Decimal)reader[((int)SeFormControlColumn.SeFormControlId - 1)];
			entity.OriginalSeFormControlId = (System.Decimal)reader["SE_FORM_CONTROL_ID"];
			entity.CodeName = (System.String)reader[((int)SeFormControlColumn.CodeName - 1)];
			entity.DescAr = (System.String)reader[((int)SeFormControlColumn.DescAr - 1)];
			entity.SeFormId = (System.Decimal)reader[((int)SeFormControlColumn.SeFormId - 1)];
			entity.SeControlTechTypeId = (System.Decimal)reader[((int)SeFormControlColumn.SeControlTechTypeId - 1)];
			entity.SeControlBizTypeId = (System.Decimal)reader[((int)SeFormControlColumn.SeControlBizTypeId - 1)];
			entity.SeControlDisableWayId = (System.Decimal)reader[((int)SeFormControlColumn.SeControlDisableWayId - 1)];
			entity.DescEn = (reader.IsDBNull(((int)SeFormControlColumn.DescEn - 1)))?null:(System.String)reader[((int)SeFormControlColumn.DescEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeFormControl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeFormControlId = (System.Decimal)dataRow["SE_FORM_CONTROL_ID"];
			entity.OriginalSeFormControlId = (System.Decimal)dataRow["SE_FORM_CONTROL_ID"];
			entity.CodeName = (System.String)dataRow["CODE_NAME"];
			entity.DescAr = (System.String)dataRow["DESC_AR"];
			entity.SeFormId = (System.Decimal)dataRow["SE_FORM_ID"];
			entity.SeControlTechTypeId = (System.Decimal)dataRow["SE_CONTROL_TECH_TYPE_ID"];
			entity.SeControlBizTypeId = (System.Decimal)dataRow["SE_CONTROL_BIZ_TYPE_ID"];
			entity.SeControlDisableWayId = (System.Decimal)dataRow["SE_CONTROL_DISABLE_WAY_ID"];
			entity.DescEn = Convert.IsDBNull(dataRow["DESC_EN"]) ? null : (System.String)dataRow["DESC_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeFormControl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeFormControl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeFormControl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeControlBizTypeIdSource	
			if (CanDeepLoad(entity, "SeControlBizType|SeControlBizTypeIdSource", deepLoadType, innerList) 
				&& entity.SeControlBizTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeControlBizTypeId;
				SeControlBizType tmpEntity = EntityManager.LocateEntity<SeControlBizType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeControlBizType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeControlBizTypeIdSource = tmpEntity;
				else
					entity.SeControlBizTypeIdSource = DataRepository.SeControlBizTypeProvider.GetBySeControlBizTypeId(transactionManager, entity.SeControlBizTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeControlBizTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeControlBizTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeControlBizTypeProvider.DeepLoad(transactionManager, entity.SeControlBizTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeControlBizTypeIdSource

			#region SeFormIdSource	
			if (CanDeepLoad(entity, "SeForm|SeFormIdSource", deepLoadType, innerList) 
				&& entity.SeFormIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeFormId;
				SeForm tmpEntity = EntityManager.LocateEntity<SeForm>(EntityLocator.ConstructKeyFromPkItems(typeof(SeForm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeFormIdSource = tmpEntity;
				else
					entity.SeFormIdSource = DataRepository.SeFormProvider.GetBySeFormId(transactionManager, entity.SeFormId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeFormIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeFormProvider.DeepLoad(transactionManager, entity.SeFormIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeFormIdSource

			#region SeControlTechTypeIdSource	
			if (CanDeepLoad(entity, "SeControlTechType|SeControlTechTypeIdSource", deepLoadType, innerList) 
				&& entity.SeControlTechTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeControlTechTypeId;
				SeControlTechType tmpEntity = EntityManager.LocateEntity<SeControlTechType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeControlTechType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeControlTechTypeIdSource = tmpEntity;
				else
					entity.SeControlTechTypeIdSource = DataRepository.SeControlTechTypeProvider.GetBySeControlTechTypeId(transactionManager, entity.SeControlTechTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeControlTechTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeControlTechTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeControlTechTypeProvider.DeepLoad(transactionManager, entity.SeControlTechTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeControlTechTypeIdSource

			#region SeControlDisableWayIdSource	
			if (CanDeepLoad(entity, "SeControlDisableWay|SeControlDisableWayIdSource", deepLoadType, innerList) 
				&& entity.SeControlDisableWayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SeControlDisableWayId;
				SeControlDisableWay tmpEntity = EntityManager.LocateEntity<SeControlDisableWay>(EntityLocator.ConstructKeyFromPkItems(typeof(SeControlDisableWay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeControlDisableWayIdSource = tmpEntity;
				else
					entity.SeControlDisableWayIdSource = DataRepository.SeControlDisableWayProvider.GetBySeControlDisableWayId(transactionManager, entity.SeControlDisableWayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeControlDisableWayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeControlDisableWayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeControlDisableWayProvider.DeepLoad(transactionManager, entity.SeControlDisableWayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeControlDisableWayIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeFormControlId methods when available
			
			#region SeApplicationLogCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeApplicationLog>|SeApplicationLogCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeApplicationLogCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeApplicationLogCollection = DataRepository.SeApplicationLogProvider.GetBySeFormControlId(transactionManager, entity.SeFormControlId);

				if (deep && entity.SeApplicationLogCollection.Count > 0)
				{
					deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeApplicationLog>) DataRepository.SeApplicationLogProvider.DeepLoad,
						new object[] { transactionManager, entity.SeApplicationLogCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SeUserAccntControlDiffCollection = DataRepository.SeUserAccntControlDiffProvider.GetBySeFormControlId(transactionManager, entity.SeFormControlId);

				if (deep && entity.SeUserAccntControlDiffCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntControlDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccntControlDiff>) DataRepository.SeUserAccntControlDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntControlDiffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeAccntControlDiffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeAccntControlDiff>|SeAccntControlDiffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeAccntControlDiffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeAccntControlDiffCollection = DataRepository.SeAccntControlDiffProvider.GetBySeFormControlId(transactionManager, entity.SeFormControlId);

				if (deep && entity.SeAccntControlDiffCollection.Count > 0)
				{
					deepHandles.Add("SeAccntControlDiffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeAccntControlDiff>) DataRepository.SeAccntControlDiffProvider.DeepLoad,
						new object[] { transactionManager, entity.SeAccntControlDiffCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeFormControl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeFormControl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeFormControl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeFormControl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeControlBizTypeIdSource
			if (CanDeepSave(entity, "SeControlBizType|SeControlBizTypeIdSource", deepSaveType, innerList) 
				&& entity.SeControlBizTypeIdSource != null)
			{
				DataRepository.SeControlBizTypeProvider.Save(transactionManager, entity.SeControlBizTypeIdSource);
				entity.SeControlBizTypeId = entity.SeControlBizTypeIdSource.SeControlBizTypeId;
			}
			#endregion 
			
			#region SeFormIdSource
			if (CanDeepSave(entity, "SeForm|SeFormIdSource", deepSaveType, innerList) 
				&& entity.SeFormIdSource != null)
			{
				DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormIdSource);
				entity.SeFormId = entity.SeFormIdSource.SeFormId;
			}
			#endregion 
			
			#region SeControlTechTypeIdSource
			if (CanDeepSave(entity, "SeControlTechType|SeControlTechTypeIdSource", deepSaveType, innerList) 
				&& entity.SeControlTechTypeIdSource != null)
			{
				DataRepository.SeControlTechTypeProvider.Save(transactionManager, entity.SeControlTechTypeIdSource);
				entity.SeControlTechTypeId = entity.SeControlTechTypeIdSource.SeControlTechTypeId;
			}
			#endregion 
			
			#region SeControlDisableWayIdSource
			if (CanDeepSave(entity, "SeControlDisableWay|SeControlDisableWayIdSource", deepSaveType, innerList) 
				&& entity.SeControlDisableWayIdSource != null)
			{
				DataRepository.SeControlDisableWayProvider.Save(transactionManager, entity.SeControlDisableWayIdSource);
				entity.SeControlDisableWayId = entity.SeControlDisableWayIdSource.SeControlDisableWayId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SeApplicationLog>
				if (CanDeepSave(entity.SeApplicationLogCollection, "List<SeApplicationLog>|SeApplicationLogCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeApplicationLog child in entity.SeApplicationLogCollection)
					{
						if(child.SeFormControlIdSource != null)
						{
							child.SeFormControlId = child.SeFormControlIdSource.SeFormControlId;
						}
						else
						{
							child.SeFormControlId = entity.SeFormControlId;
						}

					}

					if (entity.SeApplicationLogCollection.Count > 0 || entity.SeApplicationLogCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeApplicationLogProvider.Save(transactionManager, entity.SeApplicationLogCollection);
						
						deepHandles.Add("SeApplicationLogCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeApplicationLog >) DataRepository.SeApplicationLogProvider.DeepSave,
							new object[] { transactionManager, entity.SeApplicationLogCollection, deepSaveType, childTypes, innerList }
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
						if(child.SeFormControlIdSource != null)
						{
							child.SeFormControlId = child.SeFormControlIdSource.SeFormControlId;
						}
						else
						{
							child.SeFormControlId = entity.SeFormControlId;
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
				
	
			#region List<SeAccntControlDiff>
				if (CanDeepSave(entity.SeAccntControlDiffCollection, "List<SeAccntControlDiff>|SeAccntControlDiffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeAccntControlDiff child in entity.SeAccntControlDiffCollection)
					{
						if(child.SeFormControlIdSource != null)
						{
							child.SeFormControlId = child.SeFormControlIdSource.SeFormControlId;
						}
						else
						{
							child.SeFormControlId = entity.SeFormControlId;
						}

					}

					if (entity.SeAccntControlDiffCollection.Count > 0 || entity.SeAccntControlDiffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeAccntControlDiffProvider.Save(transactionManager, entity.SeAccntControlDiffCollection);
						
						deepHandles.Add("SeAccntControlDiffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeAccntControlDiff >) DataRepository.SeAccntControlDiffProvider.DeepSave,
							new object[] { transactionManager, entity.SeAccntControlDiffCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeFormControlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeFormControl</c>
	///</summary>
	public enum SeFormControlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeControlBizType</c> at SeControlBizTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeControlBizType))]
		SeControlBizType,
		
		///<summary>
		/// Composite Property for <c>SeForm</c> at SeFormIdSource
		///</summary>
		[ChildEntityType(typeof(SeForm))]
		SeForm,
		
		///<summary>
		/// Composite Property for <c>SeControlTechType</c> at SeControlTechTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeControlTechType))]
		SeControlTechType,
		
		///<summary>
		/// Composite Property for <c>SeControlDisableWay</c> at SeControlDisableWayIdSource
		///</summary>
		[ChildEntityType(typeof(SeControlDisableWay))]
		SeControlDisableWay,
		///<summary>
		/// Collection of <c>SeFormControl</c> as OneToMany for SeApplicationLogCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeApplicationLog>))]
		SeApplicationLogCollection,
		///<summary>
		/// Collection of <c>SeFormControl</c> as OneToMany for SeUserAccntControlDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccntControlDiff>))]
		SeUserAccntControlDiffCollection,
		///<summary>
		/// Collection of <c>SeFormControl</c> as OneToMany for SeAccntControlDiffCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeAccntControlDiff>))]
		SeAccntControlDiffCollection,
	}
	
	#endregion SeFormControlChildEntityTypes
	
	#region SeFormControlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeFormControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeFormControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeFormControlFilterBuilder : SqlFilterBuilder<SeFormControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeFormControlFilterBuilder class.
		/// </summary>
		public SeFormControlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeFormControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeFormControlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeFormControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeFormControlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeFormControlFilterBuilder
	
	#region SeFormControlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeFormControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeFormControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeFormControlParameterBuilder : ParameterizedSqlFilterBuilder<SeFormControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeFormControlParameterBuilder class.
		/// </summary>
		public SeFormControlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeFormControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeFormControlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeFormControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeFormControlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeFormControlParameterBuilder
	
	#region SeFormControlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeFormControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeFormControl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeFormControlSortBuilder : SqlSortBuilder<SeFormControlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeFormControlSqlSortBuilder class.
		/// </summary>
		public SeFormControlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeFormControlSortBuilder
	
} // end namespace
