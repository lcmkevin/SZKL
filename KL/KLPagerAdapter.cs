using System;
using Android.App;
using Android.Runtime;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View;
using Java.Lang;

namespace KL
{
    class KLPagerAdapter : PagerAdapter
    {
        Context context;
        KLCatalog KLCatalog;

        public KLPagerAdapter(Context context, KLCatalog KLCatalog)
        {
            this.context = context;
            this.KLCatalog = KLCatalog;
        }

        public override int Count
        {
            get { return KLCatalog.NumKLs; }
        }

        /*IsViewFromObject must be implemented for PagerAdapter to function properly. 
         * If IsViewFromObject returns false for a given position, ViewPager will not display 
         * the view at that position. In the TreePager app, the object key returned by 
         * InstantiateItem is the page View of a tree, so the code only has to check for 
         * identity (i.e, the object key and the view are one and the same). 
        
        */
        public override bool IsViewFromObject(View view, Java.Lang.Object obj)
        {
            return view == obj;
        }

#pragma warning disable CS0672 // Member overrides obsolete member
        public override Java.Lang.Object InstantiateItem (View container, int position)
#pragma warning restore CS0672 // Member overrides obsolete member
        {
            var imageView = new ImageView(context);
            imageView.SetImageResource(KLCatalog[position].imageId);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(imageView);
            return imageView;
        }

#pragma warning disable CS0672 // Member overrides obsolete member
        public override void DestroyItem(View container, int position, Java.Lang.Object view)
#pragma warning restore CS0672 // Member overrides obsolete member
        {
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.RemoveView(view as View);
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(KLCatalog[position].caption);

        }
        
    }
}
 