using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLE.Client.ViewModels;
using MvvmCross.Forms.Views;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace BLE.Client.Pages
{
    public partial class DescriptorDetailPage : MvxContentPage<DescriptorDetailViewModel>
    {
        public DescriptorDetailPage()
        {
            InitializeComponent();
        }
    }
}
