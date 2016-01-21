namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

     public class HardDrive
    {
        private readonly int capacity;
        private readonly Dictionary<int, string> data;

        private readonly List<HardDrive> hardDrives;
        private readonly bool isInRaid;

        private int hardDrivesInRaid;

        internal HardDrive()
        {
        }

        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hardDrives = new List<HardDrive>();
        }

        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDrive> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;

            this.data = new Dictionary<int, string>(capacity);
            this.hardDrives = new List<HardDrive>();
            this.hardDrives = hardDrives;
        }

        public bool IsMonochrome { get; set; }

        private int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.hardDrives.Any())
                    {
                        return 0;
                    }

                    return this.hardDrives.First().Capacity;
                }

                return this.capacity;
            }
        }

        private void SaveData(int addr, string newData)
        {
            if (this.isInRaid)
            {
                foreach (var hardDrive in this.hardDrives)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else
            {
                this.data[addr] = newData;
            }
        }

        private string LoadData(int address)
        {
            if (this.isInRaid)
            {
                if (!this.hardDrives.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hardDrives.First().LoadData(address);
            }

            if (true)
            {
                return this.data[address];
            }
        }
    }
}