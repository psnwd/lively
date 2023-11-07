﻿using Lively.Core;
using Lively.Models;
using Lively.Services;

namespace Lively.Factories
{
    public interface IWallpaperPluginFactory
    {
        IWallpaper CreateWallpaper(LibraryModel model, DisplayMonitor display, IUserSettingsService userSettings, bool isPreview = false);
    }
}