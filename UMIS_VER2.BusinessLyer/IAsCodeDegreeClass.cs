﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'AS_CODE_DEGREE_CLASS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAsCodeDegreeClass 
	{
		/// <summary>			
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "AS_CODE_DEGREE_CLASS"</remarks>
		System.Decimal AsCodeDegreeClassId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAsCodeDegreeClassId { get; set; }
			
		
		
		/// <summary>
		/// CLASS_DESCR_AR : 
		/// </summary>
		System.String  ClassDescrAr  { get; set; }
		
		/// <summary>
		/// CLASS_DESCR_EN : 
		/// </summary>
		System.String  ClassDescrEn  { get; set; }
		
		/// <summary>
		/// CLASS_CODE : 
		/// </summary>
		System.String  ClassCode  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edAcadYearFacultyAsCodeDegreeClassId
		/// </summary>	
		TList<EdAcadYearFaculty> EdAcadYearFacultyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppRegHistoryAsCodeDegreeClassId
		/// </summary>	
		TList<AdmAppRegHistory> AdmAppRegHistoryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemesterOpenAsCodeDegreeClassId
		/// </summary>	
		TList<EdSemesterOpen> EdSemesterOpenCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _seUserAccntAsCodeDegreeClassId
		/// </summary>	
		TList<SeUserAccnt> SeUserAccntCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _scSectionGroupHdrAsCodeDegreeClassId
		/// </summary>	
		TList<ScSectionGroupHdr> ScSectionGroupHdrCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admCodeEngTestAsCodeDegreeClassId
		/// </summary>	
		TList<AdmCodeEngTest> AdmCodeEngTestCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _asCodeDegreeAsCodeDegreeClassId
		/// </summary>	
		TList<AsCodeDegree> AsCodeDegreeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _seFormAsCodeDegreeClassId
		/// </summary>	
		TList<SeForm> SeFormCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _spoSponsorOfferAsCodeDegreeClassId
		/// </summary>	
		TList<SpoSponsorOffer> SpoSponsorOfferCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisGrantDegreeAsCodeDegreeClassId
		/// </summary>	
		TList<PgThesisGrantDegree> PgThesisGrantDegreeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeRefundCodeAsCodeDegreeClassId
		/// </summary>	
		TList<FeeRefundCode> FeeRefundCodeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeInstlmntRuleAsCodeDegreeClassId
		/// </summary>	
		TList<FeeInstlmntRule> FeeInstlmntRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeCdeSchshipTypeAsCodeDegreeClassId
		/// </summary>	
		TList<FeeCdeSchshipType> FeeCdeSchshipTypeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCdeCrsRegTypeAsCodeDegreeClassId
		/// </summary>	
		TList<EdCdeCrsRegType> EdCdeCrsRegTypeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeAllowanceRuleAsCodeDegreeClassId
		/// </summary>	
		TList<FeeAllowanceRule> FeeAllowanceRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCourseAsCodeDegreeClassId
		/// </summary>	
		TList<EdCourse> EdCourseCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edBylawAsCodeDegreeClassId
		/// </summary>	
		TList<EdBylaw> EdBylawCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admPrecondQualAsCodeDegreeClassId
		/// </summary>	
		TList<AdmPrecondQual> AdmPrecondQualCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edCdeQualCatAsCodeDegreeClassId
		/// </summary>	
		TList<EdCdeQualCat> EdCdeQualCatCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _appTypeRegStepsAsCodeDegreeClassId
		/// </summary>	
		TList<AppTypeRegSteps> AppTypeRegStepsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admRatingParametersMajorsAsCodeDegreeClassId
		/// </summary>	
		TList<AdmRatingParametersMajors> AdmRatingParametersMajorsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeCdeDiscTypeAsCodeDegreeClassId
		/// </summary>	
		TList<FeeCdeDiscType> FeeCdeDiscTypeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admReqDocAsCodeDegreeClassId
		/// </summary>	
		TList<AdmReqDoc> AdmReqDocCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppCountAsCodeDegreeClassId
		/// </summary>	
		TList<AdmAppCount> AdmAppCountCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edOfferingAsCodeDegreeClassId
		/// </summary>	
		TList<EdOffering> EdOfferingCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgOfferingAsCodeDegreeClassId
		/// </summary>	
		TList<PgOffering> PgOfferingCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAcceptanceCategoryAsCodeDegreeClassId
		/// </summary>	
		TList<AdmAcceptanceCategory> AdmAcceptanceCategoryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admTransAcceptanceCategoryAsCodeDegreeClassId
		/// </summary>	
		TList<AdmTransAcceptanceCategory> AdmTransAcceptanceCategoryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edResultApproveAsCodeDegreeClassId
		/// </summary>	
		TList<EdResultApprove> EdResultApproveCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admCdePlacementExamAsCodeDegreeClassId
		/// </summary>	
		TList<AdmCdePlacementExam> AdmCdePlacementExamCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeLimitRuleAsCodeDegreeClassId
		/// </summary>	
		TList<FeeLimitRule> FeeLimitRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemesterAgendaAsCodeDegreeClassId
		/// </summary>	
		TList<EdSemesterAgenda> EdSemesterAgendaCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeCodeItemAsCodeDegreeClassId
		/// </summary>	
		TList<FeeCodeItem> FeeCodeItemCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entCodeFullfillMetadataAsCodeDegreeClassId
		/// </summary>	
		TList<EntCodeFullfillMetadata> EntCodeFullfillMetadataCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admCompetitiveAvgAsCodeDegreeClassId
		/// </summary>	
		TList<AdmCompetitiveAvg> AdmCompetitiveAvgCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admTansikCodesAsCodeDegreeClassId
		/// </summary>	
		TList<AdmTansikCodes> AdmTansikCodesCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _feeFacultyRuleAsCodeDegreeClassId
		/// </summary>	
		TList<FeeFacultyRule> FeeFacultyRuleCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edGraduationAwardAsCodeDegreeClassId
		/// </summary>	
		TList<EdGraduationAward> EdGraduationAwardCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coControlAsCodeDegreeClassId
		/// </summary>	
		TList<CoControl> CoControlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admCdeFeeAsCodeDegreeClassId
		/// </summary>	
		TList<AdmCdeFee> AdmCdeFeeCollection {  get;  set;}	

		#endregion Data Properties

	}
}


