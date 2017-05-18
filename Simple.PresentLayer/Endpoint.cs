using Newtonsoft.Json;
using Sample.Abstractions.Models.ViewModel;
using Sample.Repositories;
using Sample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.PresentLayer
{
    public  class UserEndpoint
    {
        public  string GetList()
        {

            string test =  JsonConvert.SerializeObject(new UserService(new UserRepository(new DatabaseConfig())).GetUsers());

            return  test;
        }
    }

    public class BondEndpoint
    {

    }




}
