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
	/// This class is the base class for any <see cref="EdStudAbsFwProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudAbsFwProviderBase : EdStudAbsFwProviderBaseCore
    {
        #region Custom Methods
        public abstract DataTable GetStudsForAttendanceWarning(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.Decimal _fromPercent, System.Decimal _toPercent, System.Decimal _seqNo);        
        public abstract DataTable GetAllAttendanceWarningForView(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.String _studName, System.Decimal _AsCodeDegreeClass, System.Decimal _scScheduleDtlId, System.Decimal _WarningType, System.Decimal _majorId);

        //Esraa Ali         2-4-2019            8493
        public abstract DataTable GetAllAttendanceWarning_TOT_CRS_CHForView(TransactionManager transactionManager, System.Decimal ?_asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.String _studName, System.Decimal _AsCodeDegreeClass, System.Decimal _scScheduleDtlId, System.Decimal _WarningType, System.Decimal _majorId);

        public abstract DataTable GetModularAllAttendanceWarningForView(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _edCourseId, System.String _studName, System.Decimal _AsCodeDegreeClass, System.Decimal _scScheduleDtlId, System.Decimal _WarningType, System.Decimal _majorId);
        #endregion
    } // end class
} // end namespace
