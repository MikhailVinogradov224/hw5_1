            int[] arr = new int[15];
            int k = 0;
            Random rnd = new Random();
 
            
            for (int i = 0; i < 15; i++)
            {
                arr[i] = rnd.Next(100, 999);
                Console.Write("{0} ", arr[i]);
            }
            
 
            foreach(int element in arr)
            {
                
                if (element % 2 == 0)
                {
                    k++;
                    
                }
            }
          
            Console.WriteLine();
            Console.WriteLine(k);