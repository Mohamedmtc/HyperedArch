	

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
	/// An component type implementation of the 'ADM_APP_COURSE_COMP' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmAppCourseCompService : UMIS_VER2.AdmAppCourseCompServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion
        
        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmAppCourseCompService class.
		/// </summary>
		public AdmAppCourseCompService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
