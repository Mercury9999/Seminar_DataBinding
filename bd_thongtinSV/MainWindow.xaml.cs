using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_thongtinSV
{
    class SinhVien
    {
        private decimal _HocBong;
        public event PropertyChangedEventHandler PropertyChanged;

        public string HoTen { get; set; }
        public string ID { get; set; }

        public string Lop { get; set; }
        public DateTime NgayNhapHoc { get; set; }
        public decimal HocBong
        {
            get => _HocBong;
            set
            {
                _HocBong = value;

                // Support TwoWay binding
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HocBong)));
            }
        }

    }
}
