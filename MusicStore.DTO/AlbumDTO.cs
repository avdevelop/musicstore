using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStore.DTO
{
    public class AlbumDTO
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        //public virtual List<ArtistDTO> Artists { get; set; }
    }
}
