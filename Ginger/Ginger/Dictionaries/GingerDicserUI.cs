using Amdocs.Ginger.Common;
using System.Windows;

namespace Ginger.Dictionaries
{
    public class GingerDicserUI
    {

        public static void LinkToTermResource(FrameworkElement obj, DependencyProperty objPropertyToLink, eTermResKey termResourceKey)
        {
            if (obj != null && objPropertyToLink != null) //&& termResourceKey != null ... termResourceKey is never null
                obj.SetResourceReference(objPropertyToLink, termResourceKey.ToString());
        }

        public static void LinkToResource(FrameworkElement obj, DependencyProperty objPropertyToLink, string resourceKey)
        {
            if (obj != null && objPropertyToLink != null && string.IsNullOrEmpty(resourceKey) == false)
                obj.SetResourceReference(objPropertyToLink, resourceKey);
        }
    }

}
