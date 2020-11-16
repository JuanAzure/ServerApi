﻿using System.Threading.Tasks;

namespace Demo.WebApi.NetCore.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product{ get; }
        IVentaRepository Venta { get; }


        Task SaveAsync();
    }
}
