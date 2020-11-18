﻿using AutoMapper;
using Demo.WebApi.NetCore.Entities.Models;
using Demo.WebApi.NetCore.Dto.DataTransferObjects.Venta;
using Demo.WebApi.NetCore.Services;

namespace Demo.WebApi.NetCore.Dto
{
    public class VentaService
    {
        private readonly IVentaServices _ventaServices;
        private readonly IMapper _mapper;
        

        public VentaService(IVentaServices ventaServices, IMapper mapper)
        {
            _ventaServices = ventaServices;
            _mapper = mapper;
        }


        public bool Create(VentaForCreation ventaForCreation, DetalleVentaForCreation detalleVentas)
        {
            var ventatEntity = _mapper.Map<Venta>(ventaForCreation);
            var detalleVentaEntity = _mapper.Map<DetalleVenta>(detalleVentas);
            var venta = _ventaServices.Create(ventatEntity, detalleVentaEntity);           
            return venta;
        }

        
    }
}

