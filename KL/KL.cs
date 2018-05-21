using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KL
{
    public class KLPage
    {
        // Image ID for this KL image:KLPage
        public int imageId;

        // Caption text for this image:
        public string caption;

        // Returns the ID of the image:
        public int ImageID { get { return imageId; } }

        // Returns the caption text for the image:
        public string Caption { get { return caption; } }
    }

    public class KLCatalog
    {
        // Built-in KL catalog (could be replaced with a database)
        static KLPage[] KLBuiltInCatalog = {
            new KLPage { imageId = Resource.Drawable.f5600,
                           caption = "No.1" },
            new KLPage { imageId = Resource.Drawable.f5710,
                           caption = "No.2" },
            new KLPage { imageId = Resource.Drawable.ltg171,
                           caption = "No.3" },
            new KLPage { imageId = Resource.Drawable.y8111,
                           caption = "No.4" },
            new KLPage { imageId = Resource.Drawable.y240c1,
                           caption = "No.5" },
            new KLPage { imageId = Resource.Drawable.y2cc1,
                           caption = "No.6" },
            new KLPage { imageId = Resource.Drawable.y6060b2,
                           caption = "No.7" },
            new KLPage { imageId = Resource.Drawable.y6060b3,
                           caption = "No.8" },
            new KLPage { imageId = Resource.Drawable.y606al1,
                           caption = "No.9" },
            new KLPage { imageId = Resource.Drawable.A810302,
                           caption = "No.10" },
            new KLPage { imageId = Resource.Drawable.A810602,
                           caption = "No.11" },
            new KLPage { imageId = Resource.Drawable.n200301,
                           caption = "No.12" },
            new KLPage { imageId = Resource.Drawable.n200902,
                           caption = "No.13" },
        };

        // Array of KL pages that make up the catalog:
        private KLPage[] KLPages;

        // Create an instance copy of the built-in KL catalog:
        public KLCatalog() { KLPages = KLBuiltInCatalog; }

        // Indexer (read only) for accessing a KL page:
        public KLPage this[int i] { get { return KLPages[i]; } }

        // Returns the number of KL pages in the catalog:
        public int NumKLs { get { return KLPages.Length; } }
    }


}