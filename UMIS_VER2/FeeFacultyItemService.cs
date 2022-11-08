	

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
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'FEE_FACULTY_ITEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeFacultyItemService : UMIS_VER2.FeeFacultyItemServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeFacultyItemService class.
		/// </summary>
		public FeeFacultyItemService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetFacultyItemByStudID(decimal? _EdStudId, decimal? FEE_CODE_TYPE_ID, decimal? FeeStudDiscId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFacultyItemByStudID");
            #endregion Security and validation check
            #region Initialisation


            NetTiersProvider dataProvider;
            #endregion Initialisation



            dataProvider = ConnectionScope.Current.DataProvider;
            DataTable dt = dataProvider.FeeFacultyItemProvider.GetFacultyItemByStudID(_EdStudId, FEE_CODE_TYPE_ID, FeeStudDiscId);
            return dt;
        }
        #endregion

	}//End Class

} // end namespace
