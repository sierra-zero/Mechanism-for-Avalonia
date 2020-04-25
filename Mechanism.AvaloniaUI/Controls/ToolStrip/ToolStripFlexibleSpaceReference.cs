﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mechanism.AvaloniaUI.Controls.ToolStrip
{
    public class ToolStripFlexibleSpaceReference : ToolStripItemReference
    {
        public static FlexibleSpaceToolStripItem ItemInstance = new FlexibleSpaceToolStripItem();
        static ToolStripFlexibleSpaceReference()
        {
            TargetItemProperty.OverrideDefaultValue<ToolStripFlexibleSpaceReference>(ItemInstance);
        }
    }
}
