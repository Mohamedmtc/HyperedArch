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
	/// This class is the base class for any <see cref="EdGraduationAwardProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdGraduationAwardProviderBase : EdGraduationAwardProviderBaseCore
	{
        public abstract DataTable GetGraduateSpecilaization(TransactionManager transactionManager, decimal? EdStudId);

        public abstract DataTable GetGraduatesCertificates(TransactionManager transactionManager, decimal? EdStudId, decimal? EdAcadYearId, string GRADUATION_AWARD_NUMBER, DateTime? GRADUATION_AWARD_DATE, DateTime? PRESIDENT_APPROVAL_DATE, decimal? AsFacultyInfoId, string FAC_GRADUATION_AWARD_NUMBER, DateTime? FAC_GRADUATION_AWARD_DATE, decimal pageIndex, decimal pageSize);

        public abstract bool UpdateAllGraduatesCertificates(TransactionManager transactionManager, decimal? EdStudId, decimal? EdAcadYearId, string GRADUATION_AWARD_NUMBER, DateTime? GRADUATION_AWARD_DATE, DateTime? PRESIDENT_APPROVAL_DATE, decimal? AsFacultyInfoId, string FAC_GRADUATION_AWARD_NUMBER, DateTime? FAC_GRADUATION_AWARD_DATE, DateTime? DELIVARY_DATE);

        public abstract DataTable GetAllGraduationAwards(TransactionManager transactionManager, decimal? EdAcadYearId, decimal? SemsesterId, string GraduationAwardNumber, DateTime? GraduationAwardDate, DateTime? PresidentApprovalDate, decimal? AsFacultyInfoId, string FacGraduationAwardNumber, DateTime? FacGraduationAwardDate, decimal pageIndex, decimal pageSize, decimal? CodeDegree, decimal? CodeDegreeClass);

        public abstract DataTable GetStudentsHoldForGrad(TransactionManager transactionManager, decimal? EdAcadYearId, decimal? EdCodeSemesterId, decimal? AsCodeDegreeClassId, decimal? AsCodeDegreeId, decimal? AsFacultyInfoId, decimal? EntDeptId, decimal? EntMajId, string StudCode, decimal pageIndex, decimal pageSize);

        public abstract DataTable GetStudentsGrad(TransactionManager transactionManager, decimal EdGraduationAwardId, decimal pageIndex, decimal pageSize);
	} // end class
} // end namespace
