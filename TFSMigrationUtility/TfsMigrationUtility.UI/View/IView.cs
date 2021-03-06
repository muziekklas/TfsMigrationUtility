﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfsMigrationUtility.UI.ViewModels;

namespace TfsMigrationUtility.UI.View
{
    public interface IView
    {
        void ShowView();
        void Close();
        IViewModel ViewModel { get; set; }
        event EventHandler Closed;
    }
}
