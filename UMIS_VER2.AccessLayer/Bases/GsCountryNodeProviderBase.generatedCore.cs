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
	/// This class is the base class for any <see cref="GsCountryNodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCountryNodeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCountryNode, UMIS_VER2.BusinessLyer.GsCountryNodeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCountryNodeKey key)
		{
			return Delete(transactionManager, key.GsCountryNodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCountryNodeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCountryNodeId)
		{
			return Delete(null, _gsCountryNodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCountryNodeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND key.
		///		FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="_admAdmissionBandId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(_admAdmissionBandId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND key.
		///		FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		/// <remarks></remarks>
		public TList<GsCountryNode> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND key.
		///		FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND key.
		///		fkGsCountryNodeAdmAdmissionBand Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND key.
		///		fkGsCountryNodeAdmAdmissionBand Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId, int start, int pageLength,out int count)
		{
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND key.
		///		FK_GS_COUNTRY_NODE_ADM_ADMISSION_BAND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public abstract TList<GsCountryNode> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE Description: 
		/// </summary>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCNodeNatureId(System.Decimal _gsCodeCNodeNatureId)
		{
			int count = -1;
			return GetByGsCodeCNodeNatureId(_gsCodeCNodeNatureId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		/// <remarks></remarks>
		public TList<GsCountryNode> GetByGsCodeCNodeNatureId(TransactionManager transactionManager, System.Decimal _gsCodeCNodeNatureId)
		{
			int count = -1;
			return GetByGsCodeCNodeNatureId(transactionManager, _gsCodeCNodeNatureId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCNodeNatureId(TransactionManager transactionManager, System.Decimal _gsCodeCNodeNatureId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCNodeNatureId(transactionManager, _gsCodeCNodeNatureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE key.
		///		fkGsCountryNodeGsCodeCNodeNature Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCNodeNatureId(System.Decimal _gsCodeCNodeNatureId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCNodeNatureId(null, _gsCodeCNodeNatureId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE key.
		///		fkGsCountryNodeGsCodeCNodeNature Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCNodeNatureId(System.Decimal _gsCodeCNodeNatureId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCNodeNatureId(null, _gsCodeCNodeNatureId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_C_NODE_NATURE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCNodeNatureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public abstract TList<GsCountryNode> GetByGsCodeCNodeNatureId(TransactionManager transactionManager, System.Decimal _gsCodeCNodeNatureId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId">عملة دفع المصروفات الاساسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">عملة دفع المصروفات الاساسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		/// <remarks></remarks>
		public TList<GsCountryNode> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">عملة دفع المصروفات الاساسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY key.
		///		fkGsCountryNodeGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">عملة دفع المصروفات الاساسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY key.
		///		fkGsCountryNodeGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">عملة دفع المصروفات الاساسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public TList<GsCountryNode> GetByGsCodeCurrencyId(System.Decimal? _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY key.
		///		FK_GS_COUNTRY_NODE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">عملة دفع المصروفات الاساسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCountryNode objects.</returns>
		public abstract TList<GsCountryNode> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal? _gsCodeCurrencyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCountryNode Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCountryNodeKey key, int start, int pageLength)
		{
			return GetByGsCountryNodeId(transactionManager, key.GsCountryNodeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_NODE_PARENT_ID_1 index.
		/// </summary>
		/// <param name="_nodeParentId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCountryNode&gt;"/> class.</returns>
		public TList<GsCountryNode> GetByNodeParentId(System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeParentId(null,_nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NODE_PARENT_ID_1 index.
		/// </summary>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCountryNode&gt;"/> class.</returns>
		public TList<GsCountryNode> GetByNodeParentId(System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeParentId(null, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NODE_PARENT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeParentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCountryNode&gt;"/> class.</returns>
		public TList<GsCountryNode> GetByNodeParentId(TransactionManager transactionManager, System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeParentId(transactionManager, _nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NODE_PARENT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCountryNode&gt;"/> class.</returns>
		public TList<GsCountryNode> GetByNodeParentId(TransactionManager transactionManager, System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeParentId(transactionManager, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NODE_PARENT_ID_1 index.
		/// </summary>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCountryNode&gt;"/> class.</returns>
		public TList<GsCountryNode> GetByNodeParentId(System.Decimal _nodeParentId, int start, int pageLength, out int count)
		{
			return GetByNodeParentId(null, _nodeParentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_NODE_PARENT_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCountryNode&gt;"/> class.</returns>
		public abstract TList<GsCountryNode> GetByNodeParentId(TransactionManager transactionManager, System.Decimal _nodeParentId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_COUNTRY_NODE_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(null,_gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COUNTRY_NODE_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COUNTRY_NODE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COUNTRY_NODE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COUNTRY_NODE_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength, out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_COUNTRY_NODE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCountryNode GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_COUNTRY_NODE_AR index.
		/// </summary>
		/// <param name="_nodeDescrAr"></param>
		/// <param name="_nodeParentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrArNodeParentId(System.String _nodeDescrAr, System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeDescrArNodeParentId(null,_nodeDescrAr, _nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_AR index.
		/// </summary>
		/// <param name="_nodeDescrAr"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrArNodeParentId(System.String _nodeDescrAr, System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeDescrArNodeParentId(null, _nodeDescrAr, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeDescrAr"></param>
		/// <param name="_nodeParentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrArNodeParentId(TransactionManager transactionManager, System.String _nodeDescrAr, System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeDescrArNodeParentId(transactionManager, _nodeDescrAr, _nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeDescrAr"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrArNodeParentId(TransactionManager transactionManager, System.String _nodeDescrAr, System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeDescrArNodeParentId(transactionManager, _nodeDescrAr, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_AR index.
		/// </summary>
		/// <param name="_nodeDescrAr"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrArNodeParentId(System.String _nodeDescrAr, System.Decimal _nodeParentId, int start, int pageLength, out int count)
		{
			return GetByNodeDescrArNodeParentId(null, _nodeDescrAr, _nodeParentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeDescrAr"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrArNodeParentId(TransactionManager transactionManager, System.String _nodeDescrAr, System.Decimal _nodeParentId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_COUNTRY_NODE_CODE index.
		/// </summary>
		/// <param name="_nodeCode"></param>
		/// <param name="_nodeParentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeCodeNodeParentId(System.String _nodeCode, System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeCodeNodeParentId(null,_nodeCode, _nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_CODE index.
		/// </summary>
		/// <param name="_nodeCode"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeCodeNodeParentId(System.String _nodeCode, System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeCodeNodeParentId(null, _nodeCode, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeCode"></param>
		/// <param name="_nodeParentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeCodeNodeParentId(TransactionManager transactionManager, System.String _nodeCode, System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeCodeNodeParentId(transactionManager, _nodeCode, _nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeCode"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeCodeNodeParentId(TransactionManager transactionManager, System.String _nodeCode, System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeCodeNodeParentId(transactionManager, _nodeCode, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_CODE index.
		/// </summary>
		/// <param name="_nodeCode"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeCodeNodeParentId(System.String _nodeCode, System.Decimal _nodeParentId, int start, int pageLength, out int count)
		{
			return GetByNodeCodeNodeParentId(null, _nodeCode, _nodeParentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_CODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeCode"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeCodeNodeParentId(TransactionManager transactionManager, System.String _nodeCode, System.Decimal _nodeParentId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_COUNTRY_NODE_EN index.
		/// </summary>
		/// <param name="_nodeDescrEn"></param>
		/// <param name="_nodeParentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrEnNodeParentId(System.String _nodeDescrEn, System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeDescrEnNodeParentId(null,_nodeDescrEn, _nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_EN index.
		/// </summary>
		/// <param name="_nodeDescrEn"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrEnNodeParentId(System.String _nodeDescrEn, System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeDescrEnNodeParentId(null, _nodeDescrEn, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeDescrEn"></param>
		/// <param name="_nodeParentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrEnNodeParentId(TransactionManager transactionManager, System.String _nodeDescrEn, System.Decimal _nodeParentId)
		{
			int count = -1;
			return GetByNodeDescrEnNodeParentId(transactionManager, _nodeDescrEn, _nodeParentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeDescrEn"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrEnNodeParentId(TransactionManager transactionManager, System.String _nodeDescrEn, System.Decimal _nodeParentId, int start, int pageLength)
		{
			int count = -1;
			return GetByNodeDescrEnNodeParentId(transactionManager, _nodeDescrEn, _nodeParentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_EN index.
		/// </summary>
		/// <param name="_nodeDescrEn"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrEnNodeParentId(System.String _nodeDescrEn, System.Decimal _nodeParentId, int start, int pageLength, out int count)
		{
			return GetByNodeDescrEnNodeParentId(null, _nodeDescrEn, _nodeParentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_COUNTRY_NODE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_nodeDescrEn"></param>
		/// <param name="_nodeParentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCountryNode GetByNodeDescrEnNodeParentId(TransactionManager transactionManager, System.String _nodeDescrEn, System.Decimal _nodeParentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCountryNode&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCountryNode&gt;"/></returns>
		public static TList<GsCountryNode> Fill(IDataReader reader, TList<GsCountryNode> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCountryNode c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCountryNode")
					.Append("|").Append((System.Decimal)reader["GS_COUNTRY_NODE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCountryNode>(
					key.ToString(), // EntityTrackingKey
					"GsCountryNode",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCountryNode();
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
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.OriginalGsCountryNodeId = c.GsCountryNodeId;
					c.NodeDescrAr = (System.String)reader["NODE_DESCR_AR"];
					c.NodeDescrEn = Convert.IsDBNull(reader["NODE_DESCR_EN"]) ? null : (System.String)reader["NODE_DESCR_EN"];
					c.NodePath = (System.String)reader["NODE_PATH"];
					c.NodeOrder = (System.Decimal)reader["NODE_ORDER"];
					c.NodeParentId = (System.Decimal)reader["NODE_PARENT_ID"];
					c.NodeLevel = (System.Decimal)reader["NODE_LEVEL"];
					c.NodeCode = Convert.IsDBNull(reader["NODE_CODE"]) ? null : (System.String)reader["NODE_CODE"];
					c.NodeChildCount = (System.Decimal)reader["NODE_CHILD_COUNT"];
					c.GsCodeCNodeNatureId = (System.Decimal)reader["GS_CODE_C_NODE_NATURE_ID"];
					c.IsNodeLocal = (System.Decimal)reader["IS_NODE_LOCAL"];
					c.IsNodeVisible = (System.Decimal)reader["IS_NODE_VISIBLE"];
					c.GccFlg = Convert.IsDBNull(reader["GCC_FLG"]) ? null : (System.Decimal?)reader["GCC_FLG"];
					c.NationCode = Convert.IsDBNull(reader["NATION_CODE"]) ? null : (System.String)reader["NATION_CODE"];
					c.NationDescrAr = Convert.IsDBNull(reader["NATION_DESCR_AR"]) ? null : (System.String)reader["NATION_DESCR_AR"];
					c.NationDescrEn = Convert.IsDBNull(reader["NATION_DESCR_EN"]) ? null : (System.String)reader["NATION_DESCR_EN"];
					c.GsCodeCurrencyId = Convert.IsDBNull(reader["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)reader["GS_CODE_CURRENCY_ID"];
					c.AdmAdmissionBandId = Convert.IsDBNull(reader["ADM_ADMISSION_BAND_ID"]) ? null : (System.Decimal?)reader["ADM_ADMISSION_BAND_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCountryNode entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCountryNodeId = (System.Decimal)reader[((int)GsCountryNodeColumn.GsCountryNodeId - 1)];
			entity.OriginalGsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
			entity.NodeDescrAr = (System.String)reader[((int)GsCountryNodeColumn.NodeDescrAr - 1)];
			entity.NodeDescrEn = (reader.IsDBNull(((int)GsCountryNodeColumn.NodeDescrEn - 1)))?null:(System.String)reader[((int)GsCountryNodeColumn.NodeDescrEn - 1)];
			entity.NodePath = (System.String)reader[((int)GsCountryNodeColumn.NodePath - 1)];
			entity.NodeOrder = (System.Decimal)reader[((int)GsCountryNodeColumn.NodeOrder - 1)];
			entity.NodeParentId = (System.Decimal)reader[((int)GsCountryNodeColumn.NodeParentId - 1)];
			entity.NodeLevel = (System.Decimal)reader[((int)GsCountryNodeColumn.NodeLevel - 1)];
			entity.NodeCode = (reader.IsDBNull(((int)GsCountryNodeColumn.NodeCode - 1)))?null:(System.String)reader[((int)GsCountryNodeColumn.NodeCode - 1)];
			entity.NodeChildCount = (System.Decimal)reader[((int)GsCountryNodeColumn.NodeChildCount - 1)];
			entity.GsCodeCNodeNatureId = (System.Decimal)reader[((int)GsCountryNodeColumn.GsCodeCNodeNatureId - 1)];
			entity.IsNodeLocal = (System.Decimal)reader[((int)GsCountryNodeColumn.IsNodeLocal - 1)];
			entity.IsNodeVisible = (System.Decimal)reader[((int)GsCountryNodeColumn.IsNodeVisible - 1)];
			entity.GccFlg = (reader.IsDBNull(((int)GsCountryNodeColumn.GccFlg - 1)))?null:(System.Decimal?)reader[((int)GsCountryNodeColumn.GccFlg - 1)];
			entity.NationCode = (reader.IsDBNull(((int)GsCountryNodeColumn.NationCode - 1)))?null:(System.String)reader[((int)GsCountryNodeColumn.NationCode - 1)];
			entity.NationDescrAr = (reader.IsDBNull(((int)GsCountryNodeColumn.NationDescrAr - 1)))?null:(System.String)reader[((int)GsCountryNodeColumn.NationDescrAr - 1)];
			entity.NationDescrEn = (reader.IsDBNull(((int)GsCountryNodeColumn.NationDescrEn - 1)))?null:(System.String)reader[((int)GsCountryNodeColumn.NationDescrEn - 1)];
			entity.GsCodeCurrencyId = (reader.IsDBNull(((int)GsCountryNodeColumn.GsCodeCurrencyId - 1)))?null:(System.Decimal?)reader[((int)GsCountryNodeColumn.GsCodeCurrencyId - 1)];
			entity.AdmAdmissionBandId = (reader.IsDBNull(((int)GsCountryNodeColumn.AdmAdmissionBandId - 1)))?null:(System.Decimal?)reader[((int)GsCountryNodeColumn.AdmAdmissionBandId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCountryNode entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.OriginalGsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.NodeDescrAr = (System.String)dataRow["NODE_DESCR_AR"];
			entity.NodeDescrEn = Convert.IsDBNull(dataRow["NODE_DESCR_EN"]) ? null : (System.String)dataRow["NODE_DESCR_EN"];
			entity.NodePath = (System.String)dataRow["NODE_PATH"];
			entity.NodeOrder = (System.Decimal)dataRow["NODE_ORDER"];
			entity.NodeParentId = (System.Decimal)dataRow["NODE_PARENT_ID"];
			entity.NodeLevel = (System.Decimal)dataRow["NODE_LEVEL"];
			entity.NodeCode = Convert.IsDBNull(dataRow["NODE_CODE"]) ? null : (System.String)dataRow["NODE_CODE"];
			entity.NodeChildCount = (System.Decimal)dataRow["NODE_CHILD_COUNT"];
			entity.GsCodeCNodeNatureId = (System.Decimal)dataRow["GS_CODE_C_NODE_NATURE_ID"];
			entity.IsNodeLocal = (System.Decimal)dataRow["IS_NODE_LOCAL"];
			entity.IsNodeVisible = (System.Decimal)dataRow["IS_NODE_VISIBLE"];
			entity.GccFlg = Convert.IsDBNull(dataRow["GCC_FLG"]) ? null : (System.Decimal?)dataRow["GCC_FLG"];
			entity.NationCode = Convert.IsDBNull(dataRow["NATION_CODE"]) ? null : (System.String)dataRow["NATION_CODE"];
			entity.NationDescrAr = Convert.IsDBNull(dataRow["NATION_DESCR_AR"]) ? null : (System.String)dataRow["NATION_DESCR_AR"];
			entity.NationDescrEn = Convert.IsDBNull(dataRow["NATION_DESCR_EN"]) ? null : (System.String)dataRow["NATION_DESCR_EN"];
			entity.GsCodeCurrencyId = Convert.IsDBNull(dataRow["GS_CODE_CURRENCY_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_CURRENCY_ID"];
			entity.AdmAdmissionBandId = Convert.IsDBNull(dataRow["ADM_ADMISSION_BAND_ID"]) ? null : (System.Decimal?)dataRow["ADM_ADMISSION_BAND_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCountryNode"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCountryNode Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCountryNode entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAdmissionBandIdSource	
			if (CanDeepLoad(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepLoadType, innerList) 
				&& entity.AdmAdmissionBandIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAdmissionBandId ?? 0.0m);
				AdmAdmissionBand tmpEntity = EntityManager.LocateEntity<AdmAdmissionBand>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAdmissionBand), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAdmissionBandIdSource = tmpEntity;
				else
					entity.AdmAdmissionBandIdSource = DataRepository.AdmAdmissionBandProvider.GetByAdmAdmissionBandId(transactionManager, (entity.AdmAdmissionBandId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAdmissionBandIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAdmissionBandIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAdmissionBandProvider.DeepLoad(transactionManager, entity.AdmAdmissionBandIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAdmissionBandIdSource

			#region GsCodeCNodeNatureIdSource	
			if (CanDeepLoad(entity, "GsCodeCNodeNature|GsCodeCNodeNatureIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCNodeNatureIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeCNodeNatureId;
				GsCodeCNodeNature tmpEntity = EntityManager.LocateEntity<GsCodeCNodeNature>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCNodeNature), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCNodeNatureIdSource = tmpEntity;
				else
					entity.GsCodeCNodeNatureIdSource = DataRepository.GsCodeCNodeNatureProvider.GetByGsCodeCNodeNatureId(transactionManager, entity.GsCodeCNodeNatureId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCNodeNatureIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCNodeNatureIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCNodeNatureProvider.DeepLoad(transactionManager, entity.GsCodeCNodeNatureIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCNodeNatureIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeCurrencyId ?? 0.0m);
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, (entity.GsCodeCurrencyId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

			#region NodeParentIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|NodeParentIdSource", deepLoadType, innerList) 
				&& entity.NodeParentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.NodeParentId;
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.NodeParentIdSource = tmpEntity;
				else
					entity.NodeParentIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, entity.NodeParentId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'NodeParentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.NodeParentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.NodeParentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion NodeParentIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCountryNodeId methods when available
			
			#region GsCdeSchoolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeSchool>|GsCdeSchoolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeSchoolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeSchoolCollection = DataRepository.GsCdeSchoolProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.GsCdeSchoolCollection.Count > 0)
				{
					deepHandles.Add("GsCdeSchoolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeSchool>) DataRepository.GsCdeSchoolProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeSchoolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgExtMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgExtMember>|PgExtMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgExtMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgExtMemberCollection = DataRepository.PgExtMemberProvider.GetByGsCountryInfoId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.PgExtMemberCollection.Count > 0)
				{
					deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgExtMember>) DataRepository.PgExtMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgExtMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudCarStkrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudCarStkrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudCarStkrCollection = DataRepository.TrnsStudCarStkrProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.TrnsStudCarStkrCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudCarStkr>) DataRepository.TrnsStudCarStkrProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmApplicantCollectionGetByGsCountryNodeId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicant>|AdmApplicantCollectionGetByGsCountryNodeId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantCollectionGetByGsCountryNodeId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantCollectionGetByGsCountryNodeId = DataRepository.AdmApplicantProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AdmApplicantCollectionGetByGsCountryNodeId.Count > 0)
				{
					deepHandles.Add("AdmApplicantCollectionGetByGsCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicant>) DataRepository.AdmApplicantProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantCollectionGetByGsCountryNodeId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeUniversitiesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeUniversities>|GsCdeUniversitiesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeUniversitiesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeUniversitiesCollection = DataRepository.GsCdeUniversitiesProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.GsCdeUniversitiesCollection.Count > 0)
				{
					deepHandles.Add("GsCdeUniversitiesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeUniversities>) DataRepository.GsCdeUniversitiesProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeUniversitiesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdEmployeeQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdEmployeeQual>|EdEmployeeQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdEmployeeQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdEmployeeQualCollection = DataRepository.EdEmployeeQualProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.EdEmployeeQualCollection.Count > 0)
				{
					deepHandles.Add("EdEmployeeQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdEmployeeQual>) DataRepository.EdEmployeeQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdEmployeeQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AsFacultyInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AsFacultyInfo>|AsFacultyInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AsFacultyInfoCollection = DataRepository.AsFacultyInfoProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AsFacultyInfoCollection.Count > 0)
				{
					deepHandles.Add("AsFacultyInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AsFacultyInfo>) DataRepository.AsFacultyInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.AsFacultyInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGuard>|EdGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGuardCollection = DataRepository.EdGuardProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.EdGuardCollection.Count > 0)
				{
					deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGuard>) DataRepository.EdGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGuardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCollectionGetByGsBirthCountryNodeId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollectionGetByGsBirthCountryNodeId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollectionGetByGsBirthCountryNodeId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollectionGetByGsBirthCountryNodeId = DataRepository.EdStudProvider.GetByGsBirthCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.EdStudCollectionGetByGsBirthCountryNodeId.Count > 0)
				{
					deepHandles.Add("EdStudCollectionGetByGsBirthCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollectionGetByGsBirthCountryNodeId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsCdeDrvrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsCdeDrvr>|TrnsCdeDrvrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsCdeDrvrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsCdeDrvrCollection = DataRepository.TrnsCdeDrvrProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.TrnsCdeDrvrCollection.Count > 0)
				{
					deepHandles.Add("TrnsCdeDrvrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsCdeDrvr>) DataRepository.TrnsCdeDrvrProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsCdeDrvrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCollectionGetByGsCountryInfoId1
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollectionGetByGsCountryInfoId1", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollectionGetByGsCountryInfoId1' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollectionGetByGsCountryInfoId1 = DataRepository.EdStudProvider.GetByGsCountryInfoId1(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.EdStudCollectionGetByGsCountryInfoId1.Count > 0)
				{
					deepHandles.Add("EdStudCollectionGetByGsCountryInfoId1",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollectionGetByGsCountryInfoId1, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByGsCountryNodeInfoId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudConferenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudConference>|PgStudConferenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudConferenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudConferenceCollection = DataRepository.PgStudConferenceProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.PgStudConferenceCollection.Count > 0)
				{
					deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudConference>) DataRepository.PgStudConferenceProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudConferenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltRptDayMissionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayMission>|MltRptDayMissionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayMissionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayMissionCollection = DataRepository.MltRptDayMissionProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.MltRptDayMissionCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayMissionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayMission>) DataRepository.MltRptDayMissionProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayMissionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsLineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLine>|TrnsLineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineCollection = DataRepository.TrnsLineProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.TrnsLineCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLine>) DataRepository.TrnsLineProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMissionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMission>|EdStudMissionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMissionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMissionCollection = DataRepository.EdStudMissionProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.EdStudMissionCollection.Count > 0)
				{
					deepHandles.Add("EdStudMissionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMission>) DataRepository.EdStudMissionProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMissionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStudTravelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStudTravel>|PgStudTravelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStudTravelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStudTravelCollection = DataRepository.PgStudTravelProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.PgStudTravelCollection.Count > 0)
				{
					deepHandles.Add("PgStudTravelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStudTravel>) DataRepository.PgStudTravelProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStudTravelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCountryNodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCountryNode>|GsCountryNodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCountryNodeCollection = DataRepository.GsCountryNodeProvider.GetByNodeParentId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.GsCountryNodeCollection.Count > 0)
				{
					deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCountryNode>) DataRepository.GsCountryNodeProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCountryNodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFundCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFund>|FeeStudFundCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFundCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFundCollection = DataRepository.FeeStudFundProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.FeeStudFundCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFund>) DataRepository.FeeStudFundProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFundCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransReqCollection = DataRepository.AdmAppTransReqProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AdmAppTransReqCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmApplicantCollectionGetByGsBirthCountryNodeId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicant>|AdmApplicantCollectionGetByGsBirthCountryNodeId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantCollectionGetByGsBirthCountryNodeId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantCollectionGetByGsBirthCountryNodeId = DataRepository.AdmApplicantProvider.GetByGsBirthCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AdmApplicantCollectionGetByGsBirthCountryNodeId.Count > 0)
				{
					deepHandles.Add("AdmApplicantCollectionGetByGsBirthCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicant>) DataRepository.AdmApplicantProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantCollectionGetByGsBirthCountryNodeId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AlmJobCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AlmJob>|AlmJobCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AlmJobCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AlmJobCollection = DataRepository.AlmJobProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AlmJobCollection.Count > 0)
				{
					deepHandles.Add("AlmJobCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AlmJob>) DataRepository.AlmJobProvider.DeepLoad,
						new object[] { transactionManager, entity.AlmJobCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAddressDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAddressDtl>|GsAddressDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAddressDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAddressDtlCollection = DataRepository.GsAddressDtlProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.GsAddressDtlCollection.Count > 0)
				{
					deepHandles.Add("GsAddressDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAddressDtl>) DataRepository.GsAddressDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAddressDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudGuestReqDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudGuestReqDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudGuestReqDtlCollection = DataRepository.AccomStudGuestReqDtlProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AccomStudGuestReqDtlCollection.Count > 0)
				{
					deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudGuestReqDtl>) DataRepository.AccomStudGuestReqDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollectionGetByGsCountryInfoId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollectionGetByGsCountryInfoId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollectionGetByGsCountryInfoId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollectionGetByGsCountryInfoId = DataRepository.SaStfMemberProvider.GetByGsCountryInfoId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.SaStfMemberCollectionGetByGsCountryInfoId.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollectionGetByGsCountryInfoId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollectionGetByGsCountryInfoId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsMilitaryOfficeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsMilitaryOffice>|GsMilitaryOfficeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsMilitaryOfficeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsMilitaryOfficeCollection = DataRepository.GsMilitaryOfficeProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.GsMilitaryOfficeCollection.Count > 0)
				{
					deepHandles.Add("GsMilitaryOfficeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsMilitaryOffice>) DataRepository.GsMilitaryOfficeProvider.DeepLoad,
						new object[] { transactionManager, entity.GsMilitaryOfficeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollectionGetByGsCountryNodeId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollectionGetByGsCountryNodeId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollectionGetByGsCountryNodeId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollectionGetByGsCountryNodeId = DataRepository.SaStfMemberProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.SaStfMemberCollectionGetByGsCountryNodeId.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollectionGetByGsCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollectionGetByGsCountryNodeId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsCdeStopCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsCdeStop>|TrnsCdeStopCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsCdeStopCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsCdeStopCollection = DataRepository.TrnsCdeStopProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.TrnsCdeStopCollection.Count > 0)
				{
					deepHandles.Add("TrnsCdeStopCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsCdeStop>) DataRepository.TrnsCdeStopProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsCdeStopCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppWorkExperCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppWorkExperCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppWorkExperCollection = DataRepository.AdmAppWorkExperProvider.GetByGsCountryNodeId(transactionManager, entity.GsCountryNodeId);

				if (deep && entity.AdmAppWorkExperCollection.Count > 0)
				{
					deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppWorkExper>) DataRepository.AdmAppWorkExperProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppWorkExperCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCountryNode object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCountryNode instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCountryNode Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCountryNode entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAdmissionBandIdSource
			if (CanDeepSave(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepSaveType, innerList) 
				&& entity.AdmAdmissionBandIdSource != null)
			{
				DataRepository.AdmAdmissionBandProvider.Save(transactionManager, entity.AdmAdmissionBandIdSource);
				entity.AdmAdmissionBandId = entity.AdmAdmissionBandIdSource.AdmAdmissionBandId;
			}
			#endregion 
			
			#region GsCodeCNodeNatureIdSource
			if (CanDeepSave(entity, "GsCodeCNodeNature|GsCodeCNodeNatureIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCNodeNatureIdSource != null)
			{
				DataRepository.GsCodeCNodeNatureProvider.Save(transactionManager, entity.GsCodeCNodeNatureIdSource);
				entity.GsCodeCNodeNatureId = entity.GsCodeCNodeNatureIdSource.GsCodeCNodeNatureId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
			}
			#endregion 
			
			#region NodeParentIdSource
			if (CanDeepSave(entity, "GsCountryNode|NodeParentIdSource", deepSaveType, innerList) 
				&& entity.NodeParentIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.NodeParentIdSource);
				entity.NodeParentId = entity.NodeParentIdSource.GsCountryNodeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsCdeSchool>
				if (CanDeepSave(entity.GsCdeSchoolCollection, "List<GsCdeSchool>|GsCdeSchoolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeSchool child in entity.GsCdeSchoolCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.GsCdeSchoolCollection.Count > 0 || entity.GsCdeSchoolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeSchoolProvider.Save(transactionManager, entity.GsCdeSchoolCollection);
						
						deepHandles.Add("GsCdeSchoolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeSchool >) DataRepository.GsCdeSchoolProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeSchoolCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgExtMember>
				if (CanDeepSave(entity.PgExtMemberCollection, "List<PgExtMember>|PgExtMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgExtMember child in entity.PgExtMemberCollection)
					{
						if(child.GsCountryInfoIdSource != null)
						{
							child.GsCountryInfoId = child.GsCountryInfoIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryInfoId = entity.GsCountryNodeId;
						}

					}

					if (entity.PgExtMemberCollection.Count > 0 || entity.PgExtMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgExtMemberProvider.Save(transactionManager, entity.PgExtMemberCollection);
						
						deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgExtMember >) DataRepository.PgExtMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgExtMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudCarStkr>
				if (CanDeepSave(entity.TrnsStudCarStkrCollection, "List<TrnsStudCarStkr>|TrnsStudCarStkrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudCarStkr child in entity.TrnsStudCarStkrCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.TrnsStudCarStkrCollection.Count > 0 || entity.TrnsStudCarStkrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudCarStkrProvider.Save(transactionManager, entity.TrnsStudCarStkrCollection);
						
						deepHandles.Add("TrnsStudCarStkrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudCarStkr >) DataRepository.TrnsStudCarStkrProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudCarStkrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmApplicant>
				if (CanDeepSave(entity.AdmApplicantCollectionGetByGsCountryNodeId, "List<AdmApplicant>|AdmApplicantCollectionGetByGsCountryNodeId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicant child in entity.AdmApplicantCollectionGetByGsCountryNodeId)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.AdmApplicantCollectionGetByGsCountryNodeId.Count > 0 || entity.AdmApplicantCollectionGetByGsCountryNodeId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantCollectionGetByGsCountryNodeId);
						
						deepHandles.Add("AdmApplicantCollectionGetByGsCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicant >) DataRepository.AdmApplicantProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantCollectionGetByGsCountryNodeId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCdeUniversities>
				if (CanDeepSave(entity.GsCdeUniversitiesCollection, "List<GsCdeUniversities>|GsCdeUniversitiesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeUniversities child in entity.GsCdeUniversitiesCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.GsCdeUniversitiesCollection.Count > 0 || entity.GsCdeUniversitiesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeUniversitiesProvider.Save(transactionManager, entity.GsCdeUniversitiesCollection);
						
						deepHandles.Add("GsCdeUniversitiesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeUniversities >) DataRepository.GsCdeUniversitiesProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeUniversitiesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdEmployeeQual>
				if (CanDeepSave(entity.EdEmployeeQualCollection, "List<EdEmployeeQual>|EdEmployeeQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdEmployeeQual child in entity.EdEmployeeQualCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.EdEmployeeQualCollection.Count > 0 || entity.EdEmployeeQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdEmployeeQualProvider.Save(transactionManager, entity.EdEmployeeQualCollection);
						
						deepHandles.Add("EdEmployeeQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdEmployeeQual >) DataRepository.EdEmployeeQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdEmployeeQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AsFacultyInfo>
				if (CanDeepSave(entity.AsFacultyInfoCollection, "List<AsFacultyInfo>|AsFacultyInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AsFacultyInfo child in entity.AsFacultyInfoCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.AsFacultyInfoCollection.Count > 0 || entity.AsFacultyInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoCollection);
						
						deepHandles.Add("AsFacultyInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AsFacultyInfo >) DataRepository.AsFacultyInfoProvider.DeepSave,
							new object[] { transactionManager, entity.AsFacultyInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdGuard>
				if (CanDeepSave(entity.EdGuardCollection, "List<EdGuard>|EdGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGuard child in entity.EdGuardCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.EdGuardCollection.Count > 0 || entity.EdGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGuardProvider.Save(transactionManager, entity.EdGuardCollection);
						
						deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGuard >) DataRepository.EdGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGuardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollectionGetByGsBirthCountryNodeId, "List<EdStud>|EdStudCollectionGetByGsBirthCountryNodeId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollectionGetByGsBirthCountryNodeId)
					{
						if(child.GsBirthCountryNodeIdSource != null)
						{
							child.GsBirthCountryNodeId = child.GsBirthCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsBirthCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.EdStudCollectionGetByGsBirthCountryNodeId.Count > 0 || entity.EdStudCollectionGetByGsBirthCountryNodeId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudCollectionGetByGsBirthCountryNodeId);
						
						deepHandles.Add("EdStudCollectionGetByGsBirthCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStud >) DataRepository.EdStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCollectionGetByGsBirthCountryNodeId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsCdeDrvr>
				if (CanDeepSave(entity.TrnsCdeDrvrCollection, "List<TrnsCdeDrvr>|TrnsCdeDrvrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsCdeDrvr child in entity.TrnsCdeDrvrCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.TrnsCdeDrvrCollection.Count > 0 || entity.TrnsCdeDrvrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsCdeDrvrProvider.Save(transactionManager, entity.TrnsCdeDrvrCollection);
						
						deepHandles.Add("TrnsCdeDrvrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsCdeDrvr >) DataRepository.TrnsCdeDrvrProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsCdeDrvrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollectionGetByGsCountryInfoId1, "List<EdStud>|EdStudCollectionGetByGsCountryInfoId1", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollectionGetByGsCountryInfoId1)
					{
						if(child.GsCountryInfoId1Source != null)
						{
							child.GsCountryInfoId1 = child.GsCountryInfoId1Source.GsCountryNodeId;
						}
						else
						{
							child.GsCountryInfoId1 = entity.GsCountryNodeId;
						}

					}

					if (entity.EdStudCollectionGetByGsCountryInfoId1.Count > 0 || entity.EdStudCollectionGetByGsCountryInfoId1.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudCollectionGetByGsCountryInfoId1);
						
						deepHandles.Add("EdStudCollectionGetByGsCountryInfoId1",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStud >) DataRepository.EdStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCollectionGetByGsCountryInfoId1, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.GsCountryNodeInfoIdSource != null)
						{
							child.GsCountryNodeInfoId = child.GsCountryNodeInfoIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeInfoId = entity.GsCountryNodeId;
						}

					}

					if (entity.AdmPrecondQualCollection.Count > 0 || entity.AdmPrecondQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPrecondQualProvider.Save(transactionManager, entity.AdmPrecondQualCollection);
						
						deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPrecondQual >) DataRepository.AdmPrecondQualProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPrecondQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudConference>
				if (CanDeepSave(entity.PgStudConferenceCollection, "List<PgStudConference>|PgStudConferenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudConference child in entity.PgStudConferenceCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.PgStudConferenceCollection.Count > 0 || entity.PgStudConferenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudConferenceProvider.Save(transactionManager, entity.PgStudConferenceCollection);
						
						deepHandles.Add("PgStudConferenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudConference >) DataRepository.PgStudConferenceProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudConferenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltRptDayMission>
				if (CanDeepSave(entity.MltRptDayMissionCollection, "List<MltRptDayMission>|MltRptDayMissionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayMission child in entity.MltRptDayMissionCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.MltRptDayMissionCollection.Count > 0 || entity.MltRptDayMissionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayMissionProvider.Save(transactionManager, entity.MltRptDayMissionCollection);
						
						deepHandles.Add("MltRptDayMissionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayMission >) DataRepository.MltRptDayMissionProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayMissionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsLine>
				if (CanDeepSave(entity.TrnsLineCollection, "List<TrnsLine>|TrnsLineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLine child in entity.TrnsLineCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.TrnsLineCollection.Count > 0 || entity.TrnsLineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineCollection);
						
						deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLine >) DataRepository.TrnsLineProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudMission>
				if (CanDeepSave(entity.EdStudMissionCollection, "List<EdStudMission>|EdStudMissionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMission child in entity.EdStudMissionCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.EdStudMissionCollection.Count > 0 || entity.EdStudMissionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMissionProvider.Save(transactionManager, entity.EdStudMissionCollection);
						
						deepHandles.Add("EdStudMissionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMission >) DataRepository.EdStudMissionProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMissionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStudTravel>
				if (CanDeepSave(entity.PgStudTravelCollection, "List<PgStudTravel>|PgStudTravelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStudTravel child in entity.PgStudTravelCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.PgStudTravelCollection.Count > 0 || entity.PgStudTravelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStudTravelProvider.Save(transactionManager, entity.PgStudTravelCollection);
						
						deepHandles.Add("PgStudTravelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStudTravel >) DataRepository.PgStudTravelProvider.DeepSave,
							new object[] { transactionManager, entity.PgStudTravelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCountryNode>
				if (CanDeepSave(entity.GsCountryNodeCollection, "List<GsCountryNode>|GsCountryNodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCountryNode child in entity.GsCountryNodeCollection)
					{
						if(child.NodeParentIdSource != null)
						{
							child.NodeParentId = child.NodeParentIdSource.GsCountryNodeId;
						}
						else
						{
							child.NodeParentId = entity.GsCountryNodeId;
						}

					}

					if (entity.GsCountryNodeCollection.Count > 0 || entity.GsCountryNodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeCollection);
						
						deepHandles.Add("GsCountryNodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCountryNode >) DataRepository.GsCountryNodeProvider.DeepSave,
							new object[] { transactionManager, entity.GsCountryNodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFund>
				if (CanDeepSave(entity.FeeStudFundCollection, "List<FeeStudFund>|FeeStudFundCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFund child in entity.FeeStudFundCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.FeeStudFundCollection.Count > 0 || entity.FeeStudFundCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFundProvider.Save(transactionManager, entity.FeeStudFundCollection);
						
						deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFund >) DataRepository.FeeStudFundProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFundCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransReq>
				if (CanDeepSave(entity.AdmAppTransReqCollection, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransReq child in entity.AdmAppTransReqCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.AdmAppTransReqCollection.Count > 0 || entity.AdmAppTransReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqCollection);
						
						deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransReq >) DataRepository.AdmAppTransReqProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmApplicant>
				if (CanDeepSave(entity.AdmApplicantCollectionGetByGsBirthCountryNodeId, "List<AdmApplicant>|AdmApplicantCollectionGetByGsBirthCountryNodeId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicant child in entity.AdmApplicantCollectionGetByGsBirthCountryNodeId)
					{
						if(child.GsBirthCountryNodeIdSource != null)
						{
							child.GsBirthCountryNodeId = child.GsBirthCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsBirthCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.AdmApplicantCollectionGetByGsBirthCountryNodeId.Count > 0 || entity.AdmApplicantCollectionGetByGsBirthCountryNodeId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantCollectionGetByGsBirthCountryNodeId);
						
						deepHandles.Add("AdmApplicantCollectionGetByGsBirthCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicant >) DataRepository.AdmApplicantProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantCollectionGetByGsBirthCountryNodeId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AlmJob>
				if (CanDeepSave(entity.AlmJobCollection, "List<AlmJob>|AlmJobCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AlmJob child in entity.AlmJobCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.AlmJobCollection.Count > 0 || entity.AlmJobCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AlmJobProvider.Save(transactionManager, entity.AlmJobCollection);
						
						deepHandles.Add("AlmJobCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AlmJob >) DataRepository.AlmJobProvider.DeepSave,
							new object[] { transactionManager, entity.AlmJobCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAddressDtl>
				if (CanDeepSave(entity.GsAddressDtlCollection, "List<GsAddressDtl>|GsAddressDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAddressDtl child in entity.GsAddressDtlCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.GsAddressDtlCollection.Count > 0 || entity.GsAddressDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAddressDtlProvider.Save(transactionManager, entity.GsAddressDtlCollection);
						
						deepHandles.Add("GsAddressDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAddressDtl >) DataRepository.GsAddressDtlProvider.DeepSave,
							new object[] { transactionManager, entity.GsAddressDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudGuestReqDtl>
				if (CanDeepSave(entity.AccomStudGuestReqDtlCollection, "List<AccomStudGuestReqDtl>|AccomStudGuestReqDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudGuestReqDtl child in entity.AccomStudGuestReqDtlCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.AccomStudGuestReqDtlCollection.Count > 0 || entity.AccomStudGuestReqDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudGuestReqDtlProvider.Save(transactionManager, entity.AccomStudGuestReqDtlCollection);
						
						deepHandles.Add("AccomStudGuestReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudGuestReqDtl >) DataRepository.AccomStudGuestReqDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudGuestReqDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollectionGetByGsCountryInfoId, "List<SaStfMember>|SaStfMemberCollectionGetByGsCountryInfoId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollectionGetByGsCountryInfoId)
					{
						if(child.GsCountryInfoIdSource != null)
						{
							child.GsCountryInfoId = child.GsCountryInfoIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryInfoId = entity.GsCountryNodeId;
						}

					}

					if (entity.SaStfMemberCollectionGetByGsCountryInfoId.Count > 0 || entity.SaStfMemberCollectionGetByGsCountryInfoId.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollectionGetByGsCountryInfoId);
						
						deepHandles.Add("SaStfMemberCollectionGetByGsCountryInfoId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollectionGetByGsCountryInfoId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsMilitaryOffice>
				if (CanDeepSave(entity.GsMilitaryOfficeCollection, "List<GsMilitaryOffice>|GsMilitaryOfficeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsMilitaryOffice child in entity.GsMilitaryOfficeCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.GsMilitaryOfficeCollection.Count > 0 || entity.GsMilitaryOfficeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsMilitaryOfficeProvider.Save(transactionManager, entity.GsMilitaryOfficeCollection);
						
						deepHandles.Add("GsMilitaryOfficeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsMilitaryOffice >) DataRepository.GsMilitaryOfficeProvider.DeepSave,
							new object[] { transactionManager, entity.GsMilitaryOfficeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollectionGetByGsCountryNodeId, "List<SaStfMember>|SaStfMemberCollectionGetByGsCountryNodeId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollectionGetByGsCountryNodeId)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.SaStfMemberCollectionGetByGsCountryNodeId.Count > 0 || entity.SaStfMemberCollectionGetByGsCountryNodeId.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollectionGetByGsCountryNodeId);
						
						deepHandles.Add("SaStfMemberCollectionGetByGsCountryNodeId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollectionGetByGsCountryNodeId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsCdeStop>
				if (CanDeepSave(entity.TrnsCdeStopCollection, "List<TrnsCdeStop>|TrnsCdeStopCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsCdeStop child in entity.TrnsCdeStopCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.TrnsCdeStopCollection.Count > 0 || entity.TrnsCdeStopCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsCdeStopProvider.Save(transactionManager, entity.TrnsCdeStopCollection);
						
						deepHandles.Add("TrnsCdeStopCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsCdeStop >) DataRepository.TrnsCdeStopProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsCdeStopCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppWorkExper>
				if (CanDeepSave(entity.AdmAppWorkExperCollection, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppWorkExper child in entity.AdmAppWorkExperCollection)
					{
						if(child.GsCountryNodeIdSource != null)
						{
							child.GsCountryNodeId = child.GsCountryNodeIdSource.GsCountryNodeId;
						}
						else
						{
							child.GsCountryNodeId = entity.GsCountryNodeId;
						}

					}

					if (entity.AdmAppWorkExperCollection.Count > 0 || entity.AdmAppWorkExperCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppWorkExperProvider.Save(transactionManager, entity.AdmAppWorkExperCollection);
						
						deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppWorkExper >) DataRepository.AdmAppWorkExperProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppWorkExperCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCountryNodeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCountryNode</c>
	///</summary>
	public enum GsCountryNodeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAdmissionBand</c> at AdmAdmissionBandIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAdmissionBand))]
		AdmAdmissionBand,
		
		///<summary>
		/// Composite Property for <c>GsCodeCNodeNature</c> at GsCodeCNodeNatureIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCNodeNature))]
		GsCodeCNodeNature,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at NodeParentIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for GsCdeSchoolCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeSchool>))]
		GsCdeSchoolCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for PgExtMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgExtMember>))]
		PgExtMemberCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for TrnsStudCarStkrCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudCarStkr>))]
		TrnsStudCarStkrCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AdmApplicantCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicant>))]
		AdmApplicantCollectionGetByGsCountryNodeId,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for GsCdeUniversitiesCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeUniversities>))]
		GsCdeUniversitiesCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for EdEmployeeQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdEmployeeQual>))]
		EdEmployeeQualCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AsFacultyInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<AsFacultyInfo>))]
		AsFacultyInfoCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for EdGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGuard>))]
		EdGuardCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollectionGetByGsBirthCountryNodeId,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for TrnsCdeDrvrCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsCdeDrvr>))]
		TrnsCdeDrvrCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollectionGetByGsCountryInfoId1,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for PgStudConferenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudConference>))]
		PgStudConferenceCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for MltRptDayMissionCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayMission>))]
		MltRptDayMissionCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for TrnsLineCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLine>))]
		TrnsLineCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for EdStudMissionCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMission>))]
		EdStudMissionCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for PgStudTravelCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStudTravel>))]
		PgStudTravelCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for GsCountryNodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCountryNode>))]
		GsCountryNodeCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for FeeStudFundCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFund>))]
		FeeStudFundCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AdmApplicantCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicant>))]
		AdmApplicantCollectionGetByGsBirthCountryNodeId,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AlmJobCollection
		///</summary>
		[ChildEntityType(typeof(TList<AlmJob>))]
		AlmJobCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for GsAddressDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAddressDtl>))]
		GsAddressDtlCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AccomStudGuestReqDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudGuestReqDtl>))]
		AccomStudGuestReqDtlCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollectionGetByGsCountryInfoId,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for GsMilitaryOfficeCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsMilitaryOffice>))]
		GsMilitaryOfficeCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollectionGetByGsCountryNodeId,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for TrnsCdeStopCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsCdeStop>))]
		TrnsCdeStopCollection,
		///<summary>
		/// Collection of <c>GsCountryNode</c> as OneToMany for AdmAppWorkExperCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppWorkExper>))]
		AdmAppWorkExperCollection,
	}
	
	#endregion GsCountryNodeChildEntityTypes
	
	#region GsCountryNodeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCountryNodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCountryNode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCountryNodeFilterBuilder : SqlFilterBuilder<GsCountryNodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCountryNodeFilterBuilder class.
		/// </summary>
		public GsCountryNodeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCountryNodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCountryNodeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCountryNodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCountryNodeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCountryNodeFilterBuilder
	
	#region GsCountryNodeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCountryNodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCountryNode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCountryNodeParameterBuilder : ParameterizedSqlFilterBuilder<GsCountryNodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCountryNodeParameterBuilder class.
		/// </summary>
		public GsCountryNodeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCountryNodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCountryNodeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCountryNodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCountryNodeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCountryNodeParameterBuilder
	
	#region GsCountryNodeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCountryNodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCountryNode"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCountryNodeSortBuilder : SqlSortBuilder<GsCountryNodeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCountryNodeSqlSortBuilder class.
		/// </summary>
		public GsCountryNodeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCountryNodeSortBuilder
	
} // end namespace
