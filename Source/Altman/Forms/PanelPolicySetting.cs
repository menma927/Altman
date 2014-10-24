﻿using Altman.Resources;
using Altman.Util.Setting;
using Eto.Drawing;
using Eto.Forms;

namespace Altman.Forms
{
	public class PanelPolicySetting : Panel
    {
        private CheckBox _checkBoxIsParamRandom;
        private CheckBox _checkBoxIsShowDisclaimer;

        public PanelPolicySetting()
        {
            Init();
        }

        void Init()
        {
	        _checkBoxIsParamRandom = new CheckBox() {Text = AltStrRes.IsParamRandom};
	        _checkBoxIsShowDisclaimer = new CheckBox() {Text = AltStrRes.IsShowDisclaimer};

            var layout = new DynamicLayout { Padding = new Padding(20, 10), Spacing = new Size(10, 10) };

            layout.AddRow(_checkBoxIsParamRandom);
            layout.AddRow(_checkBoxIsShowDisclaimer);
            layout.Add(null);

            this.Content = layout;
        }
        public void LoadPolicySetting(Setting.PolicyStruct policy)
        {
            _checkBoxIsParamRandom.Checked = policy.IsParamRandom;
            _checkBoxIsShowDisclaimer.Checked = policy.IsShowDisclaimer;
        }
        public Setting.PolicyStruct SavePolicySetting()
        {
            var policy = new Setting.PolicyStruct();
            policy.IsParamRandom = _checkBoxIsParamRandom.Checked==true;
            policy.IsShowDisclaimer = _checkBoxIsShowDisclaimer.Checked==true;
            return policy;
        }
    }
}