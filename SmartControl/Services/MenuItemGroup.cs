using System;
using System.Collections.Generic;

namespace SmartControl.Services
{
    public class MenuItemGroup
    {
        readonly Lazy<List<MenuItemGroup>> _groups = new();
        public MenuItemGroup(string name, string url, string longDescription = "", string iconClass = "", string iconUrl = "", List<MenuItemGroup>? groups = null)
        {
            Name = name;
            NavigateUrl = url;
            LongDescription = longDescription;
            IconCssClass = iconClass;
            IconUrl = iconUrl;

            if (groups != null)
                Groups.AddRange(groups);
        }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string IconCssClass { get; set; }
        public string IconUrl { get; set; }
        public string NavigateUrl { get; set; }
        public List<MenuItemGroup> Groups { get { return _groups.Value; } }
    }
}