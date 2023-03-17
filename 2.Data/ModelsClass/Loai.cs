using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class Loai
    {
        public Loai() 
        {
            monAns = new HashSet<MonAn>();
        }
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<MonAn> monAns { get; set; }
    }
}
