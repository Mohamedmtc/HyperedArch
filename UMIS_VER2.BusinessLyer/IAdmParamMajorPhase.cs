﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_PARAM_MAJOR_PHASE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmParamMajorPhase 
	{
		/// <summary>			
		/// ADM_PARAM_MAJOR_PHASE_ID : مراحل القبول NUB
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_PARAM_MAJOR_PHASE"</remarks>
		System.Decimal AdmParamMajorPhaseId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmParamMajorPhaseId { get; set; }
			
		
		
		/// <summary>
		/// ADM_RATING_PARAMETERS_MAJORS_ID : 
		/// </summary>
		System.Decimal  AdmRatingParametersMajorsId  { get; set; }
		
		/// <summary>
		/// APP_COUNT : 
		/// </summary>
		System.Decimal?  AppCount  { get; set; }
		
		/// <summary>
		/// ED_CDE_QUAL_PHASE_ID : 
		/// </summary>
		System.Decimal?  EdCdeQualPhaseId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


