﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'SA_CODE_JOB_BEFORE_STATUS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISaCodeJobBeforeStatus 
	{
		/// <summary>			
		/// SA_CODE_JOB_BEFORE_STATUS_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SA_CODE_JOB_BEFORE_STATUS"</remarks>
		System.Decimal SaCodeJobBeforeStatusId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalSaCodeJobBeforeStatusId { get; set; }
			
		
		
		/// <summary>
		/// SA_CODE_SUMMERY_ID : 
		/// </summary>
		System.Decimal  SaCodeSummeryId  { get; set; }
		
		/// <summary>
		/// SA_CODE_JOB_STATUS_ID : 
		/// </summary>
		System.Decimal  SaCodeJobStatusId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

