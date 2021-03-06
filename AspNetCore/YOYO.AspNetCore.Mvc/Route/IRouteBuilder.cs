﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOYO.Owin;

namespace YOYO.Mvc.Route
{
    public interface IRouteBuilder
    {
		IRouteBuilder Map(string role,string defaultControllerName = null, string defaultActionName = null);
        IRouteBuilder Map(RouteRole role);
        RouteResolveResult Resolve(IOwinRequest request);
    }
}
