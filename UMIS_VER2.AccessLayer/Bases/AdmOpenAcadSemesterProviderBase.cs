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
	/// This class is the base class for any <see cref="AdmOpenAcadSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmOpenAcadSemesterProviderBase : AdmOpenAcadSemesterProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetNextAcadYears_ForDrp(TransactionManager transactionManager, System.Decimal _edAcadYearId);

        public abstract DataTable GetNextSemesters_ForDrp(TransactionManager transactionManager, System.Decimal _edCodeSemesterId);

        public abstract List<EdAcadYear> GetNextAcadYears_Lookup(TransactionManager transactionManager, System.Decimal _edAcadYearId);

        public abstract List<EdCodeSemester> GetNextSemesters_Lookup(TransactionManager transactionManager, System.Decimal _edCodeSemesterId);

        public abstract DataTable GetAdmStatistics(TransactionManager transactionManager, System.Decimal _admOpenAcadSemesterId,decimal CompFlag);

        /// <summary>
        /// Get All Academic Years For Adm
        /// </summary>
        public abstract TList<EdAcadYear> GetAdmAcadYears(TransactionManager transactionManager);

        /// <summary>
        /// Get All Semesters opened for Academic Years In Adm
        /// </summary>
        public abstract TList<EdCodeSemester> GetAdmCodeSemestersForAcadYear(TransactionManager transactionManager, decimal _edAcadYearId);

        #endregion
	} // end class
} // end namespace
