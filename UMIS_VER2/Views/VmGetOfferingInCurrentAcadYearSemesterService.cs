
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
	
	///<summary>
	/// An component type implementation of the 'VM_GetOfferingInCurrentAcadYearSemester' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class VmGetOfferingInCurrentAcadYearSemesterService : UMIS_VER2.VmGetOfferingInCurrentAcadYearSemesterServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the VmGetOfferingInCurrentAcadYearSemesterService class.
		/// </summary>
		public VmGetOfferingInCurrentAcadYearSemesterService() : base()
		{
		}
		
	}//End Class


} // end namespace
