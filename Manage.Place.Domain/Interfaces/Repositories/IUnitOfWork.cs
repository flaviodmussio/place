﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manage.Place.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> SaveChangesAsync();
        bool SaveChanges();
    }
}
