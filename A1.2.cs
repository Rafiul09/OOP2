using System;
public class Program{

    public void Print(int a, int b, int c = -1, int d = -1)
    {
        int sum = 0;
        if (c == -1 && d == -1)
        {
            sum = a + b;
            Console.WriteLine(sum);
        }
        else if (c == -1)
        {
            sum = a + b + d;
            Console.WriteLine(sum);
        }
        else if (d == -1)
        {
            sum = a + b + c;
            Console.WriteLine(sum);
        }
        else
        {
            sum = a + b + c + d;
            Console.WriteLine(sum);
        }
    }
    public void Print1(int a,int b=-1,int c=-1,int d=-1){
        int sum=0;
        if(b==-1&&d==-1){
            sum=a+c;
            Console.WriteLine(sum);
        }
        else if(b==-1&&c==-1){
            sum=a+d;
            Console.WriteLine(sum);
        }
        else if(c==-1&&d==-1){
            sum=a+b;
            Console.WriteLine(sum);    
        }
        else if(c==-1){
            sum=a+b+d;
            Console.WriteLine(sum);
        }
        else if(d==-1){
            sum=a+b+c;
            Console.WriteLine(sum);
        }
        else if(b==-1){
            sum=a+c+d;
            Console.WriteLine(sum);
        }
        else{
            sum=a+b+c+d;
            Console.WriteLine(sum);
        }
    }
    public static void Main(string[]args){
        Program p=new Program();
        p.Print1(7,c:4,d:5);
        p.Print(7, 4, d: 9);
    }
}
