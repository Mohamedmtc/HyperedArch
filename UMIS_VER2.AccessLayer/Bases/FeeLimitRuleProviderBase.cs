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
	/// This class is the base class for any <see cref="FeeLimitRuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeLimitRuleProviderBase : FeeLimitRuleProviderBaseCore
	{
        public abstract DataTable GetMinStuBalance(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _asCodeDegreeClassId, System.Decimal _asCodeDegreeId, System.Decimal _AsFacultyInfoId);

        public abstract bool CheckFeeLimitRuleExists(TransactionManager transactionManager, System.Int32? _feeLimitRuleId, System.Decimal _asFacultyInfoId, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, System.Decimal _AsCodeDegreeId);
       
    } // end class
} // end namespace
