using CapstoneProject.BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void TDelete(Color t)
        {
            _colorDal.Delete(t);
        }

        public Color TGetByID(int id)
        {
           return  _colorDal.GetByID(id);
        }

        public List<Color> TGetList()
        {
            return _colorDal.GetList();
        }

        public void TInsert(Color t)
        {
            _colorDal.Insert(t);
        }

        public void TUpdate(Color t)
        {
            _colorDal.Update(t);
        }
    }
}
