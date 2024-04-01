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
        /// <summary>
        /// Prints an array of Parcel objects in a human readable format.
        /// </summary>
        /// <param name="parcels"></param>
        public static void PrintAllParcels(Parcel[] parcels) {
            for (int i = 0; i < parcels.Length; i++) {
                Console.WriteLine(parcels[i]);
            }
        }
    }
}