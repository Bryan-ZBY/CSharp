namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_01
{
    using System;
    using System.Threading;

    public class RunningASeparateThread
    {
        public const int Repetitions = 1000;

        public static void Main()
        {
            // 将方法转换成委托类型
            ThreadStart threadStart = DoWork;
            Thread thread = new Thread(threadStart);

            // 启动线程
            thread.Start();

            // 主线程
            for(int count = 0; count < Repetitions; count++)
            {
                Console.Write('-');
            }
            thread.Join();
        }

        public static void DoWork()
        {
            for(int count = 0; count < Repetitions; count++)
            {
                Console.Write('+');
            }
        }
    }
}