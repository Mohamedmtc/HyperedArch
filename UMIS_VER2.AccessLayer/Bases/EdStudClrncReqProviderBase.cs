#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="EdStudClrncReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudClrncReqProviderBase : EdStudClrncReqProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable SearchStudClearReq(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId
            , System.Decimal _AsFacultyId, System.DateTime? _ReqFromDate, System.DateTime? _ReqToDate, System.Decimal? _GsCodeClearReasonId
            , System.Decimal? _GsCodeReqStatusId,System.String StudCode);

        public abstract decimal InsertWithIdOut(TransactionManager transactionManager, EdStudClrncReq entity);


        #endregion
	} // end class
} // end namespace
