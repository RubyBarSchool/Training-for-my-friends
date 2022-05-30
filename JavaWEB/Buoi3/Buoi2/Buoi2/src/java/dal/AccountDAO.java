/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dal;

import entity.Account;

/**
 *
 * @author lenovo
 */
public class AccountDAO {
    public boolean  checkLogin(Account entity){
        if(entity.getUsername().equals("admin")&&entity.getPassword().equals("admin")){
            return true;
        }
        return false;
    }
}
