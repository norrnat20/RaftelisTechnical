/* Parcel.cs
Created: 3/31/2024 - Natalie Norris
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

        /// <summary>
        /// Creates a Parcel object
        /// </summary>
        /// <param name="input"></param>
        public Parcel(string[] input) {
            pin = input[0];
            address = input[1]; // full address
            // Split the address into the house number and street name 
            string[] addressSplit = address.Split(' ', 2);
            addressnum = addressSplit[0];
            addressstreet = addressSplit[1];

            owner = input[2]; // full name
            // Split the fullname into first and last to sort later
            string[] nameParts = owner.Split(", ", 2);
            // If there is no first/last name (ex: Company LLC), set first/last to the same thing
            if (nameParts.Length != 1) {
                lastname = nameParts[0];
                firstname = nameParts[1];
            } else {
                lastname = nameParts[0];
                firstname = nameParts[0];
            }
            
            marketvalue = input[3];
            saledate = input[4];
            saleprice = input[5];
            link = input[6];

            // Construct Google maps link
            // Split address into all sections separated by spaces to piece together in link
            string[] addressParts = address.Split(' ');
            maps = "https://www.google.com/maps/place/";
            for (int i = 0; i < addressParts.Length; i++) {
                maps += addressParts[i] + "+";
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
}