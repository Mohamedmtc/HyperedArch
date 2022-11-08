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
	/// This class is the base class for any <see cref="FeeStudDiscProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudDiscProviderBase : FeeStudDiscProviderBaseCore
	{
        #region Custom Methods
        public abstract DataTable GetByStudent(TransactionManager transactionManager, decimal EdStudID, decimal AsFacultyInfoID, decimal EdAcadYearID,decimal EdCodeSemID);

        public abstract decimal GetStudentTotalDisc(TransactionManager transactionManager, decimal EdStudID, decimal AsFacultyInfoID, decimal EdAcadYearID);//, decimal EdCodeSemId);

        public abstract decimal GetApplicantTotalDisc(TransactionManager transactionManager, decimal _admAppRegHistoryId);

        public abstract bool IsMaxDiscount(TransactionManager transactionManager,  decimal feeStudDiscId, decimal EdStudID, decimal EdAcadYearID, decimal AsFacultyInfoID);

        //kamela,10969
        public abstract DataTable GetFeeDiscOFStudWithIdAndStatus(TransactionManager transactionManager, decimal StudId, decimal ApproveStatus, decimal AsDegreClass);

        public abstract DataTable GETFeeSudDiscUsers(TransactionManager transactionManager);
        #endregion
	} // end class
} // end namespace
