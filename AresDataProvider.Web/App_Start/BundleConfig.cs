﻿using System.Web;
using System.Web.Optimization;

namespace AresDataProvider.Web
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
									"~/Scripts/jquery-{version}.js"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
									"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/Vue").Include(
				"~/Scripts/MyVue.js",
				"~/Scripts/vue-resource.min.js",
				"~/Scripts/Vue-multilanguage.js"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
								"~/Scripts/bootstrap.js",
								"~/Scripts/respond.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
								"~/Content/bootstrap.css",
								"~/Content/site.css"));

			bundles.Add(new ScriptBundle("~/bundles/SemanticUI").Include(
								"~/Scripts/semantic.min.js",
								"~/Scripts/tab.min.js",
								"~/Scripts/dimmer.min.js"));

			bundles.Add(new StyleBundle("~/Content/SemanticUI").Include(
								"~/Content/semantic.min.css",
								"~/Content/segment.min.css",
								"~/Content/icon.min.css",
								"~/Content/tab.min.css",
								"~/Content/grid.min.css",
								"~/Content/loader.min.css",
								"~/Content/dimmer.min.css",
								"~/Content/label.min.css"));
		}
	}
}
