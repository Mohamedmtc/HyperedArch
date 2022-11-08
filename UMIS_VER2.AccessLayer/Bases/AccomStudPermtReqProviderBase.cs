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
	/// This class is the base class for any <see cref="AccomStudPermtReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudPermtReqProviderBase : AccomStudPermtReqProviderBaseCore
	{
        #region coustom Methods
        public abstract DataTable GetAccomStudPermtRequests(decimal AcadYearID, decimal SemesterID, Decimal AsFacultyinfoId, decimal DegreeId, decimal MajorId, decimal MinorId, decimal levelId, string StudName,decimal LangNum, decimal NamePolicy, string StudCode, int CodeReqState, int RequestType);
        #endregion
	} // end class
} // end namespace
