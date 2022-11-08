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
	/// This class is the base class for any <see cref="SvCourseEvalProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCourseEvalProviderBase : SvCourseEvalProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetCourses_ForView(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId , string CourseCode , string CourseDesc , decimal PubFlg);

        public abstract DataTable GetCoursesNeedStuff(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal SaStfMamberId);
        /*---task 15565 --- maha 24-12-2020---*/
        public abstract DataTable GetCoursesNeedStuff_Mod(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal SaStfMamberId);

        public abstract DataTable GetStuffCoursesSections(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal EdCourseId, decimal SaStfMamberId,decimal GroupCodeId=0);

        public abstract DataTable GetCourseEvalDetails(TransactionManager transactionManager, decimal SvCourseEvalId);

        public abstract DataTable GetStuffMemberRatings(TransactionManager transactionManager, decimal SaStfMamberId, decimal SectionId, decimal evalItemId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId);

        public abstract DataTable GetStudEvalForStaff(TransactionManager transactionManager, decimal SaStfMamberId, decimal SectionId, decimal evalItemId, decimal courseEvalId);
        public abstract TList<SvCourseEval> GetByEdAcadYearIdEdCodeSemesterIdEdCourseId(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId);
        //Marwa 22/12/2021 17608
        public abstract TList<SvCourseEval> GetByEdAcadYearIdEdCodeSemesterIdEdCourseIdSvCourseEvalID(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId, decimal SvCoursEvalID);
        
        public abstract DataTable GetCourses_ForSet(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId);

        public abstract bool GetCourses_Delete(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId);

        public abstract DataTable GetEvaluatedCourses(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId);
        //Task No:5540, Made By:shaza ,Desc: get course evaluation based on degree class ,Date: 16-4-2019
        public abstract DataTable GetEvaluatedCoursesByDegreeClass(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal AsFacultyInfo, decimal EntMainId, decimal DegreeClassId);
       //End
        public abstract DataTable GetEvalCourseTemplt(TransactionManager transactionManager, decimal EntMainId);

        public abstract bool CourseEvalTemplt_Delete(TransactionManager transactionManager, decimal EdCourseEvalId);

        public abstract bool CopyTemplateToCourses(TransactionManager transactionManager, decimal? EntityMainID, decimal SeUserID);
        #endregion

        //Marwa 21/12/2021 17608
        public abstract string CHECKValidateDateCourseEvaluate(TransactionManager transactionManager, decimal svCourseEvalId, decimal EdAcadYearId, decimal EdCodeSemesterId, DateTime EvalDate, DateTime EvalDueDate, decimal SvCourseEvalId);

        //Marwa 21/12/2021 17608
        public abstract DataTable GetCourseEvalution(TransactionManager transactionManager, decimal AcadYearId, decimal SemesterId,decimal MainId, string CourseIds);
       
    } // end class
} // end namespace
