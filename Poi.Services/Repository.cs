using Poi.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poi.Services
{
    public class Repository : IRepository
    {
        private readonly PoiContext dbContext;

        public Repository()
        {
            this.dbContext = new PoiContext();
            this.dbContext.Database.EnsureCreated();

        }

        public void Create(PointOfInterest entity)
        {
            if (entity != null)
                dbContext.Pois.Add(entity);
            else
                throw new Exception("null entity");
        }

        public void Update(PointOfInterest entity)
        {
            var existingEntity = this.dbContext.Pois.First(t => t.Id == entity.Id);
            existingEntity.Update(entity.Latitude, entity.Longitude, entity.Name);
           
        }
            
        public void Delete(PointOfInterest entity)
        {
            dbContext.Pois.Remove(entity);
        }

        public List<PointOfInterest> GetAll()
        {
            return dbContext.Pois.ToList();
        }

        public PointOfInterest GetById(Guid id)
        {
            return dbContext.Pois.First(t => t.Id == id);
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
