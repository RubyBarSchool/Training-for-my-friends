
<%@page import="entity.Student"%>
<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        
        <%
        ArrayList<Student> arr  = (request.getAttribute("arrStudent")!=null)? (ArrayList<Student>)request.getAttribute("arrStudent"):null;
        %>
    </head>
    <body>
        <form action="create" method="POST">
            Enternumber:<input type="number" name="nStudent">
            <input type="submit" value="Create">
        </form>
        
        
        <table border="1px" >
            <tr>
                <td>ID</td>
                <td>Name</td>
                <td>Age</td>
                <td>Phone</td>
                <td>Gender</td>
            </tr>
            <p><%= (arr!=null)?"There are"+arr.size()+"row student":"ko chua ban ghi nao" %></p>
            <%
                if(arr!=null){
                    
            for(Student a : arr){
            %>
            <tr>
                <td><%= a.getId() %></td>
                <td><%= a.getName()%></td>
                <td><%= a.getAge()%></td>
                <td><%= a.getPhone()%></td>
                <td><%= a.isGender()%></td>
            </tr>
            <%}}%>
        </table>
    </body>
</html>
