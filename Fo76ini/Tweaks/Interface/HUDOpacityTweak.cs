﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fo76ini.Tweaks.Interface
{
    class HUDOpacityTweak : ITweak<float>, ITweakInfo
    {
        public string Description => "";

        public WarnLevel WarnLevel => WarnLevel.None;

        public string AffectedFiles => "Fallout76Prefs.ini";

        public string AffectedValues => "[MAIN]fHUDOpacity";

        public float DefaultValue => 1.0f;

        public string Identifier => this.GetType().FullName;
        
        public bool UIReloadNecessary => false;

        public float GetValue()
        {
            return IniFiles.GetFloat("MAIN", "fHUDOpacity", DefaultValue);
        }

        public void SetValue(float value)
        {
            IniFiles.F76Prefs.Set("MAIN", "fHUDOpacity", value);
        }

        public void ResetValue()
        {
            SetValue(DefaultValue);
        }
    }
}
