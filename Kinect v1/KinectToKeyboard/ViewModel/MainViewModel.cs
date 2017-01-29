using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using VitruviusTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace VitruviusTest.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            AddCommand = new RelayCommand(cmdAdd);
            ListColorKeys = new List<ColorKey>();
        }

        private void cmdAdd()
        {
            ListColorKeys.Add(SelectedColorKey);
        }

        List<ColorKey> _listColorKeys;
        public List<ColorKey> ListColorKeys
        {
            get
            {
                return _listColorKeys;
            }
            set
            {
                _listColorKeys = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }

        public ColorKey SelectedColorKey { get; set; }


    }
}
