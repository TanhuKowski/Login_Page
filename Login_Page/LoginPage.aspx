<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Login_Page.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        @import url(https://fonts.googleapis.com/css?family=Roboto:300);
body{
 background-color:darkgoldenrod;
  font-family: "Roboto", sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;  
}

table{
    background-color:cadetblue;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div>
          <table align="center" style="border: thin solid #008080; width: 391px; height: 7px;">
                 <tr>
                <td colspan="3" 
                    style="text-align: center; font-weight: 700; border-bottom-style: solid; border-bottom-width: thin; border-bottom-color: #008080; background-color: skyblue">
                    User Login Area</td>
            </tr>
              <tr>
                  <td>
         <asp:Label Text="Username" Class="label_user" style="width: 79px;" ID="label_user_login" runat="server" />
            <asp:TextBox Class="txt_user" runat="server" ID="txt_user" style="margin-left: 20px;" placeholder="Enter the Username" Width="202px" />
                      </td>
                  </tr>
                 <tr>
                     <td>
            <asp:Label Text="Password" Class="label_pass" style="width: 79px;" ID="label_pass_login" runat="server" />
            <asp:TextBox Class="txt_pass" runat="server" ID="txt_pass" style="margin-left: 22px;" placeholder="Enter the Password" TextMode="Password" Width="203px" />
                         </td>
                  </tr>
              <tr>
                  <td>
            <asp:Button Text="Log In" ID="btn_login" style="width: 131px;  text-align:center; margin-left:125px; background-color:darkred; color:white;" runat="server" OnClick="btn_login_Click" />
                      </td>
                  </tr>
              <tr>
                  <td>
                      <asp:Button ID="btn_register" runat="server" style="width: 170px;  text-align:center; margin-left:105px; background-color:darkgreen; color:white;" Text="Create a new account" OnClick="btn_register_Click" />
                      </td>
                  </tr>
              <tr style="width: 79px;">
               <td colspan="2">
                    <asp:Label ID="lblmsg" style="font:bolder;" runat="server"></asp:Label>
                   </td>
                  </tr>
              </table>
    </div>
        </form>
</body>
</html>
