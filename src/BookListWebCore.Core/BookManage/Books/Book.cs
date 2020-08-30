using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookListWebCore.BookManage.Books
{
    public class Book:CreationAuditedEntity<long>
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 价格链接
        /// </summary>
        public string PriceUrl { get; set; }
        /// <summary>
        /// 封面图片链接
        /// </summary>
        public string imgUrl { get; set; }
    }
}
