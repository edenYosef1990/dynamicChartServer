using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Timers;

namespace Server.Services
{
    public class Service : IService
    {
        private static System.Timers.Timer aTimer;
        public Subject<ElectricSignal> SignalsObservable { get; }
        private float offset;

        public Service()
        {
            SignalsObservable = new Subject<ElectricSignal>();
            offset = 0f;
            aTimer = new System.Timers.Timer(10);
            aTimer.Elapsed += (s, e) =>
            {
                offset += 0.01f;
                SignalsObservable.OnNext(new ElectricSignal() {
                    value = Math.Sin(offset)
                });
            };
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            aTimer.Start();
        }


    }
}
