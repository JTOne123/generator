﻿using System.Collections.Generic;
using KY.Generator.Configuration;
using KY.Generator.Output;
using KY.Generator.Transfer;

namespace KY.Generator.Tests.Models
{
    internal class Writer1 : ITransferWriter
    {
        public void Write(ConfigurationBase configurationBase, List<ITransferObject> transferObjects, IOutput output)
        {
            Write1Configuration configuration = (Write1Configuration)configurationBase;
        }
    }
}