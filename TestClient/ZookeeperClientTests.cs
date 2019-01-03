using Rabbit.Zookeeper;
using Rabbit.Zookeeper.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    public class ZookeeperClientTests
    {
        private readonly IZookeeperClient _client;

        public ZookeeperClientTests()
        {
           
            _client = new ZookeeperClient(new ZookeeperClientOptions("127.0.0.1:2181")
            {
                SessionTimeout = TimeSpan.FromSeconds(20),
                OperatingTimeout = TimeSpan.FromSeconds(30)
            });
        }
        public async Task GetChildrenAsyncTest()
        {
            var childrens = await _client.GetChildrenAsync("/");
            //childrens = await _client.GetChildrenAsync("/ApiRouteRoot");
        }


        public async Task ExistsAsyncTest()
        {
            var result = await _client.ExistsAsync("/");
            
        }
    }
}
