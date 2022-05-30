<%-- 
    Document   : list
    Created on : Mar 7, 2020, 11:07:40 PM
    Author     : lenovo
--%>

<%@page import="model.Account"%>
<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <% ArrayList<Account> arr = (ArrayList<Account>)request.getAttribute("list"); %>
    </head>
    <body>
        <table border="1px" >
            <tr>
                <td>Username</td>
                <td>Password</td>
            </tr>
            <% for(Account a : arr){ %>
            <tr>
                <td><%= a.getUsername() %></td>
                <td><%= a.getPassword()%></td>
            </tr>
            <%}%>
        </table>
    </body>
</html>
