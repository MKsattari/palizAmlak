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


/// <summary>
	/// Base web page
	/// </summary>
	public class BasePage : System.Web.UI.UserControl
	{
		#region Constants


		
		#endregion


		#region Fields

		string m_PageTitle = string.Empty;

		string m_DefaultReturnPage = "./";

		#endregion

		
		#region Page Events

		/// <summary>
		/// Called when the page is loading
		/// </summary>
		/// <param name="sender">The object that raised the event</param>
		/// <param name="e">Event arguments</param>
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (IsPostBack)
			{
				
			}
			else
			{
				if (Request.UrlReferrer == null)
				{
					//
					// No referrer for the current request, use the default
					//
					UrlPrevious = new Uri(Request.Url, DefaultReturnPage);
				}
				else
				{
					UrlPrevious = Request.UrlReferrer;
				}
			}
		}


		/// <summary>
		/// Creates a new instance of the base Page
		/// </summary>
		public BasePage()
		{
			this.Load += new EventHandler(Page_Load);
		}

		#endregion


		#region Event Handlers for Controls



		#endregion


		#region Private Methods


		/// <summary>
		/// Retrieves a value from the ViewState or
		/// the default value if the ViewState is empty
		/// </summary>
		/// <param name="key">The key of the value to return</param>
		/// <param name="defaultValue">The value to return if the ViewState does not contain a value</param>
		/// <returns>The value in the ViewState for the key or the default value</returns>
		protected object GetViewState(string key, object defaultValue)
		{
			object ViewStateValue = ViewState[key];

			if (ViewStateValue == null) 
			{
				return defaultValue;
			}
			else
			{
				return ViewStateValue;
			}
		}


		/// <summary>
		/// Checks if the Query string contains a parameter
		/// </summary>
		/// <param name="parameterName">The name of the parameter</param>
		/// <returns>true if the parameter exists, false if it does not</returns>
		protected bool HasQueryStringParameter(string parameterName)
		{
			if (Request.QueryString[parameterName] == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
       

		/// <summary>
		/// Gets a value from the QueryString. The default value is returned
		/// if the parameter is not found.
		/// </summary>
		/// <param name="paramName">The name of the parameter in the query string</param>
		/// <param name="defaultValue">The value to return if the parameter is not found</param>
		/// <returns>The value of the query parameter or the default value</returns>
		protected string GetQueryStringParameter(string parameterName, string defaultValue)
		{
			string QueryParameterValue = Request.QueryString[parameterName];

			if (QueryParameterValue == null)
			{
				return defaultValue;
			}
			else
			{
				return QueryParameterValue;
			}
		}


		/// <summary>
		/// Changes or sets the value of a query string parameter
		/// </summary>
		/// <param name="urlQuery">The current query string</param>
		/// <param name="key">The name of the parameter in the query string</param>
		/// <param name="valueNew">The new value for the parameter</param>
		/// <returns>The query string with the parameter updated</returns>
		/// <example>
		/// <code>
		/// UriBuilder UrlWithSort = new UriBuilder(Request.Url);
		/// UrlWithSort.Query = ChangeQueryStringValue(UrlWithSort.Query, "SortDir", "CompanyName");
		/// </code>
		/// </example>
		protected string ChangeQueryStringValue(string urlQuery, string key, string valueNew)
		{
			if (urlQuery.Length > 0)
			{
				//
				// Remove the leading question mark as it will be put back on by the UrlBuilder
				//
				urlQuery = urlQuery.Remove(0, 1);
			}

			if (HasQueryStringParameter(key))
			{
				System.Text.RegularExpressions.Regex SortRegex = new System.Text.RegularExpressions.Regex(@"\b" + key + "=([^&]*)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
				return SortRegex.Replace(urlQuery, key + "=" + valueNew);
			}
			else
			{
				if (urlQuery.Length > 0)
				{
					urlQuery += "&";
				}

				return urlQuery + key + "=" + valueNew;
			}
		}


		#endregion
		

		#region Public Properties

		/// <summary>
		/// The title of web page 
		/// </summary>
		public string PageTitle
		{
			get { return GetViewState("Title", string.Empty) as string; }
			set { ViewState["Title"] = value; }
		}


		/// <summary>
		/// The page that the user visited before this page
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Uri UrlPrevious
		{
			get { return GetViewState("UrlPrev", new Uri(Request.Url.ToString())) as Uri; }
			set { ViewState["UrlPrev"] = value; }
		}


		/// <summary>
		/// The page address returned by UrlPrevious 
		/// when there is no referrer for the current request 
		/// </summary>
		/// <remarks>
		/// Only the page filename needs to be specified to go to 
		/// a page in the same folder. This property must be set in the
		/// constructor of the inheriting page.
		/// </remarks>
		/// <example>
		/// Employees_Search.aspx
		/// </example>
		public string DefaultReturnPage
		{
			get { return m_DefaultReturnPage; }
			set { m_DefaultReturnPage = value; }
		}


		#endregion
	}

