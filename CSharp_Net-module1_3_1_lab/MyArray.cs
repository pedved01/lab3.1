using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class MyArray
    {
        int[] arr;

        public void Assign(int []arr, int size)
        {
            // 5) add block try (outside of existing block try)
            try
            {
                try
                {
                    Console.WriteLine(this.arr[10001225451215484854]);
                    this.arr = new int[size];

                    // 1) assign some value to cell of array arr, which index is out of range
                    this.arr[this.arr.Length] = 100;

                    for (int i = 0; i < arr.Length; i++)
                        this.arr[i] = arr[i] / arr[i + 1];
                    // 7) use unchecked to assign result of operation 1000000000 * 100 
                    // to last cell of array
                    unchecked
                    {
                        arr[arr.Length - 1] = 1000000000 * 100;
                    }

                    //NullReferenceException

                }
                // 2) catch exception index out of rage
                catch (IndexOutOfRangeException ex)
                {
                    // output message 
                    Console.WriteLine("wrong index");
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    // 4) catch devision by 0 exception
                    //catch
                    Console.WriteLine("u tried divide valoe by 0");
                     Console.WriteLine(ex.Message);
                }
            }

            catch (NullReferenceException ex)
            // 6) add catch block for null reference exception of outside block try  

            {
                Console.WriteLine(ex.Message);
            }

            // change the code to execute this block (any method of any class)
            //catch 
           
        }
    }
}
