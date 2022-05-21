using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentOrganizationForma
{

    public enum NivoStudija
    { Osnovne = 0, Master, Doktorske }

    internal class Student
    {
        #region PublicProperties
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrInd { get; set; }
        public NivoStudija NivoStudija { get; set; }
        public int GodinaStudija { get; set; }
        public double Prosek { get; set; }
        public bool FIB { get; set; }
        public DateTime DatRodj { get; set; }
        #endregion

        #region Constructors
        public Student() { }

        public Student(string ime, string prezime, int brInd,
            int nivoStudija, int godinaStudija, double prosek,
            bool fib, long datRodj)
        { 
            Ime = ime;
            Prezime = prezime;
            BrInd = brInd;
            this.NivoStudija = (NivoStudija)nivoStudija;
            GodinaStudija = godinaStudija;
            Prosek = prosek;
            FIB = fib;
            DatRodj = new DateTime(datRodj); // ticks
        }
        #endregion

        #region BinFiles
        public static void UpisBin(BinaryWriter bw, in Student s)
        {
            bw.Write(s.Ime);
            bw.Write(s.Prezime);
            bw.Write(s.BrInd);
            bw.Write((int)s.NivoStudija);
            bw.Write(s.GodinaStudija);
            bw.Write(s.Prosek);
            bw.Write(s.FIB);
            bw.Write(s.DatRodj.Ticks);
        }

        public static void CitajBin(BinaryReader br, out Student s)
        {
            s = new Student();
            s.Ime = br.ReadString();
            s.Prezime = br.ReadString();
            s.BrInd = br.ReadInt32();
            s.NivoStudija = (NivoStudija)br.ReadInt32();
            s.GodinaStudija= br.ReadInt32();
            s.Prosek = br.ReadDouble();
            s.FIB = br.ReadBoolean();
            s.DatRodj = new DateTime(br.ReadInt64());
        }
        #endregion

        #region Misc
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Ime + " ");
            sb.Append(Prezime + " ");
            sb.Append(BrInd);
            return sb.ToString();
        }
        #endregion

    }
}
