﻿using OneClick.Domain._Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClick.Domain.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> users { get; }

        void saveUser(User users);

    }
}
