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
	/// This class is the base class for any <see cref="FeeUserBondReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeUserBondReqProviderBase : FeeUserBondReqProviderBaseCore
	{
        //added by manar abdelhafez task 13031 CSS
        public abstract DataTable GetFeesBondRequest(DateTime? dateFrom, DateTime? dateTo, int FeecdeBItem, string granteeName, string AccNo);
        //end 
	} // end class
} // end namespace
