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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("3a2c1244-788f-45c9-8a27-3a5ca63b0b77")]
    public partial class MyTestRepository : RepoGenBaseFolder
    {
        static MyTestRepository instance = new MyTestRepository();
        MyTestRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the MyTestRepository element repository.
        /// </summary>
        [RepositoryFolder("3a2c1244-788f-45c9-8a27-3a5ca63b0b77")]
        public static MyTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTestRepository() 
            : base("MyTestRepository", "/", null, 0, false, "3a2c1244-788f-45c9-8a27-3a5ca63b0b77", ".\\RepositoryImages\\MyTestRepository3a2c1244.rximgres")
        {
            _applicationundertest = new MyTestRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("3a2c1244-788f-45c9-8a27-3a5ca63b0b77")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("0584e134-6a8f-4d7d-8502-f93861241fec")]
        public virtual MyTestRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTestRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("0584e134-6a8f-4d7d-8502-f93861241fec")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _inputtagqInfo;
            RepoItemInfo _halloInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.google.de']", parentFolder, 30000, null, false, "0584e134-6a8f-4d7d-8502-f93861241fec", "")
            {
                _inputtagqInfo = new RepoItemInfo(this, "InputTagQ", ".//input[@title='Suche']", 30000, null, "a45fdeaf-3cf9-4b73-a275-6019f97c5a09");
                _halloInfo = new RepoItemInfo(this, "Hallo", ".//span[@innertext='Hallo']", 30000, null, "970ab529-0d8b-4310-80be-2a16d42fafc0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0584e134-6a8f-4d7d-8502-f93861241fec")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0584e134-6a8f-4d7d-8502-f93861241fec")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The InputTagQ item.
            /// </summary>
            [RepositoryItem("a45fdeaf-3cf9-4b73-a275-6019f97c5a09")]
            public virtual Ranorex.InputTag InputTagQ
            {
                get
                {
                    return _inputtagqInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagQ item info.
            /// </summary>
            [RepositoryItemInfo("a45fdeaf-3cf9-4b73-a275-6019f97c5a09")]
            public virtual RepoItemInfo InputTagQInfo
            {
                get
                {
                    return _inputtagqInfo;
                }
            }

            /// <summary>
            /// The Hallo item.
            /// </summary>
            [RepositoryItem("970ab529-0d8b-4310-80be-2a16d42fafc0")]
            public virtual Ranorex.SpanTag Hallo
            {
                get
                {
                    return _halloInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Hallo item info.
            /// </summary>
            [RepositoryItemInfo("970ab529-0d8b-4310-80be-2a16d42fafc0")]
            public virtual RepoItemInfo HalloInfo
            {
                get
                {
                    return _halloInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
