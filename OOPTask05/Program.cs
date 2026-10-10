using OOPTask05;
using OOPTask05.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPTask05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            ///  Q1  Object Copying
            ///  a) What happens when you assign one object variable to another object variable? 
            // When you assign one object variable to another object variable don't create a new object
            // in the Heap but Copies the memory address / reference from Object 01

            /// b) Does assigning one object to another create a new object? Explain.
            // No, it does not create a new object . 
            // Assigning one object variable to another simply copies the memory address (reference) from the original object to the new variable.

            /// c) What is the difference between copying an object and copying its reference?
            /// Copying a Reference obj2 = obj1 : Does NOT create a new object in memory (Heap) , copies the memory address into a new reference variable .
            /// Copying an Object : create a new object in memory (Heap) , allocates new memory space on the Heap and copies the actual values/data of the original object . 

            /// Q2  Shallow Copy vs Deep Copy
            /// a) What is a Shallow Copy?
            /// create a new object and copies all value type fields , for refernce type fields , only the references are copied , both objects point to the same nested objects . 

            ///  b) What is a Deep Copy?
            ///  a deep copy creates a new object and copies all nested objects 
            ///  the original and the copy are completly independent .
            ///  
            ///  c) What happens to reference-type members when a Shallow Copy is created?
            ///  Shallow Copy creates a new primary object on the Heap, but shares its reference-type members by copying their memory addresses. Modifying a nested object affects both the original and the copy.
            ///  
            ///  d) What happens to reference-type members when a Deep Copy is created?
            /// Deep Copy creates a new primary object on the Heap AND recursively creates new instances for all its reference - type members.Because new memory is allocated for the nested objects, modifying a nested object in the copy will NOT affect the original object

            ///  e) Give one situation where Deep Copy would be safer than Shallow Copy.
            ///  In a Shallow Copy, both objects share internal reference-type members. 
            ///  Modifying a nested object in the copy mutates the original object, causing unexpected side effects.
            ///  Deep Copy is safer because it creates fully independent nested objects, guaranteeing that modifications to the copy will never affect the original data.


            #endregion

            #region In Main 
            ///1  Object Copying
            DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir St.", 10);
            Shipment shipment1 = new Shipment("SH-101", "Electronics", 2.5m, 100.0m, address1);

            Console.WriteLine("1.Demonstrating Reference Assignment\n");

            Console.WriteLine($" before modifying : {shipment1.Description}");

            Shipment shipment2 = shipment1;

            shipment2.Description = "Laptops";

            Console.WriteLine($"shipment1 after modifying : {shipment1.Description}");
            Console.WriteLine($"shipment2 after modifying : {shipment2.Description}");

            //2  Shallow Copy
            Console.WriteLine("\n2.Demonstrating ShallowCopy()\n");

            Shipment shipment3 = shipment1.ShallowCopy();
            shipment3.Description = "Smartphones";

            Console.WriteLine($"shipment1 after modifying : {shipment1.Description}");
            Console.WriteLine($"shipment3 after modifying : {shipment3.Description}");


            shipment3.Destination.City = "Alexandria";
            Console.WriteLine( $"\nshipment1 after modifying : {shipment1.Destination.City}");
            Console.WriteLine( $"shipment2 after modifying : {shipment2.Destination.City}");
            Console.WriteLine( $"shipment3 after modifying : {shipment3.Destination.City}");

            #endregion

            Console.ReadLine();
        }
    }
}
