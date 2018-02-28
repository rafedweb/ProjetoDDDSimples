﻿using System;

namespace ProjetoDDDSimplificado.Domain.Helpers
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
