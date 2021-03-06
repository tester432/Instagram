﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GoogleSearch recording.
    /// </summary>
    [TestModule("1dc30916-32d3-4f43-83cf-4175109c3b10", ModuleType.Recording, 1)]
    public partial class GoogleSearch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static GoogleSearch instance = new GoogleSearch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GoogleSearch()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GoogleSearch Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InputTagQ' at 50;13.", repo.ApplicationUnderTest.InputTagQInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.InputTagQ.Click("50;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Hallo' with focus on 'ApplicationUnderTest.InputTagQ'.", repo.ApplicationUnderTest.InputTagQInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.InputTagQ.PressKeys("Hallo");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.InputTagQ'.", repo.ApplicationUnderTest.InputTagQInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.InputTagQ.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Hallo') on item 'ApplicationUnderTest.Hallo'.", repo.ApplicationUnderTest.HalloInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.HalloInfo, "InnerText", "Hallo");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
