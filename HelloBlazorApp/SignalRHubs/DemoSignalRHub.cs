using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloBlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace HelloBlazorApp.SignalRHubs
{
    public class DemoSignalRHub
    {
        public HubConnection ServerConnection { get; }

        internal event Action<Organisation> LoadOrganisation;

        public DemoSignalRHub()
        {
            var serverHubUrl = "http://localhost:5000/OrgaSHub";

            ServerConnection = new HubConnectionBuilder()
                .WithUrl(serverHubUrl)
                .WithAutomaticReconnect()
                .Build();

            ServerConnection.On<Organisation>(nameof(InvokeLoadOrganisation), InvokeLoadOrganisation);
        }


        private void InvokeLoadOrganisation(Organisation organisation)
        {
            LoadOrganisation?.Invoke(organisation);
        }



        //internal class SingletonHelper
        //{
        //    internal event Action<Organisation> LoadOrganisation;

        //    private static SingletonHelper _instance = null;
        //    private static object _initLock;
        //    private SingletonHelper() { }

        //    internal static SingletonHelper GetInstance
        //    {
        //        get
        //        {
        //            if (_instance == null)
        //            {
        //                lock (_initLock)
        //                {
        //                    if (_instance == null)
        //                    {
        //                        _instance = new SingletonHelper();
        //                    }
        //                }
        //            }
        //            return _instance;
        //        }
        //    }

        //    internal void InvokeLoadOrganisation(Organisation organisation)
        //    {
        //        LoadOrganisation?.Invoke(organisation);
        //    }
        //}
    }
}
