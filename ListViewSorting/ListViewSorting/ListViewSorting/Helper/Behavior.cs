using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListViewSample
{
   public class Behavior : Behavior<SfListView>
    {
        SfListView listView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            listView = bindable;
            //listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            //{
            //    PropertyName = "DateOfBirth",
            //    KeySelector = (object obj1) =>
            //    {
            //        var item = (obj1 as Contacts);
            //        return item.DateOfBirth.Year + "/" + item.DateOfBirth.Month;
            //    },
            //    Comparer = new CustomGroupComparer()
            //});

            listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "DateOfBirth",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as Contacts);
                    return item.DateOfBirth.Year;
                },
            });

            this.listView.DataSource.SortDescriptors.Add(new SortDescriptor()
            {
                PropertyName = "DateOfBirth",
                Direction = ListSortDirection.Ascending
            });

            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(SfListView bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
