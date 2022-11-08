#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="FeeUserFundReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeUserFundReqProviderBase : FeeUserFundReqProviderBaseCore
	{
        //added by manar abdelhafez task 13329 CSS
        public abstract DataTable GETFeeFundRequest(int AcadYearId, int FeecdeBItem, string granteeName, string AccNo);
     
	} // end class
} // end namespace
