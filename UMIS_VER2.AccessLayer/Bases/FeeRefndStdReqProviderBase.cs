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
	/// This class is the base class for any <see cref="FeeRefndStdReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeRefndStdReqProviderBase : FeeRefndStdReqProviderBaseCore
	{


        public abstract DataTable GetStudentRefendReq(decimal? SemesterID, decimal? AsFacultyInfoID, decimal? EdAcadYearID, int? GsCodeReqStatusID, DateTime? FromDate, DateTime? ToDate, bool? Canceled, string StudentCode, string ApplicantCode, int IsApplicant,int? ApplicantID,int?UserId);
        public abstract DataTable GetAdmAppFeesForCurrentSemsterRef(decimal AdmApplicantId );
       
    
    } // end class
} // end namespace
