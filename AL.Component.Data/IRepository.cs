﻿// 源文件头信息：
// <copyright file="IRepository.cs">
// Copyright(c)2012-2013 GMFCN.All rights reserved.
// CLR版本：4.0.30319.239
// 开发组织：郭明锋@中国
// 公司网站：http://www.gmfcn.net
// 所属工程：AL.Component.Data
// 最后修改：郭明锋
// 最后修改：2013/05/27 18:53
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using AL.Component.Tools;


namespace AL.Component.Data
{
    /// <summary>
    ///     定义仓储模型中的数据标准操作
    /// </summary>
    /// <typeparam name="TEntity">动态实体类型</typeparam>
    public interface IRepository<TEntity> where TEntity : Entity
    {
        #region 属性

        /// <summary>
        ///     获取 当前实体的查询数据集
        /// </summary>
        IQueryable<TEntity> Entities { get; }

        #endregion

        #region 公共方法

        /// <summary>
        ///     插入实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Insert(TEntity entity, bool isSave = true);

        /// <summary>
        ///     批量插入实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Insert(IEnumerable<TEntity> entities, bool isSave = true);

        /// <summary>
        ///     删除指定编号的记录
        /// </summary>
        /// <param name="id"> 实体记录编号 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Delete(object id, bool isSave = true);

        /// <summary>
        ///     删除实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Delete(TEntity entity, bool isSave = true);

        /// <summary>
        ///     删除实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Delete(IEnumerable<TEntity> entities, bool isSave = true);

        /// <summary>
        ///     删除所有符合特定表达式的数据
        /// </summary>
        /// <param name="predicate"> 查询条件谓语表达式 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Delete(Expression<Func<TEntity, bool>> predicate, bool isSave = true);

        /// <summary>
        ///     更新实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Update(TEntity entity, bool isSave = true);

        /// <summary>
        ///     查找指定主键的实体记录
        /// </summary>
        /// <param name="key"> 指定主键 </param>
        /// <returns> 符合编号的记录，不存在返回null </returns>
        TEntity GetByKey(object key);

        #endregion
    }
}