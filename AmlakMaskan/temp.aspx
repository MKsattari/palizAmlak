<%@ Page Language="C#" AutoEventWireup="true" CodeFile="temp.aspx.cs" Inherits="temp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:DropDownList ID="sklt_noe_idDropDown" runat="server" DataSourceID="NoeSqlDataSource" DataTextField="noe_nam" DataValueField="noe_id" SelectedValue='<%# Eval("sklt_noe_id") %>'>
  </asp:DropDownList>
        <asp:SqlDataSource ID="NoeSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AmlakMaskanConnectionString %>" SelectCommand="SELECT noe_id, noe_nam    FROM noe WHERE (noe_cls = N'sazeh')"></asp:SqlDataSource>



    <div dir="rtl">
    <table style="width: 100%;">
            <tr>
                <td>szh_id:</td>
                <td>
                    <asp:TextBox ID="szh_idLabel" runat="server" Text='<%# Eval("szh_id") %>' /></td>
                <td>rsht_id:</td>
                <td>
                    <asp:TextBox ID="rsht_idLabel" runat="server" Text='<%# Bind("rsht_id") %>' /></td>
            </tr>
            <tr>
                <td>modirt_id:</td>
                <td>
                    <asp:TextBox ID="modirt_idLabel" runat="server" Text='<%# Bind("modirt_id") %>' /></td>
                <td>shrstan_id:</td>
                <td>
                    <asp:TextBox ID="shrstan_idLabel" runat="server" Text='<%# Bind("shrstan_id") %>' /></td>
            </tr>
            <tr>
                <td>shobh_id:</td>
                <td>
                    <asp:TextBox ID="shobh_idLabel" runat="server" Text='<%# Bind("shobh_id") %>' /></td>
                <td>fndsion_noe_id:
                </td>
                <td>
                    <asp:TextBox ID="fndsion_noe_idLabel" runat="server" Text='<%# Bind("fndsion_noe_id") %>' /></td>
            </tr>
            <tr>
                <td>fndsion_tozi:
                </td>
                <td>
                    <asp:TextBox ID="fndsion_toziLabel" runat="server" Text='<%# Bind("fndsion_tozi") %>' /></td>
                <td>sgf_noe_id:
                </td>
                <td>
                    <asp:TextBox ID="sgf_noe_idLabel" runat="server" Text='<%# Bind("sgf_noe_id") %>' /></td>
            </tr>
            <tr>
                <td>sgf_sayr:
                </td>

                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>fndsion_tozi:
                </td>

                <td>
                    <asp:TextBox ID="sgf_sayrLabel" runat="server" Text='<%# Bind("sgf_sayr") %>' /></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>fndsion_tozi:
                </td>

                <td>&nbsp;<asp:TextBox ID="sgf_toziLabel" runat="server" Text='<%# Bind("sgf_tozi") %>' />
                </td>
                <td>
                    &nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td>sklt_noe_id
                   </td>
                <td> <asp:TextBox ID="sklt_noe_idLabel" runat="server" Text='<%# Bind("sklt_noe_id") %>' /></td>
                <td> sklt_tozi:
       
                </td>

                <td> <asp:TextBox ID="sklt_toziLabel" runat="server" Text='<%# Bind("sklt_tozi") %>' />
                </td>
                
            </tr>
            <tr>
                <td>divar_dakli_glb_tozi: </td>
                <td>
                    <asp:TextBox ID="divar_dakli_glb_toziLabel" runat="server" Text='<%# Bind("divar_dakli_glb_tozi") %>' />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>thvil_tarikh:</td>
                <td>
                    <asp:TextBox ID="thvil_tarikhLabel" runat="server" Text='<%# Bind("thvil_tarikh") %>' />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>thvil_krshnas:</td>
                <td>
                    <asp:TextBox ID="thvil_krshnasLabel" runat="server" Text='<%# Bind("thvil_krshnas") %>' />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
