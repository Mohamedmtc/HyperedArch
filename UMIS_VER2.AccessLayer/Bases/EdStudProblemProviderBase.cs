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
	/// This class is the base class for any <see cref="EdStudProblemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudProblemProviderBase : EdStudProblemProviderBaseCore
	{
        //Menna 12-02-2020 tfs 13068
        public abstract DataTable GetByViolatStd(TransactionManager transactionManager, System.Decimal? _AsFacultyInfoId, System.Decimal? _AcadYearId, System.Decimal? _EdCodeSemesterId, string _StudFacultyCode, System.Decimal? _GsCdeViolCatId, System.Decimal? _GsCdeViolId,
          DateTime? _ViolFromDate, DateTime? _ViolToDate, string _StudentName, System.Decimal? _NamePolicy, bool? _IsEnglish, string _STFCode, decimal? AsCodeDegreeClassId = null);


   
	} // end class
} // end namespace
