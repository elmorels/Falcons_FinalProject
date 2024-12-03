<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Falcons_FinalProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border ="1">
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlSolutionSelector" runat="server" >
                            <asp:ListItem>Basic Calculator</asp:ListItem>
                            <asp:ListItem>Sudoku Solver</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="cdmClickForAnswer" runat="server" Text="Click for solution" OnClick="cdmClickForAnswer_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="llbSolution" runat="server" Text="Solution"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblShowSolution" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
               </table>
              
            
        </div>
    </form>
</body>
</html>
