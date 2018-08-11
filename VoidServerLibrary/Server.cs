﻿using System;
using System.Threading;
using VoidServerLibrary.Interfaces;

namespace VoidServerLibrary
{
    public class Server //: IServer
    {
        IListener _listener;
        public Server(IListener listener)
        {
            this._listener = listener;
        }

        public void Start()
        {

        }
        public void Start(string[] args, CancellationToken token)
        {
            _listener.Start(args, token);
        }
    }
}
