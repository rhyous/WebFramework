﻿using Rhyous.WebFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Rhyous.WebFramework.Services
{
    public interface ISearchableServiceCommon<T, Tinterface, Tid> : IServiceCommon<T,Tinterface, Tid>
        where Tinterface : IEntity<Tid>
        where T : class, Tinterface
    {
        List<Tinterface> Search(string name);
        Expression<Func<T, string>> PropertyExpression { get; }
        Tinterface Get(string id);
    }
}
