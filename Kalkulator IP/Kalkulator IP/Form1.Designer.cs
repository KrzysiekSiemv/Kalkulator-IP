
namespace Kalkulator_IP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hosts = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lastHost = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.firstHost = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.broadcast = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.networkIp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.netMask = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 12);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "192.168.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maska:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 12);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "24";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(186, 227);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Oblicz";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hosts);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lastHost);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.firstHost);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.broadcast);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.networkIp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.netMask);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ipAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obliczenia";
            // 
            // hosts
            // 
            this.hosts.AutoSize = true;
            this.hosts.Location = new System.Drawing.Point(120, 152);
            this.hosts.Name = "hosts";
            this.hosts.Size = new System.Drawing.Size(37, 21);
            this.hosts.TabIndex = 21;
            this.hosts.Text = "254";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 21);
            this.label21.TabIndex = 20;
            this.label21.Text = "Liczba hostów:";
            // 
            // lastHost
            // 
            this.lastHost.AutoSize = true;
            this.lastHost.Location = new System.Drawing.Point(120, 131);
            this.lastHost.Name = "lastHost";
            this.lastHost.Size = new System.Drawing.Size(109, 21);
            this.lastHost.TabIndex = 18;
            this.lastHost.Text = "192.168.0.254";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 21);
            this.label18.TabIndex = 17;
            this.label18.Text = "Ostatni host:";
            // 
            // firstHost
            // 
            this.firstHost.AutoSize = true;
            this.firstHost.Location = new System.Drawing.Point(120, 110);
            this.firstHost.Name = "firstHost";
            this.firstHost.Size = new System.Drawing.Size(91, 21);
            this.firstHost.TabIndex = 15;
            this.firstHost.Text = "192.168.0.1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Pierwszy host:";
            // 
            // broadcast
            // 
            this.broadcast.AutoSize = true;
            this.broadcast.Location = new System.Drawing.Point(120, 89);
            this.broadcast.Name = "broadcast";
            this.broadcast.Size = new System.Drawing.Size(109, 21);
            this.broadcast.TabIndex = 12;
            this.broadcast.Text = "192.168.0.255";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Broadcast:";
            // 
            // networkIp
            // 
            this.networkIp.AutoSize = true;
            this.networkIp.Location = new System.Drawing.Point(120, 68);
            this.networkIp.Name = "networkIp";
            this.networkIp.Size = new System.Drawing.Size(115, 21);
            this.networkIp.TabIndex = 9;
            this.networkIp.Text = "192.168.0.0/24";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sieć:";
            // 
            // netMask
            // 
            this.netMask.AutoSize = true;
            this.netMask.Location = new System.Drawing.Point(120, 47);
            this.netMask.Name = "netMask";
            this.netMask.Size = new System.Drawing.Size(109, 21);
            this.netMask.TabIndex = 4;
            this.netMask.Text = "255.255.255.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Maska:";
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSize = true;
            this.ipAddress.Location = new System.Drawing.Point(120, 26);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(91, 21);
            this.ipAddress.TabIndex = 1;
            this.ipAddress.Text = "192.168.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(287, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(287, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator IP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label hosts;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lastHost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label firstHost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label broadcast;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label networkIp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label netMask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Label label3;
    }
}

