﻿using System;
using System.Runtime.Remoting.Messaging;

namespace NsqSharp.Bus
{
    internal class NsqBus : IBus
    {
        public void Send<T>(T message)
        {
            throw new NotImplementedException();
        }

        public void Send<T>()
        {
            throw new NotImplementedException();
        }

        public void Send<T>(Action<T> messageConstructor)
        {
            throw new NotImplementedException();
        }

        public void Send<T>(T message, params string[] nsqdTcpAddresses)
        {
            throw new NotImplementedException();
        }

        public void Send<T>(params string[] nsqdTcpAddresses)
        {
            throw new NotImplementedException();
        }

        public void Send<T>(Action<T> messageConstructor, params string[] nsqdTcpAddresses)
        {
            throw new NotImplementedException();
        }

        public void Send<T>(T message, string topic, params string[] nsqdTcpAddresses)
        {
            throw new NotImplementedException();
        }

        public void Send<T>(string topic, params string[] nsqdTcpAddresses)
        {
            throw new NotImplementedException();
        }

        public void Send<T>(Action<T> messageConstructor, string topic, params string[] nsqdTcpAddresses)
        {
            throw new NotImplementedException();
        }

        public void Defer(TimeSpan delay)
        {
            throw new NotImplementedException();
        }

        public void Defer(DateTime processAt)
        {
            throw new NotImplementedException();
        }

        public IMessage CurrentMessage
        {
            get { throw new NotImplementedException(); }
        }
    }
}