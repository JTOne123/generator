﻿using System.Collections.Generic;
using KY.Core;
using KY.Core.Dependency;
using KY.Generator.Configuration;
using KY.Generator.Configurations;
using KY.Generator.Json.Configurations;
using KY.Generator.Output;
using KY.Generator.Templates;
using KY.Generator.Transfer;
using KY.Generator.Transfer.Writers;

namespace KY.Generator.Json.Writers
{
    internal class JsonWriter : ITransferWriter
    {
        private readonly IDependencyResolver resolver;

        public JsonWriter(IDependencyResolver resolver)
        {
            this.resolver = resolver;
        }

        public void Write(ConfigurationBase configurationBase, List<ITransferObject> transferObjects, IOutput output)
        {
            JsonWriteConfiguration configuration = (JsonWriteConfiguration)configurationBase;
            List<FileTemplate> files = new List<FileTemplate>();
            if (configuration.Object != null)
            {
                this.resolver.Create<ObjectWriter>().Write(configuration, transferObjects).ForEach(files.Add);
            }
            if (configuration.Reader != null)
            {
                this.resolver.Create<ObjectReaderWriter>().Write(configuration, transferObjects).ForEach(files.Add);
            }
            if (configuration.Object == null && configuration.Reader == null)
            {
                Logger.Warning("Json configuration has no model and no reader property. Set at least one of them to start generation");
            }
            files.ForEach(file => configuration.Language.Write(file, output));
        }
    }
}