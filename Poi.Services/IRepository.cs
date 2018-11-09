using Poi.Data;
using System;
using System.Collections.Generic;
using System.Text;
namespace Poi.Services
{
    public interface IRepository
    {
        void Create(PointOfInterest entity);
        void Update(PointOfInterest entity);
        void Delete(PointOfInterest entity);
        List<PointOfInterest> GetAll();
        PointOfInterest GetById(Guid id);
    }
}
