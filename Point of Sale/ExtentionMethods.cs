using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;


namespace Point_of_Sale.ExtentionMethods
{
    public static class ExtentionMethods
    {
        public static T FindAncestor<T>(this DependencyObject element) where T:DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}
