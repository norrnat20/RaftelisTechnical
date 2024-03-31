using System;
using System.IO;
// using ParcelParser.cs;
using static RaftelisTechnical.ParcelParser;
using static RaftelisTechnical.Parcel;
using static RaftelisTechnical.ParcelSorter;
using static RaftelisTechnical.ParcelPrinter;

namespace RaftelisTechnical
{
    class Mainy
    {
        static void Main(string[] args)
        {
            int mode = 0;
            if (args.Length != 0) {
                if (args[0] == "c" || args[0] == "C") {
                    mode = 1;
                } else if (args[0] == "f" || args[0] == "F") {
                    mode = 2;
                }
            }
            // Parse File into nice data
            Console.WriteLine("Mode is: " + mode);
            Parcel[] parcels = ParcelParser.Parser();
            // Console.WriteLine(parcels[1]);
            parcels[1].getPin();
            // return;
            // Sort data by street name / number
            Parcel[] sortedAdd = ParcelSorter.SortAddress(parcels);
            // Sort data by first name
            Parcel[] sortedName = ParcelSorter.SortName(parcels);
            
            switch (mode)
            {
                case 0:
                    // Default Mode
                    Console.WriteLine("Printing sorted by Address:");
                    ParcelPrinter.PrintParcels(sortedAdd);
                    Console.WriteLine("\n\nPrinting sorted by Name:");
                    ParcelPrinter.PrintParcels(sortedName);
                    break;
                case 1:
                    // Console Mode
                    Console.WriteLine("Printing sorted by Address:");
                    ParcelPrinter.PrintParcels(sortedAdd);
                    Console.WriteLine("\n\nPrinting sorted by Name:");
                    ParcelPrinter.PrintParcels(sortedName);
                    break;
                case 2:
                    // Front End Mode
                    Console.WriteLine("No front end developed. Please use console mode.");
                    break;
                default:
                    Console.WriteLine("Something went wrong girlie");
                    break;
            }
        }
    }
}

/*
PIN|ADDRESS|OWNER|MARKET_VALUE|SALE_DATE|SALE_PRICE|LINK
6000090000|51 LOST RIVER AIRPORT RUNWAY|CHUNG, SAMUEL & HEIDI|339100.00|8/1/2003|152000.00|http://okanoganwa.taxsifter.com/Search/results.aspx?q=6000090000


[x] Please reply to me to confirm that you received this request and could access the attachment as soon as you can.
[ ] Please create a console or front-end application in the language(s) of your choice to accomplish the request. (Bonus if the code is in C#)
[ ] I’m attaching a delimited text file containing parcel, owner, address, and other data. Please use these records to fulfill the request.
[ ] Please sort these records by street name and then street number. Print the results with all columns included to the console, or visualize them in the front-end app.
[ ] Next, sort these records in a new way, by first name. Print the results with all columns included to the console, or visualize them in the front-end app.
[ ] *For extra credit, please add a column to the results that links to Google Maps with the address highlighted. To help with this, the city is Mazama WA.
[ ] Please upload your project to Github and reply all to this email with a link to the project.
[ ] Please complete this request by 9am PDT on 4/1/24
*/