using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace KIS.System.Advanced.MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // create an object of ScriptBundle and 
            // specify bundle name (as virtual path) as constructor parameter 
            ScriptBundle scriptBndl = new ScriptBundle("~/bundles/Javascript");
            ScriptBundle scriptBndlLogin = new ScriptBundle("~/bundles/login");


            //use Include() method to add all the script files with their paths 
            scriptBndl.Include(
                                "~/Scripts/modernizr-{version}.min.js",
                                "~/Scripts/jquery-{version}.js",
                                "~/Scripts/jquery.validate.min.js",
                                "~/Scripts/bootstrap.bundle.min.js",
                                "~/Scripts/bootbox.locales.min.js",
                                "~/Scripts/jquery.inputmask.js",
                                "~/Scripts/classie.js",
                                "~/Scripts/dummydata.js",
                                "~/Scripts/main.js",
                                "~/Scripts/site.js"
                              );


            //Add the bundle into BundleCollection
            bundles.Add(scriptBndl);

            BundleTable.EnableOptimizations = true;
        }
    }
}