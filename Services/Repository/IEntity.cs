﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.Services.Repository
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
