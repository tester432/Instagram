/*
 * Created by Ranorex
 * User: saxxo
 * Date: 17.07.2020
 * Time: 19:54
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace Instagram.Modules
{
    /// <summary>
    /// Description of SmokeTest.
    /// </summary>
    [TestModule("D4159F86-FA80-4A96-9F5F-BA596228CB0E", ModuleType.UserCode, 1)]
    public class SmokeTest : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SmokeTest()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            // start here
			InstagramRepository repo = InstagramRepository.Instance;
			
			if(InstagramRepository.Instance.ApplicationUnderTest.Login.AnmeldenInfo.Exists ())
            {
            	repo.ApplicationUnderTest.Login.Anmelden.Click();
            }
            else
            {
            	Report.Info("Button ist nicht da");
            }
        }
    }
}
