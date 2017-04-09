<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormstag.aspx.cs" Inherits="tp_4.WebFormstag" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestion Des stagiaires </title>
    <style type="text/css">
        .style1
        {
            width: 476px;
        }
        .style2
        {
            width: 171px;
        }
    </style>
</head>
<body>
<h1><font color =aqua>Application</font>     => <font size= 5>Gestion des stagiares </font></h1>
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style1">
                <table style="width:100%;">
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label1" runat="server" Text="Nom"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxNom" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblID" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label2" runat="server" Text="Prenom"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxPrenom" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:Label ID="Label3" runat="server" Text="Groupe"></asp:Label>
                        </td>
                        <td>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                                DeleteMethod="Delete" InsertMethod="Insert" 
                                OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
                                TypeName="tp_4.DSTableAdapters.groupeTableAdapter" UpdateMethod="Update">
                                <DeleteParameters>
                                    <asp:Parameter Name="Original_idg" Type="Int32" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="nomg" Type="String" />
                                    <asp:Parameter Name="datecreation" Type="DateTime" />
                                    <asp:Parameter Name="datemodification" Type="DateTime" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="nomg" Type="String" />
                                    <asp:Parameter Name="datecreation" Type="DateTime" />
                                    <asp:Parameter Name="datemodification" Type="DateTime" />
                                    <asp:Parameter Name="Original_idg" Type="Int32" />
                                </UpdateParameters>
                            </asp:ObjectDataSource>
                            <asp:DropDownList ID="DropDownListGr" runat="server" 
                                DataSourceID="ObjectDataSource1" DataTextField="nomg" DataValueField="idg" 
                                onselectedindexchanged="DropDownListGr_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Button ID="aj" runat="server" onclick="aj_Click" Text="Ajouter" 
                                Width="91px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Butmod" runat="server" Text="Modifier" Width="89px" 
                                onclick="Butmod_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Butsup" runat="server" Text="Supprimer" 
                                onclick="Butsup_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label4" runat="server" Text="Date Création"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbldatecreat" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Butenreg" runat="server" onclick="Butenreg_Click" 
                    Text="Enregistrer" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label5" runat="server" Text="Date Modification"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbldatemodi" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table style="width: 45%;">
        <tr>
            <td>
&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
                
                <asp:Button ID="Button1" CommandName="Fin" runat="server" Text="Last" onclick="Navigation_Click"/>
                <asp:Button ID="Button2" CommandName="Precedent" runat="server" Text="Previeus" onclick="Navigation_Click"/>
                <asp:Button ID="Button3" CommandName="Suivant" runat="server" Text="Next" onclick="Navigation_Click"/>
                <asp:Button ID="Butlast" CommandName="Debut" runat="server" Text="First" onclick="Navigation_Click"/>
                </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" > 
                <Columns>
               
                  <%--  onselectedindexchanged="GridView1_SelectedIndexChanged">--%>
                <asp:BoundField DataField = "idg" HeaderText="Groupe" SortExpression="Groupe"/>
                <asp:BoundField DataField = "nom" HeaderText="Nom"/>
                 <asp:BoundField DataField = "prenom" HeaderText="Prenom"/>
                  <asp:BoundField DataField = "date_creation" HeaderText="Date de creation"/>
                <asp:BoundField DataField = "date_modification" HeaderText="date de modification" />
                <asp:BoundField DataField = "id"   HeaderText="Id"/>
                </Columns>
                </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    </form>
</body>
</html>
