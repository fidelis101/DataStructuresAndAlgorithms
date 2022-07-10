using System;

namespace DataStructuresAndAlgorithms{
     public static class MyArrayExtension{
        public static void PrintArray(this Array arr )
        {
            foreach(var a in arr)
                Console.WriteLine(a.ToString());
        }

        public static int MaxArea(this int[] height) 
        {
        //Alternatively
        //Loop through each item in the list
        //For each compare lenght and heigh and get highest area for current height
        //Store highest area temporarily
        //Repeat Line 10, Compare Highest area with previous and update if larger
        
        if(height.Length < 2)
            return 0;
        
        int hArea = 0;
        
        for(int i = 0; i<height.Length;i++)
        {
            int tempArea = 0;
            
            for(int j = height.Length - 1; j>i;j--)
            {
                int currentArea = 0;
                if(height[i] < height[j])
                {
                    currentArea = height[i] * (j-i);
                    j = -1;
                } 
                else{
                    currentArea = height[j] * (j-i);
                }
                
                if(currentArea > tempArea)
                    tempArea = currentArea;
            }
            
            if(tempArea > hArea)
                hArea = tempArea;
        }
        
        return hArea;
    }
    }

}