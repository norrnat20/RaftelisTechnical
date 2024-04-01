/* ParcelPrinter.cs
Created: 3/30/2024 - Natalie Norris
Modified: 3/31/2024 - Natalie Norris
*/

using System;
using System.IO;
using static RaftelisTechnical.ParcelParser;
using static RaftelisTechnical.Parcel;


namespace RaftelisTechnical
{
    public class ParcelPrinter {
        public static void PrintParcels(Parcel[] parcels) {
            /* PrintParcels Prints an array of Parcel objects.
            It takes one argument Parcel[] parcels, a list of parcels.
            It has no return value.*/
            for (int i = 0; i < parcels.Length-1; i++) {
                Console.WriteLine(parcels[i]);
            }
        }
    }
}