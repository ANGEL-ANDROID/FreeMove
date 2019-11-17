﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeMove.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FreeMove.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to ImDema/FreeMove {0}
        ///
        ///This program is licensed under the GNU General Public License v3.0
        ///For more informations https://github.com/imDema/FreeMove/blob/master/LICENSE.txt 
        ///
        ///https://github.com/imDema.
        /// </summary>
        internal static string AboutContent {
            get {
                return ResourceManager.GetString("AboutContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It&apos;s strongly recommended not to move the &quot;Program Files&quot; or the &quot;Program Files (x86)&quot; directories as it can lead to unexpexted behaviour.
        ///You are free to move any of the programs contained in those directories without any problem instead.
        ///
        ///Are you sure you want to disable safe mode?.
        /// </summary>
        internal static string DisableSafeModeMessage {
            get {
                return ResourceManager.GetString("DisableSafeModeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR creating symbolic link.
        ///The folder is in the new position but the link could not be created.
        ///Try running as administrator
        ///
        ///Do you want to move the files back?.
        /// </summary>
        internal static string ErrorUnauthorizedLink {
            get {
                return ResourceManager.GetString("ErrorUnauthorizedLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The error was caused by a file which couldn&apos;t be moved, it may be in use or you may not have the required permissions.
        ///
        ///Try running this program as administrator and/or close any program that is using the file specified in the details
        ///
        ///DETAILS:.
        /// </summary>
        internal static string ErrorUnauthorizedMoveDetails {
            get {
                return ResourceManager.GetString("ErrorUnauthorizedMoveDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: {0}
        ///
        ///How do you want to proceed?
        ///&quot;Abort&quot; to revert changes
        ///&quot;Ignore&quot; to stop the program.
        /// </summary>
        internal static string ErrorUnauthorizedMoveMessage {
            get {
                return ResourceManager.GetString("ErrorUnauthorizedMoveMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not retrieve the version information
        ///from the GitHub server.
        /// </summary>
        internal static string GitHubErrorMessage {
            get {
                return ResourceManager.GetString("GitHubErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to proceed?
        ///
        ///By ignoring you will leave all the files as they are now: part of the files will already be in the new location and missing from the old one!.
        /// </summary>
        internal static string IgnoreMessage {
            get {
                return ResourceManager.GetString("IgnoreMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error when moving the files using FreeMove on {0} and you chose to ignore it.
        ///The rest of the contents of this directory can be found at &quot;{1}&quot; unless they were moved.
        ///Next time use &quot;Abort&quot; in case of an error to move the files back or &quot;Retry&quot; to try again.
        ///
        ///If this text file was useful or if you would have preferred it wasn&apos;t created let me know.
        ///.
        /// </summary>
        internal static string IgnoreTextFile {
            get {
                return ResourceManager.GetString("IgnoreTextFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ImDema-FreeMove-Updater.
        /// </summary>
        internal static string UserAgent {
            get {
                return ResourceManager.GetString("UserAgent", resourceCulture);
            }
        }
    }
}
