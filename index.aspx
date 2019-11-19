<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RajvirKaur_Lab4.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <asp:Label ID="Label1" runat="server" Text="Student Record"></asp:Label>
            </tr>
        </table>
        <table>
            
            <tr>
                <td>STUDENT ID</td>
                <td>
                    <asp:TextBox ID="studentID" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                        runat="server" ControlToValidate="studentID" Display="Dynamic" ForeColor="red" ErrorMessage="Student ID is mandatory!!"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ErrorMessage="The ID must be number!" Display="Dynamic"
                        Operator="DataTypeCheck" Type="Integer" ForeColor="red" ControlToValidate="studentID" ></asp:CompareValidator>

                  
                </td>
                 </tr> 
            <tr>
             <td> FIRST NAME:</td>
                <td>
                     <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
               <tr>
                 <td>LAST NAME</td>
                   <td>
                        <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
                       
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Button ID="addButton" runat="server" Text="Add Student" OnClick="addButton_Click" />
                   </td>
                   <td>
                       <asp:Button ID="delButton" runat="server" Text="Delete Student Record" />
                       <asp:Button ID="updateButton" runat="server" Text="Update Student Record" OnClick="updateButton_Click" />
                       <asp:Button ID="getButton" runat="server" Text="Get existing Student IDs" OnClick="getButton_Click" />
                   </td>
                   <td>
                       &nbsp;</td>
               </tr>
          
        </table>
        <asp:Label ID="message" runat="server" Text=""></asp:Label>
        <asp:Label ID="stuID" runat="server" Text=""></asp:Label>
        <asp:Label ID="lNAme" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
