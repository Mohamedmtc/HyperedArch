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
	/// This class is the base class for any <see cref="MltStudInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MltStudInfoProviderBase : MltStudInfoProviderBaseCore
	{
        public abstract DataTable StudentsSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal _MltOrgTreeId, System.String _StudCode);
        public abstract DataTable StudentsSearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal _MltOrgTreeId, System.String _StudCode,System.Decimal _VaccSerial, System.Decimal _MdiCdeVaccId);

        public abstract DataTable StudentsSearchForAdd(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal _MltOrgTreeId, System.String _StudCode);
	} // end class
} // end namespace
