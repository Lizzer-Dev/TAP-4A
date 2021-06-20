using System;
using System.Collections.Generic;
using System.Text;

namespace SQLApp.Models
{
    public class Estado
    {
        private int id;
        private string name;
        private double surface;

        public int Id
        {
            get { return id; }
            set { id = value; }        
        }

        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        public double Surface
        {
            get { return surface; }
            set { surface = value; }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
