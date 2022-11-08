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
	/// An component type implementation of the 'ENT_GRADING_MD_DATA' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntGradingMdDataService : UMIS_VER2.EntGradingMdDataServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataService class.
		/// </summary>
		public EntGradingMdDataService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        #endregion

	}//End Class

} // end namespace