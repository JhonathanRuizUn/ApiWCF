using ApiTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.IAdapters.ServiceContracts
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetUsers/{id}", ResponseFormat = WebMessageFormat.Json)]
        User GetUser(int id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateUser", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateUser(User user);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/DeleteUser/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void DeleteUser(int id);

        [OperationContract]
        IEnumerable<User> GetAllUsers();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddUser", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddUser(User user);


    }
}
