﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_CDE_EXAM_TYPE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCdeExamType 
	{
		/// <summary>			
		/// ED_CDE_EXAM_TYPE_ID : نوع الامتحان: تكميلى- اعادة
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_CDE_EXAM_TYPE"</remarks>
		System.Decimal EdCdeExamTypeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCdeExamTypeId { get; set; }
			
		
		
		/// <summary>
		/// EXAM_TYPE_AR : وصف عربى
		/// </summary>
		System.String  ExamTypeAr  { get; set; }
		
		/// <summary>
		/// EXM_TYPE_EN : وصف انجليش
		/// </summary>
		System.String  ExmTypeEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edExamStudAbsenceEdCdeExamTypeId
		/// </summary>	
		TList<EdExamStudAbsence> EdExamStudAbsenceCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStdExamSemesterEdCdeExamTypeId
		/// </summary>	
		TList<EdStdExamSemester> EdStdExamSemesterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudSemesterEdCdeExamTypeId
		/// </summary>	
		TList<EdStudSemester> EdStudSemesterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCheatEdCdeExamTypeId
		/// </summary>	
		TList<EdStudCheat> EdStudCheatCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStdCrsExamEdCdeExamTypeId
		/// </summary>	
		TList<EdStdCrsExam> EdStdCrsExamCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coStudSecretNumEdCdeExamTypeId
		/// </summary>	
		TList<CoStudSecretNum> CoStudSecretNumCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edExamSchdlEdCdeExamTypeId
		/// </summary>	
		TList<EdExamSchdl> EdExamSchdlCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegEdCdeExamTypeId
		/// </summary>	
		TList<EdStudCourseReg> EdStudCourseRegCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudSemesterTempEdCdeExamTypeId
		/// </summary>	
		TList<EdStudSemesterTemp> EdStudSemesterTempCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _seUserCrsAssessEdCdeExamTypeId
		/// </summary>	
		TList<SeUserCrsAssess> SeUserCrsAssessCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _coControlEdCdeExamTypeId
		/// </summary>	
		TList<CoControl> CoControlCollection {  get;  set;}	

		#endregion Data Properties

	}
}


