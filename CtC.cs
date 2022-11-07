using System;
public class Test
{
    protected int fullMarks, minutes;
    public Test(): this(30) { Console.WriteLine("Initial Test");  }
    public Test(int marks,int min):this(min)
    { Console.WriteLine("OOP2 Test");
      fullMarks = marks;
        minutes = min;
    
    }
    public Test(int min)
    {
        Console.WriteLine("OOP1 Test");
        minutes=min;
    }
    public void ShowValue() { Console.WriteLine("OOP2 Test: "+minutes); }
}

public class FinalTerm:Test
{
    public FinalTerm() { Console.WriteLine("No Final"); }
    public FinalTerm(int min):this() { Console.WriteLine("Loop Test"); }
    public FinalTerm(int marks,int min):base(marks,min) { Console.WriteLine("Structure Test"); }
}

public class MidTermTest:FinalTerm
{
    public MidTermTest() : base(){ Console.WriteLine("Function Test"); }
    public MidTermTest(int min):base (50,min)
    { Console.WriteLine("Datatype Test"); }
    public MidTermTest(int marks,int min):base(marks)
    { Console.WriteLine("condition Test"); }
}

class Program
{
    static void Main(string[] args)
    {
        MidTermTest setA = new MidTermTest(100, 120);
        new MidTermTest(100).ShowValue();
    }
}
