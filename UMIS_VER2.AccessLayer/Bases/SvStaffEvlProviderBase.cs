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
	/// This class is the base class for any <see cref="SvStaffEvlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStaffEvlProviderBase : SvStaffEvlProviderBaseCore
	{
        public abstract bool GetStaff_Delete(TransactionManager transactionManager, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal SvStaffEvlId);

        public abstract DataTable GetSVStaffTemplt(TransactionManager transactionManager, decimal EdEntityID);

        public abstract bool StaffEvlTemplt_Delete(TransactionManager transactionManager, decimal ScStaffEvlId);

        public abstract bool CopyTemplateToStaff(TransactionManager transactionManager, decimal? EntityMainID, decimal SeUserID);

        //Marwa 9/1/2022 17644
        public abstract DataTable GetGeneralEvalution(TransactionManager transactionManager, decimal AcadYearId, decimal SemesterId, decimal FacultyID, decimal LevelID);
        public abstract DataSet GetGeneralEvalutionDataForPdf(TransactionManager transactionManager, decimal AcadYearId, decimal SemesterId, decimal FacultyID, decimal LevelId, string SVGeneralEVALID);
        
    } // end class
} // end namespace
