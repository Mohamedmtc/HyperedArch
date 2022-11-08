﻿using System;
using System.ComponentModel;

namespace UMIS_VER2.BusinessLyer
{
	/// <summary>
	///		The data structure representation of the 'ENT_CODE_MD_TYPE' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEntCodeMdType 
	{
		/// <summary>			
		/// ENT_CODE_MD_TYPE_ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ENT_CODE_MD_TYPE"</remarks>
		System.Decimal EntCodeMdTypeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Decimal OriginalEntCodeMdTypeId { get; set; }
			
		
		
		/// <summary>
		/// MD_TYPE_DESCR_AR : 
		/// </summary>
		System.String  MdTypeDescrAr  { get; set; }
		
		/// <summary>
		/// MD_TYPE_DESCR_EN : 
		/// </summary>
		System.String  MdTypeDescrEn  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entCodeFullfillMetadataEntCodeMdTypeId
		/// </summary>	
		TList<EntCodeFullfillMetadata> EntCodeFullfillMetadataCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entCodePolicyMetadataEntCodeMdTypeId
		/// </summary>	
		TList<EntCodePolicyMetadata> EntCodePolicyMetadataCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entCodeIntroMetadataEntCodeMdTypeId
		/// </summary>	
		TList<EntCodeIntroMetadata> EntCodeIntroMetadataCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _accomCdePrecondEntCodeMdTypeId
		/// </summary>	
		TList<AccomCdePrecond> AccomCdePrecondCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entCodePrecondMetadataEntCodeMdTypeId
		/// </summary>	
		TList<EntCodePrecondMetadata> EntCodePrecondMetadataCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _entCodeGradingMetadataEntCodeMdTypeId
		/// </summary>	
		TList<EntCodeGradingMetadata> EntCodeGradingMetadataCollection {  get;  set;}	

		#endregion Data Properties

	}
}


