<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageLifeCycleEvent.aspx.cs" Inherits="Default2" CodeBehind="PageLifeCycleEvent.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <b>Page Life Cycle Visualization:</b>
    </div>
       


   
<br />
<br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /><br /><br />
        

        <%= PageSteps %><br />

         <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>


    </body>
</html>
