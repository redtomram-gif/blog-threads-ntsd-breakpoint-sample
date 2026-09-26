using System;

using System.Threading;



public class sample

{

    public void ThreadMethod()

    {

        while(true)

        {

            Console.WriteLine("{0}", Thread.CurrentThread.Name);

            Thread.Sleep(600);

        }

    }

    static void Main()

    {

        sample s = new sample();

        Thread t1 = new Thread(s.ThreadMethod);

        Thread t2 = new Thread(s.ThreadMethod);

        t1.Name = "First Thread";

        t2.Name = "Second Thread";

        t1.Start();

        t2.Start();

        Console.WriteLine("Enter any string to stop execution:");

        String line = Console.ReadLine();

        t1.Abort();

        t2.Abort();

    }

}
