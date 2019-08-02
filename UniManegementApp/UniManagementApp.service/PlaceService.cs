using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniManagementApp.Db;
using UniManagementApp.entities;

namespace UniManagementApp.service
{
    public class PlaceService
    {
        public List<ApplyFor> GetApplyFor()
        {
            using (var context = new UniDbContext())
            {
                return context.ApplyFors.ToList();
            }
        }

        public List<ScaleNo> GetScaleNo()
        {
            using (var context = new UniDbContext())
            {
                return context.ScaleNos.ToList();
            }
        }

        public List<ScaleNo> GetScaleNo(int id)
        {
            using (var context = new UniDbContext())
            {
                if (id == 1)
                {
                    var scale = context.ScaleNos.OrderBy(c => c.ScaleNum).Take(20).ToList();
                    return scale;
                }
                else
                {
                    var scale= context.ScaleNos.OrderBy(c => c.ScaleNum).Skip(16).Take(21).ToList();
                    return scale;
                }
                
            }
        }
        
        public List<Scale> GetJobTitle(int id)
        {
            using (var context = new UniDbContext())
            {
                return context.Scales.Where(c=>c.Scales==id).ToList();
            }
        }

        public List<Scale> GetScale()
        {
            using (var context = new UniDbContext())
            {
                return context.Scales.ToList();
            }
        }

        public List<Designation> GetDesignation()
        {
            using (var context = new UniDbContext())
            {
                return context.Designations.ToList();
            }
        }

        public List<Department> GetDepartment()
        {
            using (var context = new UniDbContext())
            {
                return context.Departments.ToList();
            }
        }

        public List<Domicile> GetDomicile()
        {
            using (var context = new UniDbContext())
            {
                return context.Domiciles.ToList();
            }
        }

        public List<Status> GetStatus()
        {
            using (var context = new UniDbContext())
            {
                return context.Statuses.ToList();
            }
        }

        public void SaveApply(Place model)
        {
            using (var context = new UniDbContext())
            {
                context.Places.Add(model);
                context.SaveChanges();
            }
        }

        public List<Place> GetRecord()
        {
            using (var context = new UniDbContext())
            {
                return context.Places.Include(c => c.Status).Include(c => c.ScaleNo).Include(c=>c.Department).Include(c=>c.Domicile).ToList();
            }
        }

        public Place GetRecord(string cnic)
        {
            using (var context = new UniDbContext())
            {
                return context.Places.Where(c => c.CNIC == cnic).Include(c => c.Status).Include(c => c.ScaleNo).Include(c => c.Department).Include(c => c.Domicile).Single();
            }
        }


    }
}
