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
	/// This class is the base class for any <see cref="EdCodeSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeSemesterProviderBase : EdCodeSemesterProviderBaseCore
	{
        public abstract DataTable GetNextSemester(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId,decimal _edCodeSemesterTypeid);
        public abstract DataTable GetNextSemesteropen(TransactionManager transactionManager, System.Decimal _edAcadYearId, System.Decimal _edCodeSemesterId, decimal _edCodeSemesterTypeid, decimal _AsFacultyInfoId);

    } // end class
} // end namespace
