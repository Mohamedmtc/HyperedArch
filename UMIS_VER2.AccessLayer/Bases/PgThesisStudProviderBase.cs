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
    /// This class is the base class for any <see cref="PgThesisStudProviderBase"/> implementation.
    /// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
    ///</summary>
    public abstract partial class PgThesisStudProviderBase : PgThesisStudProviderBaseCore
    {
        #region "Custom methods"

        public abstract DataTable GetThesis_List(TransactionManager transactionManager, System.Decimal? _EntMainId,
                                                 System.Decimal? _asCodeDegree,
                                                 System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId,
                                                 System.Decimal _EdCodeSemesterId, System.String _EdStudName,
                                                 System.String studCode, System.Decimal admYear,
                                                 System.Decimal grant_Flg, System.String thesisSubj);


        public abstract DataTable GetStudWithAcceptResearch(TransactionManager transactionManager, System.Decimal? EntMainMajorId, System.Decimal? EntMainMinorId,
         System.Decimal _EdAcadYearId, System.Decimal AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.String _EdStudName, System.String studCode,
          System.String _SuprviserName, System.String _DiscusserName, System.Decimal? _asCodeDegree, System.String _ReaserchTitle);

        //Kamela, 13866, Rasd Research Courses
        public abstract DataTable GetResearchStudsForGrading(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId,
             System.Decimal AsFacultyInfoId, System.Decimal? EntMainMajorId, System.Decimal? EntMainMinorId, System.String ReaserchTitle,System.String studCode,
         System.String EdStudName, System.Decimal? EdCourseId, System.Decimal? AssessHDRId, System.Decimal? Approve_Flg, System.Decimal? SatffMEmebr_Id);
        //end

        #endregion
    } // end class
} // end namespace
