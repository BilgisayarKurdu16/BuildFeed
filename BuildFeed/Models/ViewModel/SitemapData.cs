﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace BuildFeed.Models.ViewModel
{
    public class SitemapData
    {
        public SitemapDataBuildGroup[] Builds { get; set; }
        public Dictionary<string, SitemapPagedAction[]> Actions { get; set; }

        public string[] Labs { get; set; }
    }

    public class SitemapDataBuildGroup
    {
        public BuildGroup Id { get; set; }
        public SitemapDataBuild[] Builds { get; set; }
    }

    public class SitemapDataBuild
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class SitemapPagedAction
    {
        public string Name { get; set; }
        public RouteValueDictionary UrlParams { get; set; }
        public int Pages { get; set; }

        public string Action
        {
            get { return UrlParams["action"].ToString();  }
        }

        public string UniqueId
        {
            get { return UrlParams.GetHashCode().ToString("X8").ToLower(); }
        }
    }
}