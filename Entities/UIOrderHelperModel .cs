using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class UIOrderHelperModel<U,V,W>
    {
        public U ProductModel { set; get; }
        public V ImageDictionary { set; get; }

        public W ItemModel { set; get; }
    }
}
