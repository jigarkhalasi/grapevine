using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Repository
{
    public class BaseRepository
    {
        public GrapevineEntities Context { get; set; }

        public BaseRepository()
        {
            Context = new GrapevineEntities();
        }
    }
}
