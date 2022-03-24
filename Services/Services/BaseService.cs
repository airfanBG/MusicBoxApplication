using Data.ApplicationContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class BaseService : IBaseService
    {
        public BaseService(DbContext musicDbContext)
        {
            MusicDbContext = musicDbContext;
        }

        public DbContext MusicDbContext { get; }

        public int Add(BaseViewModel model)
        {
            if (model!=null)
            {
                Song song = new Song()
                {
                    Id = model.Id,
                   
                };

                MusicDbContext.Set<Song>().Add(song);
                return MusicDbContext.SaveChanges();
            }
            
            return 0;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BaseViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(BaseViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
