<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormManipulation.aspx.cs" Inherits="tp_4.WebFormManipulation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" 
            DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#990000" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#FFFBD6" />
            <DynamicSelectedStyle BackColor="#FFCC66" />
            <Items>
               <asp:MenuItem NavigateUrl="~/WebFormManipulation.aspx"
                    Text="Application" Value="Application"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Stagiaire Presentation/WebFormstag.aspx" 
                    Text="Stagiaire" Value="Stagiaire"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Presentation/Groupe Presentation/WebForm1.aspx" 
                    Text="Groupe" Value="Groupe"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Stagiaire Presentation/WebFormRechercher.aspx" 
                    Text="Recherecher" Value="Recherecher"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#FFCC66" />
        </asp:Menu>
        <br />
        <table style="width: 100%; height: 75px;">
            <tr>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Derniers Stagiares Manipulées :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Stag" runat="server" onclick="Stag_Click" Text="Afficher" 
                        Width="115px" />
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
        <table style="width: 100%; height: 69px;">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Derniers Groupes Manipulées&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Grp" runat="server" onclick="Grp_Click" Text="Afficher" 
                        Width="115px" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                <Columns>
               
                  <%--  onselectedindexchanged="GridView1_SelectedIndexChanged">--%>
                <asp:BoundField DataField = "idg" HeaderText="Id" SortExpression="Groupe"/>
                <asp:BoundField DataField = "nomg" HeaderText="Nom"/>
                  <asp:BoundField DataField = "datecreation" HeaderText="Date de creation"/>
                <asp:BoundField DataField = "datemodification" HeaderText="date de modification" />
                
                </Columns>
                </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
