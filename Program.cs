using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar_OOP
{
    abstract class BangunDatar
    {
        public double _hitung;
        public double Hitung
        {
            get { return _hitung; }
            set { _hitung = value; }
        }

        public abstract double hitungLuas();

        public abstract double hitungKeliling();
    }
    class Persegi : BangunDatar
    {

        private double _sisi;

        public double Sisi
        {
            get { return _sisi; }
            set { _sisi = value; }
        }

        public override double hitungLuas()
        {
            _hitung = _sisi * _sisi;
            return _hitung;
        }

        public override double hitungKeliling()
        {
            _hitung = _sisi * 4;
            return _hitung;
        }
        class PersegiPanjang : BangunDatar
        {
            private double _panjang;
            private double _lebar;

            public double Panjang
            {
                get { return _panjang; }
                set { _panjang = value; }
            }

            public double Lebar
            {
                get { return _lebar; }
                set { _lebar = value; }
            }

            public override double hitungLuas()
            {
                _hitung = _panjang * _lebar;
                return _hitung;
            }

            public override double hitungKeliling()
            {
                _hitung = (_panjang + _lebar) * 2;
                return _hitung;
            }
        }
        class Segitiga : BangunDatar
        {
            private double _alas;
            private double _tinggi;
            private double _sisi;

            public double Alas
            {
                get { return _alas; }
                set { _alas = value; }
            }

            public double Tinggi
            {
                get { return _tinggi; }
                set { _tinggi = value; }
            }

            public double Sisi
            {
                get { return _sisi; }
                set { _sisi = value; }
            }

            public override double hitungLuas()
            {
                _hitung = _alas * _tinggi / 2;
                return _hitung;
            }

            public override double hitungKeliling()
            {
                _hitung = _alas + _tinggi + _sisi;
                return _hitung;
                Persegi p = new Persegi();
                p.Sisi = 9;

                System.Console.WriteLine("Persegi");
                System.Console.WriteLine("Nilai Sisi : " + p.Sisi);
                System.Console.WriteLine("Luas : " + p.hitungLuas());
                System.Console.WriteLine("Keliling : " + p.hitungKeliling() + "\n");

                PersegiPanjang pp = new PersegiPanjang();
                pp.Panjang = 9;
                pp.Lebar = 5;

                System.Console.WriteLine("Persegi Panjang");
                System.Console.WriteLine("Nilai Panjang : " + pp.Panjang);
                System.Console.WriteLine("Nilai Lebar : " + pp.Lebar);
                System.Console.WriteLine("Luas : " + pp.hitungLuas());
                System.Console.WriteLine("Keliling : " + pp.hitungKeliling() + "\n");

                Segitiga s = new Segitiga();
                s.Alas = 5.5;
                s.Tinggi = 10;
                s.Sisi = 7;

                System.Console.WriteLine("Segitiga");
                System.Console.WriteLine("Nilai Alas : " + s.Alas);
                System.Console.WriteLine("Nilai Tinggi : " + s.Tinggi);
                System.Console.WriteLine("Nilai Sisi : " + s.Sisi);
                System.Console.WriteLine("Luas : " + s.hitungLuas());
                System.Console.WriteLine("Keliling : " + s.hitungKeliling());

                System.Console.ReadKey();
            }
        }
    }
}
