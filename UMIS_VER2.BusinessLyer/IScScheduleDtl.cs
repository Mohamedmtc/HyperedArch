﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SC_SCHEDULE_DTL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScScheduleDtl 
	{
		/// <summary>			
		/// SC_SCHEDULE_DTL_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SC_SCHEDULE_DTL"</remarks>
		System.Decimal ScScheduleDtlId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalScScheduleDtlId { get; set; }
			
		
		
		/// <summary>
		/// SC_SCHEDULE_HDR_ID : 
		/// </summary>
		System.Decimal  ScScheduleHdrId  { get; set; }
		
		/// <summary>
		/// GROUP_DESCR_AR : 
		/// </summary>
		System.String  GroupDescrAr  { get; set; }
		
		/// <summary>
		/// GROUP_DESCR_EN : 
		/// </summary>
		System.String  GroupDescrEn  { get; set; }
		
		/// <summary>
		/// GROUP_ORDER : 
		/// </summary>
		System.Decimal?  GroupOrder  { get; set; }
		
		/// <summary>
		/// GS_CODE_GENDER_ID : 
		/// </summary>
		System.Decimal?  GsCodeGenderId  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		System.Decimal?  AsFacultyInfoId  { get; set; }
		
		/// <summary>
		/// IS_RESULT_APPROVED : 
		/// </summary>
		System.Decimal  IsResultApproved  { get; set; }
		
		/// <summary>
		/// SE_USER_RSULT_APPROVE_ID : 
		/// </summary>
		System.Decimal?  SeUserRsultApproveId  { get; set; }
		
		/// <summary>
		/// RSULT_APPROVE_DATE : 
		/// </summary>
		System.DateTime?  RsultApproveDate  { get; set; }
		
		/// <summary>
		/// NO_STUDENTS : 
		/// </summary>
		System.Decimal?  NoStudents  { get; set; }
		
		/// <summary>
		/// NO_STUD_WAIT : 
		/// </summary>
		System.Decimal?  NoStudWait  { get; set; }
		
		/// <summary>
		/// ONLINE_FLG : 
		/// </summary>
		System.Decimal  OnlineFlg  { get; set; }
		
		/// <summary>
		/// IS_CLOSED : 
		/// </summary>
		System.Decimal?  IsClosed  { get; set; }
		
		/// <summary>
		/// NOTES_EMP : 
		/// </summary>
		System.String  NotesEmp  { get; set; }
		
		/// <summary>
		/// NO_STUD_MAX : 
		/// </summary>
		System.Decimal?  NoStudMax  { get; set; }
		
		/// <summary>
		/// INTERNAL_FLG : 
		/// </summary>
		System.Decimal  InternalFlg  { get; set; }
		
		/// <summary>
		/// WAITLIST_FLG : 
		/// </summary>
		System.Decimal?  WaitlistFlg  { get; set; }
		
		/// <summary>
		/// GS_CODE_LANGUAGE_ID : 
		/// </summary>
		System.Decimal?  GsCodeLanguageId  { get; set; }
		
		/// <summary>
		/// CNCL_FLG : 
		/// </summary>
		System.Decimal?  CnclFlg  { get; set; }
		
		/// <summary>
		/// PART_TIME_FLG : 
		/// </summary>
		System.Int32?  PartTimeFlg  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleCrossListScScheduleDtlId2GetByScScheduleDtlId1
		/// </summary>	
		TList<ScScheduleCrossList> ScScheduleCrossListCollectionGetByScScheduleDtlId1 {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edExamSuprvsorScScheduleDtlId
		/// </summary>	
		TList<EdExamSuprvsor> EdExamSuprvsorCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svLecNoteScScheduleDtlId
		/// </summary>	
		TList<SvLecNote> SvLecNoteCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCourseInstanceScScheduleDtlId
		/// </summary>	
		TList<EdCourseInstance> EdCourseInstanceCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _wfCrsRsltApproveScScheduleDtlId
		/// </summary>	
		TList<WfCrsRsltApprove> WfCrsRsltApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coExamSchdlPlaceScScheduleDtlId
		/// </summary>	
		TList<CoExamSchdlPlace> CoExamSchdlPlaceCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSectionGroupDtlScScheduleDtlId
		/// </summary>	
		TList<ScSectionGroupDtl> ScSectionGroupDtlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudGroupPreScScheduleDtlId
		/// </summary>	
		TList<EdStudGroupPre> EdStudGroupPreCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svPollHdrScScheduleDtlId
		/// </summary>	
		TList<SvPollHdr> SvPollHdrCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleCrossListScScheduleDtlId2GetByScScheduleDtlId2
		/// </summary>	
		TList<ScScheduleCrossList> ScScheduleCrossListCollectionGetByScScheduleDtlId2 {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleDtlDayScScheduleDtlId
		/// </summary>	
		TList<ScScheduleDtlDay> ScScheduleDtlDayCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseWaitScScheduleDtlId
		/// </summary>	
		TList<EdStudCourseWait> EdStudCourseWaitCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudGroupScScheduleDtlId
		/// </summary>	
		TList<EdStudGroup> EdStudGroupCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleRsrvScScheduleDtlId
		/// </summary>	
		TList<ScScheduleRsrv> ScScheduleRsrvCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleDtlExtStfScScheduleDtlId
		/// </summary>	
		TList<ScScheduleDtlExtStf> ScScheduleDtlExtStfCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _seBlockTransScScheduleDtlId
		/// </summary>	
		TList<SeBlockTrans> SeBlockTransCollection {  get;  set;}	

		#endregion Data Properties

	}
}

