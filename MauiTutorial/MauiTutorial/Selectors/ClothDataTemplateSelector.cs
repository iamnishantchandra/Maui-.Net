using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiTutorial.MVVM.Models;

namespace MauiTutorial.Selectors
{
    public class ClothDataTemplateSelector : DataTemplateSelector

    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Cloth = item as Cloth;
            if (!Cloth.HasOffer) {
                Application.Current.Resources.TryGetValue("ClothRes", out var clothRes);
                return clothRes as DataTemplate;
            }
            if (Cloth.HasOffer) {
                Application.Current.Resources.TryGetValue("OfferCloth", out var offerCloth);
                return offerCloth as DataTemplate;
            }
            return new DataTemplate();

        }
    }
}
