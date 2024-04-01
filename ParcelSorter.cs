/* ParcelSorter.cs
Created: 3/30/2024 - Natalie Norris
Modified: 3/31/2024 - Natalie Norris
*/

using System;
using System.IO;

namespace RaftelisTechnical
{
    public class ParcelSorter {
        /// <summary>
        /// Takes an array of Parcel obejcts and sorts them by their addresses, returning an array of Parcel objects.
        /// </summary>
        /// <param name="parcels"></param>
        /// <returns></returns>
        public static Parcel[] SortByAddress(Parcel[] parcels) {
            // sort by address number then street name to list them numerically in order as well.
            sortByAddNum(parcels);
            sortByAddStreet(parcels);
            return parcels;
        }

        /// <summary>
        ///  Takes an array of Parcel obejcts and sorts them by their owner's first names, returning an array of Parcel objects
        /// </summary>
        /// <param name="parcels"></param>
        /// <returns></returns>
        public static Parcel[] SortByName(Parcel[] parcels) {
            sortByLastName(parcels);
            sortByFirstName(parcels);
            return parcels;
        }

        /// <summary>
        /// Sorts an array of Parcels by First name of Owner
        /// </summary>
        /// <param name="A"></param>
        public static void sortByFirstName(Parcel[] A) {
            int i = 1;
            while (i < A.Length) {
                int j = i;
                while ((j>0) && (0 < String.Compare(A[j-1].getFirstName(), A[j].getFirstName()))) {
                    swap(A,j,j-1);
                    j--;
                }
                i++;
            }
        }

        /// <summary>
        /// Sorts an array of Parcels by Last name of Owner
        /// </summary>
        /// <param name="A"></param>
        public static void sortByLastName(Parcel[] A) {
            int i = 1;
            while (i < A.Length) {
                int j = i;
                while ((j>0) && (0 < String.Compare(A[j-1].getLastName(), A[j].getLastName()))) {
                    swap(A,j,j-1);
                    j--;
                }
                i++;
            }
        }

        /// <summary>
        /// Sorts an array of Parcels by Address Street Name
        /// </summary>
        /// <param name="A"></param>
        public static void sortByAddStreet(Parcel[] A) {
            int i = 1;
            while (i < A.Length) {
                int j = i;
                while ((j>0) && (0 < String.Compare(A[j-1].getAddressStreet(), A[j].getAddressStreet()))) {
                    swap(A,j,j-1);
                    j--;
                }
                i++;
            }
        }

        /// <summary>
        /// Sorts an array of Parcels by Address Number
        /// </summary>
        /// <param name="A"></param>
        public static void sortByAddNum(Parcel[] A) {
            int i = 1;
            while (i < A.Length) {
                int j = i;
                while ((j>0) && (int.Parse(A[j-1].getAddressNum()) > int.Parse(A[j].getAddressNum()))) {
                    swap(A,j,j-1);
                    j--;
                }
                i++;
            }
        }

        /// <summary>
        /// Swaps two elements in an array.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void swap(Parcel[] a, int i, int j) {
            Parcel tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}