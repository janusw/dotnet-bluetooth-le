using BLE.Client.ViewModels;
using MvvmCross.Forms.Views;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace BLE.Client.Pages
{
    public partial class CharacteristicListPage : MvxContentPage<CharacteristicListViewModel>
    {
        public CharacteristicListPage()
        {
            InitializeComponent();
        }
    }
}
