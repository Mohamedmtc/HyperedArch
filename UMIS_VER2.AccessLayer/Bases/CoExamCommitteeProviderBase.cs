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
	/// This class is the base class for any <see cref="CoExamCommitteeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamCommitteeProviderBase : CoExamCommitteeProviderBaseCore
	{
        /*---custom Method --added by maha 01-6-2021  task 16756--*/
        public abstract DataTable ValidateExamCommitteChaneCapacity(decimal CoExamCommitteID);
        public abstract DataTable UpdateNextSeatFromTo(decimal CoExamCommitteID, decimal DifferanceCapacityVal);
	} // end class
} // end namespace
