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
	/// This class is the base class for any <see cref="EdStudCourseGrdChngProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudCourseGrdChngProviderBase : EdStudCourseGrdChngProviderBaseCore
	{

        public abstract DataTable SearchStudCourseChange(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId
          , System.DateTime? _FromDate, System.DateTime? _ToDate, System.Decimal _EdCodeCourseChangeIdFrom, System.Decimal _EdCodeCourseChangeIdTo, System.Decimal _EdCodeGradingIdFrom, System.Decimal _EdCodeGradingIdTo, System.Decimal? _ApproveFlg, System.Decimal _EdStudId);

        //kamela, 13239, Seacrh About All Chng Grad of result requests
        public abstract DataTable SearchAllsentChngResultReq(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal? _ApproveFlg, System.Decimal _EdStudId, System.Decimal? _Staff_Know_Flg = null
            , System.DateTime? _FromDate = null, System.DateTime? _ToDate = null, System.Decimal? _CourseId = null, System.Decimal? _SectionId = null, System.Decimal? _RequestType = null);

        public abstract DataTable CheckAllReqForApproveAcceptReject(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal? _ApproveFlg, System.Decimal _EdStudId, System.Decimal _CodeUserType, 
           System.DateTime? _FromDate = null, System.DateTime? _ToDate = null, System.Decimal? _CourseId = null, System.Decimal? _RequestType = null);
        public abstract DataTable GetAllActionHappentOnGrdChngReq(TransactionManager transactionManager,  System.Decimal _GrdChngReqId );
       // , System.DateTime? _FromDate, System.DateTime? _ToDate, System.Decimal _EdCodeCourseChangeIdFrom, System.Decimal _EdCodeCourseChangeIdTo, System.Decimal _EdCodeGradingIdFrom, System.Decimal _EdCodeGradingIdTo, System.Decimal? _ApproveFlg, System.Decimal _EdStudId);
        //end, 13239

	} // end class
} // end namespace
