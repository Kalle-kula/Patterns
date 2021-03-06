﻿using Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverVideo
{
    public interface ISubject
    {
        void register(IObserver o);
        void unregister(IObserver o);
        void notifyObserver();
    }
}
