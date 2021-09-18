using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public struct MyStruct
    {
        public int MyStructProperty { get; private set; }

        public int MyStructProperty2 { get; private set; }

        public MyStruct(int constract1, int constract2)
        {
            this.MyStructProperty = constract1;

            this.MyStructProperty2 = constract2;
        }
    }

    public class MyClass
    {

        public int MyClassProperty { get; private set; }

        public int MyClassProperty2 { get; private set; }

        public MyClass(int constract1, int constract2)
        {
            this.MyClassProperty = constract1;

            this.MyClassProperty2 = constract2;
        }

        /// <summary>
        /// 表示オブジェクト
        /// </summary>
        public void PrintObject(MyClass myClass, MyStruct myStruct)
        {
            const int MultiNumbeer = 2;

            Console.WriteLine("MyClassProp " + myClass.MyClassProperty * MultiNumbeer + " " + myClass.MyClassProperty2 * MultiNumbeer);

            Console.WriteLine("MyClassProp " + myStruct.MyStructProperty * MultiNumbeer + " " + myStruct.MyStructProperty2 * MultiNumbeer);
        }
    }
    
}
