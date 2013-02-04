using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MusicStore.Repository;
using MusicStore.Models;
using MusicStore.DTO;
using AutoMapper;

namespace MusicStore.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlbumService" in code, svc and config file together.
    public class AlbumService : IAlbumService
    {
        IRepository<Album> albumRepository;

        public AlbumService(IRepository<Album> albumRepository)
        {
            this.albumRepository = albumRepository;
        }
        
        public IEnumerable<AlbumDTO> GetAll()
        {
            return Mapper.Map<IEnumerable<Album>, IEnumerable<AlbumDTO>>(this.albumRepository.Get());
        }
    }
}
