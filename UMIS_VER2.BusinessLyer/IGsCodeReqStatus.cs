﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CODE_REQ_STATUS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCodeReqStatus 
	{
		/// <summary>			
		/// GS_CODE_REQ_STATUS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CODE_REQ_STATUS"</remarks>
		System.Decimal GsCodeReqStatusId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCodeReqStatusId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudExecuseReqGsCodeReqStatusId
		/// </summary>	
		TList<EdStudExecuseReq> EdStudExecuseReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppTransReqGsCodeReqStatusId
		/// </summary>	
		TList<AdmAppTransReq> AdmAppTransReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeRefndStdReqGsCodeReqStatusId
		/// </summary>	
		TList<FeeRefndStdReq> FeeRefndStdReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _spoOfferStudExceptionGsCodeReqStatusId
		/// </summary>	
		TList<SpoOfferStudException> SpoOfferStudExceptionCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _rsrchStudPostponeReqGsCodeReqStatusId
		/// </summary>	
		TList<RsrchStudPostponeReq> RsrchStudPostponeReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsGsCodeReqStatusId
		/// </summary>	
		TList<EdStudIntTrns> EdStudIntTrnsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRplcGsCodeReqStatusId
		/// </summary>	
		TList<EdStudCourseRplc> EdStudCourseRplcCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudTransFromReqGsCodeReqStatusId
		/// </summary>	
		TList<EdStudTransFromReq> EdStudTransFromReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudExcuseGsCodeReqStatusId
		/// </summary>	
		TList<EdStudExcuse> EdStudExcuseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudClrncReqGsCodeReqStatusId
		/// </summary>	
		TList<EdStudClrncReq> EdStudClrncReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudPermtReqGsCodeReqStatusId
		/// </summary>	
		TList<AccomStudPermtReq> AccomStudPermtReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudLeaveReqGsCodeReqStatusId
		/// </summary>	
		TList<AccomStudLeaveReq> AccomStudLeaveReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudExmptReqGsCodeReqStatusId
		/// </summary>	
		TList<EdStudExmptReq> EdStudExmptReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _trnsStudReqGsCodeReqStatusId
		/// </summary>	
		TList<TrnsStudReq> TrnsStudReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudFeedReqGsCodeReqStatusId
		/// </summary>	
		TList<AccomStudFeedReq> AccomStudFeedReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudReqGsCodeReqStatusId
		/// </summary>	
		TList<AccomStudReq> AccomStudReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudInstallmentRequestGsCodeReqStatusId
		/// </summary>	
		TList<FeeStudInstallmentRequest> FeeStudInstallmentRequestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomStudGuestReqGsCodeReqStatusId
		/// </summary>	
		TList<AccomStudGuestReq> AccomStudGuestReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudDiscGsCodeReqStatusId
		/// </summary>	
		TList<FeeStudDisc> FeeStudDiscCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseChngGsCodeReqStatusId
		/// </summary>	
		TList<EdStudCourseChng> EdStudCourseChngCollection {  get;  set;}	

		#endregion Data Properties

	}
}


