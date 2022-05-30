/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.awt.AWTEventMulticaster;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Vector;
import javax.swing.table.DefaultTableModel;
import view.View;

/**
 *
 * @author lenovo
 */
public class ViewController {

    View view;

    public ViewController() {
        // trong tư duy là mk chuẩn bị tạo ra một vector data
        view = new View();
        // trong tư duy là mk chuẩn bị tạo ra một vector data
        insertData();
        view.setVisible(true);
        // trong tư duy là mk chuẩn bị tạo ra một vector data
        view.setResizable(false);
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
        view.getTbOutPut().setModel(new DefaultTableModel(vcData, vtHeard));
    }
// trong tư duy là mk chuẩn bị tạo ra một vector data

    public void action() {
        view.getBtFirst().addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                view.getTbOutPut().setRowSelectionInterval(0, 0);
            }
        });
        view.getBtLast().addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                view.getTbOutPut().setRowSelectionInterval(view.getTbOutPut().getRowCount() - 1,
                        view.getTbOutPut().getRowCount() - 1);
            }
        });
        view.getBtNext().addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // nó có ở cuối cùng hay k
                // nếu nó ở cuối cùng thì ae phải cho nó lên đầu tiên

                int place = view.getTbOutPut().getSelectedRow();
                // check xem nos cos phair owr dongf cuoois hay k
                if (place == view.getTbOutPut().getRowCount() - 1) {
                    view.getTbOutPut().setRowSelectionInterval(0, 0);
                } else {
                    view.getTbOutPut().setRowSelectionInterval(place + 1, place + 1);
                }

            }
        });
        view.getBtprevious().addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int place = view.getTbOutPut().getSelectedRow();
                // check xem nos cos phair owr dongf cuoois hay 
                
                if (place == 0) {
                    view.getTbOutPut().setRowSelectionInterval(0, 0);
                } else {
                    view.getTbOutPut().setRowSelectionInterval(view.getTbOutPut().getRowCount() - 1,
                            view.getTbOutPut().getRowCount() - 1);
                }
            }
        });
    }
}
