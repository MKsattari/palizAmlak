using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using RAD.AppFramework.QueryObjects;

/// <summary>
	/// SearchPage
	/// </summary>
	public class SearchPage : BasePage
	{
		#region Constants

		/// <summary>
		/// The message displayed when there are no matches for a search
		/// </summary>
		protected const string NoMatchesMessage = "Nothing was found that matched your search.";
		
		/// <summary>
		/// The message displayed on a successful search
		/// </summary>
		protected const string MatchesFoundMessage = "{0} matches for your search.";

		/// <summary>
		/// The index of the first page on a DataGrid
		/// </summary>
		protected const int FirstPage = 0;

		/// <summary>
		/// The name of the parameter in the query string that 
		/// specifies the column to sort on
		/// </summary>
		/// <remarks>
		/// Change this if you have a column in the Database called 'Sort'
		/// </remarks>
		protected const string SortParameterName = "Sort";

		/// <summary>
		/// The name of the parameter in the query string that 
		/// specifies the sort direction
		/// </summary>
		protected const string SortDirectionParameterName = "SortDir";

		#endregion


		#region Fields

		bool m_AllowSearchAll = false;

		#endregion


		#region Constructors

		/// <summary>
		/// Creates a new instance of the SearchPage class
		/// </summary>		
		public SearchPage()
		{
		}

		#endregion

		
		#region Page Events



		#endregion


		#region Event Handlers for Controls



		#endregion


		#region Methods - Private


		/// <summary>
		/// Reads the query string to populate a 
		/// search criteria control
		/// </summary>
		/// <param name="fieldName">The name of the parameter in the query string that has the search criteria</param>
		/// <param name="searchControl">The control to populate with the search criteria</param>
		/// <returns>zero if no criteria was found, or one if criteria is specified</returns>
		protected int LoadSearchString(string fieldName, HtmlInputText searchControl)
		{
			if (HasQueryStringParameter(fieldName))
			{
				string SearchValue = Request.QueryString[fieldName];

				if ((SearchValue != null && SearchValue.Length > 0) || AllowSearchAll)
				{
					searchControl.Value = SearchValue;

					return 1;
				}
			}

			return 0;
		}


		/// <summary>
		/// Reads the query string to populate a 
		/// yes/no search criteria control
		/// </summary>
		/// <param name="fieldName">The name of the parameter in the query string that has the search criteria</param>
		/// <param name="searchControl">The control to populate with the search criteria</param>
		/// <returns>zero if no criteria was found, or one if criteria is specified</returns>
		protected int LoadSearchBoolean(string fieldName, HtmlSelect searchControl)
		{
			if (HasQueryStringParameter(fieldName))
			{
				string SearchValue = Request.QueryString[fieldName];

				if ((SearchValue != null && SearchValue.Length > 0) || AllowSearchAll)
				{
					searchControl.Value = SearchValue;

					return 1;
				}
			}

			return 0;
		}


		/// <summary>
		/// Reads the query string to populate a 
		/// search criteria control for a range search
		/// </summary>
		/// <param name="fieldName">The name of the parameter in the query string that has the search criteria</param>
		/// <param name="searchControlBegin">The control to populate with the beginning search criteria</param>
		/// <param name="searchControlEnd">The control to populate with the ending search criteria</param>
		/// <returns></returns>
		protected int LoadSearchBetween(string fieldName, HtmlInputText searchControlBegin, HtmlInputText searchControlEnd)
		{
			int CriteriaCount = LoadSearchString(fieldName + "Begin", searchControlBegin);

			CriteriaCount += LoadSearchString(fieldName + "End", searchControlEnd);

			return CriteriaCount;
		}


		/// <summary>
		/// Adds search criteria to a Query if the search control is not empty
		/// </summary>
		/// <param name="queryDefinition">The query to add the criteria to</param>
		/// <param name="column">The column to search on</param>
		/// <param name="comparisionMethod">The type of search to perform</param>
		/// <param name="searchControl">The search control that has the criteria</param>
		protected void AddToQuery(Query queryDefinition, Enum column, Comparison comparisionMethod, HtmlInputText searchControl)
		{
			if (searchControl.Value.Length > 0)
			{
				queryDefinition.And(Criteria.Create(column, Condition.Is, comparisionMethod, searchControl.Value));
			}
		}


		/// <summary>
		/// Adds search criteria to a Query if the search control is not empty
		/// </summary>
		/// <param name="queryDefinition">The query to add the criteria to</param>
		/// <param name="column">The column to search on</param>
		/// <param name="comparisionMethod">The type of search to perform</param>
		/// <param name="searchControl">The search control that has the criteria</param>
		protected void AddToQuery(Query queryDefinition, Enum column, Comparison comparisionMethod, HtmlSelect searchControl)
		{
			if (searchControl.Value.Length > 0)
			{
				queryDefinition.And(Criteria.Create(column, Condition.Is, comparisionMethod, System.Xml.XmlConvert.ToBoolean(searchControl.Value)));
			}
		}


		/// <summary>
		/// Adds Between search criteria to a Query if the search controls are not empty
		/// </summary>
		/// <param name="queryDefinition">The query to add the criteria to</param>
		/// <param name="column">The column to search on</param>
		/// <param name="searchControlBegin">The search control with the lowest value</param>
		/// <param name="searchControlEnd">The search control with the highest value</param>
		protected void AddToQuery(Query queryDefinition, Enum column, HtmlInputText searchControlBegin, HtmlInputText searchControlEnd)
		{
			if (searchControlBegin.Value.Length > 0 && searchControlEnd.Value.Length > 0)
			{
				//
				// Two values specified, use Between
				//
				queryDefinition.And(Criteria.Create(column, Condition.Is, Comparison.Between, searchControlBegin.Value, searchControlEnd.Value));

			}
			else if (searchControlBegin.Value.Length > 0)
			{
				//
				// Low value specified, use GreaterThanOrEqualTo 
				//
				queryDefinition.And(Criteria.Create(column, Condition.Is, Comparison.GreaterThanOrEqualTo, searchControlBegin.Value));

			}
			else if (searchControlEnd.Value.Length > 0)
			{
				//
				// High value specified, use GreaterThanOrEqualTo 
				//
				queryDefinition.And(Criteria.Create(column, Condition.Is, Comparison.LessThanOrEqualTo, searchControlEnd.Value));

			}
		}


		/// <summary>
		/// Reads the query string and adds a sort to the query
		/// if a sort expression is found
		/// </summary>
		/// <param name="queryDefinition">The query to add the sort to</param>
		/// <param name="tableType">The type of the Table enum that the current search is for e.g. typeof(EmployeeTable)</param>
		protected void AddSortToQuery(Query queryDefinition, Type tableType)
		{
			string SortExpression = GetSortExpression();

			if (SortExpression.Length > 0)
			{
				try
				{
					Enum SortColumn = (Enum)Enum.Parse(tableType, SortExpression, true);

					queryDefinition.Sort.Add(SortBy.Create(SortColumn, GetSortDirection()));
				}
				catch (ArgumentException)
				{
					//
					// Could not parse the SortExpression
					// do not add a sort to the query
					//
				}
			}
		}


		/// <summary>
		/// Reads the query string and returns 
		/// the current sort expression 
		/// </summary>
		/// <returns>The column name to sort on or an empty string</returns>
		protected string GetSortExpression()
		{
			if (HasQueryStringParameter(SortParameterName))
			{
				return Request.QueryString[SortParameterName];
			}

			return string.Empty;
		}


		/// <summary>
		/// Reads the query string and returns 
		/// the current sort direction
		/// </summary>
		/// <returns>The SortDirection set in the query string or SortDirection.Ascending if none is found</returns>
		protected RAD.AppFramework.QueryObjects.SortDirection GetSortDirection()
		{
			if (HasQueryStringParameter(SortDirectionParameterName))
			{
				if (Request.QueryString[SortDirectionParameterName].Length > 0)
				{
					try
					{
						//
						// Convert the string value into the enum value
						//
						return (RAD.AppFramework.QueryObjects.SortDirection)Enum.Parse(typeof(RAD.AppFramework.QueryObjects.SortDirection), Request.QueryString[SortDirectionParameterName], true);
					}
					catch (ArgumentException)
					{
						return RAD.AppFramework.QueryObjects.SortDirection.Ascending;
					}
				}
			}

			return RAD.AppFramework.QueryObjects.SortDirection.Ascending;
		}


		/// <summary>
		/// Sets the the sort expression in the url and 
		/// redirects to the url
		/// </summary>
		/// <param name="sortExpression">The column name to sort on</param>
		/// <remarks>
		/// The sort direction is checked and inverted
		/// if the sort expression is the same as the current sort expression in the query string
		/// </remarks>
		protected void RedirectWithSortExpression(string sortExpression)
		{
			RAD.AppFramework.QueryObjects.SortDirection SortDirectionCurrent = GetSortDirection();

			if (sortExpression == GetSortExpression())
			{
				//
				// The sort is on the same column so switch the sort direction
				//
				if (SortDirectionCurrent == RAD.AppFramework.QueryObjects.SortDirection.Ascending)
				{
					SortDirectionCurrent = RAD.AppFramework.QueryObjects.SortDirection.Descending;
				}
				else
				{
					SortDirectionCurrent = RAD.AppFramework.QueryObjects.SortDirection.Ascending;
				}
			}
			else
			{
				//
				// Sorting on a different column so change back to the default sort
				//
				SortDirectionCurrent = RAD.AppFramework.QueryObjects.SortDirection.Ascending;
			}

			UriBuilder UrlWithSort = new UriBuilder(Request.Url);

			UrlWithSort.Query = ChangeQueryStringValue(UrlWithSort.Query, SortParameterName, sortExpression);
			UrlWithSort.Query = ChangeQueryStringValue(UrlWithSort.Query, SortDirectionParameterName, SortDirectionCurrent.ToString());
			
			Response.Redirect(UrlWithSort.ToString());
		}


		#endregion


		#region Protected Properties

		/// <summary>
		/// Specifies if searches without criteria are allowed.
		/// A search without criteria will return all of the rows in a table.
		/// </summary>
		protected bool AllowSearchAll
		{
			get { return m_AllowSearchAll; }
			set { m_AllowSearchAll = value; }
		}

		#endregion
		
	}

