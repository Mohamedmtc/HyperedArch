#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="ModulesTreeViewProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ModulesTreeViewProviderBaseCore : EntityViewProviderBase<ModulesTreeView>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ModulesTreeView&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ModulesTreeView&gt;"/></returns>
		protected static VList&lt;ModulesTreeView&gt; Fill(DataSet dataSet, VList<ModulesTreeView> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ModulesTreeView>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ModulesTreeView&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ModulesTreeView>"/></returns>
		protected static VList&lt;ModulesTreeView&gt; Fill(DataTable dataTable, VList<ModulesTreeView> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ModulesTreeView c = new ModulesTreeView();
					c.ParentId = (Convert.IsDBNull(row["ParentId"]))?0.0m:(System.Decimal?)row["ParentId"];
					c.ModuleId = (Convert.IsDBNull(row["ModuleId"]))?0.0m:(System.Decimal?)row["ModuleId"];
					c.NameEn = (Convert.IsDBNull(row["NameEn"]))?string.Empty:(System.String)row["NameEn"];
					c.NameAr = (Convert.IsDBNull(row["NameAr"]))?string.Empty:(System.String)row["NameAr"];
					c.NodePath = (Convert.IsDBNull(row["NodePath"]))?string.Empty:(System.String)row["NodePath"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;ModulesTreeView&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ModulesTreeView&gt;"/></returns>
		protected VList<ModulesTreeView> Fill(IDataReader reader, VList<ModulesTreeView> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ModulesTreeView entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ModulesTreeView>("ModulesTreeView",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ModulesTreeView();
					}
					
					entity.SuppressEntityEvents = true;

					entity.ParentId = (reader.IsDBNull(((int)ModulesTreeViewColumn.ParentId)))?null:(System.Decimal?)reader[((int)ModulesTreeViewColumn.ParentId)];
					//entity.ParentId = (Convert.IsDBNull(reader["ParentId"]))?0.0m:(System.Decimal?)reader["ParentId"];
					entity.ModuleId = (reader.IsDBNull(((int)ModulesTreeViewColumn.ModuleId)))?null:(System.Decimal?)reader[((int)ModulesTreeViewColumn.ModuleId)];
					//entity.ModuleId = (Convert.IsDBNull(reader["ModuleId"]))?0.0m:(System.Decimal?)reader["ModuleId"];
					entity.NameEn = (reader.IsDBNull(((int)ModulesTreeViewColumn.NameEn)))?null:(System.String)reader[((int)ModulesTreeViewColumn.NameEn)];
					//entity.NameEn = (Convert.IsDBNull(reader["NameEn"]))?string.Empty:(System.String)reader["NameEn"];
					entity.NameAr = (reader.IsDBNull(((int)ModulesTreeViewColumn.NameAr)))?null:(System.String)reader[((int)ModulesTreeViewColumn.NameAr)];
					//entity.NameAr = (Convert.IsDBNull(reader["NameAr"]))?string.Empty:(System.String)reader["NameAr"];
					entity.NodePath = (reader.IsDBNull(((int)ModulesTreeViewColumn.NodePath)))?null:(System.String)reader[((int)ModulesTreeViewColumn.NodePath)];
					//entity.NodePath = (Convert.IsDBNull(reader["NodePath"]))?string.Empty:(System.String)reader["NodePath"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="ModulesTreeView"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ModulesTreeView"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ModulesTreeView entity)
		{
			reader.Read();
			entity.ParentId = (reader.IsDBNull(((int)ModulesTreeViewColumn.ParentId)))?null:(System.Decimal?)reader[((int)ModulesTreeViewColumn.ParentId)];
			//entity.ParentId = (Convert.IsDBNull(reader["ParentId"]))?0.0m:(System.Decimal?)reader["ParentId"];
			entity.ModuleId = (reader.IsDBNull(((int)ModulesTreeViewColumn.ModuleId)))?null:(System.Decimal?)reader[((int)ModulesTreeViewColumn.ModuleId)];
			//entity.ModuleId = (Convert.IsDBNull(reader["ModuleId"]))?0.0m:(System.Decimal?)reader["ModuleId"];
			entity.NameEn = (reader.IsDBNull(((int)ModulesTreeViewColumn.NameEn)))?null:(System.String)reader[((int)ModulesTreeViewColumn.NameEn)];
			//entity.NameEn = (Convert.IsDBNull(reader["NameEn"]))?string.Empty:(System.String)reader["NameEn"];
			entity.NameAr = (reader.IsDBNull(((int)ModulesTreeViewColumn.NameAr)))?null:(System.String)reader[((int)ModulesTreeViewColumn.NameAr)];
			//entity.NameAr = (Convert.IsDBNull(reader["NameAr"]))?string.Empty:(System.String)reader["NameAr"];
			entity.NodePath = (reader.IsDBNull(((int)ModulesTreeViewColumn.NodePath)))?null:(System.String)reader[((int)ModulesTreeViewColumn.NodePath)];
			//entity.NodePath = (Convert.IsDBNull(reader["NodePath"]))?string.Empty:(System.String)reader["NodePath"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ModulesTreeView"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ModulesTreeView"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ModulesTreeView entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ParentId = (Convert.IsDBNull(dataRow["ParentId"]))?0.0m:(System.Decimal?)dataRow["ParentId"];
			entity.ModuleId = (Convert.IsDBNull(dataRow["ModuleId"]))?0.0m:(System.Decimal?)dataRow["ModuleId"];
			entity.NameEn = (Convert.IsDBNull(dataRow["NameEn"]))?string.Empty:(System.String)dataRow["NameEn"];
			entity.NameAr = (Convert.IsDBNull(dataRow["NameAr"]))?string.Empty:(System.String)dataRow["NameAr"];
			entity.NodePath = (Convert.IsDBNull(dataRow["NodePath"]))?string.Empty:(System.String)dataRow["NodePath"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ModulesTreeViewFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ModulesTreeView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ModulesTreeViewFilterBuilder : SqlFilterBuilder<ModulesTreeViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModulesTreeViewFilterBuilder class.
		/// </summary>
		public ModulesTreeViewFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ModulesTreeViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ModulesTreeViewFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ModulesTreeViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ModulesTreeViewFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ModulesTreeViewFilterBuilder

	#region ModulesTreeViewParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ModulesTreeView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ModulesTreeViewParameterBuilder : ParameterizedSqlFilterBuilder<ModulesTreeViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModulesTreeViewParameterBuilder class.
		/// </summary>
		public ModulesTreeViewParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ModulesTreeViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ModulesTreeViewParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ModulesTreeViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ModulesTreeViewParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ModulesTreeViewParameterBuilder
	
	#region ModulesTreeViewSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ModulesTreeView"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ModulesTreeViewSortBuilder : SqlSortBuilder<ModulesTreeViewColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModulesTreeViewSqlSortBuilder class.
		/// </summary>
		public ModulesTreeViewSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ModulesTreeViewSortBuilder

} // end namespace
