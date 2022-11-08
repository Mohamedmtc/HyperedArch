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
	/// This class is the base class for any <see cref="FeeFacultyInstallmentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeFacultyInstallmentProviderBase : FeeFacultyInstallmentProviderBaseCore
	{
        #region Custom Methods
        public abstract DataTable GetStudsArrears(TransactionManager transactionManager, decimal EdAcadYearId, decimal AsFacultyInfoId, decimal? DepartmentId, decimal? EdCodeLevelId);
        public abstract bool LoadInstallments(TransactionManager transactionManager, decimal EdAcadYearId, decimal AsFacultyInfoId, decimal EntMainId, decimal EdCodeSemesterId, decimal AsCodeDegreeId, decimal Load, decimal Lang, string _SessionID);
        #endregion
	} // end class
} // end namespace
