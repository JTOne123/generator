using KY.Generator.Languages;
using KY.Generator.Models;

namespace KY.Generator.Templates.Extensions
{
    public static class PropertyTemplateExtension
    {
        public static PropertyTemplate Internal(this PropertyTemplate property)
        {
            property.Visibility = Visibility.Internal;
            return property;
        }

        public static PropertyTemplate Protected(this PropertyTemplate property)
        {
            property.Visibility = Visibility.Protected;
            return property;
        }

        public static PropertyTemplate Private(this PropertyTemplate property)
        {
            property.Visibility = Visibility.Private;
            return property;
        }

        public static PropertyTemplate Virtual(this PropertyTemplate property, bool value = true)
        {
            property.IsVirtual = value;
            return property;
        }

        public static PropertyTemplate Static(this PropertyTemplate property, bool value = true)
        {
            property.IsStatic = value;
            return property;
        }

        public static PropertyTemplate ReadOnly(this PropertyTemplate property)
        {
            property.HasSetter = false;
            return property;
        }

        public static PropertyTemplate ReadOnlyWithCode(this PropertyTemplate property, ICodeFragment expression)
        {
            property.HasGetter = false;
            property.HasSetter = false;
            property.Expression = expression;
            return property;
        }

        public static PropertyTemplate WithDefaultValue(this PropertyTemplate property, ICodeFragment defaultValue)
        {
            property.DefaultValue = defaultValue;
            return property;
        }

        public static PropertyTemplate WithComment(this PropertyTemplate property, string description)
        {
            property.Comment = new CommentTemplate(description, CommentType.Summary);
            return property;
        }

        public static PropertyTemplate FormatName(this PropertyTemplate propertyTemplate, ILanguage language, bool formatNames = true)
        {
            if (formatNames && language is IFormattableLanguage formattableLanguage)
            {
                propertyTemplate.Name = formattableLanguage.FormatPropertyName(propertyTemplate.Name);
            }
            return propertyTemplate;
        }
    }
}