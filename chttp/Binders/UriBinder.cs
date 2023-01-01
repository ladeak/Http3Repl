﻿using System.CommandLine;
using System.CommandLine.Binding;

namespace CHttp.Binders;

public class UriBinder : BinderBase<Uri>
{
    private readonly Option<string> _option;

    public UriBinder(Option<string> option)
    {
        _option = option;
    }

    protected override Uri GetBoundValue(BindingContext bindingContext)
    {
        var value = bindingContext.ParseResult.GetValueForOption(_option) ?? string.Empty;
        return new Uri(value, UriKind.Absolute);
    }
}
