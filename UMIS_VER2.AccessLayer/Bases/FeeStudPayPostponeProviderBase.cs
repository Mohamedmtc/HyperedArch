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
	/// This class is the base class for any <see cref="FeeStudPayPostponeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudPayPostponeProviderBase : FeeStudPayPostponeProviderBaseCore
	{
        //added by mmq at 06-02-2017
        public abstract DataTable GetFeeStudPayPostpone(TransactionManager transactionManager, System.Decimal _Lang,  decimal EdAcadYearId ,decimal EdCodeSemesterId , decimal PayFlag , decimal EdstudId, decimal? AsFacultyInfoId = null, decimal? AsCodeDereeClassId = null);
        public abstract DataTable GetFeeStudExceptions(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsCodeDegreeId, decimal AsFacultyInfoId, decimal EntMainId, decimal EdCodeLevelId, decimal HasException, decimal IsSponsered, decimal SponserId, decimal Lang, decimal StudID, decimal degreeClassId);
	} // end class
} // end namespace
