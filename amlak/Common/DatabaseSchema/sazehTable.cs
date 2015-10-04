using System;
using System.Data;

using RAD.AppFramework.Reflection;

namespace amlak.DatabaseSchema
{
	/// <summary>
	/// Defines the schema of the sazeh table for use with the Query objects
	/// </summary>
	[DatabaseTable("gv_sazeh")]
	public enum sazehTable
	{
		/// <summary>
		/// szh_id Column 
		/// </summary>
		[DatabaseColumn("szh_id", DbType.Int32, AllowDBNull=false)]
		szh_id,
		
		/// <summary>
		/// mlk_id Column 
		/// </summary>
		[DatabaseColumn("mlk_id", DbType.Int32)]
		mlk_id,
		
		/// <summary>
		/// rsht_id Column 
		/// </summary>
		[DatabaseColumn("rsht_id", DbType.Int32, AllowDBNull=false)]
		rsht_id,
		
		/// <summary>
		/// modirt_id Column 
		/// </summary>
		[DatabaseColumn("modirt_id", DbType.Int32, AllowDBNull=false)]
		modirt_id,
		
		/// <summary>
		/// shrstan_id Column 
		/// </summary>
		[DatabaseColumn("shrstan_id", DbType.Int32, AllowDBNull=false)]
		shrstan_id,
		
		/// <summary>
		/// shobh_id Column 
		/// </summary>
		[DatabaseColumn("shobh_id", DbType.StringFixedLength, Length=10)]
		shobh_id,
		
		/// <summary>
		/// fndsion_noe_id Column 
		/// </summary>
		[DatabaseColumn("fndsion_noe_id", DbType.Int32, AllowDBNull=false)]
		fndsion_noe_id,
		
		/// <summary>
		/// fndsion_tozi Column 
		/// </summary>
		[DatabaseColumn("fndsion_tozi", DbType.AnsiString)]
		fndsion_tozi,
		
		/// <summary>
		/// sgf_noe_id Column 
		/// </summary>
		[DatabaseColumn("sgf_noe_id", DbType.Int32, AllowDBNull=false)]
		sgf_noe_id,
		
		/// <summary>
		/// sgf_sayr Column 
		/// </summary>
		[DatabaseColumn("sgf_sayr", DbType.AnsiString, Length=200)]
		sgf_sayr,
		
		/// <summary>
		/// sgf_tozi Column 
		/// </summary>
		[DatabaseColumn("sgf_tozi", DbType.AnsiString)]
		sgf_tozi,
		
		/// <summary>
		/// sklt_noe_id Column 
		/// </summary>
		[DatabaseColumn("sklt_noe_id", DbType.Int32, AllowDBNull=false)]
		sklt_noe_id,
		
		/// <summary>
		/// sklt_tozi Column 
		/// </summary>
		[DatabaseColumn("sklt_tozi", DbType.AnsiString, Length=200)]
		sklt_tozi,
		
		/// <summary>
		/// sklt_sayr Column 
		/// </summary>
		[DatabaseColumn("sklt_sayr", DbType.AnsiString)]
		sklt_sayr,
		
		/// <summary>
		/// divar_karji_glb_id Column 
		/// </summary>
		[DatabaseColumn("divar_karji_glb_id", DbType.Int32, AllowDBNull=false)]
		divar_karji_glb_id,
		
		/// <summary>
		/// divar_dakli_glb_partition Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_partition", DbType.Boolean)]
		divar_dakli_glb_partition,
		
		/// <summary>
		/// divar_dakli_glb_simani Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_simani", DbType.Boolean)]
		divar_dakli_glb_simani,
		
		/// <summary>
		/// divar_dakli_glb_lika Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_lika", DbType.Boolean)]
		divar_dakli_glb_lika,
		
		/// <summary>
		/// divar_dakli_glb_hblx Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_hblx", DbType.Boolean)]
		divar_dakli_glb_hblx,
		
		/// <summary>
		/// divar_dakli_glb_sofali Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_sofali", DbType.Boolean)]
		divar_dakli_glb_sofali,
		
		/// <summary>
		/// divar_dakli_glb_poma Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_poma", DbType.Boolean)]
		divar_dakli_glb_poma,
		
		/// <summary>
		/// divar_dakli_glb_ajor Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_ajor", DbType.Boolean)]
		divar_dakli_glb_ajor,
		
		/// <summary>
		/// divar_dakli_glb_drywall Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_drywall", DbType.Boolean)]
		divar_dakli_glb_drywall,
		
		/// <summary>
		/// divar_dakli_glb_sayer Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_sayer", DbType.Boolean)]
		divar_dakli_glb_sayer,
		
		/// <summary>
		/// divar_dakli_glb_sayer_val Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_sayer_val", DbType.String, Length=200)]
		divar_dakli_glb_sayer_val,
		
		/// <summary>
		/// divar_dakli_glb_tozi Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_tozi", DbType.Int32)]
		divar_dakli_glb_tozi,
		
		/// <summary>
		/// thvil_tarikh Column 
		/// </summary>
		[DatabaseColumn("thvil_tarikh", DbType.AnsiStringFixedLength, Length=10, AllowDBNull=false)]
		thvil_tarikh,
		
		/// <summary>
		/// thvil_krshnas Column 
		/// </summary>
		[DatabaseColumn("thvil_krshnas", DbType.Int32, AllowDBNull=false)]
		thvil_krshnas

	}
}
