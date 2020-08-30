using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookListWebCore.BookManage.BookList
{
    /// <summary>
    /// 书单
    /// </summary>
    public class BookList:CreationAuditedEntity
    {
        /// <summary>
        /// 书单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 书单简介
        /// </summary>
        public string Intro { get; set; }
        /// <summary>
        /// 书单标签
        /// </summary>
        public string BookTags { get; set; }
    }
}
