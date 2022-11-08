﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ED_TRAIN_STUD' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEdTrainStud 
	{
		/// <summary>			
		/// ED_TRAIN_STUD_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ED_TRAIN_STUD"</remarks>
		System.Decimal EdTrainStudId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEdTrainStudId { get; set; }
			
		
		
		/// <summary>
		/// ED_TRAINING_ID : 
		/// </summary>
		System.Decimal  EdTrainingId  { get; set; }
		
		/// <summary>
		/// ED_STUD_ID : 
		/// </summary>
		System.Decimal  EdStudId  { get; set; }
		
		/// <summary>
		/// SA_STF_MEMBER_ID : 
		/// </summary>
		System.Decimal?  SaStfMemberId  { get; set; }
		
		/// <summary>
		/// ED_COURSE_ID : 
		/// </summary>
		System.Decimal?  EdCourseId  { get; set; }
		
		/// <summary>
		/// SUP_COMMENT : 
		/// </summary>
		System.String  SupComment  { get; set; }
		
		/// <summary>
		/// ED_CODE_TRAIN_EVAL_ID : 
		/// </summary>
		System.Decimal?  EdCodeTrainEvalId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

