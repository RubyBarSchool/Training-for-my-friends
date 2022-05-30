/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dal;

import entity.Student;
import java.util.ArrayList;
import java.util.Random;

/**
 *
 * @author lenovo
 */
public class StudentDAO {
    //cruds 1 bject create read update delete search
    
    public ArrayList<Student> getAll(int number){
        ArrayList<Student> arr = new ArrayList<>();
        //c1: hoa văn mĩ lệ có nghĩa là dùng hàm random
        //c2: fix cứng
        Random rd = new Random();
        // 1 student thì nó gồm có id int, name string ,tuoi int, phone int,gender boolenrt 
        for(int i =0;i<number;i++){
            Student st = new Student();
            st.setId(i+1);
            // assci cas chuwx cais nhor nhowr nawmf trong khoangr 97 - 122
            String name = "";
            for(int k = 0 ;k<5;k++){
                int nameNumber = rd.nextInt(25) + 97;
                name+= (char) nameNumber;
            }
            st.setName(name);
            st.setAge(rd.nextInt(10)+20);
            st.setPhone(rd.nextInt(10)+1);
            st.setGender(rd.nextBoolean());
            arr.add(st);
        }
        return arr;
    }
    
}
