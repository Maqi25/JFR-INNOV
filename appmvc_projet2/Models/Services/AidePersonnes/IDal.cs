using System;

namespace appmvc_projet2.Models.Services.AidePersonnes
{
    public interface IDal : IDisposable
    {
        void DeleteCreateDatabase();
    }
}
