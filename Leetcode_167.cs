using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() {
        
        Dictionary<int,int> rec = new Dictionary<int,int>();
        int target=9;
        int[] arr ={1,3,4,5,7,10,11};
        
        
        for(int i=0;i<arr.Length;i++){
            for(int j=i+1;j<arr.Length;j++){
                
                if(i==j){
                    continue;
                }
                
                else if(arr[i]+arr[j]<arr[j] && arr[i]+arr[j]<arr[i] ){
                    break;
                }
                
                else if(arr[i]+arr[j]==target){
                    rec.Add(i+1,j+1);
                    break;
                }
                
                
            }
        }
        
        var keys=rec.Keys.ToList();
        
        foreach(var key in keys)
        Console.WriteLine(key+" "+ rec[key]);
        
         
        
        
        
        
    }
}