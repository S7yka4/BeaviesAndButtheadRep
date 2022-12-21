
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructor.Storage.Models
{
    public class Device
    {
        public Guid Id
        { get; set; }

        public string Name
        { get; set; }

        public string Img
        { get; set; }

        public int Count
        { get; set; }

        public double Cost
        { get; set; }

        public int Popularity
        { get; set; }

        public string Type
        { get; set; }

        public Device() { }

        public Device(int i)
        {
            if (i == 0)
                Type = "Case";
            if (i == 1)
                Type = "CPU";
            if (i == 2)
                Type = "Drive";
            if (i == 3)
                Type = "FAN";
            if (i == 4)
                Type = "FSP";
            if (i == 5)
                Type = "GPU";
            if (i == 6)
                Type = "Motherboard";
            if (i == 7)
                Type = "RAM";

        }
        public Device(string type)
        {
            Id = Guid.NewGuid();
            Name = "";
            Img = "";
            Count = 0;
            Cost = 0;
            Popularity = 0;
            Type = type;
        }


        public Device(string name,string img,int count,double cost,string type)
        {
            Id = Guid.NewGuid();
            Img = img;
            Name = name;
            Count = count;
            Cost = cost;
            Popularity = 0;
            Type = type;
        }
    }
}
