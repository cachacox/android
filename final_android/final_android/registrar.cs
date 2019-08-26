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

namespace final_android
{
    [Activity(Label = "registrar")]
    public class registrar : Activity
    {
        int intSexo = 0;
        int intkilos = 0;
        int intFrecuencia = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.registrar);

            Spinner sp1 = FindViewById<Spinner>(Resource.Id.spin1);
            sp1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spin1_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.sexo_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            sp1.Adapter = adapter;

            Spinner sp2 = FindViewById<Spinner>(Resource.Id.spin1);
            sp2.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spin2_ItemSelected);
            var adapter1 = ArrayAdapter.CreateFromResource(this, Resource.Array.sexo_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            sp2.Adapter = adapter1;

            Spinner sp3 = FindViewById<Spinner>(Resource.Id.spin1);
            sp3.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spin3_ItemSelected);
            var adapter2 = ArrayAdapter.CreateFromResource(this, Resource.Array.sexo_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            sp3.Adapter = adapter2;
        }

        private void spin1_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            intSexo = e.Position + 1;
        }

        private void spin2_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            intkilos = e.Position + 1;
        }

        private void spin3_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            intFrecuencia = e.Position + 1;
        }
    }
}