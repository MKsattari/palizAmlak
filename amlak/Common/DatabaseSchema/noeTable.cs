using System;
using System.Data;

using RAD.AppFramework.Reflection;

namespace amlak.DatabaseSchema
{
	/// <summary>
	/// Defines the schema of the noe table for use with the Query objects
	/// </summary>
	[DatabaseTable("gv_noe")]
	public enum noeTable
	{
		/// <summary>
		/// noe_id Column 
		/// </summary>
		[DatabaseColumn("noe_id", DbType.Int32, AllowDBNull=false)]
		noe_id,
		
		/// <summary>
		/// noe_nam Column 
		/// </summary>
		[DatabaseColumn("noe_nam", DbType.String, Length=200, AllowDBNull=false)]
		noe_nam,
		
		/// <summary>
		/// noe_cls Column 
		/// </summary>
		[DatabaseColumn("noe_cls", DbType.String, Length=50, AllowDBNull=false)]
		noe_cls,
		
		/// <summary>
		/// noe_tozi Column 
		/// </summary>
		[DatabaseColumn("noe_tozi", DbType.String, Length=200, AllowDBNull=false)]
		noe_tozi

	}
}
