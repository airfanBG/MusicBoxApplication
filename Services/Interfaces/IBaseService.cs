using Data.Models;
using Data.Models.Interfaces;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBaseService
    {
        public List<BaseViewModel> GetAll();
        public int Add(BaseViewModel model);
        public int Update(BaseViewModel model);
        public int Delete(int id);
        public BaseViewModel GetById(int id);
    }
}
