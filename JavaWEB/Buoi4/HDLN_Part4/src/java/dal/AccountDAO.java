/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dal;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.Account;

/**
 *
 * @author Duc Anh
 */
public class AccountDAO extends BaseDAO {

    public boolean checkAccount(String username, String password) {

        String sql = "select * from accounts where username = ? and password = ?";
        try {
            PreparedStatement pre = conn.prepareStatement(sql);
            pre.setString(1, username);
            pre.setString(2, password);
            ResultSet rs = pre.executeQuery();
            if (rs.next()) {
                return true;
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
        return false;
    }
    
        public boolean checkAccountExit(String username) {

        String sql = "select * from accounts where username = ?";
        try {
            PreparedStatement pre = conn.prepareStatement(sql);
            pre.setString(1, username);
            ResultSet rs = pre.executeQuery();
            if (rs.next()) {
                return true;
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
        return false;
    }
    

    public Account getByUsername(String username) {
        Account acc = new Account();
        String sql = "select * from accounts where username = ? ";
        try {
            PreparedStatement pre = conn.prepareStatement(sql);
            pre.setString(1, username);
            ResultSet rs = pre.executeQuery();
            while (rs.next()) {
                acc.setUsername(rs.getString("username"));
                acc.setPassword(rs.getString("password"));
                break;
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
        }

        return acc;
    }

    public ArrayList<Account> getAllAccount() {
        ArrayList<Account> accounts = new ArrayList<>();
        String sql = "SELECT * FROM dbo.accounts";
        try {
            PreparedStatement pre = conn.prepareStatement(sql);
            ResultSet rs = pre.executeQuery();
            while (rs.next()) {
                Account account = new Account();
                account.setUsername(rs.getString(1));
                account.setPassword(rs.getString(2));
                accounts.add(account);
            }

        } catch (SQLException ex) {
            ex.printStackTrace();
        }
        return accounts;
    }

    public void insertAccount(Account entity) {
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
            PreparedStatement pre = conn.prepareStatement(sql);
            pre.setString(1, entity.getUsername());
            pre.setString(2, entity.getPassword());
            pre.executeUpdate();
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
    }

    public void updateAccount(Account entity) {
        String sql = "update dbo.accounts set password= ?"
                + " where username = ?";
        try {
            PreparedStatement pre = conn.prepareStatement(sql);
            pre.setString(1, entity.getPassword());
            pre.setString(2, entity.getUsername());
            pre.executeUpdate();
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
    }
    
        public void updateAccountByPass(String password) {
        String sql = "update dbo.accounts set password= ? ";
                
        try {
            PreparedStatement pre = conn.prepareStatement(sql);
            pre.setString(1, password);
            pre.executeUpdate();
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
    }
    

    public void deleteByUsername(String username) {
        String sql = " DELETE FROM dbo.accounts WHERE username = ? ";
        try {
            PreparedStatement pstm = conn.prepareStatement(sql);
            pstm.setString(1, username);
            pstm.executeUpdate();
        } catch (SQLException ex) {
            Logger.getLogger(AccountDAO.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
