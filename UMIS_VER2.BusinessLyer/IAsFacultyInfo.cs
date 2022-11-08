﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'AS_FACULTY_INFO' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAsFacultyInfo 
	{
		/// <summary>			
		/// AS_FACULTY_INFO_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "AS_FACULTY_INFO"</remarks>
		System.Decimal AsFacultyInfoId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAsFacultyInfoId { get; set; }
			
		
		
		/// <summary>
		/// GS_COUNTRY_NODE_ID : 
		/// </summary>
		System.Decimal?  GsCountryNodeId  { get; set; }
		
		/// <summary>
		/// FACULTY_ADDRESS : 
		/// </summary>
		System.String  FacultyAddress  { get; set; }
		
		/// <summary>
		/// FACULTY_DESCR_AR : 
		/// </summary>
		System.String  FacultyDescrAr  { get; set; }
		
		/// <summary>
		/// FACULTY_DESCR_EN : 
		/// </summary>
		System.String  FacultyDescrEn  { get; set; }
		
		/// <summary>
		/// CON_DATE : 
		/// </summary>
		System.DateTime?  ConDate  { get; set; }
		
		/// <summary>
		/// FACULTY_LOGO : 
		/// </summary>
		System.String  FacultyLogo  { get; set; }
		
		/// <summary>
		/// NOTATION : 
		/// </summary>
		System.Int32?  Notation  { get; set; }
		
		/// <summary>
		/// FACULTY_CODE : 
		/// </summary>
		System.String  FacultyCode  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edBranchRuleAsFacultyInfoId
		/// </summary>	
		TList<EdBranchRule> EdBranchRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saMilitaryStatusAsFacultyInfoId
		/// </summary>	
		TList<SaMilitaryStatus> SaMilitaryStatusCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scStudGroupAsFacultyInfoId
		/// </summary>	
		TList<ScStudGroup> ScStudGroupCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saRelativeAsFacultyInfoId
		/// </summary>	
		TList<SaRelative> SaRelativeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _seBlockTransAsFacultyInfoId
		/// </summary>	
		TList<SeBlockTrans> SeBlockTransCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _spoSponsorStudAsFacultyInfoId
		/// </summary>	
		TList<SpoSponsorStud> SpoSponsorStudCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCodeCourseAssessAsFacultyInfoId
		/// </summary>	
		TList<EdCodeCourseAssess> EdCodeCourseAssessCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCodeDischargeHAsFacultyInfoId
		/// </summary>	
		TList<EdCodeDischargeH> EdCodeDischargeHCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saCdeAcadLoadAsFacultyInfoId
		/// </summary>	
		TList<SaCdeAcadLoad> SaCdeAcadLoadCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saEmpHierarchyAsFacultyInfoId
		/// </summary>	
		TList<SaEmpHierarchy> SaEmpHierarchyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCodeCourseTeachingAsFacultyInfoId
		/// </summary>	
		TList<EdCodeCourseTeaching> EdCodeCourseTeachingCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegPreAsFacultyInfoId
		/// </summary>	
		TList<EdStudCourseRegPre> EdStudCourseRegPreCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudExcuseAsFacultyInfoId
		/// </summary>	
		TList<EdStudExcuse> EdStudExcuseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCommAsFacultyInfoId
		/// </summary>	
		TList<GsComm> GsCommCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saJobStartStatmentAsFacultyInfoId
		/// </summary>	
		TList<SaJobStartStatment> SaJobStartStatmentCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudAcadWarnAsFacultyInfoId
		/// </summary>	
		TList<EdStudAcadWarn> EdStudAcadWarnCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisGrantDegreeAsFacultyInfoId
		/// </summary>	
		TList<PgThesisGrantDegree> PgThesisGrantDegreeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCourseTopicAsFacultyInfoId
		/// </summary>	
		TList<EdCourseTopic> EdCourseTopicCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeFineAsFacultyInfoId
		/// </summary>	
		TList<FeeFine> FeeFineCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudQualSubjectAsFacultyInfoId
		/// </summary>	
		TList<EdStudQualSubject> EdStudQualSubjectCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsCourseToAsFacultyInfoId
		/// </summary>	
		TList<EdStudIntTrnsCourseTo> EdStudIntTrnsCourseToCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudNatSimilarityRequestAsFacultyInfoId
		/// </summary>	
		TList<FeeStudNatSimilarityRequest> FeeStudNatSimilarityRequestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saJobStoppageAsFacultyInfoId
		/// </summary>	
		TList<SaJobStoppage> SaJobStoppageCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPromotionRequestAsFacultyInfoId
		/// </summary>	
		TList<SaPromotionRequest> SaPromotionRequestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coScheduleDetailAsFacultyInfoId
		/// </summary>	
		TList<CoScheduleDetail> CoScheduleDetailCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saVacationBalanceHAsFacultyInfoId
		/// </summary>	
		TList<SaVacationBalanceH> SaVacationBalanceHCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPublicationAsFacultyInfoId
		/// </summary>	
		TList<SaPublication> SaPublicationCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeFacultyRuleAsFacultyInfoId
		/// </summary>	
		TList<FeeFacultyRule> FeeFacultyRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svPollHdrAsFacultyInfoId
		/// </summary>	
		TList<SvPollHdr> SvPollHdrCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudVoucherAsFacultyInfoId
		/// </summary>	
		TList<FeeStudVoucher> FeeStudVoucherCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edAcadYearFacultyAsFacultyInfoId
		/// </summary>	
		TList<EdAcadYearFaculty> EdAcadYearFacultyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _rsrchStudPostponeReqAsFacultyInfoId
		/// </summary>	
		TList<RsrchStudPostponeReq> RsrchStudPostponeReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _seUserCrsAssessAsFacultyInfoId
		/// </summary>	
		TList<SeUserCrsAssess> SeUserCrsAssessCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudTransFromReqAsFacultyInfoId
		/// </summary>	
		TList<EdStudTransFromReq> EdStudTransFromReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCdeClrncItemFacAsFacultyInfoId
		/// </summary>	
		TList<GsCdeClrncItemFac> GsCdeClrncItemFacCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saRaiseAsFacultyInfoId
		/// </summary>	
		TList<SaRaise> SaRaiseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsStateToAsFacultyInfoId
		/// </summary>	
		TList<EdStudIntTrnsStateTo> EdStudIntTrnsStateToCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admPrecondQualAsFacultyInfoId
		/// </summary>	
		TList<AdmPrecondQual> AdmPrecondQualCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admRatingParametersMajorsAsFacultyInfoId
		/// </summary>	
		TList<AdmRatingParametersMajors> AdmRatingParametersMajorsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSchdlPeriodAsFacultyInfoId
		/// </summary>	
		TList<ScSchdlPeriod> ScSchdlPeriodCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudRetrieveRequestAsFacultyInfoId
		/// </summary>	
		TList<FeeStudRetrieveRequest> FeeStudRetrieveRequestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saExtDelAsFacultyInfoId
		/// </summary>	
		TList<SaExtDel> SaExtDelCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scHallRsrvAsFacultyInfoId
		/// </summary>	
		TList<ScHallRsrv> ScHallRsrvCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edResidencyStudAsFacultyInfoId
		/// </summary>	
		TList<EdResidencyStud> EdResidencyStudCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseChngAsFacultyInfoId
		/// </summary>	
		TList<EdStudCourseChng> EdStudCourseChngCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCourseAsFacultyInfoId
		/// </summary>	
		TList<EdCourse> EdCourseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svAutoMsgTmpltAsFacultyInfoId
		/// </summary>	
		TList<SvAutoMsgTmplt> SvAutoMsgTmpltCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleRsrvAsFacultyInfoId
		/// </summary>	
		TList<ScScheduleRsrv> ScScheduleRsrvCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saScCommDecisionAsFacultyInfoId
		/// </summary>	
		TList<SaScCommDecision> SaScCommDecisionCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTransPrefAsFacultyInfoId
		/// </summary>	
		TList<EdStudIntTransPref> EdStudIntTransPrefCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saTrainingCourseAsFacultyInfoId
		/// </summary>	
		TList<SaTrainingCourse> SaTrainingCourseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saMiltaryAsFacultyInfoId
		/// </summary>	
		TList<SaMiltary> SaMiltaryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeInstlmntRuleAsFacultyInfoId
		/// </summary>	
		TList<FeeInstlmntRule> FeeInstlmntRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admCompetitiveAvgAsFacultyInfoId
		/// </summary>	
		TList<AdmCompetitiveAvg> AdmCompetitiveAvgCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _rsrchStudRegisterAsFacultyInfoId
		/// </summary>	
		TList<RsrchStudRegister> RsrchStudRegisterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _seFormAsFacultyInfoId
		/// </summary>	
		TList<SeForm> SeFormCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edOfferingCourseAsFacultyInfoId
		/// </summary>	
		TList<EdOfferingCourse> EdOfferingCourseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeLimitRuleAsFacultyInfoId
		/// </summary>	
		TList<FeeLimitRule> FeeLimitRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saExperienceAsFacultyInfoId
		/// </summary>	
		TList<SaExperience> SaExperienceCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saServTerminAsFacultyInfoId
		/// </summary>	
		TList<SaServTermin> SaServTerminCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edOfferingAsFacultyInfoId
		/// </summary>	
		TList<EdOffering> EdOfferingCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppPrefAsFacultyInfoId
		/// </summary>	
		TList<AdmAppPref> AdmAppPrefCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudAbsenceAsFacultyInfoId
		/// </summary>	
		TList<EdStudAbsence> EdStudAbsenceCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saWarningAsFacultyInfoId
		/// </summary>	
		TList<SaWarning> SaWarningCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudStateTempAsFacultyInfoId
		/// </summary>	
		TList<EdStudStateTemp> EdStudStateTempCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPromotionAsFacultyInfoId
		/// </summary>	
		TList<SaPromotion> SaPromotionCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svStaffEvlAsFacultyInfoId
		/// </summary>	
		TList<SvStaffEvl> SvStaffEvlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _spoSponsorOfferAsFacultyInfoId
		/// </summary>	
		TList<SpoSponsorOffer> SpoSponsorOfferCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svStudAskAdvAsFacultyInfoId
		/// </summary>	
		TList<SvStudAskAdv> SvStudAskAdvCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saVacationAsFacultyInfoId
		/// </summary>	
		TList<SaVacation> SaVacationCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saEmploymentAsFacultyInfoId
		/// </summary>	
		TList<SaEmployment> SaEmploymentCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saFinStatmentAsFacultyInfoId
		/// </summary>	
		TList<SaFinStatment> SaFinStatmentCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCourseOutcomesTopicsAsFacultyInfoId
		/// </summary>	
		TList<EdCourseOutcomesTopics> EdCourseOutcomesTopicsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edPrintReqAsFacultyInfoId
		/// </summary>	
		TList<EdPrintReq> EdPrintReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudFeeItemAsFacultyInfoId
		/// </summary>	
		TList<FeeStudFeeItem> FeeStudFeeItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCodeLevelAsFacultyInfoId
		/// </summary>	
		TList<EdCodeLevel> EdCodeLevelCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scGroupInfoAsFacultyInfoId
		/// </summary>	
		TList<ScGroupInfo> ScGroupInfoCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPersonIdAsFacultyInfoId
		/// </summary>	
		TList<SaPersonId> SaPersonIdCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saStfMemberAsFacultyInfoId
		/// </summary>	
		TList<SaStfMember> SaStfMemberCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admCodeEngTestAsFacultyInfoId
		/// </summary>	
		TList<AdmCodeEngTest> AdmCodeEngTestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeRefndStdReqAsFacultyInfoId
		/// </summary>	
		TList<FeeRefndStdReq> FeeRefndStdReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsCourseFromAsFacultyInfoId
		/// </summary>	
		TList<EdStudIntTrnsCourseFrom> EdStudIntTrnsCourseFromCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coControlRoomAsFacultyInfoId
		/// </summary>	
		TList<CoControlRoom> CoControlRoomCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudBranchPrefAsFacultyInfoId
		/// </summary>	
		TList<EdStudBranchPref> EdStudBranchPrefCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudDiscContinueAsFacultyInfoId
		/// </summary>	
		TList<FeeStudDiscContinue> FeeStudDiscContinueCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudInstallmentAsFacultyInfoId
		/// </summary>	
		TList<FeeStudInstallment> FeeStudInstallmentCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudGroupAsFacultyInfoId
		/// </summary>	
		TList<EdStudGroup> EdStudGroupCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegAsFacultyInfoId
		/// </summary>	
		TList<EdStudCourseReg> EdStudCourseRegCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saScQualAsFacultyInfoId
		/// </summary>	
		TList<SaScQual> SaScQualCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _mltOrgTreeAsFacultyInfoId
		/// </summary>	
		TList<MltOrgTree> MltOrgTreeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saSupervisingJobsAsFacultyInfoId
		/// </summary>	
		TList<SaSupervisingJobs> SaSupervisingJobsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edExamSchdlAsFacultyInfoId
		/// </summary>	
		TList<EdExamSchdl> EdExamSchdlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCodeApprovalFacultyAsFacultyInfoId
		/// </summary>	
		TList<GsCodeApprovalFaculty> GsCodeApprovalFacultyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudAcadmicAdvAsFacultyInfoId
		/// </summary>	
		TList<EdStudAcadmicAdv> EdStudAcadmicAdvCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saJobActivityAsFacultyInfoId
		/// </summary>	
		TList<SaJobActivity> SaJobActivityCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudSemesterTempAsFacultyInfoId
		/// </summary>	
		TList<EdStudSemesterTemp> EdStudSemesterTempCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCodeApprovalAsFacultyInfoId
		/// </summary>	
		TList<GsCodeApproval> GsCodeApprovalCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entityMainAsFacultyInfoId
		/// </summary>	
		TList<EntityMain> EntityMainCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudInstallmentRequestAsFacultyInfoId
		/// </summary>	
		TList<FeeStudInstallmentRequest> FeeStudInstallmentRequestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegAssessAsFacultyInfoId
		/// </summary>	
		TList<EdStudCourseRegAssess> EdStudCourseRegAssessCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saCandReleaseAsFacultyInfoId
		/// </summary>	
		TList<SaCandRelease> SaCandReleaseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entPolcyGrdngHdrAsFacultyInfoId
		/// </summary>	
		TList<EntPolcyGrdngHdr> EntPolcyGrdngHdrCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudSemesterAsFacultyInfoId
		/// </summary>	
		TList<EdStudSemester> EdStudSemesterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saScResearchAsFacultyInfoId
		/// </summary>	
		TList<SaScResearch> SaScResearchCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edResultApproveAsFacultyInfoId
		/// </summary>	
		TList<EdResultApprove> EdResultApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _spoSponsorStudSemesterAsFacultyInfoId
		/// </summary>	
		TList<SpoSponsorStudSemester> SpoSponsorStudSemesterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edProjectAsFacultyInfoId
		/// </summary>	
		TList<EdProject> EdProjectCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coCrsRsltRaiseAsFacultyInfoId
		/// </summary>	
		TList<CoCrsRsltRaise> CoCrsRsltRaiseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scScheduleDtlAsFacultyInfoId
		/// </summary>	
		TList<ScScheduleDtl> ScScheduleDtlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudFacultyAsFacultyInfoId
		/// </summary>	
		TList<EdStudFaculty> EdStudFacultyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSectionGroupHdrAsFacultyInfoId
		/// </summary>	
		TList<ScSectionGroupHdr> ScSectionGroupHdrCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsStateFromAsFacultyInfoId
		/// </summary>	
		TList<EdStudIntTrnsStateFrom> EdStudIntTrnsStateFromCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeCdeDiscTypeAsFacultyInfoId
		/// </summary>	
		TList<FeeCdeDiscType> FeeCdeDiscTypeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edGraduationAwardAsFacultyInfoId
		/// </summary>	
		TList<EdGraduationAward> EdGraduationAwardCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scBuildingAsFacultyInfoId
		/// </summary>	
		TList<ScBuilding> ScBuildingCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudGrantTempAsFacultyInfoId
		/// </summary>	
		TList<EdStudGrantTemp> EdStudGrantTempCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edInttransRuleAsFacultyInfoId
		/// </summary>	
		TList<EdInttransRule> EdInttransRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgOfferingAsFacultyInfoId
		/// </summary>	
		TList<PgOffering> PgOfferingCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudStateAsFacultyInfoId
		/// </summary>	
		TList<EdStudState> EdStudStateCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPunishmentAsFacultyInfoId
		/// </summary>	
		TList<SaPunishment> SaPunishmentCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saVacationRenewAsFacultyInfoId
		/// </summary>	
		TList<SaVacationRenew> SaVacationRenewCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edBylawAsFacultyInfoId
		/// </summary>	
		TList<EdBylaw> EdBylawCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saPromotionCondStsfAsFacultyInfoId
		/// </summary>	
		TList<SaPromotionCondStsf> SaPromotionCondStsfCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saCandReleaseDetailAsFacultyInfoId
		/// </summary>	
		TList<SaCandReleaseDetail> SaCandReleaseDetailCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsApprovalHAsFacultyInfoId
		/// </summary>	
		TList<GsApprovalH> GsApprovalHCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudAbsFwAsFacultyInfoId
		/// </summary>	
		TList<EdStudAbsFw> EdStudAbsFwCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saTransferAsFacultyInfoId
		/// </summary>	
		TList<SaTransfer> SaTransferCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsAsFacultyInfoId
		/// </summary>	
		TList<EdStudIntTrns> EdStudIntTrnsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saCodeSuperviseJobAsFacultyInfoId
		/// </summary>	
		TList<SaCodeSuperviseJob> SaCodeSuperviseJobCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudDiscAsFacultyInfoId
		/// </summary>	
		TList<FeeStudDisc> FeeStudDiscCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseCompAsFacultyInfoId
		/// </summary>	
		TList<EdStudCourseComp> EdStudCourseCompCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudNoteAsFacultyInfoId
		/// </summary>	
		TList<EdStudNote> EdStudNoteCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saDocOfFileAsFacultyInfoId
		/// </summary>	
		TList<SaDocOfFile> SaDocOfFileCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _svStudAskAdvReAsFacultyInfoId
		/// </summary>	
		TList<SvStudAskAdvRe> SvStudAskAdvReCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAcceptanceCategoryAsFacultyInfoId
		/// </summary>	
		TList<AdmAcceptanceCategory> AdmAcceptanceCategoryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saVacationBalanceAsFacultyInfoId
		/// </summary>	
		TList<SaVacationBalance> SaVacationBalanceCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeStudItemCnclAsFacultyInfoId
		/// </summary>	
		TList<FeeStudItemCncl> FeeStudItemCnclCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisStudAsFacultyInfoId
		/// </summary>	
		TList<PgThesisStud> PgThesisStudCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsApprovalDAsFacultyInfoId
		/// </summary>	
		TList<GsApprovalD> GsApprovalDCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudLatenessAsFacultyInfoId
		/// </summary>	
		TList<EdStudLateness> EdStudLatenessCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _gsCodeRptSignatureAsFacultyInfoId
		/// </summary>	
		TList<GsCodeRptSignature> GsCodeRptSignatureCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _saResearchTeamAsFacultyInfoId
		/// </summary>	
		TList<SaResearchTeam> SaResearchTeamCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppTransReqAsFacultyInfoId
		/// </summary>	
		TList<AdmAppTransReq> AdmAppTransReqCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemAgendaDtlAsFacultyInfoId
		/// </summary>	
		TList<EdSemAgendaDtl> EdSemAgendaDtlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCrsFreeRstrctdAsFacultyInfoId
		/// </summary>	
		TList<EdCrsFreeRstrctd> EdCrsFreeRstrctdCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudGrantDegreeAsFacultyInfoId
		/// </summary>	
		TList<EdStudGrantDegree> EdStudGrantDegreeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudGroupPreAsFacultyInfoId
		/// </summary>	
		TList<EdStudGroupPre> EdStudGroupPreCollection {  get;  set;}	

		#endregion Data Properties

	}
}


