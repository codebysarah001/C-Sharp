<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="form-group">
            <label for="result">Result : </label>
            <asp:TextBox ID="result" runat="server" CssClass="form-control"></asp:TextBox><br />
        </div>
        <div class="form-group">
            <label for="number1">Number 1 : </label>
            <asp:TextBox ID="number1" runat="server" CssClass="form-control"></asp:TextBox><br />
        </div>
        <div class="form-group">
            <label for="number2">Number 2 : </label>
            <asp:TextBox ID="number2" runat="server" CssClass="form-control"></asp:TextBox><br />
        </div>
        
        <asp:Button ID="sum" runat="server" Text="+" CssClass="btn btn-primary" OnClick="SumButton_Click"/>
        <asp:Button ID="sub" runat="server" Text="-" CssClass="btn btn-primary" OnClick="SubButton_Click"/>
        <asp:Button ID="mul" runat="server" Text="*" CssClass="btn btn-primary" OnClick="MulButton_Click"/>

       
    </form>
</body>
</html>
