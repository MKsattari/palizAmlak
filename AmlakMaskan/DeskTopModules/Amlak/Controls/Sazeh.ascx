<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Sazeh.ascx.cs" Inherits="DeskTopModules_Amlak_Controls_Sazeh" %>
<link href="../Style/Default.css" rel="stylesheet" type="text/css" />




<asp:Panel ID="Panel1" runat="server" Direction="RightToLeft">
    <p>
        <asp:Label ID="lblMessage" CssClass="DataEntryFormMessage" runat="server"></asp:Label>
    </p>
    <br />
    <p>
        <asp:Label ID="Label1" CssClass="DataEntryFormMessage" runat="server"></asp:Label>
    </p>
    <br />
    <p>
        <asp:ValidationSummary ID="ctlValidationSummary" runat="server" CssClass="MsgValSummary"
            ForeColor=" " />
        <table id="tableView" border="0" cellpadding="1" cellspacing="0" class="DataEntryForm">
            <tr class="DataEntryTitle">
                <th nowrap="nowrap">&nbsp; </th>
                <th colspan="4">Sazeh </th>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Szh Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Szh Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:Label ID="ctlszh_id" runat="server" CssClass="DataEntry"></asp:Label>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Mlk Id</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlmlk_id" runat="server" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                    <asp:RangeValidator ID="ctlmlk_idValInt32" runat="server" ControlToValidate="ctlmlk_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Mlk Id must be a whole number" ForeColor=" " MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer">
                    </asp:RangeValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Rsht Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Rsht Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlrsht_id" runat="server" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="ctlrsht_idValRequired" runat="server" ControlToValidate="ctlrsht_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Rsht Id must be entered" ForeColor=" ">
                    </asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="ctlrsht_idValInt32" runat="server" ControlToValidate="ctlrsht_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Rsht Id must be a whole number" ForeColor=" " MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Modirt Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Modirt Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlmodirt_id" runat="server" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="ctlmodirt_idValRequired" runat="server" ControlToValidate="ctlmodirt_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Modirt Id must be entered" ForeColor=" ">
                    </asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="ctlmodirt_idValInt32" runat="server" ControlToValidate="ctlmodirt_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Modirt Id must be a whole number" ForeColor=" " MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Shrstan Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Shrstan Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlshrstan_id" runat="server" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="ctlshrstan_idValRequired" runat="server" ControlToValidate="ctlshrstan_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Shrstan Id must be entered" ForeColor=" ">
                    </asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="ctlshrstan_idValInt32" runat="server" ControlToValidate="ctlshrstan_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Shrstan Id must be a whole number" ForeColor=" " MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Shobh Id</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlshobh_id" runat="server" Columns="10" CssClass="DataEntry" MaxLength="10">
                    </asp:TextBox>
                    <br />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Fndsion Noe Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Fndsion Noe Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:DropDownList ID="ctlfndsion_noe_id" runat="server" CssClass="DataEntry">
                        <asp:ListItem Value="(null)">(none)</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:CompareValidator ID="ctlfndsion_noe_idValNotNull" runat="server" ControlToValidate="ctlfndsion_noe_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Fndsion Noe Id must be entered" ForeColor=" " Operator="NotEqual" ValueToCompare="(null)">
                    </asp:CompareValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Fndsion Tozi</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlfndsion_tozi" runat="server" Columns="50" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Sgf Noe Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Sgf Noe Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:DropDownList ID="ctlsgf_noe_id" runat="server" CssClass="DataEntry">
                        <asp:ListItem Value="(null)">(none)</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:CompareValidator ID="ctlsgf_noe_idValNotNull" runat="server" ControlToValidate="ctlsgf_noe_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Sgf Noe Id must be entered" ForeColor=" " Operator="NotEqual" ValueToCompare="(null)">
                    </asp:CompareValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Sgf Sayr</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlsgf_sayr" runat="server" Columns="100" CssClass="DataEntry" Rows="2" TextMode="MultiLine">
                    </asp:TextBox>
                    <br />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Sgf Tozi</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlsgf_tozi" runat="server" Columns="50" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Sklt Noe Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Sklt Noe Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:DropDownList ID="ctlsklt_noe_id" runat="server" CssClass="DataEntry">
                        <asp:ListItem Value="(null)">(none)</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:CompareValidator ID="ctlsklt_noe_idValNotNull" runat="server" ControlToValidate="ctlsklt_noe_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Sklt Noe Id must be entered" ForeColor=" " Operator="NotEqual" ValueToCompare="(null)">
                    </asp:CompareValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Sklt Tozi</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlsklt_tozi" runat="server" Columns="100" CssClass="DataEntry" Rows="2" TextMode="MultiLine">
                    </asp:TextBox>
                    <br />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Sklt Sayr</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlsklt_sayr" runat="server" Columns="50" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Karji Glb Id</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Divar Karji Glb Id must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:DropDownList ID="ctldivar_karji_glb_id" runat="server" CssClass="DataEntry">
                        <asp:ListItem Value="(null)">(none)</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:CompareValidator ID="ctldivar_karji_glb_idValNotNull" runat="server" ControlToValidate="ctldivar_karji_glb_id" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Divar Karji Glb Id must be entered" ForeColor=" " Operator="NotEqual" ValueToCompare="(null)">
                    </asp:CompareValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Partition</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_partition" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Simani</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_simani" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Lika</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_lika" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Hblx</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_hblx" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Sofali</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_sofali" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Poma</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_poma" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Ajor</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_ajor" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Drywall</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_drywall" runat="server" CssClass="DataEntry" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Sayer</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:CheckBox ID="ctldivar_dakli_glb_sayer" runat="server" AutoPostBack="True" CssClass="DataEntry" OnCheckedChanged="ctldivar_dakli_glb_sayer_CheckedChanged" />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr id="tr_divar_dakli_glb_sayer_val" runat="server" visible="false">
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Sayer Val</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctldivar_dakli_glb_sayer_val" runat="server" Columns="30" CssClass="DataEntry" Rows="2"></asp:TextBox>
                    <br />
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Divar Dakli Glb Tozi</span> </td>
                <td nowrap="nowrap" valign="top"></td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctldivar_dakli_glb_tozi" runat="server" Columns="100" CssClass="DataEntry" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <asp:RangeValidator ID="ctldivar_dakli_glb_toziValInt32" runat="server" ControlToValidate="ctldivar_dakli_glb_tozi" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Divar Dakli Glb Tozi must be a whole number" ForeColor=" " MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer">
                    </asp:RangeValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Thvil Tarikh</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Thvil Tarikh must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlthvil_tarikh" runat="server" Columns="10" CssClass="DataEntry" MaxLength="10">
                    </asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="ctlthvil_tarikhValRequired" runat="server" ControlToValidate="ctlthvil_tarikh" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Thvil Tarikh must be entered" ForeColor=" ">
                    </asp:RequiredFieldValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top"><span class="FieldCaption">Thvil Krshnas</span> </td>
                <td nowrap="nowrap" valign="top"><span class="RequiredFieldMark" title="Thvil Krshnas must be entered">*</span> </td>
                <td nowrap="nowrap">
                    <asp:TextBox ID="ctlthvil_krshnas" runat="server" CssClass="DataEntry">
                    </asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="ctlthvil_krshnasValRequired" runat="server" ControlToValidate="ctlthvil_krshnas" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Thvil Krshnas must be entered" ForeColor=" ">
                    </asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="ctlthvil_krshnasValInt32" runat="server" ControlToValidate="ctlthvil_krshnas" CssClass="MsgVal" Display="Dynamic" ErrorMessage="Thvil Krshnas must be a whole number" ForeColor=" " MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
                </td>
                <td>&nbsp; </td>
            </tr>
            <tr class="DataEntryFooter">
                <td>&nbsp; </td>
                <td>&nbsp; </td>
                <td>&nbsp; </td>
                <td nowrap="nowrap" valign="top">
                    <asp:Button ID="btnOK" runat="server" CssClass="Button" Text="OK" />
                    &nbsp;<asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="Button" Text="Cancel" />
                    &nbsp;<asp:Button ID="btnApply" runat="server" CssClass="Button" Text="Apply" />
                    &nbsp; </td>
                <td>&nbsp; </td>
            </tr>
        </table>
    </p>
</asp:Panel>
