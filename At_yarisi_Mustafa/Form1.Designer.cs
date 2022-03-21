
namespace At_yarisi_Mustafa
{
    partial class atyarisi_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(atyarisi_form));
            this.aracizgi1 = new System.Windows.Forms.Label();
            this.aracizgi2 = new System.Windows.Forms.Label();
            this.aracizgi3 = new System.Windows.Forms.Label();
            this.btn_yarisi_baslat = new System.Windows.Forms.Button();
            this.birinci_at = new System.Windows.Forms.PictureBox();
            this.ikinci_at = new System.Windows.Forms.PictureBox();
            this.ucuncu_at = new System.Windows.Forms.PictureBox();
            this.timer_start = new System.Windows.Forms.Timer(this.components);
            this.lbl_bitis = new System.Windows.Forms.Label();
            this.lbl_canli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_oyunu_kapat = new System.Windows.Forms.Button();
            this.lbl_yaris_sonu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birinci_at)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikinci_at)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuncu_at)).BeginInit();
            this.SuspendLayout();
            // 
            // aracizgi1
            // 
            this.aracizgi1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aracizgi1.Location = new System.Drawing.Point(2, 71);
            this.aracizgi1.Name = "aracizgi1";
            this.aracizgi1.Size = new System.Drawing.Size(766, 23);
            this.aracizgi1.TabIndex = 0;
            this.aracizgi1.Text = " ";
            // 
            // aracizgi2
            // 
            this.aracizgi2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aracizgi2.Location = new System.Drawing.Point(2, 159);
            this.aracizgi2.Name = "aracizgi2";
            this.aracizgi2.Size = new System.Drawing.Size(766, 23);
            this.aracizgi2.TabIndex = 1;
            // 
            // aracizgi3
            // 
            this.aracizgi3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aracizgi3.Location = new System.Drawing.Point(2, 254);
            this.aracizgi3.Name = "aracizgi3";
            this.aracizgi3.Size = new System.Drawing.Size(766, 23);
            this.aracizgi3.TabIndex = 2;
            // 
            // btn_yarisi_baslat
            // 
            this.btn_yarisi_baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yarisi_baslat.Location = new System.Drawing.Point(2, 280);
            this.btn_yarisi_baslat.Name = "btn_yarisi_baslat";
            this.btn_yarisi_baslat.Size = new System.Drawing.Size(103, 49);
            this.btn_yarisi_baslat.TabIndex = 3;
            this.btn_yarisi_baslat.Text = "Başla";
            this.btn_yarisi_baslat.UseVisualStyleBackColor = true;
            this.btn_yarisi_baslat.Click += new System.EventHandler(this.btn_yarisi_baslat_Click);
            // 
            // birinci_at
            // 
            this.birinci_at.Image = ((System.Drawing.Image)(resources.GetObject("birinci_at.Image")));
            this.birinci_at.Location = new System.Drawing.Point(5, 12);
            this.birinci_at.Name = "birinci_at";
            this.birinci_at.Size = new System.Drawing.Size(100, 50);
            this.birinci_at.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birinci_at.TabIndex = 4;
            this.birinci_at.TabStop = false;
            // 
            // ikinci_at
            // 
            this.ikinci_at.Image = ((System.Drawing.Image)(resources.GetObject("ikinci_at.Image")));
            this.ikinci_at.Location = new System.Drawing.Point(5, 106);
            this.ikinci_at.Name = "ikinci_at";
            this.ikinci_at.Size = new System.Drawing.Size(100, 50);
            this.ikinci_at.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ikinci_at.TabIndex = 5;
            this.ikinci_at.TabStop = false;
            // 
            // ucuncu_at
            // 
            this.ucuncu_at.Image = ((System.Drawing.Image)(resources.GetObject("ucuncu_at.Image")));
            this.ucuncu_at.Location = new System.Drawing.Point(4, 201);
            this.ucuncu_at.Name = "ucuncu_at";
            this.ucuncu_at.Size = new System.Drawing.Size(100, 50);
            this.ucuncu_at.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucuncu_at.TabIndex = 6;
            this.ucuncu_at.TabStop = false;
            // 
            // timer_start
            // 
            this.timer_start.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bitis.BackColor = System.Drawing.Color.Red;
            this.lbl_bitis.Location = new System.Drawing.Point(769, 1);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(10, 331);
            this.lbl_bitis.TabIndex = 7;
            // 
            // lbl_canli
            // 
            this.lbl_canli.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_canli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_canli.Location = new System.Drawing.Point(115, 280);
            this.lbl_canli.Name = "lbl_canli";
            this.lbl_canli.Size = new System.Drawing.Size(395, 49);
            this.lbl_canli.TabIndex = 8;
            this.lbl_canli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(785, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 331);
            this.label1.TabIndex = 9;
            // 
            // btn_oyunu_kapat
            // 
            this.btn_oyunu_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunu_kapat.Location = new System.Drawing.Point(516, 280);
            this.btn_oyunu_kapat.Name = "btn_oyunu_kapat";
            this.btn_oyunu_kapat.Size = new System.Drawing.Size(89, 49);
            this.btn_oyunu_kapat.TabIndex = 10;
            this.btn_oyunu_kapat.Text = "Bitir";
            this.btn_oyunu_kapat.UseVisualStyleBackColor = true;
            this.btn_oyunu_kapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_yaris_sonu
            // 
            this.lbl_yaris_sonu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_yaris_sonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yaris_sonu.ForeColor = System.Drawing.Color.Red;
            this.lbl_yaris_sonu.Location = new System.Drawing.Point(77, 159);
            this.lbl_yaris_sonu.Name = "lbl_yaris_sonu";
            this.lbl_yaris_sonu.Size = new System.Drawing.Size(593, 23);
            this.lbl_yaris_sonu.TabIndex = 11;
            // 
            // atyarisi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(810, 357);
            this.Controls.Add(this.lbl_yaris_sonu);
            this.Controls.Add(this.btn_oyunu_kapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_canli);
            this.Controls.Add(this.lbl_bitis);
            this.Controls.Add(this.ucuncu_at);
            this.Controls.Add(this.ikinci_at);
            this.Controls.Add(this.birinci_at);
            this.Controls.Add(this.btn_yarisi_baslat);
            this.Controls.Add(this.aracizgi3);
            this.Controls.Add(this.aracizgi2);
            this.Controls.Add(this.aracizgi1);
            this.Name = "atyarisi_form";
            this.Text = "At Yarışı Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birinci_at)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikinci_at)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuncu_at)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aracizgi1;
        private System.Windows.Forms.Label aracizgi2;
        private System.Windows.Forms.Label aracizgi3;
        private System.Windows.Forms.Button btn_yarisi_baslat;
        private System.Windows.Forms.PictureBox birinci_at;
        private System.Windows.Forms.PictureBox ikinci_at;
        private System.Windows.Forms.PictureBox ucuncu_at;
        private System.Windows.Forms.Timer timer_start;
        private System.Windows.Forms.Label lbl_bitis;
        private System.Windows.Forms.Label lbl_canli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_oyunu_kapat;
        private System.Windows.Forms.Label lbl_yaris_sonu;
    }
}

