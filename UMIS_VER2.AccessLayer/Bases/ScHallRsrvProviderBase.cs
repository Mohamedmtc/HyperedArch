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
	/// This class is the base class for any <see cref="ScHallRsrvProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScHallRsrvProviderBase : ScHallRsrvProviderBaseCore
	{
         #region Custom Methods
        public abstract DataTable Get_Empty_Hall_S(TransactionManager transactionManager, System.Decimal _CourseId,
             System.Decimal _entMainId, System.Decimal _MaxCapacity, System.Decimal _BuildingId, System.Decimal _CampasId, System.Decimal _hallTypeId, System.DateTime? _fromTime, System.DateTime? _toTime, System.String _DayID, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal ScScheduleDtlId);
      
#endregion
	} // end class
} // end namespace
