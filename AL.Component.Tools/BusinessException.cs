﻿// 源文件头信息：
// <copyright file="BusinessException.cs">
// Copyright(c)2012-2013 GMFCN.All rights reserved.
// CLR版本：4.0.30319.239
// 开发组织：郭明锋@中国
// 公司网站：http://www.gmfcn.net
// 所属工程：AL.Component.Tools
// 最后修改：郭明锋
// 最后修改：2013/05/14 23:04
// </copyright>

using System;
using System.Runtime.Serialization;


namespace AL.Component.Tools
{
    /// <summary>
    ///     数据访问层异常类，用于封装业务逻辑层引发的异常，以供 UI 层抓取
    /// </summary>
    [Serializable]
    public class BusinessException : Exception
    {
        /// <summary>
        ///     实体化一个 AL.Component.Tools.BllException 类的新实例
        /// </summary>
        public BusinessException() { }

        /// <summary>
        ///     使用异常消息实例化一个 AL.Component.Tools.BllException 类的新实例
        /// </summary>
        /// <param name="message">异常消息</param>
        public BusinessException(string message)
            : base(message) { }

        /// <summary>
        ///     使用异常消息与一个内部异常实例化一个 AL.Component.Tools.BllException 类的新实例
        /// </summary>
        /// <param name="message">异常消息</param>
        /// <param name="inner">用于封装在BllException内部的异常实例</param>
        public BusinessException(string message, Exception inner)
            : base(message, inner) { }

        /// <summary>
        ///     使用可序列化数据实例化一个 AL.Component.Tools.BllException 类的新实例
        /// </summary>
        /// <param name="info">保存序列化对象数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected BusinessException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}