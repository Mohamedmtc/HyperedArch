﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'GS_CDE_HONOR' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IGsCdeHonor 
	{
		/// <summary>			
		/// GS_CDE_HONOR_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "GS_CDE_HONOR"</remarks>
		System.Decimal GsCdeHonorId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalGsCdeHonorId { get; set; }
			
		
		
		/// <summary>
		/// HONOR_CODE : 
		/// </summary>
		System.String  HonorCode  { get; set; }
		
		/// <summary>
		/// HONOR_AR : 
		/// </summary>
		System.String  HonorAr  { get; set; }
		
		/// <summary>
		/// HONOR_EN : 
		/// </summary>
		System.String  HonorEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisGrantStudGsCdeHonorId
		/// </summary>	
		TList<PgThesisGrantStud> PgThesisGrantStudCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entPolicySemHonorGsCdeHonorId
		/// </summary>	
		TList<EntPolicySemHonor> EntPolicySemHonorCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entPolicyAccumHonorGsCdeHonorId
		/// </summary>	
		TList<EntPolicyAccumHonor> EntPolicyAccumHonorCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudFacultyGsCdeHonorId
		/// </summary>	
		TList<EdStudFaculty> EdStudFacultyCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _edStudSemesterGsCdeHonorId
		/// </summary>	
		TList<EdStudSemester> EdStudSemesterCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _pgThesisStudGsCdeHonorId
		/// </summary>	
		TList<PgThesisStud> PgThesisStudCollection {  get;  set;}	

		#endregion Data Properties

	}
}

