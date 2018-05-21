package md522d2b011f9f0499c1754ac916ad67dd4;

import android.content.Context;
import android.util.AttributeSet;
import java.util.ArrayList;
import md5c5510fb570626202b808856dc0965f84.ArtinaCustomFontLabelRenderer;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class CustomFontLabelRenderer extends ArtinaCustomFontLabelRenderer implements IGCUserPeer {
    public static final String __md_methods = "";
    private ArrayList refList;

    static {
        Runtime.register("UXDivers.Artina.Grial.CustomFontLabelRenderer, UXDivers.Artinal.Grial.Droid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", CustomFontLabelRenderer.class, __md_methods);
    }

    public CustomFontLabelRenderer(Context context, AttributeSet attributeSet, int i) throws Throwable {
        super(context, attributeSet, i);
        if (getClass() == CustomFontLabelRenderer.class) {
            TypeManager.Activate("UXDivers.Artina.Grial.CustomFontLabelRenderer, UXDivers.Artinal.Grial.Droid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new Object[]{context, attributeSet, Integer.valueOf(i)});
        }
    }

    public CustomFontLabelRenderer(Context context, AttributeSet attributeSet) throws Throwable {
        super(context, attributeSet);
        if (getClass() == CustomFontLabelRenderer.class) {
            TypeManager.Activate("UXDivers.Artina.Grial.CustomFontLabelRenderer, UXDivers.Artinal.Grial.Droid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new Object[]{context, attributeSet});
        }
    }

    public CustomFontLabelRenderer(Context context) throws Throwable {
        super(context);
        if (getClass() == CustomFontLabelRenderer.class) {
            TypeManager.Activate("UXDivers.Artina.Grial.CustomFontLabelRenderer, UXDivers.Artinal.Grial.Droid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new Object[]{context});
        }
    }

    public void monodroidAddReference(Object obj) {
        if (this.refList == null) {
            this.refList = new ArrayList();
        }
        this.refList.add(obj);
    }

    public void monodroidClearReferences() {
        if (this.refList != null) {
            this.refList.clear();
        }
    }
}
