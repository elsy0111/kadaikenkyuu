using System;
class Class1
{
    public string print1()
    {
        return "表示1";
    }
}
class Class2 : Class1
{
    public string print2()
    {
        return "表示2";
    }
}
class Test1
{
    static void Main()
    {
        Class2 c2 = new Class2();
        Console.WriteLine(c2.print1());//表示1
        Console.WriteLine(c2.print2());//表示2
    }
}