using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MusicStore.DTO;
using MusicStore.Repository;
using MusicStore.Models;
using AutoMapper;

namespace MusicStore.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class ArtistService : IArtistService
    {
        IRepository<Artist> artistRepository;

        public ArtistService(IRepository<Artist> artistRepository)
        {
            this.artistRepository = artistRepository;
        }
        
        public IEnumerable<ArtistDTO> GetAll()
        {
            return Mapper.Map<IEnumerable<Artist>, IEnumerable<ArtistDTO>>(this.artistRepository.Get());
        }
    }
}
