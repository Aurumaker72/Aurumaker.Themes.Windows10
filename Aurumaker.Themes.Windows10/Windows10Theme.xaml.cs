using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Aurumaker.Themes.Windows10;

public class Windows10Theme : Styles
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Windows10Theme" /> class.
    /// </summary>
    /// <param name="sp">The parent's service provider.</param>
    public Windows10Theme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }
}