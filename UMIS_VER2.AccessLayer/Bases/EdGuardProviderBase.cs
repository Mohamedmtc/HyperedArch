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
	/// This class is the base class for any <see cref="EdGuardProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdGuardProviderBase : EdGuardProviderBaseCore
	{
        public abstract DataTable SearchGuard(TransactionManager transactionManager, System.String _FullNameAr, System.String _FullNameEn,
               System.String _JobTitle, System.String _Email, System.String _CPR, System.String _MobileNum,
               System.String _PhoneNum, System.Decimal _StaffFlg, System.Decimal _CountryNodeId, System.Decimal _PageIndex, System.Decimal _PageSize);

        public abstract DataTable SearchExistingGuard(TransactionManager transactionManager, System.String _StudentCPR, System.String _StudentCode,
                     System.String _GuardCPR);
        
	} // end class
} // end namespace
