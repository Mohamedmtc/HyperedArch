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
	/// This class is the base class for any <see cref="SvUserTaskProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvUserTaskProviderBase : SvUserTaskProviderBaseCore
	{
        /*---custom Method --added by maha 21-8-2019   task 10817--*/
        public abstract DataTable GetUserTasksData(UMIS_VER2.BusinessLyer.SvUserTask obj, string FromDate, string ToDate);

        public abstract DataTable GetUserTaskDetails(decimal ID, int Lang);

    } // end class
       
} // end namespace
