﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KY.Generator.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KY.Generator.Tests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {}.
        /// </summary>
        internal static string empty_configuration {
            get {
                return ResourceManager.GetString("empty_configuration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {},
        ///  {}
        ///].
        /// </summary>
        internal static string empty_configuration_array {
            get {
                return ResourceManager.GetString("empty_configuration_array", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;generate&quot;:  {} 
        ///}.
        /// </summary>
        internal static string empty_generate {
            get {
                return ResourceManager.GetString("empty_generate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;Language&quot;: &quot;Csharp&quot;,
        ///  &quot;Generator&quot;: {
        ///    &quot;Client&quot;: {
        ///    }
        ///  }
        ///}
        ///.
        /// </summary>
        internal static string old_config {
            get {
                return ResourceManager.GetString("old_config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///
        ///&lt;Configuration&gt;
        ///  &lt;Language&gt;Csharp&lt;/Language&gt;
        ///  &lt;Generator&gt;
        ///    &lt;Client&gt;&lt;/Client&gt;
        ///  &lt;/Generator&gt;
        ///&lt;/Configuration&gt;.
        /// </summary>
        internal static string old_config1 {
            get {
                return ResourceManager.GetString("old_config1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;file:///C:/Projekte/C#/Generator/Core/Configuration/configuration.schema.json&quot;,
        ///  &quot;version&quot;: 2,
        ///  &quot;generate&quot;: {
        ///    &quot;write&quot;: &quot;1&quot;,
        ///    &quot;property1&quot;: &quot;Test1&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string one_generate {
            get {
                return ResourceManager.GetString("one_generate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;file:///C:/Projekte/C#/Generator/Core/Configuration/configuration.schema.json&quot;,
        ///  &quot;version&quot;: 2,
        ///  &quot;generate&quot;: [
        ///    {
        ///      &quot;write&quot;: &quot;1&quot;,
        ///      &quot;property1&quot;: &quot;Test1&quot;
        ///    }
        ///  ]
        ///}.
        /// </summary>
        internal static string one_generate_in_array {
            get {
                return ResourceManager.GetString("one_generate_in_array", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;file:///C:/Projekte/C#/Generator/Core/Configuration/configuration.schema.json&quot;,
        ///  &quot;version&quot;: 2,
        ///  &quot;generate&quot;: [
        ///    [
        ///      {
        ///        &quot;write&quot;: &quot;1&quot;,
        ///        &quot;property1&quot;: &quot;Test1&quot;
        ///      }
        ///    ]
        ///  ]
        ///}.
        /// </summary>
        internal static string one_generate_in_array_array {
            get {
                return ResourceManager.GetString("one_generate_in_array_array", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;file:///C:/Projekte/C#/Generator/Core/Configuration/configuration.schema.json&quot;,
        ///  &quot;version&quot;: 2,
        ///  &quot;generate&quot;: [
        ///    {
        ///      &quot;Read&quot;: &quot;1&quot;,
        ///      &quot;Property1&quot;: &quot;Test1&quot;
        ///    },
        ///    {
        ///      &quot;Write&quot;: &quot;1&quot;,
        ///      &quot;Property1&quot;: &quot;Test2&quot;
        ///    }
        ///  ]
        ///}
        ///.
        /// </summary>
        internal static string one_read_one_generate {
            get {
                return ResourceManager.GetString("one_read_one_generate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;file:///C:/Projekte/C#/Generator/Core/Configuration/configuration.schema.json&quot;,
        ///  &quot;version&quot;: 2,
        ///  &quot;generate&quot;: [
        ///    [
        ///      {
        ///        &quot;Read&quot;: &quot;1&quot;,
        ///        &quot;Property1&quot;: &quot;Test1&quot;
        ///      },
        ///      {
        ///        &quot;Write&quot;: &quot;1&quot;,
        ///        &quot;Property1&quot;: &quot;Test2&quot;
        ///      }
        ///    ],
        ///    [
        ///      {
        ///        &quot;Read&quot;: &quot;2&quot;,
        ///        &quot;Property1&quot;: &quot;Test3&quot;
        ///      },
        ///      {
        ///        &quot;Write&quot;: &quot;2&quot;,
        ///        &quot;Property1&quot;: &quot;Test4&quot;
        ///      }
        ///    ]
        ///  ]
        ///}
        ///
        ///.
        /// </summary>
        internal static string one_read_one_generate_twice {
            get {
                return ResourceManager.GetString("one_read_one_generate_twice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;file:///C:/Projekte/C#/Generator/Core/Configuration/configuration.schema.json&quot;,
        ///  &quot;version&quot;: 2,
        ///  &quot;generate&quot;: [
        ///    {
        ///      &quot;Read&quot;: &quot;1&quot;,
        ///      &quot;Property1&quot;: &quot;Test1&quot;
        ///    },
        ///    {
        ///      &quot;Read&quot;: &quot;2&quot;,
        ///      &quot;Property2&quot;: &quot;Test2&quot;
        ///    },
        ///    {
        ///      &quot;Write&quot;: &quot;1&quot;,
        ///      &quot;Property1&quot;: &quot;Test3&quot;
        ///    }
        ///  ]
        ///}.
        /// </summary>
        internal static string two_reads_one_generate {
            get {
                return ResourceManager.GetString("two_reads_one_generate", resourceCulture);
            }
        }
    }
}