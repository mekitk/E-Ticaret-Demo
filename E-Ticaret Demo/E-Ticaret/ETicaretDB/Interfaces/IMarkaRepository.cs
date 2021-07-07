using E_TicaretApi.Interfaces;
using ETicaretDB.DTO;
using ETicaretDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretDB.Interfaces
{
    public interface IMarkaRepository : IGenericRepository<Marka>
    {
        List<MarkaListDTO> GetMarkaList();
        public void Create(Marka marka);

        public Marka Edit(int id);

        public Marka Delete(int id);


    }
}
