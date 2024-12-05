<!--
# Name:Luke Elmore,Nate Hoang,Ray Happel
# email:elmorels@mail.uc.edu,hoangnd@mail.uc.edu,happelrc@mail.uc.edu
# Assignment Title: Final Project
# Due Date:12/10/2024
# Course: IS 3050
# Semester/Year:fall 2024
# Brief Description: This makes a table with 2 rows and 2 columns to be able to put the problems and solutions in
# Citations: Stacked overflow,InClass_2024_11_19_IS3050_001
-->
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
                            <asp:ListItem>Wildcard Matching</asp:ListItem>
                            <asp:ListItem>Distinct Subsequences</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="cmdClickForAnswer" runat="server" Text="Click for solution" OnClick="cmdClickForAnswer_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSolution" runat="server" Text="Solution"></asp:Label>
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
