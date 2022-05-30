/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.util.Vector;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import view.View;

/**
 *
 * @author DELLM4700
 */
public class Controller {

    View view;
    Integer row;
    int place = -1;

    public Controller() {
        view = new View();
        //insertData();
        row = view.getjTable1().getRowCount();
        System.out.println(row);
        view.setVisible(true);
        view.setResizable(false);
        if (row != 0) {
            action();
        } else {
            JOptionPane.showMessageDialog(view, "Please insert Data");
            System.exit(0);
        }

    }

    public void insertData() {
        // insert data cho jtable chungs ta sex dungf setdefualmoder
        // nhanaj 2 vector laf vector data va vec tor cot

        // trong tư duy là mk chuẩn bị tạo ra một vector tên cột
        // tạo vector tên cột
        Vector vtHeard = new Vector();
        vtHeard.add("StockID");
        vtHeard.add("StockName");
        vtHeard.add("Address");
        vtHeard.add("DateAvailable");
        vtHeard.add("Note");
        // trong tư duy là mk chuẩn bị tạo ra một vector data
        Vector vcData = new Vector();
        Vector vc1 = new Vector();
        vc1.add("1");
        vc1.add("Stock one");
        vc1.add("No1-Washington street");
        vc1.add("11/05/2010");
        vc1.add("");
        vcData.add(vc1);
        Vector vc2 = new Vector();
        vc2.add("2");
        vc2.add("Stock two");
        vc2.add("372 Cave town - 001 Banks");
        vc2.add("09/07/2011");
        vc2.add("");
        vcData.add(vc2);
        Vector vc3 = new Vector();
        vc3.add("3");
        vc3.add("Stock three");
        vc3.add("Nary angel-890 Number one");
        vc3.add("13/05/2015");
        vc3.add("");
        vcData.add(vc3);
        Vector vc4 = new Vector();
        vc4.add("4");
        vc4.add("Stock for");
        vc4.add("Twin tower - 01 Main street");
        vc4.add("04/07/2015");
        vc4.add("");
        vcData.add(vc4);
        Vector vc5 = new Vector();
        vc5.add("5");
        vc5.add("Stock five");
        vc5.add("Victory anniversary district");
        vc5.add("04/12/2014");
        vc5.add("");
        vcData.add(vc5);
        // trong tư duy là mk chuẩn bị tạo ra một vector data
        view.getjTable1().setModel(new DefaultTableModel(vcData, vtHeard));
    }

    public void moveFirst() {
        //Show first row of prompt table as selected
        this.place = 0;
        view.getjTable1().setRowSelectionInterval(this.place, this.place);
    }

    public void moveLast() {
        //Show last row of prompt table as selected   
        this.place = row - 1;
        view.getjTable1().setRowSelectionInterval(this.place, this.place);

    }

    public void moveNext() {
        //If it's the last row, it will move to the top
        if (this.place == (row - 1)) {
            moveFirst();
        } else {
            //Show next line if left
            this.place++;
            view.getjTable1().setRowSelectionInterval(this.place, this.place);
        }
    }

    public void movePrevious() {
        //If it's the first row, it will move to the top
        // ngay lúc đầu con trỏ của mk m=no ko nằm trong bẳng và nó là -1 thì ấn ngược lại thì nó cũng phải owr cuối cùng 
        if (this.place <= 0) {
            moveLast();
        } else {
            //Show the front line  
            this.place--;
            view.getjTable1().setRowSelectionInterval(this.place, this.place);
        }
    }

    //Event
    public void action() {
        view.getBtnFirst().addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                moveFirst();
            }
        });
        view.getBtnLast().addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                moveLast();
            }
        });
        view.getBtnNext().addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                moveNext();
            }
        });
        view.getBtnPrevious().addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                movePrevious();
            }
        });
    }
}
