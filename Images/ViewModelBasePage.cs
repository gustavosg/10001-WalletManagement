// -------------------------------------------------------------------------------
//  Sistema: WalletManagement
//
//
//
// -------------------------------------------------------------------------------
//
//
//
//
// -------------------------------------------------------------------------------

#region References

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

#endregion

namespace Images
{
    public class ViewModelBasePage : INotifyPropertyChanged
    {
        #region fields

        #endregion

        #region Methods

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        #endregion


    }
}
