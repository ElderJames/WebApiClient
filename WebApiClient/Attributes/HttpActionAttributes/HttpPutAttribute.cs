﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient.Attributes
{
    /// <summary>
    /// 表示Put请求
    /// 不可继承
    /// </summary>
    public sealed class HttpPutAttribute : HttpMethodAttribute
    {
        /// <summary>
        /// Put请求
        /// </summary>
        public HttpPutAttribute()
            : base(HttpMethod.Put)
        {
        }

        /// <summary>
        /// Put请求
        /// </summary>
        /// <param name="path">请求绝对或相对路径</param>
        public HttpPutAttribute(string path)
            : base(HttpMethod.Put, path)
        {
        }
    }
}
