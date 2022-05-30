/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dal;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Duc Anh
 */
public class BaseDAO {
    Connection conn;
   
    
    public BaseDAO(String url,String username,String password){
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            try {
                conn = DriverManager.getConnection(url,username,password);
            } catch (SQLException ex) {
                ex.printStackTrace();
            }
        } catch (ClassNotFoundException ex) {
            ex.printStackTrace();
        }
    }
     public BaseDAO() {
        this("jdbc:sqlserver://localhost:1433;databaseName=account", "sa", "123456");
    }
   
}
