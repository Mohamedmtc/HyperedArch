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
	/// This class is the base class for any <see cref="EdStudExcuseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudExcuseProviderBase : EdStudExcuseProviderBaseCore
	{
        #region Custom Methods

        public abstract decimal GetLatestID(TransactionManager transactionManager);

        public abstract DataTable GetAllForApprove(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId, decimal _Lang, decimal _GsCodeReqStateId, decimal _EdCodeExcuseTypeId, string _StudName, string _StudFacultyCode, DateTime _FromDate, DateTime _ToDate);

        public abstract DataTable GetStudExcuses(TransactionManager transactionManager, decimal _EdAcadYearId, decimal _EdCodeSemesterId, decimal _AsFacultyInfoId, decimal _EdStudId);

        #endregion
	} // end class
} // end namespace
