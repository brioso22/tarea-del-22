
namespace _22_7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btguardar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.btAFP = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.la = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtrespuesta = new System.Windows.Forms.Label();
            this.btisss = new System.Windows.Forms.Button();
            this.txtiss = new System.Windows.Forms.TextBox();
            this.buSalNet = new System.Windows.Forms.Button();
            this.txtsalnet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.la)).BeginInit();
            this.SuspendLayout();
            // 
            // btguardar
            // 
            this.btguardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.ForeColor = System.Drawing.Color.DarkRed;
            this.btguardar.Location = new System.Drawing.Point(15, 235);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(104, 37);
            this.btguardar.TabIndex = 0;
            this.btguardar.Text = "GUARDAR";
            this.btguardar.UseVisualStyleBackColor = false;
            this.btguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(111, 116);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(111, 142);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 3;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(111, 168);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(337, 90);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 9;
            // 
            // btAFP
            // 
            this.btAFP.Location = new System.Drawing.Point(256, 93);
            this.btAFP.Name = "btAFP";
            this.btAFP.Size = new System.Drawing.Size(75, 23);
            this.btAFP.TabIndex = 11;
            this.btAFP.Text = "AFP";
            this.btAFP.UseVisualStyleBackColor = true;
            this.btAFP.Click += new System.EventHandler(this.btAFP_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // la
            // 
            this.la.ContainerControl = this;
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.AutoSize = true;
            this.txtrespuesta.Location = new System.Drawing.Point(218, 247);
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(53, 13);
            this.txtrespuesta.TabIndex = 12;
            this.txtrespuesta.Text = "respuesta";
            this.txtrespuesta.Click += new System.EventHandler(this.txtrespuesta_Click);
            // 
            // btisss
            // 
            this.btisss.Location = new System.Drawing.Point(256, 123);
            this.btisss.Name = "btisss";
            this.btisss.Size = new System.Drawing.Size(75, 23);
            this.btisss.TabIndex = 13;
            this.btisss.Text = "ISSS";
            this.btisss.UseVisualStyleBackColor = true;
            this.btisss.Click += new System.EventHandler(this.txtisss_Click);
            // 
            // txtiss
            // 
            this.txtiss.Location = new System.Drawing.Point(337, 126);
            this.txtiss.Name = "txtiss";
            this.txtiss.Size = new System.Drawing.Size(100, 20);
            this.txtiss.TabIndex = 14;
            // 
            // buSalNet
            // 
            this.buSalNet.Location = new System.Drawing.Point(256, 153);
            this.buSalNet.Name = "buSalNet";
            this.buSalNet.Size = new System.Drawing.Size(75, 23);
            this.buSalNet.TabIndex = 15;
            this.buSalNet.Text = "Salario Neto";
            this.buSalNet.UseVisualStyleBackColor = true;
            this.buSalNet.Click += new System.EventHandler(this.buSalNet_Click);
            // 
            // txtsalnet
            // 
            this.txtsalnet.Location = new System.Drawing.Point(337, 155);
            this.txtsalnet.Name = "txtsalnet";
            this.txtsalnet.Size = new System.Drawing.Size(100, 20);
            this.txtsalnet.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(463, 310);
            this.Controls.Add(this.txtsalnet);
            this.Controls.Add(this.buSalNet);
            this.Controls.Add(this.txtiss);
            this.Controls.Add(this.btisss);
            this.Controls.Add(this.txtrespuesta);
            this.Controls.Add(this.btAFP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btguardar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.la)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Button btAFP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider la;
        private System.Windows.Forms.Label txtrespuesta;
        private System.Windows.Forms.TextBox txtiss;
        private System.Windows.Forms.Button btisss;
        private System.Windows.Forms.TextBox txtsalnet;
        private System.Windows.Forms.Button buSalNet;
    }
}

