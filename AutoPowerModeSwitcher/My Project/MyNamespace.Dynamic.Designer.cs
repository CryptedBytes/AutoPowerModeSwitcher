using System;
using System.ComponentModel;
using System.Diagnostics;

namespace AutoPowerModeSwitcher.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AutoPilotPopup m_AutoPilotPopup;

            public AutoPilotPopup AutoPilotPopup
            {
                [DebuggerHidden]
                get
                {
                    m_AutoPilotPopup = Create__Instance__(m_AutoPilotPopup);
                    return m_AutoPilotPopup;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AutoPilotPopup))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AutoPilotPopup);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public AutoPowerSwitcher m_AutoPowerSwitcher;

            public AutoPowerSwitcher AutoPowerSwitcher
            {
                [DebuggerHidden]
                get
                {
                    m_AutoPowerSwitcher = Create__Instance__(m_AutoPowerSwitcher);
                    return m_AutoPowerSwitcher;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AutoPowerSwitcher))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AutoPowerSwitcher);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public BootManager m_BootManager;

            public BootManager BootManager
            {
                [DebuggerHidden]
                get
                {
                    m_BootManager = Create__Instance__(m_BootManager);
                    return m_BootManager;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BootManager))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BootManager);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public BootManagerUXPort m_BootManagerUXPort;

            public BootManagerUXPort BootManagerUXPort
            {
                [DebuggerHidden]
                get
                {
                    m_BootManagerUXPort = Create__Instance__(m_BootManagerUXPort);
                    return m_BootManagerUXPort;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BootManagerUXPort))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BootManagerUXPort);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public CoreForm m_CoreForm;

            public CoreForm CoreForm
            {
                [DebuggerHidden]
                get
                {
                    m_CoreForm = Create__Instance__(m_CoreForm);
                    return m_CoreForm;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CoreForm))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CoreForm);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Debugging m_Debugging;

            public Debugging Debugging
            {
                [DebuggerHidden]
                get
                {
                    m_Debugging = Create__Instance__(m_Debugging);
                    return m_Debugging;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Debugging))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Debugging);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public DebugUI m_DebugUI;

            public DebugUI DebugUI
            {
                [DebuggerHidden]
                get
                {
                    m_DebugUI = Create__Instance__(m_DebugUI);
                    return m_DebugUI;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DebugUI))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DebugUI);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public GameList m_GameList;

            public GameList GameList
            {
                [DebuggerHidden]
                get
                {
                    m_GameList = Create__Instance__(m_GameList);
                    return m_GameList;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GameList))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GameList);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public InstallerModule m_InstallerModule;

            public InstallerModule InstallerModule
            {
                [DebuggerHidden]
                get
                {
                    m_InstallerModule = Create__Instance__(m_InstallerModule);
                    return m_InstallerModule;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_InstallerModule))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_InstallerModule);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public MemoryLeakTestingLab m_MemoryLeakTestingLab;

            public MemoryLeakTestingLab MemoryLeakTestingLab
            {
                [DebuggerHidden]
                get
                {
                    m_MemoryLeakTestingLab = Create__Instance__(m_MemoryLeakTestingLab);
                    return m_MemoryLeakTestingLab;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MemoryLeakTestingLab))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MemoryLeakTestingLab);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public PreBootManager m_PreBootManager;

            public PreBootManager PreBootManager
            {
                [DebuggerHidden]
                get
                {
                    m_PreBootManager = Create__Instance__(m_PreBootManager);
                    return m_PreBootManager;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_PreBootManager))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_PreBootManager);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public SettingsDatabase m_SettingsDatabase;

            public SettingsDatabase SettingsDatabase
            {
                [DebuggerHidden]
                get
                {
                    m_SettingsDatabase = Create__Instance__(m_SettingsDatabase);
                    return m_SettingsDatabase;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SettingsDatabase))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SettingsDatabase);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public UserInterface m_UserInterface;

            public UserInterface UserInterface
            {
                [DebuggerHidden]
                get
                {
                    m_UserInterface = Create__Instance__(m_UserInterface);
                    return m_UserInterface;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UserInterface))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UserInterface);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public UserPreferencesModule m_UserPreferencesModule;

            public UserPreferencesModule UserPreferencesModule
            {
                [DebuggerHidden]
                get
                {
                    m_UserPreferencesModule = Create__Instance__(m_UserPreferencesModule);
                    return m_UserPreferencesModule;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UserPreferencesModule))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UserPreferencesModule);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public VisualStudioDetector m_VisualStudioDetector;

            public VisualStudioDetector VisualStudioDetector
            {
                [DebuggerHidden]
                get
                {
                    m_VisualStudioDetector = Create__Instance__(m_VisualStudioDetector);
                    return m_VisualStudioDetector;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_VisualStudioDetector))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_VisualStudioDetector);
                }
            }

        }


    }
}