﻿using NuGet;

namespace AutoUpdate
{
    public class InstallationState
    {
        public IPackage Installed { get; set; }

        public IPackage Update { get; set; }
    }
}
