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
	/// Base class for the sazehDataReader
	/// <seealso cref="sazehDataReader"/>
	/// </summary>
	/// <remarks>
	/// Provides forward-only read access to the sazeh table.
	/// 
	/// This class has been auto-generated and should not be modified. Any modifications should
	/// be made to the <see cref="sazehDataReader">sazehDataReader</see> class.
	/// <br/><br/>
	/// This class was automatically generated by Rad Software NextGeneration <a href="http://www.radsoftware.com.au">http://www.radsoftware.com.au</a>
	/// </remarks>
	public class sazehDataReaderBase : StronglyTypedDataReader
	{		
		#region Fields
	
		/// <summary>The ordinal position of the szh_id column in the result set</summary>
		protected int m_szh_idOrdinal;
		/// <summary>The ordinal position of the mlk_id column in the result set</summary>
		protected int m_mlk_idOrdinal;
		/// <summary>The ordinal position of the rsht_id column in the result set</summary>
		protected int m_rsht_idOrdinal;
		/// <summary>The ordinal position of the modirt_id column in the result set</summary>
		protected int m_modirt_idOrdinal;
		/// <summary>The ordinal position of the shrstan_id column in the result set</summary>
		protected int m_shrstan_idOrdinal;
		/// <summary>The ordinal position of the shobh_id column in the result set</summary>
		protected int m_shobh_idOrdinal;
		/// <summary>The ordinal position of the fndsion_noe_id column in the result set</summary>
		protected int m_fndsion_noe_idOrdinal;
		/// <summary>The ordinal position of the fndsion_tozi column in the result set</summary>
		protected int m_fndsion_toziOrdinal;
		/// <summary>The ordinal position of the sgf_noe_id column in the result set</summary>
		protected int m_sgf_noe_idOrdinal;
		/// <summary>The ordinal position of the sgf_sayr column in the result set</summary>
		protected int m_sgf_sayrOrdinal;
		/// <summary>The ordinal position of the sgf_tozi column in the result set</summary>
		protected int m_sgf_toziOrdinal;
		/// <summary>The ordinal position of the sklt_noe_id column in the result set</summary>
		protected int m_sklt_noe_idOrdinal;
		/// <summary>The ordinal position of the sklt_tozi column in the result set</summary>
		protected int m_sklt_toziOrdinal;
		/// <summary>The ordinal position of the sklt_sayr column in the result set</summary>
		protected int m_sklt_sayrOrdinal;
		/// <summary>The ordinal position of the divar_karji_glb_id column in the result set</summary>
		protected int m_divar_karji_glb_idOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_partition column in the result set</summary>
		protected int m_divar_dakli_glb_partitionOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_simani column in the result set</summary>
		protected int m_divar_dakli_glb_simaniOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_lika column in the result set</summary>
		protected int m_divar_dakli_glb_likaOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_hblx column in the result set</summary>
		protected int m_divar_dakli_glb_hblxOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_sofali column in the result set</summary>
		protected int m_divar_dakli_glb_sofaliOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_poma column in the result set</summary>
		protected int m_divar_dakli_glb_pomaOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_ajor column in the result set</summary>
		protected int m_divar_dakli_glb_ajorOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_drywall column in the result set</summary>
		protected int m_divar_dakli_glb_drywallOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_sayer column in the result set</summary>
		protected int m_divar_dakli_glb_sayerOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_sayer_val column in the result set</summary>
		protected int m_divar_dakli_glb_sayer_valOrdinal;
		/// <summary>The ordinal position of the divar_dakli_glb_tozi column in the result set</summary>
		protected int m_divar_dakli_glb_toziOrdinal;
		/// <summary>The ordinal position of the thvil_tarikh column in the result set</summary>
		protected int m_thvil_tarikhOrdinal;
		/// <summary>The ordinal position of the thvil_krshnas column in the result set</summary>
		protected int m_thvil_krshnasOrdinal;
			
		#endregion
		
		
		#region Constructors
		
		/// <summary>
		/// Creates a new sazehDataReaderBase
		/// </summary>
		public sazehDataReaderBase()
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
		/// Returns the value of the mlk_id column for the current row
		/// </summary>
		public Int32 mlk_id
		{
			get 
			{
				try
				{
					return (Int32)DataRecord[m_mlk_idOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the rsht_id column for the current row
		/// </summary>
		public Int32 rsht_id
		{
			get 
			{
					return (Int32)DataRecord[m_rsht_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the modirt_id column for the current row
		/// </summary>
		public Int32 modirt_id
		{
			get 
			{
					return (Int32)DataRecord[m_modirt_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the shrstan_id column for the current row
		/// </summary>
		public Int32 shrstan_id
		{
			get 
			{
					return (Int32)DataRecord[m_shrstan_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the shobh_id column for the current row
		/// </summary>
		public String shobh_id
		{
			get 
			{
				try
				{
					return (String)DataRecord[m_shobh_idOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the fndsion_noe_id column for the current row
		/// </summary>
		public Int32 fndsion_noe_id
		{
			get 
			{
					return (Int32)DataRecord[m_fndsion_noe_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the fndsion_tozi column for the current row
		/// </summary>
		public String fndsion_tozi
		{
			get 
			{
				try
				{
					return (String)DataRecord[m_fndsion_toziOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the sgf_noe_id column for the current row
		/// </summary>
		public Int32 sgf_noe_id
		{
			get 
			{
					return (Int32)DataRecord[m_sgf_noe_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the sgf_sayr column for the current row
		/// </summary>
		public String sgf_sayr
		{
			get 
			{
				try
				{
					return (String)DataRecord[m_sgf_sayrOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the sgf_tozi column for the current row
		/// </summary>
		public String sgf_tozi
		{
			get 
			{
				try
				{
					return (String)DataRecord[m_sgf_toziOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the sklt_noe_id column for the current row
		/// </summary>
		public Int32 sklt_noe_id
		{
			get 
			{
					return (Int32)DataRecord[m_sklt_noe_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the sklt_tozi column for the current row
		/// </summary>
		public String sklt_tozi
		{
			get 
			{
				try
				{
					return (String)DataRecord[m_sklt_toziOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the sklt_sayr column for the current row
		/// </summary>
		public String sklt_sayr
		{
			get 
			{
				try
				{
					return (String)DataRecord[m_sklt_sayrOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_karji_glb_id column for the current row
		/// </summary>
		public Int32 divar_karji_glb_id
		{
			get 
			{
					return (Int32)DataRecord[m_divar_karji_glb_idOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_partition column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_partition
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_partitionOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_simani column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_simani
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_simaniOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_lika column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_lika
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_likaOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_hblx column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_hblx
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_hblxOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_sofali column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_sofali
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_sofaliOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_poma column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_poma
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_pomaOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_ajor column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_ajor
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_ajorOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_drywall column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_drywall
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_drywallOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_sayer column for the current row
		/// </summary>
		public Boolean divar_dakli_glb_sayer
		{
			get 
			{
				try
				{
					return (Boolean)DataRecord[m_divar_dakli_glb_sayerOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_sayer_val column for the current row
		/// </summary>
		public String divar_dakli_glb_sayer_val
		{
			get 
			{
				try
				{
					return (String)DataRecord[m_divar_dakli_glb_sayer_valOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the divar_dakli_glb_tozi column for the current row
		/// </summary>
		public Int32 divar_dakli_glb_tozi
		{
			get 
			{
				try
				{
					return (Int32)DataRecord[m_divar_dakli_glb_toziOrdinal];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is DBNull.", e);
				}
			}
		}
	
		/// <summary>
		/// Returns the value of the thvil_tarikh column for the current row
		/// </summary>
		public String thvil_tarikh
		{
			get 
			{
					return (String)DataRecord[m_thvil_tarikhOrdinal];
			}
		}
	
		/// <summary>
		/// Returns the value of the thvil_krshnas column for the current row
		/// </summary>
		public Int32 thvil_krshnas
		{
			get 
			{
					return (Int32)DataRecord[m_thvil_krshnasOrdinal];
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
			m_mlk_idOrdinal = DataReader.GetOrdinal("mlk_id");
			m_rsht_idOrdinal = DataReader.GetOrdinal("rsht_id");
			m_modirt_idOrdinal = DataReader.GetOrdinal("modirt_id");
			m_shrstan_idOrdinal = DataReader.GetOrdinal("shrstan_id");
			m_shobh_idOrdinal = DataReader.GetOrdinal("shobh_id");
			m_fndsion_noe_idOrdinal = DataReader.GetOrdinal("fndsion_noe_id");
			m_fndsion_toziOrdinal = DataReader.GetOrdinal("fndsion_tozi");
			m_sgf_noe_idOrdinal = DataReader.GetOrdinal("sgf_noe_id");
			m_sgf_sayrOrdinal = DataReader.GetOrdinal("sgf_sayr");
			m_sgf_toziOrdinal = DataReader.GetOrdinal("sgf_tozi");
			m_sklt_noe_idOrdinal = DataReader.GetOrdinal("sklt_noe_id");
			m_sklt_toziOrdinal = DataReader.GetOrdinal("sklt_tozi");
			m_sklt_sayrOrdinal = DataReader.GetOrdinal("sklt_sayr");
			m_divar_karji_glb_idOrdinal = DataReader.GetOrdinal("divar_karji_glb_id");
			m_divar_dakli_glb_partitionOrdinal = DataReader.GetOrdinal("divar_dakli_glb_partition");
			m_divar_dakli_glb_simaniOrdinal = DataReader.GetOrdinal("divar_dakli_glb_simani");
			m_divar_dakli_glb_likaOrdinal = DataReader.GetOrdinal("divar_dakli_glb_lika");
			m_divar_dakli_glb_hblxOrdinal = DataReader.GetOrdinal("divar_dakli_glb_hblx");
			m_divar_dakli_glb_sofaliOrdinal = DataReader.GetOrdinal("divar_dakli_glb_sofali");
			m_divar_dakli_glb_pomaOrdinal = DataReader.GetOrdinal("divar_dakli_glb_poma");
			m_divar_dakli_glb_ajorOrdinal = DataReader.GetOrdinal("divar_dakli_glb_ajor");
			m_divar_dakli_glb_drywallOrdinal = DataReader.GetOrdinal("divar_dakli_glb_drywall");
			m_divar_dakli_glb_sayerOrdinal = DataReader.GetOrdinal("divar_dakli_glb_sayer");
			m_divar_dakli_glb_sayer_valOrdinal = DataReader.GetOrdinal("divar_dakli_glb_sayer_val");
			m_divar_dakli_glb_toziOrdinal = DataReader.GetOrdinal("divar_dakli_glb_tozi");
			m_thvil_tarikhOrdinal = DataReader.GetOrdinal("thvil_tarikh");
			m_thvil_krshnasOrdinal = DataReader.GetOrdinal("thvil_krshnas");
		}
		
		#endregion
		
		
		#region Public Methods
		
		/// <summary>
		/// Selects all rows from the sazeh table
		/// </summary>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectAll()
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_sazeh_SelectAll";
			
			return OpenReader();
		}
		
		/// <summary>
		/// Selects rows from the sazeh table by Query definion
		/// </summary>
		/// <param name="queryDefinition">A Query object that defines the Query used to select rows from the database</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectByQuery(Query queryDefinition)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();

			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.Text);

			if (queryDefinition.TableName.Length == 0)
			{
				queryDefinition.TableName = "gv_sazeh";
			}

			queryDefinition.BuildCommand(CommandSelect);

			return OpenReader();
		}
		
		
		/// <summary>
		/// Selects rows from the sazeh table by Primary Key (szh_id)
		/// </summary>
		/// <param name="szh_id">The szh_id to use as search criteria</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectByszh_id(Int32 szh_id)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_sazeh_SelectByszh_id";
			
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@szh_id", SqlDbType.Int, szh_id));
			
			return OpenReader();
		}
		
		/// <summary>
		/// Selects rows from the sazeh table by fndsion_noe_id
		/// </summary>
		/// <param name="fndsion_noe_id">The fndsion_noe_id to use as search criteria</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectByfndsion_noe_id(Int32 fndsion_noe_id)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_sazeh_SelectByfndsion_noe_id";
			
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@fndsion_noe_id", SqlDbType.Int, fndsion_noe_id));
			
			return OpenReader();
		}
		
		/// <summary>
		/// Selects rows from the sazeh table by sgf_noe_id
		/// </summary>
		/// <param name="sgf_noe_id">The sgf_noe_id to use as search criteria</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectBysgf_noe_id(Int32 sgf_noe_id)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_sazeh_SelectBysgf_noe_id";
			
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@sgf_noe_id", SqlDbType.Int, sgf_noe_id));
			
			return OpenReader();
		}
		
		/// <summary>
		/// Selects rows from the sazeh table by sklt_noe_id
		/// </summary>
		/// <param name="sklt_noe_id">The sklt_noe_id to use as search criteria</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectBysklt_noe_id(Int32 sklt_noe_id)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_sazeh_SelectBysklt_noe_id";
			
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@sklt_noe_id", SqlDbType.Int, sklt_noe_id));
			
			return OpenReader();
		}
		
		/// <summary>
		/// Selects rows from the sazeh table by divar_karji_glb_id
		/// </summary>
		/// <param name="divar_karji_glb_id">The divar_karji_glb_id to use as search criteria</param>
		/// <returns>true on success, false otherwise</returns>
		public bool SelectBydivar_karji_glb_id(Int32 divar_karji_glb_id)
		{
			DatabaseAccessObjectFactory DataObjectFactory = CommonFactory.CreateDataObjectFactory();
		
			CommandSelect = DataObjectFactory.CreateCommand(Connection, CommandType.StoredProcedure);
			CommandSelect.CommandText = "gp_sazeh_SelectBydivar_karji_glb_id";
			
			CommandSelect.Parameters.Add(DataObjectFactory.CreateCommandParameter("@divar_karji_glb_id", SqlDbType.Int, divar_karji_glb_id));
			
			return OpenReader();
		}
		
		/// <summary>
		/// Checks if the value of the mlk_id column is NULL
		/// </summary>
		/// <returns>true if mlk_id is NULL, false if it is not NULL</returns>
		public bool Ismlk_idNull()
		{
			return DataRecord.IsDBNull(m_mlk_idOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the shobh_id column is NULL
		/// </summary>
		/// <returns>true if shobh_id is NULL, false if it is not NULL</returns>
		public bool Isshobh_idNull()
		{
			return DataRecord.IsDBNull(m_shobh_idOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the fndsion_tozi column is NULL
		/// </summary>
		/// <returns>true if fndsion_tozi is NULL, false if it is not NULL</returns>
		public bool Isfndsion_toziNull()
		{
			return DataRecord.IsDBNull(m_fndsion_toziOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the sgf_sayr column is NULL
		/// </summary>
		/// <returns>true if sgf_sayr is NULL, false if it is not NULL</returns>
		public bool Issgf_sayrNull()
		{
			return DataRecord.IsDBNull(m_sgf_sayrOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the sgf_tozi column is NULL
		/// </summary>
		/// <returns>true if sgf_tozi is NULL, false if it is not NULL</returns>
		public bool Issgf_toziNull()
		{
			return DataRecord.IsDBNull(m_sgf_toziOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the sklt_tozi column is NULL
		/// </summary>
		/// <returns>true if sklt_tozi is NULL, false if it is not NULL</returns>
		public bool Issklt_toziNull()
		{
			return DataRecord.IsDBNull(m_sklt_toziOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the sklt_sayr column is NULL
		/// </summary>
		/// <returns>true if sklt_sayr is NULL, false if it is not NULL</returns>
		public bool Issklt_sayrNull()
		{
			return DataRecord.IsDBNull(m_sklt_sayrOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_partition column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_partition is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_partitionNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_partitionOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_simani column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_simani is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_simaniNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_simaniOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_lika column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_lika is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_likaNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_likaOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_hblx column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_hblx is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_hblxNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_hblxOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_sofali column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_sofali is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_sofaliNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_sofaliOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_poma column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_poma is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_pomaNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_pomaOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_ajor column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_ajor is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_ajorNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_ajorOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_drywall column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_drywall is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_drywallNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_drywallOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_sayer column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_sayer is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_sayerNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_sayerOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_sayer_val column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_sayer_val is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_sayer_valNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_sayer_valOrdinal);
		}
		
		/// <summary>
		/// Checks if the value of the divar_dakli_glb_tozi column is NULL
		/// </summary>
		/// <returns>true if divar_dakli_glb_tozi is NULL, false if it is not NULL</returns>
		public bool Isdivar_dakli_glb_toziNull()
		{
			return DataRecord.IsDBNull(m_divar_dakli_glb_toziOrdinal);
		}
		
		
		
		
		#endregion
	}
}
