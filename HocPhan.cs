using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhHocPhi
{
    internal class HocPhan
    {
        public HocPhan(string MaHP, string TenHP, float TinChiHP, float HeSoHP)
        {
            this.ma = MaHP;
            this.ten = TenHP;
            this.tin = TinChiHP;
            this.heSo = HeSoHP;
        }

        public HocPhan(DataRow row)
        {
            this.ma = row["MaHP"].ToString();
            this.ten = row["TenHP"].ToString();
            this.tin = (float)Convert.ToSingle(row["TinChiHP"]);
            this.heSo = (float)Convert.ToSingle(row["HeSoHP"]);
        }

        private string MaHP;

        public string ma
        {
            get { return MaHP; }
            set { MaHP = value; }
        }

        private string TenHP;

        public string ten
        {
            get { return TenHP; }
            set { TenHP = value; }
        }

        private float TinChiHP;

        public float tin
        {
            get { return TinChiHP; }
            set { TinChiHP = value; }
        }

        private float HeSoHP;

        public float heSo
        {
            get { return HeSoHP; }
            set { HeSoHP = value; }
        }

    }
}
