/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using Behaviac.Design.Nodes;
using Behaviac.Design.Attributes;
using PluginBehaviac.Properties;

namespace Behaviac.Design.ObjectUI
{
    public class AlwaysTransitionUIPolicy : ObjectUIPolicy
    {
        public override void Update(object sender, DesignerPropertyInfo property)
        {
            if (_obj != null)
            {
                DesignerPropertyEditor statusPhaseEditor = GetEditor(_obj, "TransitionPhase");
                Debug.Check(statusPhaseEditor != null);

                PluginBehaviac.Events.AlwaysTransition at = this._obj as PluginBehaviac.Events.AlwaysTransition;
                if (at.Node is PluginBehaviac.Nodes.FSMReferencedBehavior)
                {
                    //
                }
                else
                {
                    statusPhaseEditor.Enabled = false;

                    //ResultOption is set to be SUCCESS by default
                    SetProperty(_obj, "TransitionPhase", PluginBehaviac.Events.ETransitionPhase.ETP_Always);
                }
            }
        }

    }
}
