﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion9.Infrastructure
{
    /*
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext,
                                                                Type controllerType)
        {
            return controllerType == null
                                        ? null
                                        : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            // put additional bindings here
        }
    }
     * */
}