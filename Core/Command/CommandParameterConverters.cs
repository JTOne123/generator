﻿using System;
using System.Collections.Generic;
using System.Reflection;
using KY.Generator.Configuration;
using KY.Generator.Exceptions;

namespace KY.Generator.Command
{
    public static class CommandParameterConverters
    {
        private static readonly Dictionary<Type, Func<string, object>> converters;

        static CommandParameterConverters()
        {
            converters = new Dictionary<Type, Func<string, object>>();
            converters.Add(typeof(char), value => value[0]);
            converters.Add(typeof(string), value => value);
            converters.Add(typeof(bool), value => value == string.Empty || bool.Parse(value));
            converters.Add(typeof(byte), value => byte.Parse(value));
            converters.Add(typeof(short), value => short.Parse(value));
            converters.Add(typeof(int), value => int.Parse(value));
            converters.Add(typeof(long), value => long.Parse(value));
            converters.Add(typeof(ushort), value => ushort.Parse(value));
            converters.Add(typeof(uint), value => uint.Parse(value));
            converters.Add(typeof(ulong), value => ulong.Parse(value));
            converters.Add(typeof(float), value => float.Parse(value));
            converters.Add(typeof(double), value => double.Parse(value));
            converters.Add(typeof(decimal), value => decimal.Parse(value));
            converters.Add(typeof(TimeSpan), value => TimeSpan.Parse(value));
            converters.Add(typeof(DateTime), value => DateTime.Parse(value));
            converters.Add(typeof(Guid), value => Guid.Parse(value));
        }

        public static object Convert(string value, PropertyInfo property)
        {
            ConfigurationPropertyConverterAttribute attribute = property.GetCustomAttribute<ConfigurationPropertyConverterAttribute>();
            if (attribute != null)
            {
                ConfigurationPropertyConverter converter = (ConfigurationPropertyConverter)Activator.CreateInstance(attribute.ConverterType);
                return converter.Convert(value);
            }
            if (!converters.ContainsKey(property.PropertyType))
            {
                throw new CommandParameterConverterNotFoundException(property.PropertyType);
            }
            return converters[property.PropertyType](value);
        }
    }
}