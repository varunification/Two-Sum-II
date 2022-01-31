using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() {
        
        Dictionary<int,int> rec = new Dictionary<int,int>();
        
        int[] arr ={1,3,4,95,0,10,90};
        int target=9;
        bool flag=false;
        int front_ptr=0;
        int count=0;
        int last_ptr=arr.Length-1;    
        while(!flag && count<arr.Length-1){
            
            
            if(arr[front_ptr]+arr[last_ptr]>target){
                last_ptr--;
                count++;
            }
            else if(arr[front_ptr]+arr[last_ptr]<target){
                front_ptr++;
                count++;
            }
            else if(arr[front_ptr]+arr[last_ptr]==target){
                rec.Add(++front_ptr,++last_ptr);
                flag=true;
            }
            else if(front_ptr==last_ptr){
                count=arr.Length;
            }
            
            
        }
        
        
        if(flag){
        var keys=rec.Keys.ToList();
        
        foreach(var key in keys)
        Console.WriteLine(key +" "+rec[key]);
        
        }        
        
        Console.WriteLine("Not Possible");
        
        
        
        
    }
}