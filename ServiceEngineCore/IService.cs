using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceEngineCore
{
    public interface IService
    {
        event EventHandler Started;
        event EventHandler Stopped;
        event EventHandler Paused;

        void Pause();
        void Resume();
        void Start();
        void Stop();
    }
}
