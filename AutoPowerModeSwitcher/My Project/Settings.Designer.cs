// ------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// Runtime Version:4.0.30319.42000
// 
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace AutoPowerModeSwitcher.My
{

    [CompilerGenerated()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    internal sealed partial class MySettings : System.Configuration.ApplicationSettingsBase
    {

        private static MySettings defaultInstance = (MySettings)Synchronized(new MySettings());

        #region My.Settings Auto-Save Functionality
        /* TODO ERROR: Skipped IfDirectiveTrivia
        #If _MyType = "WindowsForms" Then
        */
        private static bool addedHandler;

        private static object addedHandlerLockObject = new object();

        [DebuggerNonUserCode()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }
        /* TODO ERROR: Skipped EndIfDirectiveTrivia
        #End If
        */
        #endregion

        public static MySettings Default
        {
            get
            {

                /* TODO ERROR: Skipped IfDirectiveTrivia
                #If _MyType = "WindowsForms" Then
                */
                if (!addedHandler)
                {
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.Shutdown += AutoSaveSettings;
                            addedHandler = true;
                        }
                    }
                }
                /* TODO ERROR: Skipped EndIfDirectiveTrivia
                #End If
                */
                return defaultInstance;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool PreferredPowerModeEqualsBalanced
        {
            get
            {
                return Conversions.ToBoolean(this["PreferredPowerModeEqualsBalanced"]);
            }
            set
            {
                this["PreferredPowerModeEqualsBalanced"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool GamingPowerModeEquals70Freq
        {
            get
            {
                return Conversions.ToBoolean(this["GamingPowerModeEquals70Freq"]);
            }
            set
            {
                this["GamingPowerModeEquals70Freq"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool CheckInvertalEqualsFrequent
        {
            get
            {
                return Conversions.ToBoolean(this["CheckInvertalEqualsFrequent"]);
            }
            set
            {
                this["CheckInvertalEqualsFrequent"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("GTA5")]
        public string TargetProcess
        {
            get
            {
                return Conversions.ToString(this["TargetProcess"]);
            }
            set
            {
                this["TargetProcess"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool StartOnBootEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["StartOnBootEnabled"]);
            }
            set
            {
                this["StartOnBootEnabled"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool StartMinimized
        {
            get
            {
                return Conversions.ToBoolean(this["StartMinimized"]);
            }
            set
            {
                this["StartMinimized"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool TopMost
        {
            get
            {
                return Conversions.ToBoolean(this["TopMost"]);
            }
            set
            {
                this["TopMost"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool AutoPilotEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["AutoPilotEnabled"]);
            }
            set
            {
                this["AutoPilotEnabled"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool CoreEngineModeEqualsOptimized
        {
            get
            {
                return Conversions.ToBoolean(this["CoreEngineModeEqualsOptimized"]);
            }
            set
            {
                this["CoreEngineModeEqualsOptimized"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("ca366f9a-4ace-4337-b948-5b196e337c7d")]
        public string LowFreqGUID
        {
            get
            {
                return Conversions.ToString(this["LowFreqGUID"]);
            }
            set
            {
                this["LowFreqGUID"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool FirstTimeClosing
        {
            get
            {
                return Conversions.ToBoolean(this["FirstTimeClosing"]);
            }
            set
            {
                this["FirstTimeClosing"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool UserTrackingEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["UserTrackingEnabled"]);
            }
            set
            {
                this["UserTrackingEnabled"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool TaskManagerEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["TaskManagerEnabled"]);
            }
            set
            {
                this["TaskManagerEnabled"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool TaskManagerWarningRemoved
        {
            get
            {
                return Conversions.ToBoolean(this["TaskManagerWarningRemoved"]);
            }
            set
            {
                this["TaskManagerWarningRemoved"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool TaskManagerRestartAfterSession
        {
            get
            {
                return Conversions.ToBoolean(this["TaskManagerRestartAfterSession"]);
            }
            set
            {
                this["TaskManagerRestartAfterSession"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool BootManagerEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["BootManagerEnabled"]);
            }
            set
            {
                this["BootManagerEnabled"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool NoImpactEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["NoImpactEnabled"]);
            }
            set
            {
                this["NoImpactEnabled"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool TaskManagerPrioritize
        {
            get
            {
                return Conversions.ToBoolean(this["TaskManagerPrioritize"]);
            }
            set
            {
                this["TaskManagerPrioritize"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool EnableExperimentalFeatures
        {
            get
            {
                return Conversions.ToBoolean(this["EnableExperimentalFeatures"]);
            }
            set
            {
                this["EnableExperimentalFeatures"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("LegacySetting")]
        public string TrackU
        {
            get
            {
                return Conversions.ToString(this["TrackU"]);
            }
            set
            {
                this["TrackU"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("0")]
        public string ApplicationStatupMesurementValue1
        {
            get
            {
                return Conversions.ToString(this["ApplicationStatupMesurementValue1"]);
            }
            set
            {
                this["ApplicationStatupMesurementValue1"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("0")]
        public string ApplicationStatupMesurementValue2
        {
            get
            {
                return Conversions.ToString(this["ApplicationStatupMesurementValue2"]);
            }
            set
            {
                this["ApplicationStatupMesurementValue2"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool DisableCoreForm
        {
            get
            {
                return Conversions.ToBoolean(this["DisableCoreForm"]);
            }
            set
            {
                this["DisableCoreForm"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool GroupPolicyForceAutoPilot
        {
            get
            {
                return Conversions.ToBoolean(this["GroupPolicyForceAutoPilot"]);
            }
            set
            {
                this["GroupPolicyForceAutoPilot"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool DisableLegacyServices
        {
            get
            {
                return Conversions.ToBoolean(this["DisableLegacyServices"]);
            }
            set
            {
                this["DisableLegacyServices"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("GTA5")]
        public string DefaultTargetProcess
        {
            get
            {
                return Conversions.ToString(this["DefaultTargetProcess"]);
            }
            set
            {
                this["DefaultTargetProcess"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("1")]
        public byte PreferredCPUModeAsByte
        {
            get
            {
                return Conversions.ToByte(this["PreferredCPUModeAsByte"]);
            }
            set
            {
                this["PreferredCPUModeAsByte"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool AllowPowermodeControl
        {
            get
            {
                return Conversions.ToBoolean(this["AllowPowermodeControl"]);
            }
            set
            {
                this["AllowPowermodeControl"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool DisableDeveloperDetectorService
        {
            get
            {
                return Conversions.ToBoolean(this["DisableDeveloperDetectorService"]);
            }
            set
            {
                this["DisableDeveloperDetectorService"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("IDLE")]
        public string ApplicationSELFPriority
        {
            get
            {
                return Conversions.ToString(this["ApplicationSELFPriority"]);
            }
            set
            {
                this["ApplicationSELFPriority"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool DisableLegacyCheckboxStyleDetectionSystem
        {
            get
            {
                return Conversions.ToBoolean(this["DisableLegacyCheckboxStyleDetectionSystem"]);
            }
            set
            {
                this["DisableLegacyCheckboxStyleDetectionSystem"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("UserPreferencesModule")]
        public string DEBUG_StartingForm
        {
            get
            {
                return Conversions.ToString(this["DEBUG_StartingForm"]);
            }
            set
            {
                this["DEBUG_StartingForm"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool DisableSizeChangedEventChecks
        {
            get
            {
                return Conversions.ToBoolean(this["DisableSizeChangedEventChecks"]);
            }
            set
            {
                this["DisableSizeChangedEventChecks"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("180")]
        public int UI_DefaultHeight
        {
            get
            {
                return Conversions.ToInteger(this["UI_DefaultHeight"]);
            }
            set
            {
                this["UI_DefaultHeight"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("313")]
        public int UI_DefaultWidth
        {
            get
            {
                return Conversions.ToInteger(this["UI_DefaultWidth"]);
            }
            set
            {
                this["UI_DefaultWidth"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("1750")]
        public int CheckPowerPlanInterval
        {
            get
            {
                return Conversions.ToInteger(this["CheckPowerPlanInterval"]);
            }
            set
            {
                this["CheckPowerPlanInterval"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("1")]
        public string FastCheckConditionCheckPowerModeEngineInterval
        {
            get
            {
                return Conversions.ToString(this["FastCheckConditionCheckPowerModeEngineInterval"]);
            }
            set
            {
                this["FastCheckConditionCheckPowerModeEngineInterval"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool RedirectConsoleToFile
        {
            get
            {
                return Conversions.ToBoolean(this["RedirectConsoleToFile"]);
            }
            set
            {
                this["RedirectConsoleToFile"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool FlushConsoleAtStartup
        {
            get
            {
                return Conversions.ToBoolean(this["FlushConsoleAtStartup"]);
            }
            set
            {
                this["FlushConsoleAtStartup"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("Balanced")]
        public string LastCpuModeFriendlyName
        {
            get
            {
                return Conversions.ToString(this["LastCpuModeFriendlyName"]);
            }
            set
            {
                this["LastCpuModeFriendlyName"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool AllowQuit
        {
            get
            {
                return Conversions.ToBoolean(this["AllowQuit"]);
            }
            set
            {
                this["AllowQuit"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("529")]
        public string UI_MaxHeight
        {
            get
            {
                return Conversions.ToString(this["UI_MaxHeight"]);
            }
            set
            {
                this["UI_MaxHeight"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("316")]
        public string UI_MaxWidth
        {
            get
            {
                return Conversions.ToString(this["UI_MaxWidth"]);
            }
            set
            {
                this["UI_MaxWidth"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("180")]
        public string UI_MinHeight
        {
            get
            {
                return Conversions.ToString(this["UI_MinHeight"]);
            }
            set
            {
                this["UI_MinHeight"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool SafemodeEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["SafemodeEnabled"]);
            }
            set
            {
                this["SafemodeEnabled"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("This is where all the application settings stored. You may manually override any " + "value but changing values may cause application to crash or have serious issues." + " Proceed with caution. Before changing any values, please make sure the APMS app" + "lication has quit. ")]



        public string AboutThisFile
        {
            get
            {
                return Conversions.ToString(this["AboutThisFile"]);
            }
            set
            {
                this["AboutThisFile"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public bool enableGameDetection
        {
            get
            {
                return Conversions.ToBoolean(this["enableGameDetection"]);
            }
            set
            {
                this["enableGameDetection"] = value;
            }
        }
    }
}

namespace AutoPowerModeSwitcher.My
{

    [HideModuleName()]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal static class MySettingsProperty
    {

        [System.ComponentModel.Design.HelpKeyword("My.Settings")]
        internal static MySettings Settings
        {
            get
            {
                return MySettings.Default;
            }
        }
    }
}