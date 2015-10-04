using System;
using System.Data;

using RAD.AppFramework.Reflection;

namespace amlak.DatabaseSchema
{
	/// <summary>
	/// Defines the schema of the divar_dakli_glb table for use with the Query objects
	/// </summary>
	[DatabaseTable("gv_divar_dakli_glb")]
	public enum divar_dakli_glbTable
	{
		/// <summary>
		/// szh_id Column 
		/// </summary>
		[DatabaseColumn("szh_id", DbType.Int32, AllowDBNull=false)]
		szh_id,
		
		/// <summary>
		/// divar_dakli_glb_id Column 
		/// </summary>
		[DatabaseColumn("divar_dakli_glb_id", DbType.Int32, AllowDBNull=false)]
		divar_dakli_glb_id

	}
}
