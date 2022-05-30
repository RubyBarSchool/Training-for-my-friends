<%-- 
    Document   : list
    Created on : Mar 8, 2020, 11:42:33 AM
    Author     : Duc Anh
--%>

<%@page import="java.util.ArrayList"%>
<%@page import="model.Account"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ taglib prefix = "tvt" uri = "http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <%
            ArrayList<Account> accounts = (ArrayList<Account>) request.getAttribute("accounts");
        %>
    </head>
    <body>
        <table border ="1px">
            <tr>
                <td>Username</td>
                <td>Password</td>
                <td colspan="2" ></td>
            </tr>
            <%for (Account a : accounts) {%>
            <tr>
                <td><%=a.getUsername()%></td>
                <td><%=a.getPassword()%></td>
                <td><a href="update?username=<%= a.getUsername() %>"/>Edit</td>
                <td><a href="remove?username=<%= a.getUsername() %>"/>Remove</td>
            </tr>
            <%  }%>
            <tvt:forEach items="${requestScope.accounts}" var="acc" >
                 <tr>
                <td>${acc.getUsername()}</td>
                <td>${acc.password}</td>
            </tr>
                
            </tvt:forEach>
            <tr>
                <td colspan="2" ><a href="add"/>Add</td>
                <td colspan="2" ><a href="logout"/>Logout</td>
            </tr>      
        </table>
    </body>
</html>
