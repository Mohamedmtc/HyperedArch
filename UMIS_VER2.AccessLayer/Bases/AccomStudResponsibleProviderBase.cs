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
	/// This class is the base class for any <see cref="AccomStudResponsibleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudResponsibleProviderBase : AccomStudResponsibleProviderBaseCore
    {
        #region coustom Methods
        public abstract DataTable GetACCOMSTUDRESPONSIBLE(TransactionManager transactionManager, decimal EdAcadYearJoinId, decimal EdCodeSemesterJoinId, decimal AsFacultyInfoId, decimal _NamePolicy,
            string _StudClFullName, decimal EdstudId, decimal LangNum, decimal AsDegreeId, decimal? EdCodeLEvelId = null, decimal? MajorId = null, decimal? MinorId = null);
        #endregion
    } // end class
} // end namespace
