﻿using System.Web;
using System.Web.Optimization;

namespace EfProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/crud").Include(
                "~/Scripts/crud.admin.js*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                "~/Scripts/popper.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper-utils").Include(
                "~/Scripts/popper-utils.js"));

            bundles.Add(new StyleBundle("~/bundles/sweet").Include(
                "~/Content/sweet-alert.css"));

            bundles.Add(new StyleBundle("~/bundles/crud").Include(
                "~/Content/crud.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));
        }
    }
}