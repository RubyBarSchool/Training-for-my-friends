/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package entity;

public class Student {
    private int id;
    private String name;
    private int age;
    private int phone;
    private boolean gender;

    public Student() {
    }

    public Student(int id, String name, int age, int phone, boolean gender) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.phone = phone;
        this.gender = gender;
    }

    
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public int getPhone() {
        return phone;
    }

    public void setPhone(int phone) {
        this.phone = phone;
    }

    public boolean isGender() {
        return gender;
    }

    public void setGender(boolean gender) {
        this.gender = gender;
    }
    
    
    
    
}
