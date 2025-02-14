using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPfDashboard.Models;
using WPfDashboard.Interfaces;

namespace WPfDashboard.Services
{
    internal class WorldPopulationService : IDatabase<WorldPopulation>
    {
        private readonly WpfProjectDatabaseContext _wpfProjectDatabaseContext;

        public WorldPopulationService(WpfProjectDatabaseContext wpfProjectDatabaseContext)
        {
            this._wpfProjectDatabaseContext = wpfProjectDatabaseContext;
        }

        public void Create(WorldPopulation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorldPopulation entity)
        {
            throw new NotImplementedException();
        }

        public List<WorldPopulation> Get()
        {
            throw new NotImplementedException();
        }

        public WorldPopulation? GetDetail(int? id)
        {
            throw new NotImplementedException();
        }

        public void Update(WorldPopulation entity)
        {
            throw new NotImplementedException();
        }
    }
}
