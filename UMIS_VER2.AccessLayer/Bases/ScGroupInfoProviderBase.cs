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
	/// This class is the base class for any <see cref="ScGroupInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScGroupInfoProviderBase : ScGroupInfoProviderBaseCore
	{
        public abstract DataTable SearchGroups(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoPrntId);

        public abstract DataTable ScheduleSearch(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoId, System.Decimal _ScBuildingId, System.Decimal _ScHallId, System.Decimal _SaStfMemberId, System.Decimal _ScTchngDayId, System.Decimal _EdCourseId, System.Boolean _PeriodId);

        public abstract DataTable ScheduleSearchStud(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edCodeLevelId, System.Decimal _scCdeGrpTypeId, System.Decimal _scGroupInfoId, System.Decimal _ScBuildingId, System.Decimal _ScHallId, System.Decimal _SaStfMemberId, System.Decimal _ScTchngDayId, System.Decimal _EdCourseId, System.Decimal _EdStudId);

        public abstract bool CopyGroupInfo(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EntMainId, decimal EdCodeLevelId, decimal EdAcadYearNewId, decimal EdCodeSemesterNewId);
        
        public abstract DataTable GetTeachingMethodByCourseID(TransactionManager transactionManager, System.Decimal _edCourseID);

        //Added by nashassan 9/8/2016
        public abstract DataTable GetGroupsInfoByTchngMthd(TransactionManager transactionManager, System.Decimal _ScScheduleDtlId);
        //Added Marwa 9/3/2022 17995
        public abstract DataTable CheckCapacityForAddingStudentInSection(TransactionManager transactionManager, decimal SC_GROUP_INFO_ID);
        //Marwa 9/3/2022 17995
        public abstract DataTable CheckGroupCapacity(TransactionManager transactionManager, decimal SC_GROUP_INFO_ID, decimal txtSectionCapacity, decimal EdCourseId, decimal? SectionID);
        //Marwa 21/3/2022 17980
        public abstract DataTable GroupValidation(TransactionManager transactionManager, decimal EdStudID, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyID, decimal Sc_Group_InfoID, decimal SC_Group_TypeID, decimal EdCorseID, decimal? CheckFlag);
   
	} // end class
} // end namespace
