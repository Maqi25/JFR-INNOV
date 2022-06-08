using System;

namespace appmvc_projet2.Models.Services.LocationVehicules
{
    public interface IDal : IDisposable
    {
        void DeleteCreateDatabase();

        int CreerLocationDeVehicule(int serviceId, string modeleVehicule, string typeBoite, string motorisation, double kilometrage, DateTime dateMiseEnService, int nbrePlace );
    }
}
