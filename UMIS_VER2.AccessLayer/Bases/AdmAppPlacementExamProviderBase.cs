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
	/// This class is the base class for any <see cref="AdmAppPlacementExamProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppPlacementExamProviderBase : AdmAppPlacementExamProviderBaseCore
    {
        #region Custom Methods
        public abstract DataTable CheckAcceptanceCategory(TransactionManager transactionManager, System.Decimal AdmApplicantId);
        public abstract DataTable GetExamDates(TransactionManager transactionManager, System.Int32? _ExamCodeId, System.String _examDate, System.Int32? _DegClassCodeID, System.Int32? _EntMainId);
        public abstract DataTable GetForViewByDate(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, System.String _examDate, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId);
        public abstract DataTable GetAppExamDates(TransactionManager transactionManager, System.Decimal _admCdePlacementExamId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId);
        public abstract DataTable GetApplicantPlacementExams(TransactionManager transactionManager, System.Decimal AdmApplicantId);
        public abstract DataTable GetPlacementExamApplicants(TransactionManager transactionManager, System.Decimal AdmPlacementExamDateTimeId,decimal PageIndex,decimal PageSize);

        public abstract DataTable GetApplicantExternalPlacementExams(TransactionManager transactionManager, System.Decimal AdmApplicantId);
        
        #endregion
    } // end class
} // end namespace
