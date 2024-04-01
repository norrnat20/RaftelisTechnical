/* ParcelParser.cs
Created: 3/26/2024 - Natalie Norris
Modified: 3/31/2024 - Natalie Norris
*/

using System;
using System.IO;
using static RaftelisTechnical.Parcel;

namespace RaftelisTechnical {
    class ParcelParser {
        /// <summary>
        /// Parses a text file of 'Parcels'.
        /// </summary>
        /// <returns></returns>
        public static Parcel[] Parser() {           
            // Read Parcels from file
            string filey = "Parcels.txt";
            string[] lines = File.ReadAllLines(filey);

            // Create the list of Parcel objects
            Parcel[] parcels = new Parcel[lines.Length-1];
            for (int i = 1; i < lines.Length; i++) {
                string[] tokens = lines[i].Split("|");
                parcels[i-1] = new Parcel(tokens);
            }
            return parcels;
        }
    }
}