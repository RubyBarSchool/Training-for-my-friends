/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author lenovo
 */
public class Calculator extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    
    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        request.getRequestDispatcher("index.html").forward(request, response);
        
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
         // đẩy về đây cụm xử lí mà đã xử lí là phauir có dữ liệu
         int number1 = 0;
         int number2 = 0;
         String BaoLoi = "";
         if(request.getParameter("First")!=null){
             if(request.getParameter("First").matches("//d+")){
                 number1 = Integer.valueOf(request.getParameter("First"));
             }else{
                 BaoLoi+=" number 1 Khong dung dinh dang so";
             }
         }             
         else{
             BaoLoi += "Number 1 Chua Nhap";
         }
         if(request.getParameter("Second")!=null){
             if(request.getParameter("Second").matches("//d+")){
                 number2 = Integer.valueOf(request.getParameter("Second"));
             }else{
                 BaoLoi+=" number 2 Khong dung dinh dang so";
             }

             number2 = Integer.valueOf(request.getParameter("Second"));
         }else{
             BaoLoi += "Number 2 Chua Nhap";
         }
         if(BaoLoi.length()!=0){
             response.getWriter().print(BaoLoi);
         }
         
         
         String ouput = "";
         String operator = request.getParameter("operator");
        switch (operator) {
            case "+":
                ouput = number1 + number2 + "";
                if(ouput.endsWith(".0")){
                    ouput = ouput.substring(0, ouput.length()-1);
                }
                response.getWriter().print(ouput);
                break;
            case "-":
                ouput = number1 - number2 + "";
                if(ouput.endsWith(".0")){
                    ouput = ouput.substring(0, ouput.length()-1);
                }
                response.getWriter().print(ouput);
                break;
            case "*":
                ouput = number1 * number2 + "";
                if(ouput.endsWith(".0")){
                    ouput = ouput.substring(0, ouput.length()-1);
                }
                response.getWriter().print(ouput);
                break;
            case "/":
                if(number2==0){
                    response.getWriter().print("Chia Cho 0");
                }
                ouput = number1 / number2 + "";
                if(ouput.endsWith(".0")){
                    ouput = ouput.substring(0, ouput.length()-1);
                }
                response.getWriter().print(ouput);
                break;
        }
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
