using System;
using System.Configuration;

using RAD.AppFramework.Data;
using RAD.AppFramework.QueryObjects;

namespace amlak.Common
{
	/// <summary>
	/// AbstractDataObjectFactory creates the 
	/// appropriate DatabaseAccessObjectFactory for the application
	/// </summary>
	public class CommonFactory
	{
		/// <summary>
		/// Creates a DataObject Factory
		/// </summary>
		/// <returns>a DatabaseAccessObjectFactory</returns>
		public static DatabaseAccessObjectFactory CreateDataObjectFactory()
		{
			//
			// TODO Add the connection string to App.config or Web.config
			//
			return new SqlDatabaseAccessObjectFactory(ConfigurationSettings.AppSettings["ConnectionString"]); 
		}
		
		/// <summary>
		/// Creates a Query with the appropriate QueryBuilder for the database connection
		/// </summary>
		/// <returns>a new Query</returns>
		public static Query CreateQuery()
		{
			return new Query(new SqlServerQueryBuilder());
		}

		/// <summary>
		/// An instance of this class cannot be created
		/// </summary>
		private CommonFactory()
		{
		}
	}
}
