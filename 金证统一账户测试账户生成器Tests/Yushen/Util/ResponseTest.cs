﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yushen.WebService.KessClient;

namespace 金证统一账户测试账户生成器Tests.Yushen.Util
{
    /// <summary>
    /// ResponseTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ResponseTest
    {
        public ResponseTest()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CreateTest()
        {
            //
            // TODO:  在此处添加测试逻辑
            //
            string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><response><result><flag>0</flag><prompt>L1100123:板块[00]股东账号[0027969684]已签署过[1e] 存托凭证&amp;创新企业股票权限 协议</prompt><length>0</length></result><record></record></response>";
            Response response = new Response(xml);
        }
    }
}
