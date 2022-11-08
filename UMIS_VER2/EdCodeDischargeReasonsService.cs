﻿	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ED_CODE_DISCHARGE_REASONS' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdCodeDischargeReasonsService : UMIS_VER2.EdCodeDischargeReasonsServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeReasonsService class.
		/// </summary>
		public EdCodeDischargeReasonsService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace