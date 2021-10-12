using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.IO;
using SalesApp.Exceptions;

namespace SalesApp.SalesApp
{
    class Services
    {      
        //------linking repository with services
        private readonly Repository repository;
        public Services(Repository repository)
        {
            this.repository = repository;
        }

        //===========DATA ENTRY============//
        internal Sale Create(Sale toCreate)
        {
            Sale newSale = repository.Create(toCreate);
            return newSale;

        }


        //===========DELETE============//
        internal void Delete(int id)
        {
            if (!repository.Exists(id))
            {
                throw new ItemNotFoundException();
            }
            repository.Delete(id);
        }


    }
}
