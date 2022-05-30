using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demowinform
{
    public class Room
    {
        public int ID { get; set; }
        public string Name1 { get; set; }
        public Room()
        {

        }
        public Room(int id)
        {
            this.ID = id;

        }
        public override string ToString()
        {
            return "ID: " + this.ID + ", Name: " + this.Name1;
        }
        public override bool Equals(object obj)
        {
            if(obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Room r = (Room) obj;
            return r.ID == this.ID;
        }
    }
}
