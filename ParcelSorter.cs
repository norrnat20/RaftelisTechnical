/* ParcelSorter.cs
Created: 3/30/2024 - Natalie Norris
Modified: 3/31/2024 - Natalie Norris
*/

using System;
using System.IO;

namespace RaftelisTechnical
{
    public class ParcelSorter {
        public static Parcel[] SortAddress(Parcel[] parcels) {
            /* Takes an array of Parcel obejcts and sorts them by their addresses, returning an array of Parcel objects.*/
            // sort by address number then street name to list them numerically in order as well.
            sortByAddNum(parcels);
            sortByAddStreet(parcels);
            return parcels;
        }

        public static Parcel[] SortName(Parcel[] parcels) {
            /* Takes an array of Parcel obejcts and sorts them by their owner's first names, returning an array of Parcel objects*/
            sortByFirstName(parcels);
            return parcels;
        }

        public static void sortByFirstName(Parcel[] A) {
            /* Sorts an array of Parcels by First Name of Owner */
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

        public static void sortByAddStreet(Parcel[] A) {
            /* Sorts an array of Parcels by Address Street Name */
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

        public static void sortByAddNum(Parcel[] A) {
            /* Sorts an array of Parcels by Address Number */
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

        public static void swap(Parcel[] a, int i, int j) {
            /* Swaps two elements in an array */
            Parcel tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}