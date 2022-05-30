/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JOptionPane;
import view.View;

/**
 *
 * @author lenovo
 */
public class ViewController {

    View view;
    
    
    public ViewController() {
        view = new View();
        action();
        view.setVisible(true);
        view.setResizable(false);
    }
    
    
    public void action(){
        //b1 xacs ddinhj taoj suwj kieen cho thanwgf naof
        view.getBtSubmit().addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String txt = view.getTxtOutPut().getText();
                JOptionPane.showMessageDialog(view, txt);
                }
        });
    }
    
}
