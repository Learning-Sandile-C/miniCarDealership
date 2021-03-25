using System;
using System.Collections.Generic;
using System.Text;

namespace miniCarDealership
{
    class spareManager
    {
        int id;
        string name;

        public spareManager(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
