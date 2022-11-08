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
	/// This class is the base class for any <see cref="FeeStudFeeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudFeeItemProviderBase : FeeStudFeeItemProviderBaseCore
	{
        #region Custom Methods

        public abstract decimal InsertWithIdOut(TransactionManager transactionManager, FeeStudFeeItem _entity);
        public abstract DataTable GetByStudent(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID, decimal currentAcadYear, int codeTypeID, decimal EdCodeSemesterID, decimal GsCodeCurrencyId);
        public abstract TList<FeeStudFeeItem> GetByStudentFeeCodeTypeID(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID, decimal currentAcadYear, int codeTypeID, decimal EdCodeSemesterID, decimal GsCodeCurrencyId);

        public abstract DataTable GetStudentDelayedFees(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID);

        public abstract DataTable GetStudentDelayedFeesItems(TransactionManager transactionManager, System.Decimal edStudID, decimal facultyID, decimal EdAcadYearId);

        public abstract DataTable GetStudFeeStatus(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID);

        //added by mmq at 01-08-2016
        public abstract DataTable GetStudentFeeItemStatusDetails(TransactionManager transactionManager, System.Decimal _ED_STUD_SEMESTER_ID, System.Decimal _FEE_CODE_TYPE_ID, System.Decimal _lang);
        public abstract DataTable GetStudentFeeItemStatus(TransactionManager transactionManager, System.Decimal _EdStudID, System.Decimal _lang);

        //added by mmq at 08-08-2016
        public abstract DataTable GetFEE_ITEM_STS(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, DateTime? _FromDate, DateTime? _ToDate, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear);

        public abstract DataTable GetSTUD_FEE_ITEM_View(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, string _FeeCodeItemId, string _PayFlag, DateTime? _FromDate, DateTime? _ToDate, string _DiscFlag, string _TotalPaymentsFlag, string _RefundFlag, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear);
        public abstract DataTable GetByStudentsFeesMatrix(TransactionManager transactionManager, string _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdCodeSemesterId, string _EdCodeLevel, DateTime? _Fromdate, DateTime? _Todate, string _PayMethodId, string _Bank, string FromJoinYear, string ToJoinYear, string _JoinSemester, string Range, string Credit, string PageIndex, string PageSize, string StudID, string EnrollType, string FeesIds, int RemainFlag, decimal Status_Stud);
       //added by mmq at 16-08/2016
        public abstract DataTable GetStudentAllFees(TransactionManager transactionManager, System.Decimal _Lang, string _StudId);
        //added by mmq at 22-11/2016
        public abstract DataTable GetStudentExtraChFees(TransactionManager transactionManager, System.Decimal _Lang, decimal EdAcadYearId, decimal AsFacultyId, decimal EdCodeSem, string studentCode, decimal Type, decimal FeeCodeItemId);
    //added by Yassmin Gamal at 09-05-2017
        public abstract DataTable GetSummerFeesandcredithours(TransactionManager transactionManager, decimal EdAcadYearId,   decimal EdCodeSem, decimal EdStudid);

        
        //adedd by mmq at 04-10-2016
        public abstract DataTable GetStudentItemDiscountDetails(TransactionManager transactionManager, System.String _ED_STUD_SEMESTER_ID, System.String _Fee_Code_Item_id, System.Decimal _lang);

        //added by mmq at 14-12-2016
        public abstract DataTable GetFEE_ITEM_STS_New(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, DateTime? _FromDate, DateTime? _ToDate, String _EnrollType, String _range, string FromJoinYear, string ToJoinYear, string paymethod, Decimal ActiveStatues);//Add isAcvtive Marwa 14/12/2021 17560

        public abstract DataTable GetSTUD_FEE_ITEM_View_New(TransactionManager transactionManager, System.Decimal _Lang, string _AsFacultyInfoID, string _EdAcadYearId, string _EdAcadYearId_To, string _EdCodeSemester, string _EdCodeSemesterTo, string _FeeCodeItemId, string _PayFlag, DateTime? _FromDate, DateTime? _ToDate, string _DiscFlag, string _TotalPaymentsFlag, string _RefundFlag, string _EnrollType, string _range, string FromJoinYear, string ToJoinYear, string paymethod, Decimal ActiveStatues);//Add isAcvtive Marwa 14/12/2021 17560

        /*--solve issue added by maha  confirmed with eng.ALi Mohamed --*/
        public abstract DataTable CheckStudFeesPaidPerSemester(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdStudId, decimal FeesType);

        //Menna 01022022
        public abstract DataTable GetFeeStudentCourse(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyId, decimal EdCourseId, decimal ScScheduleDtlId);
        #endregion
	} // end class
} // end namespace
