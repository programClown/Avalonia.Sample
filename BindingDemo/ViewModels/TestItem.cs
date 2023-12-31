﻿using MiniMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingDemo.ViewModels;

public class TestItem : ViewModelBase
{
    private string _stringValue = "String Value";
    private string _detail;

    public string StringValue
    {
        get { return _stringValue; }
        set { this.RaiseAndSetIfChanged(ref this._stringValue, value); }
    }

    public string Detail
    {
        get { return _detail; }
        set { this.RaiseAndSetIfChanged(ref this._detail, value); }
    }
}