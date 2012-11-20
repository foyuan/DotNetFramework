﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.Base.Contract
{
    public interface IPermissionService
    {
        List<Permission> GetPermissions(string sqlWhere);

        int Insert(Permission model);
    }
}
