<%-- 
    Document   : login
    Created on : Mar 8, 2020, 11:36:18 AM
    Author     : Duc Anh
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
            Username: <input type="text" name="username"/><br/>
            Password: <input type="password" name="password"/><br/>
            <input type="checkbox" value="remember" name="remember" />Remember<br>
            <input type="submit" value="Login"/>
        </form>
    </body>
</html>
