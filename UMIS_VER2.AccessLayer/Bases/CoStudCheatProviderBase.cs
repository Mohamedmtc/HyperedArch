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
	/// This class is the base class for any <see cref="CoStudCheatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoStudCheatProviderBase : CoStudCheatProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetCheatIncedints(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId);

        public abstract DataTable GetControlExams(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId);

        public abstract DataTable GetControlExamCommittees(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId);

        public abstract DataTable GetControlExamCommitteeMembers(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _coExamCommitteeId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId);

        public abstract DataTable GetControlExamCommitteeStudents(TransactionManager transactionManager, System.Decimal _coControlId, System.Decimal _edExamSchdlId, System.Decimal _coExamCommitteeId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId);

        public abstract DataTable GetControlExamDetails(TransactionManager transactionManager, System.Decimal _edExamSchdlId);

        #endregion
	} // end class
} // end namespace
