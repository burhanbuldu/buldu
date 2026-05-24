using System.ComponentModel;
using System.Text.RegularExpressions;

namespace UyeKayit
{
    public class Uye : INotifyPropertyChanged, IDataErrorInfo
    {
        private string ad;
        private string mail;

        public string Ad
        {
            get => ad;
            set
            {
                ad = value;
                OnPropertyChanged("Ad");
            }
        }

        public string Mail
        {
            get => mail;
            set
            {
                mail = value;
                OnPropertyChanged("Mail");
            }
        }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                string desen = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";

                if (columnName == "Mail")
                {
                    // 🔥 BOŞKEN HİÇBİR ŞEY YAPMA → YAZIYI ENGELLEMEYİ ÖNLER
                    if (string.IsNullOrWhiteSpace(Mail))
                        return null;

                    if (!Regex.IsMatch(Mail, desen))
                        return "Geçersiz mail";
                }

                return null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}