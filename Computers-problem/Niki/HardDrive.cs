using System;
using System.Collections.Generic;
using System.Linq;

namespace Computers.UI.Console
{

    class HardDrive
    {

        bool isInRaid;

        int hardDrivesInRaid;

       internal HardDrive(){}
        public bool IsMonochrome { get; set; }


        List<HardDrive> hds;
        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            data = new Dictionary<int, string>(capacity);
            hds = new List<HardDrive>();
        }




        int capacity;
        Dictionary<int, string> data;
        internal HardDrive(int capacity, bool isInRaid,int hardDrivesInRaid, List< HardDrive > hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;


            data = new Dictionary<int, string>(capacity);hds = new List<HardDrive>();hds = hardDrives;
        }
        int Capacity{
            get
            {
                if (isInRaid){
                    if (!hds.Any())
                    {
                        return 0;
                    }
                    return hds.First().Capacity;}
                return capacity;
            }
        }void SaveData(int addr,string newData)
        {
            if (isInRaid) foreach (var hardDrive in hds) hardDrive.SaveData(addr, newData); else data[addr] = newData;
        }
        string LoadData(int address)
        {
            if (isInRaid)
            {
                if (!hds.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return hds.First().LoadData(address);
            }
            if (true)
            {
                return data[address];
            }
        }

        public void Draw(string a)
        {
            if (IsMonochrome)
            {
                System.Console.ForegroundColor = ConsoleColor.Gray;
                System.Console.WriteLine(a);
                System.Console.ResetColor();
            }

            else
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(a);
                System.Console.ResetColor();
            }

        }

    }

}
