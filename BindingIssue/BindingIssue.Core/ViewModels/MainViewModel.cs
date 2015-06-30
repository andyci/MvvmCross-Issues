// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the MainViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace BindingIssue.Core.ViewModels
{
    using System.Collections.Generic;
    using System.Windows.Input;
    using Cirrious.MvvmCross.ViewModels;

    /// <summary>
    /// Define the MainViewModel type.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private List<RadioItem> _list1 = new List<RadioItem>() {
            new RadioItem()
            {
             Caption = "1"
            },
            new RadioItem()
            {
                Caption = "2"
            }
        };
        private List<RadioItem> _list2 = new List<RadioItem>() {
            new RadioItem()
            {
             Caption = "3"
            },
            new RadioItem()
            {
                Caption = "4"
            }
        };

        public List<RadioItem> List1
        {
            get
            {
                return this._list1;
            }
            set
            {
                SetProperty(ref this._list1, value, () => this.List1);
            }
        }

        public List<RadioItem> List2
        {
            get
            {
                return this._list2;
            }
            set
            {
                SetProperty(ref this._list2, value, () => this.List2);
            }
        }
    }
}
