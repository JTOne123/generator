﻿using KY.Generator.Configuration;
using KY.Generator.Configurations;

namespace KY.Generator.Templates.Extensions
{
    public static class ParameterTemplateExtension
    {
        public static ParameterTemplate FormatName(this ParameterTemplate parameter, IConfiguration configuration)
        {
            parameter.Name = Formatter.FormatParameter(parameter.Name, configuration);
            return parameter;
        }
    }
}