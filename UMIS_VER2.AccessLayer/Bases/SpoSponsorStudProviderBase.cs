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
	/// This class is the base class for any <see cref="SpoSponsorStudProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorStudProviderBase : SpoSponsorStudProviderBaseCore
	{
	    public abstract DataTable GetSponsorStudents(TransactionManager transactionManager, decimal spoSponsorId);

        public abstract TList<SpoSponsorStud> GetStudentSponsered(TransactionManager transactionManager, decimal? edAcadYearId, decimal? edCodeSemesterId, decimal? spoSponsorId, decimal? GsCountryNodeId, decimal? AsFacultyInfoId, decimal? EntMainId);
      
	} // end class
} // end namespace
