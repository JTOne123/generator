﻿using System.Linq;
using KY.Generator.Output;
using KY.Generator.Templates;
using KY.Generator.Writers;

namespace KY.Generator.TypeScript.Writers
{
    public class AnonymousObjectWriter : ITemplateWriter
    {
        public virtual void Write(ICodeFragment fragment, IOutputCache output)
        {
            AnonymousObjectTemplate template = (AnonymousObjectTemplate)fragment;
            output.Add("{")
                  .Indent();
            PropertyValueTemplate last = template.Properties.LastOrDefault();
            foreach (PropertyValueTemplate property in template.Properties)
            {
                output.Add($"{property.Name}: ")
                      .Add(property.Value)
                      .If(property != last).Add(",").EndIf()
                      .BreakLine();
            }
            output.UnIndent().Add("}");
        }
    }
}