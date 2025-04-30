using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._04._2025
{

    class RangeOfArray
    {
        private int[] array;
        private int startIndex;

        public RangeOfArray(int start, int end)
        {
            if (end < start)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            startIndex = start;
            array = new int[end - start + 1];
        }

        public int Get(int index)
        {
            if (index < startIndex || index >= startIndex + array.Length)
            {
                Console.WriteLine("Index out of range");
                return 0;
            }

            return array[index - startIndex];
        }

        public void Set(int index, int value)
        {
            if (index < startIndex || index >= startIndex + array.Length)
            {
                Console.WriteLine("Index out of range");
                return;
            }

            array[index - startIndex] = value;
        }
    }


    interface IStorage
    {
        string Name { get; set; }
        string Model { get; set; }

        double GetMemory();
        double GetFreeMemory();
        void CopyData(double data);
        string GetInfo();
    }

    class Flash : IStorage
    {
        public string Name { get; set; }
        public string Model { get; set; }

        private double speed;
        private double capacity;
        private double used = 0;

        public Flash(string name, string model, double speed, double capacity)
        {
            Name = name;
            Model = model;
            this.speed = speed;
            this.capacity = capacity;
        }

        public double GetMemory() => capacity;
        public double GetFreeMemory() => capacity - used;

        public void CopyData(double data)
        {
            if (GetFreeMemory() >= data)
                used += data;
        }

        public string GetInfo()
        {
            return $"Flash: {Name} {Model}, {capacity} GB, speed: {speed} MB/s";
        }
    }

    class DVD : IStorage
    {
        public string Name { get; set; }
        public string Model { get; set; }

        private double speed;
        private bool doubleSided;
        private double capacity;
        private double used = 0;

        public DVD(string name, string model, double speed, bool doubleSided)
        {
            Name = name;
            Model = model;
            this.speed = speed;
            this.doubleSided = doubleSided;
            this.capacity = doubleSided ? 9.0 : 4.7;
        }

        public double GetMemory() => capacity;
        public double GetFreeMemory() => capacity - used;

        public void CopyData(double data)
        {
            if (GetFreeMemory() >= data)
                used += data;
        }

        public string GetInfo()
        {
            string side = doubleSided ? "double-sided" : "single-sided";
            return $"DVD: {Name} {Model}, {side}, {capacity} GB, speed: {speed} MB/s";
        }
    }

    class HDD : IStorage
    {
        public string Name { get; set; }
        public string Model { get; set; }

        private double speed;
        private int partitions;
        private double sizePerPartition;
        private double used = 0;

        public HDD(string name, string model, double speed, int partitions, double sizePerPartition)
        {
            Name = name;
            Model = model;
            this.speed = speed;
            this.partitions = partitions;
            this.sizePerPartition = sizePerPartition;
        }

        public double GetMemory() => partitions * sizePerPartition;
        public double GetFreeMemory() => GetMemory() - used;

        public void CopyData(double data)
        {
            if (GetFreeMemory() >= data)
                used += data;
        }

        public string GetInfo()
        {
            return $"HDD: {Name} {Model}, {partitions} x {sizePerPartition} GB, speed: {speed} MB/s";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            RangeOfArray myArray = new RangeOfArray(3, 7);

            myArray.Set(3, 10);
            myArray.Set(4, 20);
            myArray.Set(5, 30);

            Console.WriteLine(myArray.Get(3));
            Console.WriteLine(myArray.Get(4));
            Console.WriteLine(myArray.Get(5));

            // task 2
            List<IStorage> devices = new List<IStorage>
        {
            new Flash("SanDisk", "Ultra", 150, 64),
            new DVD("Verbatim", "DVD-R", 10, false),
            new HDD("Seagate", "Backup Plus", 100, 2, 500)
        };

            Console.WriteLine("=== Device Info Before Copy ===");
            foreach (var device in devices)
            {
                Console.WriteLine(device.GetInfo());
                Console.WriteLine($"Total: {device.GetMemory()} GB");
                Console.WriteLine($"Free: {device.GetFreeMemory()} GB\n");
            }

            double dataToCopy = 10.0;
            Console.WriteLine($"Copying {dataToCopy} GB to each device...\n");

            foreach (var device in devices)
            {
                if (device.GetFreeMemory() >= dataToCopy)
                {
                    device.CopyData(dataToCopy);
                    Console.WriteLine($"{dataToCopy} GB copied to {device.Name} {device.Model}");
                }
                else
                {
                    Console.WriteLine($"Not enough space on {device.Name} {device.Model}");
                }
            }

            Console.WriteLine("\n=== Device Info After Copy ===");
            foreach (var device in devices)
            {
                Console.WriteLine(device.GetInfo());
                Console.WriteLine($"Total: {device.GetMemory()} GB");
                Console.WriteLine($"Free: {device.GetFreeMemory()} GB\n");
            }
        }
    }
}