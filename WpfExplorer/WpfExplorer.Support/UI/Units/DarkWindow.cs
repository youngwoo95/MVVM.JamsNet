﻿using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{
    public class DarkWindow : JamesWindow
    {
        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow),
                new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }
    }
}
