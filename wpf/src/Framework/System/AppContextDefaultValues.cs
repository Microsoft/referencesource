//---------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All rights reserved.
//
// File: AppContextDefaultValues.cs
//---------------------------------------------------------------------------

using MS.Internal;

namespace System
{
    // There are cases where we have multiple assemblies that are going to import this file and
    // if they are going to also have InternalsVisibleTo between them, there will be a compiler warning
    // that the type is found both in the source and in a referenced assembly. The compiler will prefer
    // the version of the type defined in the source
    //
    // In order to disable the warning for this type we are disabling this warning for this entire file.
    #pragma warning disable 436

    internal static partial class AppContextDefaultValues
    {
        static partial void PopulateDefaultValuesPartial(string platformIdentifier, string profile, int targetFrameworkVersion)
        {
            switch (platformIdentifier)
            {
                case ".NETFramework":
                    {
                        if (targetFrameworkVersion <= 40502)
                        {
                            LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.DoNotApplyLayoutRoundingToMarginsAndBorderThicknessSwitchName, true);
                        }
                        if (targetFrameworkVersion <= 40602)
                        {
                            LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.GridStarDefinitionsCanExceedAvailableSpaceSwitchName, true);
                        }
                        if (targetFrameworkVersion <= 40700)
                        {
                            LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.SelectionPropertiesCanLagBehindSelectionChangedEventSwitchName, true);
                        }
                        if (targetFrameworkVersion <= 40701)
                        {
                            LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.DoNotUseFollowParentWhenBindingToADODataRelationSwitchName, true);
                        }
                        if (40000 <= targetFrameworkVersion && targetFrameworkVersion <= 40702)
                        {
                            LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.IListIndexerHidesCustomIndexerSwitchName, true);
                        }
                        if (targetFrameworkVersion <= 40800)
                        {
                            LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.SelectorUpdatesSelectionPropertiesWhenDisconnectedSwitchName, true);
                        }

#if Preserve48Regression_SelectorInDataGridUpdatesSelectionPropertiesWhenDisconnected
                                                // 4.8 shipped with a regression.  Uncommenting this clause would preserve
                                                // the bad behavior for apps targeting 4.8.  However, .NET Servicing
                                                // shiproom decided it's better to fix the behavior.  An app that
                                                // targets 4.8 and depends on the bad behavior can still get it
                                                // by setting the switch to true.
                                                if (targetFrameworkVersion == 40800)
                                                {
                                                    LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.SelectorInDataGridUpdatesSelectionPropertiesWhenDisconnectedSwitchName, true);
                                                }
#endif

// The AppContext  analyzer expects an if statement here, we should have named the switch 'DoNotUseAdorner' and not included this line at all - by default, switches get set to 'false'
// Because this was realized after we shipped, we are going to disable the warning for this switch.
#pragma warning disable BCL0012
                        // DDVSO:405199
                        // The standard behavior is to draw Text/PasswordBox selections via the adorner.
                        // We want this to always be the case unless it is explicity changed, regardless of .NET target version.
                        LocalAppContext.DefineSwitchDefault(FrameworkAppContextSwitches.UseAdornerForTextboxSelectionRenderingSwitchName, true);
#pragma warning restore BCL0012

                        break;
                    }
            }
        }
    }

    #pragma warning restore 436
}
