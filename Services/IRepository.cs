﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace davidharveysblog.Services
{
    /// <summary>
    /// Based on https://cpratt.co/truly-generic-repository/
    /// </summary>
    public interface IRepository : IReadOnlyRepository
    {
        void Create<TEntity>(TEntity entity, string createdBy = null) where TEntity : class, IEntity;

        void Update<TEntity>(TEntity entity, string modifiedBy = null) where TEntity : class, IEntity;

        void Delete<TEntity>(object id) where TEntity : class, IEntity;

        void Delete<TEntity>(TEntity entity) where TEntity : class, IEntity;

        void Save();

        Task SaveAsync();
    }
}
