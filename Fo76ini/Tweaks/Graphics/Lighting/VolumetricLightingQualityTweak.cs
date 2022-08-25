﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fo76ini.Tweaks.Graphics
{
    class VolumetricLightingQualityTweak : ITweak<int>, ITweakInfo
    {
        public string Description => "Changes the quality/clarity of god rays / light shafts.\nRecommended setting: 2 (High)";

        public WarnLevel WarnLevel => WarnLevel.None;

        public string AffectedFiles => "Fallout76Prefs.ini";

        public string AffectedValues => "[Display]iVolumetricLightingTextureQuality";

        public int DefaultValue => 1;

        public string Identifier => this.GetType().FullName;
        
        public bool UIReloadNecessary => true;

        public int GetValue()
        {
            return IniFiles.GetInt("Display", "iVolumetricLightingTextureQuality", DefaultValue);
        }

        public void SetValue(int value)
        {
            IniFiles.F76Prefs.Set("Display", "iVolumetricLightingTextureQuality", value);
        }

        public void ResetValue()
        {
            SetValue(DefaultValue);
        }
    }
}
