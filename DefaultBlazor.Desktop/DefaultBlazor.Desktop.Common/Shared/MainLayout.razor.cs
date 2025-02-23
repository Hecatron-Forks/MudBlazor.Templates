﻿namespace DefaultBlazor.Desktop.Common.Shared {

    /// <summary> The main layout. </summary>
    public partial class MainLayout {

        /// <summary> Gets or sets a value indicating whether the drawer open. </summary>
        /// <value> True if drawer open, false if not. </value>
        private bool _drawerOpen { get; set; } = true;

        /// <summary> Toggle the Nav Drawer. </summary>
        private void DrawerToggle() {
            _drawerOpen = !_drawerOpen;
        }
    }
}
