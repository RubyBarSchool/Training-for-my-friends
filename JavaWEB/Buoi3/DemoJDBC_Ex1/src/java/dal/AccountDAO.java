/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dal;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.Account;

/**
 *
 * @author lenovo
 */
public class AccountDAO extends DBconnection {

    public boolean checkLogin(Account entity) {
        // truyeenf vaof rntity neeus toonf taij thif select se cos data torng bang
        String sql = " SELECT * FROM dbo.accounts WHERE username = ? "
                + " AND password = ? ";
        try {
            PreparedStatement pstm = connection.prepareStatement(sql);
            pstm.setString(1, entity.getUsername());
            pstm.setString(2, entity.getPassword());
            // truyền vào sql
            ResultSet rs = pstm.executeQuery();
            // nếu rs có giá trị thì sao? đúng
            // nếu rs ko có giá trị thì ko tồn tại acc
            if (rs.next()) {
                return true;
            }

        } catch (SQLException ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        return false;
    }
    
    public ArrayList<Account> getAll() {
        // truyeenf vaof rntity neeus toonf taij thif select se cos data torng bang
        ArrayList<Account> arr = new ArrayList<>();
        String sql = " SELECT * FROM dbo.accounts ";
        try {
            PreparedStatement pstm = connection.prepareStatement(sql);
            ResultSet rs = pstm.executeQuery();

            while(rs.next()) {
                Account acc = new Account();
                String username = rs.getString("username");
                String password = rs.getString("password");
                acc.setUsername(username);
                acc.setPassword(password);
                arr.add(acc);
            }

        } catch (SQLException ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        return arr;
    }

    public boolean checkExitAccount(Account entity) {
        // truyeenf vaof rntity neeus toonf taij thif select se cos data torng bang
        String sql = " SELECT * FROM dbo.accounts WHERE username = ? ";

        try {
            PreparedStatement pstm = connection.prepareStatement(sql);
            pstm.setString(1, entity.getUsername());

            // truyền vào sql
            ResultSet rs = pstm.executeQuery();
            // nếu rs có giá trị thì sao? đúng
            // nếu rs ko có giá trị thì ko tồn tại acc
            if (rs.next()) {
                return false;
            }

        } catch (SQLException ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        return true;
    }

    public void inserAccount(Account entity) {
        String sql = "INSERT INTO dbo.accounts\n"
                + "(\n"
                + "    username,\n"
                + "    password\n"
                + ")\n"
                + "VALUES\n"
                + "(   ?, -- username - varchar(50)\n"
                + "    ?  -- password - varchar(50)\n"
                + "    )";
        try {
            PreparedStatement pstm = connection.prepareStatement(sql);
            pstm.setString(1, entity.getUsername());
            pstm.setString(2, entity.getPassword());
            pstm.executeUpdate();

        } catch (SQLException ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
