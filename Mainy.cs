/* Mainy.cs
Created: 3/30/2024 - Natalie Norris
Modified: 3/31/2024 - Natalie Norris
*/

using System;
using System.IO;
using static RaftelisTechnical.ParcelParser;
using static RaftelisTechnical.Parcel;
using static RaftelisTechnical.ParcelSorter;
using static RaftelisTechnical.ParcelPrinter;

namespace RaftelisTechnical {
    class Mainy {
        static void Main(string[] args) {
            // check for command line arguments, set mode accordingly
            int mode = 0;
            if (args.Length != 0) {
                if (args[0] == "c" || args[0] == "C") {
                    mode = 1;
                } else if (args[0] == "f" || args[0] == "F") {
                    mode = 2;
                }
            }

            // Parse File into nice data
            Parcel[] parcels = ParcelParser.Parser();

            // Sort data by street name / number
            Parcel[] sortedAdd = new Parcel[parcels.Length];
            ParcelSorter.SortAddress(parcels);
            parcels.CopyTo(sortedAdd, 0);
            
            // Sort data by first name
            Parcel[] sortedName = new Parcel[parcels.Length];
            sortedName = ParcelSorter.SortName(parcels);
            
            switch (mode) {
                case 0:
                    // Default Mode
                    Console.WriteLine("Printing Parcels sorted by Address:");
                    ParcelPrinter.PrintParcels(sortedAdd);
                    Console.WriteLine("\n\nPrinting Parcels sorted by First Name:");
                    ParcelPrinter.PrintParcels(sortedName);
                    break;
                case 1:
                    // Console Mode
                    Console.WriteLine("Printing Parcels sorted by Address:");
                    ParcelPrinter.PrintParcels(sortedAdd);
                    Console.WriteLine("\n\nPrinting Parcels sorted by First Name:");
                    ParcelPrinter.PrintParcels(sortedName);
                    break;
                case 2:
                    // Front End Mode
                    Console.WriteLine("No front end developed. Please use console mode.");
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
        }
    }
}