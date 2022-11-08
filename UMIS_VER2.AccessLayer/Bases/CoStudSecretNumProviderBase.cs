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
	/// This class is the base class for any <see cref="CoStudSecretNumProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoStudSecretNumProviderBase : CoStudSecretNumProviderBaseCore
	{
        public abstract DataTable DeleteStudSecretNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ENT_MAIN_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID);
        public abstract DataTable GetSECRET_NUM(TransactionManager transactionManager, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal ED_ACAD_YEAR_ID, System.String SECRET_NUM);
        public abstract DataTable GetStudSecretNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal? ENT_MAIN_ID, System.Decimal ED_CODE_LEVEL_ID ,System.Decimal ED_EXAM_TYPE_ID);
        public abstract DataTable GetStudSerialNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID, System.Decimal ExamTypeId, System.Decimal DepId, System.Decimal MajorId);
        public abstract DataTable GetStudSerialNumStatastics(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID);
        public abstract DataTable GetStudToCreateSerialNum(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal AS_FACULTY_INFO_ID, System.Decimal ED_CODE_LEVEL_ID, System.Decimal ED_COURSE_ID, System.Decimal DepId, System.Decimal MajorId);

    } // end class
} // end namespace
