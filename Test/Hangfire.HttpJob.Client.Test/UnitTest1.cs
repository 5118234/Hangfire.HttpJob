using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hangfire.HttpJob.Client.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var serverUrl = "http://localhost:5000/job";
            var result = HangfireJobClient.AddBackgroundJob(serverUrl, new BackgroundJob
            {
                JobName = "����api",
                Method = "Get",
                Url = "http://localhost:5000/testaaa",
                Mail = new List<string> {"1877682825@qq.com"},
                SendSucMail = true,
                DelayFromMinutes = 1
            }, new HangfireServerPostOption
            {
                BasicUserName = "admin",
                BasicPassword = "test"
            });
            Assert.IsTrue(result.IsSuccess);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var serverUrl = "http://localhost:5000/job";
            var result = HangfireJobClient.AddRecurringJob(serverUrl, new RecurringJob()
            {
                JobName = "����5��40ִ��",
                Method = "Post",
                Data = new {name = "aaa",age = 10},
                Url = "http://localhost:5000/testpost",
                Mail = new List<string> { "1877682825@qq.com" },
                SendSucMail = true,
                Cron = "40 17 * * *"
            }, new HangfireServerPostOption
            {
                BasicUserName = "admin",
                BasicPassword = "test"
            });
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
