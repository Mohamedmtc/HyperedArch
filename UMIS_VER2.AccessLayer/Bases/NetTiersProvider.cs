#region Using directives

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// The base class to implements to create a .NetTiers provider.
	///</summary>
	public abstract class NetTiersProvider : NetTiersProviderBase
	{
		
		///<summary>
		/// Current MilCodeCourseProviderBase instance.
		///</summary>
		public virtual MilCodeCourseProviderBase MilCodeCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomApartmentProviderBase instance.
		///</summary>
		public virtual AccomApartmentProviderBase AccomApartmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltCdeBhvrAttndcRltdProviderBase instance.
		///</summary>
		public virtual MltCdeBhvrAttndcRltdProviderBase MltCdeBhvrAttndcRltdProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudVaccProviderBase instance.
		///</summary>
		public virtual MdiStudVaccProviderBase MdiStudVaccProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltCdeOrgTypeProviderBase instance.
		///</summary>
		public virtual MltCdeOrgTypeProviderBase MltCdeOrgTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudRecordProviderBase instance.
		///</summary>
		public virtual MdiStudRecordProviderBase MdiStudRecordProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudSignProviderBase instance.
		///</summary>
		public virtual MdiStudSignProviderBase MdiStudSignProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudHosptlProviderBase instance.
		///</summary>
		public virtual MdiStudHosptlProviderBase MdiStudHosptlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudInvstgProviderBase instance.
		///</summary>
		public virtual MdiStudInvstgProviderBase MdiStudInvstgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudLifeStyleProviderBase instance.
		///</summary>
		public virtual MdiStudLifeStyleProviderBase MdiStudLifeStyleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudProblemProviderBase instance.
		///</summary>
		public virtual MdiStudProblemProviderBase MdiStudProblemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltCdeOutRsnProviderBase instance.
		///</summary>
		public virtual MltCdeOutRsnProviderBase MltCdeOutRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltCdeStudDegreeProviderBase instance.
		///</summary>
		public virtual MltCdeStudDegreeProviderBase MltCdeStudDegreeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltLvlBhvrAttndcProviderBase instance.
		///</summary>
		public virtual MltLvlBhvrAttndcProviderBase MltLvlBhvrAttndcProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCdeConfTypeProviderBase instance.
		///</summary>
		public virtual PgCdeConfTypeProviderBase PgCdeConfTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCdeRptRecommendProviderBase instance.
		///</summary>
		public virtual PgCdeRptRecommendProviderBase PgCdeRptRecommendProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCdeStfRoleProviderBase instance.
		///</summary>
		public virtual PgCdeStfRoleProviderBase PgCdeStfRoleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltOrgTreeProviderBase instance.
		///</summary>
		public virtual MltOrgTreeProviderBase MltOrgTreeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCdeCommRecommendProviderBase instance.
		///</summary>
		public virtual PgCdeCommRecommendProviderBase PgCdeCommRecommendProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltStudInfoProviderBase instance.
		///</summary>
		public virtual MltStudInfoProviderBase MltStudInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltRptDayStudStsProviderBase instance.
		///</summary>
		public virtual MltRptDayStudStsProviderBase MltRptDayStudStsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltRptDayMissionProviderBase instance.
		///</summary>
		public virtual MltRptDayMissionProviderBase MltRptDayMissionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltRptDayOutStudProviderBase instance.
		///</summary>
		public virtual MltRptDayOutStudProviderBase MltRptDayOutStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltRptDayOutProviderBase instance.
		///</summary>
		public virtual MltRptDayOutProviderBase MltRptDayOutProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudFamHstryProviderBase instance.
		///</summary>
		public virtual MdiStudFamHstryProviderBase MdiStudFamHstryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiStudClnqProviderBase instance.
		///</summary>
		public virtual MdiStudClnqProviderBase MdiStudClnqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeVaccProviderBase instance.
		///</summary>
		public virtual MdiCdeVaccProviderBase MdiCdeVaccProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegFpStaffAbsenceDtlProviderBase instance.
		///</summary>
		public virtual IntegFpStaffAbsenceDtlProviderBase IntegFpStaffAbsenceDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegLogProviderBase instance.
		///</summary>
		public virtual IntegLogProviderBase IntegLogProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegMoodleEnrolProviderBase instance.
		///</summary>
		public virtual IntegMoodleEnrolProviderBase IntegMoodleEnrolProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegMoodleUnenrolProviderBase instance.
		///</summary>
		public virtual IntegMoodleUnenrolProviderBase IntegMoodleUnenrolProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegFpStaffAbsenceProviderBase instance.
		///</summary>
		public virtual IntegFpStaffAbsenceProviderBase IntegFpStaffAbsenceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MltStudBhvrAttndcProviderBase instance.
		///</summary>
		public virtual MltStudBhvrAttndcProviderBase MltStudBhvrAttndcProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegFinanceProviderBase instance.
		///</summary>
		public virtual IntegFinanceProviderBase IntegFinanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsMilitaryRegionProviderBase instance.
		///</summary>
		public virtual GsMilitaryRegionProviderBase GsMilitaryRegionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsSysPivotProviderBase instance.
		///</summary>
		public virtual GsSysPivotProviderBase GsSysPivotProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current HrDepartmentProviderBase instance.
		///</summary>
		public virtual HrDepartmentProviderBase HrDepartmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegCdeErrorTypeProviderBase instance.
		///</summary>
		public virtual IntegCdeErrorTypeProviderBase IntegCdeErrorTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegMoodleUpdateStaffProviderBase instance.
		///</summary>
		public virtual IntegMoodleUpdateStaffProviderBase IntegMoodleUpdateStaffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegMoodleUpdateStudProviderBase instance.
		///</summary>
		public virtual IntegMoodleUpdateStudProviderBase IntegMoodleUpdateStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeSignCatProviderBase instance.
		///</summary>
		public virtual MdiCdeSignCatProviderBase MdiCdeSignCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeLifeStyleProviderBase instance.
		///</summary>
		public virtual MdiCdeLifeStyleProviderBase MdiCdeLifeStyleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeProblemProviderBase instance.
		///</summary>
		public virtual MdiCdeProblemProviderBase MdiCdeProblemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeInvstgProviderBase instance.
		///</summary>
		public virtual MdiCdeInvstgProviderBase MdiCdeInvstgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeSignProviderBase instance.
		///</summary>
		public virtual MdiCdeSignProviderBase MdiCdeSignProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeHosptlProviderBase instance.
		///</summary>
		public virtual MdiCdeHosptlProviderBase MdiCdeHosptlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MdiCdeDiseaseProviderBase instance.
		///</summary>
		public virtual MdiCdeDiseaseProviderBase MdiCdeDiseaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegUserAdLogHdrProviderBase instance.
		///</summary>
		public virtual IntegUserAdLogHdrProviderBase IntegUserAdLogHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegPaymentUpayProviderBase instance.
		///</summary>
		public virtual IntegPaymentUpayProviderBase IntegPaymentUpayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegSemOpenCloseProviderBase instance.
		///</summary>
		public virtual IntegSemOpenCloseProviderBase IntegSemOpenCloseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCdeThesisStatusProviderBase instance.
		///</summary>
		public virtual PgCdeThesisStatusProviderBase PgCdeThesisStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current IntegUserAdLogDtlProviderBase instance.
		///</summary>
		public virtual IntegUserAdLogDtlProviderBase IntegUserAdLogDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current RsrchCdeTitleProviderBase instance.
		///</summary>
		public virtual RsrchCdeTitleProviderBase RsrchCdeTitleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgOfferingProviderBase instance.
		///</summary>
		public virtual PgOfferingProviderBase PgOfferingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCdeAdminJobProviderBase instance.
		///</summary>
		public virtual SaCdeAdminJobProviderBase SaCdeAdminJobProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgOfferingTopicProviderBase instance.
		///</summary>
		public virtual PgOfferingTopicProviderBase PgOfferingTopicProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current RsrchCdeStatusProviderBase instance.
		///</summary>
		public virtual RsrchCdeStatusProviderBase RsrchCdeStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisDetailedSpecProviderBase instance.
		///</summary>
		public virtual PgThesisDetailedSpecProviderBase PgThesisDetailedSpecProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisGeneralSpecProviderBase instance.
		///</summary>
		public virtual PgThesisGeneralSpecProviderBase PgThesisGeneralSpecProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current RsrchStudRegisterProviderBase instance.
		///</summary>
		public virtual RsrchStudRegisterProviderBase RsrchStudRegisterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current RsrchStudRegisterDtlProviderBase instance.
		///</summary>
		public virtual RsrchStudRegisterDtlProviderBase RsrchStudRegisterDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current RsrchCommStaffRecomProviderBase instance.
		///</summary>
		public virtual RsrchCommStaffRecomProviderBase RsrchCommStaffRecomProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCandReleaseProviderBase instance.
		///</summary>
		public virtual SaCandReleaseProviderBase SaCandReleaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCodeChangeTypeProviderBase instance.
		///</summary>
		public virtual PgCodeChangeTypeProviderBase PgCodeChangeTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCandReleaseDetailProviderBase instance.
		///</summary>
		public virtual SaCandReleaseDetailProviderBase SaCandReleaseDetailProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCdeAcadLoadProviderBase instance.
		///</summary>
		public virtual SaCdeAcadLoadProviderBase SaCdeAcadLoadProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeDocTypeProviderBase instance.
		///</summary>
		public virtual SaCodeDocTypeProviderBase SaCodeDocTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeCourseTypeProviderBase instance.
		///</summary>
		public virtual SaCodeCourseTypeProviderBase SaCodeCourseTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeDocProviderBase instance.
		///</summary>
		public virtual SaCodeDocProviderBase SaCodeDocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeCourseScoreProviderBase instance.
		///</summary>
		public virtual SaCodeCourseScoreProviderBase SaCodeCourseScoreProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisStudProviderBase instance.
		///</summary>
		public virtual PgThesisStudProviderBase PgThesisStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeCourseProviderBase instance.
		///</summary>
		public virtual SaCodeCourseProviderBase SaCodeCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeEmpMethodProviderBase instance.
		///</summary>
		public virtual SaCodeEmpMethodProviderBase SaCodeEmpMethodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeCommMemberTypeProviderBase instance.
		///</summary>
		public virtual SaCodeCommMemberTypeProviderBase SaCodeCommMemberTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCodeRsrchStrategyProviderBase instance.
		///</summary>
		public virtual PgCodeRsrchStrategyProviderBase PgCodeRsrchStrategyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisCommProviderBase instance.
		///</summary>
		public virtual PgThesisCommProviderBase PgThesisCommProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisCommApproveProviderBase instance.
		///</summary>
		public virtual PgThesisCommApproveProviderBase PgThesisCommApproveProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisCommMemberProviderBase instance.
		///</summary>
		public virtual PgThesisCommMemberProviderBase PgThesisCommMemberProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current RsrchStudPostponeReqProviderBase instance.
		///</summary>
		public virtual RsrchStudPostponeReqProviderBase RsrchStudPostponeReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgSubjectDefinitionProviderBase instance.
		///</summary>
		public virtual PgSubjectDefinitionProviderBase PgSubjectDefinitionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgStudTravelProviderBase instance.
		///</summary>
		public virtual PgStudTravelProviderBase PgStudTravelProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgStudTravelExtendProviderBase instance.
		///</summary>
		public virtual PgStudTravelExtendProviderBase PgStudTravelExtendProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgCodeSupervisorChgRsnProviderBase instance.
		///</summary>
		public virtual PgCodeSupervisorChgRsnProviderBase PgCodeSupervisorChgRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgExtMemberProviderBase instance.
		///</summary>
		public virtual PgExtMemberProviderBase PgExtMemberProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgStfRoleDegProviderBase instance.
		///</summary>
		public virtual PgStfRoleDegProviderBase PgStfRoleDegProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgStudConferenceProviderBase instance.
		///</summary>
		public virtual PgStudConferenceProviderBase PgStudConferenceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgStudPublishProviderBase instance.
		///</summary>
		public virtual PgStudPublishProviderBase PgStudPublishProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisCommRecommendProviderBase instance.
		///</summary>
		public virtual PgThesisCommRecommendProviderBase PgThesisCommRecommendProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisCommRptProviderBase instance.
		///</summary>
		public virtual PgThesisCommRptProviderBase PgThesisCommRptProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisDiscussionDateProviderBase instance.
		///</summary>
		public virtual PgThesisDiscussionDateProviderBase PgThesisDiscussionDateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisGrantDegreeProviderBase instance.
		///</summary>
		public virtual PgThesisGrantDegreeProviderBase PgThesisGrantDegreeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisStaffProviderBase instance.
		///</summary>
		public virtual PgThesisStaffProviderBase PgThesisStaffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisSeminarProviderBase instance.
		///</summary>
		public virtual PgThesisSeminarProviderBase PgThesisSeminarProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisNoteProviderBase instance.
		///</summary>
		public virtual PgThesisNoteProviderBase PgThesisNoteProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsMilitaryOfficeProviderBase instance.
		///</summary>
		public virtual GsMilitaryOfficeProviderBase GsMilitaryOfficeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisStudExtendProviderBase instance.
		///</summary>
		public virtual PgThesisStudExtendProviderBase PgThesisStudExtendProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisSupervisorCommApproveProviderBase instance.
		///</summary>
		public virtual PgThesisSupervisorCommApproveProviderBase PgThesisSupervisorCommApproveProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisValidityRptProviderBase instance.
		///</summary>
		public virtual PgThesisValidityRptProviderBase PgThesisValidityRptProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisStudRsrchStrtgyProviderBase instance.
		///</summary>
		public virtual PgThesisStudRsrchStrtgyProviderBase PgThesisStudRsrchStrtgyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisSupervisorRptProviderBase instance.
		///</summary>
		public virtual PgThesisSupervisorRptProviderBase PgThesisSupervisorRptProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisSupervisorCommProviderBase instance.
		///</summary>
		public virtual PgThesisSupervisorCommProviderBase PgThesisSupervisorCommProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisStudTopicProviderBase instance.
		///</summary>
		public virtual PgThesisStudTopicProviderBase PgThesisStudTopicProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisGrantStudProviderBase instance.
		///</summary>
		public virtual PgThesisGrantStudProviderBase PgThesisGrantStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgAttchdDocProviderBase instance.
		///</summary>
		public virtual PgAttchdDocProviderBase PgAttchdDocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PgThesisStudApproveProviderBase instance.
		///</summary>
		public virtual PgThesisStudApproveProviderBase PgThesisStudApproveProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCourseElectTypeProviderBase instance.
		///</summary>
		public virtual GsCourseElectTypeProviderBase GsCourseElectTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeDocProviderBase instance.
		///</summary>
		public virtual GsCdeDocProviderBase GsCdeDocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeActvtyTypeProviderBase instance.
		///</summary>
		public virtual GsCdeActvtyTypeProviderBase GsCdeActvtyTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeUserFundReqProviderBase instance.
		///</summary>
		public virtual FeeUserFundReqProviderBase FeeUserFundReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeUserBondReqProviderBase instance.
		///</summary>
		public virtual FeeUserBondReqProviderBase FeeUserBondReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeTreasuryReqProviderBase instance.
		///</summary>
		public virtual FeeTreasuryReqProviderBase FeeTreasuryReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeTreasuryItemProviderBase instance.
		///</summary>
		public virtual FeeTreasuryItemProviderBase FeeTreasuryItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeYearPrdBankProviderBase instance.
		///</summary>
		public virtual FeeYearPrdBankProviderBase FeeYearPrdBankProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsAgendaHolidayProviderBase instance.
		///</summary>
		public virtual GsAgendaHolidayProviderBase GsAgendaHolidayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeActvtyProviderBase instance.
		///</summary>
		public virtual GsCdeActvtyProviderBase GsCdeActvtyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeClrncReasonProviderBase instance.
		///</summary>
		public virtual GsCdeClrncReasonProviderBase GsCdeClrncReasonProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeClrncItemProviderBase instance.
		///</summary>
		public virtual GsCdeClrncItemProviderBase GsCdeClrncItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeCampusProviderBase instance.
		///</summary>
		public virtual GsCdeCampusProviderBase GsCdeCampusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeBloodProviderBase instance.
		///</summary>
		public virtual GsCdeBloodProviderBase GsCdeBloodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCountryNodeProviderBase instance.
		///</summary>
		public virtual GsCountryNodeProviderBase GsCountryNodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsApprovalHProviderBase instance.
		///</summary>
		public virtual GsApprovalHProviderBase GsApprovalHProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeRefundCodeProviderBase instance.
		///</summary>
		public virtual FeeRefundCodeProviderBase FeeRefundCodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsAttchdDocProviderBase instance.
		///</summary>
		public virtual GsAttchdDocProviderBase GsAttchdDocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsApprovalDProviderBase instance.
		///</summary>
		public virtual GsApprovalDProviderBase GsApprovalDProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudDiscContinueProviderBase instance.
		///</summary>
		public virtual FeeStudDiscContinueProviderBase FeeStudDiscContinueProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeSemesterAgendaProviderBase instance.
		///</summary>
		public virtual FeeSemesterAgendaProviderBase FeeSemesterAgendaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeRefundCodeDtlProviderBase instance.
		///</summary>
		public virtual FeeRefundCodeDtlProviderBase FeeRefundCodeDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeVoucherInvocProviderBase instance.
		///</summary>
		public virtual FeeVoucherInvocProviderBase FeeVoucherInvocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsAddressDtlProviderBase instance.
		///</summary>
		public virtual GsAddressDtlProviderBase GsAddressDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeRefndStdReqProviderBase instance.
		///</summary>
		public virtual FeeRefndStdReqProviderBase FeeRefndStdReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeHonorProviderBase instance.
		///</summary>
		public virtual GsCdeHonorProviderBase GsCdeHonorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeApprovalPnltyProviderBase instance.
		///</summary>
		public virtual GsCdeApprovalPnltyProviderBase GsCdeApprovalPnltyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeItemSemesterProviderBase instance.
		///</summary>
		public virtual FeeItemSemesterProviderBase FeeItemSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeFacultyProviderBase instance.
		///</summary>
		public virtual GsCdeFacultyProviderBase GsCdeFacultyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeClrncItemFacProviderBase instance.
		///</summary>
		public virtual GsCdeClrncItemFacProviderBase GsCdeClrncItemFacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeRefndStdDetProviderBase instance.
		///</summary>
		public virtual FeeRefndStdDetProviderBase FeeRefndStdDetProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeItemTrnsBlncProviderBase instance.
		///</summary>
		public virtual FeeItemTrnsBlncProviderBase FeeItemTrnsBlncProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudAllowanceProviderBase instance.
		///</summary>
		public virtual FeeStudAllowanceProviderBase FeeStudAllowanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeLimitRuleProviderBase instance.
		///</summary>
		public virtual FeeLimitRuleProviderBase FeeLimitRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudInstallmentRequestProviderBase instance.
		///</summary>
		public virtual FeeStudInstallmentRequestProviderBase FeeStudInstallmentRequestProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudBankProviderBase instance.
		///</summary>
		public virtual FeeStudBankProviderBase FeeStudBankProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudInstallmentProviderBase instance.
		///</summary>
		public virtual FeeStudInstallmentProviderBase FeeStudInstallmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudItemCnclProviderBase instance.
		///</summary>
		public virtual FeeStudItemCnclProviderBase FeeStudItemCnclProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudFundProviderBase instance.
		///</summary>
		public virtual FeeStudFundProviderBase FeeStudFundProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudFeeItemProviderBase instance.
		///</summary>
		public virtual FeeStudFeeItemProviderBase FeeStudFeeItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudDiscFeeItemProviderBase instance.
		///</summary>
		public virtual FeeStudDiscFeeItemProviderBase FeeStudDiscFeeItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudNatSimilarityRequestProviderBase instance.
		///</summary>
		public virtual FeeStudNatSimilarityRequestProviderBase FeeStudNatSimilarityRequestProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudDiscSemesterProviderBase instance.
		///</summary>
		public virtual FeeStudDiscSemesterProviderBase FeeStudDiscSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudPayPostponeProviderBase instance.
		///</summary>
		public virtual FeeStudPayPostponeProviderBase FeeStudPayPostponeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudDiscProviderBase instance.
		///</summary>
		public virtual FeeStudDiscProviderBase FeeStudDiscProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudVoucherProviderBase instance.
		///</summary>
		public virtual FeeStudVoucherProviderBase FeeStudVoucherProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudCoursesItemProviderBase instance.
		///</summary>
		public virtual FeeStudCoursesItemProviderBase FeeStudCoursesItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeTreasuryProviderBase instance.
		///</summary>
		public virtual FeeTreasuryProviderBase FeeTreasuryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudRetrieveRequestProviderBase instance.
		///</summary>
		public virtual FeeStudRetrieveRequestProviderBase FeeStudRetrieveRequestProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudVoucherPayMthodProviderBase instance.
		///</summary>
		public virtual FeeStudVoucherPayMthodProviderBase FeeStudVoucherPayMthodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudVoucherItemProviderBase instance.
		///</summary>
		public virtual FeeStudVoucherItemProviderBase FeeStudVoucherItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudDiscCodeItemProviderBase instance.
		///</summary>
		public virtual FeeStudDiscCodeItemProviderBase FeeStudDiscCodeItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeStudVoucherCrsItemProviderBase instance.
		///</summary>
		public virtual FeeStudVoucherCrsItemProviderBase FeeStudVoucherCrsItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeIncomeProviderBase instance.
		///</summary>
		public virtual GsCdeIncomeProviderBase GsCdeIncomeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeMaritalStatusProviderBase instance.
		///</summary>
		public virtual GsCdeMaritalStatusProviderBase GsCdeMaritalStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeMilCourseResProviderBase instance.
		///</summary>
		public virtual GsCodeMilCourseResProviderBase GsCodeMilCourseResProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeMilitaryStateProviderBase instance.
		///</summary>
		public virtual GsCodeMilitaryStateProviderBase GsCodeMilitaryStateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodePassFailProviderBase instance.
		///</summary>
		public virtual GsCodePassFailProviderBase GsCodePassFailProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodePayMethodProviderBase instance.
		///</summary>
		public virtual GsCodePayMethodProviderBase GsCodePayMethodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeLanguageProviderBase instance.
		///</summary>
		public virtual GsCodeLanguageProviderBase GsCodeLanguageProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeKinshipProviderBase instance.
		///</summary>
		public virtual GsCodeKinshipProviderBase GsCodeKinshipProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeIdentTypeProviderBase instance.
		///</summary>
		public virtual GsCodeIdentTypeProviderBase GsCodeIdentTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeGuardSupportLevelProviderBase instance.
		///</summary>
		public virtual GsCodeGuardSupportLevelProviderBase GsCodeGuardSupportLevelProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeHouseStatProviderBase instance.
		///</summary>
		public virtual GsCodeHouseStatProviderBase GsCodeHouseStatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeHouseTypeProviderBase instance.
		///</summary>
		public virtual GsCodeHouseTypeProviderBase GsCodeHouseTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeIdentKindProviderBase instance.
		///</summary>
		public virtual GsCodeIdentKindProviderBase GsCodeIdentKindProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodePayMthdTypeProviderBase instance.
		///</summary>
		public virtual GsCodePayMthdTypeProviderBase GsCodePayMthdTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsContactMethodHProviderBase instance.
		///</summary>
		public virtual GsContactMethodHProviderBase GsContactMethodHProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeGenderProviderBase instance.
		///</summary>
		public virtual GsCodeGenderProviderBase GsCodeGenderProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCommProviderBase instance.
		///</summary>
		public virtual GsCommProviderBase GsCommProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCommRecomProviderBase instance.
		///</summary>
		public virtual GsCommRecomProviderBase GsCommRecomProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCommStaffProviderBase instance.
		///</summary>
		public virtual GsCommStaffProviderBase GsCommStaffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsContactMethodDProviderBase instance.
		///</summary>
		public virtual GsContactMethodDProviderBase GsContactMethodDProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeReligionProviderBase instance.
		///</summary>
		public virtual GsCodeReligionProviderBase GsCodeReligionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCommPurposeProviderBase instance.
		///</summary>
		public virtual GsCommPurposeProviderBase GsCommPurposeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeRptSignatureProviderBase instance.
		///</summary>
		public virtual GsCodeRptSignatureProviderBase GsCodeRptSignatureProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCommDuttyProviderBase instance.
		///</summary>
		public virtual GsCommDuttyProviderBase GsCommDuttyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeSysProviderBase instance.
		///</summary>
		public virtual GsCodeSysProviderBase GsCodeSysProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeReqStatusProviderBase instance.
		///</summary>
		public virtual GsCodeReqStatusProviderBase GsCodeReqStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeWeekDayProviderBase instance.
		///</summary>
		public virtual GsCodeWeekDayProviderBase GsCodeWeekDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeSportTypeProviderBase instance.
		///</summary>
		public virtual GsCdeSportTypeProviderBase GsCdeSportTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeEducationLevelProviderBase instance.
		///</summary>
		public virtual GsCodeEducationLevelProviderBase GsCodeEducationLevelProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeTrnSiteActProviderBase instance.
		///</summary>
		public virtual GsCdeTrnSiteActProviderBase GsCdeTrnSiteActProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeSpecAreaProviderBase instance.
		///</summary>
		public virtual GsCdeSpecAreaProviderBase GsCdeSpecAreaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeViolCatProviderBase instance.
		///</summary>
		public virtual GsCdeViolCatProviderBase GsCdeViolCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeSchoolTypeProviderBase instance.
		///</summary>
		public virtual GsCdeSchoolTypeProviderBase GsCdeSchoolTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeOutcomeProviderBase instance.
		///</summary>
		public virtual GsCdeOutcomeProviderBase GsCdeOutcomeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeTrnSiteTypeProviderBase instance.
		///</summary>
		public virtual GsCdeTrnSiteTypeProviderBase GsCdeTrnSiteTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdePenaltyProviderBase instance.
		///</summary>
		public virtual GsCdePenaltyProviderBase GsCdePenaltyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeSchoolProviderBase instance.
		///</summary>
		public virtual GsCdeSchoolProviderBase GsCdeSchoolProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeTrainSiteProviderBase instance.
		///</summary>
		public virtual GsCdeTrainSiteProviderBase GsCdeTrainSiteProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeTrainRespProviderBase instance.
		///</summary>
		public virtual GsCdeTrainRespProviderBase GsCdeTrainRespProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdePenaltyRelatedProviderBase instance.
		///</summary>
		public virtual GsCdePenaltyRelatedProviderBase GsCdePenaltyRelatedProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeUniversitiesProviderBase instance.
		///</summary>
		public virtual GsCdeUniversitiesProviderBase GsCdeUniversitiesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeViolProviderBase instance.
		///</summary>
		public virtual GsCdeViolProviderBase GsCdeViolProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeCNodeNatureProviderBase instance.
		///</summary>
		public virtual GsCodeCNodeNatureProviderBase GsCodeCNodeNatureProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeContactMethodProviderBase instance.
		///</summary>
		public virtual GsCodeContactMethodProviderBase GsCodeContactMethodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeCurrencyProviderBase instance.
		///</summary>
		public virtual GsCodeCurrencyProviderBase GsCodeCurrencyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeApprovalProviderBase instance.
		///</summary>
		public virtual GsCodeApprovalProviderBase GsCodeApprovalProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeDocTypeProviderBase instance.
		///</summary>
		public virtual GsCodeDocTypeProviderBase GsCodeDocTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeApprovalListHProviderBase instance.
		///</summary>
		public virtual GsCodeApprovalListHProviderBase GsCodeApprovalListHProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeApprovalListDProviderBase instance.
		///</summary>
		public virtual GsCodeApprovalListDProviderBase GsCodeApprovalListDProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeApprovalFuncProviderBase instance.
		///</summary>
		public virtual GsCodeApprovalFuncProviderBase GsCodeApprovalFuncProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCdeWeekDayGrpProviderBase instance.
		///</summary>
		public virtual GsCdeWeekDayGrpProviderBase GsCdeWeekDayGrpProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeExperienceProviderBase instance.
		///</summary>
		public virtual SaCodeExperienceProviderBase SaCodeExperienceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GsCodeApprovalFacultyProviderBase instance.
		///</summary>
		public virtual GsCodeApprovalFacultyProviderBase GsCodeApprovalFacultyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeHealthStateProviderBase instance.
		///</summary>
		public virtual SaCodeHealthStateProviderBase SaCodeHealthStateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoSponsorTypeProviderBase instance.
		///</summary>
		public virtual SpoSponsorTypeProviderBase SpoSponsorTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeJobActivityProviderBase instance.
		///</summary>
		public virtual SaCodeJobActivityProviderBase SaCodeJobActivityProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoSponsorProviderBase instance.
		///</summary>
		public virtual SpoSponsorProviderBase SpoSponsorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current StaticViNotesProviderBase instance.
		///</summary>
		public virtual StaticViNotesProviderBase StaticViNotesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoSponsorOfferProviderBase instance.
		///</summary>
		public virtual SpoSponsorOfferProviderBase SpoSponsorOfferProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoSponsorFeeItemProviderBase instance.
		///</summary>
		public virtual SpoSponsorFeeItemProviderBase SpoSponsorFeeItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoOfferContinueProviderBase instance.
		///</summary>
		public virtual SpoOfferContinueProviderBase SpoOfferContinueProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoResponsiblePersonProviderBase instance.
		///</summary>
		public virtual SpoResponsiblePersonProviderBase SpoResponsiblePersonProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoSponsorStudSemesterProviderBase instance.
		///</summary>
		public virtual SpoSponsorStudSemesterProviderBase SpoSponsorStudSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoSponsorOfferExtProviderBase instance.
		///</summary>
		public virtual SpoSponsorOfferExtProviderBase SpoSponsorOfferExtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvAutoMsgTmpltProviderBase instance.
		///</summary>
		public virtual SvAutoMsgTmpltProviderBase SvAutoMsgTmpltProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeCompDProviderBase instance.
		///</summary>
		public virtual SvCdeCompDProviderBase SvCdeCompDProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeCompHProviderBase instance.
		///</summary>
		public virtual SvCdeCompHProviderBase SvCdeCompHProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeLockerProviderBase instance.
		///</summary>
		public virtual SvCdeLockerProviderBase SvCdeLockerProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeMsgParamProviderBase instance.
		///</summary>
		public virtual SvCdeMsgParamProviderBase SvCdeMsgParamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeQstnTypeProviderBase instance.
		///</summary>
		public virtual SvCdeQstnTypeProviderBase SvCdeQstnTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoOfferStudExceptionProviderBase instance.
		///</summary>
		public virtual SpoOfferStudExceptionProviderBase SpoOfferStudExceptionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeReqStatusProviderBase instance.
		///</summary>
		public virtual SvCdeReqStatusProviderBase SvCdeReqStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeEvalItemHdrProviderBase instance.
		///</summary>
		public virtual SvCdeEvalItemHdrProviderBase SvCdeEvalItemHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeEvalExtProviderBase instance.
		///</summary>
		public virtual SvCdeEvalExtProviderBase SvCdeEvalExtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoStudFeeItemProviderBase instance.
		///</summary>
		public virtual SpoStudFeeItemProviderBase SpoStudFeeItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeCompTypeProviderBase instance.
		///</summary>
		public virtual SvCdeCompTypeProviderBase SvCdeCompTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeCompReplyProviderBase instance.
		///</summary>
		public virtual SvCdeCompReplyProviderBase SvCdeCompReplyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeDeviceTypeProviderBase instance.
		///</summary>
		public virtual SvCdeDeviceTypeProviderBase SvCdeDeviceTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoDepartmentProviderBase instance.
		///</summary>
		public virtual SpoDepartmentProviderBase SpoDepartmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoSponsorStudProviderBase instance.
		///</summary>
		public virtual SpoSponsorStudProviderBase SpoSponsorStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SpoContactProviderBase instance.
		///</summary>
		public virtual SpoContactProviderBase SpoContactProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeVersionProviderBase instance.
		///</summary>
		public virtual SeVersionProviderBase SeVersionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeCodeUserTypeProviderBase instance.
		///</summary>
		public virtual SeCodeUserTypeProviderBase SeCodeUserTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeControlBizTypeProviderBase instance.
		///</summary>
		public virtual SeControlBizTypeProviderBase SeControlBizTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeModuleProviderBase instance.
		///</summary>
		public virtual SeModuleProviderBase SeModuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeControlDisableWayProviderBase instance.
		///</summary>
		public virtual SeControlDisableWayProviderBase SeControlDisableWayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AsFacultyInfoProviderBase instance.
		///</summary>
		public virtual AsFacultyInfoProviderBase AsFacultyInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AsCodeDegreeClassProviderBase instance.
		///</summary>
		public virtual AsCodeDegreeClassProviderBase AsCodeDegreeClassProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeCodeUserPlaceProviderBase instance.
		///</summary>
		public virtual SeCodeUserPlaceProviderBase SeCodeUserPlaceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeCdeBlockTypeProviderBase instance.
		///</summary>
		public virtual SeCdeBlockTypeProviderBase SeCdeBlockTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeAccntProviderBase instance.
		///</summary>
		public virtual SeAccntProviderBase SeAccntProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeCodeChangeTypeProviderBase instance.
		///</summary>
		public virtual SeCodeChangeTypeProviderBase SeCodeChangeTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeCodeUserJobProviderBase instance.
		///</summary>
		public virtual SeCodeUserJobProviderBase SeCodeUserJobProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeControlTechTypeProviderBase instance.
		///</summary>
		public virtual SeControlTechTypeProviderBase SeControlTechTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeUserAccntProviderBase instance.
		///</summary>
		public virtual SeUserAccntProviderBase SeUserAccntProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeUserPhaseProviderBase instance.
		///</summary>
		public virtual SeUserPhaseProviderBase SeUserPhaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeFormProviderBase instance.
		///</summary>
		public virtual SeFormProviderBase SeFormProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeUserCrsAssessProviderBase instance.
		///</summary>
		public virtual SeUserCrsAssessProviderBase SeUserCrsAssessProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeUserAccntDegProviderBase instance.
		///</summary>
		public virtual SeUserAccntDegProviderBase SeUserAccntDegProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeUserProviderBase instance.
		///</summary>
		public virtual SeUserProviderBase SeUserProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeSrvyTypeProviderBase instance.
		///</summary>
		public virtual SvCdeSrvyTypeProviderBase SvCdeSrvyTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeUserAccntFormDiffProviderBase instance.
		///</summary>
		public virtual SeUserAccntFormDiffProviderBase SeUserAccntFormDiffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeFormControlProviderBase instance.
		///</summary>
		public virtual SeFormControlProviderBase SeFormControlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeBlockTransProviderBase instance.
		///</summary>
		public virtual SeBlockTransProviderBase SeBlockTransProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeUserAccntControlDiffProviderBase instance.
		///</summary>
		public virtual SeUserAccntControlDiffProviderBase SeUserAccntControlDiffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeStudTabControlProviderBase instance.
		///</summary>
		public virtual SeStudTabControlProviderBase SeStudTabControlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeStudTabUserTypeControlProviderBase instance.
		///</summary>
		public virtual SeStudTabUserTypeControlProviderBase SeStudTabUserTypeControlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCdeTaskStatusProviderBase instance.
		///</summary>
		public virtual SvCdeTaskStatusProviderBase SvCdeTaskStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCodeEvalItemProviderBase instance.
		///</summary>
		public virtual SvCodeEvalItemProviderBase SvCodeEvalItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SysFormControlProviderBase instance.
		///</summary>
		public virtual SysFormControlProviderBase SysFormControlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SysMessagesProviderBase instance.
		///</summary>
		public virtual SysMessagesProviderBase SysMessagesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SysParamProviderBase instance.
		///</summary>
		public virtual SysParamProviderBase SysParamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SysServiceProviderBase instance.
		///</summary>
		public virtual SysServiceProviderBase SysServiceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SystemParamProviderBase instance.
		///</summary>
		public virtual SystemParamProviderBase SystemParamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SysFormProviderBase instance.
		///</summary>
		public virtual SysFormProviderBase SysFormProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAdmissionBandProviderBase instance.
		///</summary>
		public virtual AdmAdmissionBandProviderBase AdmAdmissionBandProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvUserTaskProviderBase instance.
		///</summary>
		public virtual SvUserTaskProviderBase SvUserTaskProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvUserMobTokenProviderBase instance.
		///</summary>
		public virtual SvUserMobTokenProviderBase SvUserMobTokenProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudStaffEvalExtProviderBase instance.
		///</summary>
		public virtual SvStudStaffEvalExtProviderBase SvStudStaffEvalExtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvUserRefreshTokenProviderBase instance.
		///</summary>
		public virtual SvUserRefreshTokenProviderBase SvUserRefreshTokenProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsCdeBusProviderBase instance.
		///</summary>
		public virtual TrnsCdeBusProviderBase TrnsCdeBusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvUserMessageProviderBase instance.
		///</summary>
		public virtual SvUserMessageProviderBase SvUserMessageProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCourseEvalProviderBase instance.
		///</summary>
		public virtual SvCourseEvalProviderBase SvCourseEvalProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsCdeColorProviderBase instance.
		///</summary>
		public virtual TrnsCdeColorProviderBase TrnsCdeColorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current WfCdeFunctionProviderBase instance.
		///</summary>
		public virtual WfCdeFunctionProviderBase WfCdeFunctionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsCdeDrvrProviderBase instance.
		///</summary>
		public virtual TrnsCdeDrvrProviderBase TrnsCdeDrvrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCodeRatingSchmProviderBase instance.
		///</summary>
		public virtual SvCodeRatingSchmProviderBase SvCodeRatingSchmProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsLineProviderBase instance.
		///</summary>
		public virtual TrnsLineProviderBase TrnsLineProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsCdeStopProviderBase instance.
		///</summary>
		public virtual TrnsCdeStopProviderBase TrnsCdeStopProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCourseEvalExtProviderBase instance.
		///</summary>
		public virtual SvCourseEvalExtProviderBase SvCourseEvalExtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current WfCdeActionProviderBase instance.
		///</summary>
		public virtual WfCdeActionProviderBase WfCdeActionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsLineStopProviderBase instance.
		///</summary>
		public virtual TrnsLineStopProviderBase TrnsLineStopProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UsrTopLinkProviderBase instance.
		///</summary>
		public virtual UsrTopLinkProviderBase UsrTopLinkProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsStudCarStkrProviderBase instance.
		///</summary>
		public virtual TrnsStudCarStkrProviderBase TrnsStudCarStkrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudStaffEvalProviderBase instance.
		///</summary>
		public virtual SvStudStaffEvalProviderBase SvStudStaffEvalProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrnsStudReqProviderBase instance.
		///</summary>
		public virtual TrnsStudReqProviderBase TrnsStudReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudPollProviderBase instance.
		///</summary>
		public virtual SvStudPollProviderBase SvStudPollProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudLockerReqProviderBase instance.
		///</summary>
		public virtual SvStudLockerReqProviderBase SvStudLockerReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvSrvyHdrProviderBase instance.
		///</summary>
		public virtual SvSrvyHdrProviderBase SvSrvyHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvPollHdrProviderBase instance.
		///</summary>
		public virtual SvPollHdrProviderBase SvPollHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvSrvyAnswrProviderBase instance.
		///</summary>
		public virtual SvSrvyAnswrProviderBase SvSrvyAnswrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvPollDtlProviderBase instance.
		///</summary>
		public virtual SvPollDtlProviderBase SvPollDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvSrvyRespondQstnProviderBase instance.
		///</summary>
		public virtual SvSrvyRespondQstnProviderBase SvSrvyRespondQstnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvMsgTmpltParamProviderBase instance.
		///</summary>
		public virtual SvMsgTmpltParamProviderBase SvMsgTmpltParamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvMessageSendPrvProviderBase instance.
		///</summary>
		public virtual SvMessageSendPrvProviderBase SvMessageSendPrvProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCodeRatingSchmDtlProviderBase instance.
		///</summary>
		public virtual SvCodeRatingSchmDtlProviderBase SvCodeRatingSchmDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvCourseEvalItemProviderBase instance.
		///</summary>
		public virtual SvCourseEvalItemProviderBase SvCourseEvalItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvLecNoteProviderBase instance.
		///</summary>
		public virtual SvLecNoteProviderBase SvLecNoteProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvMessageProviderBase instance.
		///</summary>
		public virtual SvMessageProviderBase SvMessageProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvSrvyQstnProviderBase instance.
		///</summary>
		public virtual SvSrvyQstnProviderBase SvSrvyQstnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudCompProviderBase instance.
		///</summary>
		public virtual SvStudCompProviderBase SvStudCompProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvSrvyRespondAnswrProviderBase instance.
		///</summary>
		public virtual SvSrvyRespondAnswrProviderBase SvSrvyRespondAnswrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudCourseEvalProviderBase instance.
		///</summary>
		public virtual SvStudCourseEvalProviderBase SvStudCourseEvalProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudAskAdvProviderBase instance.
		///</summary>
		public virtual SvStudAskAdvProviderBase SvStudAskAdvProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudCourseEvalExtProviderBase instance.
		///</summary>
		public virtual SvStudCourseEvalExtProviderBase SvStudCourseEvalExtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStaffEvlProviderBase instance.
		///</summary>
		public virtual SvStaffEvlProviderBase SvStaffEvlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStaffPollProviderBase instance.
		///</summary>
		public virtual SvStaffPollProviderBase SvStaffPollProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStaffEvalExtProviderBase instance.
		///</summary>
		public virtual SvStaffEvalExtProviderBase SvStaffEvalExtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStudAskAdvReProviderBase instance.
		///</summary>
		public virtual SvStudAskAdvReProviderBase SvStudAskAdvReProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeApplicationLogProviderBase instance.
		///</summary>
		public virtual SeApplicationLogProviderBase SeApplicationLogProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SvStaffEvalItemProviderBase instance.
		///</summary>
		public virtual SvStaffEvalItemProviderBase SvStaffEvalItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeScDegProviderBase instance.
		///</summary>
		public virtual SaCodeScDegProviderBase SaCodeScDegProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeJobStatusProviderBase instance.
		///</summary>
		public virtual SaCodeJobStatusProviderBase SaCodeJobStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPromotionCondProviderBase instance.
		///</summary>
		public virtual SaPromotionCondProviderBase SaPromotionCondProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AsCodeDegreeProviderBase instance.
		///</summary>
		public virtual AsCodeDegreeProviderBase AsCodeDegreeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaStfMemberProviderBase instance.
		///</summary>
		public virtual SaStfMemberProviderBase SaStfMemberProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPersonIdProviderBase instance.
		///</summary>
		public virtual SaPersonIdProviderBase SaPersonIdProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPromotionProviderBase instance.
		///</summary>
		public virtual SaPromotionProviderBase SaPromotionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaOfficeHourProviderBase instance.
		///</summary>
		public virtual SaOfficeHourProviderBase SaOfficeHourProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeSummeryProviderBase instance.
		///</summary>
		public virtual SaCodeSummeryProviderBase SaCodeSummeryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaMilitaryStatusProviderBase instance.
		///</summary>
		public virtual SaMilitaryStatusProviderBase SaMilitaryStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaMiltaryProviderBase instance.
		///</summary>
		public virtual SaMiltaryProviderBase SaMiltaryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaJobStartStatmentProviderBase instance.
		///</summary>
		public virtual SaJobStartStatmentProviderBase SaJobStartStatmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaJobStoppageProviderBase instance.
		///</summary>
		public virtual SaJobStoppageProviderBase SaJobStoppageProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaKeywordListProviderBase instance.
		///</summary>
		public virtual SaKeywordListProviderBase SaKeywordListProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPromotionCondStsfProviderBase instance.
		///</summary>
		public virtual SaPromotionCondStsfProviderBase SaPromotionCondStsfProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeApplicationAuditProviderBase instance.
		///</summary>
		public virtual SeApplicationAuditProviderBase SeApplicationAuditProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPromotionRequestProviderBase instance.
		///</summary>
		public virtual SaPromotionRequestProviderBase SaPromotionRequestProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPublicationProviderBase instance.
		///</summary>
		public virtual SaPublicationProviderBase SaPublicationProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdAcadYearProviderBase instance.
		///</summary>
		public virtual EdAcadYearProviderBase EdAcadYearProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPunishBylawAuthProviderBase instance.
		///</summary>
		public virtual SaPunishBylawAuthProviderBase SaPunishBylawAuthProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaRaiseProviderBase instance.
		///</summary>
		public virtual SaRaiseProviderBase SaRaiseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaRelativeProviderBase instance.
		///</summary>
		public virtual SaRelativeProviderBase SaRelativeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaResearchTeamProviderBase instance.
		///</summary>
		public virtual SaResearchTeamProviderBase SaResearchTeamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPunishmentBylawsProviderBase instance.
		///</summary>
		public virtual SaPunishmentBylawsProviderBase SaPunishmentBylawsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaJobActivityProviderBase instance.
		///</summary>
		public virtual SaJobActivityProviderBase SaJobActivityProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaPunishmentProviderBase instance.
		///</summary>
		public virtual SaPunishmentProviderBase SaPunishmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaTransferProviderBase instance.
		///</summary>
		public virtual SaTransferProviderBase SaTransferProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaScCommProviderBase instance.
		///</summary>
		public virtual SaScCommProviderBase SaScCommProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeRatingProviderBase instance.
		///</summary>
		public virtual SaCodeRatingProviderBase SaCodeRatingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaFinStatmentProviderBase instance.
		///</summary>
		public virtual SaFinStatmentProviderBase SaFinStatmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodePunishRsnProviderBase instance.
		///</summary>
		public virtual SaCodePunishRsnProviderBase SaCodePunishRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaExtDelProviderBase instance.
		///</summary>
		public virtual SaExtDelProviderBase SaExtDelProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodePunishingAuthorityProviderBase instance.
		///</summary>
		public virtual SaCodePunishingAuthorityProviderBase SaCodePunishingAuthorityProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodePunishProviderBase instance.
		///</summary>
		public virtual SaCodePunishProviderBase SaCodePunishProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeResearchCoopProviderBase instance.
		///</summary>
		public virtual SaCodeResearchCoopProviderBase SaCodeResearchCoopProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeSemesterTypeProviderBase instance.
		///</summary>
		public virtual EdCodeSemesterTypeProviderBase EdCodeSemesterTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeSemesterProviderBase instance.
		///</summary>
		public virtual EdCodeSemesterProviderBase EdCodeSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeJobActivityPlaceProviderBase instance.
		///</summary>
		public virtual SaCodeJobActivityPlaceProviderBase SaCodeJobActivityPlaceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeJobBeforeStatusProviderBase instance.
		///</summary>
		public virtual SaCodeJobBeforeStatusProviderBase SaCodeJobBeforeStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeOrgProviderBase instance.
		///</summary>
		public virtual SaCodeOrgProviderBase SaCodeOrgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeParDelNatureProviderBase instance.
		///</summary>
		public virtual SaCodeParDelNatureProviderBase SaCodeParDelNatureProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeServTerminRsnProviderBase instance.
		///</summary>
		public virtual SaCodeServTerminRsnProviderBase SaCodeServTerminRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeStaffTypeProviderBase instance.
		///</summary>
		public virtual SaCodeStaffTypeProviderBase SaCodeStaffTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaDocOfFileProviderBase instance.
		///</summary>
		public virtual SaDocOfFileProviderBase SaDocOfFileProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaEmpHierarchyProviderBase instance.
		///</summary>
		public virtual SaEmpHierarchyProviderBase SaEmpHierarchyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaEmploymentProviderBase instance.
		///</summary>
		public virtual SaEmploymentProviderBase SaEmploymentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaExperienceProviderBase instance.
		///</summary>
		public virtual SaExperienceProviderBase SaExperienceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCommMemberProviderBase instance.
		///</summary>
		public virtual SaCommMemberProviderBase SaCommMemberProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeVacationTypeProviderBase instance.
		///</summary>
		public virtual SaCodeVacationTypeProviderBase SaCodeVacationTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeStfFlgProviderBase instance.
		///</summary>
		public virtual SaCodeStfFlgProviderBase SaCodeStfFlgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeSuperviseJobProviderBase instance.
		///</summary>
		public virtual SaCodeSuperviseJobProviderBase SaCodeSuperviseJobProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeTrainingFlgProviderBase instance.
		///</summary>
		public virtual SaCodeTrainingFlgProviderBase SaCodeTrainingFlgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaCodeTrainingOrgProviderBase instance.
		///</summary>
		public virtual SaCodeTrainingOrgProviderBase SaCodeTrainingOrgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaScCommDecisionProviderBase instance.
		///</summary>
		public virtual SaScCommDecisionProviderBase SaScCommDecisionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScCdeHallTypeProviderBase instance.
		///</summary>
		public virtual ScCdeHallTypeProviderBase ScCdeHallTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScCdeGrpTypeProviderBase instance.
		///</summary>
		public virtual ScCdeGrpTypeProviderBase ScCdeGrpTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleHdrProviderBase instance.
		///</summary>
		public virtual ScScheduleHdrProviderBase ScScheduleHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaScQualProviderBase instance.
		///</summary>
		public virtual SaScQualProviderBase SaScQualProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleDtlProviderBase instance.
		///</summary>
		public virtual ScScheduleDtlProviderBase ScScheduleDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScBuildingProviderBase instance.
		///</summary>
		public virtual ScBuildingProviderBase ScBuildingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScSchdlPeriodProviderBase instance.
		///</summary>
		public virtual ScSchdlPeriodProviderBase ScSchdlPeriodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScGroupInfoProviderBase instance.
		///</summary>
		public virtual ScGroupInfoProviderBase ScGroupInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScHallProviderBase instance.
		///</summary>
		public virtual ScHallProviderBase ScHallProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScTchngSlotProviderBase instance.
		///</summary>
		public virtual ScTchngSlotProviderBase ScTchngSlotProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScSchdlSlotProviderBase instance.
		///</summary>
		public virtual ScSchdlSlotProviderBase ScSchdlSlotProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScGroupDayProviderBase instance.
		///</summary>
		public virtual ScGroupDayProviderBase ScGroupDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleCrossListProviderBase instance.
		///</summary>
		public virtual ScScheduleCrossListProviderBase ScScheduleCrossListProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleDtlDayProviderBase instance.
		///</summary>
		public virtual ScScheduleDtlDayProviderBase ScScheduleDtlDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScSchdlSlotStaffProviderBase instance.
		///</summary>
		public virtual ScSchdlSlotStaffProviderBase ScSchdlSlotStaffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleDtlDateProviderBase instance.
		///</summary>
		public virtual ScScheduleDtlDateProviderBase ScScheduleDtlDateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScTchngDayProviderBase instance.
		///</summary>
		public virtual ScTchngDayProviderBase ScTchngDayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleDtlDayExceptionProviderBase instance.
		///</summary>
		public virtual ScScheduleDtlDayExceptionProviderBase ScScheduleDtlDayExceptionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeAccntControlDiffProviderBase instance.
		///</summary>
		public virtual SeAccntControlDiffProviderBase SeAccntControlDiffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScTchngAgendaProviderBase instance.
		///</summary>
		public virtual ScTchngAgendaProviderBase ScTchngAgendaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SeAccntFormDiffProviderBase instance.
		///</summary>
		public virtual SeAccntFormDiffProviderBase SeAccntFormDiffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScSectionGroupHdrProviderBase instance.
		///</summary>
		public virtual ScSectionGroupHdrProviderBase ScSectionGroupHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScStudGroupProviderBase instance.
		///</summary>
		public virtual ScStudGroupProviderBase ScStudGroupProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleDtlExtStfProviderBase instance.
		///</summary>
		public virtual ScScheduleDtlExtStfProviderBase ScScheduleDtlExtStfProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleHdrDefaultProviderBase instance.
		///</summary>
		public virtual ScScheduleHdrDefaultProviderBase ScScheduleHdrDefaultProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScScheduleRsrvProviderBase instance.
		///</summary>
		public virtual ScScheduleRsrvProviderBase ScScheduleRsrvProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScSectionGroupDtlProviderBase instance.
		///</summary>
		public virtual ScSectionGroupDtlProviderBase ScSectionGroupDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScSchdlHdrProviderBase instance.
		///</summary>
		public virtual ScSchdlHdrProviderBase ScSchdlHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaSupervisingJobsProviderBase instance.
		///</summary>
		public virtual SaSupervisingJobsProviderBase SaSupervisingJobsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScHallRsrvProviderBase instance.
		///</summary>
		public virtual ScHallRsrvProviderBase ScHallRsrvProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaStfSummeryTransProviderBase instance.
		///</summary>
		public virtual SaStfSummeryTransProviderBase SaStfSummeryTransProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaTrainingCourseProviderBase instance.
		///</summary>
		public virtual SaTrainingCourseProviderBase SaTrainingCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaStfDocProviderBase instance.
		///</summary>
		public virtual SaStfDocProviderBase SaStfDocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaScResearchProviderBase instance.
		///</summary>
		public virtual SaScResearchProviderBase SaScResearchProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaStfAttendProviderBase instance.
		///</summary>
		public virtual SaStfAttendProviderBase SaStfAttendProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaVacationBylawsProviderBase instance.
		///</summary>
		public virtual SaVacationBylawsProviderBase SaVacationBylawsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaServTerminProviderBase instance.
		///</summary>
		public virtual SaServTerminProviderBase SaServTerminProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaVacationRenewProviderBase instance.
		///</summary>
		public virtual SaVacationRenewProviderBase SaVacationRenewProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScCdeHallEquipProviderBase instance.
		///</summary>
		public virtual ScCdeHallEquipProviderBase ScCdeHallEquipProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScDaySlotProviderBase instance.
		///</summary>
		public virtual ScDaySlotProviderBase ScDaySlotProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScGroupStaffProviderBase instance.
		///</summary>
		public virtual ScGroupStaffProviderBase ScGroupStaffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScHallEquipProviderBase instance.
		///</summary>
		public virtual ScHallEquipProviderBase ScHallEquipProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ScCdeActvtyProviderBase instance.
		///</summary>
		public virtual ScCdeActvtyProviderBase ScCdeActvtyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaWarningAddTypeProviderBase instance.
		///</summary>
		public virtual SaWarningAddTypeProviderBase SaWarningAddTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaWarningProviderBase instance.
		///</summary>
		public virtual SaWarningProviderBase SaWarningProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaVacationRuleProviderBase instance.
		///</summary>
		public virtual SaVacationRuleProviderBase SaVacationRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaVacationBalanceHProviderBase instance.
		///</summary>
		public virtual SaVacationBalanceHProviderBase SaVacationBalanceHProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaVacationBalanceProviderBase instance.
		///</summary>
		public virtual SaVacationBalanceProviderBase SaVacationBalanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SaVacationProviderBase instance.
		///</summary>
		public virtual SaVacationProviderBase SaVacationProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeItemPaymentWaysProviderBase instance.
		///</summary>
		public virtual FeeItemPaymentWaysProviderBase FeeItemPaymentWaysProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeInvoiceItemProviderBase instance.
		///</summary>
		public virtual FeeInvoiceItemProviderBase FeeInvoiceItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeUnitProviderBase instance.
		///</summary>
		public virtual CtrCdeUnitProviderBase CtrCdeUnitProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeInvoiceProviderBase instance.
		///</summary>
		public virtual FeeInvoiceProviderBase FeeInvoiceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrKtchnStfCrtfProviderBase instance.
		///</summary>
		public virtual CtrKtchnStfCrtfProviderBase CtrKtchnStfCrtfProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeSrvcJobProviderBase instance.
		///</summary>
		public virtual CtrCdeSrvcJobProviderBase CtrCdeSrvcJobProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrSrvcCrewProviderBase instance.
		///</summary>
		public virtual CtrSrvcCrewProviderBase CtrSrvcCrewProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeSrvMthdProviderBase instance.
		///</summary>
		public virtual CtrCdeSrvMthdProviderBase CtrCdeSrvMthdProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeMealProviderBase instance.
		///</summary>
		public virtual CtrCdeMealProviderBase CtrCdeMealProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeSpclMealProviderBase instance.
		///</summary>
		public virtual CtrCdeSpclMealProviderBase CtrCdeSpclMealProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeMealItemProviderBase instance.
		///</summary>
		public virtual CtrCdeMealItemProviderBase CtrCdeMealItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrStudExpProviderBase instance.
		///</summary>
		public virtual CtrStudExpProviderBase CtrStudExpProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeOutRsnProviderBase instance.
		///</summary>
		public virtual CtrCdeOutRsnProviderBase CtrCdeOutRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdBranchRuleProviderBase instance.
		///</summary>
		public virtual EdBranchRuleProviderBase EdBranchRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrStudOutProviderBase instance.
		///</summary>
		public virtual CtrStudOutProviderBase CtrStudOutProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdBylawProviderBase instance.
		///</summary>
		public virtual EdBylawProviderBase EdBylawProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdBranchCrsProviderBase instance.
		///</summary>
		public virtual EdBranchCrsProviderBase EdBranchCrsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdAcdadvRmkProviderBase instance.
		///</summary>
		public virtual EdAcdadvRmkProviderBase EdAcdadvRmkProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdAcadYearFacultyProviderBase instance.
		///</summary>
		public virtual EdAcadYearFacultyProviderBase EdAcadYearFacultyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdAcadPlanProviderBase instance.
		///</summary>
		public virtual EdAcadPlanProviderBase EdAcadPlanProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdAbsenceApproveProviderBase instance.
		///</summary>
		public virtual EdAbsenceApproveProviderBase EdAbsenceApproveProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdAcadPlanDtlProviderBase instance.
		///</summary>
		public virtual EdAcadPlanDtlProviderBase EdAcadPlanDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeKtchnJobProviderBase instance.
		///</summary>
		public virtual CtrCdeKtchnJobProviderBase CtrCdeKtchnJobProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdAcadPlanHdrProviderBase instance.
		///</summary>
		public virtual EdAcadPlanHdrProviderBase EdAcadPlanHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeItemTypeProviderBase instance.
		///</summary>
		public virtual CtrCdeItemTypeProviderBase CtrCdeItemTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrCdeExpRsnProviderBase instance.
		///</summary>
		public virtual CtrCdeExpRsnProviderBase CtrCdeExpRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoControlProviderBase instance.
		///</summary>
		public virtual CoControlProviderBase CoControlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoControlMemberProviderBase instance.
		///</summary>
		public virtual CoControlMemberProviderBase CoControlMemberProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrMenuProviderBase instance.
		///</summary>
		public virtual CtrMenuProviderBase CtrMenuProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoControlRoomProviderBase instance.
		///</summary>
		public virtual CoControlRoomProviderBase CoControlRoomProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoCourseResultProviderBase instance.
		///</summary>
		public virtual CoCourseResultProviderBase CoCourseResultProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoContRoomMemberProviderBase instance.
		///</summary>
		public virtual CoContRoomMemberProviderBase CoContRoomMemberProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoContRmMemCourseProviderBase instance.
		///</summary>
		public virtual CoContRmMemCourseProviderBase CoContRmMemCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmTransferAcceptanceProviderBase instance.
		///</summary>
		public virtual AdmTransferAcceptanceProviderBase AdmTransferAcceptanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AlmJobProviderBase instance.
		///</summary>
		public virtual AlmJobProviderBase AlmJobProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AlmPrintRequestProviderBase instance.
		///</summary>
		public virtual AlmPrintRequestProviderBase AlmPrintRequestProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AppTypeRegStepsProviderBase instance.
		///</summary>
		public virtual AppTypeRegStepsProviderBase AppTypeRegStepsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoClemRuleFacProviderBase instance.
		///</summary>
		public virtual CoClemRuleFacProviderBase CoClemRuleFacProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoCrsRsltRaiseProviderBase instance.
		///</summary>
		public virtual CoCrsRsltRaiseProviderBase CoCrsRsltRaiseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrMenuItemProviderBase instance.
		///</summary>
		public virtual CtrMenuItemProviderBase CtrMenuItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoExamPaperProviderBase instance.
		///</summary>
		public virtual CoExamPaperProviderBase CoExamPaperProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoExaminerCorectorProviderBase instance.
		///</summary>
		public virtual CoExaminerCorectorProviderBase CoExaminerCorectorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoScheduleDetailProviderBase instance.
		///</summary>
		public virtual CoScheduleDetailProviderBase CoScheduleDetailProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoSupervisorStudCountProviderBase instance.
		///</summary>
		public virtual CoSupervisorStudCountProviderBase CoSupervisorStudCountProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoExamCommitteeProviderBase instance.
		///</summary>
		public virtual CoExamCommitteeProviderBase CoExamCommitteeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoExamCommSupervisorAltProviderBase instance.
		///</summary>
		public virtual CoExamCommSupervisorAltProviderBase CoExamCommSupervisorAltProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrMenuActProviderBase instance.
		///</summary>
		public virtual CtrMenuActProviderBase CtrMenuActProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrMenuActItemProviderBase instance.
		///</summary>
		public virtual CtrMenuActItemProviderBase CtrMenuActItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CtrMealItemProviderBase instance.
		///</summary>
		public virtual CtrMealItemProviderBase CtrMealItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoExamSchdlPlaceProviderBase instance.
		///</summary>
		public virtual CoExamSchdlPlaceProviderBase CoExamSchdlPlaceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoExamCommSupervisorProviderBase instance.
		///</summary>
		public virtual CoExamCommSupervisorProviderBase CoExamCommSupervisorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeAcadWarnTypeProviderBase instance.
		///</summary>
		public virtual EdCdeAcadWarnTypeProviderBase EdCdeAcadWarnTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeCourseChngRsnProviderBase instance.
		///</summary>
		public virtual EdCdeCourseChngRsnProviderBase EdCdeCourseChngRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeCrsRegTypeProviderBase instance.
		///</summary>
		public virtual EdCdeCrsRegTypeProviderBase EdCdeCrsRegTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeGradingTypeProviderBase instance.
		///</summary>
		public virtual EdCodeGradingTypeProviderBase EdCodeGradingTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeLevelProviderBase instance.
		///</summary>
		public virtual EdCodeLevelProviderBase EdCodeLevelProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeLoadTypeProviderBase instance.
		///</summary>
		public virtual EdCodeLoadTypeProviderBase EdCodeLoadTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeQualProviderBase instance.
		///</summary>
		public virtual EdCodeQualProviderBase EdCodeQualProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeStudyMethodProviderBase instance.
		///</summary>
		public virtual EdCodeStudyMethodProviderBase EdCodeStudyMethodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeGradingProviderBase instance.
		///</summary>
		public virtual EdCodeGradingProviderBase EdCodeGradingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeExamPeriodTypeProviderBase instance.
		///</summary>
		public virtual EdCodeExamPeriodTypeProviderBase EdCodeExamPeriodTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeExcuseTypeProviderBase instance.
		///</summary>
		public virtual EdCodeExcuseTypeProviderBase EdCodeExcuseTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoExamPlaceStudProviderBase instance.
		///</summary>
		public virtual CoExamPlaceStudProviderBase CoExamPlaceStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoStudSecretNumProviderBase instance.
		///</summary>
		public virtual CoStudSecretNumProviderBase CoStudSecretNumProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CoStudCheatProviderBase instance.
		///</summary>
		public virtual CoStudCheatProviderBase CoStudCheatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeQualGroupProviderBase instance.
		///</summary>
		public virtual EdCodeQualGroupProviderBase EdCodeQualGroupProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeQualSubjectProviderBase instance.
		///</summary>
		public virtual EdCodeQualSubjectProviderBase EdCodeQualSubjectProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeRatingProviderBase instance.
		///</summary>
		public virtual EdCodeRatingProviderBase EdCodeRatingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeTrainEvalProviderBase instance.
		///</summary>
		public virtual EdCodeTrainEvalProviderBase EdCodeTrainEvalProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseExpHdrProviderBase instance.
		///</summary>
		public virtual EdCourseExpHdrProviderBase EdCourseExpHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeTransCourseTypeProviderBase instance.
		///</summary>
		public virtual EdCodeTransCourseTypeProviderBase EdCodeTransCourseTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseProviderBase instance.
		///</summary>
		public virtual EdCourseProviderBase EdCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeSubjectProviderBase instance.
		///</summary>
		public virtual EdCodeSubjectProviderBase EdCodeSubjectProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeStudCaseProviderBase instance.
		///</summary>
		public virtual EdCodeStudCaseProviderBase EdCodeStudCaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeRepeatRuleProviderBase instance.
		///</summary>
		public virtual EdCodeRepeatRuleProviderBase EdCodeRepeatRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeSemActvityProviderBase instance.
		///</summary>
		public virtual EdCodeSemActvityProviderBase EdCodeSemActvityProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCoursePrfxProviderBase instance.
		///</summary>
		public virtual EdCoursePrfxProviderBase EdCoursePrfxProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeStateStatusProviderBase instance.
		///</summary>
		public virtual EdCodeStateStatusProviderBase EdCodeStateStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeEnrollTypeProviderBase instance.
		///</summary>
		public virtual EdCodeEnrollTypeProviderBase EdCodeEnrollTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeDischargeReasonsProviderBase instance.
		///</summary>
		public virtual EdCodeDischargeReasonsProviderBase EdCodeDischargeReasonsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeOutcomeCatProviderBase instance.
		///</summary>
		public virtual EdCdeOutcomeCatProviderBase EdCdeOutcomeCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeDischargeHProviderBase instance.
		///</summary>
		public virtual EdCodeDischargeHProviderBase EdCodeDischargeHProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeQualCatProviderBase instance.
		///</summary>
		public virtual EdCdeQualCatProviderBase EdCdeQualCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeQualBrnProviderBase instance.
		///</summary>
		public virtual EdCdeQualBrnProviderBase EdCdeQualBrnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeQualPhaseProviderBase instance.
		///</summary>
		public virtual EdCdeQualPhaseProviderBase EdCdeQualPhaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeGrdChngRsnProviderBase instance.
		///</summary>
		public virtual EdCdeGrdChngRsnProviderBase EdCdeGrdChngRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeExmptProviderBase instance.
		///</summary>
		public virtual EdCdeExmptProviderBase EdCdeExmptProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeExecuseRsnProviderBase instance.
		///</summary>
		public virtual EdCdeExecuseRsnProviderBase EdCdeExecuseRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeEmpQualProviderBase instance.
		///</summary>
		public virtual EdCdeEmpQualProviderBase EdCdeEmpQualProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeEnrollChngRsnProviderBase instance.
		///</summary>
		public virtual EdCdeEnrollChngRsnProviderBase EdCdeEnrollChngRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeExamSchdlTypeProviderBase instance.
		///</summary>
		public virtual EdCdeExamSchdlTypeProviderBase EdCdeExamSchdlTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeExamTypeProviderBase instance.
		///</summary>
		public virtual EdCdeExamTypeProviderBase EdCdeExamTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeQualStatusProviderBase instance.
		///</summary>
		public virtual EdCdeQualStatusProviderBase EdCdeQualStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeSchoolGradeProviderBase instance.
		///</summary>
		public virtual EdCdeSchoolGradeProviderBase EdCdeSchoolGradeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCourseChngProviderBase instance.
		///</summary>
		public virtual EdCodeCourseChngProviderBase EdCodeCourseChngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCourseStatusProviderBase instance.
		///</summary>
		public virtual EdCodeCourseStatusProviderBase EdCodeCourseStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCourseTeachingProviderBase instance.
		///</summary>
		public virtual EdCodeCourseTeachingProviderBase EdCodeCourseTeachingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCourseTypeProviderBase instance.
		///</summary>
		public virtual EdCodeCourseTypeProviderBase EdCodeCourseTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCourseCaseProviderBase instance.
		///</summary>
		public virtual EdCodeCourseCaseProviderBase EdCodeCourseCaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCourseAssessProviderBase instance.
		///</summary>
		public virtual EdCodeCourseAssessProviderBase EdCodeCourseAssessProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCourseProviderBase instance.
		///</summary>
		public virtual EdCodeCourseProviderBase EdCodeCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeSocialAffairProviderBase instance.
		///</summary>
		public virtual EdCdeSocialAffairProviderBase EdCdeSocialAffairProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeStudTypeProviderBase instance.
		///</summary>
		public virtual EdCdeStudTypeProviderBase EdCdeStudTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCdeTchngMthdProviderBase instance.
		///</summary>
		public virtual EdCdeTchngMthdProviderBase EdCdeTchngMthdProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCodeCheatRsltProviderBase instance.
		///</summary>
		public virtual EdCodeCheatRsltProviderBase EdCodeCheatRsltProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmTransAcceptanceCategoryProviderBase instance.
		///</summary>
		public virtual AdmTransAcceptanceCategoryProviderBase AdmTransAcceptanceCategoryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmTansikCodesProviderBase instance.
		///</summary>
		public virtual AdmTansikCodesProviderBase AdmTansikCodesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeExamGrdngProviderBase instance.
		///</summary>
		public virtual AdmCdeExamGrdngProviderBase AdmCdeExamGrdngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntityMainProviderBase instance.
		///</summary>
		public virtual EntityMainProviderBase EntityMainProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmApplicantProviderBase instance.
		///</summary>
		public virtual AdmApplicantProviderBase AdmApplicantProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeStatusProviderBase instance.
		///</summary>
		public virtual AdmCdeStatusProviderBase AdmCdeStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdePlacementExamProviderBase instance.
		///</summary>
		public virtual AdmCdePlacementExamProviderBase AdmCdePlacementExamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeFeeProviderBase instance.
		///</summary>
		public virtual AdmCdeFeeProviderBase AdmCdeFeeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmTansikMajorsCodesProviderBase instance.
		///</summary>
		public virtual AdmTansikMajorsCodesProviderBase AdmTansikMajorsCodesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppCourseCompProviderBase instance.
		///</summary>
		public virtual AdmAppCourseCompProviderBase AdmAppCourseCompProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeAppStatusProviderBase instance.
		///</summary>
		public virtual AdmCdeAppStatusProviderBase AdmCdeAppStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeAppTypeProviderBase instance.
		///</summary>
		public virtual AdmCdeAppTypeProviderBase AdmCdeAppTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeStatusRsnProviderBase instance.
		///</summary>
		public virtual AdmCdeStatusRsnProviderBase AdmCdeStatusRsnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppRegHistoryProviderBase instance.
		///</summary>
		public virtual AdmAppRegHistoryProviderBase AdmAppRegHistoryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAcceptanceCategoryProviderBase instance.
		///</summary>
		public virtual AdmAcceptanceCategoryProviderBase AdmAcceptanceCategoryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppCountProviderBase instance.
		///</summary>
		public virtual AdmAppCountProviderBase AdmAppCountProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomWfCdeFunctionProviderBase instance.
		///</summary>
		public virtual AccomWfCdeFunctionProviderBase AccomWfCdeFunctionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppAlumniPrefProviderBase instance.
		///</summary>
		public virtual AdmAppAlumniPrefProviderBase AdmAppAlumniPrefProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppDisabilityProviderBase instance.
		///</summary>
		public virtual AdmAppDisabilityProviderBase AdmAppDisabilityProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppInfoProviderBase instance.
		///</summary>
		public virtual AdmAppInfoProviderBase AdmAppInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppInterviewExamProviderBase instance.
		///</summary>
		public virtual AdmAppInterviewExamProviderBase AdmAppInterviewExamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppLanguagesProviderBase instance.
		///</summary>
		public virtual AdmAppLanguagesProviderBase AdmAppLanguagesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppLanguagesDtlProviderBase instance.
		///</summary>
		public virtual AdmAppLanguagesDtlProviderBase AdmAppLanguagesDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppHonorProviderBase instance.
		///</summary>
		public virtual AdmAppHonorProviderBase AdmAppHonorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppGuardianProviderBase instance.
		///</summary>
		public virtual AdmAppGuardianProviderBase AdmAppGuardianProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppFeesProviderBase instance.
		///</summary>
		public virtual AdmAppFeesProviderBase AdmAppFeesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppDocProviderBase instance.
		///</summary>
		public virtual AdmAppDocProviderBase AdmAppDocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppEssayProviderBase instance.
		///</summary>
		public virtual AdmAppEssayProviderBase AdmAppEssayProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppExmptCourseProviderBase instance.
		///</summary>
		public virtual AdmAppExmptCourseProviderBase AdmAppExmptCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppFeePromocodeProviderBase instance.
		///</summary>
		public virtual AdmAppFeePromocodeProviderBase AdmAppFeePromocodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomWfCdeActionProviderBase instance.
		///</summary>
		public virtual AccomWfCdeActionProviderBase AccomWfCdeActionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomPolcyAbsenceProviderBase instance.
		///</summary>
		public virtual AccomPolcyAbsenceProviderBase AccomPolcyAbsenceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudResponsibleProviderBase instance.
		///</summary>
		public virtual AccomStudResponsibleProviderBase AccomStudResponsibleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodeEntityTypeProviderBase instance.
		///</summary>
		public virtual EntCodeEntityTypeProviderBase EntCodeEntityTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomFloorProviderBase instance.
		///</summary>
		public virtual AccomFloorProviderBase AccomFloorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudAbsenceWarnProviderBase instance.
		///</summary>
		public virtual AccomStudAbsenceWarnProviderBase AccomStudAbsenceWarnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomRoomProviderBase instance.
		///</summary>
		public virtual AccomRoomProviderBase AccomRoomProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudAbsenceProviderBase instance.
		///</summary>
		public virtual AccomStudAbsenceProviderBase AccomStudAbsenceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomCdeWarnProviderBase instance.
		///</summary>
		public virtual AccomCdeWarnProviderBase AccomCdeWarnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomBuildingProviderBase instance.
		///</summary>
		public virtual AccomBuildingProviderBase AccomBuildingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmRegStepsProviderBase instance.
		///</summary>
		public virtual AdmRegStepsProviderBase AdmRegStepsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomCdeBookStatusProviderBase instance.
		///</summary>
		public virtual AccomCdeBookStatusProviderBase AccomCdeBookStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomBedProviderBase instance.
		///</summary>
		public virtual AccomBedProviderBase AccomBedProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomCdeRoomTypeProviderBase instance.
		///</summary>
		public virtual AccomCdeRoomTypeProviderBase AccomCdeRoomTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomCdePermtTypeProviderBase instance.
		///</summary>
		public virtual AccomCdePermtTypeProviderBase AccomCdePermtTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudBookProviderBase instance.
		///</summary>
		public virtual AccomStudBookProviderBase AccomStudBookProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomCdePrecondProviderBase instance.
		///</summary>
		public virtual AccomCdePrecondProviderBase AccomCdePrecondProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudDismissProviderBase instance.
		///</summary>
		public virtual AccomStudDismissProviderBase AccomStudDismissProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudPermtReqProviderBase instance.
		///</summary>
		public virtual AccomStudPermtReqProviderBase AccomStudPermtReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmExamGrdngPkgProviderBase instance.
		///</summary>
		public virtual AdmExamGrdngPkgProviderBase AdmExamGrdngPkgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudReqProviderBase instance.
		///</summary>
		public virtual AccomStudReqProviderBase AccomStudReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomWfRequestApproveProviderBase instance.
		///</summary>
		public virtual AccomWfRequestApproveProviderBase AccomWfRequestApproveProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmDecisionStatusProviderBase instance.
		///</summary>
		public virtual AdmDecisionStatusProviderBase AdmDecisionStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudLeaveReqProviderBase instance.
		///</summary>
		public virtual AccomStudLeaveReqProviderBase AccomStudLeaveReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudFeedReqProviderBase instance.
		///</summary>
		public virtual AccomStudFeedReqProviderBase AccomStudFeedReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmOpenAcadSemesterProviderBase instance.
		///</summary>
		public virtual AdmOpenAcadSemesterProviderBase AdmOpenAcadSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudFeedReqDtlProviderBase instance.
		///</summary>
		public virtual AccomStudFeedReqDtlProviderBase AccomStudFeedReqDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudLateProviderBase instance.
		///</summary>
		public virtual AccomStudLateProviderBase AccomStudLateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppLtrRecomProviderBase instance.
		///</summary>
		public virtual AdmAppLtrRecomProviderBase AdmAppLtrRecomProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudGuestReqProviderBase instance.
		///</summary>
		public virtual AccomStudGuestReqProviderBase AccomStudGuestReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccomStudGuestReqDtlProviderBase instance.
		///</summary>
		public virtual AccomStudGuestReqDtlProviderBase AccomStudGuestReqDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppMediaProviderBase instance.
		///</summary>
		public virtual AdmAppMediaProviderBase AdmAppMediaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmParamProviderBase instance.
		///</summary>
		public virtual AdmParamProviderBase AdmParamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppMessageProviderBase instance.
		///</summary>
		public virtual AdmAppMessageProviderBase AdmAppMessageProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmParamMajorPhaseProviderBase instance.
		///</summary>
		public virtual AdmParamMajorPhaseProviderBase AdmParamMajorPhaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmOutboxProviderBase instance.
		///</summary>
		public virtual AdmOutboxProviderBase AdmOutboxProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmPlaceExamCourseProviderBase instance.
		///</summary>
		public virtual AdmPlaceExamCourseProviderBase AdmPlaceExamCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmIntTransferAcceptanceProviderBase instance.
		///</summary>
		public virtual AdmIntTransferAcceptanceProviderBase AdmIntTransferAcceptanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmFeePromocodeProviderBase instance.
		///</summary>
		public virtual AdmFeePromocodeProviderBase AdmFeePromocodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCodeEngTestProviderBase instance.
		///</summary>
		public virtual AdmCodeEngTestProviderBase AdmCodeEngTestProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmFeeQualCatProviderBase instance.
		///</summary>
		public virtual AdmFeeQualCatProviderBase AdmFeeQualCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmPlaceExamDatetimeProviderBase instance.
		///</summary>
		public virtual AdmPlaceExamDatetimeProviderBase AdmPlaceExamDatetimeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmInboxProviderBase instance.
		///</summary>
		public virtual AdmInboxProviderBase AdmInboxProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmPlaceExamLocProviderBase instance.
		///</summary>
		public virtual AdmPlaceExamLocProviderBase AdmPlaceExamLocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmSkillTypeProviderBase instance.
		///</summary>
		public virtual AdmSkillTypeProviderBase AdmSkillTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmPrecondQualProviderBase instance.
		///</summary>
		public virtual AdmPrecondQualProviderBase AdmPrecondQualProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmStaticScholarshipProviderBase instance.
		///</summary>
		public virtual AdmStaticScholarshipProviderBase AdmStaticScholarshipProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmScholorshipProviderBase instance.
		///</summary>
		public virtual AdmScholorshipProviderBase AdmScholorshipProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmTansikAppCodesProviderBase instance.
		///</summary>
		public virtual AdmTansikAppCodesProviderBase AdmTansikAppCodesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmRsrvdCodeProviderBase instance.
		///</summary>
		public virtual AdmRsrvdCodeProviderBase AdmRsrvdCodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmRatingParametersMajorsProviderBase instance.
		///</summary>
		public virtual AdmRatingParametersMajorsProviderBase AdmRatingParametersMajorsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmReqDocProviderBase instance.
		///</summary>
		public virtual AdmReqDocProviderBase AdmReqDocProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmRegStepPayOnlineProviderBase instance.
		///</summary>
		public virtual AdmRegStepPayOnlineProviderBase AdmRegStepPayOnlineProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmRatingParamMajorTypeProviderBase instance.
		///</summary>
		public virtual AdmRatingParamMajorTypeProviderBase AdmRatingParamMajorTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmExamGrdngPkgDtlProviderBase instance.
		///</summary>
		public virtual AdmExamGrdngPkgDtlProviderBase AdmExamGrdngPkgDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppTransReqProviderBase instance.
		///</summary>
		public virtual AdmAppTransReqProviderBase AdmAppTransReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmEnglishProficiencyProviderBase instance.
		///</summary>
		public virtual AdmEnglishProficiencyProviderBase AdmEnglishProficiencyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppTransFromCourseProviderBase instance.
		///</summary>
		public virtual AdmAppTransFromCourseProviderBase AdmAppTransFromCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppTopicProviderBase instance.
		///</summary>
		public virtual AdmAppTopicProviderBase AdmAppTopicProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppTransBalanceProviderBase instance.
		///</summary>
		public virtual AdmAppTransBalanceProviderBase AdmAppTransBalanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppSponsorProviderBase instance.
		///</summary>
		public virtual AdmAppSponsorProviderBase AdmAppSponsorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppPlaceExamCourseProviderBase instance.
		///</summary>
		public virtual AdmAppPlaceExamCourseProviderBase AdmAppPlaceExamCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppProcStepsProviderBase instance.
		///</summary>
		public virtual AdmAppProcStepsProviderBase AdmAppProcStepsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppPlacementExamProviderBase instance.
		///</summary>
		public virtual AdmAppPlacementExamProviderBase AdmAppPlacementExamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppTransToCourseProviderBase instance.
		///</summary>
		public virtual AdmAppTransToCourseProviderBase AdmAppTransToCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppPrefProviderBase instance.
		///</summary>
		public virtual AdmAppPrefProviderBase AdmAppPrefProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCodeMasteryProviderBase instance.
		///</summary>
		public virtual AdmCodeMasteryProviderBase AdmCodeMasteryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmAppWorkExperProviderBase instance.
		///</summary>
		public virtual AdmAppWorkExperProviderBase AdmAppWorkExperProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCodeTransferTypeProviderBase instance.
		///</summary>
		public virtual AdmCodeTransferTypeProviderBase AdmCodeTransferTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeQualStatusProviderBase instance.
		///</summary>
		public virtual AdmCdeQualStatusProviderBase AdmCdeQualStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCompetitiveAvgProviderBase instance.
		///</summary>
		public virtual AdmCompetitiveAvgProviderBase AdmCompetitiveAvgProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeMediaProviderBase instance.
		///</summary>
		public virtual AdmCdeMediaProviderBase AdmCdeMediaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmApplicantAcceptanceProviderBase instance.
		///</summary>
		public virtual AdmApplicantAcceptanceProviderBase AdmApplicantAcceptanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeEssayOptionProviderBase instance.
		///</summary>
		public virtual AdmCdeEssayOptionProviderBase AdmCdeEssayOptionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeAlumniPrefProviderBase instance.
		///</summary>
		public virtual AdmCdeAlumniPrefProviderBase AdmCdeAlumniPrefProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseBarredProviderBase instance.
		///</summary>
		public virtual EdCourseBarredProviderBase EdCourseBarredProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AdmCdeCourseCompProviderBase instance.
		///</summary>
		public virtual AdmCdeCourseCompProviderBase AdmCdeCourseCompProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseCoreqProviderBase instance.
		///</summary>
		public virtual EdCourseCoreqProviderBase EdCourseCoreqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodeMdTypeProviderBase instance.
		///</summary>
		public virtual EntCodeMdTypeProviderBase EntCodeMdTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodeFullfillMetadataProviderBase instance.
		///</summary>
		public virtual EntCodeFullfillMetadataProviderBase EntCodeFullfillMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ErpOrgTreeProviderBase instance.
		///</summary>
		public virtual ErpOrgTreeProviderBase ErpOrgTreeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntIntroducMetadataProviderBase instance.
		///</summary>
		public virtual EntIntroducMetadataProviderBase EntIntroducMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntIntroducMdDataProviderBase instance.
		///</summary>
		public virtual EntIntroducMdDataProviderBase EntIntroducMdDataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntGraduationReqProviderBase instance.
		///</summary>
		public virtual EntGraduationReqProviderBase EntGraduationReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodePrecondMetadataProviderBase instance.
		///</summary>
		public virtual EntCodePrecondMetadataProviderBase EntCodePrecondMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntGradingMetadataProviderBase instance.
		///</summary>
		public virtual EntGradingMetadataProviderBase EntGradingMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntFullfillMetadataProviderBase instance.
		///</summary>
		public virtual EntFullfillMetadataProviderBase EntFullfillMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntGradingMdDataProviderBase instance.
		///</summary>
		public virtual EntGradingMdDataProviderBase EntGradingMdDataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntFullfillMdDataProviderBase instance.
		///</summary>
		public virtual EntFullfillMdDataProviderBase EntFullfillMdDataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntMainMatrixProviderBase instance.
		///</summary>
		public virtual EntMainMatrixProviderBase EntMainMatrixProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntMajorPhaseProviderBase instance.
		///</summary>
		public virtual EntMajorPhaseProviderBase EntMajorPhaseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntMajorPhaseCrsExpProviderBase instance.
		///</summary>
		public virtual EntMajorPhaseCrsExpProviderBase EntMajorPhaseCrsExpProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyAccumHonorProviderBase instance.
		///</summary>
		public virtual EntPolicyAccumHonorProviderBase EntPolicyAccumHonorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyAssessCourseProviderBase instance.
		///</summary>
		public virtual EntPolicyAssessCourseProviderBase EntPolicyAssessCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyAssessDtlProviderBase instance.
		///</summary>
		public virtual EntPolicyAssessDtlProviderBase EntPolicyAssessDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyAssessGrpDtlProviderBase instance.
		///</summary>
		public virtual EntPolicyAssessGrpDtlProviderBase EntPolicyAssessGrpDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyAbsenceProviderBase instance.
		///</summary>
		public virtual EntPolicyAbsenceProviderBase EntPolicyAbsenceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolcyGrdngHdrProviderBase instance.
		///</summary>
		public virtual EntPolcyGrdngHdrProviderBase EntPolcyGrdngHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolcyGrdngCourseProviderBase instance.
		///</summary>
		public virtual EntPolcyGrdngCourseProviderBase EntPolcyGrdngCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPlcyAcadWarnProviderBase instance.
		///</summary>
		public virtual EntPlcyAcadWarnProviderBase EntPlcyAcadWarnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPlcyAcadWarnDtlProviderBase instance.
		///</summary>
		public virtual EntPlcyAcadWarnDtlProviderBase EntPlcyAcadWarnDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolcyCrsRetakeProviderBase instance.
		///</summary>
		public virtual EntPolcyCrsRetakeProviderBase EntPolcyCrsRetakeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolcyGpaProviderBase instance.
		///</summary>
		public virtual EntPolcyGpaProviderBase EntPolcyGpaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCoursePkgMdDataProviderBase instance.
		///</summary>
		public virtual EntCoursePkgMdDataProviderBase EntCoursePkgMdDataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCoursePkgHdrProviderBase instance.
		///</summary>
		public virtual EntCoursePkgHdrProviderBase EntCoursePkgHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCoursePkgDtlProviderBase instance.
		///</summary>
		public virtual EntCoursePkgDtlProviderBase EntCoursePkgDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudStateTempProviderBase instance.
		///</summary>
		public virtual EdStudStateTempProviderBase EdStudStateTempProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudTransProviderBase instance.
		///</summary>
		public virtual EdStudTransProviderBase EdStudTransProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudTransFromReqProviderBase instance.
		///</summary>
		public virtual EdStudTransFromReqProviderBase EdStudTransFromReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudViolProviderBase instance.
		///</summary>
		public virtual EdStudViolProviderBase EdStudViolProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudStateProviderBase instance.
		///</summary>
		public virtual EdStudStateProviderBase EdStudStateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudSportProviderBase instance.
		///</summary>
		public virtual EdStudSportProviderBase EdStudSportProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudSemesterProviderBase instance.
		///</summary>
		public virtual EdStudSemesterProviderBase EdStudSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudSemesterExtProviderBase instance.
		///</summary>
		public virtual EdStudSemesterExtProviderBase EdStudSemesterExtProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudQualProviderBase instance.
		///</summary>
		public virtual EdStudQualProviderBase EdStudQualProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudSemesterTempProviderBase instance.
		///</summary>
		public virtual EdStudSemesterTempProviderBase EdStudSemesterTempProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudViolAppealProviderBase instance.
		///</summary>
		public virtual EdStudViolAppealProviderBase EdStudViolAppealProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdTopicTchngProviderBase instance.
		///</summary>
		public virtual EdTopicTchngProviderBase EdTopicTchngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodeIntroMetadataProviderBase instance.
		///</summary>
		public virtual EntCodeIntroMetadataProviderBase EntCodeIntroMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodePolicyCatProviderBase instance.
		///</summary>
		public virtual EntCodePolicyCatProviderBase EntCodePolicyCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodePolicyMetadataProviderBase instance.
		///</summary>
		public virtual EntCodePolicyMetadataProviderBase EntCodePolicyMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCourseMdDataProviderBase instance.
		///</summary>
		public virtual EntCourseMdDataProviderBase EntCourseMdDataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCodeGradingMetadataProviderBase instance.
		///</summary>
		public virtual EntCodeGradingMetadataProviderBase EntCodeGradingMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdTrainingProviderBase instance.
		///</summary>
		public virtual EdTrainingProviderBase EdTrainingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntCdePkgTypeProviderBase instance.
		///</summary>
		public virtual EntCdePkgTypeProviderBase EntCdePkgTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdTrainStudProviderBase instance.
		///</summary>
		public virtual EdTrainStudProviderBase EdTrainStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntAvailPrntTypeProviderBase instance.
		///</summary>
		public virtual EntAvailPrntTypeProviderBase EntAvailPrntTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyAssessGrpHdrProviderBase instance.
		///</summary>
		public virtual EntPolicyAssessGrpHdrProviderBase EntPolicyAssessGrpHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdTrainSupervisorProviderBase instance.
		///</summary>
		public virtual EdTrainSupervisorProviderBase EdTrainSupervisorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyAssessHdrProviderBase instance.
		///</summary>
		public virtual EntPolicyAssessHdrProviderBase EntPolicyAssessHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyCourseChngProviderBase instance.
		///</summary>
		public virtual EntPolicyCourseChngProviderBase EntPolicyCourseChngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeFacultyRuleProviderBase instance.
		///</summary>
		public virtual FeeFacultyRuleProviderBase FeeFacultyRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeFacultyItemProviderBase instance.
		///</summary>
		public virtual FeeFacultyItemProviderBase FeeFacultyItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCodeBanksProviderBase instance.
		///</summary>
		public virtual FeeCodeBanksProviderBase FeeCodeBanksProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCodeItemProviderBase instance.
		///</summary>
		public virtual FeeCodeItemProviderBase FeeCodeItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCodeReasonsProviderBase instance.
		///</summary>
		public virtual FeeCodeReasonsProviderBase FeeCodeReasonsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeTrsryProviderBase instance.
		///</summary>
		public virtual FeeCdeTrsryProviderBase FeeCdeTrsryProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeTrnsProviderBase instance.
		///</summary>
		public virtual FeeCdeTrnsProviderBase FeeCdeTrnsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeFundProviderBase instance.
		///</summary>
		public virtual FeeCdeFundProviderBase FeeCdeFundProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeInvocStatusProviderBase instance.
		///</summary>
		public virtual FeeCdeInvocStatusProviderBase FeeCdeInvocStatusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeLimitTypeProviderBase instance.
		///</summary>
		public virtual FeeCdeLimitTypeProviderBase FeeCdeLimitTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeSchshipCatProviderBase instance.
		///</summary>
		public virtual FeeCdeSchshipCatProviderBase FeeCdeSchshipCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeSchshipTypeProviderBase instance.
		///</summary>
		public virtual FeeCdeSchshipTypeProviderBase FeeCdeSchshipTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCodeTypeProviderBase instance.
		///</summary>
		public virtual FeeCodeTypeProviderBase FeeCodeTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeInstlmntRuleProviderBase instance.
		///</summary>
		public virtual FeeInstlmntRuleProviderBase FeeInstlmntRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCourseExpProviderBase instance.
		///</summary>
		public virtual FeeCourseExpProviderBase FeeCourseExpProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeInstlmntStudProviderBase instance.
		///</summary>
		public virtual FeeInstlmntStudProviderBase FeeInstlmntStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeInstlmntDtlProviderBase instance.
		///</summary>
		public virtual FeeInstlmntDtlProviderBase FeeInstlmntDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeIntegrationLedgerProviderBase instance.
		///</summary>
		public virtual FeeIntegrationLedgerProviderBase FeeIntegrationLedgerProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeFundRuleProviderBase instance.
		///</summary>
		public virtual FeeFundRuleProviderBase FeeFundRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeFacItemAdmYearProviderBase instance.
		///</summary>
		public virtual FeeFacItemAdmYearProviderBase FeeFacItemAdmYearProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeFineDtlProviderBase instance.
		///</summary>
		public virtual FeeFineDtlProviderBase FeeFineDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeFacultyInstallmentProviderBase instance.
		///</summary>
		public virtual FeeFacultyInstallmentProviderBase FeeFacultyInstallmentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeDiscCatProviderBase instance.
		///</summary>
		public virtual FeeCdeDiscCatProviderBase FeeCdeDiscCatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeFineProviderBase instance.
		///</summary>
		public virtual FeeFineProviderBase FeeFineProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyLoadProviderBase instance.
		///</summary>
		public virtual EntPolicyLoadProviderBase EntPolicyLoadProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeBondItemProviderBase instance.
		///</summary>
		public virtual FeeCdeBondItemProviderBase FeeCdeBondItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyMetadataProviderBase instance.
		///</summary>
		public virtual EntPolicyMetadataProviderBase EntPolicyMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyMdDataProviderBase instance.
		///</summary>
		public virtual EntPolicyMdDataProviderBase EntPolicyMdDataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudProviderBase instance.
		///</summary>
		public virtual EdStudProviderBase EdStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyGradingLevelProviderBase instance.
		///</summary>
		public virtual EntPolicyGradingLevelProviderBase EntPolicyGradingLevelProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyGradingHdrProviderBase instance.
		///</summary>
		public virtual EntPolicyGradingHdrProviderBase EntPolicyGradingHdrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyExcuseProviderBase instance.
		///</summary>
		public virtual EntPolicyExcuseProviderBase EntPolicyExcuseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyCourseRepeatProviderBase instance.
		///</summary>
		public virtual EntPolicyCourseRepeatProviderBase EntPolicyCourseRepeatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyGradingDtlProviderBase instance.
		///</summary>
		public virtual EntPolicyGradingDtlProviderBase EntPolicyGradingDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyObservedProviderBase instance.
		///</summary>
		public virtual EntPolicyObservedProviderBase EntPolicyObservedProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyGradingCourseProviderBase instance.
		///</summary>
		public virtual EntPolicyGradingCourseProviderBase EntPolicyGradingCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicyGradingLevelCoursesProviderBase instance.
		///</summary>
		public virtual EntPolicyGradingLevelCoursesProviderBase EntPolicyGradingLevelCoursesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPolicySemHonorProviderBase instance.
		///</summary>
		public virtual EntPolicySemHonorProviderBase EntPolicySemHonorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeBusLineItemProviderBase instance.
		///</summary>
		public virtual FeeBusLineItemProviderBase FeeBusLineItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeAllowanceProviderBase instance.
		///</summary>
		public virtual FeeCdeAllowanceProviderBase FeeCdeAllowanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeBankAccntProviderBase instance.
		///</summary>
		public virtual FeeCdeBankAccntProviderBase FeeCdeBankAccntProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeCdeDiscTypeProviderBase instance.
		///</summary>
		public virtual FeeCdeDiscTypeProviderBase FeeCdeDiscTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeAllowanceRuleProviderBase instance.
		///</summary>
		public virtual FeeAllowanceRuleProviderBase FeeAllowanceRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeAccomItemProviderBase instance.
		///</summary>
		public virtual FeeAccomItemProviderBase FeeAccomItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeAccntYearPeriodProviderBase instance.
		///</summary>
		public virtual FeeAccntYearPeriodProviderBase FeeAccntYearPeriodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPrecondMetadataProviderBase instance.
		///</summary>
		public virtual EntPrecondMetadataProviderBase EntPrecondMetadataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EntPrecondMdDataProviderBase instance.
		///</summary>
		public virtual EntPrecondMdDataProviderBase EntPrecondMdDataProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ErpEmpProviderBase instance.
		///</summary>
		public virtual ErpEmpProviderBase ErpEmpProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FeeAccntYearProviderBase instance.
		///</summary>
		public virtual FeeAccntYearProviderBase FeeAccntYearProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudRsrvRegTimeProviderBase instance.
		///</summary>
		public virtual EdStudRsrvRegTimeProviderBase EdStudRsrvRegTimeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdSemAgendaTimeProviderBase instance.
		///</summary>
		public virtual EdSemAgendaTimeProviderBase EdSemAgendaTimeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdSemesterOpenProviderBase instance.
		///</summary>
		public virtual EdSemesterOpenProviderBase EdSemesterOpenProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdSemesterAgendaProviderBase instance.
		///</summary>
		public virtual EdSemesterAgendaProviderBase EdSemesterAgendaProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudRsdncyProviderBase instance.
		///</summary>
		public virtual EdStudRsdncyProviderBase EdStudRsdncyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStaffCoursePrefProviderBase instance.
		///</summary>
		public virtual EdStaffCoursePrefProviderBase EdStaffCoursePrefProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdSemAgendaFormProviderBase instance.
		///</summary>
		public virtual EdSemAgendaFormProviderBase EdSemAgendaFormProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdSemAgendaDtlProviderBase instance.
		///</summary>
		public virtual EdSemAgendaDtlProviderBase EdSemAgendaDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdProjectProviderBase instance.
		///</summary>
		public virtual EdProjectProviderBase EdProjectProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdProjSupervisorProviderBase instance.
		///</summary>
		public virtual EdProjSupervisorProviderBase EdProjSupervisorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdResidencyStudProviderBase instance.
		///</summary>
		public virtual EdResidencyStudProviderBase EdResidencyStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdResultApproveProviderBase instance.
		///</summary>
		public virtual EdResultApproveProviderBase EdResultApproveProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStaffDayPrefProviderBase instance.
		///</summary>
		public virtual EdStaffDayPrefProviderBase EdStaffDayPrefProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStdCrsExamProviderBase instance.
		///</summary>
		public virtual EdStdCrsExamProviderBase EdStdCrsExamProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStdCrsExamAssessProviderBase instance.
		///</summary>
		public virtual EdStdCrsExamAssessProviderBase EdStdCrsExamAssessProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudActvtyRegProviderBase instance.
		///</summary>
		public virtual EdStudActvtyRegProviderBase EdStudActvtyRegProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudBranchPrefProviderBase instance.
		///</summary>
		public virtual EdStudBranchPrefProviderBase EdStudBranchPrefProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudBranchTempProviderBase instance.
		///</summary>
		public virtual EdStudBranchTempProviderBase EdStudBranchTempProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCheatProviderBase instance.
		///</summary>
		public virtual EdStudCheatProviderBase EdStudCheatProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudActivityProviderBase instance.
		///</summary>
		public virtual EdStudActivityProviderBase EdStudActivityProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudAcadmicAdvProviderBase instance.
		///</summary>
		public virtual EdStudAcadmicAdvProviderBase EdStudAcadmicAdvProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStdExamSemesterProviderBase instance.
		///</summary>
		public virtual EdStdExamSemesterProviderBase EdStdExamSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudAbsFwProviderBase instance.
		///</summary>
		public virtual EdStudAbsFwProviderBase EdStudAbsFwProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudAbsenceProviderBase instance.
		///</summary>
		public virtual EdStudAbsenceProviderBase EdStudAbsenceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudAcadWarnProviderBase instance.
		///</summary>
		public virtual EdStudAcadWarnProviderBase EdStudAcadWarnProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdProjStudProviderBase instance.
		///</summary>
		public virtual EdProjStudProviderBase EdProjStudProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdPrintReqProviderBase instance.
		///</summary>
		public virtual EdPrintReqProviderBase EdPrintReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseOutcomesTopicsProviderBase instance.
		///</summary>
		public virtual EdCourseOutcomesTopicsProviderBase EdCourseOutcomesTopicsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseRltdProviderBase instance.
		///</summary>
		public virtual EdCourseRltdProviderBase EdCourseRltdProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseTchngProviderBase instance.
		///</summary>
		public virtual EdCourseTchngProviderBase EdCourseTchngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseTopicProviderBase instance.
		///</summary>
		public virtual EdCourseTopicProviderBase EdCourseTopicProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseOutcomesDtlProviderBase instance.
		///</summary>
		public virtual EdCourseOutcomesDtlProviderBase EdCourseOutcomesDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseOrientProviderBase instance.
		///</summary>
		public virtual EdCourseOrientProviderBase EdCourseOrientProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseEquivProviderBase instance.
		///</summary>
		public virtual EdCourseEquivProviderBase EdCourseEquivProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseExpDtlProviderBase instance.
		///</summary>
		public virtual EdCourseExpDtlProviderBase EdCourseExpDtlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseInfoProviderBase instance.
		///</summary>
		public virtual EdCourseInfoProviderBase EdCourseInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCourseInstanceProviderBase instance.
		///</summary>
		public virtual EdCourseInstanceProviderBase EdCourseInstanceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdCrsFreeRstrctdProviderBase instance.
		///</summary>
		public virtual EdCrsFreeRstrctdProviderBase EdCrsFreeRstrctdProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdEmployeeQualProviderBase instance.
		///</summary>
		public virtual EdEmployeeQualProviderBase EdEmployeeQualProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdExamCrsOrderProviderBase instance.
		///</summary>
		public virtual EdExamCrsOrderProviderBase EdExamCrsOrderProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdOfferingProviderBase instance.
		///</summary>
		public virtual EdOfferingProviderBase EdOfferingProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdOfferingCourseProviderBase instance.
		///</summary>
		public virtual EdOfferingCourseProviderBase EdOfferingCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdOutcomeProviderBase instance.
		///</summary>
		public virtual EdOutcomeProviderBase EdOutcomeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdOutcomesTopicsProviderBase instance.
		///</summary>
		public virtual EdOutcomesTopicsProviderBase EdOutcomesTopicsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdInttransRuleProviderBase instance.
		///</summary>
		public virtual EdInttransRuleProviderBase EdInttransRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdGuardProviderBase instance.
		///</summary>
		public virtual EdGuardProviderBase EdGuardProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdExamSchdlProviderBase instance.
		///</summary>
		public virtual EdExamSchdlProviderBase EdExamSchdlProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdExamStudAbsenceProviderBase instance.
		///</summary>
		public virtual EdExamStudAbsenceProviderBase EdExamStudAbsenceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdExamSuprvsorProviderBase instance.
		///</summary>
		public virtual EdExamSuprvsorProviderBase EdExamSuprvsorProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdGraduationAwardProviderBase instance.
		///</summary>
		public virtual EdGraduationAwardProviderBase EdGraduationAwardProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCheatExecProviderBase instance.
		///</summary>
		public virtual EdStudCheatExecProviderBase EdStudCheatExecProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudClrncReqProviderBase instance.
		///</summary>
		public virtual EdStudClrncReqProviderBase EdStudClrncReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudIntTrnsProviderBase instance.
		///</summary>
		public virtual EdStudIntTrnsProviderBase EdStudIntTrnsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudClrncItemProviderBase instance.
		///</summary>
		public virtual EdStudClrncItemProviderBase EdStudClrncItemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudIntTrnsCourseFromProviderBase instance.
		///</summary>
		public virtual EdStudIntTrnsCourseFromProviderBase EdStudIntTrnsCourseFromProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudIntTrnsCourseToProviderBase instance.
		///</summary>
		public virtual EdStudIntTrnsCourseToProviderBase EdStudIntTrnsCourseToProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudIntTrnsStateToProviderBase instance.
		///</summary>
		public virtual EdStudIntTrnsStateToProviderBase EdStudIntTrnsStateToProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudIntTrnsStateFromProviderBase instance.
		///</summary>
		public virtual EdStudIntTrnsStateFromProviderBase EdStudIntTrnsStateFromProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudGuardProviderBase instance.
		///</summary>
		public virtual EdStudGuardProviderBase EdStudGuardProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudGrantDegreeProviderBase instance.
		///</summary>
		public virtual EdStudGrantDegreeProviderBase EdStudGrantDegreeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudGrantTempProviderBase instance.
		///</summary>
		public virtual EdStudGrantTempProviderBase EdStudGrantTempProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudGroupProviderBase instance.
		///</summary>
		public virtual EdStudGroupProviderBase EdStudGroupProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudGroupPreProviderBase instance.
		///</summary>
		public virtual EdStudGroupPreProviderBase EdStudGroupPreProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudIntTransPrefProviderBase instance.
		///</summary>
		public virtual EdStudIntTransPrefProviderBase EdStudIntTransPrefProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudInttransTempProviderBase instance.
		///</summary>
		public virtual EdStudInttransTempProviderBase EdStudInttransTempProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudLangProviderBase instance.
		///</summary>
		public virtual EdStudLangProviderBase EdStudLangProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudPnltyCourseProviderBase instance.
		///</summary>
		public virtual EdStudPnltyCourseProviderBase EdStudPnltyCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudProblemProviderBase instance.
		///</summary>
		public virtual EdStudProblemProviderBase EdStudProblemProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudQualGroupProviderBase instance.
		///</summary>
		public virtual EdStudQualGroupProviderBase EdStudQualGroupProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudQualSubjectProviderBase instance.
		///</summary>
		public virtual EdStudQualSubjectProviderBase EdStudQualSubjectProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudNoteProviderBase instance.
		///</summary>
		public virtual EdStudNoteProviderBase EdStudNoteProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudMltryCrsProviderBase instance.
		///</summary>
		public virtual EdStudMltryCrsProviderBase EdStudMltryCrsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudLatenessProviderBase instance.
		///</summary>
		public virtual EdStudLatenessProviderBase EdStudLatenessProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudMilitaryInfoProviderBase instance.
		///</summary>
		public virtual EdStudMilitaryInfoProviderBase EdStudMilitaryInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudMilitaryStateProviderBase instance.
		///</summary>
		public virtual EdStudMilitaryStateProviderBase EdStudMilitaryStateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudMissionProviderBase instance.
		///</summary>
		public virtual EdStudMissionProviderBase EdStudMissionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudGraduationAwardProviderBase instance.
		///</summary>
		public virtual EdStudGraduationAwardProviderBase EdStudGraduationAwardProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudFacultyProviderBase instance.
		///</summary>
		public virtual EdStudFacultyProviderBase EdStudFacultyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegProviderBase EdStudCourseRegProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudExmptReqAttchProviderBase instance.
		///</summary>
		public virtual EdStudExmptReqAttchProviderBase EdStudExmptReqAttchProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegAddProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegAddProviderBase EdStudCourseRegAddProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegAssessProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegAssessProviderBase EdStudCourseRegAssessProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegPolcyProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegPolcyProviderBase EdStudCourseRegPolcyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegAssessSubProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegAssessSubProviderBase EdStudCourseRegAssessSubProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseGrdChngProviderBase instance.
		///</summary>
		public virtual EdStudCourseGrdChngProviderBase EdStudCourseGrdChngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCodeChngProviderBase instance.
		///</summary>
		public virtual EdStudCodeChngProviderBase EdStudCodeChngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudContactMethodProviderBase instance.
		///</summary>
		public virtual EdStudContactMethodProviderBase EdStudContactMethodProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseChngProviderBase instance.
		///</summary>
		public virtual EdStudCourseChngProviderBase EdStudCourseChngProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseCompProviderBase instance.
		///</summary>
		public virtual EdStudCourseCompProviderBase EdStudCourseCompProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegPreProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegPreProviderBase EdStudCourseRegPreProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegTempProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegTempProviderBase EdStudCourseRegTempProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRegTopicProviderBase instance.
		///</summary>
		public virtual EdStudCourseRegTopicProviderBase EdStudCourseRegTopicProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudExmptReqProviderBase instance.
		///</summary>
		public virtual EdStudExmptReqProviderBase EdStudExmptReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudExmptCrsFromProviderBase instance.
		///</summary>
		public virtual EdStudExmptCrsFromProviderBase EdStudExmptCrsFromProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudExecuseReqProviderBase instance.
		///</summary>
		public virtual EdStudExecuseReqProviderBase EdStudExecuseReqProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudExmptCrsToProviderBase instance.
		///</summary>
		public virtual EdStudExmptCrsToProviderBase EdStudExmptCrsToProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudExcuseProviderBase instance.
		///</summary>
		public virtual EdStudExcuseProviderBase EdStudExcuseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudExcuseCourseProviderBase instance.
		///</summary>
		public virtual EdStudExcuseCourseProviderBase EdStudExcuseCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseRplcProviderBase instance.
		///</summary>
		public virtual EdStudCourseRplcProviderBase EdStudCourseRplcProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudCourseWaitProviderBase instance.
		///</summary>
		public virtual EdStudCourseWaitProviderBase EdStudCourseWaitProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudDisabilityProviderBase instance.
		///</summary>
		public virtual EdStudDisabilityProviderBase EdStudDisabilityProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current EdStudEnrollChangeProviderBase instance.
		///</summary>
		public virtual EdStudEnrollChangeProviderBase EdStudEnrollChangeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current WfCrsRsltApproveProviderBase instance.
		///</summary>
		public virtual WfCrsRsltApproveProviderBase WfCrsRsltApproveProvider{get {throw new NotImplementedException();}}
		
		
		///<summary>
		/// Current AppFeeViewProviderBase instance.
		///</summary>
		public virtual AppFeeViewProviderBase AppFeeViewProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ApplicantPlacementExamViewProviderBase instance.
		///</summary>
		public virtual ApplicantPlacementExamViewProviderBase ApplicantPlacementExamViewProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ApplicantRequiredDocumentViewProviderBase instance.
		///</summary>
		public virtual ApplicantRequiredDocumentViewProviderBase ApplicantRequiredDocumentViewProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ApplicantStepsViewProviderBase instance.
		///</summary>
		public virtual ApplicantStepsViewProviderBase ApplicantStepsViewProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ModulesTreeViewProviderBase instance.
		///</summary>
		public virtual ModulesTreeViewProviderBase ModulesTreeViewProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current StaffAcademicLoadsProviderBase instance.
		///</summary>
		public virtual StaffAcademicLoadsProviderBase StaffAcademicLoadsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TeachingLoadDistributionPerProgramProviderBase instance.
		///</summary>
		public virtual TeachingLoadDistributionPerProgramProviderBase TeachingLoadDistributionPerProgramProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VmGetOfferingInCurrentAcadYearSemesterProviderBase instance.
		///</summary>
		public virtual VmGetOfferingInCurrentAcadYearSemesterProviderBase VmGetOfferingInCurrentAcadYearSemesterProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VscheduleCoursesProviderBase instance.
		///</summary>
		public virtual VscheduleCoursesProviderBase VscheduleCoursesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VwGetAcadmicPlanCoursesProviderBase instance.
		///</summary>
		public virtual VwGetAcadmicPlanCoursesProviderBase VwGetAcadmicPlanCoursesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VwGetUniversityRequirementsCoursesProviderBase instance.
		///</summary>
		public virtual VwGetUniversityRequirementsCoursesProviderBase VwGetUniversityRequirementsCoursesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VwSelectDegreeAfterApplyRepeateRuleProviderBase instance.
		///</summary>
		public virtual VwSelectDegreeAfterApplyRepeateRuleProviderBase VwSelectDegreeAfterApplyRepeateRuleProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VwSelectStudRemainCourseProviderBase instance.
		///</summary>
		public virtual VwSelectStudRemainCourseProviderBase VwSelectStudRemainCourseProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current VwSelectTotalCrsHrsRegProviderBase instance.
		///</summary>
		public virtual VwSelectTotalCrsHrsRegProviderBase VwSelectTotalCrsHrsRegProvider{get {throw new NotImplementedException();}}
		
	}
}
