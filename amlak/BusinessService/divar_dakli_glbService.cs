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
	/// divar_dakli_glbService allows for application specific business logic to be added without 
	/// having to make changes to the auto-generated divar_dakli_glbServiceBase class. 
	/// </summary>
	/// <remarks>
	/// Any additional functionality must be added to the divar_dakli_glbService class.
	/// <br/><br/>
	/// This class was automatically generated by Rad Software NextGeneration <a href="http://www.radsoftware.com.au">http://www.radsoftware.com.au</a>
	/// </remarks>
	public class divar_dakli_glbService : divar_dakli_glbServiceBase
	{
		#region Constants
		
		
		
		#endregion
		
		
		#region Fields
		
		/// <summary>
		/// A static instance of the divar_dakli_glbService
		/// </summary>
		static divar_dakli_glbService m_Instance;
		
		#endregion
		
		
		#region Constructors
		
		/// <summary>
		/// Creates a new divar_dakli_glbService
		/// </summary>
		public divar_dakli_glbService() : base()
		{
		}
		
		/// <summary>
		/// Creates a new divar_dakli_glbService and specifies the Database context
		/// </summary>		
		public divar_dakli_glbService(DatabaseConnection connection) : base(connection)
		{
		}
				
		/// <summary>
		/// Initializes the static instance
		/// </summary>
		static divar_dakli_glbService()
		{
			m_Instance = new divar_dakli_glbService();
		}
		
		#endregion
		
		
		#region Public Properties
		
		/// <summary>
		/// A default instance of the divar_dakli_glbService
		/// </summary>
		public static divar_dakli_glbService Instance
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
