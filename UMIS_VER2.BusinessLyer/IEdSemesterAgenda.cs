﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_SEMESTER_AGENDA' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdSemesterAgenda 
	{
		/// <summary>			
		/// ED_SEMESTER_AGENDA_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_SEMESTER_AGENDA"</remarks>
		System.Decimal EdSemesterAgendaId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdSemesterAgendaId { get; set; }
			
		
		
		/// <summary>
		/// ED_SEMESTER_OPEN_ID : 
		/// </summary>
		System.Decimal?  EdSemesterOpenId  { get; set; }
		
		/// <summary>
		/// ADM_OPEN_ACAD_SEMESTER_ID : Ejust
		/// </summary>
		System.Decimal?  AdmOpenAcadSemesterId  { get; set; }
		
		/// <summary>
		/// ED_CODE_SEM_ACTVITY_ID : 
		/// </summary>
		System.Decimal  EdCodeSemActvityId  { get; set; }
		
		/// <summary>
		/// FROM_DATE : 
		/// </summary>
		System.DateTime?  FromDate  { get; set; }
		
		/// <summary>
		/// TO_DATE : 
		/// </summary>
		System.DateTime?  ToDate  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : UG/PG
		/// </summary>
		System.Decimal?  AsCodeDegreeClassId  { get; set; }
		
		/// <summary>
		/// EMAIL_FLG : 
		/// </summary>
		System.Decimal?  EmailFlg  { get; set; }
		
		/// <summary>
		/// EMP_FLG : 
		/// </summary>
		System.Decimal?  EmpFlg  { get; set; }
		
		/// <summary>
		/// STF_FLG : 
		/// </summary>
		System.Decimal?  StfFlg  { get; set; }
		
		/// <summary>
		/// STUD_FLG : يعرض النشاط فى فيو طالب
		/// </summary>
		System.Decimal?  StudFlg  { get; set; }
		
		/// <summary>
		/// ONLINE_FLG : يسمح للطلاب التسجيل اونلاين
		/// </summary>
		System.Decimal  OnlineFlg  { get; set; }
		
		/// <summary>
		/// TO_DATE_ACT : 
		/// </summary>
		System.DateTime?  ToDateAct  { get; set; }
		
		/// <summary>
		/// SHOW_FLG : 
		/// </summary>
		System.Decimal?  ShowFlg  { get; set; }
		
		/// <summary>
		/// NEW_COMR_FLG : 
		/// </summary>
		System.Boolean?  NewComrFlg  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// AUDT_NOTE : 
		/// </summary>
		System.String  AudtNote  { get; set; }
		
		/// <summary>
		/// NOTES : Responsible
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// FEE_REFUND_PRCNT : نسبة الاسترداد عند عمل انسحاب او انسحاب متأخر
		/// </summary>
		System.Decimal?  FeeRefundPrcnt  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_ID : مسلسل الدرجة العلمية
		/// </summary>
		System.Decimal?  AsCodeDegreeId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemAgendaFormEdSemesterAgendaId
		/// </summary>	
		TList<EdSemAgendaForm> EdSemAgendaFormCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemAgendaDtlEdSemesterAgendaId
		/// </summary>	
		TList<EdSemAgendaDtl> EdSemAgendaDtlCollection {  get;  set;}	

		#endregion Data Properties

	}
}

