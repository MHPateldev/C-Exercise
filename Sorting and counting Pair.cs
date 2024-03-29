using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int pair=0,count = 1;
            Array.Sort(ar);
            int pre = ar[0];
            for(int i=1; i< n;i++)
            {
                if(pre == ar[i]){
                    Console.WriteLine(pre+ "here "+i+"= "+ar[i]);
                    count++;
                }
                else if(count>=2){
                    Console.WriteLine(pre+ "here "+i+"= "+ar[i]);
                    pair += count/2;
                    Console.WriteLine(pair);
                    pre = ar[i];
                    count =1;
                }
                else{
                    pre = ar[i];
                    count =1;
                }
                
                if(i == n-1){
                    pair += count/2;
                }
            }
        return pair;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
