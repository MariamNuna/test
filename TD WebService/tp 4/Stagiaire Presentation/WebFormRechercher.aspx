<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRechercher.aspx.cs" Inherits="tp_4.WebFormRechercher" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 245px;
        }
        .style2
        {
            width: 245px;
            height: 45px;
        }
        .style3
        {
            height: 45px;
        }
        .style4
        {
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 57%; height: 93px; margin-bottom: 0px;">
            <tr>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Nom"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label2" runat="server" Text="Groupe"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        DataSourceID="ObjectDataSource1" DataTextField="nomg" DataValueField="idg">
                    </asp:DropDownList>
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
                </td>
            </tr>
            <tr>
                <td class="style4" colspan="2">
                    <asp:Button ID="butrech" runat="server" onclick="butrech_Click" 
                        Text="Rechercher" Width="163px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Nouveau" Width="163px" 
                        onclick="Button1_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
               
                  <%--  onselectedindexchanged="GridView1_SelectedIndexChanged">--%>
                <asp:BoundField DataField = "idg" HeaderText="Groupe" SortExpression="Groupe"/>
                <asp:BoundField DataField = "nom" HeaderText="Nom"/>
                 <asp:BoundField DataField = "prenom" HeaderText="Prenom"/>
                  <asp:BoundField DataField = "date_creation" HeaderText="Date de creation"/>
                <asp:BoundField DataField = "date_modification" HeaderText="date de modification" />
                <asp:BoundField DataField = "id"  Visible ="false" HeaderText="Id"/>
                </Columns>
                </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
