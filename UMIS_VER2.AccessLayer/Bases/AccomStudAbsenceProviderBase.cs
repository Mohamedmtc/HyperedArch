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
	/// This class is the base class for any <see cref="AccomStudAbsenceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudAbsenceProviderBase : AccomStudAbsenceProviderBaseCore
	{
        #region Custom Methods
        public abstract DataTable GetAccomAbsenceStuds(TransactionManager transactionManager, decimal EdAcadYearId,decimal EdCodeSemesterId, decimal AsFacultyInfoId,
           decimal _NamePolicy, decimal? EdCodeLevelId, string _StudClFullName, decimal EdstudId, decimal LangNum, DateTime? AbsenceDate, decimal? GenderId = null , decimal FajrFlg = 0, decimal? AsCodeDegreeClass = null);

        #endregion
	} // end class
} // end namespace
