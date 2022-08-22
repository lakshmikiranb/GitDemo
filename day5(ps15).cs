using System;
using System.Collections.Generic;

class day5
{


    static public void Main()
    {
      
        
            int result = 0;
           
            Boolean status = false;
    
            HashSet<int> data = new HashSet<int>();
          
            for (int i = arr.Length - 1; i > 0; --i)
            {
                if (data.Contains(arr[i]))
                {
                   
                    status = true;
                    result = arr[i];
                }
                else
                {
                   
                    data.Add(arr[i]);
                }
            }
            if (status == true)
            {
               s
                Console.Write(result);
            }
            else
            {
                
                Console.Write(" None \n");
            }
        }
        public static void Main(String[] args)
        {
            Counting task = new Counting();
           
            int[] arr = {1,5,3,4,3,5,6 };
            task.firstRepeating(arr);
        }
    }