﻿using System;
using System.Xml;

namespace Yushen.WebService.KessClient
{
    public class Request
    {
        /// <summary>
        /// Webservice操作的名称
        /// </summary>
        public string methonName;

        /// <summary>
        /// 存放XML文件的相对路径
        /// </summary>
        string xmlPath = "Yushen/WebService/KessClient/Xml/";

        XmlDocument xmlDoc = new XmlDocument();

        /// <summary>
        /// 创建Request对象
        /// </summary>
        /// <param name="operatorId">操作员代码</param>
        /// <param name="methonName">Webservice操作的名称</param>
        /// <param name="isIgnoreComments">是否忽略XML文件中的注释，默认忽略</param>
        public Request(string operatorId, string methonName, bool isIgnoreComments = true)
        {
            this.getXmlDocumentFromFile(methonName, isIgnoreComments);

            // 设置操作员代码
            this.setOperator(operatorId);
            this.methonName = methonName;
        }

        /// <summary>
        /// 通过XML字符串创建Request对象
        /// </summary>
        /// <param name="operatorId">操作员代码</param>
        /// <param name="operateName">Webservice操作的名称</param>
        /// <param name="xml">XML字符串</param>
        public Request(string operatorId, string operateName, string xml)
        {
            xmlDoc.LoadXml(xml);

            // 设置操作员代码
            this.setOperator(operatorId);
            this.methonName = operateName;
        }

        /**
         * 根据关键字设置某个值的属性
         * 
         **/
        public void setAttr(string name, string value)
        {
            XmlNode node = xmlDoc.SelectSingleNode("/request/data/" + name);
            if (node == null)
            {
                throw new Exception("找不到属性：" + name);
            }
            node.InnerText = value;
        }

        /// <summary>
        /// 返回XML字符串
        /// </summary>
        public string xml
        {
            get
            {
                return xmlDoc.InnerXml;
            }
        }

        /// <summary>
        /// 设置本次请求的操作员
        /// </summary>
        /// <param name="id"></param>
        internal void setOperator(string id)
        {
            XmlNode node = xmlDoc.SelectSingleNode("/request/auth/OPERATOR");
            if (node == null)
            {
                throw new Exception("找不到属性：/request/auth/OPERATOR");
            }
            node.InnerText = id;
        }

        /// <summary>
        /// 读取用于生成WebService请求的Xml配置文件
        /// </summary>
        /// <param name="methonName">WebService操作方法名称，即不含.xml后缀的XML文件名</param>
        /// <param name="ignoreComments">是否忽略文档里面的注释，默认忽略</param>
        internal void getXmlDocumentFromFile(string methonName = "", bool ignoreComments = true)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = ignoreComments;// 是否忽略文档里面的注释
                xmlPath = xmlPath + methonName + ".xml";
                XmlReader reader = XmlReader.Create(@xmlPath, settings);
                xmlDoc.Load(reader);
                reader.Close();
            }
            catch (Exception)
            {
                throw new NotImplementedException("WebService XML文件加载失败：" + xmlPath);
            }
        }
    }
}
