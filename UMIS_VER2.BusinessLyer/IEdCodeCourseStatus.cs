﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_CODE_COURSE_STATUS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdCodeCourseStatus 
	{
		/// <summary>			
		/// ED_CODE_COURSE_STATUS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_CODE_COURSE_STATUS"</remarks>
		System.Decimal EdCodeCourseStatusId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdCodeCourseStatusId { get; set; }
			
		
		
		/// <summary>
		/// DESCR_AR : 
		/// </summary>
		System.String  DescrAr  { get; set; }
		
		/// <summary>
		/// DESCR_EN : 
		/// </summary>
		System.String  DescrEn  { get; set; }
		
		/// <summary>
		/// SYMBOL : 
		/// </summary>
		System.String  Symbol  { get; set; }
		
		/// <summary>
		/// SHOW_FLG : 
		/// </summary>
		System.Decimal  ShowFlg  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsCourseFromEdCodeCourseStatusId
		/// </summary>	
		TList<EdStudIntTrnsCourseFrom> EdStudIntTrnsCourseFromCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseGrdChngEdCodeCourseStsNewIdGetByEdCodeCourseStsNewId
		/// </summary>	
		TList<EdStudCourseGrdChng> EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegEdCodeCourseStatusId
		/// </summary>	
		TList<EdStudCourseReg> EdStudCourseRegCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegAssessEdCodeCourseStatusId
		/// </summary>	
		TList<EdStudCourseRegAssess> EdStudCourseRegAssessCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStdCrsExamEdCodeCourseStatusNewIdGetByEdCodeCourseStatusNewId
		/// </summary>	
		TList<EdStdCrsExam> EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseGrdChngEdCodeCourseStsNewIdGetByEdCodeCourseStsOldId
		/// </summary>	
		TList<EdStudCourseGrdChng> EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStdCrsExamEdCodeCourseStatusNewIdGetByEdCodeCourseStatusOldId
		/// </summary>	
		TList<EdStdCrsExam> EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudCourseRegTempEdCodeCourseStatusId
		/// </summary>	
		TList<EdStudCourseRegTemp> EdStudCourseRegTempCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudIntTrnsCourseToEdCodeCourseStatusId
		/// </summary>	
		TList<EdStudIntTrnsCourseTo> EdStudIntTrnsCourseToCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entPolcyGrdngHdrEdCodeCourseStatusNewId
		/// </summary>	
		TList<EntPolcyGrdngHdr> EntPolcyGrdngHdrCollection {  get;  set;}	

		#endregion Data Properties

	}
}


