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

namespace Instagram.Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Registration recording.
    /// </summary>
    [TestModule("82a0a94c-c65d-4fdf-bfa8-36e8cbe2bbc2", ModuleType.Recording, 1)]
    public partial class Registration : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Instagram.InstagramRepository repository.
        /// </summary>
        public static global::Instagram.InstagramRepository repo = global::Instagram.InstagramRepository.Instance;

        static Registration instance = new Registration();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Registration()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Registration Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Registration.Page_1.Registrieren' at Center.", repo.ApplicationUnderTest.Registration.Page_1.RegistrierenInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Registration.Page_1.Registrieren.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Registration.Page_1.EmailOrPhone' at Center.", repo.ApplicationUnderTest.Registration.Page_1.EmailOrPhoneInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Registration.Page_1.EmailOrPhone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ranorex001@firemail.de' with focus on 'ApplicationUnderTest.Registration.Page_1.EmailOrPhone'.", repo.ApplicationUnderTest.Registration.Page_1.EmailOrPhoneInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Registration.Page_1.EmailOrPhone.PressKeys("ranorex001@firemail.de");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Registration.Page_1.FullName' at Center.", repo.ApplicationUnderTest.Registration.Page_1.FullNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Registration.Page_1.FullName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Ranorex Tester' with focus on 'ApplicationUnderTest.Registration.Page_1.FullName'.", repo.ApplicationUnderTest.Registration.Page_1.FullNameInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Registration.Page_1.FullName.PressKeys("Ranorex Tester");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Login.Username' at Center.", repo.ApplicationUnderTest.Login.UsernameInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Login.Username.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Ranorex001' with focus on 'ApplicationUnderTest.Login.Username'.", repo.ApplicationUnderTest.Login.UsernameInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Login.Username.PressKeys("Ranorex001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Login.Password' at Center.", repo.ApplicationUnderTest.Login.PasswordInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Login.Password.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'rAnOrEx111' with focus on 'ApplicationUnderTest.Login.Password'.", repo.ApplicationUnderTest.Login.PasswordInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Login.Password.PressKeys("rAnOrEx111");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Registration.Page_1.Weiter' at Center.", repo.ApplicationUnderTest.Registration.Page_1.WeiterInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Registration.Page_1.Weiter.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '9' on item 'ApplicationUnderTest.Registration.Page_2.Monat'.", repo.ApplicationUnderTest.Registration.Page_2.MonatInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Registration.Page_2.Monat.Element.SetAttributeValue("TagValue", "9");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item 'ApplicationUnderTest.Registration.Page_2.Tag'.", repo.ApplicationUnderTest.Registration.Page_2.TagInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Registration.Page_2.Tag.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2001' on item 'ApplicationUnderTest.Registration.Page_2.Jahr'.", repo.ApplicationUnderTest.Registration.Page_2.JahrInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Registration.Page_2.Jahr.Element.SetAttributeValue("TagValue", "2001");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Registration.Page_1.Weiter' at Center.", repo.ApplicationUnderTest.Registration.Page_1.WeiterInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Registration.Page_1.Weiter.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '056284' with focus on 'ApplicationUnderTest.Registration.Page_3.EmailConfirmationCode'.", repo.ApplicationUnderTest.Registration.Page_3.EmailConfirmationCodeInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Registration.Page_3.EmailConfirmationCode.PressKeys("056284");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Registration.Page_1.Weiter' at Center.", repo.ApplicationUnderTest.Registration.Page_1.WeiterInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.Registration.Page_1.Weiter.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
