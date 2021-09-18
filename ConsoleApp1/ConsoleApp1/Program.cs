using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1, 2);

            MyStruct myStruct = new MyStruct(3, 4);
         
            ///表示メソッドの呼び出し
            myClass.PrintObject(myClass, myStruct);
        }


    }
}
