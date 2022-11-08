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
	/// This class is the base class for any <see cref="ScSectionGroupHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScSectionGroupHdrProviderBase : ScSectionGroupHdrProviderBaseCore
	{
        public abstract DataTable GetSectionGroupHdrList(TransactionManager transactionManager, System.Decimal _AsCodeDegreeClassId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EntMainId, System.Decimal _GrpTypeFlg, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal? _EdCourseId, string _GroupCode, System.Decimal _IsActive, System.Decimal? _SttafId);
		
		public abstract int GetMinNoAvailForGroupHdrLoad(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId);
        public abstract DataTable GetMinFromToDateForGroupHdrLoad(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId);
        public abstract DataTable Get_SECTION_GROUP_In_Department(TransactionManager transactionManager, System.Decimal _AsCodeDegreeClassId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EntMainId, System.Decimal _GrpTypeFlg, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

	} // end class
} // end namespace
