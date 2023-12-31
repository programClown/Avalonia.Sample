﻿using MiniMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BindingDemo.ViewModels;

public class NestedCommandViewModel : ViewModelBase
{
    public NestedCommandViewModel()
    {
        Command = MiniCommand.Create(() => { });
    }

    public ICommand Command { get; }
}