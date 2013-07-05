﻿using System;
using MediaBrowser.Model.Dto;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace MediaBrowser.Theater.Interfaces.Presentation
{
    /// <summary>
    /// Interface IApplicationWindow
    /// </summary>
    public interface IPresentationManager
    {
        /// <summary>
        /// Gets the apps.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>IEnumerable{ITheaterApp}.</returns>
        /// <value>The apps.</value>
        IEnumerable<ITheaterApp> GetApps(UserDto user);

        /// <summary>
        /// Gets the settings pages.
        /// </summary>
        /// <value>The settings pages.</value>
        IEnumerable<ISettingsPage> SettingsPages { get; }

        IEnumerable<IHomePage> HomePages { get; }

        /// <summary>
        /// Occurs when [window loaded].
        /// </summary>
        event EventHandler<EventArgs> WindowLoaded;
        
        /// <summary>
        /// Gets the window.
        /// </summary>
        /// <value>The window.</value>
        Window Window { get; }

        /// <summary>
        /// Gets the backdrop container.
        /// </summary>
        /// <value>The backdrop container.</value>
        FrameworkElement BackdropContainer { get; }

        /// <summary>
        /// Gets the window overlay.
        /// </summary>
        /// <value>The window overlay.</value>
        FrameworkElement WindowOverlay { get; }

        /// <summary>
        /// Clears the backdrops.
        /// </summary>
        void ClearBackdrops();

        /// <summary>
        /// Sets the backdrops.
        /// </summary>
        /// <param name="item">The item.</param>
        void SetBackdrops(BaseItemDto item);

        /// <summary>
        /// Sets the backdrops.
        /// </summary>
        /// <param name="paths">The paths.</param>
        void SetBackdrops(IEnumerable<string> paths);

        /// <summary>
        /// Shows the default error message.
        /// </summary>
        void ShowDefaultErrorMessage();

        /// <summary>
        /// Shows the message.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns>MessageBoxResult.</returns>
        MessageBoxResult ShowMessage(MessageBoxInfo options);

        /// <summary>
        /// Shows the notification.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="text">The text.</param>
        /// <param name="icon">The icon.</param>
        void ShowNotification(string caption, string text, BitmapImage icon);

        /// <summary>
        /// Sets the page title.
        /// </summary>
        /// <param name="title">The title.</param>
        void SetPageTitle(string title);

        /// <summary>
        /// Sets the default page title.
        /// </summary>
        void SetDefaultPageTitle();

        /// <summary>
        /// Adds the parts.
        /// </summary>
        /// <param name="apps">The apps.</param>
        /// <param name="settingsPages">The settings pages.</param>
        /// <param name="homePages">The home pages.</param>
        void AddParts(IEnumerable<ITheaterApp> apps, IEnumerable<ISettingsPage> settingsPages, IEnumerable<IHomePage> homePages);

        /// <summary>
        /// Adds the resource dictionary.
        /// </summary>
        /// <param name="resource">The resource.</param>
        void AddResourceDictionary(ResourceDictionary resource);

        /// <summary>
        /// Removes the resource dictionary.
        /// </summary>
        /// <param name="resource">The resource.</param>
        void RemoveResourceDictionary(ResourceDictionary resource);
    }
}