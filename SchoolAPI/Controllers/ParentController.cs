﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public ParentController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        // GET: api/Teacher/
        [HttpGet]
        public IEnumerable<Parent> Get()
        {
            return _repo.Parents.GetParentsIncludeAll();
        }

        [HttpGet("{stringId}")]
        public Parent Get(string stringId)
        {
            return _repo.Parents.GetParentByUserIdInclude(stringId);
        }

        // GET: api/Teacher/5
        [HttpGet("{id:int}")]
        public Parent Get(int id)
        {
            return _repo.Parents.GetParentIncludeAll(id);
        }

        // POST: api/School
        [HttpPost]
        public void Post([FromBody] Parent value)
        {
            var newParent = new Parent
            {
                Name = value.Name,
                Email = value.Email,
                Children = value.Children,
                UserId = value.UserId
            };
            _repo.Parents.Create(newParent);
            _repo.Save();
        }

        // PUT: api/School/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Parent value)
        {
            var parent = _repo.Parents.GetParent(id);
            parent.Name = value.Name;
            parent.Children = value.Children;
            parent.Email = value.Email;
            parent.UserId = value.UserId;
            _repo.Save();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parent = _repo.Parents.GetParent(id);
            _repo.Parents.Delete(parent);
            _repo.Save();
        }
    }
}
