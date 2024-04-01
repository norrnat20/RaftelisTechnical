/* ParcelParser.cs
Created: 3/26/2024 - Natalie Norris
Modified: 3/31/2024 - Natalie Norris
*/

using System;
using System.IO;

namespace RaftelisTechnical {
    public class Parcel {
        // PIN|ADDRESS|OWNER|MARKET_VALUE|SALE_DATE|SALE_PRICE|LINK
        // 6000090000|51 LOST RIVER AIRPORT RUNWAY|CHUNG, SAMUEL & HEIDI|339100.00|8/1/2003|152000.00|http://okanoganwa.taxsifter.com/Search/results.aspx?q=6000090000
        string pin;
        string address;
        string addressnum;
        string addressstreet;
        string owner;
        string firstname;
        string lastname;
        string marketvalue;
        string saledate;
        string saleprice;
        string link;
        string maps;

        public Parcel(string[] input) {
            /*  Creates a Parcel object.
                Takes in an array of strings.
            */
            pin = input[0];
            address = input[1]; // full address
            string[] temp = address.Split(' ', 2);
            addressnum = temp[0];
            addressstreet = temp[1];

            owner = input[2]; // full name
            string[] temptwo = owner.Split(", ", 2);
            // If there is no first/last name (ex: Company LLC), set first/last to the same thing
            if (temptwo.Length != 1) {
                lastname = temptwo[0];
                firstname = temptwo[1];
            } else {
                lastname = temptwo[0];
                firstname = temptwo[0];
            }
            
            marketvalue = input[3];
            saledate = input[4];
            saleprice = input[5];
            link = input[6];

            // google maps link
            string[] tempthree = address.Split(' ');
            maps = "https://www.google.com/maps/place/";
            for (int i = 0; i < tempthree.Length; i++) {
                maps += tempthree[i] + "+";
            }
            maps += "Mazama+WA+98833";

        }

        public string getAddress() {
            return address;
        }
        public string getAddressNum() {
            return addressnum;
        }
        public string getAddressStreet() {
            return addressstreet;
        }

        public string getOwner() {
            return owner;
        }
        public string getFirstName() {
            return firstname;
        }
        public string getLastName() {
            return lastname;
        }
        public override string ToString() {
            // prints nicely
            return (pin + "|" + address + "|" + owner + "|" + marketvalue + "|" + saledate + "|" + saleprice + "|" + link + "|" + maps);
        }
    }

    class ParcelParser {
        public static Parcel[] Parser() {
            /*  Parses a text file of 'Parcels'
                and returns an array of Parcel objects.
            */
            
            // Read Parcels from file
            string filey = "Parcels.txt";
            string[] lines = File.ReadAllLines(filey);

            // Create the list of Parcel objects
            Parcel[] parcels = new Parcel[lines.Length-2];
            for (int i = 1; i < lines.Length-1; i++) {
                string[] tokens = lines[i].Split("|");
                parcels[i-1] = new Parcel(tokens);
            }
            return parcels;
        }
    }
}


