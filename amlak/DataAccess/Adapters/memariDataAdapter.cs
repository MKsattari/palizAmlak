using System;
using System.Data;

using RAD.AppFramework.Data;

using amlak.Common;
using amlak.DataAccess.Adapters.Base;

namespace amlak.DataAccess.Adapters
{
	/// <summary>
	/// memariDataAdapter allows for application specific data operations to be added without 
	/// having to make changes to the auto-generated memariDataAdapterBase class. 
	/// <seealso cref="memariDataAdapterBase"/>
	/// </summary>
	/// <remarks>
	/// Any modifications must be made to the memariDataAdapter class.
	/// <br/><br/>
	/// This class was automatically generated by Rad Software NextGeneration <a href="http://www.radsoftware.com.au">http://www.radsoftware.com.au</a>
	/// </remarks>
	public class memariDataAdapter : memariDataAdapterBase
	{
		#region Constants
		
		
		
		#endregion
		
		
		#region Fields
		
		/// <summary>
		/// A static instance of the memariDataAdapter
		/// </summary>
		static memariDataAdapter m_Instance;		
		
		#endregion
		
		
		#region Constructors
		
		/// <summary>
		/// Creates a new memariDataAdapter 
		/// that uses the specified DatabaseConnection
		/// </summary>
		public memariDataAdapter(DatabaseConnection dbconnection) : base(dbconnection)
		{
		
		}
		
		/// <summary>
		/// Creates a new memariDataAdapter 
		/// </summary>
		public memariDataAdapter() : base()
		{
		
		}
		
		/// <summary>
		/// Initializes the static instance
		/// </summary>
		static memariDataAdapter()
		{
			m_Instance = new memariDataAdapter();
		}
		
		#endregion
		
		
		#region Public Properties
		
		/// <summary>
		/// A default instance of the memariDataAdapter
		/// </summary>
		public static memariDataAdapter Instance
		{
			get { return m_Instance; }
		}		
		
		#endregion
		
		
		#region Private Methods
		
		
		
		#endregion
		
		
		#region Public Methods
		
		
		
		#endregion
	}
}
