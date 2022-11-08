﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_OPEN_ACAD_SEMESTER' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmOpenAcadSemester 
	{
		/// <summary>			
		/// ADM_OPEN_ACAD_SEMESTER_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_OPEN_ACAD_SEMESTER"</remarks>
		System.Decimal AdmOpenAcadSemesterId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmOpenAcadSemesterId { get; set; }
			
		
		
		/// <summary>
		/// ED_CODE_SEMESTER_ID : 
		/// </summary>
		System.Decimal  EdCodeSemesterId  { get; set; }
		
		/// <summary>
		/// ED_ACAD_YEAR_ID : 
		/// </summary>
		System.Decimal  EdAcadYearId  { get; set; }
		
		/// <summary>
		/// FROM_DATE : 
		/// </summary>
		System.DateTime  FromDate  { get; set; }
		
		/// <summary>
		/// TO_DATE : 
		/// </summary>
		System.DateTime  ToDate  { get; set; }
		
		/// <summary>
		/// IS_CURRENT : 
		/// </summary>
		System.Decimal  IsCurrent  { get; set; }
		
		/// <summary>
		/// IS_CLOSED : 
		/// </summary>
		System.Decimal  IsClosed  { get; set; }
		
		/// <summary>
		/// CLOSE_WEB : 
		/// </summary>
		System.Decimal  CloseWeb  { get; set; }
		
		/// <summary>
		/// RESTRICT_UPDATE : 
		/// </summary>
		System.Decimal  RestrictUpdate  { get; set; }
		
		/// <summary>
		/// COMPTITIVE_RATE_FLG : 
		/// </summary>
		System.Decimal  ComptitiveRateFlg  { get; set; }
		
		/// <summary>
		/// ADMISSION_VALIDATION_FLG : 
		/// </summary>
		System.Decimal  AdmissionValidationFlg  { get; set; }
		
		/// <summary>
		/// DISTRIBUTION_FLG : 
		/// </summary>
		System.Decimal  DistributionFlg  { get; set; }
		
		/// <summary>
		/// EARLY_FROM_DATE : early Admission
		/// </summary>
		System.DateTime?  EarlyFromDate  { get; set; }
		
		/// <summary>
		/// EARLY_TO_DATE : early Admission
		/// </summary>
		System.DateTime?  EarlyToDate  { get; set; }
		
		/// <summary>
		/// MIN_TRNS_CGPA : "الحد الأدنى للمعدل المقبول للطلاب المحولين"
		/// </summary>
		System.Decimal?  MinTrnsCgpa  { get; set; }
		
		/// <summary>
		/// NOTES : 
		/// </summary>
		System.String  Notes  { get; set; }
		
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
		///	which are related to this object through the relation _admRatingParametersMajorsAdmOpenAcadSemesterId
		/// </summary>	
		TList<AdmRatingParametersMajors> AdmRatingParametersMajorsCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppFeesAdmOpenAcadSemesterId
		/// </summary>	
		TList<AdmAppFees> AdmAppFeesCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admTansikMajorsCodesAdmOpenAcadSemesterId
		/// </summary>	
		TList<AdmTansikMajorsCodes> AdmTansikMajorsCodesCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admPlaceExamDatetimeAdmOpenAcadSemesterId
		/// </summary>	
		TList<AdmPlaceExamDatetime> AdmPlaceExamDatetimeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admAppRegHistoryAdmOpenAcadSemesterId
		/// </summary>	
		TList<AdmAppRegHistory> AdmAppRegHistoryCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admCompetitiveAvgAdmOpenAcadSemesterId
		/// </summary>	
		TList<AdmCompetitiveAvg> AdmCompetitiveAvgCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _admRsrvdCodeAdmOpenAcadSemesterId
		/// </summary>	
		TList<AdmRsrvdCode> AdmRsrvdCodeCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edSemesterAgendaAdmOpenAcadSemesterId
		/// </summary>	
		TList<EdSemesterAgenda> EdSemesterAgendaCollection {  get;  set;}	

		#endregion Data Properties

	}
}

