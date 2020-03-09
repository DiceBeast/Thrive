﻿using SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IParentRepository : IRepositoryBase<Parent>
    {
        Parent GetParent(int parentId);
        void CreateParent(Parent parent);
        Parent GetParentIncludeAll(int classId);
        List<Parent> GetParentsIncludeAll();
        public Parent GetParentByUserIdInclude(string userId);
    }
}
