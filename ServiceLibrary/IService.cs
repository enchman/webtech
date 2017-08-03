using System;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    /// <summary>
    /// Service MUST encapsulate from the main process
    /// </summary>
    public interface IService
    {
        void Start();
        void Stop();
        Task StartAsync();
        Task StopAsync();
    }
}
