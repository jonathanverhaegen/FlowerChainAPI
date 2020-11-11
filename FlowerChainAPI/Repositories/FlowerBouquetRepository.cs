using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FlowerChainAPI.Database;
using FlowerChainAPI.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlowerChainAPI.Repositories
{
    public class FlowerBouquetRepository : IFlowerBouquetRepository
    {

        private readonly FlowerChainContext _context;

        public FlowerBouquetRepository(FlowerChainContext context)
        {
            _context = context;
        }

        public async Task<List<FlowerBouquet>> GetAllBouquetsAsync()
        {
            return await _context.FlowerBouquet.ToListAsync();
        }
    }


}