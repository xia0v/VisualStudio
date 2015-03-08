﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using GitHub.Models;

namespace GitHub.ViewModels
{
    /// <summary>
    /// ViewModel for the the Clone Repository dialog
    /// </summary>
    public interface ICloneRepoViewModel : IViewModel
    {
        /// <summary>
        /// Command to clone the currently selected repository.
        /// </summary>
        ICommand CloneCommand { get; }

        /// <summary>
        /// The list of repositories the current user may clone from the specified host.
        /// </summary>
        ICollection<IRepositoryModel> Repositories { get; }
    }
}
