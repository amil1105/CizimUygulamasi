using System.Reflection;

namespace CizimUygulamasi
{
    public partial class Case1 : Form
    {
        private SekilManager manager = new();
        private Point merkezNoktasi;
        private bool cizimModu = false;
        private string secilenTip = "Dikdörtgen";
        private Color secilenRenk = Color.Black;

        private bool suruklemeModu = false;
        private Point suruklemeBaslangic;

        private bool secimModu = false;

        private Button? seciliButon;
        private Button? seciliRenkButonu;

        public Case1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            typeof(Panel).InvokeMember("DoubleBuffered",
             BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
             null, panel1, new object[] { true });

            this.Load += Case1_Load;

            btnDikdortgen.Text = "";
            btnDaire.Text = "";
            btnUcgen.Text = "";
            btnAltigen.Text = "";

            btnDikdortgen.FlatStyle = FlatStyle.Flat;
            btnDaire.FlatStyle = FlatStyle.Flat;
            btnUcgen.FlatStyle = FlatStyle.Flat;
            btnAltigen.FlatStyle = FlatStyle.Flat;
            btnSec.FlatStyle = FlatStyle.Flat;

            btnDikdortgen.Paint += BtnDikdortgen_Paint;
            btnDaire.Paint += BtnDaire_Paint;
            btnUcgen.Paint += BtnUcgen_Paint;
            btnAltigen.Paint += BtnAltigen_Paint;

            btnDikdortgen.Click += (s, e) =>
            {
                secilenTip = "Dikdörtgen";
                secimModu = false;
                SekilButonSecimiGuncelle(btnDikdortgen);
            };

            btnDaire.Click += (s, e) =>
            {
                secilenTip = "Daire";
                secimModu = false;
                SekilButonSecimiGuncelle(btnDaire);
            };

            btnUcgen.Click += (s, e) =>
            {
                secilenTip = "Üçgen";
                secimModu = false;
                SekilButonSecimiGuncelle(btnUcgen);
            };

            btnAltigen.Click += (s, e) =>
            {
                secilenTip = "Altıgen";
                secimModu = false;
                SekilButonSecimiGuncelle(btnAltigen);
            };

            btnKirmizi.Click += (s, e) =>
            {
                secilenRenk = Color.Red;
                RenkButonSecimiGuncelle(btnKirmizi);
                RenkDegistir(secilenRenk);
            };

            btnMavi.Click += (s, e) =>
            {
                secilenRenk = Color.Blue;
                RenkButonSecimiGuncelle(btnMavi);
                RenkDegistir(secilenRenk);
            };

            btnYesil.Click += (s, e) =>
            {
                secilenRenk = Color.Green;
                RenkButonSecimiGuncelle(btnYesil);
                RenkDegistir(secilenRenk);
            };

            btnTuruncu.Click += (s, e) =>
            {
                secilenRenk = Color.Orange;
                RenkButonSecimiGuncelle(btnTuruncu);
                RenkDegistir(secilenRenk);
            };

            btnSiyah.Click += (s, e) =>
            {
                secilenRenk = Color.Black;
                RenkButonSecimiGuncelle(btnSiyah);
                RenkDegistir(secilenRenk);
            };

            btnSari.Click += (s, e) =>
            {
                secilenRenk = Color.Yellow;
                RenkButonSecimiGuncelle(btnSari);
                RenkDegistir(secilenRenk);
            };

            btnMor.Click += (s, e) =>
            {
                secilenRenk = Color.Purple;
                RenkButonSecimiGuncelle(btnMor);
                RenkDegistir(secilenRenk);
            };

            btnBordo.Click += (s, e) =>
            {
                secilenRenk = Color.Maroon;
                RenkButonSecimiGuncelle(btnBordo);
                RenkDegistir(secilenRenk);
            };

            btnBeyaz.Click += (s, e) =>
            {
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    secilenRenk = cd.Color;
                    btnBeyaz.BackColor = cd.Color;
                    RenkButonSecimiGuncelle(btnBeyaz);
                    RenkDegistir(secilenRenk);
                }
            };

            TumButonSecimleriSifirla();
        }

        private void Case1_Load(object? sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is GroupBox gb)
                {
                    foreach (Control gbCtrl in gb.Controls)
                    {
                        if (gbCtrl is Button btn && btn.FlatStyle != FlatStyle.Flat)
                        {
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                }
            }

            LblmouseLocation.Text = "X: 0, Y: 0";
        }

        private void TumButonSecimleriSifirla()
        {
            btnDikdortgen.FlatAppearance.BorderColor = Color.Gray;
            btnDaire.FlatAppearance.BorderColor = Color.Gray;
            btnUcgen.FlatAppearance.BorderColor = Color.Gray;
            btnAltigen.FlatAppearance.BorderColor = Color.Gray;

            btnDikdortgen.FlatAppearance.BorderSize = 2;
            btnDaire.FlatAppearance.BorderSize = 2;
            btnUcgen.FlatAppearance.BorderSize = 2;
            btnAltigen.FlatAppearance.BorderSize = 2;

            btnKirmizi.FlatAppearance.BorderColor = Color.Gray;
            btnMavi.FlatAppearance.BorderColor = Color.Gray;
            btnYesil.FlatAppearance.BorderColor = Color.Gray;
            btnTuruncu.FlatAppearance.BorderColor = Color.Gray;
            btnSiyah.FlatAppearance.BorderColor = Color.Gray;
            btnSari.FlatAppearance.BorderColor = Color.Gray;
            btnMor.FlatAppearance.BorderColor = Color.Gray;
            btnBordo.FlatAppearance.BorderColor = Color.Gray;
            btnBeyaz.FlatAppearance.BorderColor = Color.Gray;

            btnKirmizi.FlatAppearance.BorderSize = 2;
            btnMavi.FlatAppearance.BorderSize = 2;
            btnYesil.FlatAppearance.BorderSize = 2;
            btnTuruncu.FlatAppearance.BorderSize = 2;
            btnSiyah.FlatAppearance.BorderSize = 2;
            btnSari.FlatAppearance.BorderSize = 2;
            btnMor.FlatAppearance.BorderSize = 2;
            btnBordo.FlatAppearance.BorderSize = 2;
            btnBeyaz.FlatAppearance.BorderSize = 2;

            btnSec.FlatAppearance.BorderColor = Color.Gray;
            btnSec.FlatAppearance.BorderSize = 2;

            seciliButon = null;
            seciliRenkButonu = null;
        }

        private void SekilButonSecimiGuncelle(Button secilen)
        {
            btnDikdortgen.FlatAppearance.BorderColor = Color.Gray;
            btnDaire.FlatAppearance.BorderColor = Color.Gray;
            btnUcgen.FlatAppearance.BorderColor = Color.Gray;
            btnAltigen.FlatAppearance.BorderColor = Color.Gray;

            btnDikdortgen.FlatAppearance.BorderSize = 2;
            btnDaire.FlatAppearance.BorderSize = 2;
            btnUcgen.FlatAppearance.BorderSize = 2;
            btnAltigen.FlatAppearance.BorderSize = 2;

            secilen.FlatAppearance.BorderColor = Color.Gray;
            secilen.FlatAppearance.BorderSize = 5;
            seciliButon = secilen;

            btnSec.FlatAppearance.BorderColor = Color.Gray;
            btnSec.FlatAppearance.BorderSize = 2;
        }

        private void RenkButonSecimiGuncelle(Button secilen)
        {
            btnKirmizi.FlatAppearance.BorderColor = Color.Gray;
            btnMavi.FlatAppearance.BorderColor = Color.Gray;
            btnYesil.FlatAppearance.BorderColor = Color.Gray;
            btnTuruncu.FlatAppearance.BorderColor = Color.Gray;
            btnSiyah.FlatAppearance.BorderColor = Color.Gray;
            btnSari.FlatAppearance.BorderColor = Color.Gray;
            btnMor.FlatAppearance.BorderColor = Color.Gray;
            btnBordo.FlatAppearance.BorderColor = Color.Gray;
            btnBeyaz.FlatAppearance.BorderColor = Color.Gray;

            btnKirmizi.FlatAppearance.BorderSize = 2;
            btnMavi.FlatAppearance.BorderSize = 2;
            btnYesil.FlatAppearance.BorderSize = 2;
            btnTuruncu.FlatAppearance.BorderSize = 2;
            btnSiyah.FlatAppearance.BorderSize = 2;
            btnSari.FlatAppearance.BorderSize = 2;
            btnMor.FlatAppearance.BorderSize = 2;
            btnBordo.FlatAppearance.BorderSize = 2;
            btnBeyaz.FlatAppearance.BorderSize = 2;

            secilen.FlatAppearance.BorderColor = Color.Gray;
            secilen.FlatAppearance.BorderSize = 5;
            seciliRenkButonu = secilen;
        }
        private void BtnDikdortgen_Paint(object? sender, PaintEventArgs e)
        {
            if (sender == null) return;
            Button btn = (Button)sender;

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.Renk = Color.Yellow;
            dikdortgen.Baslangic = new Point(10, 10);
            dikdortgen.Bitis = new Point(btn.Width - 10, btn.Height - 10);
            dikdortgen.Ciz(e.Graphics);

            using (Pen p = new Pen(Color.Black))
            {
                e.Graphics.DrawRectangle(p, dikdortgen.GetSinirlar());
            }
        }

        private void BtnDaire_Paint(object? sender, PaintEventArgs e)
        {
            if (sender == null) return;
            Button btn = (Button)sender;

            Daire daire = new Daire();
            daire.Renk = Color.Purple;
            daire.Baslangic = new Point(10, 10);
            daire.Bitis = new Point(btn.Width - 10, btn.Height - 10);
            daire.Ciz(e.Graphics);

            using (Pen p = new Pen(Color.Black))
            {
                e.Graphics.DrawEllipse(p, daire.GetSinirlar());
            }
        }

        private void BtnUcgen_Paint(object? sender, PaintEventArgs e)
        {
            if (sender == null) return;
            Button btn = (Button)sender;

            Ucgen ucgen = new Ucgen();
            ucgen.Renk = Color.Blue;
            ucgen.Baslangic = new Point(10, 10);
            ucgen.Bitis = new Point(btn.Width - 10, btn.Height - 10);
            ucgen.Ciz(e.Graphics);

            Rectangle rect = ucgen.GetSinirlar();
            Point[] points = new Point[3];
            points[0] = new Point(rect.X + rect.Width / 2, rect.Y);
            points[1] = new Point(rect.X, rect.Y + rect.Height);
            points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height);

            using (Pen p = new Pen(Color.Black))
            {
                e.Graphics.DrawPolygon(p, points);
            }
        }

        private void BtnAltigen_Paint(object? sender, PaintEventArgs e)
        {
            if (sender == null) return;
            Button btn = (Button)sender;
            int centerX = btn.Width / 2;
            int centerY = btn.Height / 2;
            int radius = Math.Min(btn.Width - 5, btn.Height - 5) / 2;

            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = 2 * Math.PI / 6 * i;
                points[i] = new Point(
                    (int)(centerX + radius * Math.Cos(angle)),
                    (int)(centerY + radius * Math.Sin(angle))
                );
            }

            using (SolidBrush brush = new SolidBrush(Color.Green))
            {
                e.Graphics.FillPolygon(brush, points);
            }
            e.Graphics.DrawPolygon(Pens.Black, points);
        }

        private void groupBox1_Enter(object? sender, EventArgs e)
        {
        }

        private void panel1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Sekil? tiklananSekil = manager.Sekiller.LastOrDefault(s => s.IceriyorMu(e.Location));

                if (tiklananSekil != null && (tiklananSekil == manager.SeciliSekil || secimModu))
                {
                    manager.SekilSec(e.Location);

                    if (manager.SeciliSekil != null)
                    {
                        GuncelleButonlariSeciliSekileGore(manager.SeciliSekil);
                    }

                    suruklemeModu = true;
                    suruklemeBaslangic = e.Location;
                    panel1.Invalidate();
                    return;
                }

                if (secimModu)
                {
                    manager.SekilSec(e.Location);

                    if (manager.SeciliSekil != null)
                    {
                        GuncelleButonlariSeciliSekileGore(manager.SeciliSekil);
                    }
                    else
                    {
                        TumButonSecimleriSifirla();
                        btnSec.FlatAppearance.BorderColor = Color.Gray;
                        btnSec.FlatAppearance.BorderSize = 2;
                    }

                    panel1.Invalidate();
                    return;
                }

                cizimModu = true;
                merkezNoktasi = e.Location;
            }
        }

        private void GuncelleButonlariSeciliSekileGore(Sekil sekil)
        {
            if (sekil.Renk == Color.Red)
                RenkButonSecimiGuncelle(btnKirmizi);
            else if (sekil.Renk == Color.Blue)
                RenkButonSecimiGuncelle(btnMavi);
            else if (sekil.Renk == Color.Green)
                RenkButonSecimiGuncelle(btnYesil);
            else if (sekil.Renk == Color.Orange)
                RenkButonSecimiGuncelle(btnTuruncu);
            else if (sekil.Renk == Color.Black)
                RenkButonSecimiGuncelle(btnSiyah);
            else if (sekil.Renk == Color.Yellow)
                RenkButonSecimiGuncelle(btnSari);
            else if (sekil.Renk == Color.Purple)
                RenkButonSecimiGuncelle(btnMor);
            else if (sekil.Renk == Color.Maroon)
                RenkButonSecimiGuncelle(btnBordo);
            else
            {
                btnBeyaz.BackColor = sekil.Renk;
                RenkButonSecimiGuncelle(btnBeyaz);
            }

            if (sekil.SekilTipi == "Dikdörtgen")
                SekilButonunuIsaretle(btnDikdortgen);
            else if (sekil.SekilTipi == "Daire")
                SekilButonunuIsaretle(btnDaire);
            else if (sekil.SekilTipi == "Üçgen")
                SekilButonunuIsaretle(btnUcgen);
            else if (sekil.SekilTipi == "Altıgen")
                SekilButonunuIsaretle(btnAltigen);

            secilenRenk = sekil.Renk;
        }

        private void panel1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (LblmouseLocation != null)
            {
                LblmouseLocation.Text = $"Mouse Location(X,Y): {e.X}, {e.Y}";
            }

            if (suruklemeModu && manager.SeciliSekil != null)
            {
                int dx = e.X - suruklemeBaslangic.X;
                int dy = e.Y - suruklemeBaslangic.Y;

                Point yeniBaslangic = new Point(manager.SeciliSekil.Baslangic.X + dx, manager.SeciliSekil.Baslangic.Y + dy);
                Point yeniBitis = new Point(manager.SeciliSekil.Bitis.X + dx, manager.SeciliSekil.Bitis.Y + dy);

                if (PanelIcindeKaliyor(yeniBaslangic, yeniBitis))
                {
                    manager.SeciliSekil.Baslangic = yeniBaslangic;
                    manager.SeciliSekil.Bitis = yeniBitis;

                    suruklemeBaslangic = e.Location;
                }

                panel1.Invalidate();
            }
            else if (cizimModu)
            {
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object? sender, MouseEventArgs e)
        {
            if (suruklemeModu)
            {
                suruklemeModu = false;
                panel1.Invalidate();
                return;
            }

            if (!cizimModu) return;
            cizimModu = false;

            int dx = Math.Abs(e.X - merkezNoktasi.X);
            int dy = Math.Abs(e.Y - merkezNoktasi.Y);

            Point bas = new Point(merkezNoktasi.X - dx, merkezNoktasi.Y - dy);
            Point bit = new Point(merkezNoktasi.X + dx, merkezNoktasi.Y + dy);

            AdjustToPanelBounds(ref bas, ref bit);

            Sekil sekil = secilenTip switch
            {
                "Daire" => new Daire(),
                "Üçgen" => new Ucgen(),
                "Altıgen" => new Altigen(),
                _ => new Dikdortgen(),
            };

            sekil.Baslangic = bas;
            sekil.Bitis = bit;
            sekil.Renk = secilenRenk;

            manager.SekilEkle(sekil);
            panel1.Invalidate();
        }

        private void panel1_Paint(object? sender, PaintEventArgs e)
        {
            manager.CizHepsi(e.Graphics);

            if (cizimModu)
            {
                Point currentPoint = panel1.PointToClient(Cursor.Position);

                int dx = Math.Abs(currentPoint.X - merkezNoktasi.X);
                int dy = Math.Abs(currentPoint.Y - merkezNoktasi.Y);

                Point bas = new Point(merkezNoktasi.X - dx, merkezNoktasi.Y - dy);
                Point bit = new Point(merkezNoktasi.X + dx, merkezNoktasi.Y + dy);

                AdjustToPanelBounds(ref bas, ref bit);

                Sekil tempSekil = secilenTip switch
                {
                    "Daire" => new Daire(),
                    "Üçgen" => new Ucgen(),
                    "Altıgen" => new Altigen(),
                    _ => new Dikdortgen(),
                };

                tempSekil.Baslangic = bas;
                tempSekil.Bitis = bit;
                tempSekil.Renk = Color.FromArgb(128, secilenRenk);

                tempSekil.Ciz(e.Graphics);

                using (Brush b = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillEllipse(b, merkezNoktasi.X - 3, merkezNoktasi.Y - 3, 6, 6);
                }
            }
        }

        private void btnSec_Click(object? sender, EventArgs e)
        {
            secimModu = true;

            btnDikdortgen.FlatAppearance.BorderColor = Color.Gray;
            btnDaire.FlatAppearance.BorderColor = Color.Gray;
            btnUcgen.FlatAppearance.BorderColor = Color.Gray;
            btnAltigen.FlatAppearance.BorderColor = Color.Gray;

            btnDikdortgen.FlatAppearance.BorderSize = 2;
            btnDaire.FlatAppearance.BorderSize = 2;
            btnUcgen.FlatAppearance.BorderSize = 2;
            btnAltigen.FlatAppearance.BorderSize = 2;

            btnSec.FlatAppearance.BorderColor = Color.Gray;
            btnSec.FlatAppearance.BorderSize = 5;
        }

        private void Panel1_MouseClick_ForSelection(object? sender, MouseEventArgs e)
        {
            manager.SekilSec(e.Location);

            if (manager.SeciliSekil != null)
            {
                if (manager.SeciliSekil.Renk == Color.Red)
                    RenkButonSecimiGuncelle(btnKirmizi);
                else if (manager.SeciliSekil.Renk == Color.Blue)
                    RenkButonSecimiGuncelle(btnMavi);
                else if (manager.SeciliSekil.Renk == Color.Green)
                    RenkButonSecimiGuncelle(btnYesil);
                else if (manager.SeciliSekil.Renk == Color.Orange)
                    RenkButonSecimiGuncelle(btnTuruncu);
                else if (manager.SeciliSekil.Renk == Color.Black)
                    RenkButonSecimiGuncelle(btnSiyah);
                else if (manager.SeciliSekil.Renk == Color.Yellow)
                    RenkButonSecimiGuncelle(btnSari);
                else if (manager.SeciliSekil.Renk == Color.Purple)
                    RenkButonSecimiGuncelle(btnMor);
                else if (manager.SeciliSekil.Renk == Color.Maroon)
                    RenkButonSecimiGuncelle(btnBordo);
                else
                {
                    btnBeyaz.BackColor = manager.SeciliSekil.Renk;
                    RenkButonSecimiGuncelle(btnBeyaz);
                }

                if (manager.SeciliSekil.SekilTipi == "Dikdörtgen")
                    SekilButonunuIsaretle(btnDikdortgen);
                else if (manager.SeciliSekil.SekilTipi == "Daire")
                    SekilButonunuIsaretle(btnDaire);
                else if (manager.SeciliSekil.SekilTipi == "Üçgen")
                    SekilButonunuIsaretle(btnUcgen);
                else if (manager.SeciliSekil.SekilTipi == "Altıgen")
                    SekilButonunuIsaretle(btnAltigen);

                manager.SeciliSekil.Renk = secilenRenk;
            }

            panel1.Invalidate();
        }

        private void SekilButonunuIsaretle(Button btn)
        {
            btnDikdortgen.FlatAppearance.BorderColor = Color.Gray;
            btnDaire.FlatAppearance.BorderColor = Color.Gray;
            btnUcgen.FlatAppearance.BorderColor = Color.Gray;
            btnAltigen.FlatAppearance.BorderColor = Color.Gray;

            btnDikdortgen.FlatAppearance.BorderSize = 2;
            btnDaire.FlatAppearance.BorderSize = 2;
            btnUcgen.FlatAppearance.BorderSize = 2;
            btnAltigen.FlatAppearance.BorderSize = 2;

            btn.FlatAppearance.BorderColor = Color.Gray;
            btn.FlatAppearance.BorderSize = 5;
        }

        private void btnSil_Click(object? sender, EventArgs e)
        {
            manager.SilSecili();
            panel1.Invalidate();
        }

        private void btnYeni_Click(object? sender, EventArgs e)
        {
            manager.Temizle();
            panel1.Invalidate();
        }

        private void btnAc_Click(object? sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Filter = "Metin Dosyaları (*.txt)|*.txt";
            ofd.Title = "Çizim Dosyası Aç";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    manager.Temizle();
                    foreach (var line in File.ReadLines(ofd.FileName))
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length < 4) continue;

                        Sekil sekil = parts[0] switch
                        {
                            "Daire" => new Daire(),
                            "Üçgen" => new Ucgen(),
                            "Altıgen" => new Altigen(),
                            _ => new Dikdortgen()
                        };

                        try
                        {
                            var bas = parts[1].Split(',');
                            var bit = parts[2].Split(',');

                            if (bas.Length < 2 || bit.Length < 2) continue;

                            int argb;
                            if (!int.TryParse(parts[3], out argb)) continue;

                            var renk = Color.FromArgb(argb);

                            sekil.Baslangic = new Point(int.Parse(bas[0]), int.Parse(bas[1]));
                            sekil.Bitis = new Point(int.Parse(bit[0]), int.Parse(bit[1]));
                            sekil.Renk = renk;

                            manager.SekilEkle(sekil);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    panel1.Invalidate();
                    MessageBox.Show("Dosya başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya açılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKaydet_Click(object? sender, EventArgs e)
        {
            if (manager.Sekiller.Count == 0)
            {
                MessageBox.Show("Kaydedilecek şekil bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new();
            sfd.Filter = "Metin Dosyaları (*.txt)|*.txt";
            sfd.Title = "Çizim Dosyası Kaydet";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new(sfd.FileName))
                    {
                        foreach (var sekil in manager.Sekiller)
                        {
                            sw.WriteLine($"{sekil.SekilTipi};{sekil.Baslangic.X},{sekil.Baslangic.Y};{sekil.Bitis.X},{sekil.Bitis.Y};{sekil.Renk.ToArgb()}");
                        }
                    }

                    MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya kaydedilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBeyaz_Click(object? sender, EventArgs e)
        {

        }

        private bool PanelIcindeKaliyor(Point baslangic, Point bitis)
        {
            int minX = 0;
            int minY = 0;
            int maxX = panel1.Width;
            int maxY = panel1.Height;

            if (manager.SeciliSekil != null)
            {
                Point originalBaslangic = manager.SeciliSekil.Baslangic;
                Point originalBitis = manager.SeciliSekil.Bitis;

                manager.SeciliSekil.Baslangic = baslangic;
                manager.SeciliSekil.Bitis = bitis;

                Rectangle sekilSinirlar = manager.SeciliSekil.GetSinirlar();

                manager.SeciliSekil.Baslangic = originalBaslangic;
                manager.SeciliSekil.Bitis = originalBitis;

                return sekilSinirlar.Left >= minX &&
                       sekilSinirlar.Top >= minY &&
                       sekilSinirlar.Right <= maxX &&
                       sekilSinirlar.Bottom <= maxY;
            }

            int sekilMinX = Math.Min(baslangic.X, bitis.X);
            int sekilMinY = Math.Min(baslangic.Y, bitis.Y);
            int sekilMaxX = Math.Max(baslangic.X, bitis.X);
            int sekilMaxY = Math.Max(baslangic.Y, bitis.Y);

            return sekilMinX >= minX && sekilMinY >= minY && sekilMaxX <= maxX && sekilMaxY <= maxY;
        }

        private void AdjustToPanelBounds(ref Point baslangic, ref Point bitis)
        {
            int minX = 0;
            int minY = 0;
            int maxX = panel1.Width;
            int maxY = panel1.Height;

            int sekilMinX = Math.Min(baslangic.X, bitis.X);
            int sekilMinY = Math.Min(baslangic.Y, bitis.Y);
            int sekilMaxX = Math.Max(baslangic.X, bitis.X);
            int sekilMaxY = Math.Max(baslangic.Y, bitis.Y);
            int width = sekilMaxX - sekilMinX;
            int height = sekilMaxY - sekilMinY;

            if (sekilMinX < minX)
            {
                int diff = minX - sekilMinX;
                sekilMinX = minX;
                sekilMaxX = sekilMinX + width;
            }

            if (sekilMinY < minY)
            {
                int diff = minY - sekilMinY;
                sekilMinY = minY;
                sekilMaxY = sekilMinY + height;
            }

            if (sekilMaxX > maxX)
            {
                int diff = sekilMaxX - maxX;
                sekilMaxX = maxX;
                sekilMinX = Math.Max(minX, sekilMaxX - width);
            }

            if (sekilMaxY > maxY)
            {
                int diff = sekilMaxY - maxY;
                sekilMaxY = maxY;
                sekilMinY = Math.Max(minY, sekilMaxY - height);
            }

            baslangic = new Point(sekilMinX, sekilMinY);
            bitis = new Point(sekilMaxX, sekilMaxY);
        }

        private void RenkDegistir(Color yeniRenk)
        {
            if (manager.SeciliSekil != null)
            {
                manager.SeciliSekil.Renk = yeniRenk;
                panel1.Invalidate();
            }
        }

        private void Case1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
