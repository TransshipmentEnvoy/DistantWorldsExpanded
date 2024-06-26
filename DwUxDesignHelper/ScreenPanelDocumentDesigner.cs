﻿using System.ComponentModel;
using System.Collections;
using System.Drawing;
using System.Windows.Forms.Design;

namespace DistantWorlds.Controls.Design;

[ToolboxItemFilter("DistantWorlds.Controls.ScreenPanel", ToolboxItemFilterType.Custom)]
internal class ScreenPanelDocumentDesigner : DocumentDesigner {

  public ScreenPanelDocumentDesigner()
    => AutoResizeHandles = true;

  private Size Size {
    get => Control.ClientSize;
    set => Control.ClientSize = value;
  }

  protected override void PreFilterProperties(IDictionary properties) {
    base.PreFilterProperties(properties);

    // Handle shadowed properties
    string[] shadowProps = { "Size" };

    var empty = Array.Empty<Attribute>();

    for (var i = 0; i < shadowProps.Length; i++) {
      if (properties[shadowProps[i]] is PropertyDescriptor prop)
        properties[shadowProps[i]] = TypeDescriptor.CreateProperty
          (typeof(ScreenPanelDocumentDesigner), prop, empty);
    }
  }

}