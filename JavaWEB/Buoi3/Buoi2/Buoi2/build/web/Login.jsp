<%-- 
    Document   : Login
    Created on : Mar 6, 2020, 5:59:42 PM
    Author     : Nguyen Dang Hung
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <form action="login" method="POST">
            Enter username:<input type="text" name="user"/>
            <br/>
            Enter password:<input type="password" name="pass"/>
            <br/>
            <input type="submit" value="Login"/>
        </form>
    </body>
</html>
