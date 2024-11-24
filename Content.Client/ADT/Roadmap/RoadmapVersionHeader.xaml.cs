﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.ADT.Roadmap;

[GenerateTypedNameReferences]
public sealed partial class RoadmapVersionHeader : BoxContainer
{
    public string? Text
    {
        get => Version.Text;
        set => Version.Text = value;
    }

    public RoadmapVersionHeader()
    {
        RobustXamlLoader.Load(this);
    }
}
