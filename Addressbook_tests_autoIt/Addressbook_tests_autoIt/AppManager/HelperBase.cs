﻿using AutoItX3Lib;

namespace Addressbook_tests_autoIt
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected string WINTITLE;
        protected AutoItX3 aux;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            this.aux = manager.Aux;
            WINTITLE = ApplicationManager.WINTITLE;
        }
    }
}