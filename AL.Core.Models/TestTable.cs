using AL.Component.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL.Core.Models
{
    [Description("测试Code First")]
    public class TestTable:Entity
    {
        /// <summary>
        /// 初始化一个 角色实体类 的新实例
        /// </summary>
        public TestTable()
        {
            Id = CombHelper.NewComb();
        }

        /// <summary>
        /// 获取或设置 角色编号
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 获取或设置 角色名称
        /// </summary>
        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 角色描述
        /// </summary>
        [StringLength(100)]
        public string Description { get; set; }
    }
}
