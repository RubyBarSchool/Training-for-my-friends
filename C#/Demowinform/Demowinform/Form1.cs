using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demowinform
{
    public partial class Form1 : Form
    {
        string msv = "HE130302";
        string name = "Tran Vu Truong";
        public Form1()
        {
            InitializeComponent();
            this.txt1.Text = this.msv;
            this.txt2.Text = this.name;
            cbRoom.DataSource = this.CreateRoom();
            cbRoom.DisplayMember = "Name1";
            cbRoom.ValueMember = "ID";
            //cbRoom.SelectedItem = "Room2";
            // tìm ra thang can select
            // cbRoom.Text = "Room10";

            //this.cbRoom.SelectedItem = new Room(3);
            //this.cbRoom.SelectedIndex = 3; 
            //this.cbRoom.SelectedValue = 3;

        }

        public List<Room> CreateRoom()
        {
            List<Room> arr = new List<Room>();
            for(int i = 0; i < 20; i += 2)
            {
                Room r = new Room();
                r.ID = i;
                r.Name1 = "Room" + i;
                arr.Add(r);
            }
            return arr;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //cbRoom.SelectedItem = "Room1"  
            string x = "";
            if (this.rdMale.Checked)
            {
                x+= "Male duoc check \n";
            }
            if (this.rdfEMALE.Checked)
            {
                x += "Female duoc check \n";
            }
            if (this.RDbEdE.Checked)
            {
                x += "Be De duoc check \n";
            }
            MessageBox.Show(x);
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
