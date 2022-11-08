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
	/// This class is the base class for any <see cref="EdProjectProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdProjectProviderBase : EdProjectProviderBaseCore
	{

	    public abstract TList<EdProject> GetStudentProjects(TransactionManager transactionManager, decimal? edAcadYearId,
                                                            decimal? edCodeSemesterId, decimal? edProjectId, decimal? asFacultyInfo, decimal entityMainId,
	                                                        string studCode, string studName, decimal lang);

	} // end class
} // end namespace
