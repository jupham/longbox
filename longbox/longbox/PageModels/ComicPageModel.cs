using longbox.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace longbox.PageModels
{
    public class ComicPageModel : FreshMvvm.FreshBasePageModel
    {
        public Comic Comic { get; set; }

        public ComicPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Comic = initData as Comic;
        }
    }
}
