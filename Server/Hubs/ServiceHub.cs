using Microsoft.AspNetCore.SignalR;
using Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Server.Hubs
{
    public class ServiceHub : Hub
    {
        private IService _service;

        public ServiceHub(IService service)
        {
            _service = service;
        }

        public IAsyncEnumerable<ElectricSignal> StreamSignals()
        {
            return _service.SignalsObservable.ToAsyncEnumerable();
        }
    }
}
