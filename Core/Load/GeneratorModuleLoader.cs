﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using KY.Core;
using KY.Core.Dependency;
using KY.Core.Module;

namespace KY.Generator.Load
{
    internal class GeneratorModuleLoader
    {
        private readonly IDependencyResolver resolver;
        private readonly ModuleFinder moduleFinder;

        public GeneratorModuleLoader(IDependencyResolver resolver, ModuleFinder moduleFinder)
        {
            this.resolver = resolver;
            this.moduleFinder = moduleFinder;
        }

        public void Load(IEnumerable<string> modules)
        {
            List<ModuleBase> loadedModules = this.moduleFinder.Modules.ToList();
            foreach (string module in modules)
            {
                Assembly assembly = GeneratorAssemblyLocator.Locate(module);
                if (assembly == null)
                {
                    continue;
                }
                this.moduleFinder.LoadFrom(assembly);
            }
            List<ModuleBase> newModules = this.moduleFinder.Modules.Where(module => !loadedModules.Contains(module)).ToList();
            foreach (ModuleBase module in newModules)
            {
                Logger.Trace($"{module.GetType().Name.Replace("Module", "")}-{module.GetType().Assembly.GetName().Version} module loaded");
            }
            newModules.ForEach(module => this.resolver.Bind<ModuleBase>().To(module));
            newModules.ForEach(module => module.Initialize());
        }
    }
}