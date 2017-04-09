<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="tp_4.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 434px;
        }
        .style2
        {
            width: 518px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style2">
                <table style="width: 139%;">
                    <tr>
                        <td class="style1">
                            <asp:Label ID="Label1" runat="server" Text="Nom"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextNom" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;
                            <asp:Label ID="LabelId" runat="server" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:Label ID="Label2" runat="server" Text="date Creation"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lbldateCreation" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:Label ID="Label3" runat="server" Text="Date Modification"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblDateModification" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width: 43%; margin-left: 272px;">
                    <tr>
                        <td>
                            <asp:Button ID="Butenreg" runat="server" Text="Enregistrer" 
                                onclick="Butenreg_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Butsup" runat="server" Text="Supprimer" 
                                onclick="Butsup_Click" Width="94px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Butmodi" runat="server" Text="Modifier" 
                                onclick="Butmodi_Click" Width="93px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="ButNv" runat="server" Text="Nouveau" onclick="ButNv_Click" 
                                Width="93px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2">
&nbsp;&nbsp;
                &nbsp;&nbsp;
                &nbsp;&nbsp;
                <asp:Button ID="Butlast" CommandName="Debut" runat="server" Text="Last" onclick="Navigation_Click"/>
                <asp:Button ID="Butprev" CommandName="Precedent"  runat="server" Text="Previews" onclick="Navigation_Click" />
                <asp:Button ID="Butnext" CommandName="Suivant"  runat="server" Text="Next" 
                    onclick="Navigation_Click" style="width: 41px"/>
                <asp:Button ID="Butfirst" CommandName="Fin"  runat="server" Text="First" onclick="Navigation_Click" />
                </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                <Columns>
               
                  <%--  onselectedindexchanged="GridView1_SelectedIndexChanged">--%>
                <asp:BoundField DataField = "nomg" HeaderText="Nom du groupe" SortExpression="Nom"/>
                <asp:BoundField DataField = "datecreation" HeaderText="Date de creation"/>
                <asp:BoundField DataField = "datemodification" HeaderText="date de modification" />
                <asp:BoundField DataField = "idg"   HeaderText="Id"/>
                </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    </form>
</body>
</html>
