<%-- 
    Document   : edit
    Created on : Mar 13, 2020, 11:08:51 PM
    Author     : lenovo
--%>

<%@page import="model.Account"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <% Account acc = (Account) request.getAttribute("account"); %>
    </head>
    <body>
        <form action="update" method="POST">
            Username: <input type="text" value="<%= acc.getUsername() %>" readonly  name="username" />
            Password: <input type="password" value="<%= acc.getPassword()%>" name="password"/>
            <input type="submit" value="Update"/>
            <a href="list"/>Return to list
        </form>
    </body>
</html>
