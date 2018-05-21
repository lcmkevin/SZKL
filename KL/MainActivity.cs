using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.App;
using PCLStorage;

using Xamarin.Forms.Platform.Android;




namespace KL
{
    [Activity(Label = "KL",  MainLauncher =false , Icon = "@drawable/icon")]
    
    public class MainActivity : FormsAppCompatActivity  // was FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            // set the layout resources first
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabbar;

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            
            KLCatalog KLCatalog = new KLCatalog();
            viewPager.Adapter = new KLPagerAdapter(this, KLCatalog);


            


        }

        
        public override void OnBackPressed()
        {
            Finish();
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }


    }

 
}

