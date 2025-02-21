using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPfDashboard.Models;
using WPfDashboard.Interfaces;
using System.Diagnostics.Eventing.Reader;

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
            this._wpfProjectDatabaseContext?.Add(entity);
            this._wpfProjectDatabaseContext?.SaveChanges();
        }

        public void Delete(int? id)
        {
            var vaildData = this._wpfProjectDatabaseContext?.WorldPopulations.FirstOrDefault(c => c.Id == id);
            if (vaildData != null)
            {
                this._wpfProjectDatabaseContext?.WorldPopulations.Remove(vaildData);
            }
            else
            {
                throw new InvalidOperationException();

            }
        }



        public List<WorldPopulation> Get()
        {
            return this._wpfProjectDatabaseContext?.WorldPopulations.ToList();
        }

        public WorldPopulation? GetDetail(int? id)
        {

            var vaildData = this._wpfProjectDatabaseContext?.WorldPopulations.FirstOrDefault(c => c.Id == id);
            if (vaildData != null)
            {
                return vaildData;
            }
            else
            {
                throw new InvalidOperationException();

            }

        }

        public void Update(WorldPopulation entity)
        {
            this._wpfProjectDatabaseContext?.WorldPopulations.Update(entity);
            this._wpfProjectDatabaseContext?.SaveChanges();
        }
    }
}
