using Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace Server.Services
{
    public interface IService
    {
        public Subject<ElectricSignal> SignalsObservable { get; }
    }
}
