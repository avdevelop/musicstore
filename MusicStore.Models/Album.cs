using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStore.Models
{
    public class Album
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        //public virtual List<Artist> Artists { get; set; }
    }
}
