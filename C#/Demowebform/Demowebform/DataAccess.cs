using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demowebform
{
    public static class DataAccess
    {
        public static List<DiaChi> getAllDiaChi()
        {
            List<DiaChi> list = new List<DiaChi>();
            for (int i = 0; i< 10; i++)
            {
                DiaChi dc = new DiaChi();
                dc.ID = i + 1;
                dc.Name = "Place " + dc.ID;
                list.Add(dc);
            }
            return list;
        }
        public static List<Student> getAllStudent()
        {
            Random rd = new Random();
            List<Student> list = new List<Student>();
            List<DiaChi> listDc = getAllDiaChi();
            for(int i = 0; i < 10; i++)
            {
                Student st = new Student();
                st.ID = i;
                st.Name = "StudentName " + st.ID;
                st.Place = listDc[rd.Next(9)];
                list.Add(st);
            }
            return list;
        }

        public static List<Student> getStudentbyID(int idDc,List<Student> list)
        {
            List<Student> listSt = new List<Student>();
            foreach (Student st in list)
            {
                if(st.Place.ID == idDc)
                {
                    listSt.Add(st);
                }
            }
            return listSt;
        }
    }
}