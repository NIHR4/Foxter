﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Foxter.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Foxter.Resources.AppStrings", typeof(AppStrings).Assembly);
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
        ///   Looks up a localized string similar to -- AUTHORS definition
        ///
        ///CREATE TABLE &quot;AUTHORS&quot; (
        ///	&quot;AuthorId&quot;	INTEGER NOT NULL,
        ///	&quot;Username&quot;	TEXT NOT NULL,
        ///	&quot;Password&quot;	TEXT NOT NULL,
        ///	PRIMARY KEY(&quot;AuthorId&quot;)
        ///);
        ///
        ///
        ///-- CHAPTERS definition
        ///
        ///CREATE TABLE CHAPTERS (
        ///	ChapterId INTEGER NOT NULL,
        ///	StoryId INTEGER,
        ///	StoryTitle TEXT NOT NULL,
        ///	ChapterTitle TEXT NOT NULL,
        ///	PublishingDate TEXT NOT NULL,
        ///	WrittenBy INTEGER,
        ///	CONSTRAINT CHAPTERS_PK PRIMARY KEY (ChapterId),
        ///	CONSTRAINT CHAPTERS_AUTHORS_FK FOREIGN KEY (WrittenBy) REFERENCES AUTHORS(Auth [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DbCreationScript {
            get {
                return ResourceManager.GetString("DbCreationScript", resourceCulture);
            }
        }
    }
}