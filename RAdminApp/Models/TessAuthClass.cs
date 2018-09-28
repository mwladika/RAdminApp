using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Tessitura.Service.Facade;
using Tessitura.Service;


namespace RAdminApp.Models
{
    public class TessAuthClass
    {
        public static TessituraServiceFacade GetTessituraService(string baseUri)
        {
            var timeout = 5000;
            var tessituraService = new TessituraServiceFacade(baseUri, timeout);
            var userCredentials = new UserCredentials(ConfigurationManager.AppSettings["RESTUserName"], ConfigurationManager.AppSettings["RESTUserGroup"], ConfigurationManager.AppSettings["RESTMachine"], ConfigurationManager.AppSettings["RESTPassword"]);
            tessituraService.SetCredentials(userCredentials);

            return tessituraService;
        }
    }
}