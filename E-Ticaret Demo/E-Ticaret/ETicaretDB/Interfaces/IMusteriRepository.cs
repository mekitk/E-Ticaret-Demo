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
     public interface IMusteriRepository : IGenericRepository<Musteri>
    {
        int GetMusteriCount();

       List<MusteriListDTO> GetMusteriList();
    }
}
