/* Natalie Norris
Created: 3/30/2024 - Natalie Norris
Modified: 3/30/2024 - Natalie Norris
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
                // Parcel current = parcels[i];
                Console.WriteLine(parcels[i]);
            }
        }
    }
}

// PIN|ADDRESS|OWNER|MARKET_VALUE|SALE_DATE|SALE_PRICE|LINK
// 6000090000|51 LOST RIVER AIRPORT RUNWAY|CHUNG, SAMUEL & HEIDI|339100.00|8/1/2003|152000.00|http://okanoganwa.taxsifter.com/Search/results.aspx?q=6000090000