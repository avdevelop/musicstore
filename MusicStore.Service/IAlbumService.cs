using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MusicStore.DTO;

namespace MusicStore.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlbumService" in both code and config file together.
    [ServiceContract]
    public interface IAlbumService
    {
        [OperationContract]
        IEnumerable<AlbumDTO> GetAll();
    }
}
