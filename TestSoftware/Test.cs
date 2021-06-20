using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TestSoftware
{
    public class Test : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string testName;
        public string TestName
        {
            get => testName;
            set { testName = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TestName")); }
        }

        private string otazka1;
        public string Otazka1
        {
            get => otazka1;
            set { otazka1 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Otazka1")); }
        }

        private string otazka2;
        public string Otazka2
        {
            get => otazka2;
            set { otazka2 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Otazka2")); }
        }

        private string otazka3;
        public string Otazka3
        {
            get => otazka3;
            set { otazka3 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Otazka3")); }
        }

        private string otazka4;
        public string Otazka4
        {
            get => otazka4;
            set { otazka4 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Otazka4")); }
        }

        private string odpoved1A;
        public string Odpoved1A
        {
            get => odpoved1A;
            set { odpoved1A = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved1A")); }
        }

        private string odpoved1B;
        public string Odpoved1B
        {
            get => odpoved1B;
            set { odpoved1B = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved1B")); }
        }

        private string odpoved1C;
        public string Odpoved1C
        {
            get => odpoved1C;
            set { odpoved1C = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved1C")); }
        }

        private string odpoved1D;
        public string Odpoved1D
        {
            get => odpoved1D;
            set { odpoved1D = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved1D")); }
        }

        private string odpoved2A;
        public string Odpoved2A
        {
            get => odpoved2A;
            set { odpoved2A = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved2A")); }
        }

        private string odpoved2B;
        public string Odpoved2B
        {
            get => odpoved2B;
            set { odpoved2B = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved2B")); }
        }

        private string odpoved2C;
        public string Odpoved2C
        {
            get => odpoved2C;
            set { odpoved2C = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved2C")); }
        }

        private string odpoved2D;
        public string Odpoved2D
        {
            get => odpoved2D;
            set { odpoved2D = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved2D")); }
        }

        private string odpoved3A;
        public string Odpoved3A
        {
            get => odpoved3A;
            set { odpoved3A = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved3A")); }
        }

        private string odpoved3B;
        public string Odpoved3B
        {
            get => odpoved3B;
            set { odpoved3B = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved3B")); }
        }

        private string odpoved3C;
        public string Odpoved3C
        {
            get => odpoved3C;
            set { odpoved3C = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved3C")); }
        }

        private string odpoved3D;
        public string Odpoved3D
        {
            get => odpoved3D;
            set { odpoved3D = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved3D")); }
        }

        private string odpoved4A;
        public string Odpoved4A
        {
            get => odpoved4A;
            set { odpoved4A = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved4A")); }
        }

        private string odpoved4B;
        public string Odpoved4B
        {
            get => odpoved4B;
            set { odpoved4B = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved4B")); }
        }

        private string odpoved4C;
        public string Odpoved4C
        {
            get => odpoved4C;
            set { odpoved4C = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved4C")); }
        }

        private string odpoved4D;
        public string Odpoved4D
        {
            get => odpoved4D;
            set { odpoved4D = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Odpoved4D")); }
        }

        public static ObservableCollection<Test> Tests { get; set; } = new ObservableCollection<Test>();

        public static void TestList()
        {
            Tests.Add(new Test
            {
                TestName = "Vzorový test",
                Otazka1 = "Vypočítejte: 155-47",
                Otazka2 = "Co je to Ukulele?",
                Otazka3 = "Kolik hodin bylo potřeba na vytvoření tohoto softwaru?",
                Otazka4 = "Líbí se vám tento software?",
                Odpoved1A = "108",
                Odpoved1B = "107",
                Odpoved1C = "109",
                Odpoved1D = "106",
                Odpoved2A = "Nic to není",
                Odpoved2B = "Hudební nástroj",
                Odpoved2C = "Bulharské hory",
                Odpoved2D = "Druh kamene",
                Odpoved3A = "0-2 hodiny",
                Odpoved3B = "3-5 hodin",
                Odpoved3C = "6-8 hodin",
                Odpoved3D = "10 hodin a víc",
                Odpoved4A = "Ne, je příšerný!",
                Odpoved4B = "Je perfektní!",
                Odpoved4C = "Viděl jsem lepší.",
                Odpoved4D = "50/50"
            });
        }
    }
}