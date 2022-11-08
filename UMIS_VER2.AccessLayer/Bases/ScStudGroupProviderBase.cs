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
	/// This class is the base class for any <see cref="ScStudGroupProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScStudGroupProviderBase : ScStudGroupProviderBaseCore
	{
        public abstract DataTable GetStudsInGroup(TransactionManager transactionManager, System.Decimal _scGroupInfoId);

        public abstract DataTable StudentsSearchForAdd(TransactionManager transactionManager, System.Decimal _scGroupInfoId, decimal _edCodeLevelId, string _studCode);

        public abstract DataTable SC_Get_Count_Of_Students(TransactionManager transactionManager, System.Decimal asFacultyInfoId, System.Decimal EDCODESEMESTERID, System.Decimal EDACADYEARID, System.Decimal EDCODELEVELID, System.Decimal ENTMAINID, System.Decimal SCGROUPINFOPRNTID, System.Decimal EDCOURSEID, decimal GrpTypeId);

        public abstract void AutoGenerateSubGroupInfo(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EntMainId, decimal EdCodeLevelId, decimal EdCourseId, decimal ScGroupInfoPrntId,decimal GrpTypeId, decimal TotStudCount, decimal GroupCount, decimal GroupStudCount, decimal OrderTypeId, string grpPrfx);
        //Angham 25/11/2020
        public abstract Boolean ValidateIFStudentsInGroupSection(TransactionManager transactionManager, System.Decimal AsFacultyInfoId, System.Decimal EdcodeSemesterId,
                   System.Decimal AcadYearID, System.Decimal EdCodeLevelID, System.Decimal MajorID, decimal GrpTypeId);
        //End Angham 25/11/2020

    } // end class
} // end namespace
