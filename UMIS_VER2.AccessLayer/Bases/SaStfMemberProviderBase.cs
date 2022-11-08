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
	/// This class is the base class for any <see cref="SaStfMemberProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaStfMemberProviderBase : SaStfMemberProviderBaseCore
    {
        #region Custom Methods
        public TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(System.Decimal _asFacultyInfoId, System.Decimal _entMainId)
        {
            int count = -1;
            return GetByAsFacultyInfoIdAndEntMainId(_asFacultyInfoId, _entMainId, 0, int.MaxValue, out count);
        }

        public TList<SaStfMember> GetStudentInstructor(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _EdStudId)
        {
            int count = -1;
            return GetStudentInstructor(transactionManager, _EdAcadYearId, _EdCodeSemId, _EdStudId, 0, int.MaxValue, out count);
        }


        public TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId)
        {
            int count = -1;
            return GetByAsFacultyInfoIdAndEntMainId(transactionManager, _asFacultyInfoId, _entMainId, 0, int.MaxValue, out count);
        }
        public TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, int start, int pageLength)
        {
            int count = -1;
            return GetByAsFacultyInfoIdAndEntMainId(transactionManager, _asFacultyInfoId, _entMainId, start, pageLength, out count);
        }

        public TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(System.Decimal _asFacultyInfoId, System.Decimal _entMainId, int start, int pageLength)
        {
            int count = -1;
            return GetByAsFacultyInfoIdAndEntMainId(null, _asFacultyInfoId, _entMainId, start, pageLength, out count);
        }
        public TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(System.Decimal _asFacultyInfoId, System.Decimal _entMainId, int start, int pageLength, out int count)
        {
            return GetByAsFacultyInfoIdAndEntMainId(null, _asFacultyInfoId, _entMainId, start, pageLength, out count);
        }
        public abstract TList<SaStfMember> GetStudentInstructor(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _EdStudId, int start, int pageLength, out int count);

        public abstract TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, int start, int pageLength, out int count);
        public TList<SaStfMember> GetForAdviseView(TransactionManager transactionManager, System.Decimal? _EdAcadYear, System.Decimal? _EdCodeSem, System.Decimal? _AsFacultyInfo, System.Decimal? _entityMainId, System.Decimal? _lang)
        {
            int count = -1;
            return GetForAdviseView(transactionManager, _EdAcadYear, _EdCodeSem, _AsFacultyInfo, _entityMainId,_lang, 0, int.MaxValue, out count);
        }
        public abstract TList<SaStfMember> GetForAdviseView(TransactionManager transactionManager, System.Decimal? _EdAcadYear, System.Decimal? _EdCodeSem, System.Decimal? _AsFacultyInfo, System.Decimal? _entityMainId, System.Decimal? _lang, int start, int pageLength, out int count);

        public TList<SaStfMember> GetByOfferingId(TransactionManager transactionManager, System.Decimal? _EdOfferingId)
        {
            int count = -1;
            return GetByOfferingId(transactionManager, _EdOfferingId, 0, int.MaxValue, out count);
        }

        public abstract TList<SaStfMember> GetByOfferingId(TransactionManager transactionManager, System.Decimal? _EdOfferingId, int start, int pageLength, out int count);

        public abstract TList<SaStfMember> GetDepartmentStaff(TransactionManager transactionManager, System.Decimal _DeptEntMainId, System.String _Lang);

        public abstract TList<SaStfMember> GetSpecificDepartmentStaff(TransactionManager transactionManager, System.Decimal _DeptEntMainId, System.String _Lang);
        
        public DataTable StufCoursesTimeTable(System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStufMemberID)
        {
            return StufCoursesTimeTable(null, _AsFacultyInfoId, _EdAcadYearId, _EdCodeSemesterId, _SaStufMemberID);
        }
        public abstract DataTable StufCoursesTimeTable(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStufMemberID);

        public abstract decimal InsertWithStfMemIdOut(TransactionManager transactionManager, SaStfMember _entity);
        public abstract bool InsertStf(TransactionManager transactionManager, SaStfMember entity);
        
        
        public abstract DataTable GetStufTeachingCourses(TransactionManager transactionManager, System.Decimal _SaStfMemberID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract DataTable GetStufCourseGroups(TransactionManager transactionManager, System.Decimal _SaStfMemberID, System.Decimal _EdCourseId);

        public abstract DataTable GetStaffsForStudent(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        public abstract SaStfMember GetBySchedule(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal EdCourseID, decimal ScScheduleDtlID, decimal GsCodeWeekID, decimal ScTchngSlotID);


        public abstract DataTable GetStaffCreditHours(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal GsCodeWeekID, decimal AsNodeID);

        public abstract DataTable SearchStaffMemOfficeHours(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.String _StfName, System.Decimal _GsCodeWeekDayId, System.Decimal _NumHouresFrom, System.Decimal _NumHouresTo);

        //Esraa Ali         8-7-2019           10194
        public abstract TList<SaStfMember> GetStfByEdStudSemIDandCrsID(TransactionManager transactionManager, System.Decimal _EdStudSemesterId, System.Decimal _EdCourseId);

        //Esraa Ali     27-5-2020     13648
        //Start
        public abstract DataTable INTEG_GetTeachers(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID);

        public abstract DataTable INTEG_GetTeacherRoster(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID);
        //End

        //Angham 25/11/2020
        public abstract TList<SaStfMember> GetStaffAvailable(System.Decimal? StfMemberId, System.Decimal AcadYearID, System.Decimal SemsterID, System.String StfName, string XMLData);
        //End Angham 25/11/2020
        #endregion
    } // end class
} // end namespace
