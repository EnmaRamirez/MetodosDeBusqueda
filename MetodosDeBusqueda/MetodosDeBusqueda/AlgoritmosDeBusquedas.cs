using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeBusqueda
    //1
{
    public class AlgoritmosDeBusquedas
    {
        public static int  BusquedaSecuencial(int[] array, int target)
        {   
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                
                    return i; ;
                
            }
            return -1;

           
        }
        public static int BusquedaBinaria(int[] array, int target) 
        { 
            int left = 0, right = array.Length - 1;
            while(left <= right) 
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid; 
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
                

            }
            return -1;
        }
       
       
        

    }
}
