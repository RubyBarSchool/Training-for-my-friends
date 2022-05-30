<%-- 
    Document   : insert
    Created on : Mar 7, 2020, 10:48:29 PM
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
        <form action="insert" method="POST" >
                UserName: <input type="text" name="username" /><br/>
                PassWord<input type="password" name="password" /><br/>
                <input type="submit" value="Insert" />
        </form>
    </body>
</html>
