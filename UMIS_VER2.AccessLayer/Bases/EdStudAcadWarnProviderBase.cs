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
	/// This class is the base class for any <see cref="EdStudAcadWarnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudAcadWarnProviderBase : EdStudAcadWarnProviderBaseCore
    {
        #region Custom Methods
        public abstract DataTable GetStudsForAcademicWarning(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _lang, System.Decimal _cGPA, System.Decimal _edCodelevelId, System.Decimal _dpEntityMainId, System.Decimal __majEntityMainId);
        public abstract DataTable GetAllAcademicWarningForView(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _lang, System.String _studCode, System.Decimal _warnNo, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCodeLevelId, System.Decimal _asCodeDegreeClassId);
        public abstract DataTable GetStudentEmails(TransactionManager transactionManager, System.Decimal _edStudId);
        #endregion
    } // end class
} // end namespace
