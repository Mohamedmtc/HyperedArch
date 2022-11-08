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
	/// This class is the base class for any <see cref="EdAcadPlanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdAcadPlanProviderBase : EdAcadPlanProviderBaseCore
	{
        public abstract DataTable Search(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _codeDegreeClassId, System.Decimal _isClosed);
        public abstract bool InsertImportedPlan(TransactionManager transactionManager, System.Decimal EDAcadOldPlanId, System.Decimal EdAcadNewPlanId);
        public abstract bool InsertImportedBylaw(TransactionManager transactionManager, System.Decimal EDAcadOldBylawId, System.Decimal EdAcadNewBylawId);
        public abstract TList<EdAcadYear> GetAcadYears(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId);
        public abstract TList<EdAcadYear> GetAcadYears(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId , System.Decimal _asCodeDeegreeClassId);
	} // end class
} // end namespace
