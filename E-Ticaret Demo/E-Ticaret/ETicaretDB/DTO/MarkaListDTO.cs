using E_TicaretApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretDB.DTO
{
   public class MarkaListDTO : MarkaRepository
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string KucukYol { get; set; }
      

    }
}
