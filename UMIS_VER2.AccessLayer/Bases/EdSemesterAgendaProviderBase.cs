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
	/// This class is the base class for any <see cref="EdSemesterAgendaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdSemesterAgendaProviderBase : EdSemesterAgendaProviderBaseCore
	{
        public abstract DataTable GetByEdSemesterOpenId_DataTable(TransactionManager transactionManager, System.Decimal _edSemesterOpenId);
        public abstract DataTable Get_Agenda_Activity(TransactionManager transactionManager, System.Decimal ED_SEMESTER_OPEN_ID, decimal? STUD_FLG, decimal? STF_FLG, decimal? EMP_FLG, System.Decimal AS_CODE_DEGREE_CLASS_ID, decimal? DtlFlg, decimal? ShowFlag);


        public abstract TList<EdSemesterAgenda> GetAgendaByOpensemIDClassDegree(TransactionManager transactionManager, decimal _edSemesterOpenId, decimal _AsCodeDegreeClassID);
     

	} // end class
} // end namespace
