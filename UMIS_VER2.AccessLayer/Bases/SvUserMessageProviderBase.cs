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
	/// This class is the base class for any <see cref="SvUserMessageProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvUserMessageProviderBase : SvUserMessageProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable SearchStudentsByName(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.String _Name, System.Decimal _EntMainId);

        //public override DataTable SearchStudentsByNameInEntityMain(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _Name);

        public abstract DataTable SearchStudentsByGPA(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GPA, System.String _GPA_Flag, System.Decimal _EntMainId);

        public abstract DataTable SearchStudentsByLevel(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Level, System.Decimal _EntMainId);

        public abstract DataTable SearchStudentsByEntMainId(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId);

        public abstract DataTable SearchStudentsByCourseReg(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseId, System.Decimal _EntMainId);

        public abstract DataTable SearchStudentsByAdv(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStfMemberId, System.Decimal _EntMainId);

        public abstract DataTable AllStudents(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract DataTable AllStudentsByAsFacultyInfoId(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId);

        public abstract DataTable AllStudentsByName(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.String _Name);

        public abstract DataTable AllStudentsByGPA(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GPA, System.String _GPA_Flag);

        //public abstract DataTable AllStudentsByLevel(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Level);

        public abstract DataTable AllStudentsByLevel(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Level, System.Decimal _AsFacultyInfoId);

        public abstract DataTable AllStudentsByCourseReg(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseId);

        public abstract DataTable AllStudentsByAdv(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStfMemberId);

        public abstract DataTable SearchStaffsByEntMainId(TransactionManager transactionManager, System.Decimal _EntMainId);

        public abstract DataTable SearchStaffsByName(TransactionManager transactionManager, System.Decimal _Lang, System.String _Name, System.Decimal _EntMainId);

        public abstract DataTable SearchStaffsByDegree(TransactionManager transactionManager, System.Decimal _SaCodeScDegId, System.Decimal _EntMainId);

        public abstract DataTable SearchStaffsByJobStatus(TransactionManager transactionManager, System.Decimal _SaCodeJobStatusId, System.Decimal _EntMainId);

        public abstract DataTable GetUserMessages(TransactionManager transactionManager, System.Decimal _SeUserId);

        public abstract int GetUserNewMessagesCount(TransactionManager transactionManager, System.Decimal _SeUserId);

        #endregion
    } // end class
} // end namespace
