namespace CizimUygulamasi
{
    partial class Case1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Case1));
            panel1 = new Panel();
            CizimSekli = new GroupBox();
            btnUcgen = new Button();
            btnAltigen = new Button();
            btnDaire = new Button();
            btnDikdortgen = new Button();
            RenkSecimi = new GroupBox();
            btnBeyaz = new Button();
            btnBordo = new Button();
            btnSari = new Button();
            btnSiyah = new Button();
            btnMor = new Button();
            btnYesil = new Button();
            btnTuruncu = new Button();
            btnMavi = new Button();
            btnKirmizi = new Button();
            SekilIslemleri = new GroupBox();
            btnYeni = new Button();
            ımageList1 = new ImageList(components);
            btnSil = new Button();
            btnSec = new Button();
            dosyaIslemleri = new GroupBox();
            btnKaydet = new Button();
            btnAc = new Button();
            groupBox1 = new GroupBox();
            LblmouseLocation = new Label();
            CizimSekli.SuspendLayout();
            RenkSecimi.SuspendLayout();
            SekilIslemleri.SuspendLayout();
            dosyaIslemleri.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 766);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // CizimSekli
            // 
            CizimSekli.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CizimSekli.BackColor = Color.White;
            CizimSekli.Controls.Add(btnUcgen);
            CizimSekli.Controls.Add(btnAltigen);
            CizimSekli.Controls.Add(btnDaire);
            CizimSekli.Controls.Add(btnDikdortgen);
            CizimSekli.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CizimSekli.ForeColor = Color.Black;
            CizimSekli.Location = new Point(1276, 29);
            CizimSekli.Name = "CizimSekli";
            CizimSekli.Size = new Size(217, 215);
            CizimSekli.TabIndex = 1;
            CizimSekli.TabStop = false;
            CizimSekli.Text = "ÇİZİM ŞEKLİ";
            CizimSekli.Enter += groupBox1_Enter;
            // 
            // btnUcgen
            // 
            btnUcgen.FlatAppearance.BorderColor = Color.Gray;
            btnUcgen.FlatAppearance.BorderSize = 2;
            btnUcgen.FlatStyle = FlatStyle.Flat;
            btnUcgen.Location = new Point(4, 122);
            btnUcgen.Name = "btnUcgen";
            btnUcgen.Size = new Size(99, 87);
            btnUcgen.TabIndex = 0;
            btnUcgen.Text = "ucgen";
            btnUcgen.UseVisualStyleBackColor = true;
            // 
            // btnAltigen
            // 
            btnAltigen.FlatAppearance.BorderColor = Color.Gray;
            btnAltigen.FlatAppearance.BorderSize = 2;
            btnAltigen.FlatStyle = FlatStyle.Flat;
            btnAltigen.Location = new Point(118, 122);
            btnAltigen.Name = "btnAltigen";
            btnAltigen.Size = new Size(99, 87);
            btnAltigen.TabIndex = 0;
            btnAltigen.Text = "altigen";
            btnAltigen.UseVisualStyleBackColor = true;
            // 
            // btnDaire
            // 
            btnDaire.FlatAppearance.BorderColor = Color.Gray;
            btnDaire.FlatAppearance.BorderSize = 2;
            btnDaire.FlatStyle = FlatStyle.Flat;
            btnDaire.Location = new Point(118, 26);
            btnDaire.Name = "btnDaire";
            btnDaire.Size = new Size(99, 87);
            btnDaire.TabIndex = 0;
            btnDaire.Text = "daire";
            btnDaire.UseVisualStyleBackColor = true;
            // 
            // btnDikdortgen
            // 
            btnDikdortgen.FlatAppearance.BorderColor = Color.Gray;
            btnDikdortgen.FlatAppearance.BorderSize = 2;
            btnDikdortgen.FlatStyle = FlatStyle.Flat;
            btnDikdortgen.Location = new Point(6, 26);
            btnDikdortgen.Name = "btnDikdortgen";
            btnDikdortgen.Size = new Size(99, 87);
            btnDikdortgen.TabIndex = 0;
            btnDikdortgen.Text = "dikdortgen";
            btnDikdortgen.UseVisualStyleBackColor = true;
            // 
            // RenkSecimi
            // 
            RenkSecimi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RenkSecimi.BackColor = Color.White;
            RenkSecimi.Controls.Add(btnBeyaz);
            RenkSecimi.Controls.Add(btnBordo);
            RenkSecimi.Controls.Add(btnSari);
            RenkSecimi.Controls.Add(btnSiyah);
            RenkSecimi.Controls.Add(btnMor);
            RenkSecimi.Controls.Add(btnYesil);
            RenkSecimi.Controls.Add(btnTuruncu);
            RenkSecimi.Controls.Add(btnMavi);
            RenkSecimi.Controls.Add(btnKirmizi);
            RenkSecimi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RenkSecimi.ForeColor = Color.Black;
            RenkSecimi.Location = new Point(1276, 250);
            RenkSecimi.Name = "RenkSecimi";
            RenkSecimi.Size = new Size(217, 243);
            RenkSecimi.TabIndex = 2;
            RenkSecimi.TabStop = false;
            RenkSecimi.Text = "RENK SEÇİMİ";
            // 
            // btnBeyaz
            // 
            btnBeyaz.FlatAppearance.BorderColor = Color.Gray;
            btnBeyaz.FlatAppearance.BorderSize = 2;
            btnBeyaz.FlatStyle = FlatStyle.Flat;
            btnBeyaz.Location = new Point(147, 166);
            btnBeyaz.Name = "btnBeyaz";
            btnBeyaz.Size = new Size(64, 64);
            btnBeyaz.TabIndex = 0;
            btnBeyaz.UseVisualStyleBackColor = true;
            btnBeyaz.Click += btnBeyaz_Click;
            // 
            // btnBordo
            // 
            btnBordo.BackColor = Color.Maroon;
            btnBordo.FlatAppearance.BorderColor = Color.Gray;
            btnBordo.FlatAppearance.BorderSize = 2;
            btnBordo.FlatStyle = FlatStyle.Flat;
            btnBordo.Location = new Point(77, 166);
            btnBordo.Name = "btnBordo";
            btnBordo.Size = new Size(64, 64);
            btnBordo.TabIndex = 0;
            btnBordo.UseVisualStyleBackColor = false;
            // 
            // btnSari
            // 
            btnSari.BackColor = Color.Yellow;
            btnSari.FlatAppearance.BorderColor = Color.Gray;
            btnSari.FlatAppearance.BorderSize = 2;
            btnSari.FlatStyle = FlatStyle.Flat;
            btnSari.Location = new Point(147, 96);
            btnSari.Name = "btnSari";
            btnSari.Size = new Size(64, 64);
            btnSari.TabIndex = 0;
            btnSari.UseVisualStyleBackColor = false;
            // 
            // btnSiyah
            // 
            btnSiyah.BackColor = Color.Black;
            btnSiyah.FlatAppearance.BorderColor = Color.Gray;
            btnSiyah.FlatAppearance.BorderSize = 2;
            btnSiyah.FlatStyle = FlatStyle.Flat;
            btnSiyah.Location = new Point(77, 96);
            btnSiyah.Name = "btnSiyah";
            btnSiyah.Size = new Size(64, 64);
            btnSiyah.TabIndex = 0;
            btnSiyah.UseVisualStyleBackColor = false;
            // 
            // btnMor
            // 
            btnMor.BackColor = Color.Purple;
            btnMor.FlatAppearance.BorderColor = Color.Gray;
            btnMor.FlatAppearance.BorderSize = 2;
            btnMor.FlatStyle = FlatStyle.Flat;
            btnMor.Location = new Point(7, 166);
            btnMor.Name = "btnMor";
            btnMor.Size = new Size(64, 64);
            btnMor.TabIndex = 0;
            btnMor.UseVisualStyleBackColor = false;
            // 
            // btnYesil
            // 
            btnYesil.BackColor = Color.Green;
            btnYesil.FlatAppearance.BorderColor = Color.Gray;
            btnYesil.FlatAppearance.BorderSize = 2;
            btnYesil.FlatStyle = FlatStyle.Flat;
            btnYesil.Location = new Point(147, 26);
            btnYesil.Name = "btnYesil";
            btnYesil.Size = new Size(64, 64);
            btnYesil.TabIndex = 0;
            btnYesil.UseVisualStyleBackColor = false;
            // 
            // btnTuruncu
            // 
            btnTuruncu.BackColor = Color.Orange;
            btnTuruncu.FlatAppearance.BorderColor = Color.Gray;
            btnTuruncu.FlatAppearance.BorderSize = 2;
            btnTuruncu.FlatStyle = FlatStyle.Flat;
            btnTuruncu.Location = new Point(7, 96);
            btnTuruncu.Name = "btnTuruncu";
            btnTuruncu.Size = new Size(64, 64);
            btnTuruncu.TabIndex = 0;
            btnTuruncu.UseVisualStyleBackColor = false;
            // 
            // btnMavi
            // 
            btnMavi.BackColor = Color.Blue;
            btnMavi.FlatAppearance.BorderColor = Color.Gray;
            btnMavi.FlatAppearance.BorderSize = 2;
            btnMavi.FlatStyle = FlatStyle.Flat;
            btnMavi.Location = new Point(77, 26);
            btnMavi.Name = "btnMavi";
            btnMavi.Size = new Size(64, 64);
            btnMavi.TabIndex = 0;
            btnMavi.UseVisualStyleBackColor = false;
            // 
            // btnKirmizi
            // 
            btnKirmizi.BackColor = Color.Red;
            btnKirmizi.FlatAppearance.BorderColor = Color.Gray;
            btnKirmizi.FlatAppearance.BorderSize = 2;
            btnKirmizi.FlatStyle = FlatStyle.Flat;
            btnKirmizi.Location = new Point(7, 26);
            btnKirmizi.Name = "btnKirmizi";
            btnKirmizi.Size = new Size(64, 64);
            btnKirmizi.TabIndex = 0;
            btnKirmizi.UseVisualStyleBackColor = false;
            // 
            // SekilIslemleri
            // 
            SekilIslemleri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SekilIslemleri.BackColor = Color.White;
            SekilIslemleri.Controls.Add(btnYeni);
            SekilIslemleri.Controls.Add(btnSil);
            SekilIslemleri.Controls.Add(btnSec);
            SekilIslemleri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SekilIslemleri.Location = new Point(1276, 499);
            SekilIslemleri.Name = "SekilIslemleri";
            SekilIslemleri.Size = new Size(219, 107);
            SekilIslemleri.TabIndex = 3;
            SekilIslemleri.TabStop = false;
            SekilIslemleri.Text = "ŞEKİL İŞLEMLERİ";
            // 
            // btnYeni
            // 
            btnYeni.FlatAppearance.BorderColor = Color.Gray;
            btnYeni.FlatAppearance.BorderSize = 2;
            btnYeni.FlatStyle = FlatStyle.Flat;
            btnYeni.ImageKey = "Create_New-80_icon-icons.png";
            btnYeni.ImageList = ımageList1;
            btnYeni.Location = new Point(147, 26);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(64, 64);
            btnYeni.TabIndex = 0;
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Actions-document-save-as-icon.png");
            ımageList1.Images.SetKeyName(1, "free-folder-icon-1485-thumb.png");
            ımageList1.Images.SetKeyName(2, "Full.jpg");
            ımageList1.Images.SetKeyName(3, "hands-click-png-icon-5.png");
            ımageList1.Images.SetKeyName(4, "Create_New-80_icon-icons.png");
            // 
            // btnSil
            // 
            btnSil.FlatAppearance.BorderColor = Color.Gray;
            btnSil.FlatAppearance.BorderSize = 2;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ImageKey = "Full.jpg";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(77, 26);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(64, 64);
            btnSil.TabIndex = 0;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSec
            // 
            btnSec.FlatAppearance.BorderColor = Color.Gray;
            btnSec.FlatAppearance.BorderSize = 2;
            btnSec.FlatStyle = FlatStyle.Flat;
            btnSec.ImageIndex = 3;
            btnSec.ImageList = ımageList1;
            btnSec.Location = new Point(7, 26);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(64, 64);
            btnSec.TabIndex = 0;
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // dosyaIslemleri
            // 
            dosyaIslemleri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dosyaIslemleri.BackColor = Color.White;
            dosyaIslemleri.Controls.Add(btnKaydet);
            dosyaIslemleri.Controls.Add(btnAc);
            dosyaIslemleri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dosyaIslemleri.ForeColor = Color.Black;
            dosyaIslemleri.Location = new Point(1276, 612);
            dosyaIslemleri.Name = "dosyaIslemleri";
            dosyaIslemleri.Size = new Size(219, 99);
            dosyaIslemleri.TabIndex = 4;
            dosyaIslemleri.TabStop = false;
            dosyaIslemleri.Text = "DOSYA İŞLEMLERİ";
            // 
            // btnKaydet
            // 
            btnKaydet.FlatAppearance.BorderColor = Color.Gray;
            btnKaydet.FlatAppearance.BorderSize = 2;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ImageKey = "Actions-document-save-as-icon.png";
            btnKaydet.ImageList = ımageList1;
            btnKaydet.Location = new Point(77, 26);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(64, 64);
            btnKaydet.TabIndex = 0;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnAc
            // 
            btnAc.FlatAppearance.BorderColor = Color.Gray;
            btnAc.FlatAppearance.BorderSize = 2;
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.ImageKey = "free-folder-icon-1485-thumb.png";
            btnAc.ImageList = ımageList1;
            btnAc.Location = new Point(7, 26);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(64, 64);
            btnAc.TabIndex = 0;
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(LblmouseLocation);
            groupBox1.Location = new Point(1270, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 775);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // LblmouseLocation
            // 
            LblmouseLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblmouseLocation.AutoSize = true;
            LblmouseLocation.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblmouseLocation.Location = new Point(6, 752);
            LblmouseLocation.Name = "LblmouseLocation";
            LblmouseLocation.Size = new Size(134, 17);
            LblmouseLocation.TabIndex = 0;
            LblmouseLocation.Text = "Mouse Location(X,Y): ";
            // 
            // Case1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 790);
            Controls.Add(dosyaIslemleri);
            Controls.Add(SekilIslemleri);
            Controls.Add(CizimSekli);
            Controls.Add(RenkSecimi);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Case1";
            Text = "CASE 1";
            WindowState = FormWindowState.Maximized;
            CizimSekli.ResumeLayout(false);
            RenkSecimi.ResumeLayout(false);
            SekilIslemleri.ResumeLayout(false);
            dosyaIslemleri.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox CizimSekli;
        private GroupBox RenkSecimi;
        private Button btnUcgen;
        private Button btnAltigen;
        private Button btnDaire;
        private Button btnDikdortgen;
        private Button btnYesil;
        private Button btnMavi;
        private Button btnKirmizi;
        private Button btnBeyaz;
        private Button btnBordo;
        private Button btnSari;
        private Button btnSiyah;
        private Button btnMor;
        private Button btnTuruncu;
        private GroupBox SekilIslemleri;
        private Button btnYeni;
        private Button btnSil;
        private Button btnSec;
        private GroupBox dosyaIslemleri;
        private Button btnKaydet;
        private Button btnAc;
        private ImageList ımageList1;
        private GroupBox groupBox1;
        private Label LblmouseLocation;
    }
}
