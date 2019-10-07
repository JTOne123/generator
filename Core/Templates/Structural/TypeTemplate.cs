using System;
using System.Diagnostics;

namespace KY.Generator.Templates
{
    [DebuggerDisplay("TypeTemplate: {Name}")]
    public class TypeTemplate : ICodeFragment
    {
        public string Name { get; }
        public string Namespace { get; }
        public bool IsInterface { get; }
        public bool IsNullable { get; }
        public bool FromSystem { get; }

        public TypeTemplate(string name, string nameSpace = null, bool isInterface = false, bool isNullable = false, bool fromSystem = false)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Namespace = nameSpace;
            this.IsInterface = isInterface;
            this.IsNullable = isNullable;
            this.FromSystem = fromSystem;
        }

        public override bool Equals(object obj)
        {
            var type = obj as TypeTemplate;
            return type != null && this.Name.Equals(type.Name);
        }

        public static bool operator ==(TypeTemplate left, TypeTemplate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TypeTemplate left, TypeTemplate right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}