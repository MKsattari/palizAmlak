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
	/// An editable web page that is used for data entry
	/// </summary>
	public class EditablePage : BasePage
	{
		#region PageDataEntryMode enumeration
		
		/// <summary>
		/// The Data Entry Mode for an ASPX page
		/// </summary>
		protected enum PageDataEntryMode
		{
			/// <summary>
			/// The page will add a new row
			/// </summary>
			AddRow,
			/// <summary>
			/// The page is editing a row
			/// </summary>
			EditRow,
			/// <summary>
			/// The page is viewing a row only
			/// </summary>
			ViewRow,
			/// <summary>
			/// There is an error on the page / row to edit could not be found
			/// </summary>
			ErrorOccurred
		}

        protected enum  NoeCls
        {
            /// <summary>
            /// نوع اسکلت سازه
            /// </summary>
             szh_sklt,
            /// <summary>
            /// نوع فونداسیون
            /// </summary>
            szh_fndsion ,
            /// <summary>
            ///نوع دیوار خارجی
            /// </summary>
            szh_divar_kharji
            /// <summary>
            ///
            /// </summary>
           
        }	
		
		#endregion
		
	
		#region Constants

		/// <summary>
		/// The name of the Read only parameter in the query string
		/// </summary>
		protected const string ReadOnlyKeyName = "ReadOnly";

		#endregion


		#region Fields

        public Int32 m_mlk_idCurrent
        {
            get { return (Int32)GetViewState("m_mlk_idCurrent", 0); }
            set { ViewState["m_mlk_idCurrent"] = value; }
        }
       

		#endregion

		
		#region Page Events

		/// <summary>
		/// Called when the page is loading
		/// </summary>
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (IsPostBack)
			{
				
			}
			else
			{
				//
				// Check if page should be read only
				//
				if (HasQueryStringParameter(ReadOnlyKeyName))
				{
					if (Request.QueryString[ReadOnlyKeyName].ToLower() == "true")
					{
						DataEntryMode = PageDataEntryMode.ViewRow;

						DisableDataEntryControls(Controls);
					}
				}
			}
		}


		/// <summary>
		/// Creates a new instance of the base Page
		/// </summary>
		public EditablePage()
		{
			this.Load += new EventHandler(Page_Load);
		}

		#endregion


		#region Event Handlers for Controls



		#endregion


		#region Private Methods
		
		/// <summary>
		/// Disables all data entry contols in the control collection
		/// </summary>
		/// <example>
		/// DisableDataEntryControls(Page.Controls);
		/// </example>
		/// <param name="controlList">A list of controls to disable</param>
		protected void DisableDataEntryControls(ControlCollection controlList)
		{
			foreach (Control ControlCurrent in controlList)
			{
				if (ControlCurrent is HtmlContainerControl)
				{
					//
					// Call this method again recursively for container controls
					//
					HtmlContainerControl Container = ControlCurrent as HtmlContainerControl;
					DisableDataEntryControls(Container.Controls);
				}

				if (ControlCurrent is WebControl)
				{
					WebControl WebControlCurrent = ControlCurrent as WebControl;	

					if (WebControlCurrent is Calendar)
					{
						WebControlCurrent.Enabled = false;
					}
					if (WebControlCurrent is CheckBox)
					{
						WebControlCurrent.Enabled = false;
					}
					if (WebControlCurrent is LinkButton)
					{
						WebControlCurrent.Enabled = false;
					}
					if (WebControlCurrent is ListControl)
					{
						WebControlCurrent.Enabled = false;
					}
					if (WebControlCurrent is TextBox)
					{
						WebControlCurrent.Enabled = false;
					}
				}
			}
		}


		#endregion
		

		#region Public Properties

		/// <summary>
		/// The Data entry mode for editable pages
		/// </summary>
		protected PageDataEntryMode DataEntryMode
		{
			get { return (PageDataEntryMode)GetViewState("DataEntryMode", PageDataEntryMode.AddRow); }
			set { ViewState["DataEntryMode"] = value; }
		}

        public Int32 m_szh_idCurrent
        {
            get { return (Int32)GetViewState("m_szh_idCurrent", 0); }
            set { ViewState["m_szh_idCurrent"] = value; }
        }

       
		#endregion
		
	}

