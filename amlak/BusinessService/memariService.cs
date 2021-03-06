using System;
using System.Data;

using RAD.AppFramework;
using RAD.AppFramework.Data;
using RAD.AppFramework.QueryObjects;

using amlak.Common;
using amlak.DatabaseSchema;
using amlak.Data;
using amlak.DataAccess.Adapters;
using amlak.BusinessService.Base;

namespace amlak.BusinessService
{
	/// <summary>
	/// memariService allows for application specific business logic to be added without 
	/// having to make changes to the auto-generated memariServiceBase class. 
	/// </summary>
	/// <remarks>
	/// Any additional functionality must be added to the memariService class.
	/// <br/><br/>
	/// This class was automatically generated by Rad Software NextGeneration <a href="http://www.radsoftware.com.au">http://www.radsoftware.com.au</a>
	/// </remarks>
	public class memariService : memariServiceBase
	{
		#region Constants
		
		
		
		#endregion
		
		
		#region Fields
		
		/// <summary>
		/// A static instance of the memariService
		/// </summary>
		static memariService m_Instance;
		
		#endregion
		
		
		#region Constructors
		
		/// <summary>
		/// Creates a new memariService
		/// </summary>
		public memariService() : base()
		{
		}
		
		/// <summary>
		/// Creates a new memariService and specifies the Database context
		/// </summary>		
		public memariService(DatabaseConnection connection) : base(connection)
		{
		}
				
		/// <summary>
		/// Initializes the static instance
		/// </summary>
		static memariService()
		{
			m_Instance = new memariService();
		}
		
		#endregion
		
		
		#region Public Properties
		
		/// <summary>
		/// A default instance of the memariService
		/// </summary>
		public static memariService Instance
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
