﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_STUD_EXMPT_REQ' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdStudExmptReq 
	{
		/// <summary>			
		/// ED_STUD_EXMPT_REQ_ID : طلبات الاعفاء
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_STUD_EXMPT_REQ"</remarks>
		System.Decimal EdStudExmptReqId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdStudExmptReqId { get; set; }
			
		
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// GS_CODE_REQ_STATUS_ID : حالة الطلب
		/// </summary>
		System.Decimal  GsCodeReqStatusId  { get; set; }
		
		/// <summary>
		/// REQ_DATE : last approve or cancel date
		/// </summary>
		System.DateTime  ReqDate  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// ED_CDE_EXMPT_ID : نوع الاعفاء:credittransferRPL-crosscredit-trainingcourse
		/// </summary>
		System.Int32  EdCdeExmptId  { get; set; }
		
		/// <summary>
		/// DEPT_APPROVE_DT : تاريخ مجلس القسم (Program)
		/// </summary>
		System.DateTime?  DeptApproveDt  { get; set; }
		
		/// <summary>
		/// FAC_APPROVE_DT : تاريخ مجلس المدرسة  (School)
		/// </summary>
		System.DateTime?  FacApproveDt  { get; set; }
		
		/// <summary>
		/// UNIV_APPROVE_DT : تاريخ مجلس التعليم (Education Council)
		/// </summary>
		System.DateTime?  UnivApproveDt  { get; set; }
		
		/// <summary>
		/// APPROVE_FLG : مؤشر اعتماد الطلب
		/// </summary>
		System.Decimal  ApproveFlg  { get; set; }
		
		/// <summary>
		/// EXMPT_APPROVE_DT : اعتماد طلب اعفاء
		/// </summary>
		System.DateTime?  ExmptApproveDt  { get; set; }
		
		/// <summary>
		/// EXMPT_APPRV_USR_ID : اعتماد طلب اعفاء
		/// </summary>
		System.Decimal?  ExmptApprvUsrId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudExmptReqAttchEdStudExmptReqId
		/// </summary>	
		TList<EdStudExmptReqAttch> EdStudExmptReqAttchCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudExmptCrsFromEdStudExmptReqId
		/// </summary>	
		TList<EdStudExmptCrsFrom> EdStudExmptCrsFromCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudExmptCrsToEdStudExmptReqId
		/// </summary>	
		TList<EdStudExmptCrsTo> EdStudExmptCrsToCollection {  get;  set;}	

		#endregion Data Properties

	}
}


