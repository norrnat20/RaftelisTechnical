/* Natalie Norris
Created: 3/26/2024 - Natalie Norris
Modified: 3/30/2024 - Natalie Norris
*/

using System;
using System.IO;

namespace RaftelisTechnical
{
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

        public Parcel(string[] input) {
            // tow constructors ? for list and individual args form
            pin = input[0];
            address = input[1]; // full address
            string[] temp = address.Split(' ', 2);
            addressnum = temp[0];
            addressstreet = temp[1];

            owner = input[2]; // full name
            string[] temptwo = owner.Split(", ", 2);
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
        }

        public string getPin() {
            return pin;
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
        public string getMarketValue() {
            return marketvalue;
        }
        public string getSaleDate() {
            return saledate;
        }
        public string getSalePrice() {
            return saleprice;
        }
        public string getLink() {
            return link;
        }
    
        public override string ToString() {
            return (pin + "|" + address + "|" + owner + "|" + marketvalue + "|" + saledate + "|" + saleprice + "|" + link);
        }
    }

    class ParcelParser {
        // public static Parcel[] parcels;
        public static void Test() {
            Console.WriteLine("ParcelParser.Test!");
            string filey = "Parcels.txt";
            string[] lines = File.ReadAllLines(filey);
            string[] tokens = lines[0].Split("|");
            foreach (string type in tokens)
                Console.WriteLine(type);
        }

        public static Parcel[] Parser() {
            Console.WriteLine("ParcelParser.Parser()");
            // Read Parcels from file
            string filey = "Parcels.txt";
            string[] lines = File.ReadAllLines(filey);

            Parcel[] parcels = new Parcel[lines.Length-1];
            for (int i = 1; i < lines.Length-1; i++) {
            // for (int i = 1; i < 10; i++) {
                string[] tokens = lines[i].Split("|");
                parcels[i] = new Parcel(tokens);
            }
            return parcels;
        }
    }
}


