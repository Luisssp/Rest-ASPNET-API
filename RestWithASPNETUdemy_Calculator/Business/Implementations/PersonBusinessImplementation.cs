﻿using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        //private MySQLContext _context;
        //private readonly IPersonRepository _repository;
        private readonly IRepository<Person> _repository;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
        public List<Person> FindAll() 
        {         
            return _repository.FindAll();             
        }      
        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }        
    }
}
