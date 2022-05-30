<%-- 
    Document   : Login
    Created on : Mar 7, 2020, 12:45:16 AM
    Author     : lenovo
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <form action="login" method="POST" >
                Username: <input type="text" name="username" /><br/>
                <input type="password" name="password" /><br/>
                <input type="submit" value="Login" />     
                <button><a href="insert" target="_blank" >Add</a></button>
        </form>
        
       
        
    </body>
</html>
