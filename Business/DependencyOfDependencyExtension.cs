﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Unity;
using Unity.Extension;

namespace Business
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IData, DataClass>();
        }
    }
}
