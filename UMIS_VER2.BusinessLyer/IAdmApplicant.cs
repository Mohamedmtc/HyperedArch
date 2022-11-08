﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_APPLICANT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmApplicant 
	{
		/// <summary>			
		/// ADM_APPLICANT_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_APPLICANT"</remarks>
		System.Decimal AdmApplicantId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmApplicantId { get; set; }
			
		
		
		/// <summary>
		/// ADM_APP_CODE : 
		/// </summary>
		System.String  AdmAppCode  { get; set; }
		
		/// <summary>
		/// USERNAME : 
		/// </summary>
		System.String  Username  { get; set; }
		
		/// <summary>
		/// PASSWORD_SALT : 
		/// </summary>
		System.String  PasswordSalt  { get; set; }
		
		/// <summary>
		/// PASSWORD_HASH : 
		/// </summary>
		System.String  PasswordHash  { get; set; }
		
		/// <summary>
		/// SECURITY_QS : 
		/// </summary>
		System.String  SecurityQs  { get; set; }
		
		/// <summary>
		/// SECURITY_QS_ANS_SALT : 
		/// </summary>
		System.String  SecurityQsAnsSalt  { get; set; }
		
		/// <summary>
		/// SECURITY_QS_ANS_HASH : 
		/// </summary>
		System.String  SecurityQsAnsHash  { get; set; }
		
		/// <summary>
		/// ACTIVATION_CODE : 
		/// </summary>
		System.String  ActivationCode  { get; set; }
		
		/// <summary>
		/// ACTIVATION_FLG : 
		/// </summary>
		System.Decimal?  ActivationFlg  { get; set; }
		
		/// <summary>
		/// REG_DATE : 
		/// </summary>
		System.DateTime?  RegDate  { get; set; }
		
		/// <summary>
		/// FNAME_AR : 
		/// </summary>
		System.String  FnameAr  { get; set; }
		
		/// <summary>
		/// FNAME_EN : 
		/// </summary>
		System.String  FnameEn  { get; set; }
		
		/// <summary>
		/// MNAME_AR : 
		/// </summary>
		System.String  MnameAr  { get; set; }
		
		/// <summary>
		/// MNAME_EN : 
		/// </summary>
		System.String  MnameEn  { get; set; }
		
		/// <summary>
		/// LNAME_AR : 
		/// </summary>
		System.String  LnameAr  { get; set; }
		
		/// <summary>
		/// LNAME_EN : 
		/// </summary>
		System.String  LnameEn  { get; set; }
		
		/// <summary>
		/// FAMILY_AR : 
		/// </summary>
		System.String  FamilyAr  { get; set; }
		
		/// <summary>
		/// FAMILY_EN : 
		/// </summary>
		System.String  FamilyEn  { get; set; }
		
		/// <summary>
		/// GS_CODE_RELIGION_ID : 
		/// </summary>
		System.Decimal?  GsCodeReligionId  { get; set; }
		
		/// <summary>
		/// CPR : 
		/// </summary>
		System.String  Cpr  { get; set; }
		
		/// <summary>
		/// PASSPOR_NO : 
		/// </summary>
		System.String  PassporNo  { get; set; }
		
		/// <summary>
		/// PASSPOR_EXPIRE_DATE : 
		/// </summary>
		System.DateTime?  PassporExpireDate  { get; set; }
		
		/// <summary>
		/// BIRTHDATE : 
		/// </summary>
		System.DateTime?  Birthdate  { get; set; }
		
		/// <summary>
		/// PHOTO_PATH : 
		/// </summary>
		System.String  PhotoPath  { get; set; }
		
		/// <summary>
		/// GS_CDE_MARITAL_STATUS_ID : 
		/// </summary>
		System.Decimal?  GsCdeMaritalStatusId  { get; set; }
		
		/// <summary>
		/// GS_CODE_GENDER_ID : 
		/// </summary>
		System.Decimal?  GsCodeGenderId  { get; set; }
		
		/// <summary>
		/// WORK_FLG : 
		/// </summary>
		System.Decimal?  WorkFlg  { get; set; }
		
		/// <summary>
		/// GS_COUNTRY_NODE_ID : الجنسية
		/// </summary>
		System.Decimal?  GsCountryNodeId  { get; set; }
		
		/// <summary>
		/// FULL_NAME_AR : 
		/// </summary>
		System.String  FullNameAr  { get; set; }
		
		/// <summary>
		/// FULL_NAME_EN : 
		/// </summary>
		System.String  FullNameEn  { get; set; }
		
		/// <summary>
		/// RESIDENT_ID : 
		/// </summary>
		System.String  ResidentId  { get; set; }
		
		/// <summary>
		/// RESIDENT_EXPIRE_DATE : 
		/// </summary>
		System.DateTime?  ResidentExpireDate  { get; set; }
		
		/// <summary>
		/// GS_BIRTH_COUNTRY_NODE_ID : مكان الميلاد
		/// </summary>
		System.Decimal?  GsBirthCountryNodeId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal?  EdStudId  { get; set; }
		
		/// <summary>
		/// LOYALTY_FLG : 
		/// </summary>
		System.Decimal?  LoyaltyFlg  { get; set; }
		
		/// <summary>
		/// GS_CODE_LANGUAGE_ID : لغة التخصص
		/// </summary>
		System.Decimal?  GsCodeLanguageId  { get; set; }
		
		/// <summary>
		/// PASSPOR_ISSUE_DATE : 
		/// </summary>
		System.DateTime?  PassporIssueDate  { get; set; }
		
		/// <summary>
		/// SPECIAL_NEED_FLG : 
		/// </summary>
		System.Boolean?  SpecialNeedFlg  { get; set; }
		
		/// <summary>
		/// IDENT_ISSUE_DATE : 
		/// </summary>
		System.DateTime?  IdentIssueDate  { get; set; }
		
		/// <summary>
		/// IDENT_EXPIRE_DATE : 
		/// </summary>
		System.DateTime?  IdentExpireDate  { get; set; }
		
		/// <summary>
		/// IDENT_ISSUE_PLC : مكان اصدار
		/// </summary>
		System.String  IdentIssuePlc  { get; set; }
		
		/// <summary>
		/// VISA_NUMBER : رقم التأشيرة
		/// </summary>
		System.String  VisaNumber  { get; set; }
		
		/// <summary>
		/// VISA_ISSUE_DATE : 
		/// </summary>
		System.DateTime?  VisaIssueDate  { get; set; }
		
		/// <summary>
		/// VISA_EXPIRE_DATE : 
		/// </summary>
		System.DateTime?  VisaExpireDate  { get; set; }
		
		/// <summary>
		/// LAST_DATE : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// SE_USER_ID : 
		/// </summary>
		System.Decimal?  SeUserId  { get; set; }
		
		/// <summary>
		/// ED_CDE_SOCIAL_AFFAIR_ID : نوع الشؤن الاجتماعية CSS
		/// </summary>
		System.Int32?  EdCdeSocialAffairId  { get; set; }
		
		/// <summary>
		/// PUC_FLG : كفيل
		/// </summary>
		System.Boolean?  PucFlg  { get; set; }
		
		/// <summary>
		/// NO_CHILD : PG Ejust
		/// </summary>
		System.Int32?  NoChild  { get; set; }
		
		/// <summary>
		/// HIGH_QUAL_FLG : Deraya UG طالب حاصل على بكالريوس
		/// </summary>
		System.Boolean?  HighQualFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svUserMessageAdmApplicantId
		/// </summary>	
		TList<SvUserMessage> SvUserMessageCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppRegHistoryAdmApplicantId
		/// </summary>	
		TList<AdmAppRegHistory> AdmAppRegHistoryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svSrvyRespondQstnAdmApplicantId
		/// </summary>	
		TList<SvSrvyRespondQstn> SvSrvyRespondQstnCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admScholorshipAdmApplicantId
		/// </summary>	
		TList<AdmScholorship> AdmScholorshipCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admOutboxOutMsgAppToGetByOutMsgAppFrom
		/// </summary>	
		TList<AdmOutbox> AdmOutboxCollectionGetByOutMsgAppFrom {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudGuardAdmApplicantId
		/// </summary>	
		TList<EdStudGuard> EdStudGuardCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeRefndStdReqAdmApplicantId
		/// </summary>	
		TList<FeeRefndStdReq> FeeRefndStdReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppPlaceExamCourseAdmApplicantId
		/// </summary>	
		TList<AdmAppPlaceExamCourse> AdmAppPlaceExamCourseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppHonorAdmApplicantId
		/// </summary>	
		TList<AdmAppHonor> AdmAppHonorCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppDocAdmApplicantId
		/// </summary>	
		TList<AdmAppDoc> AdmAppDocCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudNoteAdmApplicantId
		/// </summary>	
		TList<EdStudNote> EdStudNoteCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudActivityAdmApplicantId
		/// </summary>	
		TList<EdStudActivity> EdStudActivityCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admOutboxOutMsgAppToGetByOutMsgAppTo
		/// </summary>	
		TList<AdmOutbox> AdmOutboxCollectionGetByOutMsgAppTo {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admRsrvdCodeAdmApplicantId
		/// </summary>	
		TList<AdmRsrvdCode> AdmRsrvdCodeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svMessageAdmApplicantId
		/// </summary>	
		TList<SvMessage> SvMessageCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppInfoAdmApplicantId
		/// </summary>	
		TList<AdmAppInfo> AdmAppInfoCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppCourseCompAdmApplicantId
		/// </summary>	
		TList<AdmAppCourseComp> AdmAppCourseCompCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsAddressDtlAdmApplicantId
		/// </summary>	
		TList<GsAddressDtl> GsAddressDtlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudLangAdmApplicantId
		/// </summary>	
		TList<EdStudLang> EdStudLangCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppPrefAdmApplicantId
		/// </summary>	
		TList<AdmAppPref> AdmAppPrefCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppPlacementExamAdmApplicantId
		/// </summary>	
		TList<AdmAppPlacementExam> AdmAppPlacementExamCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudQualAdmApplicantId
		/// </summary>	
		TList<EdStudQual> EdStudQualCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppGuardianAdmApplicantId
		/// </summary>	
		TList<AdmAppGuardian> AdmAppGuardianCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudVoucherAdmApplicantId
		/// </summary>	
		TList<FeeStudVoucher> FeeStudVoucherCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudContactMethodAdmApplicantId
		/// </summary>	
		TList<EdStudContactMethod> EdStudContactMethodCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admInboxInMsgAppToGetByInMsgAppFrom
		/// </summary>	
		TList<AdmInbox> AdmInboxCollectionGetByInMsgAppFrom {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppProcStepsAdmApplicantId
		/// </summary>	
		TList<AdmAppProcSteps> AdmAppProcStepsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppEssayAdmApplicantId
		/// </summary>	
		TList<AdmAppEssay> AdmAppEssayCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppLanguagesAdmApplicantId
		/// </summary>	
		TList<AdmAppLanguages> AdmAppLanguagesCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppDisabilityAdmApplicantId
		/// </summary>	
		TList<AdmAppDisability> AdmAppDisabilityCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppMediaAdmApplicantId
		/// </summary>	
		TList<AdmAppMedia> AdmAppMediaCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppFeesAdmApplicantId
		/// </summary>	
		TList<AdmAppFees> AdmAppFeesCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admEnglishProficiencyAdmApplicantId
		/// </summary>	
		TList<AdmEnglishProficiency> AdmEnglishProficiencyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admInboxInMsgAppToGetByInMsgAppTo
		/// </summary>	
		TList<AdmInbox> AdmInboxCollectionGetByInMsgAppTo {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppWorkExperAdmApplicantId
		/// </summary>	
		TList<AdmAppWorkExper> AdmAppWorkExperCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppLtrRecomAdmApplicantId
		/// </summary>	
		TList<AdmAppLtrRecom> AdmAppLtrRecomCollection {  get;  set;}	

		#endregion Data Properties

	}
}

