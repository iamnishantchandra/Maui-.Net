using MauiTutorial.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiTutorial.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ClothViewModel
    {
        public ObservableCollection<Cloth> Products { get; set; } = new ObservableCollection<Cloth>();
        public bool IsRefresh { get; set; }
        public ICommand RefreshCommand => new Command(async ()=>{
            IsRefresh = true;
            await Task.Delay(2000);
            RefreshItems(Products.Count);
            IsRefresh = false;
        });
        public ICommand ReachedCommand => new Command(async ()=>{
            
            RefreshItems(Products.Count);
        });
        public ICommand DeleteCommand => new Command(async ()=>{
            
            RefreshItems(Products.Count);
        });
        public ClothViewModel()
        {
            RefreshItems();
        }
        private void RefreshItems(int lastItem=0)
        {
            //Products = new ObservableCollection<Cloth>();
            var ItemPerPage = 3;
            var Items= new ObservableCollection<Cloth>()
            {
                new Cloth
                {
                    Title = "Yellow T-Shirt",
                    Price = 12.0m,
                    Image ="a1.png",
                    HasOffer = true,
                    OfferPrice = 10.2m,
                },
                new Cloth
                {
                    Title = "White T-Shirt",
                    Price = 7.0m,
                    Image ="b2.png",
                    HasOffer = false,
                    OfferPrice = 0m
                },
                new Cloth
                {
                    Title = "Grey T-Shirt",
                    Price = 17.0m,
                    Image ="c3.png",
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Cloth
                {
                    Title = "Red T-Shirt",
                    Price = 11.0m,
                    Image ="d4.png",
                    HasOffer = false,
                    OfferPrice = 10.2m
                },
                new Cloth
                {
                    Title = "Black T-Shirt",
                    Price = 14.0m,
                    Image ="e5.png",
                    HasOffer = false,
                    OfferPrice = 10.2m
                },
                new Cloth
                {
                    Title = "Pink T-Shirt",
                    Price = 13.0m,
                    Image ="f6.png",
                    HasOffer = true,
                    OfferPrice = 11.2m
                },
                new Cloth
                {
                    Title = "Green T-Shirt",
                    Price = 18.0m,
                    Image ="g7.png",
                    HasOffer = true,
                    OfferPrice = 12.2m
                }
            };
            var PageItems = Items.Skip(lastItem).Take(ItemPerPage);
            foreach (var item in PageItems)
            {
                Products.Add(item);

            }
        }

    }
}
