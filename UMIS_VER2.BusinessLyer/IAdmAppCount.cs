﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ADM_APP_COUNT' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdmAppCount 
	{
		/// <summary>			
		/// ADM_APP_COUNT_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ADM_APP_COUNT"</remarks>
		System.Decimal AdmAppCountId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalAdmAppCountId { get; set; }
			
		
		
		/// <summary>
		/// ENT_MAIN_ID : 
		/// </summary>
		System.Decimal  EntMainId  { get; set; }
		
		/// <summary>
		/// MAX_COUNT : 
		/// </summary>
		System.Decimal?  MaxCount  { get; set; }
		
		/// <summary>
		/// AS_CODE_DEGREE_CLASS_ID : 
		/// </summary>
		System.Decimal?  AsCodeDegreeClassId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

