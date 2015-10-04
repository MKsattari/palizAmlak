using System;
using System.Data;

using RAD.AppFramework.Reflection;

namespace amlak.DatabaseSchema
{
	/// <summary>
	/// Defines the schema of the memari table for use with the Query objects
	/// </summary>
	[DatabaseTable("gv_memari")]
	public enum memariTable
	{
		/// <summary>
		/// MemariID Column 
		/// </summary>
		[DatabaseColumn("MemariID", DbType.Int32, AllowDBNull=false)]
		MemariID,
		
		/// <summary>
		/// ReshtehID Column 
		/// </summary>
		[DatabaseColumn("ReshtehID", DbType.Int32, AllowDBNull=false)]
		ReshtehID,
		
		/// <summary>
		/// ModiriatID Column 
		/// </summary>
		[DatabaseColumn("ModiriatID", DbType.Int32)]
		ModiriatID,
		
		/// <summary>
		/// ShahrestanID Column 
		/// </summary>
		[DatabaseColumn("ShahrestanID", DbType.Int32)]
		ShahrestanID

	}
}
