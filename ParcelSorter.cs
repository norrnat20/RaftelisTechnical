/* Natalie Norris
Created: 3/30/2024 - Natalie Norris
Modified: 3/30/2024 - Natalie Norris
*/

using System;
using System.IO;


namespace RaftelisTechnical
{
    public class ParcelSorter {
        public static Parcel[] SortAddress(Parcel[] parcels) {
            Console.WriteLine("ParcelSorter.SortAddress()");
            return parcels;
        }

        public static Parcel[] SortName(Parcel[] parcels) {
            Console.WriteLine("ParcelSorter.SortName()");
            return parcels;
        }

        public void insertionSort(Parcel[] A) {
            int i = 1;
            while (i < A.Length){
                int j = i;
                    // while ((j>0) && (A[j-1] > A[j])){ // change this logic
                        // int result = String.Compare(A[j-1], A[j])
                        //swap(A,j,j-1);
                        //j--;
                    //}
                i++;
            }
        }

        public void swap(Parcel[] a, int i, int j) {
            Parcel tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}