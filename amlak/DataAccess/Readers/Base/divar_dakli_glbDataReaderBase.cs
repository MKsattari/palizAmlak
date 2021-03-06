using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;

using RAD.AppFramework.Data;
using RAD.AppFramework.QueryObjects;

using amlak.Common;
using amlak.DataAccess;

namespace amlak.DataAccess.Readers.Base
{
	/// <summary>
	/// Base class for the divar_dakli_glbDataReader
	/// <seealso cref="divar_dakli_glbDataReader"/>
	/// </summary>
	/// <remarks>
	/// Provides forward-only read access to the divar_dakli_glb table.
	/// 
	/// This class has been auto-generated and should not be modified. Any modifications should
	/// be made to the <see cref="divar_dakli_glbDataReader">divar_dakli_glbDataReader</see> class.
	/// <br/><br/>
	/// This class was automatically generated by Rad Software NextGeneration <a href="http://www.radsoftware.com.au">http://www.radsoftware.com.au</a>
	/// </remarks>
	public class divar_dakli_glbDataReaderBase : StronglyTypedDataReader
	{		
		#region Fields
	
		/// <summary>The ordinal position of the szh_id column in the result set</summary>
		protected int m_szh_idOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_id column in the result set</summary>
		protected int m_divar_dakli_glb_idOrdinal;
			
		#endregion
		
		
		#region Constructors
		
		/// <summary>
		/// Creates a new divar_dakli_glbDataReaderBase
		/// </summary>
		public divar_dakli_glbDataReaderBase()
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			Connection = DataObjectFactory.CreateConnection();
		}
		
		#endregion
		

		#region Column Attributes


		/// <summary>
		/// Returns the value of the szh_id column for the current row
		/// </summary>
		public Int32 szh_id
		{
			get 
			{
					return (Int32)DataRecord[m_szh_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_id column for the current row
		/// </summary>
		public Int32 divar_dakli_glb_id
		{
			get 
			{
					return (Int32)DataRecord[m_divar_dakli_glb_idOrdinal];
			}
		}
	

		#endregion

		
		#region Private Methods
		
		/// <summary>
		/// Sets the indexes of the columns within the result set
		/// </summary>
		protected override void SetColumnOrdinals()
		{
			m_szh_idOrdinal = DataReader.GetOrdinal("szh_id");
			m_divar_dakli_glb_idOrdinal = DataReader.GetOrdinal("divar_dakli_glb_id");
		}
		
		#endregion
		
		
		#region Public Methods
		
		/// <summary>
		/// Selects all rows from the divar_dakli_glb table
		/// </summary>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectAll()
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_divar_dakli_glb_SelectAll";
			
			return OpenReader();
		}
		
		/// <summary>
		/// Selects rows from the divar_dakli_glb table by Query definion
		/// </summary>
		/// <param name="queryDefinition">A Query object that defines the Query used to select rows from the database</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectByQuery(Query queryDefinition)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();

			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.Text);

			if (queryDefinition.TableName.Length == 0)
			{
				queryDefinition.TableName = "gv_divar_dakli_glb";
			}

			queryDefinition.BuildCommand(CommandSelect);

			return OpenReader();
		}
		
		
		/// <summary>
		/// Selects rows from the divar_dakli_glb table by Primary Key (szh_id, divar_dakli_glb_id)
		/// </summary>
		/// <param name="szh_id">The szh_id to use as search criteria</param>
		/// <param name="divar_dakli_glb_id">The divar_dakli_glb_id to use as search criteria</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectByszh_idAnddivar_dakli_glb_id(Int32 szh_id, Int32 divar_dakli_glb_id)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id";
			
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@szh_id", SqlDbType.Int, szh_id));
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@divar_dakli_glb_id", SqlDbType.Int, divar_dakli_glb_id));
			
			return OpenReader();
		}
		
		/// <summary>
		/// Selects rows from the divar_dakli_glb table by divar_dakli_glb_id
		/// </summary>
		/// <param name="divar_dakli_glb_id">The divar_dakli_glb_id to use as search criteria</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectBydivar_dakli_glb_id(Int32 divar_dakli_glb_id)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_divar_dakli_glb_SelectBydivar_dakli_glb_id";
			
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@divar_dakli_glb_id", SqlDbType.Int, divar_dakli_glb_id));
			
			return OpenReader();
		}
		
		
		
		
		#endregion
	}
}
