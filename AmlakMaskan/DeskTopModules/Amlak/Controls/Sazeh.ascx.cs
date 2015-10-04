
using amlak.BusinessService;
using amlak.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;





    public partial class DeskTopModules_Amlak_Controls_Sazeh : EditablePage
    {
       #region Constants


		#endregion

		#region Fields

		
        
        
		#endregion

				
		#region Page Events

		/// <summary>
		/// Event raised when the page is requested
		/// </summary>
		private void Page_Load(object sender, System.EventArgs e)
		{
			//
			// Find primary key values to use to populate the form
			//

            if (m_szh_idCurrent > 0)
			{
                            
				DataEntryMode = PageDataEntryMode.EditRow;

				PageTitle = string.Format("Sazeh - Editing {0}: {1}", "szh_id", m_szh_idCurrent);
			}
			else
			{
				DataEntryMode = PageDataEntryMode.AddRow;

                PageTitle = "ثبت اطلاعات سازه";
                lblMessage.Text = "ثبت اطلاعات سازه";
			}

			if (Page.IsPostBack)
			{
			
			}
			else
			{
				//
				// Initial Page Request
				//
				PopulateControls();

				if (DataEntryMode == PageDataEntryMode.EditRow || DataEntryMode == PageDataEntryMode.ViewRow)
				{
					if (!LoadData())
					{
						//
						// Could not load the row from the database
						//
						lblMessage.Text = "Error loading sazeh";

						DataEntryMode = PageDataEntryMode.ErrorOccurred;
						
						DisableDataEntryControls(this.Controls);
					}
				}
			}
		}

		#endregion


		#region Event Handlers for Controls

		/// <summary>
		/// Apply the changes and return to the previous screen
		/// </summary>
		public void btnOK_Click(object sender, System.EventArgs e)
		{
			if (SaveData())
			{
				//Response.Redirect(UrlPrevious.ToString());
                lblMessage.Text = "Adding a new entry successfull";
			}
		}


		/// <summary>
		/// Apply the changes and remain on this page
		/// </summary>
		public void btnApply_Click(object sender, System.EventArgs e)
		{
			if (SaveData())
			{
				//
				// Redirect back to this page in Edit mode
				//
				if (DataEntryMode == PageDataEntryMode.AddRow)
				{	
					UriBuilder EditUri = new UriBuilder(Request.Url);
					EditUri.Query += string.Format("{0}={1}", "szh_id", m_szh_idCurrent);

					//
					// Redirect back to this page 
					// with the primary key information in the query string
					//
					Response.Redirect(EditUri.ToString());
							
				}
				else
				{
					lblMessage.Text = "Sazeh saved";

					LoadData();
				}
			}
			else
			{
				lblMessage.Text = "Error saving Sazeh";
				DataEntryMode = PageDataEntryMode.ErrorOccurred;
			}
		}
		
		
		/// <summary>
		/// return to the previous screen
		/// </summary>
		public void btnCancel_Click(object sender, System.EventArgs e)
		{
			Response.Redirect(UrlPrevious.ToString());
		}
		
		#endregion


		#region Private Methods
		
		/// <summary>
		/// Loads data from the database for drop down lists
		/// </summary>
		private void PopulateControls0()
		{
			
			//
			// Populate the fndsion_noe_id Drop Down List
			//
			noeDataSet noeDS1 = new noeDataSet();
			noeService noeLogic1 = new noeService();

			if (noeLogic1.GetAll(noeDS1) > 0)
			{
				ListItem noeListItemNew;
				foreach (noeDataSet.noeRow noeCurrent in noeDS1.noe.Rows)
				{
                    //
                    // Populate the sklt_noe_id Drop Down List
                    //
                    if (noeCurrent.noe_cls==NoeCls.szh_sklt.ToString())
                    {
                        noeListItemNew = new ListItem();
                        noeListItemNew.Value = noeCurrent.noe_id.ToString();
                        noeListItemNew.Text = noeCurrent.noe_nam.ToString();

                        ctlsklt_noe_id.Items.Add(noeListItemNew);
                    }
                    //
                    // Populate the szh_fndsion Drop Down List
                    //

                    if (noeCurrent.noe_cls == NoeCls.szh_fndsion.ToString())
                    {
                        noeListItemNew = new ListItem();
                        noeListItemNew.Value = noeCurrent.noe_id.ToString();
                        noeListItemNew.Text = noeCurrent.noe_nam.ToString();

                        ctlfndsion_noe_id.Items.Add(noeListItemNew);
                    }
                    //
                    // Populate the sgf_noe_id Drop Down List
                    //
                    if (noeCurrent.noe_cls == NoeCls.szh_fndsion.ToString())
                    {
                        noeListItemNew = new ListItem();
                        noeListItemNew.Value = noeCurrent.noe_id.ToString();
                        noeListItemNew.Text = noeCurrent.noe_nam.ToString();

                        ctlfndsion_noe_id.Items.Add(noeListItemNew);
                    }
					
				}
			}
			
			
		
		}

        /// <summary>
        /// Loads data from the database for drop down lists
        /// </summary>
        private void PopulateControls()
        {

            noeDataSet noeDS = new noeDataSet();
            noeService noeLogic = new noeService();

            if (noeLogic.GetAll(noeDS) > 0)

            {
                ListItem noeListItemNew;
                foreach (noeDataSet.noeRow noeCurrent in noeDS.noe.Rows)
                {
                        //
                        // Populate the sklt_noe_id Drop Down List
                        //
                        if (noeCurrent.noe_cls == NoeCls.szh_sklt.ToString())
                        {
                            noeListItemNew = new ListItem();
                            noeListItemNew.Value = noeCurrent.noe_id.ToString();
                            noeListItemNew.Text = noeCurrent.noe_nam.ToString();

                            ctlsklt_noe_id.Items.Add(noeListItemNew);
                        }
                        //
                        // Populate the szh_fndsion Drop Down List
                        //

                        if (noeCurrent.noe_cls == NoeCls.szh_fndsion.ToString())
                        {
                            noeListItemNew = new ListItem();
                            noeListItemNew.Value = noeCurrent.noe_id.ToString();
                            noeListItemNew.Text = noeCurrent.noe_nam.ToString();

                            ctlfndsion_noe_id.Items.Add(noeListItemNew);
                        }
                      
                        //
                        // Populate the divar_karji_glb_id Drop Down List
                        //

                        if (noeCurrent.noe_cls == NoeCls.szh_divar_kharji.ToString())
                        {
                            noeListItemNew = new ListItem();
                            noeListItemNew.Value = noeCurrent.noe_id.ToString();
                            noeListItemNew.Text = noeCurrent.noe_nam.ToString();

                            ctldivar_karji_glb_id.Items.Add(noeListItemNew);


                        }
                       
                        
                    }
                }
            }

           

            

        

        /// <summary>
        /// Loads a row from the sazeh table for viewing or editing
        /// </summary>
        /// <returns>true on success, false on error</returns>
        private bool LoadData()
        {
            if ((DataEntryMode != PageDataEntryMode.EditRow) && (DataEntryMode != PageDataEntryMode.ViewRow))
            {
                return true;
            }

            sazehDataSet sazehDS = new sazehDataSet();
            sazehService sazehLogic = new sazehService();

            if (sazehLogic.GetByszh_id(sazehDS, m_szh_idCurrent) == 0)
            {
                //
                // sazeh Row not found
                //
                return false;
            }

            sazehDataSet.sazehRow sazehRowCurrent = sazehDS.sazeh[0];
            ListItem SelectedListItem;

            //
            // Populate the Page controls from the DataRow
            //
            ctlszh_id.Text = sazehRowCurrent.szh_id.ToString();
            ctlmlk_id.Text = (sazehRowCurrent.Ismlk_idNull()) ? string.Empty : sazehRowCurrent.mlk_id.ToString();
            ctlrsht_id.Text = sazehRowCurrent.rsht_id.ToString();
            ctlmodirt_id.Text = sazehRowCurrent.modirt_id.ToString();
            ctlshrstan_id.Text = sazehRowCurrent.shrstan_id.ToString();
            ctlshobh_id.Text = (sazehRowCurrent.Isshobh_idNull()) ? string.Empty : sazehRowCurrent.shobh_id;
            SelectedListItem = ctlfndsion_noe_id.Items.FindByValue(sazehRowCurrent.fndsion_noe_id.ToString());
            if (SelectedListItem != null)
            {
                ctlfndsion_noe_id.ClearSelection();
                SelectedListItem.Selected = true;
            }
            ctlfndsion_tozi.Text = (sazehRowCurrent.Isfndsion_toziNull()) ? string.Empty : sazehRowCurrent.fndsion_tozi;
            SelectedListItem = ctlsgf_noe_id.Items.FindByValue(sazehRowCurrent.sgf_noe_id.ToString());
            if (SelectedListItem != null)
            {
                ctlsgf_noe_id.ClearSelection();
                SelectedListItem.Selected = true;
            }
            ctlsgf_sayr.Text = (sazehRowCurrent.Issgf_sayrNull()) ? string.Empty : sazehRowCurrent.sgf_sayr;
            ctlsgf_tozi.Text = (sazehRowCurrent.Issgf_toziNull()) ? string.Empty : sazehRowCurrent.sgf_tozi;
            SelectedListItem = ctlsklt_noe_id.Items.FindByValue(sazehRowCurrent.sklt_noe_id.ToString());
            if (SelectedListItem != null)
            {
                ctlsklt_noe_id.ClearSelection();
                SelectedListItem.Selected = true;
            }
            ctlsklt_tozi.Text = (sazehRowCurrent.Issklt_toziNull()) ? string.Empty : sazehRowCurrent.sklt_tozi;
            ctlsklt_sayr.Text = (sazehRowCurrent.Issklt_sayrNull()) ? string.Empty : sazehRowCurrent.sklt_sayr;
            SelectedListItem = ctldivar_karji_glb_id.Items.FindByValue(sazehRowCurrent.divar_karji_glb_id.ToString());
            if (SelectedListItem != null)
            {
                ctldivar_karji_glb_id.ClearSelection();
                SelectedListItem.Selected = true;
            }
            ctldivar_dakli_glb_partition.Checked = sazehRowCurrent.divar_dakli_glb_partition;
            ctldivar_dakli_glb_simani.Checked = sazehRowCurrent.divar_dakli_glb_simani;
            ctldivar_dakli_glb_lika.Checked = sazehRowCurrent.divar_dakli_glb_lika;
            ctldivar_dakli_glb_hblx.Checked = sazehRowCurrent.divar_dakli_glb_hblx;
            ctldivar_dakli_glb_sofali.Checked = sazehRowCurrent.divar_dakli_glb_sofali;
            ctldivar_dakli_glb_poma.Checked = sazehRowCurrent.divar_dakli_glb_poma;
            ctldivar_dakli_glb_ajor.Checked = sazehRowCurrent.divar_dakli_glb_ajor;
            ctldivar_dakli_glb_drywall.Checked = sazehRowCurrent.divar_dakli_glb_drywall;
            ctldivar_dakli_glb_sayer.Checked = sazehRowCurrent.divar_dakli_glb_sayer;
            ctldivar_dakli_glb_sayer_val.Text = (sazehRowCurrent.Isdivar_dakli_glb_sayer_valNull()) ? string.Empty : sazehRowCurrent.divar_dakli_glb_sayer_val;
            ctldivar_dakli_glb_tozi.Text = (sazehRowCurrent.Isdivar_dakli_glb_toziNull()) ? string.Empty : sazehRowCurrent.divar_dakli_glb_tozi.ToString();
            ctlthvil_tarikh.Text = sazehRowCurrent.thvil_tarikh;
            ctlthvil_krshnas.Text = sazehRowCurrent.thvil_krshnas.ToString();


            return true;
        }


        /// <summary>
        /// Adds or updates the row in the Database
        /// </summary>
        /// <returns>true on success, false on error</returns>
        private bool SaveData()
        {
            //
            // Check that the Form has passed validation
            //
            Page.Validate();

            if (!Page.IsValid)
            {
                // Validation failed
                return false;
            }

            sazehDataSet sazehDS = new sazehDataSet();
            sazehService sazehLogic = new sazehService();
            sazehDataSet.sazehRow sazehRowCurrent;

            switch (DataEntryMode)
            {
                case PageDataEntryMode.AddRow:
                    //
                    // Create a New Row
                    //
                    sazehRowCurrent = sazehDS.sazeh.NewsazehRow();
                    break;

                case PageDataEntryMode.EditRow:
                    //
                    // Update existing Row
                    //
                    if (sazehLogic.GetByszh_id(sazehDS, m_szh_idCurrent) == 0)
                    {
                        //
                        // sazeh Row not found
                        //
                        return false;
                    }
                    else
                    {
                        sazehRowCurrent = sazehDS.sazeh[0];
                    }
                    break;

                default:
                    return false;
            }

            //
            // Set the DataRow values from the Page Controls
            //

            // mlk_id
            if (ctlmlk_id.Text.Length == 0)
            {
                sazehRowCurrent.Setmlk_idNull();
            }
            else
            {
                sazehRowCurrent.mlk_id = Convert.ToInt32(ctlmlk_id.Text);
            }

            // rsht_id
            sazehRowCurrent.rsht_id = Convert.ToInt32(ctlrsht_id.Text);
            // modirt_id
            sazehRowCurrent.modirt_id = Convert.ToInt32(ctlmodirt_id.Text);
            // shrstan_id
            sazehRowCurrent.shrstan_id = Convert.ToInt32(ctlshrstan_id.Text);
            // shobh_id
            if (ctlshobh_id.Text.Length == 0)
            {
                sazehRowCurrent.Setshobh_idNull();
            }
            else
            {
                sazehRowCurrent.shobh_id = ctlshobh_id.Text;
            }

            // fndsion_noe_id
            sazehRowCurrent.fndsion_noe_id = Convert.ToInt32(ctlfndsion_noe_id.SelectedItem.Value);
            // fndsion_tozi
            if (ctlfndsion_tozi.Text.Length == 0)
            {
                sazehRowCurrent.Setfndsion_toziNull();
            }
            else
            {
                sazehRowCurrent.fndsion_tozi = ctlfndsion_tozi.Text;
            }

            // sgf_noe_id
            sazehRowCurrent.sgf_noe_id = Convert.ToInt32(ctlsgf_noe_id.SelectedItem.Value);
            // sgf_sayr
            if (ctlsgf_sayr.Text.Length == 0)
            {
                sazehRowCurrent.Setsgf_sayrNull();
            }
            else
            {
                sazehRowCurrent.sgf_sayr = ctlsgf_sayr.Text;
            }

            // sgf_tozi
            if (ctlsgf_tozi.Text.Length == 0)
            {
                sazehRowCurrent.Setsgf_toziNull();
            }
            else
            {
                sazehRowCurrent.sgf_tozi = ctlsgf_tozi.Text;
            }

            // sklt_noe_id
            sazehRowCurrent.sklt_noe_id = Convert.ToInt32(ctlsklt_noe_id.SelectedItem.Value);
            // sklt_tozi
            if (ctlsklt_tozi.Text.Length == 0)
            {
                sazehRowCurrent.Setsklt_toziNull();
            }
            else
            {
                sazehRowCurrent.sklt_tozi = ctlsklt_tozi.Text;
            }

            // sklt_sayr
            if (ctlsklt_sayr.Text.Length == 0)
            {
                sazehRowCurrent.Setsklt_sayrNull();
            }
            else
            {
                sazehRowCurrent.sklt_sayr = ctlsklt_sayr.Text;
            }

            // divar_karji_glb_id
            sazehRowCurrent.divar_karji_glb_id = Convert.ToInt32(ctldivar_karji_glb_id.SelectedItem.Value);
            // divar_dakli_glb_partition
            sazehRowCurrent.divar_dakli_glb_partition = ctldivar_dakli_glb_partition.Checked;
            // divar_dakli_glb_simani
            sazehRowCurrent.divar_dakli_glb_simani = ctldivar_dakli_glb_simani.Checked;
            // divar_dakli_glb_lika
            sazehRowCurrent.divar_dakli_glb_lika = ctldivar_dakli_glb_lika.Checked;
            // divar_dakli_glb_hblx
            sazehRowCurrent.divar_dakli_glb_hblx = ctldivar_dakli_glb_hblx.Checked;
            // divar_dakli_glb_sofali
            sazehRowCurrent.divar_dakli_glb_sofali = ctldivar_dakli_glb_sofali.Checked;
            // divar_dakli_glb_poma
            sazehRowCurrent.divar_dakli_glb_poma = ctldivar_dakli_glb_poma.Checked;
            // divar_dakli_glb_ajor
            sazehRowCurrent.divar_dakli_glb_ajor = ctldivar_dakli_glb_ajor.Checked;
            // divar_dakli_glb_drywall
            sazehRowCurrent.divar_dakli_glb_drywall = ctldivar_dakli_glb_drywall.Checked;
            // divar_dakli_glb_sayer
            sazehRowCurrent.divar_dakli_glb_sayer = ctldivar_dakli_glb_sayer.Checked;
            // divar_dakli_glb_sayer_val
            if (ctldivar_dakli_glb_sayer_val.Text.Length == 0)
            {
                sazehRowCurrent.Setdivar_dakli_glb_sayer_valNull();
            }
            else
            {
                sazehRowCurrent.divar_dakli_glb_sayer_val = ctldivar_dakli_glb_sayer_val.Text;
            }

            // divar_dakli_glb_tozi
            if (ctldivar_dakli_glb_tozi.Text.Length == 0)
            {
                sazehRowCurrent.Setdivar_dakli_glb_toziNull();
            }
            else
            {
                sazehRowCurrent.divar_dakli_glb_tozi = Convert.ToInt32(ctldivar_dakli_glb_tozi.Text);
            }

            // thvil_tarikh
            sazehRowCurrent.thvil_tarikh = ctlthvil_tarikh.Text;
            // thvil_krshnas
            sazehRowCurrent.thvil_krshnas = Convert.ToInt32(ctlthvil_krshnas.Text);

            if (DataEntryMode == PageDataEntryMode.AddRow)
            {
                //
                // Add the new Row to the DataSet
                //
                sazehDS.sazeh.Rows.Add(sazehRowCurrent);
            }

            //
            // Save the changes to the database
            //
            sazehLogic.UpdateDataSet(sazehDS);

            //
            // Update the primary key values
            //
            m_szh_idCurrent = sazehRowCurrent.szh_id;


            return true;
        }
		#endregion

		
		#region Web Form Designer generated code
		
		
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			
		}
		
		#endregion

        protected void ctldivar_dakli_glb_sayer_CheckedChanged(object sender, EventArgs e)
        {
            if (ctldivar_dakli_glb_sayer.Checked)
            {
                tr_divar_dakli_glb_sayer_val.Visible = true;
                ctldivar_dakli_glb_sayer_val.Text = string.Empty;
            }
            else
            {
                tr_divar_dakli_glb_sayer_val.Visible = false;
                ctldivar_dakli_glb_sayer_val.Text = string.Empty;
            }
        }
}

