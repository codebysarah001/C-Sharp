<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormSubmission.aspx.cs" Inherits="Task7.FormSubmission" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Information</title>
    <style>
        <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 20px;
            background-color: #f0f0f0;
        }

        form {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 600px;
            margin: auto;
        }

        label {
            font-weight: bold;
            display: inline-block;
            margin-bottom: 5px;
        }

        input[type="text"],
        input[type="email"],
        textarea {
            width: 100%;
            padding: 5px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        input[type="radio"],
        input[type="checkbox"] {
            margin-right: 10px;
        }

        div {
            margin-bottom: 15px;
        }

        .button-container {
            text-align: center;
            
        }

        .button-container button {
            background-color: #007BFF; /* New button color */
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            display: inline-block;
        }

        .button-container button:hover {
            background-color: #0056b3; /* Hover color */
        }

        hr {
            margin-top: 40px;
            margin-bottom: 40px;
            border: 0;
            border-top: 1px solid #ccc;
        }

        h2 {
            color: #333;
            text-align: center;
        }

        .result-section label {
            font-weight: normal;
        }
    </style>
    </style>
</head>
<body>

    <h2 style="text-align: center;">Form Submission</h2>

    <form id="form1" runat="server">

        <%-- Name --%>

        <div>
            <label for="name" >Name : </label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </div>

        <br />

        <%-- Email --%>

        <div>
            <label for="email" >Email : </label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </div>
        <br />

        <%-- ID --%>

        <div>
            <label for="id" >ID : </label>
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
        </div>

        <br />

        <%-- Gender --%>

        <div>
            <label>Gender : </label>
            <div>
                <asp:RadioButton ID="genderMale" runat="server" GroupName="Gender"></asp:RadioButton>
                <label for="genderMale">Male</label>
            </div>

            <div>
                <asp:RadioButton ID="genderFemale" runat="server" GroupName="Gender"></asp:RadioButton>
                <label for="genderFemale">Female</label>
            </div>
        </div>

        <br />

         <%-- Courses --%>

         <div>
             <label>Courses </label>
             <div>
                 <asp:CheckBox ID="courseCSS" runat="server"></asp:CheckBox>
                 <label for="courseCSS">CSS</label>
             </div>

             <div>
                 <asp:RadioButton ID="courseHTML" runat="server"></asp:RadioButton>
                 <label for="courseHTML">HTML</label>
             </div>

             <div>
                <asp:RadioButton ID="courseJavaScript" runat="server"></asp:RadioButton>
                <label for="courseJavaScript">JavaScript</label>
            </div>
         </div>

        <br />


         <%-- Description --%>

        <div>
            <label>Description </label><br />
            <asp:TextBox ID="description" runat="server" TextMode="MultiLine"></asp:TextBox><br />
        </div>

        <br />
        
        <%--Button--%>

        <div class="button-container">
            <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"></asp:Button>
            <asp:Literal ID="result" runat="server"></asp:Literal>
        </div>
    </form>

    <br /><br /><hr />
    <h2 style="text-align:left;">Personal Information</h2>
    <label id="name1" runat="server">Name : </label><br />
    <label id="email1" runat="server">Email : </label><br />
    <label id="id1" runat="server">ID : </label><br />
    <label id="gender1" runat="server">Gender : </label><br />
    <label id="courses1" runat="server">Courses : </label><br />
    <label id="dec" runat="server">Description : </label><br />

</body>
</html>
