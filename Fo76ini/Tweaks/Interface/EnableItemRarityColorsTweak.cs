﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fo76ini.Tweaks.Interface
{
    class EnableItemRarityColorsTweak : ITweak<bool>, ITweakInfo
    {
        public string Description => "";

        public string AffectedFiles => "Fallout76Prefs.ini";

        public string AffectedValues => "[NuclearWinter]bEnableItemRarityColors";

        public bool DefaultValue => true;

        public string Identifier => this.GetType().FullName;

        public bool GetValue()
        {
            return IniFiles.GetBool("NuclearWinter", "bEnableItemRarityColors", DefaultValue);
        }

        public void SetValue(bool value)
        {
            IniFiles.F76Prefs.Set("NuclearWinter", "bEnableItemRarityColors", value);
        }

        public void ResetValue()
        {
            SetValue(DefaultValue);
        }
    }
}