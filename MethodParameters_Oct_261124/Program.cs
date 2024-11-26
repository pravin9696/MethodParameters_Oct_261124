using System.Runtime.Intrinsics.Arm;

namespace MethodParameters_Oct_261124
{
    class student
    {
        public int roll { get; set; }
        public string name { get; set; }
        public int totalMarks { get; set; }
        public void setInfo(int r, string nm, int tm)
        {
            roll = r;
            name = nm;
            totalMarks = tm;
        }
        public void showInfo()
        {
            Console.WriteLine($"Roll :{roll} Name :{name} Total Marks :{totalMarks}");
        }
    }

    class temp
    {

        private int x;
        public void setX(int i) {  x = i; }
        public int getX() { return x; }

    }
    class MyClass
    {
        //default parameter example
        public void method4(int x=100)
        {
            Console.WriteLine("in method4 x="+x);
        }
        public void method5(int x=11,int y=4,string gender="Male")
        {
            Console.WriteLine("in method4 x=" + x);
            Console.WriteLine("in method4 y=" + y);
            Console.WriteLine("in gender =" + gender);
        }


        //parameter Array example

        public void method2(int a,int b,int c,int d)
        {

        }
        public void method2(int a, int b, int c)
        {

        }
        public void method3(params int[]x)
        {
            int sum = 0;
            Console.WriteLine("total parameters passed :"+x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
                Console.WriteLine(x[i]);
            }
            Console.WriteLine("sum of parameters :"+sum);
        }

        public void metho1(temp t1)//temp class t1 ref variable
        {
            Console.WriteLine("in method1 x :");
            Console.WriteLine(t1.getX());
            t1.setX(1111);
            Console.WriteLine("in method1 x :");
            Console.WriteLine(t1.getX());
        }
        public void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y=temp;
        }

        public void inParameterMethod(in int x)
        {
            int y;
            y = x;
            Console.WriteLine("y="+y+" x="+x);
            //x = 555; //invalid

        }
        public void OutParameterMethod(out int x)
        {
            x = 12345;
            int y;
            y = x;
            Console.WriteLine("y=" + y + " x=" + x);
            //x = 555; //invalid
            x++;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //temp tobj=new temp();
            //tobj.setX(999);
            //Console.WriteLine("in Main method tobj.x :");
            //Console.WriteLine(tobj.getX());

            //MyClass Mobj = new MyClass();
            //Mobj.metho1(tobj);
            //Console.WriteLine("in Main method tobj.x :");
            //Console.WriteLine(tobj.getX());

            //int a = 100;
            //int b = 200;
            //Console.WriteLine("before swap a:"+a+" b:"+b);

            //Mobj.swap(ref a,ref b);
            //Console.WriteLine("After swap a:" + a + " b:" + b);

            student s1 = new student();
            s1.setInfo(1, "abcd", 100);
            s1.showInfo();
            student s2 = new student();
            s2.setInfo(nm: "anand", tm: 345, r: 2);
            s2.showInfo();

            student s3 = new student();
            s3.setInfo(3, tm: 897, nm:"anand");
            s3.showInfo();
            s3.setInfo(3, "vijay", tm: 333);
            s3.showInfo();


            MyClass mobj2 = new MyClass();
            //int v1 = 111;
            //mobj2.inParameterMethod(in v1);
            //Console.WriteLine("v1=" + v1);
            //v1++;
            //mobj2.inParameterMethod(in v1);
            //Console.WriteLine("v1="+v1);

            //mobj2.OutParameterMethod(out v1);

            //mobj2.method3(111, 222, 333, 444);
            //mobj2.method3(99);
            //mobj2.method3();
            //int[] tt = new int[5];
            //mobj2.method3(tt);

            mobj2.method4(500);
            mobj2.method4();
            mobj2.method5(gender:"Female",y:999);

        }
    }
}
