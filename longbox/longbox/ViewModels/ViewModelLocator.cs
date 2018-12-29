using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace longbox.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            Bootstrap.Initialize();
        }

        public ComicGridViewModel ComicGrid {
            get
            {
                return ServiceLocator.Current.GetInstance<ComicGridViewModel>();
            }
        }
    }
}
