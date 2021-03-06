﻿using GalaSoft.MvvmLight.Ioc;

namespace TimesheetParser.Business.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register(() => this, true);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CrmLoginViewModel>();
            SimpleIoc.Default.Register<HelpViewModel>();
        }

        public static ViewModelLocator Current => SimpleIoc.Default.GetInstance<ViewModelLocator>();
        public MainViewModel MainVM => SimpleIoc.Default.GetInstance<MainViewModel>();
        public CrmLoginViewModel CrmLoginVM => SimpleIoc.Default.GetInstance<CrmLoginViewModel>();
        public HelpViewModel HelpVM => SimpleIoc.Default.GetInstance<HelpViewModel>();
    }
}