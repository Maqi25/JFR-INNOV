using System;
using System.Collections.Generic;

namespace appmvc_projet2.Models.Services.TransportColis
{
    public interface IDal : IDisposable
    {
        void DeleteCreateDatabase();
        
        List<TransportDeColis> ObtientTousLesTransportsDeColis();
        int CreerTransportDeColis(int serviceId, string nomDuColis, double volume, string format, string nature);
        void Modifier(int id, int serviceId, string nomDuColis, double volume, string format, string nature, string imagePath);
    }
}
