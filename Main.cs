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
    class RaftelisTechnical {
        const int DEFAULT = 0;
        const int CONSOLE = 1;
        const int FRONTEND = 2;

        static void Main(string[] args) {
            // check for command line arguments, set mode accordingly
            int mode = DEFAULT;
            if (args.Length != 0) {
                if (args[0] == "c" || args[0] == "C") {
                    mode = CONSOLE;
                } else if (args[0] == "f" || args[0] == "F") {
                    mode = FRONTEND;
                }
            }

            // Parse File into nice data
            Parcel[] parcels = ParcelParser.Parser();

            // Sort data by street name / number
            Parcel[] sortedAdd = new Parcel[parcels.Length];
            ParcelSorter.SortByAddress(parcels);
            parcels.CopyTo(sortedAdd, 0);
            
            // Sort data by first name
            Parcel[] sortedName = new Parcel[parcels.Length];
            ParcelSorter.SortByName(parcels);
            parcels.CopyTo(sortedName, 0);
            
            switch (mode) {
                case DEFAULT:
                    // Default Mode
                    Console.WriteLine("Printing Parcels sorted by Address:");
                    ParcelPrinter.PrintAllParcels(sortedAdd);
                    Console.WriteLine("\n\nPrinting Parcels sorted by First Name:");
                    ParcelPrinter.PrintAllParcels(sortedName);
                    break;
                case CONSOLE:
                    // Console Mode
                    Console.WriteLine("Printing Parcels sorted by Address:");
                    ParcelPrinter.PrintAllParcels(sortedAdd);
                    Console.WriteLine("\n\nPrinting Parcels sorted by First Name:");
                    ParcelPrinter.PrintAllParcels(sortedName);
                    break;
                case FRONTEND:
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