﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Patterns.Tools.DocTemplates.Templates {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TemplateResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TemplateResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Patterns.Tools.DocTemplates.Templates.TemplateResources", typeof(TemplateResources).Assembly);
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
        ///   Looks up a localized string similar to @using Patterns.Tools.DocTemplates.Models
        ///@inherits RazorEngine.Templating.TemplateBase&lt;AssemblyModel&gt;
        ///@{
        ///	Layout = &quot;Layout.cshtml&quot;;
        ///	ViewBag.Title = string.Format(&quot;Assembly: {0}&quot;, Model.Name);
        ///}
        ///
        ///@if (Model.IsPublishedOnNuGet)
        ///{
        ///	&lt;p&gt;
        ///		&lt;a href=&quot;http://nuget.org/packages/Patterns&quot;&gt;Available on NuGet&lt;/a&gt;
        ///	&lt;/p&gt;
        ///}
        ///
        ///&lt;p&gt;
        ///	&lt;span class=&quot;assembly-description&quot;&gt;@Model.Description&lt;/span&gt;
        ///&lt;/p&gt;
        ///
        ///&lt;ul&gt;
        ///	@foreach (NamespaceModel namespaceModel in Model.Namespaces)
        ///	{
        ///		Include(&quot;NamespaceTemplate&quot;, name [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AssemblyTemplate {
            get {
                return ResourceManager.GetString("AssemblyTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @inherits Patterns.Tools.DocTemplates.Fx.DepthAwareTemplateBase
        ///&lt;!doctype html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///	&lt;meta charset=&quot;utf-8&quot;&gt;
        ///	&lt;meta http-equiv=&quot;X-UA-Compatible&quot; content=&quot;chrome=1&quot;&gt;
        ///	&lt;title&gt;Code Patterns for .NET&lt;/title&gt;
        ///	&lt;link rel=&quot;stylesheet&quot; href=&quot;@AppRelativeRoot()css/styles.css&quot;&gt;
        ///	&lt;link rel=&quot;stylesheet&quot; href=&quot;@AppRelativeRoot()css/pygment_trac.css&quot;&gt;
        ///	&lt;script src=&quot;https://cdnjs.cloudflare.com/ajax/libs/jquery/1.9.1/jquery.min.js&quot; type=&quot;text/javascript&quot;&gt;&lt;/script&gt;
        ///	&lt;script src=&quot;@AppRelativeRoot()js/res [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Layout {
            get {
                return ResourceManager.GetString("Layout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;li&gt;namespace goes here&lt;/li&gt;.
        /// </summary>
        internal static string NamespaceTemplate {
            get {
                return ResourceManager.GetString("NamespaceTemplate", resourceCulture);
            }
        }
    }
}
