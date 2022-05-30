<%-- 
    Document   : add
    Created on : Mar 8, 2020, 11:51:47 AM
    Author     : Duc Anh
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <%  %>
    </head>
    <body>
        <form action="add" method="POST">
            Username: <input type="text" name="username"/><br>
            Password: <input type="password" name="password"/>        
            <h1>${(param.Error ne null)?"username exits":""}</h1>
            <input type="submit" value="Add"/>
            <a href="list"/>Return to list
        </form>
    </body>
</html>
