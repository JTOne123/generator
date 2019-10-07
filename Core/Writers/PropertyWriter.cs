﻿using System.Linq;
using KY.Generator.Models;
using KY.Generator.Output;
using KY.Generator.Templates;

namespace KY.Generator.Writers
{
    public class PropertyWriter : ITemplateWriter
    {
        public virtual void Write(ICodeFragment fragment, IOutputCache output)
        {
            PropertyTemplate template = (PropertyTemplate)fragment;
            PropertyTemplate lastTemplate = output.LastFragments.FirstOrDefault() as PropertyTemplate;
            if (template.Attributes.Count > 0 || lastTemplate?.Attributes.Count > 0)
            {
                output.BreakLine();
            }
            if (template.Comment != null)
            {
                output.Add(template.Comment).BreakLine();
            }
            if (template.Attributes.Count > 0)
            {
                output.Add(template.Attributes).BreakLine();
            }
            output.Add(template.Visibility == Visibility.None ? string.Empty : template.Visibility.ToString().ToLower())
                  .Add(" ")
                  .Add(template.IsVirtual ? "virtual " : string.Empty)
                  .Add(template.IsStatic ? "static " : string.Empty)
                  .Add(template.Type)
                  .Add(" ")
                  .Add(template.Name);
            if (template.HasGetter || template.HasSetter)
            {
                output.Add(" { ")
                      .Add(template.HasGetter ? "get; " : string.Empty)
                      .Add(template.HasSetter ? "set; " : string.Empty)
                      .Add("}");
            }
            if (template.DefaultValue != null)
            {
                output.Add(" = ")
                      .Add(template.DefaultValue)
                      .CloseLine();
            }
            if (template.Expression != null)
            {
                output.Add(" => ")
                      .Add(template.Expression)
                      .CloseLine();
            }
            output.BreakLineIfNotEmpty();
        }
    }
}