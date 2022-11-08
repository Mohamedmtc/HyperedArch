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
	/// This class is the base class for any <see cref="EdSemesterOpenProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdSemesterOpenProviderBase : EdSemesterOpenProviderBaseCore
    {
        #region Custom Methods

        public bool DeleteAllSemesterAgenda(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpenKey key)
        {
            return DeleteAllSemesterAgenda(transactionManager, key.EdSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public bool DeleteAllSemesterAgenda(System.Decimal _edSemesterOpenId)
        {
            return DeleteAllSemesterAgenda(null, _edSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public abstract bool DeleteAllSemesterAgenda(TransactionManager transactionManager, System.Decimal _edSemesterOpenId);

        public abstract bool SP_UpdateSetCurrentSem(TransactionManager transactionManager, System.Decimal _ACD_YEAR, System.Decimal _ED_CODE_SEMESTER_ID, System.Decimal _ent_main_id, decimal? AsCodeDegreeClassId);

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
        /// <param name="key">The unique identifier of the row to delete.</param>
        /// <returns>Returns true if operation suceeded.</returns>
        public decimal ImportFromPreviousAgenda(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpenKey key)
        {
            return ImportFromPreviousAgenda(transactionManager, key.EdSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public decimal ImportFromPreviousAgenda(System.Decimal _edSemesterOpenId)
        {
            return ImportFromPreviousAgenda(null, _edSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public abstract decimal ImportFromPreviousAgenda(TransactionManager transactionManager, System.Decimal _edSemesterOpenId);

        public abstract UMIS_VER2.BusinessLyer.EdSemesterOpen GetForIncompleteScoring(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId);



        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
        /// <param name="key">The unique identifier of the row to delete.</param>
        /// <returns>Returns true if operation suceeded.</returns>
        public bool ImportFromPreviousSem(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpenKey key)
        {
            return ImportFromPreviousSem(transactionManager, key.EdSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public bool ImportFromPreviousSem(System.Decimal _edSemesterOpenId)
        {
            return ImportFromPreviousSem(null, _edSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public abstract bool ImportFromPreviousSem(TransactionManager transactionManager, System.Decimal _edSemesterOpenId);



        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
        /// <param name="key">The unique identifier of the row to delete.</param>
        /// <returns>Returns true if operation suceeded.</returns>
        public DataTable CheckDepartmentsResultApproved(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdSemesterOpenKey key)
        {
            return CheckDepartmentsResultApproved(transactionManager, key.EdSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public DataTable CheckDepartmentsResultApproved(System.Decimal _edSemesterOpenId)
        {
            return CheckDepartmentsResultApproved(null, _edSemesterOpenId);
        }

        /// <summary>
        /// 	Deletes a row from the DataSource.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edSemesterOpenId">. Primary Key.</param>
        /// <remarks>Deletes based on primary key(s).</remarks>
        /// <returns>Returns true if operation suceeded.</returns>
        public abstract DataTable CheckDepartmentsResultApproved(TransactionManager transactionManager, System.Decimal _edSemesterOpenId);
		
		
        #endregion
    } // end class
} // end namespace
