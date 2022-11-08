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
	/// This class is the base class for any <see cref="CoCrsRsltRaiseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoCrsRsltRaiseProviderBase : CoCrsRsltRaiseProviderBaseCore
	{
        public abstract DataTable CoCrsRsltRaiseGetSearch(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode, decimal _AsCodeDegreeClassId);
        public abstract bool ApplyRaise(TransactionManager transactionManager,  System.Decimal _CoCrsRsltRaiseId, System.Decimal _DeleteFlg);
    } // end class

} // end namespace
