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
	/// This class is the base class for any <see cref="EdStudFacultyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudFacultyProviderBase : EdStudFacultyProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetHonorDegreeForStudent(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _asFacultyInfoId, System.Decimal _cGPA);

        public abstract DataTable GetStudentEntities(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _asFacultyInfoId);

        public abstract EdStudFaculty GetByStudFacultyCode(System.String _studFacultyCode);
        public abstract TList<EdStudFaculty> GetByAdmApplicantIdModular(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);

        public TList<EdStudFaculty> GetByAdmApplicantIdModular(TransactionManager transactionManager, System.Decimal _admApplicantId)
        {
            int count = -1;
            return GetByAdmApplicantIdModular(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
        }
        #endregion
	} // end class
} // end namespace
