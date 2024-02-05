using ApiTest.App_Start;
using ApiTest.Core.Entities;
using ApiTest.Core.UseCases;
using ApiTest.IAdapters.ServiceContracts;
using ApiTest.Infrastructure.Repositorios;
using ApiTest.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ApiTest
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : UserService
    {

        private Service1()
        {
           
        }

     
    }
}

