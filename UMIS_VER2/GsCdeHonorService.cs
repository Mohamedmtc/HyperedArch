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
	/// An component type implementation of the 'GS_CDE_HONOR' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class GsCdeHonorService : UMIS_VER2.GsCdeHonorServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the GsCdeHonorService class.
		/// </summary>
		public GsCdeHonorService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
