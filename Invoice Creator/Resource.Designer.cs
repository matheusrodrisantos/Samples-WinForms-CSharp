﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoiceCreator {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InvoiceCreator.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;Demo&gt;
        ///	&lt;Invoice&gt;
        ///		&lt;InvoiceDate&gt;&lt;/InvoiceDate&gt;
        ///		&lt;InvoiceNumber&gt;&lt;/InvoiceNumber&gt;
        ///		&lt;CustomerID&gt;&lt;/CustomerID&gt;
        ///		&lt;BillTo_Name&gt;&lt;/BillTo_Name&gt;
        ///		&lt;BillTo_Address&gt;&lt;/BillTo_Address&gt;
        ///		&lt;BillTo_Address2&gt;&lt;/BillTo_Address2&gt;
        ///		&lt;BillTo_City&gt;&lt;/BillTo_City&gt;
        ///		&lt;BillTo_State&gt;&lt;/BillTo_State&gt;
        ///		&lt;BillTo_ZipCode&gt;&lt;/BillTo_ZipCode&gt;
        ///		&lt;ShipTo_Name&gt;&lt;/ShipTo_Name&gt;
        ///		&lt;ShipTo_Address&gt;&lt;/ShipTo_Address&gt;
        ///		&lt;ShipTo_Address2&gt;&lt;/ShipTo_Address2&gt;
        ///		&lt;ShipTo_City&gt;&lt;/ShipTo_City&gt;
        ///		&lt;ShipTo_S [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EmptyTemplate {
            get {
                return ResourceManager.GetString("EmptyTemplate", resourceCulture);
            }
        }
    }
}