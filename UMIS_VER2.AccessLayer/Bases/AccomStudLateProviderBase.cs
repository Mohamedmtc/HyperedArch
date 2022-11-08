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
	/// This class is the base class for any <see cref="AccomStudLateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudLateProviderBase : AccomStudLateProviderBaseCore
	{
        #region Custom Methods
        public abstract DataTable GetBookedMaleStudsforLateness(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal AsFacultyInfoId,
              decimal AsdegreeId, decimal _NamePolicy, string _StudClFullName, decimal EdstudId, decimal? EdCodeLevelId, decimal Lang, decimal CurrentDateFlg , DateTime? LatenessDate, 
             decimal? MajorId = null , decimal? MinorId = null ,decimal? GenderId = null );
        #endregion
	} // end class
} // end namespace
