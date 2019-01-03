using System;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ZookeeperClientTests client = new ZookeeperClientTests();
            client.ExistsAsyncTest().Wait();
            client.GetChildrenAsyncTest().Wait();
            Console.WriteLine("Hello World!");
        }
    }
}
