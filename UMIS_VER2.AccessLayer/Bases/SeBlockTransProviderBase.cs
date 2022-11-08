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
    /// This class is the base class for any <see cref="SeBlockTransProviderBase"/> implementation.
    /// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
    ///</summary>
    public abstract partial class SeBlockTransProviderBase : SeBlockTransProviderBaseCore
    {
        #region Custom Methods
        public abstract decimal InsertBlockStudent(TransactionManager transactionManager, SeBlockTrans _entity);
        public abstract bool InsertBulkBlockStudent(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? SectionId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId, decimal UserId);

        public abstract bool BulkBlockTrans(TransactionManager transactionManager,
                                                    System.String SlctdScSchedulDtlID,
                                                    decimal EmpStudFlg,
                                                    decimal? AsFacultyInfoId,
                                                    decimal? EntMainId,
                                                    decimal? EdCodeSemId,
                                                    decimal? EdAcadYearId,
                                                    string courseCode,
                                                    decimal? FlagFreez,
                                                    decimal? BlockType,
                                                    decimal? AsCodeDegreeClassId,
                                                    decimal UserId,
                                                    decimal BulkFlg);

        public abstract void DeleteBlockStudent(TransactionManager transactionManager, System.Decimal SeBlockTransId, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal SeCdeBlockTypeId, System.Decimal ScScheduleDtlId);
        public abstract DataTable GetStudentsToBlosk(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId
            , string StudCode, string StudCodeFrom, string StudCodeTo, decimal? FlagFreez, decimal? AdmissionYear, decimal? OrientationFlag, decimal? EnrollStatus, decimal? LoadType, decimal? paymentflg, decimal? miltirystatus, decimal? GsCodeMilitaryStateId, decimal? BlockReasonID);
        //copied from GetStudentsToBlosk and change sp  by mmq at 30-01-2017 --Task5052
        public abstract DataTable GetStudentsToBlosk_HU(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? AsCodeDegreeclassId
           , string StudCode, string StudCodeFrom, string StudCodeTo, decimal? FlagFreez, decimal? AdmissionYear, decimal? OrientationFlag, decimal? EnrollStatus, decimal? LoadType, decimal? paymentflg, decimal? miltirystatus, decimal? GsCodeMilitaryStateId, decimal? BlockReasonID);

        public abstract DataTable GetCourseSectionToBlosk(TransactionManager transactionManager, decimal? lang, decimal? AsFacultyInfoId, decimal? EntMainId, decimal? EdCodeSemId, decimal? EdAcadYearId, decimal? SectionId, string courseCode, decimal? FlagFreez, decimal? BlockType, decimal? AsCodeDegreeClassId);
        /*-----task 11283  ---KU ----2-12-2019 ---*/
        public abstract void UnBlockStudent_Fees(TransactionManager transactionManager, decimal StudentID, decimal EdAcadYearID, decimal EdCodeSemsterID);
        #endregion
    } // end class
} // end namespace
